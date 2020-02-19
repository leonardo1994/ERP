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
    public class VehicleApp
    {
        private readonly IFactoryCommand<Vehicle> _epr;

        public VehicleApp(IFactoryConnection efc)
        {
            _epr = new VehicleRepo(efc);
        }

        public Vehicle FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Vehicle> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Vehicle Vehicle)
        {
            return _epr.InsertOrUpdate(Vehicle);
        }

        public IQueryable<Vehicle> Search(Expression<Func<Vehicle, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Vehicle> Search()
        {
            return _epr.Search();
        }
    }
}