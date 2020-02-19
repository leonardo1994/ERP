using Esr.Core.Domain.ClassBase;
using System;
using Esr.Core.Domain.Authentication;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.EnumBase;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Esr.Core.Domain.Attributes;

namespace Esr.Module.Parking.Domain
{
    [Table("ParkingAgreement")]
    [DisplayName("Convênio Estacionamento")]
    public class ParkingAgreement : IEntityBase
    {
        public Company CompanyControl { get; set; }
        public int? CompanyControlId { get; set; }
        public DateTime? DateRegistration { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int Id { get; set; }
        public bool Integration { get; set; }
        public Status Status { get; set; }
        public User UserControl { get; set; }
        public int? UserControlId { get; set; }

        [DisplayName("Código")]
        public string Code { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }

        public int SituationId { get { return (int)Situation; } set { Situation = (Situation)value; } }
        [Required]
        public Situation Situation { get; set; }

        [DisplayName("Empresa")]
        public int LegalPersonId { get; set; }
        public virtual LegalPerson LegalPerson { get; set; }

        [DisplayName("Hora Fixa ?")]
        [LockedTrueValue(new[] { "ParkingFinalHour" }, new object[] { true })]
        public bool ParkingFixedTime { get; set; }

        [DataType(DataType.Time)]
        [DisplayName("Hora Inicial")]
        public DateTime ParkingStartingTime { get; set; }

        [DataType(DataType.Time)]
        [DisplayName("Hora Final")]
        public DateTime ParkingFinalHour { get; set; }

        [DisplayName("Desconto R$")]
        public decimal DiscountValueReal { get; set; }

        [DisplayName("Desconto %")]
        public decimal DiscountValuePorcent { get; set; }

        /// <summary>
        /// Segunda-Feira.
        /// </summary>
        [DisplayName("Segunda-Feira")]
        public bool Monday { get; set; }

        /// <summary>
        /// Terça-Feira
        /// </summary>
        [DisplayName("Terça-Feira")]
        public bool Tuesday { get; set; }

        /// <summary>
        /// Quarta-Feira
        /// </summary>
        [DisplayName("Quarta-Feira")]
        public bool Wednesday { get; set; }

        /// <summary>
        /// Quinta-Feira
        /// </summary>
        [DisplayName("Quinta-Feira")]
        public bool Thursday { get; set; }

        /// <summary>
        /// Sexta-Feira
        /// </summary>
        [DisplayName("Sexta-Feira")]
        public bool Friday { get; set; }

        /// <summary>
        /// Sábado
        /// </summary>
        [DisplayName("Sábado")]
        public bool Saturday { get; set; }

        /// <summary>
        /// Domingo
        /// </summary>
        [DisplayName("Domingo")]
        public bool Sunday { get; set; }

        /// <summary>
        /// Feriado
        /// </summary>
        [DisplayName("Feriado")]
        public bool Holiday { get; set; }

        public virtual ICollection<ParkingInOut> ListParkingInOut { get; set; }
    }
}
