using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;

namespace Esr.Module.Funerary.Domain.OrderOfServices
{
    [DisplayName(@"Documento")]
    public class OsDocument : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [Required]
        public int OrderOfServiceId { get; set; }
        public virtual OrderOfService OrderOfService { get; set; }

        [DisplayName(@"Descrição"), Required]
        public string Description { get; set; }

        [DisplayName(@"Selecione o arquivo")]
        public string Archive { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }
    }
}
