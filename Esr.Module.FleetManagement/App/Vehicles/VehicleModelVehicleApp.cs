using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.FleetManagement.Domain.Vehicles;
using Esr.Module.FleetManagement.Repository.Vehicles;
using Esr.Core.Domain.Other;

namespace Esr.Module.FleetManagement.App.Vehicles
{
    public class VehicleModelVehicleApp
    {
        private readonly IFactoryCommand<VehicleModelVehicle> _epr;

        public VehicleModelVehicleApp(IFactoryConnection efc)
        {
            _epr = new VehicleModelVehicleRepo(efc);
        }

        public VehicleModelVehicle FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<VehicleModelVehicle> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(VehicleModelVehicle Vehicle)
        {
            return _epr.InsertOrUpdate(Vehicle);
        }

        public IQueryable<VehicleModelVehicle> Search(Expression<Func<VehicleModelVehicle, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<VehicleModelVehicle> Search()
        {
            return _epr.Search();
        }
    }
}