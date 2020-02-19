using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Queries;
using System.Collections.Generic;

namespace Esr.Core.App.Queries
{
    public class QueryApp
    {
        private readonly IFactoryCommand<Query> _epr;

        public QueryApp(IFactoryConnection efc)
        {
            _epr = new QueryRepo(efc);
        }

        public Query FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Query> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Query Query)
        {
            return _epr.InsertOrUpdate(Query);
        }

        public IQueryable<Query> Search(Expression<Func<Query, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Query> Search()
        {
            return _epr.Search();
        }
    }
}