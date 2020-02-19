using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Linq;
using Esr.Module.Financial.Domain.Pay;

namespace Esr.Module.Financial.Repository.Pay
{
    public class BillsToPayRepo : IFactoryCommand<BillsToPay>
    {
        private readonly IFactoryCommand<BillsToPay> _efcmd;

        public BillsToPayRepo(IFactoryConnection efc)
        {
            IFactoryRepository<BillsToPay> efr = new OdbcSqlServer<BillsToPay>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(BillsToPay eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(BillsToPay eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<BillsToPay> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public BillsToPay FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<BillsToPay> Search(Expression<Func<BillsToPay, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<BillsToPay> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<BillsToPay> AsNoTracking(Expression<Func<BillsToPay, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<BillsToPay> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<BillsToPay> IFactoryCommand<BillsToPay>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<BillsToPay>.SearchOfType<T>(Expression<Func<BillsToPay, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
