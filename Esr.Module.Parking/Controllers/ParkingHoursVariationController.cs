using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Parking.App;
using Esr.Module.Parking.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.Parking.Controllers
{
    public class ParkingHoursVariationController
    {
        private ParkingHoursVariationApp _ParkingHoursVariationApp; 
        private IFactoryConnection _connection;

        public ParkingHoursVariationController(IFactoryConnection connection)
        {
            _connection = connection;
            _ParkingHoursVariationApp = new ParkingHoursVariationApp(connection);
        }
        
        public bool Save(ParkingHoursVariation ParkingHoursVariation)
        {
            _ParkingHoursVariationApp.InsertOrUpdate(ParkingHoursVariation);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ParkingHoursVariationApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ParkingHoursVariationApp.Remove(_ParkingHoursVariationApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// ParkingHoursVariations List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListParkingHoursVariation(Expression<Func<ParkingHoursVariation, bool>> expression)
        {
            return _ParkingHoursVariationApp.Search(expression)
                .Select(c => new
                {
                    c.Id,
                    c.ParkingItemTableOfPriceId,
                    c.Integration,
                    c.ParkingFixedTime,
                    c.ParkingStartingTime,
                    c.ParkingFinalHour,
                    c.ParkingValue
                }).ToList();
        }

        public bool Remove(Expression<Func<ParkingHoursVariation, bool>> expression)
        {
            _ParkingHoursVariationApp.Remove(_ParkingHoursVariationApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<ParkingHoursVariation, bool>> expression)
        {
            return _ParkingHoursVariationApp.Search(expression).ToList();
        }

        public ParkingHoursVariation FindId(int id)
        {
            return _ParkingHoursVariationApp.FindId(id);
        }
    }
}