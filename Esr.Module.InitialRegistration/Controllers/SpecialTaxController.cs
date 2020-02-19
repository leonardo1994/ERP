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
    public class SpecialTaxController
    {
        private SpecialTaxApp _SpecialTaxApp;
        private IFactoryConnection _connection;

        public SpecialTaxController(IFactoryConnection connection)
        {
            _connection = connection;
            _SpecialTaxApp = new SpecialTaxApp(connection);
        }

        public bool Save(SpecialTax SpecialTax)
        {
            _SpecialTaxApp.InsertOrUpdate(SpecialTax);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _SpecialTaxApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _SpecialTaxApp.Remove(_SpecialTaxApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// SpecialTaxs List.
        /// </summary>
        /// <returns>{ c.Id, c.Taxation.Description, c.Aliquot, c.Iva }</returns>
        public IList ListSpecialTax()
        {
            return _SpecialTaxApp.Search()
                .Select(c => new
                { c.Id, c.Taxation.Description, c.Aliquot, c.Iva }).ToList();
        }

        /// <summary>
        /// SpecialTaxs List.
        /// </summary>
        /// <returns>{ c.Id, c.Taxation.Description, c.Aliquot, c.Iva }</returns>
        public IList Search(Expression<Func<SpecialTax, bool>> expression)
        {
            return _SpecialTaxApp.Search(expression)
                .Select(c => new
                { c.Id, c.Taxation.Description, c.Aliquot, c.Iva }).ToList();
        }

        public bool Remove(Expression<Func<SpecialTax, bool>> expression)
        {
            _SpecialTaxApp.Remove(_SpecialTaxApp.Search(expression).ToList());
            return _connection.Save();
        }

        public SpecialTax FindId(int id)
        {
            return _SpecialTaxApp.FindId(id);
        }
    }
}