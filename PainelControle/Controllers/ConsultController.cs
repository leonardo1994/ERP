using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Core.App.Queries;
using Esr.Core.Domain.Queries;
using System.Linq.Expressions;
using System;

namespace Esr.Module.ControlPainel.Controllers
{
    public class ConsultController
    {
        private ConsultApp _ConsultApp;
        private IFactoryConnection _connection;

        public ConsultController(IFactoryConnection connection)
        {
            _connection = connection;
            _ConsultApp = new ConsultApp(connection);
        }

        public bool Save(Consult Consult)
        {
            _ConsultApp.InsertOrUpdate(Consult);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ConsultApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ConsultApp.Remove(_ConsultApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de Consultas
        /// </summary>
        /// <returns>{ c.Id, c.Code, Query = c.Query.Code, c.Display }</returns>
        public IList ListConsult()
        {
            return _ConsultApp.Search()
                .Select(c => new
                { c.Id, c.Code, Query = c.Query.Code, c.Display , c.Integration }).ToList();
        }

        public bool Remove(Expression<Func<Consult, bool>> expression)
        {
            _ConsultApp.Remove(_ConsultApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Consult, bool>> expression)
        {
            return _ConsultApp.Search(expression).ToList();
        }

        public IList ConsultSearch(Expression<Func<Consult, bool>> expression)
        {
            return _ConsultApp.Search(expression)
                .Select(c => new
                { c.Id, c.Code, Query = c.Query.Code, c.Display , c.Integration }).ToList();
        }

        public Consult FindId(int id)
        {
            return _ConsultApp.FindId(id);
        }
    }
}
