using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Parking.Domain;
using Esr.Module.Parking.Repository;

namespace Esr.Module.Parking.App
{
    public class ParkingAgreementApp
    {
        private readonly IFactoryCommand<ParkingAgreement> _epr;

        public ParkingAgreementApp(IFactoryConnection efc)
        {
            _epr = new ParkingAgreementRepo(efc);
        }

        public ParkingAgreement FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<ParkingAgreement> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(ParkingAgreement ParkingAgreement)
        {
            return _epr.InsertOrUpdate(ParkingAgreement);
        }

        public IQueryable<ParkingAgreement> Search(Expression<Func<ParkingAgreement, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<ParkingAgreement> Search()
        {
            return _epr.Search();
        }
    }
}