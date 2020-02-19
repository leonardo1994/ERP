using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.Stock.Domain.Integration;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace Esr.Module.Funerary.Domain.Integration.Stock
{
    public class ItemOutputStockFunerary : IntegrationItemsStock
    {
        public int? OsProductId { get; set; }
        public virtual OsProduct OsProduct { get; set; }

        public override Expression<Func<IntegrationItemsStock, bool>> GetExpressionByRelation()
        {
            Expression<Func<IntegrationItemsStock, bool>> expression = x => (x as ItemOutputStockFunerary).OsProductId == OsProductId;
            return expression;
        }
    }
}