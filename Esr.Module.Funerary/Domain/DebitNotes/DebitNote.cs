using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Module.Funerary.Domain.Contractors;

namespace Esr.Module.Funerary.Domain.DebitNotes
{
    [DisplayName(@"Nota de Débito")]
    public class DebitNote : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Nota de Débito")]
        public string NumberDebitNote { get; set; }

        [DisplayName(@"Número do Processo")]
        [Required]
        public string ProcessNumber { get; set; }

        [DisplayName(@"Valor")]
        [Required]
        [Range(00.001, double.MaxValue)]
        public decimal Value { get; set; }

        [DisplayName(@"Nome do falecido")]
        [Required]
        public string DeadName { get; set; }

        [DisplayName(@"Data")]
        [Required]
        [Column(Order = 2, TypeName = "datetime2")]
        public DateTime Date { get; set; }

        [Required]
        [DisplayName(@"Contratada")]
        public int ContractorId { get; set; }
        public virtual Contractor Contractor { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }

        public bool Integration { get; set; }
    }
}
