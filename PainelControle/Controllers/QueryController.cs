using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Core.App.Queries;
using Esr.Core.Domain.Queries;
using Esr.Core.App.Authentication;
using Esr.Core.Domain.Authentication;
using System.Linq.Expressions;
using System;

namespace Esr.Module.ControlPainel.Controllers
{
    public class QueryController
    {
        private QueryApp _QueryApp;
        private IFactoryConnection _connection;

        public QueryController(IFactoryConnection connection)
        {
            _connection = connection;
            _QueryApp = new QueryApp(connection);
        }

        public bool Save(Query Query)
        {
            _QueryApp.InsertOrUpdate(Query);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _QueryApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _QueryApp.Remove(_QueryApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de Querys
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Sql }</returns>
        public IList ListQuery()
        {
            return _QueryApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.Sql }).ToList();
        }

        public IList<Query> Search(Expression<Func<Query, bool>> expression)
        {
            return _QueryApp.Search(expression).ToList();
        }

        public Query FindId(int id)
        {
            return _QueryApp.FindId(id);
        }

        public bool Remove(Expression<Func<Query, bool>> expression)
        {
            _QueryApp.Remove(_QueryApp.Search(expression).ToList());
            return _connection.Save();
        }
    }
}