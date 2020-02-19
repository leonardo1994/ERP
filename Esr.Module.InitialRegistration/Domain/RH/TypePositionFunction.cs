using System;
using System.Collections.Generic;
using System.ComponentModel;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;

namespace Esr.Module.InitialRegistration.Domain.RH
{
    [DisplayName(@"Tipo Cargo/Função")]
    public class TypePositionFunction: IEntityBase
    {
        public int Id { get; set; }

        [DisplayName(@"Código")]
        public string TypeOfficeFunctionCode { get; set; }

        [DisplayName(@"Description")]
        public string TypeOfficeFunctionDescription { get; set; }

        public Status Status { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<Office> Offices { get; set; }
        public virtual ICollection<Function> Functions { get; set; }
    }
}