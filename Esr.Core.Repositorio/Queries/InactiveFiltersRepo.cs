using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Queries
{
    public class InactiveFiltersRepo : IFactoryCommand<InactiveFilters>
    {
        private readonly IFactoryCommand<InactiveFilters> _efcmd;

        public InactiveFiltersRepo(IFactoryConnection efc)
        {
            IFactoryRepository<InactiveFilters> efr = new DbContext<InactiveFilters>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(InactiveFilters eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(InactiveFilters eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<InactiveFilters> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public InactiveFilters FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<InactiveFilters> Search(Expression<Func<InactiveFilters, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<InactiveFilters> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<InactiveFilters> AsNoTracking(Expression<Func<InactiveFilters, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<InactiveFilters> IFactoryCommand<InactiveFilters>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<InactiveFilters> IFactoryCommand<InactiveFilters>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<InactiveFilters>.SearchOfType<T>(Expression<Func<InactiveFilters, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
