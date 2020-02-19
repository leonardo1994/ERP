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
    public class StockItemRepo : IFactoryCommand<StockItem>
    {
        private readonly IFactoryCommand<StockItem> _efcmd;

        public StockItemRepo(IFactoryConnection efc)
        {
            IFactoryRepository<StockItem> efr = new DbContext<StockItem>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(StockItem eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(StockItem eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<StockItem> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public StockItem FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<StockItem> Search(Expression<Func<StockItem, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<StockItem> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<StockItem> AsNoTracking(Expression<Func<StockItem, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<StockItem> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IList<StockItem> IFactoryCommand<StockItem>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<StockItem> IFactoryCommand<StockItem>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<StockItem>.SearchOfType<T>(Expression<Func<StockItem, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
