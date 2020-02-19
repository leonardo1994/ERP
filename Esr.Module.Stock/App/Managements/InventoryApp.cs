using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Stock.Domain.Movements;
using Esr.Module.Stock.Repository.Moviments;
using System.Collections.Generic;

namespace Esr.Module.Stock.App.Managements
{
    public class InventoryApp
    {
        private readonly IFactoryCommand<Inventory> _epr;

        public InventoryApp(IFactoryConnection efc)
        {
            _epr = new InventoryRepo(efc);
        }

        public Inventory FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Inventory> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Inventory Inventory)
        {
            return _epr.InsertOrUpdate(Inventory);
        }

        public IQueryable<Inventory> Search(Expression<Func<Inventory, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Inventory> Search()
        {
            return _epr.Search();
        }
    }
}