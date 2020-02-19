using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Stock.App.InputsOutputs;
using Esr.Module.Stock.Domain.Movements;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.Stock.Controllers
{
    public class ItemOutputStockController
    {
        private ItemOutputStockApp _ItemOutputStockApp; 
        private IFactoryConnection _connection;

        public ItemOutputStockController(IFactoryConnection connection)
        {
            _connection = connection;
            _ItemOutputStockApp = new ItemOutputStockApp(connection);
        }
        
        public bool Save(ItemOutputStock ItemOutputStock)
        {
            _ItemOutputStockApp.InsertOrUpdate(ItemOutputStock);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ItemOutputStockApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ItemOutputStockApp.Remove(_ItemOutputStockApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// ItemOutputStocks List.
        /// </summary>
        /// <returns>{ c.Id, c.StockItem.Code, c.StockItem.Description, c.LocalStock.LocalCode, c.UnitMeasure.Initials, c.Quantity, c.UnitaryValue, c.Total }</returns>
        public IList ListItemOutputStock(Expression<Func<ItemOutputStock, bool>> expression)
        {
            return _ItemOutputStockApp.Search()
                 .Select(c => new
                 { c.Id, c.OutputStockId, c.StockItem.Code, c.StockItem.Description, c.LocalStock.LocalCode, c.UnitMeasure.Initials, c.Quantity, c.UnitaryValue, c.Total, c.Integration }).ToList();
        }

        /// <summary>
        /// ItemOutputStocks List.
        /// </summary>
        /// <returns>{ c.Id, c.StockItem.Code, c.StockItem.Description, c.LocalStock.LocalCode, c.UnitMeasure.Initials, c.Quantity, c.UnitaryValue, c.Total }</returns>
        public IList Search(Expression<Func<ItemOutputStock, bool>> expression)
        {
            return _ItemOutputStockApp.Search(expression).ToList();
               
        }

        public bool Remove(Expression<Func<ItemOutputStock, bool>> expression)
        {
            _ItemOutputStockApp.Remove(_ItemOutputStockApp.Search(expression).ToList());
            return _connection.Save();
        }

        public ItemOutputStock FindId(int id)
        {
            return _ItemOutputStockApp.FindId(id);
        }
    }
}