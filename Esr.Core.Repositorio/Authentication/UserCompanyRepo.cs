using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Authentication
{
    public class UserCompanyRepo : IFactoryCommand<UserCompany>
    {
        private readonly IFactoryCommand<UserCompany> _efcmd;

        public UserCompanyRepo(IFactoryConnection efc)
        {
            IFactoryRepository<UserCompany> efr = new DbContext<UserCompany>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(UserCompany eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(UserCompany eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<UserCompany> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public UserCompany FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<UserCompany> Search(Expression<Func<UserCompany, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<UserCompany> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<UserCompany> AsNoTracking(Expression<Func<UserCompany, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<UserCompany> IFactoryCommand<UserCompany>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<UserCompany> IFactoryCommand<UserCompany>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<UserCompany>.SearchOfType<T>(Expression<Func<UserCompany, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}