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
    [DisplayName(@"Tipo de serviço"), CompoundIndex(new[] { "Code", "TypeStructure" })]
    public class TypeService : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Código"), Required]
        public string Code { get; set; }

        [DisplayName(@"Descrição"), Required]
        public string Description { get; set; }

        [DisplayName(@"Tipo"), LockedTrueValue(new[] { "TypeServices" }, new object[] { TypeStructure.Analytical }), Required]
        public TypeStructure TypeStructure { get; set; }

        public int? TypeServiceMasterId { get; set; }
        public virtual TypeService TypeServiceMaster { get; set; }

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