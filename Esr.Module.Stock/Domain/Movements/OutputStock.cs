using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;
using Esr.Module.Stock.Domain.Integration;

namespace Esr.Module.Stock.Domain.Movements
{
    [DisplayName(@"Saída de Estoque")]
    public class OutputStock : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Código"), Unique, Required]
        public string Code { get; set; }

        [DisplayName(@"Data"), Required, Column(TypeName = "datetime2")]
        public DateTime DateOutput { get; set; }

        [DisplayName(@"Pessoa")]
        public int? PersonId { get; set; }
        public virtual Person Person { get; set; }

        /// <summary>
        /// Referencia do movimento de integração.
        /// </summary>
        public int? IntegrationCapeStockId { get; set; }
        public virtual IntegrationCapeStock IntegrationCapeStock { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<ItemOutputStock> ItemOutputStocks { get; set; }
    }
}
