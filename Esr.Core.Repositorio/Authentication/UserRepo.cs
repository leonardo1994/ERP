using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Authentication
{
    public class UserRepo : IFactoryCommand<User>
    {
        private readonly IFactoryCommand<User> _efcmd;

        public UserRepo(IFactoryConnection efc)
        {
            IFactoryRepository<User> efr = new DbContext<User>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(User eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(User eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<User> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public User FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<User> Search(Expression<Func<User, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<User> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<User> AsNoTracking(Expression<Func<User, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<User> IFactoryCommand<User>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<User> IFactoryCommand<User>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<User>.SearchOfType<T>(Expression<Func<User, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
