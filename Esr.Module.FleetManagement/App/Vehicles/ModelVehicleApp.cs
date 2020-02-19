using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.FleetManagement.Domain.Vehicles;
using Esr.Module.FleetManagement.Repository.Vehicles;

namespace Esr.Module.FleetManagement.App.Vehicles
{
    public class ModelVehicleApp
    {
        private readonly IFactoryCommand<ModelVehicle> _epr;

        public ModelVehicleApp(IFactoryConnection efc)
        {
            _epr = new ModelVehicleRepo(efc);
        }

        public ModelVehicle FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<ModelVehicle> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(ModelVehicle ModelVehicle)
        {
            return _epr.InsertOrUpdate(ModelVehicle);
        }

        public IQueryable<ModelVehicle> Search(Expression<Func<ModelVehicle, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<ModelVehicle> Search()
        {
            return _epr.Search();
        }
    }
}