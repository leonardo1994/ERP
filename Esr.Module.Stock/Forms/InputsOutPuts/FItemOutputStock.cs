using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.InitialRegistration.App.StockItems;
using Esr.Module.InitialRegistration.Forms.StockItems;
using Esr.Module.Stock.Domain.Movements;
using Esr.Module.Stock.Controllers;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.InitialRegistration.Domain.StockItems;

namespace Esr.Module.Stock.Forms.InputsOutPuts
{
    public partial class FItemOutputStock : FForm
    {
        public FItemOutputStock()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(ItemOutputStockController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListItemOutputStock" }
            }, typeof(ItemOutputStock));

            ObjectControl = new List<ItemOutputStock>();

            InitializeComponent();

            LocalStockId.DisplayMember = "LocalName";
            LocalStockId.ValueMember = "Id";
            LocalStockId.FormType = typeof(FLocalStock);
            LocalStockId.ObjetoApp = new InvokeMethod(typeof(LocalStockController), TypeExecute.SearchAll, "ListLocalStock", typeof(LocalStock));

            StockItemId.DisplayMember = "Description";
            StockItemId.ValueMember = "Id";
            StockItemId.ObjetoApp = new InvokeMethod(typeof(StockItemController), TypeExecute.SearchAll, "ListStockItem", typeof(StockItem));
            StockItemId.FormType = typeof(FInputStock);

            UnitMeasureId.FormType = typeof(FUnitMeasure);
            UnitMeasureId.ObjetoApp = new InvokeMethod(typeof(UnitMeasureController), TypeExecute.SearchAll, "ListUnitMeasure", typeof(UnitMeasure));
            UnitMeasureId.ValueMember = "Id";
            UnitMeasureId.DisplayMember = "Initials";
        }
    }
}
