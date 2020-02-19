using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Linq;
using Esr.Module.Financial.Domain.Receive;

namespace Esr.Module.Financial.Repository.Receive
{
    public class InstallmentOfAccountsReceivableRepo : IFactoryCommand<InstallmentOfAccountsReceivable>
    {
        private readonly IFactoryCommand<InstallmentOfAccountsReceivable> _efcmd;

        public InstallmentOfAccountsReceivableRepo(IFactoryConnection efc)
        {
            IFactoryRepository<InstallmentOfAccountsReceivable> efr = new OdbcSqlServer<InstallmentOfAccountsReceivable>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(InstallmentOfAccountsReceivable eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(InstallmentOfAccountsReceivable eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<InstallmentOfAccountsReceivable> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public InstallmentOfAccountsReceivable FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<InstallmentOfAccountsReceivable> Search(Expression<Func<InstallmentOfAccountsReceivable, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<InstallmentOfAccountsReceivable> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<InstallmentOfAccountsReceivable> AsNoTracking(Expression<Func<InstallmentOfAccountsReceivable, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<InstallmentOfAccountsReceivable> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<InstallmentOfAccountsReceivable> IFactoryCommand<InstallmentOfAccountsReceivable>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<InstallmentOfAccountsReceivable>.SearchOfType<T>(Expression<Func<InstallmentOfAccountsReceivable, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
