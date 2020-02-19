using Esr.Core.Component;
using Esr.Module.Parking.Controllers;
using Esr.Module.Parking.Domain;
using System.Collections.Generic;

namespace Esr.Module.Parking.Forms
{
    public partial class FParkingHoursVariation : FForm
    {
        public FParkingHoursVariation()
        {
            Module = "Estacionamento";

            ObjectControl = new List<ParkingHoursVariation>();

            InvokeMethod = new InvokeMethod(typeof(ParkingHoursVariationController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListParkingHoursVariation" }
            }, typeof(ParkingHoursVariation));

            InitializeComponent();
        }
    }
}