using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.OrderOfServices;
using System.Linq;
using System.Data.Entity;
using Esr.Core.Repository;

namespace Esr.Module.Funerary.Repository.OrderOfServices
{
    public class OsProductRepo : IFactoryCommand<OsProduct>
    {
        private readonly IFactoryCommand<OsProduct> _efcmd;

        public OsProductRepo(IFactoryConnection efc)
        {
            IFactoryRepository<OsProduct> efr = new DbContext<OsProduct>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(OsProduct eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(OsProduct eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<OsProduct> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public OsProduct FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<OsProduct> Search(Expression<Func<OsProduct, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<OsProduct> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<OsProduct> AsNoTracking(Expression<Func<OsProduct, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<OsProduct> IFactoryCommand<OsProduct>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<OsProduct> IFactoryCommand<OsProduct>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<OsProduct>.SearchOfType<T>(Expression<Func<OsProduct, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}