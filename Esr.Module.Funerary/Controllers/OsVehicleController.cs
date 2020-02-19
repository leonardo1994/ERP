using Esr.Core.Domain.Authentication;
using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.App.Authentication;
using System.Collections;
using Esr.Module.Funerary.App.OrderOfServices;
using Esr.Module.Funerary.Domain.OrderOfServices;
using System;
using System.Linq.Expressions;

namespace Esr.Module.Funerary.Controllers
{
    public class OsVehicleController
    {
        private OsVehicleApp _OsVehicleApp;
        private IFactoryConnection _connection;

        public OsVehicleController(IFactoryConnection connection)
        {
            _connection = connection;
            _OsVehicleApp = new OsVehicleApp(connection);
        }

        public bool Save(OsVehicle OsVehicle)
        {
            _OsVehicleApp.InsertOrUpdate(OsVehicle);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _OsVehicleApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _OsVehicleApp.Remove(_OsVehicleApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// OsVehicle List.
        /// </summary>
        /// <returns>{ c.Id, c.Drive.DriveName, c.VehiclePlate.Plate, c.DateTimeInitial, c.DateTimeFinal }</returns>
        public IList ListOsVehicle()
        {
            return _OsVehicleApp.Search()
                .Select(c => new
                { c.Id, c.Drive.DriveName, c.VehiclePlate.Plate, c.DateTimeInitial, c.DateTimeFinal }).ToList();
        }

        /// <summary>
        /// OsVehicle List.
        /// </summary>
        /// <returns>{ c.Id, c.Drive.DriveName, c.VehiclePlate.Plate, c.DateTimeInitial, c.DateTimeFinal }</returns>
        public IList ListOsVehicle(Expression<Func<OsVehicle, bool>> expression)
        {
            return _OsVehicleApp.Search(expression)
                .Select(c => new
                { c.Id, c.Integration, c.Drive.DriveName, c.VehiclePlate.Plate, c.DateTimeInitial, c.DateTimeFinal }).ToList();
        }

        /// <summary>
        /// OsVehicle List.
        /// </summary>
        /// <returns>{ c.Id, c.Drive.DriveName, c.VehiclePlate.Plate, c.DateTimeInitial, c.DateTimeFinal }</returns>
        public IList Search(Expression<Func<OsVehicle, bool>> expression)
        {
            return _OsVehicleApp.Search(expression).ToList();
        }

        public bool Remove(Expression<Func<OsVehicle, bool>> expression)
        {
            _OsVehicleApp.Remove(_OsVehicleApp.Search(expression).ToList());
            return _connection.Save();
        }

        public OsVehicle FindId(int id)
        {
            return _OsVehicleApp.FindId(id);
        }
    }
}