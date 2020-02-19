using System;
using System.ComponentModel;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;

namespace Esr.Module.InitialRegistration.Domain.RH
{
    [DisplayName(@"Função")]
    public class Function : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Código")]
        public string FunctionCode { get; set; }

        [DisplayName(@"Descrição")]
        public string FunctionDescription { get; set; }

        [DisplayName(@"Tipo de Cargo")]
        public int TypeOfficeFunctionId { get; set; }
        public virtual TypePositionFunction TypePositionFunction { get; set; }

        [DisplayName(@"Natureza do Cargo")]
        public int NaturePositionFunctionId { get; set; }
        public virtual NaturePositionFunction NaturePositionFunction { get; set; }

        [DisplayName(@"CBO")]
        public int CboId { get; set; }
        public virtual Cbo Cbo { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }

        public bool Integration { get; set; }
    }
}
