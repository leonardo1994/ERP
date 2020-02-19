using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Repository.ItemSupplierss;
using Esr.Core.Domain.Other;

namespace Esr.Module.InitialRegistration.App.ItemSupplierss
{
    public class ItemSuppliersApp
    {
        private readonly IFactoryCommand<ItemSuppliers> _epr;

        public ItemSuppliersApp(IFactoryConnection efc)
        {
            _epr = new ItemSuppliersRepo(efc);
        }

        public ItemSuppliers FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<ItemSuppliers> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(ItemSuppliers ItemSuppliers)
        {
            return _epr.InsertOrUpdate(ItemSuppliers);
        }

        public IQueryable<ItemSuppliers> Search(Expression<Func<ItemSuppliers, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<ItemSuppliers> Search()
        {
            return _epr.Search();
        }
    }
}