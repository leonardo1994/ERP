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
    public class CityController
    {
        private CityApp _CityApp; 
        private IFactoryConnection _connection;

        public CityController(IFactoryConnection connection)
        {
            _connection = connection;
            _CityApp = new CityApp(connection);
        }
        
        public bool Save(City City)
        {
            _CityApp.InsertOrUpdate(City);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _CityApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _CityApp.Remove(_CityApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Citys List.
        /// </summary>
        /// <returns>{ c.Id, c.CityName, c.CodeIbge, c.State.Initials }</returns>
        public IList ListCity()
        {
            return _CityApp.Search()
                .Select(c => new
                { c.Id, c.CityName, c.CodeIbge, c.State.Initials }).ToList();
        }

        /// <summary>
        /// Citys List.
        /// </summary>
        /// <returns>{ c.Id, c.CityName, c.CodeIbge, c.State.Initials }</returns>
        public IList ListCity(Expression<Func<City, bool>> expression)
        {
            return _CityApp.Search(expression)
                .Select(c => new
                { c.Id, c.CityName, c.CodeIbge, c.State.Initials }).ToList();
        }

        /// <summary>
        /// Citys List.
        /// </summary>
        /// <returns>{ c.Id, c.CityName, c.CodeIbge, c.State.Initials }</returns>
        public IList<City> Search(Expression<Func<City, bool>> expression)
        {
            return _CityApp.Search(expression).ToList();
        }

        public bool Remove(Expression<Func<City, bool>> expression)
        {
            _CityApp.Remove(_CityApp.Search(expression).ToList());
            return _connection.Save();
        }

        public City FindId(int id)
        {
            return _CityApp.FindId(id);
        }

    }
}