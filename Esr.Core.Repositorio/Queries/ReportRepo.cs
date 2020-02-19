using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Queries
{
    public class ReportRepo : IFactoryCommand<Report>
    {
        private readonly IFactoryCommand<Report> _efcmd;

        public ReportRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Report> efr = new DbContext<Report>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Report eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Report eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Report> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Report FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Report> Search(Expression<Func<Report, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Report> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Report> AsNoTracking(Expression<Func<Report, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Report> IFactoryCommand<Report>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Report> IFactoryCommand<Report>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Report>.SearchOfType<T>(Expression<Func<Report, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
