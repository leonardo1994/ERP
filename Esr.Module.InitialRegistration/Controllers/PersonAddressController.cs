using Esr.Core.App.Authentication;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.RH;
using Esr.Module.InitialRegistration.Domain.RH;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class PersonAddressController
    {
        private PersonAddressApp _PersonAddressApp; 
        private IFactoryConnection _connection;

        public PersonAddressController(IFactoryConnection connection)
        {
            _connection = connection;
            _PersonAddressApp = new PersonAddressApp(connection);
        }
        
        public bool Save(PersonAddress PersonAddress)
        {
            _PersonAddressApp.InsertOrUpdate(PersonAddress);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _PersonAddressApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _PersonAddressApp.Remove(_PersonAddressApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// PersonAddresss List.
        /// </summary>
        /// <returns>{ c.Id, c.ZipCode, c.Street, c.Neighborhood, c.City.CityName, c.State.StateName, c.Country.CountryName }</returns>
        public IList ListPersonAddress()
        {
            return _PersonAddressApp.Search()
                .Select(c => new
                { c.Id, c.ZipCode, c.Street, c.Neighborhood, c.City.CityName, c.State.StateName, c.Country.CountryName }).ToList();
        }

        /// <summary>
        /// PersonAddresss List.
        /// </summary>
        /// <returns>{ c.Id, c.ZipCode, c.Street, c.Neighborhood, c.City.CityName, c.State.StateName, c.Country.CountryName }</returns>
        public IList Search(Expression<Func<PersonAddress, bool>> expression)
        {
            return _PersonAddressApp.Search(expression)
                .Select(c => new
                { c.Id, c.ZipCode, c.Street, c.Neighborhood, c.City.CityName, c.State.StateName, c.Country.CountryName }).ToList();
        }

        public bool Remove(Expression<Func<PersonAddress, bool>> expression)
        {
            _PersonAddressApp.Remove(_PersonAddressApp.Search(expression).ToList());
            return _connection.Save();
        }

        public PersonAddress FindId(int id)
        {
            return _PersonAddressApp.FindId(id);
        }
    }
}