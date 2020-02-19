using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Component.SAttributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Module.TaxManagement.Domain.Taxations;

namespace Esr.Module.InitialRegistration.Domain.StockItems
{
    [DisplayName(@"Impostos Específicos")]
    public class SpecialTax : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Item do estoque"), Required]
        public int StockItemId { get; set; }
        public virtual StockItem StockItem { get; set; }

        [DisplayName(@"Imposto"), Required]
        public int TaxationId { get; set; }
        public virtual Taxation Taxation { get; set; }

        [DisplayName(@"Alíquota")]
        public decimal Aliquot { get; set; }

        [DisplayName(@"IVA"), DisplayInfo("IVA - impostos sobre o valor agregado, imposto cobrado sobre a oferta de bens e serviços.")]
        public decimal Iva { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }
    }
}
