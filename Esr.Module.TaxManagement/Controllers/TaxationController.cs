using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.TaxManagement.App.Taxations;
using Esr.Module.TaxManagement.Domain.Taxations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.Stock.Controllers
{
    public class TaxationController
    {
        private TaxationApp _TaxationApp; 
        private IFactoryConnection _connection;

        public TaxationController(IFactoryConnection connection)
        {
            _connection = connection;
            _TaxationApp = new TaxationApp(connection);
        }
        
        public bool Save(Taxation Taxation)
        {
            _TaxationApp.InsertOrUpdate(Taxation);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _TaxationApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _TaxationApp.Remove(_TaxationApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Taxations List.
        /// </summary>
        /// <returns>{ c.Id, c.Initials, c.StandardRate, c.Description, c.TaxesOnBooks }</returns>
        public IList ListTaxation()
        {
            return _TaxationApp.Search()
                .Select(c => new
                { c.Id, c.Initials, c.StandardRate, c.Description, c.TaxesOnBooks }).ToList();
        }

        public bool Remove(Expression<Func<Taxation, bool>> expression)
        {
            _TaxationApp.Remove(_TaxationApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Taxation, bool>> expression)
        {
            return _TaxationApp.Search(expression).ToList();
        }

        public  Taxation FindId(int id)
        {
            return _TaxationApp.FindId(id);
        }
    }
}