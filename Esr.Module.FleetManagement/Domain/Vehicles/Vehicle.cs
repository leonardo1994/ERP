using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;

namespace Esr.Module.FleetManagement.Domain.Vehicles
{
    [DisplayName(@"Veículo")]
    public class Vehicle : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"Code"), Required, Unique]
        public string CodeVehicle { get; set; }

        [DisplayName(@"Veículo"), Required]
        public string NameVehicle { get; set; }

        public DateTime? DateUpdate { get; set; }

        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<VehiclePlate> VehiclePlates { get; set; }
        public virtual ICollection<VehicleModelVehicle> VehicleModelVehicles { get; set; }
    }
}
