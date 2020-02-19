using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Linq;
using Esr.Module.Parking.Domain;
using Esr.Core.Repository;

namespace Esr.Module.Parking.Repository
{
    public class ParkingHoursVariationRepo : IFactoryCommand<ParkingHoursVariation>
    {
        private readonly IFactoryCommand<ParkingHoursVariation> _efcmd;

        public ParkingHoursVariationRepo(IFactoryConnection efc)
        {
            IFactoryRepository<ParkingHoursVariation> efr = new DbContext<ParkingHoursVariation>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(ParkingHoursVariation eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(ParkingHoursVariation eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<ParkingHoursVariation> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public ParkingHoursVariation FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<ParkingHoursVariation> Search(Expression<Func<ParkingHoursVariation, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<ParkingHoursVariation> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<ParkingHoursVariation> AsNoTracking(Expression<Func<ParkingHoursVariation, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<ParkingHoursVariation> SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<ParkingHoursVariation> IFactoryCommand<ParkingHoursVariation>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<ParkingHoursVariation>.SearchOfType<T>(Expression<Func<ParkingHoursVariation, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}