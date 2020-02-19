using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Queries;
using Esr.Core.Domain.Other;

namespace Esr.Core.App.Queries
{
    public class InactiveFiltersApp
    {
        private readonly IFactoryCommand<InactiveFilters> _epr;

        public InactiveFiltersApp(IFactoryConnection efc)
        {
            _epr = new InactiveFiltersRepo(efc);
        }

        public InactiveFilters FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<InactiveFilters> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(InactiveFilters InactiveFilters)
        {
            return _epr.InsertOrUpdate(InactiveFilters);
        }

        public IQueryable<InactiveFilters> Search(Expression<Func<InactiveFilters, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<InactiveFilters> Search()
        {
            return _epr.Search();
        }
    }
}