using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Microsoft.Build.Framework;
using System;
using System.ComponentModel;

namespace Esr.Core.Domain.Catalog
{
    [DisplayName("Form")]
    public class Table : IEntityBase
    {
        public Company CompanyControl { get; set; }
        public int? CompanyControlId { get; set; }
        public DateTime? DateRegistration { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int Id { get; set; }
        public Status Status { get; set; }
        public User UserControl { get; set; }
        public int? UserControlId { get; set; }

        [DisplayName(@"Nome do Form"), Required]
        public string TableName { get; set; }

        [DisplayName(@"Descrição")]
        public string DescriptionForm { get; set; }

        public bool Integration { get; set; }
    }
}
