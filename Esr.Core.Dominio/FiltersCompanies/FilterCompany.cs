using Esr.Core.Domain.ClassBase;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.Authentication;
using Microsoft.Build.Framework;
using System.ComponentModel;

namespace Esr.Core.Domain.FiltersCompanies
{
    [Table("FilterCompany")]
    public class FilterCompany : IEntityBase
    {
        public Company CompanyControl { get; set; }
        
        public int? CompanyControlId { get; set; }

        public DateTime? DateRegistration { get; set; }

        public DateTime? DateUpdate { get; set; }

        public int Id { get; set; }

        public bool Integration { get; set; }

        public Status Status { get; set; }

        public User UserControl { get; set; }

        public int? UserControlId { get; set; }

        /// <summary>
        /// Tabela que será verificado o filtro da pesquisa.
        /// </summary>
        [Required]
        public int DbTableId { get; set; }
        public virtual DbTable DbTable { get; set; }

        /// <summary>
        /// Empresa Principal
        /// </summary>
        [Required]
        [DisplayName("Empresa Principal")]
        public int CompanyLeftId { get; set; }
        public virtual Company CompanyLeft { get; set; }

        /// <summary>
        /// Empresa relacionadas no filtro
        /// </summary>
        [Required]
        [DisplayName("Empresa Compartilhada")]
        public int CompanyRightId { get; set; }
        public virtual Company CompanyRight { get; set; }

        [DisplayName("Filtro Ativo")]
        public bool Active { get; set; }
    }
}