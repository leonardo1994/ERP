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
    public class AttendantRepo : IFactoryCommand<Attendant>
    {
        private readonly IFactoryCommand<Attendant> _efcmd;

        public AttendantRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Attendant> efr = new DbContext<Attendant>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Attendant eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Attendant eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Attendant> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Attendant FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Attendant> Search(Expression<Func<Attendant, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Attendant> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Attendant> AsNoTracking(Expression<Func<Attendant, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Attendant> IFactoryCommand<Attendant>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Attendant> IFactoryCommand<Attendant>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Attendant>.SearchOfType<T>(Expression<Func<Attendant, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
