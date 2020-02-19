using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Module.FleetManagement.App.Vehicles;
using Esr.Module.FleetManagement.Domain.Vehicles;
using System.Linq.Expressions;
using System;

namespace Esr.Module.FleetManagement.Controllers
{
    public class ModelVehicleController
    {
        private ModelVehicleApp _ModelVehicleApp;
        private IFactoryConnection _connection;

        public ModelVehicleController(IFactoryConnection connection)
        {
            _connection = connection;
            _ModelVehicleApp = new ModelVehicleApp(connection);
        }

        public bool Save(ModelVehicle ModelVehicle)
        {
            _ModelVehicleApp.InsertOrUpdate(ModelVehicle);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ModelVehicleApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ModelVehicleApp.Remove(_ModelVehicleApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// ModelVehicles List
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.ModelVehicleName, c.Cnh }</returns>
        public IList ListModelVehicle()
        {
            return _ModelVehicleApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.Description }).ToList();
        }

        /// <summary>
        /// ModelVehicles List
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.ModelVehicleName, c.Cnh }</returns>
        public IList ListModelVehicle(Expression<Func<ModelVehicle, bool>> expression)
        {
            return _ModelVehicleApp.Search(expression)
                .Select(c => new
                { c.Id, c.Code, c.Description }).ToList();
        }

        public bool Remove(Expression<Func<ModelVehicle, bool>> expression)
        {
            _ModelVehicleApp.Remove(_ModelVehicleApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<ModelVehicle, bool>> expression)
        {
            return _ModelVehicleApp.Search(expression).ToList();
        }

        public ModelVehicle FindId(int id)
        {
            return _ModelVehicleApp.FindId(id);
        }
    }
}
