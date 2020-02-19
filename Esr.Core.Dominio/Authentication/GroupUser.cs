using System;
using Esr.Core.Domain.ClassBase;

namespace Esr.Core.Domain.Authentication
{
    public class GroupUser : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int GroupAccessId { get; set; }
        public virtual GroupAccess GroupAccess { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }

        public int? UserControlId { get; set; }
        public User UserControl { get; set; }

        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }

        public bool Integration { get; set; }
    }
}
