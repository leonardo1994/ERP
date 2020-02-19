using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Repository.OrderOfServices;
using Esr.Module.Funerary.Domain.OrderOfServices;
using System.Collections.Generic;

namespace Esr.Module.Funerary.App.OrderOfServices
{
    public class OsContractorProductApp
    {
        private readonly IFactoryCommand<OsContractorProduct> _epr;

        public OsContractorProductApp(IFactoryConnection efc)
        {
            _epr = new OsContractorProductRepo(efc);
        }

        public OsContractorProduct FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<OsContractorProduct> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(OsContractorProduct OsContractorProduct)
        {
            return _epr.InsertOrUpdate(OsContractorProduct);
        }

        public IQueryable<OsContractorProduct> Search(Expression<Func<OsContractorProduct, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<OsContractorProduct> Search()
        {
            return _epr.Search();
        }
    }
}