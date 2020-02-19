using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using System.Linq.Expressions;
using System;
using Esr.Module.Financial.App.Receive;
using Esr.Module.Financial.Domain.Receive;

namespace Esr.Module.Financial.Controllers.Receive
{
    public class BillsToReceiveController
    {
        private BillsToReceiveApp _BillsToReceiveApp;
        private IFactoryConnection _connection;

        public BillsToReceiveController(IFactoryConnection connection)
        {
            _connection = connection;
            _BillsToReceiveApp = new BillsToReceiveApp(connection);
        }

        public bool Save(BillsToReceive BillsToReceive)
        {
            _BillsToReceiveApp.InsertOrUpdate(BillsToReceive);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _BillsToReceiveApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _BillsToReceiveApp.Remove(_BillsToReceiveApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// BillsToReceives List
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.BillsToReceiveName, c.Cnh }</returns>
        public IList ListBillsToReceive()
        {
            return _BillsToReceiveApp.Search()
                .Select(c => new
                { c.Id, c.Document, c.Series, c.DateOfIssure }).ToList();
        }

        public bool Remove(Expression<Func<BillsToReceive, bool>> expression)
        {
            _BillsToReceiveApp.Remove(_BillsToReceiveApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<BillsToReceive, bool>> expression)
        {
            return _BillsToReceiveApp.Search(expression).ToList();
        }

        public BillsToReceive FindId(int id)
        {
            return _BillsToReceiveApp.FindId(id);
        }
    }
}