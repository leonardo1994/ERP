using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Linq;
using Esr.Module.Financial.Domain.Receive;

namespace Esr.Module.Financial.Repository.Receive
{
    public class BillsToReceiveRepo : IFactoryCommand<BillsToReceive>
    {
        private readonly IFactoryCommand<BillsToReceive> _efcmd;

        public BillsToReceiveRepo(IFactoryConnection efc)
        {
            IFactoryRepository<BillsToReceive> efr = new OdbcSqlServer<BillsToReceive>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(BillsToReceive eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(BillsToReceive eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<BillsToReceive> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public BillsToReceive FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<BillsToReceive> Search(Expression<Func<BillsToReceive, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<BillsToReceive> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<BillsToReceive> AsNoTracking(Expression<Func<BillsToReceive, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<BillsToReceive> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<BillsToReceive> IFactoryCommand<BillsToReceive>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<BillsToReceive>.SearchOfType<T>(Expression<Func<BillsToReceive, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
