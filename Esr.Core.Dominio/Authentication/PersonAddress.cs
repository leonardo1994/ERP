using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Address;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.ClassBase;

namespace Esr.Core.Domain.Authentication
{
    [DisplayName(@"Endereços")]
    public class PersonAddress : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        [DisplayName(@"Cep"), Required, Unique]
        public string ZipCode { get; set; }

        [DisplayName(@"Rua"), Required]
        public string Street { get; set; }

        [DisplayName(@"Número"), Required, Range(1, double.MaxValue)]
        public decimal Number { get; set; }

        [DisplayName(@"Bairro"), Required]
        public string Neighborhood { get; set; }

        [DisplayName(@"País"), Required]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        [DisplayName(@"Estado"), Required, DependencyKey("CountryId")]
        public int StateId { get; set; }
        public virtual State State { get; set; }

        [DisplayName(@"Cidade"), Required, DependencyKey("StateId")]
        public int CityId { get; set; }
        public virtual City City { get; set; }

        [DisplayName(@"Complemento")]
        public string Complement { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }
    }
}
