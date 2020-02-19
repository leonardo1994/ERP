using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using System.Linq;

namespace Esr.Core.Repository.Authentication
{
    public class CompanyRepo : IFactoryCommand<Company>
    {
        private readonly IFactoryCommand<Company> _efcmd;

        public CompanyRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Company> efr = new DbContext<Company>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Company eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Company eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Company> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Company FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Company> Search(Expression<Func<Company, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Company> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Company> AsNoTracking(Expression<Func<Company, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Company> IFactoryCommand<Company>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Company> IFactoryCommand<Company>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Company>.SearchOfType<T>(Expression<Func<Company, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
