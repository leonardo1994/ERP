using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.FleetManagement.Domain.Vehicles;
using System.Linq;

namespace Esr.Module.FleetManagement.Repository.Vehicles
{
    public class ModelVehicleRepo : IFactoryCommand<ModelVehicle>
    {
        private readonly IFactoryCommand<ModelVehicle> _efcmd;

        public ModelVehicleRepo(IFactoryConnection efc)
        {
            IFactoryRepository<ModelVehicle> efr = new OdbcSqlServer<ModelVehicle>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(ModelVehicle eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(ModelVehicle eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<ModelVehicle> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public ModelVehicle FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<ModelVehicle> Search(Expression<Func<ModelVehicle, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<ModelVehicle> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<ModelVehicle> AsNoTracking(Expression<Func<ModelVehicle, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<ModelVehicle> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<ModelVehicle> IFactoryCommand<ModelVehicle>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<ModelVehicle>.SearchOfType<T>(Expression<Func<ModelVehicle, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
