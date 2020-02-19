using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Parking.Domain;
using Esr.Module.Parking.Repository;

namespace Esr.Module.Parking.App
{
    public class ParkingHoursVariationApp
    {
        private readonly IFactoryCommand<ParkingHoursVariation> _epr;

        public ParkingHoursVariationApp(IFactoryConnection efc)
        {
            _epr = new ParkingHoursVariationRepo(efc);
        }

        public ParkingHoursVariation FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<ParkingHoursVariation> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(ParkingHoursVariation ParkingHoursVariation)
        {
            return _epr.InsertOrUpdate(ParkingHoursVariation);
        }

        public IQueryable<ParkingHoursVariation> Search(Expression<Func<ParkingHoursVariation, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<ParkingHoursVariation> Search()
        {
            return _epr.Search();
        }
    }
}