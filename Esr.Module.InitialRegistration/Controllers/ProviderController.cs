using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.Providers;
using Esr.Module.InitialRegistration.Domain.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class ProviderController
    {
        private ProviderApp _ProviderApp; 
        private IFactoryConnection _connection;

        public ProviderController(IFactoryConnection connection)
        {
            _connection = connection;
            _ProviderApp = new ProviderApp(connection);
        }
        
        public Provider FindId(int id)
        {
            return _ProviderApp.FindId(id);
        }

        public bool Save(Provider Provider)
        {
            _ProviderApp.InsertOrUpdate(Provider);
            return _connection.Save();
        }

        public bool Remove(Expression<Func<Provider, bool>> expression)
        {
            return _ProviderApp.Remove(_ProviderApp.Search(expression).ToList());
        }

        public bool RemoveId(int id)
        {
            _ProviderApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ProviderApp.Remove(_ProviderApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Providers List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListProvider()
        {
            return _ProviderApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.PersonName, c.Cnpj }).ToList();
        }

        /// <summary>
        /// Providers List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListProvider(Expression<Func<Provider, bool>> expression)
        {
            return _ProviderApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.PersonName, c.Cnpj }).ToList();
        }

        public IList Search(Expression<Func<Provider, bool>> expression)
        {
            return _ProviderApp.Search(expression).ToList();
        }
    }
}