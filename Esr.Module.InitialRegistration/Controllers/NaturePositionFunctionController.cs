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
    public class NaturePositionFunctionController
    {
        private NaturePositionFunctionApp _NaturePositionFunctionApp; 
        private IFactoryConnection _connection;

        public NaturePositionFunctionController(IFactoryConnection connection)
        {
            _connection = connection;
            _NaturePositionFunctionApp = new NaturePositionFunctionApp(connection);
        }
        
        public bool Save(NaturePositionFunction NaturePositionFunction)
        {
            _NaturePositionFunctionApp.InsertOrUpdate(NaturePositionFunction);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _NaturePositionFunctionApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _NaturePositionFunctionApp.Remove(_NaturePositionFunctionApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// NaturePositionFunctions List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListNaturePositionFunction()
        {
            return _NaturePositionFunctionApp.Search()
                .Select(c => new
                { c.Id, c.NaturePositionFunctionCode, c.NaturePositionFunctionDescription }).ToList();
        }

        public bool Remove(Expression<Func<NaturePositionFunction, bool>> expression)
        {
            _NaturePositionFunctionApp.Remove(_NaturePositionFunctionApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<NaturePositionFunction, bool>> expression)
        {
            return _NaturePositionFunctionApp.Search(expression).ToList();
        }

        public NaturePositionFunction FindId(int id)
        {
            return _NaturePositionFunctionApp.FindId(id);
        }
    }
}