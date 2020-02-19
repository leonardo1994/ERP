using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.EnumBase;
using Esr.Core.Domain.FiltersCompanies;

namespace Esr.Core.Domain.Authentication
{
    [Table("Company")]
    [DisplayName(@"Empresas")]
    public class Company : LegalPerson
    {
        [Required]
        [DisplayName(@"Tipo")]
        public TypeCompany TypeCompany { get; set; }

        public int TypeCompanyId { get { return (int)TypeCompany; } set { TypeCompany = (TypeCompany)value; } }

        public virtual ICollection<UserCompany> UsersCompanies { get; set; }
        public virtual ICollection<FilterCompany> FiltersCompanies { get; set; }
    }
}