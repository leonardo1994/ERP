using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Address;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Address;

namespace Esr.Core.App.Address
{
    public class CityApp
    {
        private readonly IFactoryCommand<City> _epr;

        public CityApp(IFactoryConnection efc)
        {
            _epr = new CityRepo(efc);
        }

        public City FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<City> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(City city)
        {
            return _epr.InsertOrUpdate(city);
        }

        public IQueryable<City> Search(Expression<Func<City, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<City> Search()
        {
            return _epr.Search();
        }
    }
}