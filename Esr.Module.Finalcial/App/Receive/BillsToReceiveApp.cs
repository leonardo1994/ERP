using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Financial.Domain.Receive;
using Esr.Module.Financial.Repository.Receive;

namespace Esr.Module.Financial.App.Receive
{
    public class BillsToReceiveApp
    {
        private readonly IFactoryCommand<BillsToReceive> _epr;

        public BillsToReceiveApp(IFactoryConnection efc)
        {
            _epr = new BillsToReceiveRepo(efc);
        }

        public BillsToReceive FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<BillsToReceive> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(BillsToReceive BillsToReceive)
        {
            return _epr.InsertOrUpdate(BillsToReceive);
        }

        public IQueryable<BillsToReceive> Search(Expression<Func<BillsToReceive, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<BillsToReceive> Search()
        {
            return _epr.Search();
        }
    }
}