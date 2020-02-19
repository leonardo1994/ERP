using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.TaxManagement.Domain.Taxations;
using Esr.Module.TaxManagement.Repository.Taxations;
using System.Collections.Generic;

namespace Esr.Module.TaxManagement.App.Taxations
{
    public class TaxationApp
    {
        private readonly IFactoryCommand<Taxation> _epr;

        public TaxationApp(IFactoryConnection efc)
        {
            _epr = new TaxationRepo(efc);
        }

        public Taxation FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Taxation> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Taxation Taxation)
        {
            return _epr.InsertOrUpdate(Taxation);
        }

        public IQueryable<Taxation> Search(Expression<Func<Taxation, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Taxation> Search()
        {
            return _epr.Search();
        }
    }
}