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
    public class InactiveFiltersController
    {
        private InactiveFiltersApp _InactiveFiltersApp;
        private IFactoryConnection _connection;

        public InactiveFiltersController(IFactoryConnection connection)
        {
            _connection = connection;
            _InactiveFiltersApp = new InactiveFiltersApp(connection);
        }

        public bool Save(InactiveFilters InactiveFilters)
        {
            _InactiveFiltersApp.InsertOrUpdate(InactiveFilters);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _InactiveFiltersApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _InactiveFiltersApp.Remove(_InactiveFiltersApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<InactiveFilters, bool>> expression)
        {
            return _InactiveFiltersApp.Search(expression).ToList();
        }

        /// <summary>
        /// Lista de Filtros Inativos
        /// </summary>
        /// <returns>{ c.Id, c.Filter.Code, c.TypeFilter }</returns>
        public IList ListInactiveFilters()
        {
            return _InactiveFiltersApp.Search()
                .Select(c => new
                { c.Id, c.Filter.Code, c.TypeFilter }).ToList();
        }

        public IList InactiveFiltersSearch(Expression<Func<InactiveFilters, bool>> expression)
        {
            return _InactiveFiltersApp.Search(expression)
                .Select(c => new
                { c.Id, c.Filter.Code, c.TypeFilter }).ToList();
        }

        public InactiveFilters FindId(int id)
        {
            return _InactiveFiltersApp.FindId(id);
        }

        public bool Remove(Expression<Func<InactiveFilters, bool>> expression)
        {
            _InactiveFiltersApp.Remove(_InactiveFiltersApp.Search(expression).ToList());
            return _connection.Save();
        }        
    }
}