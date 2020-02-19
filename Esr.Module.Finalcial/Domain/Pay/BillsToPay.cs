using Esr.Core.Domain.ClassBase;
using System.ComponentModel;
using Esr.Core.Domain.Authentication;
using System;
using System.Collections.Generic;
using Esr.Module.Financial.Domain.Financial;
using System.ComponentModel.DataAnnotations;
using Esr.Module.Financial.Domain.Receive;

namespace Esr.Module.Financial.Domain.Pay
{
    /// <summary>
    /// Contas a Receber
    /// </summary>
    [DisplayName("Contas a Pagar")]
    public class BillsToPay : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        /// <summary>
        /// Série do documento.
        /// </summary>
        [DisplayName("Série")]
        public string Series { get; set; }

        /// <summary>
        /// Número do Documento
        /// </summary>
        [DisplayName("Documento")]
        [Required]
        public string Document { get; set; }

        /// <summary>
        /// Referencia de Cliente/Fornecedor/Colaborador.
        /// </summary>
        [DisplayName("Cliente/Fornecedor")]
        [Required]
        public int PersonId { get; set; }
        public Person Person { get; set; }

        /// <summary>
        /// Data de Emissão do Documento
        /// </summary>
        [DisplayName("Data de Emissão")]
        [Required]
        public DateTime DateOfIssure { get; set; }

        /// <summary>
        /// Tipo do Título Financeiro
        /// </summary>
        [DisplayName("Tipo de Documento")]
        [Required]
        public int TypeDocumentFinancialId { get; set; }
        public virtual TypeDocumentFinancial TypeDocumentFinancial { get; set; }

        /// <summary>
        /// Parcelas do Contas a Receber
        /// </summary>
        [DisplayName("Parcelas do Contas a Pagar")]
        public virtual ICollection<InstallmentOfAccountsReceivable> InstallmentsOfAccountsReceivable { get; set; }
    }
}