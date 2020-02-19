using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Module.Funerary.App.OrderOfServices;
using Esr.Module.Funerary.Domain.OrderOfServices;
using System.Linq.Expressions;
using System;

namespace Esr.Module.Funerary.Controllers
{
    public class OsContractorProductController
    {
        private OsContractorProductApp _OsContractorProductApp;
        private IFactoryConnection _connection;

        public OsContractorProductController(IFactoryConnection connection)
        {
            _connection = connection;
            _OsContractorProductApp = new OsContractorProductApp(connection);
        }

        public bool Save(OsContractorProduct OsContractorProduct)
        {
            _OsContractorProductApp.InsertOrUpdate(OsContractorProduct);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _OsContractorProductApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _OsContractorProductApp.Remove(_OsContractorProductApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// OsContractorProduct List.
        /// </summary>
        /// <returns>{ c.Id, c.Contractor.PersonName, c.StockItem.Description, c.UnitMeasure.Initials, c.Quantity, c.UnitaryValue, c.ValueTotal }</returns>
        public IList ListOsContractorProduct()
        {
            return _OsContractorProductApp.Search()
                .Select(c => new
                { c.Id, c.Contractor.PersonName, c.StockItem.Description, c.UnitMeasure.Initials, c.Quantity, c.UnitaryValue, c.ValueTotal }).ToList();
        }

        public bool Remove(Expression<Func<OsContractorProduct, bool>> expression)
        {
            _OsContractorProductApp.Remove(_OsContractorProductApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<OsContractorProduct, bool>> expression)
        {
            return _OsContractorProductApp.Search(expression).ToList();
        }

        public OsContractorProduct FindId(int id)
        {
            return _OsContractorProductApp.FindId(id);
        }
    }
}