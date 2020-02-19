using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Stock.Repository.InputsOutPuts;
using System.Collections.Generic;
using Esr.Module.Stock.Domain.Movements;
using Esr.Module.Stock.App.Managements;
using Esr.Core.Domain.Other;
using Esr.Module.InitialRegistration.App.UnitMeasureConversions;
using Esr.Module.InitialRegistration.App.StockItems;

namespace Esr.Module.Stock.App.InputsOutputs
{
    public class ItemOutputStockApp
    {
        private IFactoryCommand<ItemOutputStock> _epr;
        private readonly StockManagement _stockManagement;
        private readonly StockItemApp _stockItemApp;
        private readonly UnitMeasureConversionApp _unitMeasureConversionApp;
        public IList<Log> Logs { get; set; }

        public ItemOutputStockApp(IFactoryConnection efc)
        {
            _epr = new ItemOutputStockRepo(efc);
            _stockManagement = new StockManagement(efc);
            _stockItemApp = new StockItemApp(efc);
            _unitMeasureConversionApp = new UnitMeasureConversionApp(efc);
            Logs = new List<Log>();
        }

        public ItemOutputStock FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<ItemOutputStock> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(ItemOutputStock ItemOutputStock)
        {
            if (_stockManagement.ValidItem(ItemOutputStock.StockItemId, ItemOutputStock.LocalStockId, ItemOutputStock.UnitMeasureId, ItemOutputStock.Quantity, ItemOutputStock.Id))
            {

                var stockItem = _stockItemApp.FindId(ItemOutputStock.StockItemId);

                ItemOutputStock.StandarUnitMeasureId = stockItem.UnitMeasureId;

                if (stockItem.UnitMeasureId != ItemOutputStock.UnitMeasureId)
                {
                    ItemOutputStock.StandardQuantity = _unitMeasureConversionApp.Convert(ItemOutputStock.UnitMeasureId, stockItem.UnitMeasureId, stockItem.Id, stockItem.FamilyId, ItemOutputStock.Quantity);
                    ItemOutputStock.StandardUnitValue = ItemOutputStock.UnitaryValue / ItemOutputStock.StandardQuantity;
                    ItemOutputStock.StandardTotal = ItemOutputStock.StandardQuantity * ItemOutputStock.StandardUnitValue;
                }
                else
                {
                    ItemOutputStock.StandardQuantity = ItemOutputStock.Quantity;
                    ItemOutputStock.StandardUnitValue = ItemOutputStock.UnitaryValue;
                    ItemOutputStock.StandardTotal = ItemOutputStock.Total;
                }

                return _epr.InsertOrUpdate(ItemOutputStock);
            }else
            {
                return false;
            }
        }

        public IQueryable<ItemOutputStock> Search(Expression<Func<ItemOutputStock, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<ItemOutputStock> Search()
        {
            return _epr.Search();
        }

        /// <summary>
        /// Retorna a quantidade total de saídas do item.
        /// </summary>
        /// <param name="stockItemId">Id do item de estoque.</param>
        /// <param name="localStockId">Id do local de estoque.</param>
        /// <returns></returns>
        public decimal GetQuantityTotal(int stockItemId, int localStockId)
        {
            var stockItem = _stockItemApp.FindId(stockItemId);

            var UnitMeasureAndQuantity = _epr.Search(c => c.StockItemId == stockItemId && c.LocalStockId == localStockId)
                .GroupBy(c => c.StandarUnitMeasureId)
                .Select(c => new { UnitMeasureId = c.Key, QtdTotal = c.Sum(d => d.StandardQuantity) });

            decimal qtd = decimal.Zero;

            foreach (var item in UnitMeasureAndQuantity)
            {
                if (item.UnitMeasureId != stockItem.UnitMeasureId)
                {
                    qtd = qtd + _unitMeasureConversionApp.Convert(item.UnitMeasureId, stockItem.UnitMeasureId, stockItemId, stockItem.FamilyId, item.QtdTotal);
                }
                else
                {
                    qtd = qtd + item.QtdTotal;
                }
            }

            return qtd;
        }
    }
}