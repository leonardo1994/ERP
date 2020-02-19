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
    public class VehiclePlateController
    {
        private VehiclePlateApp _VehiclePlateApp;
        private IFactoryConnection _connection;

        public VehiclePlateController(IFactoryConnection connection)
        {
            _connection = connection;
            _VehiclePlateApp = new VehiclePlateApp(connection);
        }

        public bool Save(VehiclePlate VehiclePlate)
        {
            _VehiclePlateApp.InsertOrUpdate(VehiclePlate);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _VehiclePlateApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _VehiclePlateApp.Remove(_VehiclePlateApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// VehiclePlates List
        /// </summary>
        /// <returns>{ c.Id, c.Plate, Modelo = c.ModelVehicle.Description, Cor = c.Color.Description }</returns>
        public IList ListVehiclePlate()
        {
            return _VehiclePlateApp.Search()
                .Select(c => new
                { c.Id, c.Plate, Carro = c.Vehicle.NameVehicle, Modelo = c.ModelVehicle.Description, Cor = c.Color.Description }).ToList();
        }

        public bool Remove(Expression<Func<VehiclePlate, bool>> expression)
        {
            _VehiclePlateApp.Remove(_VehiclePlateApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<VehiclePlate, bool>> expression)
        {
            return _VehiclePlateApp.Search(expression).ToList();
        }

        public VehiclePlate FindId(int id)
        {
            return _VehiclePlateApp.FindId(id);
        }
    }
}