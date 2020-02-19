using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.InitialRegistration.Domain.Services;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.InitialRegistration.Repository.Services
{
    public class ServiceRepo : IFactoryCommand<Service>
    {
        private readonly IFactoryCommand<Service> _efcmd;

        public ServiceRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Service> efr = new DbContext<Service>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Service eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Service eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Service> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Service FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Service> Search(Expression<Func<Service, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Service> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Service> AsNoTracking(Expression<Func<Service, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<Service> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IList<Service> IFactoryCommand<Service>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<Service> IFactoryCommand<Service>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<Service>.SearchOfType<T>(Expression<Func<Service, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
