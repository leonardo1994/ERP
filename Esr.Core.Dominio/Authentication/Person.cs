using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.Address;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.ClassBase;

namespace Esr.Core.Domain.Authentication
{
    [Table("Person")]
    [DisplayName("Pessoa")]
    public class Person : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName("Código")]
        public virtual string Code { get; set; }

        [Required]
        [DisplayName("Nome")]
        public virtual string PersonName { get; set; }

        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress)]
        public virtual string Email { get; set; }

        [DisplayName("Telefone Fixo")]
        [DataType(DataType.PhoneNumber)]
        public virtual string LandLine { get; set; }

        [DisplayName("Telefone Celular")]
        [DataType(DataType.PhoneNumber)]
        public virtual string CellPhone { get; set; }

        [DisplayName("Telefone Comercial")]
        [DataType(DataType.PhoneNumber)]
        public virtual string CommercialPhone { get; set; }

        [DisplayName("Cep")]
        public string ZipCode { get; set; }

        [DisplayName("Rua/Av.")]
        public string Street { get; set; }

        [DisplayName("Bairro")]
        public string Neighborhood { get; set; }

        [DisplayName(@"País")]
        public int? CountryId { get; set; }
        public virtual Country Country { get; set; }

        [DisplayName(@"Estado"), DependencyKey("CountryId")]
        public int? StateId { get; set; }
        public virtual State State { get; set; }

        [DisplayName(@"Cidade"), DependencyKey("StateId")]
        public int? CityId { get; set; }
        public virtual City City { get; set; }

        [DisplayName("Número")]
        public decimal NumberStreet { get; set; }

        [DisplayName("Complemento")]
        public string Complement { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
    }
}
