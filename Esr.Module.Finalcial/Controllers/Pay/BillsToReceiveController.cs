using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using System.Linq.Expressions;
using System;
using Esr.Module.Financial.Domain.Pay;
using Esr.Module.Financial.App.Pay;

namespace Esr.Module.Financial.Controllers.Pay
{
    public class BillsToPayController
    {
        private BillsToPayApp _BillsToPayApp;
        private IFactoryConnection _connection;

        public BillsToPayController(IFactoryConnection connection)
        {
            _connection = connection;
            _BillsToPayApp = new BillsToPayApp(connection);
        }

        public bool Save(BillsToPay BillsToPay)
        {
            _BillsToPayApp.InsertOrUpdate(BillsToPay);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _BillsToPayApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _BillsToPayApp.Remove(_BillsToPayApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// BillsToPays List
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.BillsToPayName, c.Cnh }</returns>
        public IList ListBillsToPay()
        {
            return _BillsToPayApp.Search()
                .Select(c => new
                { c.Id, c.Document, c.Series, c.DateOfIssure }).ToList();
        }

        public bool Remove(Expression<Func<BillsToPay, bool>> expression)
        {
            _BillsToPayApp.Remove(_BillsToPayApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<BillsToPay, bool>> expression)
        {
            return _BillsToPayApp.Search(expression).ToList();
        }

        public BillsToPay FindId(int id)
        {
            return _BillsToPayApp.FindId(id);
        }
    }
}