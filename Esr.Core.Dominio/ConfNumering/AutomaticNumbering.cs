using System;
using System.ComponentModel;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.Catalog;
using Esr.Core.Domain.ClassBase;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Build.Framework;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.FiltersCompanies;

namespace Esr.Core.Domain.ConfNumbering
{
    [Table("AutomaticNumbering")]
    [DisplayName("Numeração Automática")]
    public class AutomaticNumbering : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }

        [Required]
        [DisplayName("Nome da tabela")]
        public int DbTableId { get; set; }
        public virtual DbTable DbTable { get; set; }

        [Required]
        [DisplayName("Nome do campo")]
        public string FieldName { get; set; }

        [DisplayName("Sequencial ? ")]
        public bool Sequence { get; set; }

        [LockedTrueValue(new[] { "Sequence" }, new object[] { true })]
        [DisplayName("Prox. número")]
        public int NextNumber { get; set; }

        public bool Integration { get; set; }
    }
}