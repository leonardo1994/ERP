using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.OrderOfServices;
using System.Data.Entity;
using System.Linq;
using Esr.Core.Repository;

namespace Esr.Module.Funerary.Repository.OrderOfServices
{
    public class OsServiceRepo : IFactoryCommand<OsService>
    {
        private readonly IFactoryCommand<OsService> _efcmd;

        public OsServiceRepo(IFactoryConnection efc)
        {
            IFactoryRepository<OsService> efr = new DbContext<OsService>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(OsService eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(OsService eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<OsService> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public OsService FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<OsService> Search(Expression<Func<OsService, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<OsService> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<OsService> AsNoTracking(Expression<Func<OsService, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }


        IList<OsService> IFactoryCommand<OsService>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<OsService> IFactoryCommand<OsService>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<OsService>.SearchOfType<T>(Expression<Func<OsService, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
