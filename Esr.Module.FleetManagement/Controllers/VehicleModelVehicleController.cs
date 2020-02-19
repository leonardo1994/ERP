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
    public class VehicleModelVehicleController
    {
        private VehicleModelVehicleApp _VehicleModelVehicleApp;
        private IFactoryConnection _connection;

        public VehicleModelVehicleController(IFactoryConnection connection)
        {
            _connection = connection;
            _VehicleModelVehicleApp = new VehicleModelVehicleApp(connection);
        }

        public bool Save(VehicleModelVehicle VehicleModelVehicle)
        {
            _VehicleModelVehicleApp.InsertOrUpdate(VehicleModelVehicle);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _VehicleModelVehicleApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _VehicleModelVehicleApp.Remove(_VehicleModelVehicleApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// VehicleModelVehicles List
        /// </summary>
        /// <returns>{ c.Id, Color = c.Color.Description, Model = c.ModelVehicle.Description }</returns>
        public IList ListVehicleModelVehicle(Expression<Func<VehicleModelVehicle, bool>> expression)
        {
            return _VehicleModelVehicleApp.Search(expression)
                .Select(c => new { c.Id, c.ModelVehicle.Description, c.Vehicle.NameVehicle, c.VehicleId, c.ModelVehicleId }).ToList();
        }

        public IList Search(Expression<Func<VehicleModelVehicle, bool>> expression)
        {
            return _VehicleModelVehicleApp.Search(expression)
                .Select(c => new
                { c.Id, c.ModelVehicle.Description, c.Vehicle.NameVehicle, c.VehicleId, c.ModelVehicleId }).ToList();
        }

        public bool Remove(Expression<Func<VehicleModelVehicle, bool>> expression)
        {
            _VehicleModelVehicleApp.Remove(_VehicleModelVehicleApp.Search(expression).ToList());
            return _connection.Save();
        }

        public VehicleModelVehicle FindId(int id)
        {
            return _VehicleModelVehicleApp.FindId(id);
        }
    }
}