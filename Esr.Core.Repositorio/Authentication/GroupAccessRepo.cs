using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Authentication
{
    public class GroupAccessRepo : IFactoryCommand<GroupAccess>
    {
        private readonly IFactoryCommand<GroupAccess> _efcmd;

        public GroupAccessRepo(IFactoryConnection efc)
        {
            IFactoryRepository<GroupAccess> efr = new DbContext<GroupAccess>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(GroupAccess eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(GroupAccess eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<GroupAccess> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public GroupAccess FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<GroupAccess> Search(Expression<Func<GroupAccess, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<GroupAccess> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<GroupAccess> AsNoTracking(Expression<Func<GroupAccess, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<GroupAccess> IFactoryCommand<GroupAccess>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<GroupAccess> IFactoryCommand<GroupAccess>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<GroupAccess>.SearchOfType<T>(Expression<Func<GroupAccess, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
