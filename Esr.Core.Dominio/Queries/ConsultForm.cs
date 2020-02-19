using System;
using System.ComponentModel;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.Catalog;
using Esr.Core.Domain.ClassBase;

namespace Esr.Core.Domain.Queries
{
    [DisplayName(@"Consultas X Forms")]
    public class ConsultForm : IEntityBase
    {
        public Company CompanyControl { get; set; }
        public int? CompanyControlId { get; set; }
        public DateTime? DateRegistration { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int Id { get; set; }
        public Status Status { get; set; }
        public User UserControl { get; set; }
        public int? UserControlId { get; set; }

        public int ConsultId { get; set; }
        public virtual Consult Consult { get; set; }
        public bool Integration { get; set; }

        [DisplayName(@"Selecione o Form")]
        public int TableId { get; set; }
        public virtual Table Table { get; set; }
    }
}
