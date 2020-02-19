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
    public class VehiclePlateApp
    {
        private readonly IFactoryCommand<VehiclePlate> _epr;

        public VehiclePlateApp(IFactoryConnection efc)
        {
            _epr = new VehiclePlateRepo(efc);
        }

        public VehiclePlate FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<VehiclePlate> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(VehiclePlate Vehicle)
        {
            return _epr.InsertOrUpdate(Vehicle);
        }

        public IQueryable<VehiclePlate> Search(Expression<Func<VehiclePlate, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<VehiclePlate> Search()
        {
            return _epr.Search();
        }
    }
}