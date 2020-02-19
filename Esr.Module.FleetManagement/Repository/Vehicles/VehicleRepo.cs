using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.FleetManagement.Domain.Vehicles;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.FleetManagement.Repository.Vehicles
{
    public class VehicleRepo : IFactoryCommand<Vehicle>
    {
        private readonly IFactoryCommand<Vehicle> _efcmd;

        public VehicleRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Vehicle> efr = new OdbcSqlServer<Vehicle>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Vehicle eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Vehicle eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Vehicle> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Vehicle FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Vehicle> Search(Expression<Func<Vehicle, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Vehicle> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Vehicle> AsNoTracking(Expression<Func<Vehicle, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<Vehicle> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Vehicle> IFactoryCommand<Vehicle>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Vehicle>.SearchOfType<T>(Expression<Func<Vehicle, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
