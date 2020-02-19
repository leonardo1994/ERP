using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;

namespace Esr.Module.InitialRegistration.Domain.StockItems
{
    [DisplayName(@"Composição do item de estoque")]
    public class Composition : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Item de estoque"), Required]
        public int StockItemId { get; set; }
        public virtual StockItem StockItem { get; set; }

        [DisplayName(@"Quantidade"), Required, Range(0.01, double.MaxValue)]
        public decimal Quantity { get; set; }

        [DisplayName(@"Unidade de Medida"), Required]
        public int UnitMeasureId { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }

        [DisplayName(@"Valor"), Required, Range(0.01, double.MaxValue)]
        public decimal Value { get; set; }

        public bool Integration { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
    }
}
