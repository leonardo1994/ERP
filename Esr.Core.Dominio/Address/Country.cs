using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;

namespace Esr.Core.Domain.Address
{
    [DisplayName(@"Pais")]
    public class Country : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Pais"), Required]
        public string CountryName { get; set; }

        [DisplayName(@"Sigla"), Required]
        public string Initials { get; set; }

        [DisplayName(@"Código IBGE")]
        public string CodeIbge { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<State> States { get; set; }
        public virtual ICollection<PublicPlace> PublicPlaces { get; set; }
        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}