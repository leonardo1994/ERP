using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Authentication
{
    public class GroupUserRepo : IFactoryCommand<GroupUser>
    {
        private readonly IFactoryCommand<GroupUser> _efcmd;

        public GroupUserRepo(IFactoryConnection efc)
        {
            IFactoryRepository<GroupUser> efr = new DbContext<GroupUser>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(GroupUser eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(GroupUser eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<GroupUser> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public GroupUser FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<GroupUser> Search(Expression<Func<GroupUser, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<GroupUser> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<GroupUser> AsNoTracking(Expression<Func<GroupUser, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<GroupUser> IFactoryCommand<GroupUser>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<GroupUser> IFactoryCommand<GroupUser>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<GroupUser>.SearchOfType<T>(Expression<Func<GroupUser, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
