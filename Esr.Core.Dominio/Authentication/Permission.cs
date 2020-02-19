using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;

namespace Esr.Core.Domain.Authentication
{
    [DisplayName("Permissão")]
    public class Permission : IEntityBase
    {
        public int Id { get; set; }

        public Status Status { get; set; }

        [Required]
        [DisplayName("Tipo do componente")]
        public TypeComponent TypeComponent { get; set; }

        public int TypeComponentId { get { return (int)TypeComponent; } set { TypeComponent = (TypeComponent)value; } }

        [Required]
        [DisplayName("Nome da permissão")]
        public string NamePermission { get; set; }

        [DisplayName("Visível")]
        public bool Visible { get; set; }

        [DisplayName("Inserir")]
        public bool Insert { get; set; }

        [DisplayName("Deletar")]
        public bool Delete { get; set; }

        [DisplayName("Atualizar")]
        public bool Update { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<GroupPermission> GroupPermissions { get; set; }
    }
}