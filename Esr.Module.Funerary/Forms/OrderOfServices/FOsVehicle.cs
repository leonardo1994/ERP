using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.FleetManagement.Forms.Drives;
using Esr.Module.FleetManagement.Forms.Vehicles;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.InitialRegistration.Forms.Services;
using Esr.Module.Funerary.Controllers;
using Esr.Module.FleetManagement.Controllers;
using Esr.Module.FleetManagement.Domain.Drives;
using Esr.Module.FleetManagement.Domain.Vehicles;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.InitialRegistration.Domain.Services;

namespace Esr.Module.Funerary.Forms.OrderOfServices
{
    public partial class FOsVehicle : FForm
    {
        public FOsVehicle()
        {
            Module = "Funerária";

            InvokeMethod = new InvokeMethod(typeof(OsVehicleController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListOsVehicle" }
            }, typeof(OsVehicle));

            ObjectControl = new List<OsVehicle>();

            InitializeComponent();

            DriveId.ValueMember = "Id";
            DriveId.DisplayMember = "DriveName";
            DriveId.ObjetoApp = new InvokeMethod(typeof(DriveController), TypeExecute.SearchAll, "ListDrive", typeof(Drive));
            DriveId.FormType = typeof(FDrive);

            VehiclePlateId.ValueMember = "Id";
            VehiclePlateId.DisplayMember = "Plate";
            VehiclePlateId.ObjetoApp = new InvokeMethod(typeof(VehiclePlateController), TypeExecute.SearchAll, "ListVehiclePlate", typeof(VehiclePlate));
            VehiclePlateId.FormType = typeof(FVehiclePlate);

            ServiceId.ValueMember = "Id";
            ServiceId.DisplayMember = "Description";
            ServiceId.ObjetoApp = new InvokeMethod(typeof(ServiceController), TypeExecute.SearchAll, "ListService", typeof(Service));
            ServiceId.FormType = typeof(FService);
        }
    }
}