using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Linq;
using Esr.Module.Parking.Domain;
using Esr.Core.Repository;

namespace Esr.Module.Parking.Repository
{
    public class ParkingItemTableOfPriceRepo : IFactoryCommand<ParkingItemTableOfPrice>
    {
        private readonly IFactoryCommand<ParkingItemTableOfPrice> _efcmd;

        public ParkingItemTableOfPriceRepo(IFactoryConnection efc)
        {
            IFactoryRepository<ParkingItemTableOfPrice> efr = new DbContext<ParkingItemTableOfPrice>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(ParkingItemTableOfPrice eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(ParkingItemTableOfPrice eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<ParkingItemTableOfPrice> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public ParkingItemTableOfPrice FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<ParkingItemTableOfPrice> Search(Expression<Func<ParkingItemTableOfPrice, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<ParkingItemTableOfPrice> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<ParkingItemTableOfPrice> AsNoTracking(Expression<Func<ParkingItemTableOfPrice, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<ParkingItemTableOfPrice> SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<ParkingItemTableOfPrice> IFactoryCommand<ParkingItemTableOfPrice>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<ParkingItemTableOfPrice>.SearchOfType<T>(Expression<Func<ParkingItemTableOfPrice, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}