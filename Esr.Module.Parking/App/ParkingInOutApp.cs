using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Parking.Domain;
using Esr.Module.Parking.Repository;
using Esr.Core.App.ConfNumbering;
using Esr.Core.App.FiltersCompanies;

namespace Esr.Module.Parking.App
{
    public class ParkingInOutApp
    {
        private readonly IFactoryCommand<ParkingInOut> _epr;
        private readonly AutomaticNumberingApp _autNumApp;
        private readonly DbTableApp _dbTableApp;

        public ParkingInOutApp(IFactoryConnection efc)
        {
            _epr = new ParkingInOutRepo(efc);
            _autNumApp = new AutomaticNumberingApp(efc);
            _dbTableApp = new DbTableApp(efc);
        }

        public ParkingInOut FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<ParkingInOut> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(ParkingInOut ParkingInOut)
        {
            return _epr.InsertOrUpdate(ParkingInOut);
        }

        public IQueryable<ParkingInOut> Search(Expression<Func<ParkingInOut, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<ParkingInOut> Search()
        {
            return _epr.Search();
        }

        public bool GerarEntrada(ParkingInOut parkingInOut)
        {
            var dbTableId = _dbTableApp.Search(c => c.TableName == "ParkingInOut").Select(c => new { c.Id }).FirstOrDefault();
            parkingInOut.TicketNumber = _autNumApp.GerarSequencia(dbTableId.Id, "TicketNumber").GetValueOrDefault(0) ;
            parkingInOut.ParkingDateTimeInput = DateTime.Now;
            return _epr.InsertOrUpdate(parkingInOut);
        }
    }
}