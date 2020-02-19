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
    public class ItemInputStockRepo : IFactoryCommand<ItemInputStock>
    {
        private readonly IFactoryCommand<ItemInputStock> _efcmd;

        public ItemInputStockRepo(IFactoryConnection efc)
        {
            IFactoryRepository<ItemInputStock> efr = new DbContext<ItemInputStock>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(ItemInputStock eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(ItemInputStock eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<ItemInputStock> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public ItemInputStock FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<ItemInputStock> Search(Expression<Func<ItemInputStock, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<ItemInputStock> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<ItemInputStock> AsNoTracking(Expression<Func<ItemInputStock, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<ItemInputStock> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IList<ItemInputStock> IFactoryCommand<ItemInputStock>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<ItemInputStock> IFactoryCommand<ItemInputStock>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<ItemInputStock>.SearchOfType<T>(Expression<Func<ItemInputStock, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
