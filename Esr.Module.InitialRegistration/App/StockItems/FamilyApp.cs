using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Repository.StockItems;
using Esr.Core.Domain.Other;

namespace Esr.Module.InitialRegistration.App.StockItems
{
    public class FamilyApp
    {
        private readonly IFactoryCommand<Family> _epr;

        public FamilyApp(IFactoryConnection efc)
        {
            _epr = new FamilyRepo(efc);
        }

        public Family FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Family> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Family Family)
        {
            return _epr.InsertOrUpdate(Family);
        }

        public IQueryable<Family> Search(Expression<Func<Family, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Family> Search()
        {
            return _epr.Search();
        }
    }
}