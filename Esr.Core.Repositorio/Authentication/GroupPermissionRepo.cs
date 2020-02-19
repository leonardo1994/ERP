using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;

namespace Esr.Core.Repository.Authentication
{
    public class GroupPermissionRepo : IFactoryCommand<GroupPermission>
    {
        private readonly IFactoryCommand<GroupPermission> _efcmd;

        public GroupPermissionRepo(IFactoryConnection efc)
        {
            IFactoryRepository<GroupPermission> efr = new DbContext<GroupPermission>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(GroupPermission eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(GroupPermission eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<GroupPermission> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public GroupPermission FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<GroupPermission> Search(Expression<Func<GroupPermission, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<GroupPermission> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<GroupPermission> AsNoTracking(Expression<Func<GroupPermission, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<GroupPermission> IFactoryCommand<GroupPermission>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<GroupPermission> IFactoryCommand<GroupPermission>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<GroupPermission>.SearchOfType<T>(Expression<Func<GroupPermission, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
