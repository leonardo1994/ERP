using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.ClassBase;

namespace Esr.Core.Domain.Authentication
{
    [Table("User")]
    [DisplayName(@"Usuários")]
    public class User : IEntityBase
    {
        public int Id { get; set; }

        public Status Status { get; set; }

        [DisplayName(@"Nome"), Required(ErrorMessage = @"é obrigatório")]
        public string UserName { get; set; }

        [DisplayName(@"Login"), Required(ErrorMessage = @"é obrigatório")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [DisplayName(@"Senha"), Required(ErrorMessage = @"é obrigatório")]
        [MinLength(6)]
        public string Password { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [DisplayName(@"Confirmar Senha")]
        [Required]
        [MinLength(6)]
        public string PasswordCompare { get; set; }

        [DisplayName("Administrador")]
        [LockedTrueValue(new[] { "UsersCompanies" }, new object[] { true })]
        public bool IsAdministrator { get; set; }

        [DisplayName("Acesso a todas as empresas")]
        public bool AccessAllCompanies { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<UserCompany> UsersCompanies { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
    }
}
