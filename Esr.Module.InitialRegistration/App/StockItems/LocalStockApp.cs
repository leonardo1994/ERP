using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Repository.StockItems;
using System.Collections.Generic;

namespace Esr.Module.InitialRegistration.App.StockItems
{
    public class LocalStockApp
    {
        private readonly IFactoryCommand<LocalStock> _epr;

        public LocalStockApp(IFactoryConnection efc)
        {
            _epr = new LocalStockRepo(efc);
        }

        public LocalStock FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<LocalStock> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(LocalStock LocalStock)
        {
            return _epr.InsertOrUpdate(LocalStock);
        }

        public IQueryable<LocalStock> Search(Expression<Func<LocalStock, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<LocalStock> Search()
        {
            return _epr.Search();
        }
    }
}