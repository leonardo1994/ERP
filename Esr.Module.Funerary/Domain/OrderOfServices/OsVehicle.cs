using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Module.FleetManagement.Domain.Drives;
using Esr.Module.FleetManagement.Domain.Vehicles;
using Esr.Module.InitialRegistration.Domain.Services;
using Esr.Core.Domain.Attributes;

namespace Esr.Module.Funerary.Domain.OrderOfServices
{
    [DisplayName(@"Frota X Serviços")]
    public class OsVehicle : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"OS"), Required]
        public int OrderOfServiceId { get; set; }
        public virtual OrderOfService OrderOfService { get; set; }

        [DisplayName(@"Motorista"), Required]
        public int DriveId { get; set; }
        public virtual Drive Drive { get; set; }

        [DisplayName(@"Veículo"), Required]
        public int VehiclePlateId { get; set; }
        public virtual VehiclePlate VehiclePlate { get; set; }

        [DisplayName(@"Serviço"), Required, AppendValue(new[] { "ValueService" }, new[] { "ValueService" })]
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }

        [DisplayName(@"Valor R$"), Required]
        public decimal ValueService { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName(@"Data/Hora Inicio"), Required, Column(TypeName = "datetime2")]
        public DateTime DateTimeInitial { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName(@"Data/Hora Final"), Column(TypeName = "datetime2")]
        public DateTime? DateTimeFinal { get; set; }

        public bool Integration { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
    }
}