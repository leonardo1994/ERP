using System;
using System.Collections.Generic;
using System.ComponentModel;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Microsoft.Build.Framework;

namespace Esr.Core.Domain.Queries
{
    [DisplayName(@"Relatório")]
    public class Report : IEntityBase
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

        [DisplayName(@"Nome de exibição"), Required]
        public string Display { get; set; }

        [DisplayName(@"Nome do Arquivo"), Required]
        public string ReportName { get; set; }

        [DisplayName(@"Query"), Required]
        public int QueryId { get; set; }
        public virtual Query Query { get; set; }

        [DisplayName(@"Forms para exibição")]
        public virtual ICollection<ReportForm> ReportForms { get; set; }
        public bool Integration { get; set; }
    }
}