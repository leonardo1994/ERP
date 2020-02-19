using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.GroupAttendants;
using System.Data.Entity;
using System.Linq;
using Esr.Core.Repository;

namespace Esr.Module.Funerary.Repository.GroupAttendants
{
    public class GroupAttendantRepo : IFactoryCommand<GroupAttendant>
    {
        private readonly IFactoryCommand<GroupAttendant> _efcmd;

        public GroupAttendantRepo(IFactoryConnection efc)
        {
            IFactoryRepository<GroupAttendant> efr = new DbContext<GroupAttendant>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(GroupAttendant eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(GroupAttendant eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<GroupAttendant> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public GroupAttendant FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<GroupAttendant> Search(Expression<Func<GroupAttendant, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<GroupAttendant> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<GroupAttendant> AsNoTracking(Expression<Func<GroupAttendant, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<GroupAttendant> IFactoryCommand<GroupAttendant>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<GroupAttendant> IFactoryCommand<GroupAttendant>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<GroupAttendant>.SearchOfType<T>(Expression<Func<GroupAttendant, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
