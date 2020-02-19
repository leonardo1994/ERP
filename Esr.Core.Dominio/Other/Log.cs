using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Esr.Core.Domain.Other
{
    [DisplayName("Log do sistema")]
    public class Log : IEntityBase
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

        [DisplayName("Origem")]
        public string Origin { get; set; }
        public int? OriginId { get; set; }

        [DisplayName("Destino")]
        public string Destination { get; set; }
        public int? DestinationId { get; set; }

        [DisplayName("Identificação")]
        public string Identification { get; set; }

        [DisplayName("Descriçao")]
        public string Description { get; set; }

        public ProcessStatus ProcessStatus { get; set; }
    }

    public enum ProcessStatus
    {
        [Display(Name = "Erro no processo")]
        Error,
        [Display(Name = "Processado com sucesso")]
        Success,
        [Display(Name = "Alerta no processo")]
        Alert
    }
}