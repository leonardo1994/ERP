using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Module.Funerary.Domain.Contractors;
using Esr.Module.InitialRegistration.Domain.Services;

namespace Esr.Module.Funerary.Domain.OrderOfServices
{
    [DisplayName(@"Contratada X Serviços")]
    public class OsContractorService : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [Required]
        public int OrderOfServiceId { get; set; }
        public virtual OrderOfService OrderOfService { get; set; }

        [DisplayName(@"Contratada"), Required]
        public int ContractorId { get; set; }
        public virtual Contractor Contractor { get; set; }

        [DisplayName(@"Serviço"), Required]
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        [DisplayName(@"Valor R$"), Required]
        public decimal ValueService { get; set; }

        [DisplayName(@"Histórico do serviço")]
        public string HistoricalService { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }
    }
}
