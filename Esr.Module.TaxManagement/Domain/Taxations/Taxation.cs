using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;

namespace Esr.Module.TaxManagement.Domain.Taxations
{
    [DisplayName(@"Impostos")]
    public class Taxation : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Sigla"), Required, Unique]
        public string Initials { get; set; }

        [DisplayName(@"Descrição"), Required]
        public string Description { get; set; }

        [DisplayName(@"Taxa Padrão")]
        public decimal StandardRate { get; set; }

        [Required]
        public virtual int TaxesOnBooksId { get { return (int)TaxesOnBooks; } set { TaxesOnBooks = (TaxesOnBooks)value; } }

        [DisplayName(@"Imposto em Livros"), Required]
        public TaxesOnBooks TaxesOnBooks { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }
    }
}
