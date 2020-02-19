using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.Services;
using Esr.Module.InitialRegistration.Repository.Services;
using System.Collections.Generic;

namespace Esr.Module.InitialRegistration.App.Services
{
    public class ServiceApp
    {
        private readonly IFactoryCommand<Service> _epr;

        public ServiceApp(IFactoryConnection efc)
        {
            _epr = new ServiceRepo(efc);
        }

        public Service FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Service> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Service Service)
        {
            return _epr.InsertOrUpdate(Service);
        }

        public IQueryable<Service> Search(Expression<Func<Service, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Service> Search()
        {
            return _epr.Search();
        }
    }
}