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
    public class CompositionController
    {
        private CompositionApp _CompositionApp; 
        private IFactoryConnection _connection;

        public CompositionController(IFactoryConnection connection)
        {
            _connection = connection;
            _CompositionApp = new CompositionApp(connection);
        }
        
        public bool Save(Composition Composition)
        {
            _CompositionApp.InsertOrUpdate(Composition);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _CompositionApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _CompositionApp.Remove(_CompositionApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Compositions List.
        /// </summary>
        /// <returns>{ c.Id, c.StockItem.Description, c.Quantity, c.UnitMeasure.Initials }</returns>
        public IList ListComposition()
        {
            return _CompositionApp.Search()
                .Select(c => new
                { c.Id, c.StockItem.Description, c.Quantity, c.UnitMeasure.Initials }).ToList();
        }

        /// <summary>
        /// Compositions List.
        /// </summary>
        /// <returns>{ c.Id, c.StockItem.Description, c.Quantity, c.UnitMeasure.Initials }</returns>
        public IList Search(Expression<Func<Composition, bool>> expression)
        {
            return _CompositionApp.Search(expression)
                .Select(c => new
                { c.Id, c.StockItem.Description, c.Quantity, c.UnitMeasure.Initials }).ToList();
        }

        public bool Remove(Expression<Func<Composition, bool>> expression)
        {
            _CompositionApp.Remove(_CompositionApp.Search(expression).ToList());
            return _connection.Save();
        }

        public Composition FindId(int id)
        {
            return _CompositionApp.FindId(id);
        }
    }
}