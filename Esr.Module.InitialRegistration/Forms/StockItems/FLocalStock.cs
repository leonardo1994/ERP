using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.EnumBase;
using Esr.Module.InitialRegistration.App.StockItems;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    public partial class FLocalStock : FForm
    {
        public FLocalStock()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(LocalStockController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListLocalStock" }
            }, typeof(LocalStock));

            ObjectControl = new List<LocalStock>();

            InitializeComponent();

            TypeStructure.SetEnumItems<TypeStructure>(Core.Domain.EnumBase.TypeStructure.Sinthetic);

            LocalStocks.FormType = typeof(FLocalStock);
            LocalStocks.ObjetoApp = new InvokeMethod(typeof(LocalStockController), TypeExecute.Search, "Search", typeof(LocalStock));
            LocalStocks.ScreenSecondary = true;
            LocalStocks.IsDependecyUkey = true;
            LocalStocks.PropertyDependecyUkey = "LocalStockMasterId";
            LocalStocks.Caption = "Sub Locais";

            ImageSource = Properties.Resources.local;
        }
    }
}
