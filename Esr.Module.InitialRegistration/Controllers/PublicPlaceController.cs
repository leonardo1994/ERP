using Esr.Core.App.Address;
using Esr.Core.Domain.Address;
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
    public class PublicPlaceController
    {
        private PublicPlaceApp _PublicPlaceApp;
        private IFactoryConnection _connection;

        public PublicPlaceController(IFactoryConnection connection)
        {
            _connection = connection;
            _PublicPlaceApp = new PublicPlaceApp(connection);
        }

        public bool Save(PublicPlace PublicPlace)
        {
            _PublicPlaceApp.InsertOrUpdate(PublicPlace);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _PublicPlaceApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _PublicPlaceApp.Remove(_PublicPlaceApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// PublicPlaces List.
        /// </summary>
        /// <returns>{ c.Id, c.ZipCode, c.Street, c.Neighborhood, c.City.CityName, State = c.State.Initials, Country = c.Country.Initials }</returns>
        public IList ListPublicPlace()
        {
            return _PublicPlaceApp.Search()
                .Select(c => new
                { c.Id, c.ZipCode, c.Street, c.Neighborhood, c.City.CityName, State = c.State.Initials, Country = c.Country.Initials }).ToList();
        }

        public bool Remove(Expression<Func<PublicPlace, bool>> expression)
        {
            _PublicPlaceApp.Remove(_PublicPlaceApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<PublicPlace, bool>> expression)
        {
            return _PublicPlaceApp.Search(expression).ToList();
        }

        public PublicPlace FindId(int id)
        {
            return _PublicPlaceApp.FindId(id);
        }
    }
}