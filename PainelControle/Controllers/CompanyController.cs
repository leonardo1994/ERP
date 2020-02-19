using Esr.Core.Domain.Authentication;
using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.App.Authentication;
using System.Collections;
using System.Linq.Expressions;
using System;
using Esr.Core.App.FiltersCompanies;
using System.Data.Entity;

namespace Esr.Module.ControlPainel.Controllers
{
    public class CompanyController
    {
        private CompanyApp _CompanyApp;

        private IFactoryConnection _connection;

        public CompanyController(IFactoryConnection connection)
        {
            _connection = connection;
            _CompanyApp = new CompanyApp(connection);
        }

        public bool Save(Company Company)
        {
            _CompanyApp.InsertOrUpdate(Company);
            return _connection.Save();
        }

        public bool Remove(Expression<Func<Company, bool>> expression)
        {
            var companies = _CompanyApp.Search(expression).Include(c => c.FiltersCompanies).ToList();
            _CompanyApp.Remove(companies);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _CompanyApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _CompanyApp.Remove(_CompanyApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de empresas.
        /// </summary>
        /// <returns>{ c.Id, c.PersonName, c.Cnpj, c.City.CityName, c.State.StateName, c.Country.CountryName }</returns>
        public IList ListCompany()
        {
            return _CompanyApp.Search()
                .Select(c => new
                { c.Id, c.PersonName, c.Cnpj, c.City.CityName, c.State.StateName, c.Country.CountryName, c.Integration }).ToList();
        }

        public IList Search(Expression<Func<Company, bool>> expression)
        {
            return _CompanyApp.Search(expression).ToList();
        }

        public IList CompaniesSearch(Expression<Func<Company, bool>> expression)
        {
            return _CompanyApp.Search(expression)
                .Select(c => new { c.Id, c.PersonName, c.Cnpj, c.Integration }).ToList();
        }

        public Company FindId(int id)
        {
            return _CompanyApp.FindId(id);
        }
    }
}