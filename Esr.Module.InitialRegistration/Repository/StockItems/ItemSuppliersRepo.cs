using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.InitialRegistration.Repository.ItemSupplierss
{
    public class ItemSuppliersRepo : IFactoryCommand<ItemSuppliers>
    {
        private readonly IFactoryCommand<ItemSuppliers> _efcmd;

        public ItemSuppliersRepo(IFactoryConnection efc)
        {
            IFactoryRepository<ItemSuppliers> efr = new DbContext<ItemSuppliers>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(ItemSuppliers eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(ItemSuppliers eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<ItemSuppliers> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public ItemSuppliers FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<ItemSuppliers> Search(Expression<Func<ItemSuppliers, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<ItemSuppliers> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<ItemSuppliers> AsNoTracking(Expression<Func<ItemSuppliers, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<ItemSuppliers> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IList<ItemSuppliers> IFactoryCommand<ItemSuppliers>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<ItemSuppliers> IFactoryCommand<ItemSuppliers>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<ItemSuppliers>.SearchOfType<T>(Expression<Func<ItemSuppliers, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
