using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Queries
{
    public class FilterRepo : IFactoryCommand<Filter>
    {
        private readonly IFactoryCommand<Filter> _efcmd;

        public FilterRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Filter> efr = new DbContext<Filter>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Filter eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Filter eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Filter> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Filter FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Filter> Search(Expression<Func<Filter, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Filter> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Filter> AsNoTracking(Expression<Func<Filter, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Filter> IFactoryCommand<Filter>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Filter> IFactoryCommand<Filter>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Filter>.SearchOfType<T>(Expression<Func<Filter, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
