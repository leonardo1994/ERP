using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.Persons;
using Esr.Module.InitialRegistration.Repository.Persons;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.App.Persons
{
    public class PhysicalPersonApp
    {
        private readonly IFactoryCommand<PhysicalPerson> _epr;

        public PhysicalPersonApp(IFactoryConnection efc)
        {
            _epr = new PhysicalPersonRepo(efc);
        }

        public PhysicalPerson FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<PhysicalPerson> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(PhysicalPerson PhysicalPerson)
        {
            return _epr.InsertOrUpdate(PhysicalPerson);
        }

        public IQueryable<PhysicalPerson> Search(Expression<Func<PhysicalPerson, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<PhysicalPerson> Search()
        {
            return _epr.Search();
        }
    }
}