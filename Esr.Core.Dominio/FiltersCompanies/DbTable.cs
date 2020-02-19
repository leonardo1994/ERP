using System;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using System.ComponentModel;
using System.Collections.Generic;
using Esr.Core.Domain.ConfNumbering;

namespace Esr.Core.Domain.FiltersCompanies
{
    /// <summary>
    /// Tabelas do banco de dados do sistema
    /// </summary>
    public class DbTable : IEntityBase
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

        [DisplayName("Tabela")]
        public string TableName { get; set; }

        [DisplayName("Descrição")]
        public string TableDescription { get; set; }

        public virtual ICollection<FilterCompany> FilterCompanies { get; set; }
        public virtual ICollection<AutomaticNumbering> AutomaticNumberings { get; set; }
    }
}