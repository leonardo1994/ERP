using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using System.Data.Entity;
using System.Linq;
using Esr.Module.Stock.Domain.Movements;

namespace Esr.Module.Stock.Repository.Moviments
{
    public class InventoryRepo : IFactoryCommand<Inventory>
    {
        private readonly IFactoryCommand<Inventory> _efcmd;

        public InventoryRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Inventory> efr = new DbContext<Inventory>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Inventory eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Inventory eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Inventory> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Inventory FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Inventory> Search(Expression<Func<Inventory, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Inventory> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Inventory> AsNoTracking(Expression<Func<Inventory, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<Inventory> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Inventory> IFactoryCommand<Inventory>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Inventory>.SearchOfType<T>(Expression<Func<Inventory, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
