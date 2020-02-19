using Esr.Core.Domain.ClassBase;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.Authentication;
using System;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Attributes;

namespace Esr.Module.InitialRegistration.Domain.Sales
{
    [DisplayName("Forma de Pagamento")]
    [Table("FormOfPayment")]
    public class FormOfPayment : IEntityBase
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
        [DisplayName("Código")]
        public string Code { get; set; }

        [Required]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [Required]
        [DisplayName("Tipo de Pagamento")]
        public TypePaymant TypePaymant { get; set; }
        public int TypePaymantId { get { return (int)TypePaymant; } set { TypePaymant = (TypePaymant)value; } }
    }

    public enum TypePaymant
    {
        [Display(Name = "Cartão")]
        Card,
        [Display(Name = "Dinheiro")]
        Money
    }
}
