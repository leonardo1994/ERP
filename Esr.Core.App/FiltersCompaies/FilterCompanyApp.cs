using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Domain.FiltersCompanies;
using Esr.Core.Repository.FiltersCompanies;

namespace Esr.Core.App.FiltersCompanies
{
    public class FilterCompanyApp
    {
        private readonly IFactoryCommand<FilterCompany> _epr;

        public FilterCompanyApp(IFactoryConnection efc)
        {
            _epr = new FilterCompanyRepo(efc);
        }

        public FilterCompany FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<FilterCompany> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(FilterCompany FilterCompany)
        {
            return _epr.InsertOrUpdate(FilterCompany);
        }

        public IQueryable<FilterCompany> Search(Expression<Func<FilterCompany, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<FilterCompany> Search()
        {
            return _epr.Search();
        }
    }
}