using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.FleetManagement.Domain.Drives;
using System.Linq;

namespace Esr.Module.FleetManagement.Repository.Drives
{
    public class DriveRepo : IFactoryCommand<Drive>
    {
        private readonly IFactoryCommand<Drive> _efcmd;

        public DriveRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Drive> efr = new OdbcSqlServer<Drive>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Drive eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Drive eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Drive> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Drive FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Drive> Search(Expression<Func<Drive, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Drive> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Drive> AsNoTracking(Expression<Func<Drive, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<Drive> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Drive> IFactoryCommand<Drive>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Drive>.SearchOfType<T>(Expression<Func<Drive, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
