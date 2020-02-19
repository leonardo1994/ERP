using Esr.Core.Component;
using Esr.Module.FleetManagement.Controllers;
using Esr.Module.FleetManagement.Domain.Vehicles;
using Esr.Module.FleetManagement.Forms.Vehicles;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.InitialRegistration.Domain.Persons;
using Esr.Module.InitialRegistration.Forms.Persons;
using Esr.Module.Parking.Controllers;
using Esr.Module.Parking.Domain;
using System.Collections.Generic;

namespace Esr.Module.Parking.Forms
{
    public partial class FParkingIn : FProcess
    {
        public FParkingIn()
        {
            ObjectControl = new List<ParkingInOut>();

            InvokeMethod = new InvokeMethod(typeof(ParkingInOutController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "GerarEntrada" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListParkingInOut" }
            }, typeof(ParkingInOut));

            InitializeComponent();

            VehiclePlateId.DisplayMember = "Plate";
            VehiclePlateId.ValueMember = "Id";
            VehiclePlateId.ObjetoApp = new InvokeMethod(typeof(VehiclePlateController), TypeExecute.SearchAll, "ListVehiclePlate", typeof(VehiclePlate));
            VehiclePlateId.FormType = typeof(FVehiclePlate);
            VehiclePlateId.PropertySearch = "Plate";

            PhysicalPersonId.DisplayMember = "PersonName";
            PhysicalPersonId.ValueMember = "Id";
            PhysicalPersonId.ObjetoApp = new InvokeMethod(typeof(PhysicalPersonController), TypeExecute.SearchAll, "ListPhysicalPerson", typeof(PhysicalPerson));
            PhysicalPersonId.FormType = typeof(FPhysicalPerson);

            ParkingTableOfPriceId.DisplayMember = "Description";
            ParkingTableOfPriceId.ValueMember = "Id";
            ParkingTableOfPriceId.ObjetoApp = new InvokeMethod(typeof(ParkingTableOfPriceController), TypeExecute.SearchAll, "ListParkingTableOfPrice", typeof(ParkingTableOfPrice));
            ParkingTableOfPriceId.FormType = typeof(FParkingTableOfPrice);

            ParkingItemTableOfPriceId.DisplayMember = "Description";
            ParkingItemTableOfPriceId.ValueMember = "Id";
            ParkingItemTableOfPriceId.ObjetoApp = new InvokeMethod(typeof(ParkingItemTableOfPriceController), TypeExecute.Search, "ListParkingItemTableOfPrice", typeof(ParkingItemTableOfPrice));

            ImageSource = Properties.Resources.Icon_Parking;
        }
    }
}