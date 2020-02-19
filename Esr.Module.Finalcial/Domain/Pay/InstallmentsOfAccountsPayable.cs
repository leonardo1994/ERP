using Esr.Core.Domain.ClassBase;
using System.ComponentModel;
using Esr.Core.Domain.Authentication;
using System;
using System.ComponentModel.DataAnnotations;

namespace Esr.Module.Financial.Domain.Pay
{
    /// <summary>
    /// Parcela do Contas a Receber
    /// </summary>
    [DisplayName("Parcela do Contas a Pagar")]
    public class InstallmentsOfAccountsPayable : IEntityBase
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
        /// Contas a Receber
        /// </summary>
        [DisplayName("Contas a Pagar")]
        public int BillsToPayId { get; set; }
        public virtual BillsToPay BillsToPay { get; set; }

        /// <summary>
        /// Número da Parcela
        /// </summary>
        [Required]
        [DisplayName("Número da Parcela")]
        public string PortionNumber { get; set; }

        /// <summary>
        /// Vencimento Real
        /// </summary>
        [Required]
        [DisplayName("Vencimento Real")]
        public DateTime ActualMaturity { get; set; }

        /// <summary>
        /// Vencimento Nominal
        /// </summary>
        [Required]
        [DisplayName("Vencimento Nominal")]
        public DateTime NominalMaturity { get; set; }

        /// <summary>
        /// Valor da Parcela
        /// </summary>
        [Required]
        [DisplayName("Valor da Parcela")]
        public decimal PlotValue { get; set; }
    }
}