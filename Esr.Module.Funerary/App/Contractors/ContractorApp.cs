using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.Contractors;
using Esr.Module.Funerary.Repository.Contractors;
using System.Collections.Generic;
using System.Collections;
using Esr.Core.Domain.Other;

namespace Esr.Module.Funerary.App.Contractors
{
    public class ContractorApp
    {
        private readonly IFactoryCommand<Contractor> _epr;

        public ContractorApp(IFactoryConnection efc)
        {
            _epr = new ContractorRepo(efc);
        }

        public Contractor FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Contractor> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Contractor Contractor)
        {
            return _epr.InsertOrUpdate(Contractor);
        }

        public IQueryable<Contractor> Search(Expression<Func<Contractor, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Contractor> Search()
        {
            return _epr.Search();
        }
    }
}