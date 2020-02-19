using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Repository.Providers;
using Esr.Module.InitialRegistration.Domain.Providers;

namespace Esr.Module.InitialRegistration.App.Providers
{
    public class ProviderApp
    {
        private readonly IFactoryCommand<Provider> _epr;

        public ProviderApp(IFactoryConnection efc)
        {
            _epr = new ProviderRepo(efc);
        }

        public Provider FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Provider> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Provider Provider)
        {
            return _epr.InsertOrUpdate(Provider);
        }

        public IQueryable<Provider> Search(Expression<Func<Provider, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Provider> Search()
        {
            return _epr.Search();
        }
    }
}