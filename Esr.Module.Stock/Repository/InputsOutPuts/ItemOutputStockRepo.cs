using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using System.Data.Entity;
using System.Linq;
using Esr.Module.Stock.Domain.Movements;

namespace Esr.Module.Stock.Repository.InputsOutPuts
{
    public class ItemOutputStockRepo : IFactoryCommand<ItemOutputStock>
    {
        private readonly IFactoryCommand<ItemOutputStock> _efcmd;

        public ItemOutputStockRepo(IFactoryConnection efc)
        {
            IFactoryRepository<ItemOutputStock> efr = new DbContext<ItemOutputStock>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(ItemOutputStock eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(ItemOutputStock eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<ItemOutputStock> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public ItemOutputStock FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<ItemOutputStock> Search(Expression<Func<ItemOutputStock, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<ItemOutputStock> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<ItemOutputStock> AsNoTracking(Expression<Func<ItemOutputStock, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<ItemOutputStock> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<ItemOutputStock> IFactoryCommand<ItemOutputStock>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<ItemOutputStock>.SearchOfType<T>(Expression<Func<ItemOutputStock, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
