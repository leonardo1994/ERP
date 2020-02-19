using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.ClassBase;

namespace Esr.Core.Domain.Authentication
{
    [DisplayName("Grupo de acesso")]
    public class GroupAccess : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        [Required]
        [DisplayName("Título")]
        public string Title { get; set; }
        [DisplayName("Descrição")]
        public string Description { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<GroupPermission> GroupPermissions { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
    }
}