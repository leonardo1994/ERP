using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Repository.StockItems;

namespace Esr.Module.InitialRegistration.App.StockItems
{
    public class CompositionApp
    {
        private readonly IFactoryCommand<Composition> _epr;

        public CompositionApp(IFactoryConnection efc)
        {
            _epr = new CompositionRepo(efc);
        }

        public Composition FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Composition> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Composition Composition)
        {
            return _epr.InsertOrUpdate(Composition);
        }

        public IQueryable<Composition> Search(Expression<Func<Composition, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Composition> Search()
        {
            return _epr.Search();
        }
    }
}