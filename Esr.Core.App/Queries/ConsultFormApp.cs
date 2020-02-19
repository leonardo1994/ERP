using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Queries;

namespace Esr.Core.App.Queries
{
    public class ConsultFormApp
    {
        private readonly IFactoryCommand<ConsultForm> _epr;

        public ConsultFormApp(IFactoryConnection efc)
        {
            _epr = new ConsultFormRepo(efc);
        }

        public ConsultForm FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<ConsultForm> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(ConsultForm ConsultForm)
        {
            return _epr.InsertOrUpdate(ConsultForm);
        }

        public IQueryable<ConsultForm> Search(Expression<Func<ConsultForm, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<ConsultForm> Search()
        {
            return _epr.Search();
        }
    }
}