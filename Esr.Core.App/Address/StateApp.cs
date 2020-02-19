using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Address;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Address;
using System.Collections.Generic;

namespace Esr.Core.App.Address
{
    public class StateApp
    {
        private readonly IFactoryCommand<State> _epr;

        public StateApp(IFactoryConnection efc)
        {
            _epr = new StateRepo(efc);
        }

        public State FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<State> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(State State)
        {
            return _epr.InsertOrUpdate(State);
        }

        public IQueryable<State> Search(Expression<Func<State, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<State> Search()
        {
            return _epr.Search();
        }
    }
}