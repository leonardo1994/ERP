using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esr.Module.Parking.Domain
{
    [Table("ParkingItemTableOfPrice")]
    [DisplayName("Item da Tabela de Preço")]
    public class ParkingItemTableOfPrice : IEntityBase
    {
        public int Id { get; set; }
        public DateTime? DateRegistration { get; set; }
        public DateTime? DateUpdate { get; set; }
        public Company CompanyControl { get; set; }
        public int? CompanyControlId { get; set; }
        public int? UserControlId { get; set; }
        public bool Integration { get; set; }
        public Status Status { get; set; }
        public User UserControl { get; set; }

        [Required]
        [DisplayName("Tabela de Preço")]
        public int ParkingTableOfPriceId { get; set; }
        public virtual ParkingTableOfPrice ParkingTableOfPrice { get; set; }

        public int SituationId { get { return (int)Situation; } set { Situation = (Situation)value; } }
        [Required]
        public Situation Situation { get; set; }

        [Required]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DisplayName("Tolerância")]
        public decimal Tolerance { get; set; }

        [DisplayName("Preço Máximo")]
        public decimal MaxinumPrice { get; set; }

        [DisplayName("Tempo")]
        public decimal TimeOvertime { get; set; }

        [Required]
        public TimeType TypeTimeOvertime { get; set; }

        [DisplayName("Valor")]
        public decimal ValueOvertime { get; set; }

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
        public virtual ICollection<ParkingHoursVariation> ParkingHoursVariations { get; set; }
    }
}