using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Queries;

namespace Esr.Core.App.Queries
{
    public class ConsultApp
    {
        private readonly IFactoryCommand<Consult> _epr;

        public ConsultApp(IFactoryConnection efc)
        {
            _epr = new ConsultRepo(efc);
        }

        public Consult FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Consult> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Consult Consult)
        {
            return _epr.InsertOrUpdate(Consult);
        }

        public IQueryable<Consult> Search(Expression<Func<Consult, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Consult> Search()
        {
            return _epr.Search();
        }
    }
}