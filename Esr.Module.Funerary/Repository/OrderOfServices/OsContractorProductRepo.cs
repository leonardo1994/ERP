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
    public class OsContractorProductRepo : IFactoryCommand<OsContractorProduct>
    {
        private readonly IFactoryCommand<OsContractorProduct> _efcmd;

        public OsContractorProductRepo(IFactoryConnection efc)
        {
            IFactoryRepository<OsContractorProduct> efr = new DbContext<OsContractorProduct>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(OsContractorProduct eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(OsContractorProduct eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<OsContractorProduct> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public OsContractorProduct FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<OsContractorProduct> Search(Expression<Func<OsContractorProduct, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<OsContractorProduct> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<OsContractorProduct> AsNoTracking(Expression<Func<OsContractorProduct, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<OsContractorProduct> IFactoryCommand<OsContractorProduct>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<OsContractorProduct> IFactoryCommand<OsContractorProduct>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<OsContractorProduct>.SearchOfType<T>(Expression<Func<OsContractorProduct, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
