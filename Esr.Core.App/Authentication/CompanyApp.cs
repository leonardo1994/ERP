using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Authentication;
using Esr.Core.App.FiltersCompanies;
using System.Collections.Generic;

namespace Esr.Core.App.Authentication
{
    public class CompanyApp
    {
        private readonly IFactoryCommand<Company> _epr;
        private readonly FilterCompanyApp _filter;
        private readonly DbTableApp _dbTableApp;

        public CompanyApp(IFactoryConnection efc)
        {
            _epr = new CompanyRepo(efc);
            _filter = new FilterCompanyApp(efc);
            _dbTableApp = new DbTableApp(efc);
        }

        public Company FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool InsertOrUpdate(Company Company)
        {
            if (FindId(Company.Id) == null)
                CreateFilterCompany(Company);
            return _epr.InsertOrUpdate(Company);
        }

        public bool Remove(int id)
        {
            _filter.Remove(_filter.Search(c => c.CompanyLeftId == id || c.CompanyRightId == id).ToList());
            return _epr.Remove(id);
        }

        public bool Remove(IList<Company> cities)
        {
            var ids = cities.Select(c => c.Id);
            _filter.Remove(_filter.Search(c => ids.Contains(c.CompanyLeftId) || ids.Contains(c.CompanyRightId)).ToList());
            return _epr.Remove(cities);
        }

        public IQueryable<Company> Search(Expression<Func<Company, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Company> Search()
        {
            return _epr.Search();
        }

        private void CreateFilterCompany(Company company)
        {
            // Tabelas que por padrão são desconsideradas dos filtros iniciais.
            string[] tablesStandard = { "DbTable", "FilterCompany", "Table", "Company", "Translate", "User" };

            var tables = GlobalUser.Tables;

            foreach (var item in tables)
            {
                _filter.InsertOrUpdate(new Domain.FiltersCompanies.FilterCompany()
                {
                    Active = tablesStandard.Contains(item.TableName) ? false : true,
                    CompanyControlId = GlobalUser.Company?.Id,
                    UserControlId = GlobalUser.User?.Id,
                    DbTableId = item.Id,
                    CompanyLeft = company,
                    CompanyLeftId = company.Id,
                    CompanyRight = company,
                    CompanyRightId = company.Id,
                });
            }
        }
    }
}