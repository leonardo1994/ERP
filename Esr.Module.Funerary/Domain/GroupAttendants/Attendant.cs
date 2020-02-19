using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;

namespace Esr.Module.Funerary.Domain.GroupAttendants
{
    [DisplayName(@"Atendentes")]
    public class Attendant : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [Required]
        public int GroupAttendantId { get; set; }
        public virtual GroupAttendant GroupAttendant { get; set; }

        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }
    }
}
