using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.StockItems;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class StockItemController
    {
        private StockItemApp _StockItemApp; 
        private IFactoryConnection _connection;

        public StockItemController(IFactoryConnection connection)
        {
            _connection = connection;
            _StockItemApp = new StockItemApp(connection);
        }
        
        public bool Save(StockItem StockItem)
        {
            _StockItemApp.InsertOrUpdate(StockItem);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _StockItemApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _StockItemApp.Remove(_StockItemApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// StockItems List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description, c.UnitMeasure.Initials, c.Family.FamilyName, c.Situation }</returns>
        public IList ListStockItem()
        {
            return _StockItemApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.Description, c.UnitMeasure.Initials, c.Family.FamilyName }).ToList();
        }

        public bool Remove(Expression<Func<StockItem, bool>> expression)
        {
            _StockItemApp.Remove(_StockItemApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<StockItem, bool>> expression)
        {
            return _StockItemApp.Search(expression).ToList();
        }

        public IList SearchAll()
        {
            return _StockItemApp
                .Search()
                .Select(c => new { c.Id, c.Code, CodeDescription = c.Code + " - " + c.Description })
                .ToList();
        }

        public StockItem FindId(int id)
        {
            return _StockItemApp.FindId(id);
        }
    }
}