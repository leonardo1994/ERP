using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Repository.StockItems;

namespace Esr.Module.InitialRegistration.App.StockItems
{
    public class StockItemApp
    {
        private readonly IFactoryCommand<StockItem> _epr;

        public StockItemApp(IFactoryConnection efc)
        {
            _epr = new StockItemRepo(efc);
        }

        public StockItem FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<StockItem> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(StockItem StockItem)
        {
            return _epr.InsertOrUpdate(StockItem);
        }

        public IQueryable<StockItem> Search(Expression<Func<StockItem, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<StockItem> Search()
        {
            return _epr.Search();
        }

    }
}