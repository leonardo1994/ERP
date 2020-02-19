using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Linq;
using Esr.Module.Parking.Domain;
using Esr.Core.Repository;

namespace Esr.Module.Parking.Repository
{
    public class ParkingInOutRepo : IFactoryCommand<ParkingInOut>
    {
        private readonly IFactoryCommand<ParkingInOut> _efcmd;

        public ParkingInOutRepo(IFactoryConnection efc)
        {
            IFactoryRepository<ParkingInOut> efr = new DbContext<ParkingInOut>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(ParkingInOut eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(ParkingInOut eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<ParkingInOut> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public ParkingInOut FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<ParkingInOut> Search(Expression<Func<ParkingInOut, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<ParkingInOut> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<ParkingInOut> AsNoTracking(Expression<Func<ParkingInOut, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<ParkingInOut> SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<ParkingInOut> IFactoryCommand<ParkingInOut>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<ParkingInOut>.SearchOfType<T>(Expression<Func<ParkingInOut, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}