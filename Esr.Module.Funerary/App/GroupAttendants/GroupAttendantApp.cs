using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.GroupAttendants;
using Esr.Module.Funerary.Repository.GroupAttendants;
using System.Collections.Generic;

namespace Esr.Module.Funerary.App.GroupAttendants
{
    public class GroupAttendantApp
    {
        private readonly IFactoryCommand<GroupAttendant> _epr;

        public GroupAttendantApp(IFactoryConnection efc)
        {
            _epr = new GroupAttendantRepo(efc);
        }

        public GroupAttendant FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<GroupAttendant> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(GroupAttendant GroupAttendant)
        {
            return _epr.InsertOrUpdate(GroupAttendant);
        }

        public IQueryable<GroupAttendant> Search(Expression<Func<GroupAttendant, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<GroupAttendant> Search()
        {
            return _epr.Search();
        }
    }
}