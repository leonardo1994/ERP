using Esr.Core.Domain.Authentication;
using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.App.Authentication;
using System.Collections;
using System.Linq.Expressions;
using System;

namespace Esr.Module.ControlPainel.Controllers
{
    public class PersonController
    {
        private PersonApp _PersonApp;
        private IFactoryConnection _connection;

        public PersonController(IFactoryConnection connection)
        {
            _connection = connection;
            _PersonApp = new PersonApp(connection);
        }

        public bool Save(Person Person)
        {
            _PersonApp.InsertOrUpdate(Person);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _PersonApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _PersonApp.Remove(_PersonApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de empresas.
        /// </summary>
        /// <returns>{ c.Id, c.PersonName, c.Cnpj, c.City.CityName, c.State.StateName, c.Country.CountryName }</returns>
        public IList ListPerson()
        {
            return _PersonApp.Search()
                .Select(c => new
                { c.Id, c.PersonName }).ToList();
        }

        public Person FindId(int id)
        {
            return _PersonApp.FindId(id);
        }

        public bool Remove(Expression<Func<Person, bool>> expression)
        {
            _PersonApp.Remove(_PersonApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Person, bool>> expression)
        {
            return _PersonApp.Search(expression).ToList();
        }
    }
}
