using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.UnitMeasureConversions;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class UnitMeasureConversionController
    {
        private UnitMeasureConversionApp _UnitMeasureConversionApp;
        private IFactoryConnection _connection;

        public UnitMeasureConversionController(IFactoryConnection connection)
        {
            _connection = connection;
            _UnitMeasureConversionApp = new UnitMeasureConversionApp(connection);
        }

        public bool Save(UnitMeasureConversion UnitMeasureConversion)
        {
            _UnitMeasureConversionApp.InsertOrUpdate(UnitMeasureConversion);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _UnitMeasureConversionApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _UnitMeasureConversionApp.Remove(_UnitMeasureConversionApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// UnitMeasureConversions List.
        /// </summary>
        /// <returns>{ c.Id, c.Initials, c.Description }</returns>
        public IList ListUnitMeasureConversion(Expression<Func<UnitMeasureConversion, bool>> expression)
        {
            return _UnitMeasureConversionApp.Search(expression)
                .Include(c => c.SecondUnitMeasure)
                .Include(C => C.StockItem)
                .Include(C => C.Family)
                .Select(c => new
                {
                    c.Id,
                    c.FirstUnitMeasureId,
                    c.SecondUnitMeasureId,
                    c.SecondUnitMeasure.Initials,
                    c.SecondUnitMeasure.Description,
                    c.StockItem.Code,
                    c.Family.FamilyName
                }).ToList();
        }

        public bool Remove(Expression<Func<UnitMeasureConversion, bool>> expression)
        {
            _UnitMeasureConversionApp.Remove(_UnitMeasureConversionApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<UnitMeasureConversion, bool>> expression)
        {
            return _UnitMeasureConversionApp.Search(expression).ToList();
        }

        public IList SearchAll()
        {
            return _UnitMeasureConversionApp.Search().ToList();
        }

        public UnitMeasureConversion FindId(int id)
        {
            return _UnitMeasureConversionApp.FindId(id);
        }
    }
}