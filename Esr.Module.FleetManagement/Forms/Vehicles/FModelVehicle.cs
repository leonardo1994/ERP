using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.FleetManagement.App.Vehicles;
using Esr.Module.FleetManagement.Domain.Vehicles;
using Esr.Module.InitialRegistration.Forms.Colors;
using Esr.Module.FleetManagement.Controllers;

namespace Esr.Module.FleetManagement.Forms.Vehicles
{
    public partial class FModelVehicle : FForm
    {
        public FModelVehicle()
        {
            Module = "Gestão de Frotas";

            InvokeMethod = new InvokeMethod(typeof(ModelVehicleController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListModelVehicle" }
            }, typeof(ModelVehicle));

            ObjectControl = new List<ModelVehicle>();

            InitializeComponent();

            ColorModelVehicles.ObjetoApp = new InvokeMethod(typeof(ColorModelVehicleController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Search, "Search" }
            }, typeof(ColorModelVehicle));
            ColorModelVehicles.ScreenSecondary = true;
            ColorModelVehicles.IsDependecyUkey = false;
            ColorModelVehicles.FormType = typeof(FColor);
            ColorModelVehicles.Caption = "Cores";

            ImageSource = Properties.Resources.model_vehicle_fw;
        }
    }
}
