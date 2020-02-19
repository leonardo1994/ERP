using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.FleetManagement.Domain.Vehicles;
using Esr.Module.InitialRegistration.Forms.Colors;
using Esr.Module.FleetManagement.Controllers;

namespace Esr.Module.FleetManagement.Forms.Vehicles
{
    public partial class FVehiclePlate : FForm
    {
        public FVehiclePlate()
        {
            Module = "Gestão de Frotas";

            InvokeMethod = new InvokeMethod(typeof(VehiclePlateController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListVehiclePlate" }
            }, typeof(VehiclePlate));

            ObjectControl = new List<VehiclePlate>();

            InitializeComponent();

            Plate.Mask = "AAA-9999";

            VehicleId.ValueMember = "Id";
            VehicleId.DisplayMember = "NameVehicle";
            VehicleId.FormType = typeof(FVehicle);
            VehicleId.ObjetoApp = new InvokeMethod(typeof(VehicleController), TypeExecute.SearchAll, "ListVehicle", typeof(Vehicle));

            ModelVehicleId.ValueMember = "Id";
            ModelVehicleId.DisplayMember = "Description";
            ModelVehicleId.FormType = typeof(FModelVehicle);
            ModelVehicleId.ObjetoApp = new InvokeMethod(typeof(VehicleModelVehicleController), TypeExecute.Search, "ListVehicleModelVehicle", typeof(VehicleModelVehicle));

            ColorId.ValueMember = "Id";
            ColorId.DisplayMember = "Color";
            ColorId.FormType = typeof(FColor);
            ColorId.ObjetoApp = new InvokeMethod(typeof(ColorModelVehicleController), TypeExecute.Search, "ListColorModelVehicle", typeof(ColorModelVehicle));

            ImageSource = Properties.Resources.icon_placa_fw;

        }
    }
}