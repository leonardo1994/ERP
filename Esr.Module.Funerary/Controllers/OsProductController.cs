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
    public class OsProductController
    {
        private OsProductApp _OsProductApp;
        private IFactoryConnection _connection;

        public OsProductController(IFactoryConnection connection)
        {
            _connection = connection;
            _OsProductApp = new OsProductApp(connection);
        }

        public bool Save(OsProduct OsProduct)
        {
            _connection.BeginTransaction();
            if (_OsProductApp.InsertOrUpdate(OsProduct))
            {
                _connection.Save();
                _connection.Commit();
                return true;
            }
            else
            {
                _connection.Rollback();
                return false;
            }
        }

        public bool RemoveId(int id)
        {
            _OsProductApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _OsProductApp.Remove(_OsProductApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        public bool RemoveListId(Expression<Func<OsProduct, bool>> expression)
        {
            _OsProductApp.Remove(_OsProductApp.Search(expression).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// OsProduct List.
        /// </summary>
        /// <returns>{ c.Id, c.Provider.PersonName, c.StockItem.Description, c.UnitMeasure.Initials, c.Quantity, c.UnitaryValue, c.ValueTotal }</returns>
        public IList ListOsProduct(Expression<Func<OsProduct, bool>> expression)
        {
            return _OsProductApp.Search(expression)
                .Select(c => new
                { c.Id, c.Integration, c.Provider.PersonName, c.StockItem.Description, c.UnitMeasure.Initials, c.Quantity, c.UnitaryValue, c.ValueTotal }).ToList();
        }

        public IList<OsProduct> Search(Expression<Func<OsProduct, bool>> expression)
        {
            return _OsProductApp.Search(expression).ToList();
        }

        public bool Remove(Expression<Func<OsProduct, bool>> expression)
        {
            _OsProductApp.Remove(_OsProductApp.Search(expression).ToList());
            return _connection.Save();
        }

        public OsProduct FindId(int id)
        {
            return _OsProductApp.FindId(id);
        }
    }
}