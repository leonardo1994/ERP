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
    public class TypeServiceRepo : IFactoryCommand<TypeService>
    {
        private readonly IFactoryCommand<TypeService> _efcmd;

        public TypeServiceRepo(IFactoryConnection efc)
        {
            IFactoryRepository<TypeService> efr = new DbContext<TypeService>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(TypeService eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(TypeService eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<TypeService> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public TypeService FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<TypeService> Search(Expression<Func<TypeService, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<TypeService> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<TypeService> AsNoTracking(Expression<Func<TypeService, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<TypeService> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IList<TypeService> IFactoryCommand<TypeService>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<TypeService> IFactoryCommand<TypeService>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<TypeService>.SearchOfType<T>(Expression<Func<TypeService, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
