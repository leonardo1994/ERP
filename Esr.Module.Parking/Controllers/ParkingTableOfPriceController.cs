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
    public class ParkingTableOfPriceController
    {
        private ParkingTableOfPriceApp _ParkingTableOfPriceApp; 
        private IFactoryConnection _connection;

        public ParkingTableOfPriceController(IFactoryConnection connection)
        {
            _connection = connection;
            _ParkingTableOfPriceApp = new ParkingTableOfPriceApp(connection);
        }
        
        public bool Save(ParkingTableOfPrice ParkingTableOfPrice)
        {
            _ParkingTableOfPriceApp.InsertOrUpdate(ParkingTableOfPrice);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ParkingTableOfPriceApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ParkingTableOfPriceApp.Remove(_ParkingTableOfPriceApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// ParkingTableOfPrices List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListParkingTableOfPrice()
        {
            return _ParkingTableOfPriceApp.Search()
                .Select(c => new
                {
                    c.Id,
                    c.Code,
                    c.Description,
                    c.Integration
                }).ToList();
        }

        public bool Remove(Expression<Func<ParkingTableOfPrice, bool>> expression)
        {
            _ParkingTableOfPriceApp.Remove(_ParkingTableOfPriceApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<ParkingTableOfPrice, bool>> expression)
        {
            return _ParkingTableOfPriceApp.Search(expression).ToList();
        }

        public ParkingTableOfPrice FindId(int id)
        {
            return _ParkingTableOfPriceApp.FindId(id);
        }
    }
}