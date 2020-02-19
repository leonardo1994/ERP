using Esr.Core.Domain.ClassBase;
using System;
using Esr.Core.Domain.Authentication;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace Esr.Module.Stock.Domain.Integration
{
    public class IntegrationItemsStock : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        [NotMapped]
        public int InputStockId { get; set; }

        [NotMapped]
        public int OutputStockId { get; set; }

        [NotMapped]
        public DateTime Date { get; set; }

        [NotMapped]
        public int LocalStockId { get; set; }

        [NotMapped]
        public int StockItemId { get; set; }

        [NotMapped]
        public int UnitMeasureId { get; set; }

        [NotMapped]
        public decimal Quantity { get; set; }

        [NotMapped]
        public decimal UnitaryValue { get; set; }

        [NotMapped]
        public decimal Total { get; set; }

        [NotMapped]
        public int StandarUnitMeasureId { get; set; }

        [NotMapped]
        public decimal StandardQuantity { get; set; }

        [NotMapped]
        public decimal StandardUnitValue { get; set; }

        [NotMapped]
        public decimal StandardTotal { get; set; }

        [NotMapped]
        public int? IntegrationCapeStockId { get; set; }

        public string Origin { get; set; }

        [NotMapped]
        public int TypeIntegrationId { get { return (int)TypeIntegration; } set { TypeIntegration = (TypeIntegration)value; } }
        [NotMapped]
        public TypeIntegration TypeIntegration { get; set; }

        public virtual Expression<Func<IntegrationItemsStock, bool>> GetExpressionByRelation()
        {
            return null;
        }
    }
}
