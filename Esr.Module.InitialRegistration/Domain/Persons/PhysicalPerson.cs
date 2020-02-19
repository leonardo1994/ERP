using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Esr.Module.InitialRegistration.Domain.Persons
{
    [DisplayName("Pessoa Física")]
    public class PhysicalPerson : Person
    {
        [Required]
        [CpfValidator]
        [DisplayName(@"Cpf")]
        [Unique]
        public string Cpf { get; set; }
    }
}