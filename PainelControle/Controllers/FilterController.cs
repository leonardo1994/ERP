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
    public class FilterController
    {
        private FilterApp _FilterApp;
        private IFactoryConnection _connection;

        public FilterController(IFactoryConnection connection)
        {
            _connection = connection;
            _FilterApp = new FilterApp(connection);
        }

        public bool Save(Filter Filter)
        {
            _FilterApp.InsertOrUpdate(Filter);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _FilterApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _FilterApp.Remove(_FilterApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de Filters
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.NameTable, c.NameColumn, c.Display, c.DefaultTypeFilter, Query = c.Query.Code }</returns>
        public IList ListFilter()
        {
            return _FilterApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.NameTable, c.NameColumn, c.Display, c.DefaultTypeFilter, Query = c.Query.Code , c.Integration }).ToList();
        }

        public bool Remove(Expression<Func<Filter, bool>> expression)
        {
            _FilterApp.Remove(_FilterApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Filter, bool>> expression)
        {
            return _FilterApp.Search(expression).ToList();
        }

        public IList FiltersSearch(Expression<Func<Filter, bool>> expression)
        {
            return _FilterApp.Search(expression)
                .Select(c => new
                { c.Id, c.Code, c.NameTable, c.NameColumn, c.Display, c.DefaultTypeFilter, Query = c.Query.Code }).ToList();
        }

        public Filter FindId(int id)
        {
            return _FilterApp.FindId(id);
        }
    }
}