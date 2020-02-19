using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Stock.App.InputsOutputs;
using Esr.Module.Stock.App.InputsOutPuts;
using Esr.Module.Stock.Domain.Movements;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.Stock.Controllers
{
    public class OutputStockController
    {
        private OutputStockApp _OutputStockApp; 
        private IFactoryConnection _connection;

        public OutputStockController(IFactoryConnection connection)
        {
            _connection = connection;
            _OutputStockApp = new OutputStockApp(connection);
        }
        
        public bool Save(OutputStock OutputStock)
        {
            _OutputStockApp.InsertOrUpdate(OutputStock);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _OutputStockApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _OutputStockApp.Remove(_OutputStockApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// OutputStocks List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.DateOutput, c.Person.PersonName }</returns>
        public IList ListOutputStock()
        {
            return _OutputStockApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.DateOutput, c.Person.PersonName }).ToList();
        }

        public bool Remove(Expression<Func<OutputStock, bool>> expression)
        {
            _OutputStockApp.Remove(_OutputStockApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<OutputStock, bool>> expression)
        {
            return _OutputStockApp.Search(expression).ToList();
        }

        public OutputStock FindId(int id)
        {
            return _OutputStockApp.FindId(id);
        }
    }
}