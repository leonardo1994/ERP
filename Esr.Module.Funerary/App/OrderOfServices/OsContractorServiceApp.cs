using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.Funerary.Repository.OrderOfServices;
using System.Collections;
using System.Collections.Generic;
using Esr.Core.Domain.Other;

namespace Esr.Module.Funerary.App.OrderOfServices
{
    public class OsContractorServiceApp
    {
        private readonly IFactoryCommand<OsContractorService> _epr;

        public OsContractorServiceApp(IFactoryConnection efc)
        {
            _epr = new OsContractorServiceRepo(efc);
        }

        public OsContractorService FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<OsContractorService> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(OsContractorService OsContractorService)
        {
            return _epr.InsertOrUpdate(OsContractorService);
        }

        public IQueryable<OsContractorService> Search(Expression<Func<OsContractorService, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<OsContractorService> Search()
        {
            return _epr.Search();
        }
    }
}