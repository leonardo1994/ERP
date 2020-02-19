using Esr.Core.Domain.ClassBase;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.Authentication;

namespace Esr.Core.Domain.UserResources
{
    [Table("UserResource")]
    public class UserResource : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public string ReferenceCode { get; set; }

        public string Value { get; set; }
    }
}
