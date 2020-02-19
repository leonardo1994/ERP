using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;

namespace Esr.Module.InitialRegistration.Domain.StockItems
{
    [DisplayName(@"Familia"), CompoundIndex(new[] { "FamilyCode", "TypeStructure" })]
    public class Family : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Código"), Required]
        public string FamilyCode { get; set; }

        public virtual int TypeStructureId { get { return (int)TypeStructure; } set { TypeStructure = (TypeStructure)value; } }

        [DisplayName(@"Tipo"), Required]
        [LockedTrueValue(new[] { "Families" }, new object[] { TypeStructure.Analytical })]
        public TypeStructure TypeStructure { get; set; }

        [DisplayName(@"Descrição"), Required]
        public string FamilyName { get; set; }

        public virtual int OriginItemId { get { return (int)OriginItem; } set { OriginItem = (OriginItem)value; } }

        [DisplayName(@"Origem")]
        public OriginItem OriginItem { get; set; }

        [DisplayName(@"Nível Superior")]
        public int? FamilyMasterId { get; set; }
        public virtual Family FamilyMaster { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }

        public bool Integration { get; set; }

        public virtual ICollection<StockItem> StockItems { get; set; }
        public virtual ICollection<Family> Families { get; set; }

        public virtual ICollection<UnitMeasureConversion> UnitMeasureConversions { get; set; }
    }
}