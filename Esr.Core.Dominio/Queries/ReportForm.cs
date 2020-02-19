using System;
using System.ComponentModel;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.Catalog;
using Esr.Core.Domain.ClassBase;
using Microsoft.Build.Framework;

namespace Esr.Core.Domain.Queries
{
    [DisplayName(@"Relatório X Forms")]
    public class ReportForm : IEntityBase
    {
        public Company CompanyControl { get; set; }
        public int? CompanyControlId { get; set; }
        public DateTime? DateRegistration { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int Id { get; set; }
        public Status Status { get; set; }
        public User UserControl { get; set; }
        public int? UserControlId { get; set; }

        [Required]
        public int ReportId { get; set; }
        public virtual Report Report { get; set; }

        [DisplayName(@"Selecione o Form"), Required]
        public int TableId { get; set; }
        public virtual Table Table { get; set; }
        public bool Integration { get; set; }
    }
}
