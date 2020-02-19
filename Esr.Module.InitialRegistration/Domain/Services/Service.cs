using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;

namespace Esr.Module.InitialRegistration.Domain.Services
{
    [DisplayName(@"Serviços")]
    public class Service : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Código"), Unique, Required]
        public string Code { get; set; }

        [DisplayName(@"Descrição"), Required]
        public string Description { get; set; }

        [DisplayName(@"Tipo Serviço")]
        public int? TypeServiceId { get; set; }
        public virtual TypeService TypeService { get; set; }

        public TypeValue TypeValueCommission { get; set; }

        [DisplayName(@"Comissão"), Range(0.00, double.MaxValue)]
        public decimal Commission { get; set; }

        [DisplayName(@"Custo")]
        public decimal Cost { get; set; }

        public TypeValue TypeValueProfit { get; set; }

        [DisplayName(@"Lucro"), Range(0.00, double.MaxValue)]
        public decimal Profit { get; set; }

        [DisplayName(@"Valor do Serviço"), Range(0.00, double.MaxValue)]
        public decimal ValueService { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<TypeService> TypeServices { get; set; }
    }
}
