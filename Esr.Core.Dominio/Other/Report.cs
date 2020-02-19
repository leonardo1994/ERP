using System;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;

namespace Esr.Core.Domain.Other
{
    public class Report_Old : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        public string Name { get; set; }
        public string Sql { get; set; }
        public string ReportName { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }
    }
}
