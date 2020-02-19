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
    public class GroupUserApp
    {
        private readonly IFactoryCommand<GroupUser> _epr;

        public GroupUserApp(IFactoryConnection efc)
        {
            _epr = new GroupUserRepo(efc);
        }

        public GroupUser FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<GroupUser> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(GroupUser GroupUser)
        {
            return _epr.InsertOrUpdate(GroupUser);
        }

        public IQueryable<GroupUser> Search(Expression<Func<GroupUser, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<GroupUser> Search()
        {
            return _epr.Search();
        }
    }
}