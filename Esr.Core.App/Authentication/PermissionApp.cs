using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Authentication;
using System.Linq;

namespace Esr.Core.App.Authentication
{
    public class PermissionApp
    {
        private readonly IFactoryCommand<Permission> _epr;

        public PermissionApp(IFactoryConnection efc)
        {
            _epr = new PermissionRepo(efc);
        }

        public Permission FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Permission> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Permission Permission)
        {
            return _epr.InsertOrUpdate(Permission);
        }

        public IQueryable<Permission> Search(Expression<Func<Permission, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Permission> Search()
        {
            return _epr.Search();
        }
    }
}