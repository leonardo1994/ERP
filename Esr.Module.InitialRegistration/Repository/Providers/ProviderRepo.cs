using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.InitialRegistration.Domain.Providers;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.InitialRegistration.Repository.Providers
{
    public class ProviderRepo : IFactoryCommand<Provider>
    {
        private readonly IFactoryCommand<Provider> _efcmd;

        public ProviderRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Provider> efr = new DbContext<Provider>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Provider eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Provider eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Provider> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Provider FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Provider> Search(Expression<Func<Provider, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Provider> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Provider> AsNoTracking(Expression<Func<Provider, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Provider> IFactoryCommand<Provider>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<Provider> IFactoryCommand<Provider>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<Provider>.SearchOfType<T>(Expression<Func<Provider, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
