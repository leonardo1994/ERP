using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Module.InitialRegistration.Repository.RH;

namespace Esr.Module.InitialRegistration.App.RH
{
    public class NaturePositionFunctionApp
    {
        private readonly IFactoryCommand<NaturePositionFunction> _epr;

        public NaturePositionFunctionApp(IFactoryConnection efc)
        {
            _epr = new NaturePositionFunctionRepo(efc);
        }

        public NaturePositionFunction FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<NaturePositionFunction> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(NaturePositionFunction NaturePositionFunction)
        {
            return _epr.InsertOrUpdate(NaturePositionFunction);
        }

        public IQueryable<NaturePositionFunction> Search(Expression<Func<NaturePositionFunction, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<NaturePositionFunction> Search()
        {
            return _epr.Search();
        }
    }
}