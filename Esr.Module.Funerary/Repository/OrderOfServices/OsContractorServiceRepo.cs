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
    public class OsContractorServiceRepo : IFactoryCommand<OsContractorService>
    {
        private readonly IFactoryCommand<OsContractorService> _efcmd;

        public OsContractorServiceRepo(IFactoryConnection efc)
        {
            IFactoryRepository<OsContractorService> efr = new DbContext<OsContractorService>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(OsContractorService eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(OsContractorService eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<OsContractorService> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public OsContractorService FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<OsContractorService> Search(Expression<Func<OsContractorService, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<OsContractorService> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<OsContractorService> AsNoTracking(Expression<Func<OsContractorService, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<OsContractorService> IFactoryCommand<OsContractorService>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<OsContractorService> IFactoryCommand<OsContractorService>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<OsContractorService>.SearchOfType<T>(Expression<Func<OsContractorService, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
