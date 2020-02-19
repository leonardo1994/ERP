using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Stock.Domain.Movements;
using Esr.Module.Stock.Repository.InputsOutPuts;
using System.Collections.Generic;

namespace Esr.Module.Stock.App.InputsOutputs
{
    public class InputStockApp
    {
        private readonly IFactoryCommand<InputStock> _epr;

        public InputStockApp(IFactoryConnection efc)
        {
            _epr = new InputStockRepo(efc);
        }

        public InputStock FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<InputStock> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(InputStock InputStock)
        {
            return _epr.InsertOrUpdate(InputStock);
        }

        public IQueryable<InputStock> Search(Expression<Func<InputStock, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<InputStock> Search()
        {
            return _epr.Search();
        }
    }
}