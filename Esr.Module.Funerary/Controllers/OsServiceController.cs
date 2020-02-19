using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Module.Funerary.App.OrderOfServices;
using Esr.Module.Funerary.Domain.OrderOfServices;
using System.Linq.Expressions;
using System;

namespace Esr.Module.Funerary.Controllers
{
    public class OsServiceController
    {
        private OsServiceApp _OsServiceApp;
        private IFactoryConnection _connection;

        public OsServiceController(IFactoryConnection connection)
        {
            _connection = connection;
            _OsServiceApp = new OsServiceApp(connection);
        }

        public bool Save(OsService OsService)
        {
            _OsServiceApp.InsertOrUpdate(OsService);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _OsServiceApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _OsServiceApp.Remove(_OsServiceApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// OsService List.
        /// </summary>
        /// <returns>{ c.Id, c.LegalPerson.PersonName, c.Service.Description, c.ValueService }</returns>
        public IList ListOsService(Expression<Func<OsService, bool>> expression)
        {
            return _OsServiceApp.Search(expression)
                .Select(c => new
                { c.Id, c.Integration,  c.LegalPerson.PersonName, c.Service.Description, c.ValueService }).ToList();
        }

        /// <summary>
        /// OsService List.
        /// </summary>
        /// <returns>{ c.Id, c.LegalPerson.PersonName, c.Service.Description, c.ValueService }</returns>
        public IList Search(Expression<Func<OsService, bool>> expression)
        {
            return _OsServiceApp.Search(expression).ToList();
        }

        public bool Remove(Expression<Func<OsService, bool>> expression)
        {
            _OsServiceApp.Remove(_OsServiceApp.Search(expression).ToList());
            return _connection.Save();
        }

        public OsService FindId(int id)
        {
            return _OsServiceApp.FindId(id);
        }
    }
}