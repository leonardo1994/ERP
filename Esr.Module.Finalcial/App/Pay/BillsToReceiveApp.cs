using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Financial.Domain.Receive;
using Esr.Module.Financial.Repository.Receive;
using Esr.Module.Financial.Domain.Pay;
using Esr.Module.Financial.Repository.Pay;

namespace Esr.Module.Financial.App.Pay
{
    public class BillsToPayApp
    {
        private readonly IFactoryCommand<BillsToPay> _epr;

        public BillsToPayApp(IFactoryConnection efc)
        {
            _epr = new BillsToPayRepo(efc);
        }

        public BillsToPay FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<BillsToPay> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(BillsToPay BillsToPay)
        {
            return _epr.InsertOrUpdate(BillsToPay);
        }

        public IQueryable<BillsToPay> Search(Expression<Func<BillsToPay, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<BillsToPay> Search()
        {
            return _epr.Search();
        }
    }
}