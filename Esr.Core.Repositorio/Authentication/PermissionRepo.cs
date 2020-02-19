using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Authentication
{
    public class PermissionRepo : IFactoryCommand<Permission>
    {
        private readonly IFactoryCommand<Permission> _efcmd;

        public PermissionRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Permission> efr = new DbContext<Permission>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Permission eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Permission eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Permission> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Permission FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Permission> Search(Expression<Func<Permission, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Permission> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Permission> AsNoTracking(Expression<Func<Permission, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Permission> IFactoryCommand<Permission>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Permission> IFactoryCommand<Permission>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Permission>.SearchOfType<T>(Expression<Func<Permission, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
