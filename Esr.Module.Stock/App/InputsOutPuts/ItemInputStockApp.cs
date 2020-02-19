using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Stock.Domain.Movements;
using Esr.Module.Stock.Repository.InputsOutPuts;
using Esr.Module.Stock.App.Managements;
using Esr.Module.InitialRegistration.App.StockItems;
using Esr.Module.InitialRegistration.App.UnitMeasureConversions;

namespace Esr.Module.Stock.App.InputsOutputs
{
    public class ItemInputStockApp
    {
        private readonly IFactoryCommand<ItemInputStock> _epr;
        private readonly StockItemApp _stockItemApp;
        private readonly UnitMeasureConversionApp _unitMeasureConversionApp;

        public ItemInputStockApp(IFactoryConnection efc)
        {
            _epr = new ItemInputStockRepo(efc);
            _stockItemApp = new StockItemApp(efc);
            _unitMeasureConversionApp = new UnitMeasureConversionApp(efc);
        }

        public ItemInputStock FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<ItemInputStock> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(ItemInputStock ItemInputStock)
        {
            var stockItem = _stockItemApp.FindId(ItemInputStock.StockItemId);

            ItemInputStock.StandarUnitMeasureId = stockItem.UnitMeasureId;

            if (stockItem.UnitMeasureId != ItemInputStock.UnitMeasureId)
            {
                ItemInputStock.StandardQuantity = _unitMeasureConversionApp.Convert(ItemInputStock.UnitMeasureId, stockItem.UnitMeasureId, stockItem.Id, stockItem.FamilyId, ItemInputStock.Quantity);
                ItemInputStock.StandardUnitValue = ItemInputStock.UnitaryValue / ItemInputStock.StandardQuantity;
                ItemInputStock.StandardTotal = ItemInputStock.StandardQuantity * ItemInputStock.StandardUnitValue;
            }
            else
            {
                ItemInputStock.StandardQuantity = ItemInputStock.Quantity;
                ItemInputStock.StandardUnitValue = ItemInputStock.UnitaryValue;
                ItemInputStock.StandardTotal = ItemInputStock.Total;
            }

            return _epr.InsertOrUpdate(ItemInputStock);
        }

        public IQueryable<ItemInputStock> Search(Expression<Func<ItemInputStock, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<ItemInputStock> Search()
        {
            return _epr.Search();
        }

        /// <summary>
        /// Retorna a quantidade total de entradas do item.
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