using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Module.InitialRegistration.Repository.RH;
using Esr.Core.Domain.Other;

namespace Esr.Module.InitialRegistration.App.RH
{
    public class TypePositionFunctionApp
    {
        private readonly IFactoryCommand<TypePositionFunction> _epr;

        public TypePositionFunctionApp(IFactoryConnection efc)
        {
            _epr = new TypePositionFunctionRepo(efc);
        }

        public TypePositionFunction FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<TypePositionFunction> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(TypePositionFunction TypePositionFunction)
        {
            return _epr.InsertOrUpdate(TypePositionFunction);
        }

        public IQueryable<TypePositionFunction> Search(Expression<Func<TypePositionFunction, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<TypePositionFunction> Search()
        {
            return _epr.Search();
        }
    }
}