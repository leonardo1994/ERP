using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Domain.Providers;
using System.Collections.Generic;
using Esr.Module.Funerary.Domain.Integration.Stock;

namespace Esr.Module.Funerary.Domain.OrderOfServices
{
    [DisplayName(@"OS X Produtos"), CompoundIndex(new[] { "OrderOfServiceId", "StockItemId", "ProviderId" })]
    public class OsProduct : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [Required]
        public int OrderOfServiceId { get; set; }
        public virtual OrderOfService OrderOfService { get; set; }

        [Required]
        [DisplayName(@"Local")]
        public int LocalStockId { get; set; }
        public virtual LocalStock LocalStock { get; set; }

        [DisplayName(@"Produto"), Required, AppendValue(new[] { "UnitMeasureId", "ValueSale" }, new[] { "UnitMeasureId", "UnitaryValue" })]
        public int StockItemId { get; set; }
        public virtual StockItem StockItem { get; set; }

        [DisplayName(@"Quantidade"), Required, OperationValue("UnitaryValue", "ValueTotal", TypeOperation.Multiplication)]
        public decimal Quantity { get; set; }

        [DisplayName(@"Unidade de Medida"), Required]
        public int UnitMeasureId { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }

        [DisplayName(@"Fornecedor"), DependencyKey("StockItemId"), AppendValue(new[] { "Value" }, new[] { "UnitaryValue" })]
        public int? ProviderId { get; set; }
        public virtual Provider Provider { get; set; }

        [DisplayName(@"Valor Unitário"), Required, OperationValue("Quantity", "ValueTotal", TypeOperation.Multiplication)]
        public decimal UnitaryValue { get; set; }

        [DisplayName(@"Valor Total")]
        public decimal ValueTotal { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }

        public bool Integration { get; set; }

        public virtual ICollection<ItemOutputStockFunerary> ItemOutputStockFunerary { get; set; }
    }
}