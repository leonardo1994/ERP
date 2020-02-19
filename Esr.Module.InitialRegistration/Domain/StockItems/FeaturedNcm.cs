using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;

namespace Esr.Module.InitialRegistration.Domain.StockItems
{
    [DisplayName(@"Destaque da NCM")]
    public class FeaturedNcm : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"NCM")]
        public int NcmId { get; set; }
        public Ncm Ncm { get; set; }

        [DisplayName(@"Código"), Required, Unique]
        public string Code { get; set; }

        [DisplayName(@"Destaque da NCM"), Required]
        public string Description { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }

        public bool Integration { get; set; }
    }
}