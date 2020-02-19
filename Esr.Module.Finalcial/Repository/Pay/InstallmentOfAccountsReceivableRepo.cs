using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Linq;
using Esr.Module.Financial.Domain.Pay;

namespace Esr.Module.Financial.Repository.Pay
{
    public class InstallmentsOfAccountsPayableRepo : IFactoryCommand<InstallmentsOfAccountsPayable>
    {
        private readonly IFactoryCommand<InstallmentsOfAccountsPayable> _efcmd;

        public InstallmentsOfAccountsPayableRepo(IFactoryConnection efc)
        {
            IFactoryRepository<InstallmentsOfAccountsPayable> efr = new OdbcSqlServer<InstallmentsOfAccountsPayable>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(InstallmentsOfAccountsPayable eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(InstallmentsOfAccountsPayable eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<InstallmentsOfAccountsPayable> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public InstallmentsOfAccountsPayable FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<InstallmentsOfAccountsPayable> Search(Expression<Func<InstallmentsOfAccountsPayable, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<InstallmentsOfAccountsPayable> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<InstallmentsOfAccountsPayable> AsNoTracking(Expression<Func<InstallmentsOfAccountsPayable, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<InstallmentsOfAccountsPayable> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<InstallmentsOfAccountsPayable> IFactoryCommand<InstallmentsOfAccountsPayable>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<InstallmentsOfAccountsPayable>.SearchOfType<T>(Expression<Func<InstallmentsOfAccountsPayable, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}