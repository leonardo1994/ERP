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
    public class TypePositionFunctionController
    {
        private TypePositionFunctionApp _TypePositionFunctionApp; 
        private IFactoryConnection _connection;

        public TypePositionFunctionController(IFactoryConnection connection)
        {
            _connection = connection;
            _TypePositionFunctionApp = new TypePositionFunctionApp(connection);
        }
        
        public bool Save(TypePositionFunction TypePositionFunction)
        {
            _TypePositionFunctionApp.InsertOrUpdate(TypePositionFunction);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _TypePositionFunctionApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _TypePositionFunctionApp.Remove(_TypePositionFunctionApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// TypePositionFunctions List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListTypePositionFunction()
        {
            return _TypePositionFunctionApp.Search()
                .Select(c => new
                { c.Id, c.TypeOfficeFunctionCode, c.TypeOfficeFunctionDescription }).ToList();
        }

        public bool Remove(Expression<Func<TypePositionFunction, bool>> expression)
        {
            _TypePositionFunctionApp.Remove(_TypePositionFunctionApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<TypePositionFunction, bool>> expression)
        {
            return _TypePositionFunctionApp.Search(expression).ToList();
        }

        public TypePositionFunction FindId(int id)
        {
            return _TypePositionFunctionApp.FindId(id);
        }
    }
}