using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;

namespace Esr.Module.InitialRegistration.Domain.RH
{
    [DisplayName(@"CBO"), CompoundIndex(new[] { "CboCode", "CboDescription" })]
    public class Cbo : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Código"), Required]
        public string CboCode { get; set; }

        [DisplayName(@"Descrição"), Required]
        public string CboDescription { get; set; }

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