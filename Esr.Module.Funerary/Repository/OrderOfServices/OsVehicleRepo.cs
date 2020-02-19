using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.OrderOfServices;
using System.Data.Entity;
using System.Linq;
using Esr.Core.Repository;

namespace Esr.Module.Funerary.Repository.OrderOfServices
{
    public class OsVehicleRepo : IFactoryCommand<OsVehicle>
    {
        private readonly IFactoryCommand<OsVehicle> _efcmd;

        public OsVehicleRepo(IFactoryConnection efc)
        {
            IFactoryRepository<OsVehicle> efr = new DbContext<OsVehicle>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(OsVehicle eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(OsVehicle eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<OsVehicle> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public OsVehicle FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<OsVehicle> Search(Expression<Func<OsVehicle, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<OsVehicle> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<OsVehicle> AsNoTracking(Expression<Func<OsVehicle, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<OsVehicle> IFactoryCommand<OsVehicle>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<OsVehicle> IFactoryCommand<OsVehicle>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<OsVehicle>.SearchOfType<T>(Expression<Func<OsVehicle, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
