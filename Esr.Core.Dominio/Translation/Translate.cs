using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esr.Core.Domain.Translation
{
    [DisplayName("Tradutor")]
    public class Translate : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [DisplayName("Nome da propriedade")]
        [StringLength(100)]
        public string PropertyName { get; set; }

        [DisplayName("Portugues")]
        public string Portugues { get; set; }
        [DisplayName("English")]
        public string English { get; set; }
        [DisplayName("Espanhol")]
        public string Espanhol { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }
    }
}