using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.InitialRegistration.Domain.RH;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.InitialRegistration.Repository.RH
{
    public class OfficeRepo : IFactoryCommand<Office>
    {
        private readonly IFactoryCommand<Office> _efcmd;

        public OfficeRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Office> efr = new DbContext<Office>();
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Office eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Office eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Office> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Office FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Office> Search(Expression<Func<Office, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Office> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Office> AsNoTracking(Expression<Func<Office, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<Office> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Office> IFactoryCommand<Office>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<Office>.SearchOfType<T>(Expression<Func<Office, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
