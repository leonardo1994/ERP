using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Linq;
using Esr.Module.Parking.Domain;
using Esr.Core.Repository;

namespace Esr.Module.Parking.Repository
{
    public class ParkingTableOfPriceRepo : IFactoryCommand<ParkingTableOfPrice>
    {
        private readonly IFactoryCommand<ParkingTableOfPrice> _efcmd;

        public ParkingTableOfPriceRepo(IFactoryConnection efc)
        {
            IFactoryRepository<ParkingTableOfPrice> efr = new DbContext<ParkingTableOfPrice>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(ParkingTableOfPrice eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(ParkingTableOfPrice eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<ParkingTableOfPrice> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public ParkingTableOfPrice FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<ParkingTableOfPrice> Search(Expression<Func<ParkingTableOfPrice, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<ParkingTableOfPrice> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<ParkingTableOfPrice> AsNoTracking(Expression<Func<ParkingTableOfPrice, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<ParkingTableOfPrice> SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<ParkingTableOfPrice> IFactoryCommand<ParkingTableOfPrice>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<ParkingTableOfPrice>.SearchOfType<T>(Expression<Func<ParkingTableOfPrice, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}