using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.GroupAttendants;
using Esr.Module.Funerary.Repository.GroupAttendants;

namespace Esr.Module.Funerary.App.GroupAttendants
{
    public class AttendantApp
    {
        private readonly IFactoryCommand<Attendant> _epr;

        public AttendantApp(IFactoryConnection efc)
        {
            _epr = new AttendantRepo(efc);
        }

        public Attendant FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Attendant> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Attendant Attendant)
        {
            return _epr.InsertOrUpdate(Attendant);
        }

        public IQueryable<Attendant> Search(Expression<Func<Attendant, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Attendant> Search()
        {
            return _epr.Search();
        }
    }
}