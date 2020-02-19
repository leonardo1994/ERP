using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Repository.StockItems;

namespace Esr.Module.InitialRegistration.App.StockItems
{
    public class FeaturedNcmApp
    {
        private readonly IFactoryCommand<FeaturedNcm> _epr;

        public FeaturedNcmApp(IFactoryConnection efc)
        {
            _epr = new FeaturedNcmRepo(efc);
        }

        public FeaturedNcm FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<FeaturedNcm> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(FeaturedNcm FeaturedNcm)
        {
            return _epr.InsertOrUpdate(FeaturedNcm);
        }

        public IQueryable<FeaturedNcm> Search(Expression<Func<FeaturedNcm, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<FeaturedNcm> Search()
        {
            return _epr.Search();
        }
    }
}