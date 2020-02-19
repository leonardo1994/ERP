using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Authentication;
using System.Data.Entity;

namespace Esr.Core.App.Authentication
{
    public class UserApp
    {
        private readonly IFactoryCommand<User> _epr;

        public UserApp(IFactoryConnection efc)
        {
            _epr = new UserRepo(efc);
        }

        public User FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<User> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(User User)
        {
            return _epr.InsertOrUpdate(User);
        }

        public IQueryable<User> Search(Expression<Func<User, bool>> expression)
        {
            return _epr.Search(expression)
                .Include(c => c.GroupUsers)
                .Include(c => c.UsersCompanies.Select(d => d.Company));
        }

        public IQueryable<User> Search()
        {
            return _epr.Search();
        }
    }
}