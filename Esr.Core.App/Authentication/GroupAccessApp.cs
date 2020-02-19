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
    public class GroupAccessApp
    {
        private readonly IFactoryCommand<GroupAccess> _epr;

        public GroupAccessApp(IFactoryConnection efc)
        {
            _epr = new GroupAccessRepo(efc);
        }

        public GroupAccess FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<GroupAccess> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(GroupAccess GroupAccess)
        {
            return _epr.InsertOrUpdate(GroupAccess);
        }

        public IQueryable<GroupAccess> Search(Expression<Func<GroupAccess, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<GroupAccess> Search()
        {
            return _epr.Search();
        }
    }
}