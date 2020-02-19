using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Esr.Module.Stock.Domain.Movements
{
    [CompoundIndex(new[] { "InventoryId", "StockItemId" })]
    public class InventoryItems : IEntityBase
    {
        public Company CompanyControl { get; set; }
        public int? CompanyControlId { get; set; }
        public DateTime? DateRegistration { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int Id { get; set; }
        public bool Integration { get; set; }
        public Status Status { get; set; }
        public User UserControl { get; set; }
        public int? UserControlId { get; set; }

        [Required]
        [DisplayName("Inventário")]
        public int InventoryId { get; set; }
        public virtual Inventory Invetory { get; set; }

        [Required]
        [DisplayName("Item de estoque")]
        public int StockItemId { get; set; }
        public virtual StockItem StockItem { get; set; }

        [DisplayName("Primeira Contagem")]
        public decimal FirstCount { get; set; }

        [DisplayName("Contagem Aprovada")]
        public decimal CountApproved { get; set; }
    }
}