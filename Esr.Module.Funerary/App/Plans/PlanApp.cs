using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.Plans;
using Esr.Module.Funerary.Repository.Plans;

namespace Esr.Module.Funerary.App.Plans
{
    public class PlanApp
    {
        private readonly IFactoryCommand<Plan> _epr;

        public PlanApp(IFactoryConnection efc)
        {
            _epr = new PlanRepo(efc);
        }

        public Plan FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Plan> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Plan Plan)
        {
            return _epr.InsertOrUpdate(Plan);
        }

        public IQueryable<Plan> Search(Expression<Func<Plan, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Plan> Search()
        {
            return _epr.Search();
        }
    }
}