using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Module.InitialRegistration.Domain.Services;
using Esr.Core.Domain.Attributes;

namespace Esr.Module.Funerary.Domain.OrderOfServices
{
    [DisplayName(@"OS X Serviços")]
    public class OsService : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [Required]
        public int OrderOfServiceId { get; set; }
        public virtual OrderOfService OrderOfService { get; set; }

        [DisplayName("Prestadora")]
        public int LegalPersonId { get; set; }
        public virtual LegalPerson LegalPerson { get; set; }

        [DisplayName(@"Serviço"), Required, AppendValue(new[] { "ValueService" }, new[] { "ValueService" })]
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        [DisplayName(@"Valor R$")]
        public decimal ValueService { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }
    }
}
