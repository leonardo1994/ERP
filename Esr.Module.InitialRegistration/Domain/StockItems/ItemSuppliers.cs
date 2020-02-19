using Esr.Core.Domain.ClassBase;
using System;
using Esr.Core.Domain.Authentication;
using Esr.Module.InitialRegistration.Domain.Providers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Esr.Core.Domain.Attributes;

namespace Esr.Module.InitialRegistration.Domain.StockItems
{
    [CompoundIndex(new[] { "ProviderId", "StockItemId" })]
    [DisplayName("Fornecedores do Item")]
    public class ItemSuppliers : IEntityBase
    {
        public int Id { get; set; }

        public int StockItemId { get; set; }
        public virtual StockItem StockItem { get; set; }

        [DisplayName("Fornecedor")]
        [Required]
        public int ProviderId { get; set; }
        public virtual Provider Provider { get; set; }

        [DisplayName(@"Valor")]
        public decimal Value { get; set; }

        public Company CompanyControl { get; set; }

        public int? CompanyControlId { get; set; }

        public DateTime? DateRegistration { get; set; }

        public DateTime? DateUpdate { get; set; }

        public Status Status { get; set; }

        public User UserControl { get; set; }

        public int? UserControlId { get; set; }

        public bool Integration { get; set; }
    }
}
