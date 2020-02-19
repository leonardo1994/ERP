using Esr.Core.Component;
using Esr.Core.Domain.EnumBase;
using Esr.Module.Parking.Controllers;
using Esr.Module.Parking.Domain;
using System.Collections.Generic;
using System;

namespace Esr.Module.Parking.Forms
{
    public partial class FParkingItemTableOfPrice : FForm
    {
        public FParkingItemTableOfPrice()
        {
            Module = "Estacionamento";

            ObjectControl = new List<ParkingItemTableOfPrice>();

            InvokeMethod = new InvokeMethod(typeof(ParkingItemTableOfPriceController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListParkingItemTableOfPrice" }
            }, typeof(ParkingItemTableOfPrice));

            InitializeComponent();

            Situation.SetEnumItems<Situation>(Core.Domain.EnumBase.Situation.Active);

            TypeTimeOvertime.SetEnumItems<TimeType>(TimeType.Hour);

            ParkingHoursVariations.FormType = typeof(FParkingHoursVariation);
            ParkingHoursVariations.ObjetoApp = new InvokeMethod(typeof(ParkingHoursVariationController), TypeExecute.Search, "ListParkingHoursVariation", typeof(ParkingHoursVariation));
            ParkingHoursVariations.ScreenSecondary = true;
            ParkingHoursVariations.IsDependecyUkey = true;
            ParkingHoursVariations.Caption = "Varição de Hora/Preço";

            ImageSource = Properties.Resources.Icon_ItemTableOfPrice;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var col1 = ParkingHoursVariations.SComponent.Columns["ParkingStartingTime"];
            if (col1 != null)
                col1.DefaultCellStyle.Format = "HH:mm";

            var col2 = ParkingHoursVariations.SComponent.Columns["ParkingFinalHour"];
            if (col2 != null)
                col2.DefaultCellStyle.Format = "HH:mm";

            var col3 = ParkingHoursVariations.SComponent.Columns["ParkingValue"];
            if (col3 != null)
                col3.DefaultCellStyle.Format = "C2";
        }
    }
}