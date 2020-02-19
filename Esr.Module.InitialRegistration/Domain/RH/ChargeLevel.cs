using System;
using System.Collections.Generic;
using System.ComponentModel;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;

namespace Esr.Module.InitialRegistration.Domain.RH
{
    [DisplayName(@"Nível do Cargo")]
    public class ChargeLevel : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Código")]
        public string ChargeLevelCode { get; set; }

        [DisplayName(@"Ddescription")]
        public string ChargeLevelDescription { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<Office> Offices { get; set; }
    }
}