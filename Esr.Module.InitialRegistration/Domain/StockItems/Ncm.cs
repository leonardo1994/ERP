using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;

namespace Esr.Module.InitialRegistration.Domain.StockItems
{
    [DisplayName(@"NCM - Nomenclatura Comum do Mercosul")]
    public class Ncm : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Código"), Required, Unique]
        public string NcmCode { get; set; }

        [DisplayName(@"Descrição"), Required]
        public string NcmName { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<StockItem> StockItems { get; set; }
        public virtual ICollection<FeaturedNcm> FeaturedNcms { get; set; }
    }
}