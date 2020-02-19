using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Module.InitialRegistration.Repository.RH;
using System.Collections.Generic;

namespace Esr.Module.InitialRegistration.App.RH
{
    public class CboApp
    {
        private readonly IFactoryCommand<Cbo> _epr;

        public CboApp(IFactoryConnection efc)
        {
            _epr = new CboRepo(efc);
        }

        public Cbo FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Cbo> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Cbo Cbo)
        {
            return _epr.InsertOrUpdate(Cbo);
        }

        public IQueryable<Cbo> Search(Expression<Func<Cbo, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Cbo> Search()
        {
            return _epr.Search();
        }
    }
}