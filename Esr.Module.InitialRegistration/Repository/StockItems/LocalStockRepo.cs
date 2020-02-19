using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.InitialRegistration.Repository.StockItems
{
    public class LocalStockRepo : IFactoryCommand<LocalStock>
    {
        private readonly IFactoryCommand<LocalStock> _efcmd;

        public LocalStockRepo(IFactoryConnection efc)
        {
            IFactoryRepository<LocalStock> efr = new DbContext<LocalStock>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(LocalStock eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(LocalStock eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<LocalStock> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public LocalStock FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<LocalStock> Search(Expression<Func<LocalStock, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<LocalStock> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<LocalStock> AsNoTracking(Expression<Func<LocalStock, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<LocalStock> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IList<LocalStock> IFactoryCommand<LocalStock>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<LocalStock> IFactoryCommand<LocalStock>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<LocalStock>.SearchOfType<T>(Expression<Func<LocalStock, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
