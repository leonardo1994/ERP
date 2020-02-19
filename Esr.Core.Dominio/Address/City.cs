using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;

namespace Esr.Core.Domain.Address
{
    [DisplayName(@"Cidade")]
    public class City : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Nome"), Required]
        public string CityName { get; set; }

        [DisplayName(@"Código IBGE")]
        public string CodeIbge { get; set; }

        [DisplayName(@"Estado"), Required]
        public int StateId { get; set; }
        public virtual State State { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }

        public bool Integration { get; set; }

        public virtual ICollection<PublicPlace> PublicPlaces { get; set; }
        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}