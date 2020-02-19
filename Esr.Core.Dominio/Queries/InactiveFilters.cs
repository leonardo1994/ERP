using System;
using System.ComponentModel;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Microsoft.Build.Framework;

namespace Esr.Core.Domain.Queries
{
    [DisplayName(@"Filtros Inativos"), CompoundIndex(new[] { "FilterId", "TypeFilter" })]
    public class InactiveFilters : IEntityBase
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
        public int FilterId { get; set; }
        public virtual Filter Filter { get; set; }
        public bool Integration { get; set; }

        public virtual int TypeFilterComponentId { get { return (int)TypeFilter; } set { TypeFilter = (TypeFilter)value; } }
        [DisplayName(@"Filtro Inativo"), Required]
        public TypeFilter TypeFilter { get; set; }
    }
}
