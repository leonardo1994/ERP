using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.FleetManagement.App.Vehicles;
using Esr.Module.FleetManagement.Domain.Vehicles;
using Esr.Module.FleetManagement.Controllers;

namespace Esr.Module.FleetManagement.Forms.Vehicles
{
    public partial class FVehicle : FForm
    {
        public FVehicle()
        {
            Module = "Gestão de Frotas";

            InvokeMethod = new InvokeMethod(typeof(VehicleController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListVehicle" }
            }, typeof(Vehicle));

            ObjectControl = new List<Vehicle>();

            InitializeComponent();

            VehicleModelVehicles.ObjetoApp = new InvokeMethod(typeof(VehicleModelVehicleController),  new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Search, "Search" }
            } , typeof(VehicleModelVehicle));
            VehicleModelVehicles.ScreenSecondary = true;
            VehicleModelVehicles.IsDependecyUkey = false;
            VehicleModelVehicles.FormType = typeof(FModelVehicle);
            VehicleModelVehicles.Caption = "Modelos";
            VehicleModelVehicles.PropertyDisplayForm = "ModelVehicleId";

            ImageSource = Properties.Resources.icon_vehicle;
        }
    }
}
