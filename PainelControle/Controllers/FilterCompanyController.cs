using Esr.Core.App.FiltersCompanies;
using Esr.Core.Domain.FiltersCompanies;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Expressions;

namespace Esr.Module.ControlPainel.Controllers
{
    public class FilterCompanyController
    {
        private FilterCompanyApp _FilterCompanyApp;
        private IFactoryConnection _connection;

        public FilterCompanyController(IFactoryConnection connection)
        {
            _connection = connection;
            _FilterCompanyApp = new FilterCompanyApp(connection);
        }

        public bool Save(FilterCompany FilterCompany)
        {
            _FilterCompanyApp.InsertOrUpdate(FilterCompany);
            return _connection.Save();
        }

        public bool Remove(Expression<Func<FilterCompany, bool>> expression)
        {
            _FilterCompanyApp.Remove(_FilterCompanyApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList<FilterCompany> Search(Expression<Func<FilterCompany, bool>> expression)
        {
            return _FilterCompanyApp.Search(expression).ToList();
        }

        public bool RemoveId(int id)
        {
            _FilterCompanyApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _FilterCompanyApp.Remove(_FilterCompanyApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        public bool RemoveList(Expression<Func<FilterCompany, bool>> expression)
        {
            _FilterCompanyApp.Remove(_FilterCompanyApp.Search(expression).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de filtros de empresas.
        /// </summary>
        /// <returns>{ c.Id, Principal = c.CompanyLeft.PersonName, Relacionada = c.CompanyRight.PersonName, c.DbTable.TableName, c.Active }</returns>
        public IList ListFilterCompany()
        {
            return _FilterCompanyApp.Search()
                .Select(c => new
                { c.Id, Principal = c.CompanyLeft.PersonName, Relacionada = c.CompanyRight.PersonName, c.DbTable.TableName, c.Active , c.Integration }).ToList();
        }

        public FilterCompany FindId(int id)
        {
            return _FilterCompanyApp.FindId(id);
        }
    }
}