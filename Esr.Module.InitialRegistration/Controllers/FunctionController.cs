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
    public class FunctionController
    {
        private FunctionApp _FunctionApp; 
        private IFactoryConnection _connection;

        public FunctionController(IFactoryConnection connection)
        {
            _connection = connection;
            _FunctionApp = new FunctionApp(connection);
        }
        
        public bool Save(Function Function)
        {
            _FunctionApp.InsertOrUpdate(Function);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _FunctionApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _FunctionApp.Remove(_FunctionApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Functions List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListFunction()
        {
            return _FunctionApp.Search()
                .Select(c => new
                { c.Id, c.FunctionCode, c.FunctionDescription }).ToList();
        }

        public bool Remove(Expression<Func<Function, bool>> expression)
        {
            _FunctionApp.Remove(_FunctionApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Function, bool>> expression)
        {
            return _FunctionApp.Search(expression).ToList();
        }

        public Function FindId(int id)
        {
            return _FunctionApp.FindId(id);
        }
    }
}