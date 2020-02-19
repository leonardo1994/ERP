using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Authentication;

namespace Esr.Core.App.Authentication
{
    public class PersonAddressApp
    {
        private readonly IFactoryCommand<PersonAddress> _epr;

        public PersonAddressApp(IFactoryConnection efc)
        {
            _epr = new PersonAddressRepo(efc);
        }

        public PersonAddress FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<PersonAddress> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(PersonAddress PersonAddress)
        {
            return _epr.InsertOrUpdate(PersonAddress);
        }

        public IQueryable<PersonAddress> Search(Expression<Func<PersonAddress, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<PersonAddress> Search()
        {
            return _epr.Search();
        }
    }
}