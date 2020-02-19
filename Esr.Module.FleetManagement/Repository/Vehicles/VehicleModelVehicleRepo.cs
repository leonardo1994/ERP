using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.FleetManagement.Domain.Vehicles;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.FleetManagement.Repository.Vehicles
{
    public class VehicleModelVehicleRepo : IFactoryCommand<VehicleModelVehicle>
    {
        private readonly IFactoryCommand<VehicleModelVehicle> _efcmd;

        public VehicleModelVehicleRepo(IFactoryConnection efc)
        {
            IFactoryRepository<VehicleModelVehicle> efr = new OdbcSqlServer<VehicleModelVehicle>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(VehicleModelVehicle eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(VehicleModelVehicle eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<VehicleModelVehicle> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public VehicleModelVehicle FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<VehicleModelVehicle> Search(Expression<Func<VehicleModelVehicle, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<VehicleModelVehicle> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<VehicleModelVehicle> AsNoTracking(Expression<Func<VehicleModelVehicle, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<VehicleModelVehicle> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<VehicleModelVehicle> IFactoryCommand<VehicleModelVehicle>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<VehicleModelVehicle>.SearchOfType<T>(Expression<Func<VehicleModelVehicle, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
