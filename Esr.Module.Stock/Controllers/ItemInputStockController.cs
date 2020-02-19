using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.RH;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Module.Stock.App.InputsOutputs;
using Esr.Module.Stock.Domain.Movements;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.Stock.Controllers
{
    public class ItemInputStockController
    {
        private ItemInputStockApp _ItemInputStockApp; 
        private IFactoryConnection _connection;

        public ItemInputStockController(IFactoryConnection connection)
        {
            _connection = connection;
            _ItemInputStockApp = new ItemInputStockApp(connection);
        }
        
        public bool Save(ItemInputStock ItemInputStock)
        {
            _ItemInputStockApp.InsertOrUpdate(ItemInputStock);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ItemInputStockApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ItemInputStockApp.Remove(_ItemInputStockApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// ItemInputStocks List.
        /// </summary>
        /// <returns>{ c.Id, c.StockItem.Code, c.StockItem.Description, c.LocalStock.LocalCode, c.UnitMeasure.Initials, c.Quantity, c.UnitaryValue, c.Total }</returns>
        public IList ListItemInputStock(Expression<Func<ItemInputStock, bool>> expression)
        {
            return _ItemInputStockApp.Search()
                .Select(c => new
                { c.Id, c.StockItem.Code, c.StockItem.Description, c.LocalStock.LocalCode, c.UnitMeasure.Initials, c.Quantity, c.UnitaryValue, c.Total, c.Integration }).ToList();
        }

        /// <summary>
        /// ItemInputStocks List.
        /// </summary>
        /// <returns>{ c.Id, c.StockItem.Code, c.StockItem.Description, c.LocalStock.LocalCode, c.UnitMeasure.Initials, c.Quantity, c.UnitaryValue, c.Total }</returns>
        public IList Search(Expression<Func<ItemInputStock, bool>> expression)
        {
            return _ItemInputStockApp.Search(expression).ToList();
        }

        public bool Remove(Expression<Func<ItemInputStock, bool>> expression)
        {
            _ItemInputStockApp.Remove(_ItemInputStockApp.Search(expression).ToList());
            return _connection.Save();
        }

        public ItemInputStock FindId(int id)
        {
            return _ItemInputStockApp.FindId(id);
        }
    }
}