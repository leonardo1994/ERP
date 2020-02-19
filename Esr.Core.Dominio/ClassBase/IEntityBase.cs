using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.Authentication;

namespace Esr.Core.Domain.ClassBase
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados
    public interface IEntityBase
    {
        /// <summary>
        /// Chave Primária
        /// </summary>
        [Key]
        int Id { get; set; }

        /// <summary>
        /// Status do Registro
        /// </summary>
        Status Status { get; set; }

        /// <summary>
        /// Data de Alteração
        /// </summary>
        [DisplayName("Data de Alteração")]
        [Column(Order = 2, TypeName = "datetime2")]
        DateTime? DateUpdate { get; set; }

        /// <summary>
        /// Data de Cadastro
        /// </summary>
        [Column(Order = 3, TypeName = "datetime2")]
        [DisplayName("Data de Cadastro")]
        DateTime? DateRegistration { get; set; }

        /// <summary>
        /// Usuário
        /// </summary>
        [DisplayName("Usuário")]
        int? UserControlId { get; set; }
        User UserControl { get; set; }

        /// <summary>
        /// Empresa
        /// </summary>
        [DisplayName("Empresa")]
        int? CompanyControlId { get; set; }
        Company CompanyControl { get; set; }

        /// <summary>
        /// Proveniente de Integração
        /// </summary>
        [DisplayName("Proveniente de integração")]
        bool Integration { get; set; }
    }

    public enum Status
    {
        Confirmed,
        NoConfirmed
    }
}
