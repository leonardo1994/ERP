using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.Services;
using Esr.Module.InitialRegistration.Repository.Services;


namespace Esr.Module.InitialRegistration.App.Services
{
    public class TypeServiceApp
    {
        private readonly IFactoryCommand<TypeService> _epr;

        public TypeServiceApp(IFactoryConnection efc)
        {
            _epr = new TypeServiceRepo(efc);
        }

        public TypeService FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<TypeService> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(TypeService TypeService)
        {
            return _epr.InsertOrUpdate(TypeService);
        }

        public IQueryable<TypeService> Search(Expression<Func<TypeService, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<TypeService> Search()
        {
            return _epr.Search();
        }
    }
}