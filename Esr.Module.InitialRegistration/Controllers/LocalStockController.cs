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
    public class LocalStockController
    {
        private LocalStockApp _LocalStockApp; 
        private IFactoryConnection _connection;

        public LocalStockController(IFactoryConnection connection)
        {
            _connection = connection;
            _LocalStockApp = new LocalStockApp(connection);
        }
        
        public bool Save(LocalStock LocalStock)
        {
            _LocalStockApp.InsertOrUpdate(LocalStock);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _LocalStockApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _LocalStockApp.Remove(_LocalStockApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// LocalStocks List.
        /// </summary>
        /// <returns>{ c.Id, c.LocalCode, c.LocalName, c.TypeStructure,  LocalStockMasterCode = c.LocalStockMaster.LocalCode, LocalStockMasterName = c.LocalStockMaster.LocalName }</returns>
        public IList ListLocalStock()
        {
            return _LocalStockApp.Search()
                .Select(c => new
                { c.Id, c.LocalCode, c.LocalName, c.TypeStructure,  LocalStockMasterCode = c.LocalStockMaster.LocalCode, LocalStockMasterName = c.LocalStockMaster.LocalName }).ToList();
        }

        /// <summary>
        /// LocalStocks List.
        /// </summary>
        /// <returns>{ c.Id, c.LocalCode, c.LocalName, c.TypeStructure,  LocalStockMasterCode = c.LocalStockMaster.LocalCode, LocalStockMasterName = c.LocalStockMaster.LocalName }</returns>
        public IList ListLocalStock(Expression<Func<LocalStock, bool>> expression)
        {
            return _LocalStockApp.Search(expression)
                .Select(c => new
                { c.Id, c.LocalCode, c.LocalName, c.TypeStructure, LocalStockMasterCode = c.LocalStockMaster.LocalCode, LocalStockMasterName = c.LocalStockMaster.LocalName }).ToList();
        }

        public bool Remove(Expression<Func<LocalStock, bool>> expression)
        {
            _LocalStockApp.Remove(_LocalStockApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<LocalStock, bool>> expression)
        {
            return _LocalStockApp.Search(expression).ToList();
        }

        public LocalStock FindId(int id)
        {
            return _LocalStockApp.FindId(id);
        }
    }
}