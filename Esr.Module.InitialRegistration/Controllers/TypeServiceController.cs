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
    public class TypeServiceController
    {
        private TypeServiceApp _TypeServiceApp; 
        private IFactoryConnection _connection;

        public TypeServiceController(IFactoryConnection connection)
        {
            _connection = connection;
            _TypeServiceApp = new TypeServiceApp(connection);
        }
        
        public bool Save(TypeService TypeService)
        {
            _TypeServiceApp.InsertOrUpdate(TypeService);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _TypeServiceApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _TypeServiceApp.Remove(_TypeServiceApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// TypeServices List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListTypeService()
        {
            return _TypeServiceApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.Description }).ToList();
        }

        /// <summary>
        /// TypeServices List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList Search(Expression<Func<TypeService, bool>> expression)
        {
            return _TypeServiceApp.Search(expression)
                .Select(c => new
                { c.Id, c.Code, c.Description }).ToList();
        }

        public bool Remove(Expression<Func<TypeService, bool>> expression)
        {
            _TypeServiceApp.Remove(_TypeServiceApp.Search(expression).ToList());
            return _connection.Save();
        }

        public TypeService FindId(int id)
        {
            return _TypeServiceApp.FindId(id);
        }
    }
}