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
    public class VehicleController
    {
        private VehicleApp _VehicleApp;
        private IFactoryConnection _connection;

        public VehicleController(IFactoryConnection connection)
        {
            _connection = connection;
            _VehicleApp = new VehicleApp(connection);
        }

        public bool Save(Vehicle Vehicle)
        {
            _VehicleApp.InsertOrUpdate(Vehicle);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _VehicleApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _VehicleApp.Remove(_VehicleApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Vehicles List
        /// </summary>
        /// <returns>{ c.Id, c.CodeVehicle, c.NameVehicle }</returns>
        public IList ListVehicle()
        {
            return _VehicleApp.Search()
                .Select(c => new
                { c.Id, c.CodeVehicle, c.NameVehicle }).ToList();
        }

        public bool Remove(Expression<Func<Vehicle, bool>> expression)
        {
            _VehicleApp.Remove(_VehicleApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Vehicle, bool>> expression)
        {
            return _VehicleApp.Search(expression).ToList();
        }

        public Vehicle FindId(int id)
        {
            return _VehicleApp.FindId(id);
        }
    }
}