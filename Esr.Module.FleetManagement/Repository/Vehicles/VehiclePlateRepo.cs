using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.FleetManagement.Domain.Vehicles;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.FleetManagement.Repository.Vehicles
{
    public class VehiclePlateRepo : IFactoryCommand<VehiclePlate>
    {
        private readonly IFactoryCommand<VehiclePlate> _efcmd;

        public VehiclePlateRepo(IFactoryConnection efc)
        {
            IFactoryRepository<VehiclePlate> efr = new OdbcSqlServer<VehiclePlate>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(VehiclePlate eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(VehiclePlate eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<VehiclePlate> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public VehiclePlate FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<VehiclePlate> Search(Expression<Func<VehiclePlate, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<VehiclePlate> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<VehiclePlate> AsNoTracking(Expression<Func<VehiclePlate, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<VehiclePlate> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<VehiclePlate> IFactoryCommand<VehiclePlate>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<VehiclePlate>.SearchOfType<T>(Expression<Func<VehiclePlate, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
