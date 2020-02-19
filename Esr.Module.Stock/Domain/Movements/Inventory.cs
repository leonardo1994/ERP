using System;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Esr.Core.Domain.Attributes;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System.Collections.Generic;

namespace Esr.Module.Stock.Domain.Movements
{
    public class Inventory : IEntityBase
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

        [Unique]
        [Required]
        [StringLength(20)]
        [DisplayName("Código do invetário")]
        public string InventoryCode { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Descrição do invetário")]
        public string InventoryDescription { get; set; }

        [Required]
        [DisplayName("Data do inventário")]
        public DateTime DateOfInventory { get; set; }

        [Required]
        [DisplayName("Responsável pelo inventário")]
        public int ResponsibleInventoryId { get; set; }
        public virtual ResponsibleInventory ResponsibleInventory { get; set; }

        [Required]
        [DisplayName("Local de Armazenamento")]
        public int LocalStockId { get; set; }
        public virtual LocalStock LocalStock { get; set; }

        [DisplayName("Cálculado")]
        public bool Calculated { get; set; }

        public virtual ICollection<InventoryItems> InventoryItems { get; set; }
    }
}