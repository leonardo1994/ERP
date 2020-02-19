using Esr.Core.App.Authentication;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class LegalPersonController
    {
        private LegalPersonApp _LegalPersonApp; 
        private IFactoryConnection _connection;

        public LegalPersonController(IFactoryConnection connection)
        {
            _connection = connection;
            _LegalPersonApp = new LegalPersonApp(connection);
        }
        
        public bool Save(LegalPerson LegalPerson)
        {
            _LegalPersonApp.InsertOrUpdate(LegalPerson);
            return _connection.Save();
        }

        public bool Save(Provider LegalPerson)
        {
            _LegalPersonApp.InsertOrUpdate(LegalPerson);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _LegalPersonApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _LegalPersonApp.Remove(_LegalPersonApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        public LegalPerson FindId(int id)
        {
            return _LegalPersonApp.FindId(id);
        }

        /// <summary>
        /// LegalPersons List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.PersonName, c.Cnpj }</returns>
        public IList<LegalPerson> ListLegalPerson()
        {
            return _LegalPersonApp.Search().ToList();
        }

        public IList<LegalPerson> Search(Expression<Func<LegalPerson, bool>> expression)
        {
            return _LegalPersonApp.Search(expression).ToList();
        }

        public bool Remove(Expression<Func<LegalPerson, bool>> expression)
        {
            _LegalPersonApp.Remove(_LegalPersonApp.Search(expression).ToList());
            return _connection.Save();
        }
    }
}