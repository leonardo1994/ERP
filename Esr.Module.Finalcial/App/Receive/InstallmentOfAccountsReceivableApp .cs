using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Financial.Domain.Receive;
using Esr.Module.Financial.Repository.Receive;

namespace Esr.Module.Financial.App.Receive
{
    public class InstallmentOfAccountsReceivableApp
    {
        private readonly IFactoryCommand<InstallmentOfAccountsReceivable> _epr;

        public InstallmentOfAccountsReceivableApp(IFactoryConnection efc)
        {
            _epr = new InstallmentOfAccountsReceivableRepo(efc);
        }

        public InstallmentOfAccountsReceivable FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<InstallmentOfAccountsReceivable> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(InstallmentOfAccountsReceivable InstallmentOfAccountsReceivable)
        {
            return _epr.InsertOrUpdate(InstallmentOfAccountsReceivable);
        }

        public IQueryable<InstallmentOfAccountsReceivable> Search(Expression<Func<InstallmentOfAccountsReceivable, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<InstallmentOfAccountsReceivable> Search()
        {
            return _epr.Search();
        }
    }
}