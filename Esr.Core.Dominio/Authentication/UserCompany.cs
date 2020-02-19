using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.ClassBase;

namespace Esr.Core.Domain.Authentication
{
    [Table("UserCompany")]
    [DisplayName(@"Empresas X Usuários")]
    public class UserCompany : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }

        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }

        public bool Integration { get; set; }
    }
}
