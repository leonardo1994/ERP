using Esr.Core.Component;
using Esr.Core.Domain.EnumBase;
using Esr.Module.Parking.Controllers;
using Esr.Module.Parking.Domain;
using System.Collections.Generic;

namespace Esr.Module.Parking.Forms
{
    public partial class FParkingTableOfPrice : FForm
    {
        public FParkingTableOfPrice()
        {
            Module = "Estacionamento";

            ObjectControl = new List<ParkingTableOfPrice>();

            InvokeMethod = new InvokeMethod(typeof(ParkingTableOfPriceController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListParkingTableOfPrice" }
            }, typeof(ParkingTableOfPrice));

            InitializeComponent();

            Situation.SetEnumItems<Situation>(Core.Domain.EnumBase.Situation.Active);

            ParkingItemsTableOfPrice.FormType = typeof(FParkingItemTableOfPrice);
            ParkingItemsTableOfPrice.ObjetoApp = new InvokeMethod(typeof(ParkingItemTableOfPriceController), TypeExecute.Search, "ListParkingItemTableOfPrice", typeof(ParkingItemTableOfPrice));
            ParkingItemsTableOfPrice.ScreenSecondary = true;
            ParkingItemsTableOfPrice.IsDependecyUkey = true;
            ParkingItemsTableOfPrice.Caption = "Itens da Tabela de Preço";

            ImageSource = Properties.Resources.Icon_TableOfPrice;
        }
    }
}