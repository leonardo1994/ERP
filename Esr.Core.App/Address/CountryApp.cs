using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Address;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Address;
using System.Collections.Generic;

namespace Esr.Core.App.Address
{
    public class CountryApp
    {
        private readonly IFactoryCommand<Country> _epr;

        public CountryApp(IFactoryConnection efc)
        {
            _epr = new CountryRepo(efc);
        }

        public Country FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Country> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Country Country)
        {
            return _epr.InsertOrUpdate(Country);
        }

        public IQueryable<Country> Search(Expression<Func<Country, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Country> Search()
        {
            return _epr.Search();
        }
    }
}