using System;
using System.Collections.Generic;
using System.ComponentModel;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Microsoft.Build.Framework;

namespace Esr.Core.Domain.Queries
{
    [DisplayName(@"Query")]
    public class Query : IEntityBase
    {
        public Company CompanyControl { get; set; }
        public int? CompanyControlId { get; set; }
        public DateTime? DateRegistration { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int Id { get; set; }
        public Status Status { get; set; }
        public User UserControl { get; set; }
        public int? UserControlId { get; set; }

        [DisplayName(@"Código"), Unique, Required]
        public string Code { get; set; }

        [DisplayName(@"Sql")]
        [Required]
        public string Sql { get; set; }

        [DisplayName(@"Filtros")]
        public virtual ICollection<Filter> Filters { get; set; }
        [DisplayName(@"Consultas")]
        public virtual ICollection<Consult> Consults { get; set; }
        [DisplayName(@"Relatórios")]
        public virtual ICollection<Report> Reports { get; set; }
        public bool Integration { get; set; }
    }
}
