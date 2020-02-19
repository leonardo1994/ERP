using System;
using System.Collections.Generic;
using System.ComponentModel;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Microsoft.Build.Framework;

namespace Esr.Core.Domain.Queries
{
    [DisplayName(@"Consultas")]
    public class Consult : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }

        [DisplayName(@"Código"), Required]
        public string Code { get; set; }

        [DisplayName(@"Descrição"), Required]
        public string Display { get; set; }

        [DisplayName(@"Query"), Required]
        public int QueryId { get; set; }
        public virtual Query Query { get; set; }

        public bool Integration { get; set; }

        [DisplayName(@"Lista de Forms")]
        public virtual ICollection<ConsultForm> ConsultForms { get; set; }
    }
}
