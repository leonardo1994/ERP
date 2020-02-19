using System;
using System.ComponentModel;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;

namespace Esr.Module.FleetManagement.Domain.Vehicles
{
    [DisplayName(@"Veículo X Modelo")]
    public class VehicleModelVehicle : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Veículo")]
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        [DisplayName(@"Modelo")]
        public int ModelVehicleId { get; set; }
        public virtual ModelVehicle ModelVehicle { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }
    }
}
