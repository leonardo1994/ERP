using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;

namespace Esr.Core.Domain.Queries
{
    [DisplayName("Filtros"), CompoundIndex(new[] { "QueryId", "Code" })]
    public class Filter : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }

        [DisplayName(@"Query"), Required]
        public int QueryId { get; set; }
        public virtual Query Query { get; set; }

        [DisplayName(@"Identificador"), Required]
        public string Code { get; set; }

        [DisplayName(@"Nome de exibição")]
        [Required]
        public string Display { get; set; }

        [DisplayName(@"Nome da Coluna"), Required]
        public string NameColumn { get; set; }

        [DisplayName(@"Nome da Tabela"), Required]
        public string NameTable { get; set; }

        public virtual int TypeFilterComponentId { get { return (int)TypeComponent; } set { TypeComponent = (TypeFilterComponent)value; } }
        [DisplayName(@"Tipo de Componente")]
        [Required]
        public TypeFilterComponent TypeComponent { get; set; }

        public virtual int DefaultTypeFilterId { get { return (int)DefaultTypeFilter; } set { DefaultTypeFilter = (TypeFilter)value; } }
        [DisplayName(@"Filtro Principal")]
        [Required]
        public TypeFilter DefaultTypeFilter { get; set; }
        public bool Integration { get; set; }

        [DisplayName(@"Filtros Inativos")]
        public virtual ICollection<InactiveFilters> InactiveFilters { get; set; }
    }
}
