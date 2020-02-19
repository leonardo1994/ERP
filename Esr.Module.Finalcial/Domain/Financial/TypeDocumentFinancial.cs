using System;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Esr.Module.Financial.Domain.Receive;
using Esr.Module.Financial.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esr.Module.Financial.Domain.Financial
{
    /// <summary>
    /// Tipo de Documento do Financeiro
    /// </summary>
    [DisplayName("Tipo de Documento Financeiro")]
    public class TypeDocumentFinancial : IEntityBase
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

        [Required]
        [DisplayName("Código")]
        public string TypeDocumentCode { get; set; }
        [Required]
        [DisplayName("Descrição")]
        public string TypeDocumentDescription { get; set; }

        [Required]
        public int ParticipationId { get { return (int)Participation;  } set { Participation = (Participation)value; } }
        [Required]
        [DisplayName("Participação")]
        public Participation Participation { get; set; }

        public virtual ICollection<BillsToReceive> BillsToReceives { get; set; }
    }
}