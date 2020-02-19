using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.UnitMeasures;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class UnitMeasureController
    {
        private UnitMeasureApp _UnitMeasureApp; 
        private IFactoryConnection _connection;

        public UnitMeasureController(IFactoryConnection connection)
        {
            _connection = connection;
            _UnitMeasureApp = new UnitMeasureApp(connection);
        }
        
        public bool Save(UnitMeasure UnitMeasure)
        {
            _UnitMeasureApp.InsertOrUpdate(UnitMeasure);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _UnitMeasureApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _UnitMeasureApp.Remove(_UnitMeasureApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// UnitMeasures List.
        /// </summary>
        /// <returns>{ c.Id, c.Initials, c.Description }</returns>
        public IList ListUnitMeasure()
        {
            return _UnitMeasureApp.Search()
                .Select(c => new
                { c.Id, c.Initials, c.Description }).ToList();
        }

        public bool Remove(Expression<Func<UnitMeasure, bool>> expression)
        {
            _UnitMeasureApp.Remove(_UnitMeasureApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<UnitMeasure, bool>> expression)
        {
            return _UnitMeasureApp.Search(expression).ToList();
        }

        public UnitMeasure FindId(int id)
        {
            return _UnitMeasureApp.FindId(id);
        }
    }
}