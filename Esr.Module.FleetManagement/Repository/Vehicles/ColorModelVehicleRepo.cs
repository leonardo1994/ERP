using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.FleetManagement.Domain.Vehicles;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.FleetManagement.Repository.Vehicles
{
    public class ColorModelVehicleRepo : IFactoryCommand<ColorModelVehicle>
    {
        private readonly IFactoryCommand<ColorModelVehicle> _efcmd;

        public ColorModelVehicleRepo(IFactoryConnection efc)
        {
            IFactoryRepository<ColorModelVehicle> efr = new OdbcSqlServer<ColorModelVehicle>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(ColorModelVehicle eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(ColorModelVehicle eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<ColorModelVehicle> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public ColorModelVehicle FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<ColorModelVehicle> Search(Expression<Func<ColorModelVehicle, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<ColorModelVehicle> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<ColorModelVehicle> AsNoTracking(Expression<Func<ColorModelVehicle, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<ColorModelVehicle> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<ColorModelVehicle> IFactoryCommand<ColorModelVehicle>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<ColorModelVehicle>.SearchOfType<T>(Expression<Func<ColorModelVehicle, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
