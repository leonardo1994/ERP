using Esr.Core.Domain.ClassBase;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.Authentication;
using System.ComponentModel;
using Esr.Core.Domain.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Esr.Module.Parking.Domain
{
    [Table("ParkingHoursVariation")]
    [DisplayName("Variação Hora/Preço")]
    public class ParkingHoursVariation : IEntityBase
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

        public int ParkingItemTableOfPriceId { get; set; }
        public virtual ParkingItemTableOfPrice ParkingItemTableOfPrice { get; set; }

        [DisplayName("Hora Fixa ?")]
        [LockedTrueValue(new[] { "ParkingFinalHour" }, new object[] { true })]
        public bool ParkingFixedTime { get; set; }

        [DataType(DataType.Time)]
        [DisplayName("Hora Inicial")]
        public DateTime ParkingStartingTime { get; set; }

        [DataType(DataType.Time)]
        [DisplayName("Hora Final")]
        public DateTime ParkingFinalHour { get; set; }

        [DisplayName("Valor")]
        public decimal ParkingValue { get; set; }
    }
}