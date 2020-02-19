using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.Services;
using Esr.Module.InitialRegistration.Domain.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class ServiceController
    {
        private ServiceApp _ServiceApp; 
        private IFactoryConnection _connection;

        public ServiceController(IFactoryConnection connection)
        {
            _connection = connection;
            _ServiceApp = new ServiceApp(connection);
        }
        
        public bool Save(Service Service)
        {
            _ServiceApp.InsertOrUpdate(Service);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ServiceApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ServiceApp.Remove(_ServiceApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Services List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListService()
        {
            return _ServiceApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.Description }).ToList();
        }

        public bool Remove(Expression<Func<Service, bool>> expression)
        {
            _ServiceApp.Remove(_ServiceApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Service, bool>> expression)
        {
            return _ServiceApp.Search(expression).ToList();
        }

        public Service FindId(int id)
        {
            return _ServiceApp.FindId(id);
        }
    }
}