using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Module.InitialRegistration.Domain.Colors;

namespace Esr.Module.FleetManagement.Domain.Vehicles
{
    [DisplayName(@"Modelo X Cor")]
    public class ColorModelVehicle : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Modelo"), Required]
        public int ModelVehicleId { get; set; }
        public virtual ModelVehicle ModelVehicle { get; set; }

        [DisplayName(@"Cor"), Required]
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }

        public bool Integration { get; set; }
    }
}
