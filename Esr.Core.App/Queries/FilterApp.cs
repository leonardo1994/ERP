using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Queries;


namespace Esr.Core.App.Queries
{
    public class FilterApp
    {
        private readonly IFactoryCommand<Filter> _epr;

        public FilterApp(IFactoryConnection efc)
        {
            _epr = new FilterRepo(efc);
        }

        public Filter FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Filter> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Filter Filter)
        {
            return _epr.InsertOrUpdate(Filter);
        }

        public IQueryable<Filter> Search(Expression<Func<Filter, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Filter> Search()
        {
            return _epr.Search();
        }
    }
}