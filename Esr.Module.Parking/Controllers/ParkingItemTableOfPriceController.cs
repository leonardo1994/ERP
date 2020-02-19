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
    public class ParkingItemTableOfPriceController
    {
        private ParkingItemTableOfPriceApp _ParkingItemTableOfPriceApp; 
        private IFactoryConnection _connection;

        public ParkingItemTableOfPriceController(IFactoryConnection connection)
        {
            _connection = connection;
            _ParkingItemTableOfPriceApp = new ParkingItemTableOfPriceApp(connection);
        }
        
        public bool Save(ParkingItemTableOfPrice ParkingItemTableOfPrice)
        {
            _ParkingItemTableOfPriceApp.InsertOrUpdate(ParkingItemTableOfPrice);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ParkingItemTableOfPriceApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ParkingItemTableOfPriceApp.Remove(_ParkingItemTableOfPriceApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// ParkingItemTableOfPrices List.
        /// </summary>
        /// <returns>{c.Id,c.CategoryType,c.FixedTime,c.StartingTime,c.FinalHour,c.Value,c.Monday,c.Tuesday,c.Wednesday,c.Thursday,c.Friday,c.Saturday,c.Sunday,c.Holiday}</returns>
        public IList ListParkingItemTableOfPrice(Expression<Func<ParkingItemTableOfPrice, bool>> expression)
        {
            return _ParkingItemTableOfPriceApp.Search(expression)
                .Select(c => new
                {
                    c.Id,
                    c.ParkingTableOfPriceId,
                    c.Situation,
                    c.Description,
                    c.Integration,
                    c.Tolerance,
                    c.MaxinumPrice,
                    c.ValueOvertime,
                    c.Monday,
                    c.Tuesday,
                    c.Wednesday,
                    c.Thursday,
                    c.Friday,
                    c.Saturday,
                    c.Sunday,
                    c.Holiday
                }).ToList();
        }

        public bool Remove(Expression<Func<ParkingItemTableOfPrice, bool>> expression)
        {
            _ParkingItemTableOfPriceApp.Remove(_ParkingItemTableOfPriceApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<ParkingItemTableOfPrice, bool>> expression)
        {
            return _ParkingItemTableOfPriceApp.Search(expression).ToList();
        }

        public ParkingItemTableOfPrice FindId(int id)
        {
            return _ParkingItemTableOfPriceApp.FindId(id);
        }
    }
}