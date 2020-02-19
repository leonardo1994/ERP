using Esr.Core.App.Parameters;
using Esr.Core.Domain.Parameters;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Parking.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.Parking.Controllers
{
    public class ParkingParameterController
    {
        private ParameterApp _ParameterApp;
        private IFactoryConnection _connection;

        public ParkingParameterController(IFactoryConnection connection)
        {
            _connection = connection;
            _ParameterApp = new ParameterApp(connection);
        }

        public bool Save(Parameter Parameter)
        {
            _ParameterApp.InsertOrUpdate(Parameter);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ParameterApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ParameterApp.Remove(_ParameterApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Parameters List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListParameter()
        {
            return _ParameterApp.Search<ParkingParameter>(d => true)
                .Select(c => new
                {
                    c.Id,
                    c.Integration,
                    c.StandardTableOfPriceId
                }).ToList();
        }

        public bool Remove(Expression<Func<Parameter, bool>> expression)
        {
            _ParameterApp.Remove(_ParameterApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<ParkingParameter, bool>> expression)
        {
            return _ParameterApp.Search<ParkingParameter>(d => true).Where(expression).ToList();
        }

        public Parameter FindId(int id)
        {
            return _ParameterApp.FindId(id);
        }
    }
}
