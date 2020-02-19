using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Module.InitialRegistration.Repository.RH;

namespace Esr.Module.InitialRegistration.App.RH
{
    public class FunctionApp
    {
        private readonly IFactoryCommand<Function> _epr;

        public FunctionApp(IFactoryConnection efc)
        {
            _epr = new FunctionRepo(efc);
        }

        public Function FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Function> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Function Function)
        {
            return _epr.InsertOrUpdate(Function);
        }

        public IQueryable<Function> Search(Expression<Func<Function, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Function> Search()
        {
            return _epr.Search();
        }
    }
}