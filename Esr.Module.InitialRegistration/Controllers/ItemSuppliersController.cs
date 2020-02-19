using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.ItemSupplierss;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class ItemSuppliersController
    {
        private ItemSuppliersApp _ItemSuppliersApp; 
        private IFactoryConnection _connection;

        public ItemSuppliersController(IFactoryConnection connection)
        {
            _connection = connection;
            _ItemSuppliersApp = new ItemSuppliersApp(connection);
        }
        
        public bool Save(ItemSuppliers ItemSuppliers)
        {
            _ItemSuppliersApp.InsertOrUpdate(ItemSuppliers);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ItemSuppliersApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ItemSuppliersApp.Remove(_ItemSuppliersApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        public IList ListItemProvider(Expression<Func<ItemSuppliers, bool>> expression)
        {
            return _ItemSuppliersApp.Search(expression).Select(c => new
            {
                Id = c.ProviderId,
                c.Provider.PersonName,
                c.Integration,
                c.Value
            }).ToList();
        }

        /// <summary>
        /// ItemSupplierss List.
        /// </summary>
        /// <returns>{ c.Id, c.Provider.PersonName, c.StockItem.Description, c.Value }</returns>
        public IList ListItemSuppliers(Expression<Func<ItemSuppliers, bool>> expression)
        {
            return _ItemSuppliersApp.Search(expression)
                .Select(c => new
                { c.Id, c.Provider.PersonName, c.StockItem.Description, c.Value, c.Integration }).ToList();
        }

        /// <summary>
        /// ItemSupplierss List.
        /// </summary>
        /// <returns>{ c.Id, c.Provider.PersonName, c.StockItem.Description, c.Value }</returns>
        public IList<ItemSuppliers> Search(Expression<Func<ItemSuppliers, bool>> expression)
        {
            return _ItemSuppliersApp.Search(expression).ToList();
        }

        public bool Remove(Expression<Func<ItemSuppliers, bool>> expression)
        {
            _ItemSuppliersApp.Remove(_ItemSuppliersApp.Search(expression).ToList());
            return _connection.Save();
        }

        public ItemSuppliers FindId(int id)
        {
            return _ItemSuppliersApp.FindId(id);
        }
    }
}