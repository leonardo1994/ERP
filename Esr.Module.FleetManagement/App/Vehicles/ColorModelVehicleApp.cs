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
    public class ColorModelVehicleApp
    {
        private readonly IFactoryCommand<ColorModelVehicle> _epr;

        public ColorModelVehicleApp(IFactoryConnection efc)
        {
            _epr = new ColorModelVehicleRepo(efc);
        }

        public ColorModelVehicle FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<ColorModelVehicle> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(ColorModelVehicle ColorModelVehicle)
        {
            return _epr.InsertOrUpdate(ColorModelVehicle);
        }

        public IQueryable<ColorModelVehicle> Search(Expression<Func<ColorModelVehicle, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<ColorModelVehicle> Search()
        {
            return _epr.Search();
        }
    }
}