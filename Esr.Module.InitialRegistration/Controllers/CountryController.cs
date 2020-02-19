using Esr.Core.App.Address;
using Esr.Core.Domain.Address;
using Esr.Core.Domain.RepositoryFactory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class CountryController
    {
        private CountryApp _CountryApp; 
        private IFactoryConnection _connection;

        public CountryController(IFactoryConnection connection)
        {
            _connection = connection;
            _CountryApp = new CountryApp(connection);
        }
        
        public bool Save(Country Country)
        {
            _CountryApp.InsertOrUpdate(Country);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _CountryApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _CountryApp.Remove(_CountryApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Countrys List.
        /// </summary>
        /// <returns>{ c.Id, c.Initials, c.CountryName, c.CodeIbge }</returns>
        public IList ListCountry()
        {
            return _CountryApp.Search()
                .Select(c => new
                { c.Id, c.Initials, c.CountryName, c.CodeIbge }).ToList();
        }

        public bool Remove(Expression<Func<Country, bool>> expression)
        {
            _CountryApp.Remove(_CountryApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Country, bool>> expression)
        {
            return _CountryApp.Search(expression).ToList();
        }

        public Country FindId(int id)
        {
            return _CountryApp.FindId(id);
        }
    }
}