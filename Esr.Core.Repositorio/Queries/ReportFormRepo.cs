using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Queries
{
    public class ReportFormRepo : IFactoryCommand<ReportForm>
    {
        private readonly IFactoryCommand<ReportForm> _efcmd;

        public ReportFormRepo(IFactoryConnection efc)
        {
            IFactoryRepository<ReportForm> efr = new DbContext<ReportForm>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(ReportForm eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(ReportForm eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<ReportForm> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public ReportForm FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<ReportForm> Search(Expression<Func<ReportForm, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<ReportForm> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<ReportForm> AsNoTracking(Expression<Func<ReportForm, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<ReportForm> IFactoryCommand<ReportForm>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<ReportForm> IFactoryCommand<ReportForm>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<ReportForm>.SearchOfType<T>(Expression<Func<ReportForm, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
