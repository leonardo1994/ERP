using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.StockItems;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class MarkController
    {
        private MarkApp _MarkApp;
        private IFactoryConnection _connection;

        public MarkController(IFactoryConnection connection)
        {
            _connection = connection;
            _MarkApp = new MarkApp(connection);
        }

        public bool Save(Mark Mark)
        {
            _MarkApp.InsertOrUpdate(Mark);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _MarkApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _MarkApp.Remove(_MarkApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Marks List.
        /// </summary>
        /// <returns>{ c.Id, c.MarkCode, c.MarkDescription }</returns>
        public IList ListMark()
        {
            return _MarkApp.Search()
                .Select(c => new
                { c.Id, c.MarkCode, c.MarkDescription }).ToList();
        }

        public bool Remove(Expression<Func<Mark, bool>> expression)
        {
            _MarkApp.Remove(_MarkApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Mark, bool>> expression)
        {
            return _MarkApp.Search(expression).ToList();
        }

        public Mark FindId(int id)
        {
            return _MarkApp.FindId(id);
        }
    }
}