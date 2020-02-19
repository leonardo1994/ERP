using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using Esr.Core.Domain.FiltersCompanies;
using System.Linq;

namespace Esr.Core.Repository.FiltersCompanies
{
    public class FilterCompanyRepo : IFactoryCommand<FilterCompany>
    {
        private readonly IFactoryCommand<FilterCompany> _efcmd;

        public FilterCompanyRepo(IFactoryConnection efc)
        {
            IFactoryRepository<FilterCompany> efr = new DbContext<FilterCompany>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(FilterCompany eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(FilterCompany eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<FilterCompany> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public FilterCompany FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<FilterCompany> Search(Expression<Func<FilterCompany, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<FilterCompany> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<FilterCompany> AsNoTracking(Expression<Func<FilterCompany, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<FilterCompany> IFactoryCommand<FilterCompany>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<FilterCompany> IFactoryCommand<FilterCompany>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<FilterCompany>.SearchOfType<T>(Expression<Func<FilterCompany, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
