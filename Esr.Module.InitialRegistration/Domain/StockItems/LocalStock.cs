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
    [DisplayName(@"Local")]
    public class LocalStock : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Código"), Unique, Required]
        public string LocalCode { get; set; }

        [DisplayName(@"Descrição"), Required]
        public string LocalName { get; set; }

        public virtual int TypeStructureId { get { return (int)TypeStructure; } set { TypeStructure = (TypeStructure)value; } }

        [DisplayName(@"Tipo"), Required]
        [LockedTrueValue(new[] { "LocalStocks" }, new object[] { TypeStructure.Analytical })]
        public TypeStructure TypeStructure { get; set; }

        [DisplayName(@"Nível Superior")]
        public int? LocalStockMasterId { get; set; }
        public virtual LocalStock LocalStockMaster { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<LocalStock> LocalStocks { get; set; }

    }
}
