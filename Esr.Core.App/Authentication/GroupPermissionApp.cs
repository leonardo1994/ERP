using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Authentication;
using Esr.Core.Domain.Other;

namespace Esr.Core.App.Authentication
{
    public class GroupPermissionApp
    {
        private readonly IFactoryCommand<GroupPermission> _epr;

        public GroupPermissionApp(IFactoryConnection efc)
        {
            _epr = new GroupPermissionRepo(efc);
        }

        public GroupPermission FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<GroupPermission> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(GroupPermission GroupPermission)
        {
            return _epr.InsertOrUpdate(GroupPermission);
        }

        public IQueryable<GroupPermission> Search(Expression<Func<GroupPermission, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<GroupPermission> Search()
        {
            return _epr.Search();
        }
    }
}
