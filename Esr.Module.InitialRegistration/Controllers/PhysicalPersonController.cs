using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.Persons;
using Esr.Module.InitialRegistration.Domain.Persons;
using Esr.Module.InitialRegistration.Domain.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class PhysicalPersonController
    {
        private PhysicalPersonApp _PhysicalPersonApp; 
        private IFactoryConnection _connection;

        public PhysicalPersonController(IFactoryConnection connection)
        {
            _connection = connection;
            _PhysicalPersonApp = new PhysicalPersonApp(connection);
        }
        
        public bool Save(PhysicalPerson PhysicalPerson)
        {
            _PhysicalPersonApp.InsertOrUpdate(PhysicalPerson);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _PhysicalPersonApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _PhysicalPersonApp.Remove(_PhysicalPersonApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        public PhysicalPerson FindId(int id)
        {
            return _PhysicalPersonApp.FindId(id);
        }

        /// <summary>
        /// PhysicalPersons List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.PersonName, c.Cnpj }</returns>
        public IList<PhysicalPerson> ListPhysicalPerson()
        {
            return _PhysicalPersonApp.Search().ToList();
        }

        public IList<PhysicalPerson> Search(Expression<Func<PhysicalPerson, bool>> expression)
        {
            return _PhysicalPersonApp.Search(expression).ToList();
        }

        public bool Remove(Expression<Func<PhysicalPerson, bool>> expression)
        {
            _PhysicalPersonApp.Remove(_PhysicalPersonApp.Search(expression).ToList());
            return _connection.Save();
        }
    }
}