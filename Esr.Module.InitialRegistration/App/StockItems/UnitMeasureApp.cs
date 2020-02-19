using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Repository.StockItems;

namespace Esr.Module.InitialRegistration.App.UnitMeasures
{
    public class UnitMeasureApp
    {
        private readonly IFactoryCommand<UnitMeasure> _epr;

        public UnitMeasureApp(IFactoryConnection efc)
        {
            _epr = new UnitMeasureRepo(efc);
        }

        public UnitMeasure FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<UnitMeasure> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(UnitMeasure UnitMeasure)
        {
            return _epr.InsertOrUpdate(UnitMeasure);
        }

        public IQueryable<UnitMeasure> Search(Expression<Func<UnitMeasure, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<UnitMeasure> Search()
        {
            return _epr.Search();
        }
    }
}