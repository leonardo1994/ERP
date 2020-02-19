using System;
using System.Linq.Expressions;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.Stock.Domain.Integration;

namespace Esr.Module.Funerary.Domain.Integration.Stock
{
    public class OutputStockFunerary : IntegrationCapeStock
    {
        public int? OrderOfServiceId { get; set; }
        public virtual OrderOfService OrderOfService { get; set; }

        public override Expression<Func<IntegrationCapeStock, bool>> GetExpressionByRelation()
        {
            Expression<Func<IntegrationCapeStock, bool>> expression = x => (x as OutputStockFunerary).OrderOfServiceId == OrderOfServiceId;
            return expression;
        }
    }
}