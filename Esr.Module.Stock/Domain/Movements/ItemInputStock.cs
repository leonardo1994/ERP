using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.Stock.Domain.Integration;

namespace Esr.Module.Stock.Domain.Movements
{
    [DisplayName(@"Item Entrada Estoque")]
    public class ItemInputStock : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Capa Entrada Estoque"), Required]
        public int InputStockId { get; set; }
        public virtual InputStock InputStock { get; set; }

        [DisplayName(@"Data"), Required, Column(TypeName = "datetime2")]
        public DateTime Date { get; set; }

        [DisplayName(@"Local"), Required]
        public int LocalStockId { get; set; }
        public virtual LocalStock LocalStock { get; set; }

        [DisplayName(@"Item"), Required]
        public int StockItemId { get; set; }
        public virtual StockItem StockItem { get; set; }

        [DisplayName(@"Un. Medida"), Required]
        public int UnitMeasureId { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }

        [DisplayName(@"Quantidade"), Required]
        [OperationValue("UnitaryValue", "Total", TypeOperation.Multiplication)]
        public decimal Quantity { get; set; }

        [OperationValue("Quantity", "Total", TypeOperation.Multiplication)]
        [DisplayName(@"Unitário"), Required]
        public decimal UnitaryValue { get; set; }

        [DisplayName(@"Total"), Required]
        public decimal Total { get; set; }

        [DisplayName(@"Un. Medida Padrão"), Required]
        public int StandarUnitMeasureId { get; set; }
        public virtual UnitMeasure StandarUnitMeasure { get; set; }

        [DisplayName(@"Quantidade Padrão"), Required]
        public decimal StandardQuantity { get; set; }

        [DisplayName(@"Valor Unitário Padrão"), Required]
        public decimal StandardUnitValue { get; set; }

        [DisplayName(@"Total Padrão"), Required]
        public decimal StandardTotal { get; set; }

        /// <summary>
        /// Referencia do movimento de integração.
        /// </summary>
        public int? IntegrationItemsStockId { get; set; }
        public virtual IntegrationItemsStock IntegrationItemsStock { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }

        public bool Integration { get; set; }
    }
}
