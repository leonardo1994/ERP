using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Parking.Domain;
using Esr.Module.Parking.Repository;

namespace Esr.Module.Parking.App
{
    public class ParkingTableOfPriceApp
    {
        private readonly IFactoryCommand<ParkingTableOfPrice> _epr;

        public ParkingTableOfPriceApp(IFactoryConnection efc)
        {
            _epr = new ParkingTableOfPriceRepo(efc);
        }

        public ParkingTableOfPrice FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<ParkingTableOfPrice> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(ParkingTableOfPrice ParkingTableOfPrice)
        {
            return _epr.InsertOrUpdate(ParkingTableOfPrice);
        }

        public IQueryable<ParkingTableOfPrice> Search(Expression<Func<ParkingTableOfPrice, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<ParkingTableOfPrice> Search()
        {
            return _epr.Search();
        }
    }
}