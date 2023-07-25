using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Module.FleetManagement.App.Vehicles;
using Esr.Module.FleetManagement.Domain.Vehicles;
using System.Linq.Expressions;
using System;
using System.Windows;

namespace Esr.Module.FleetManagement.Controllers
{
    public class ColorModelVehicleController
    {
        private ColorModelVehicleApp _ColorModelVehicleApp;
        private IFactoryConnection _connection;

        public ColorModelVehicleController(IFactoryConnection connection)
        {
            _connection = connection;
            _ColorModelVehicleApp = new ColorModelVehicleApp(connection);
        }

        public bool Save(ColorModelVehicle ColorModelVehicle)
        {
            _ColorModelVehicleApp.InsertOrUpdate(ColorModelVehicle);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ColorModelVehicleApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ColorModelVehicleApp.Remove(_ColorModelVehicleApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// ColorModelVehicles List
        /// </summary>
        /// <returns>{ c.Id, Color = c.Color.Description, Model = c.ModelVehicle.Description }</returns>
        public IList ListColorModelVehicle(Expression<Func<ColorModelVehicle, bool>> expression)
        {
            return _ColorModelVehicleApp.Search(expression)
                .Select(c => new
                { c.Color.Id, Color = c.Color.Description, Model = c.ModelVehicle.Description }).ToList();
        }

        public IList Search(Expression<Func<ColorModelVehicle, bool>> expression)
        {
            return _ColorModelVehicleApp.Search(expression)
                .Select(c => new
                { c.Id, Color = c.Color.Description, Model = c.ModelVehicle.Description }).ToList();
        }

        public bool Remove(Expression<Func<ColorModelVehicle, bool>> expression)
        {
            _ColorModelVehicleApp.Remove(_ColorModelVehicleApp.Search(expression).ToList());
            return _connection.Save();
        }

        public ColorModelVehicle FindId(int id)
        {
            return _ColorModelVehicleApp.FindId(id);
        }
    }
}