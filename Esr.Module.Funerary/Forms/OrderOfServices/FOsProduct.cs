using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.InitialRegistration.Forms.StockItems;
using Esr.Module.InitialRegistration.Forms.Providers;
using Esr.Module.Funerary.Controllers;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Domain.Providers;

namespace Esr.Module.Funerary.Forms.OrderOfServices
{
    public partial class FOsProduct : FForm
    {
        public FOsProduct()
        {
            Module = "Funerária";

            InvokeMethod = new InvokeMethod(typeof(OsProductController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListOsProduct" }
            }, typeof(OsProduct));

            ObjectControl = new List<OsProduct>();

            InitializeComponent();

            StockItemId.ValueMember = "Id";
            StockItemId.DisplayMember = "Description";
            StockItemId.ObjetoApp = new InvokeMethod(typeof(StockItemController), TypeExecute.SearchAll, "ListStockItem", typeof(StockItem));
            StockItemId.FormType = typeof(FStockItem);

            LocalStockId.ValueMember = "Id";
            LocalStockId.DisplayMember = "LocalName";
            LocalStockId.ObjetoApp = new InvokeMethod(typeof(LocalStockController), TypeExecute.SearchAll, "ListLocalStock", typeof(LocalStock));
            LocalStockId.FormType = typeof(FLocalStock);

            UnitMeasureId.DisplayMember = "Initials";
            UnitMeasureId.ValueMember = "Id";
            UnitMeasureId.ObjetoApp = new InvokeMethod(typeof(UnitMeasureController), TypeExecute.SearchAll, "ListUnitMeasure", typeof(UnitMeasure));
            UnitMeasureId.FormType = typeof(FUnitMeasure);

            ProviderId.DisplayMember = "PersonName";
            ProviderId.ValueMember = "Id";
            ProviderId.ObjetoApp = new InvokeMethod(typeof(ItemSuppliersController), TypeExecute.Search, "ListItemProvider", typeof(ItemSuppliers));
            ProviderId.FormType = typeof(FProvider);
        }
    }
}