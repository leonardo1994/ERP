using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Financial.Domain.Pay;
using Esr.Module.Financial.Repository.Pay;

namespace Esr.Module.Financial.App.Pay
{
    public class InstallmentsOfAccountsPayableApp
    {
        private readonly IFactoryCommand<InstallmentsOfAccountsPayable> _epr;

        public InstallmentsOfAccountsPayableApp(IFactoryConnection efc)
        {
            _epr = new InstallmentsOfAccountsPayableRepo(efc);
        }

        public InstallmentsOfAccountsPayable FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<InstallmentsOfAccountsPayable> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(InstallmentsOfAccountsPayable InstallmentsOfAccountsPayable)
        {
            return _epr.InsertOrUpdate(InstallmentsOfAccountsPayable);
        }

        public IQueryable<InstallmentsOfAccountsPayable> Search(Expression<Func<InstallmentsOfAccountsPayable, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<InstallmentsOfAccountsPayable> Search()
        {
            return _epr.Search();
        }
    }
}