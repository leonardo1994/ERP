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
    public class InputStockController
    {
        private InputStockApp _InputStockApp; 
        private IFactoryConnection _connection;

        public InputStockController(IFactoryConnection connection)
        {
            _connection = connection;
            _InputStockApp = new InputStockApp(connection);
        }
        
        public bool Save(InputStock InputStock)
        {
            _InputStockApp.InsertOrUpdate(InputStock);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _InputStockApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _InputStockApp.Remove(_InputStockApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// InputStocks List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListInputStock()
        {
            return _InputStockApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.DateInput, c.Person.PersonName }).ToList();
        }

        public bool Remove(Expression<Func<InputStock, bool>> expression)
        {
            _InputStockApp.Remove(_InputStockApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<InputStock, bool>> expression)
        {
            return _InputStockApp.Search(expression).ToList();
        }

        public InputStock FindId(int id)
        {
            return _InputStockApp.FindId(id);
        }
    }
}