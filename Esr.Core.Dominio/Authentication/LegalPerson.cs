using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Attributes;

namespace Esr.Core.Domain.Authentication
{
    [DisplayName("Pessoa Jurídica")]
    public class LegalPerson : Person
    {
        [DisplayName("Nome Fantasia")]
        public override string PersonName { get; set; }

        [Required]
        [DisplayName(@"Razão Social")]
        public virtual string CorporateName { get; set; }

        [Required]
        [CnpjValidator]
        [DisplayName(@"Cnpj")]
        [Unique]
        public virtual string Cnpj { get; set; }
    }
}