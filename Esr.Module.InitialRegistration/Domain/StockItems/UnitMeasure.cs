using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esr.Module.InitialRegistration.Domain.StockItems
{
    [DisplayName(@"Unidade de Medida")]
    [Table("UnitMeasures")]
    public class UnitMeasure : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Sigla"), Unique, Required, StringLength(2)]
        public string Initials { get; set; }
        [DisplayName(@"Descrição"), Required]
        public string Description { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<StockItem> StockItems { get; set; }
        public virtual ICollection<Composition> Compositions { get; set; }

        public virtual ICollection<UnitMeasureConversion> UnitMeasureConversions { get; set; }
    }
}