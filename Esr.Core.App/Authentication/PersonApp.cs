using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Authentication;
using System.Linq;
using Esr.Core.Domain.Other;

namespace Esr.Core.App.Authentication
{
    public class PersonApp
    {
        private readonly IFactoryCommand<Person> _epr;

        public PersonApp(IFactoryConnection efc)
        {
            _epr = new PersonRepo(efc);
        }

        public Person FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Person> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Person Person)
        {
            return _epr.InsertOrUpdate(Person);
        }

        public IQueryable<Person> Search(Expression<Func<Person, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Person> Search()
        {
            return _epr.Search();
        }
    }
}