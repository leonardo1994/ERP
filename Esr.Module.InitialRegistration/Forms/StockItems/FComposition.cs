using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.InitialRegistration.App.StockItems;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    public partial class FComposition : FForm
    {
        public FComposition()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(CompositionController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListComposition" }
            }, typeof(Composition));

            ObjectControl = new List<Composition>();
            InitializeComponent();

            StockItemId.DisplayMember = "Description";
            StockItemId.ValueMember = "Id";
            StockItemId.ObjetoApp = new InvokeMethod(typeof(StockItemController), TypeExecute.SearchAll, "ListStockItem", typeof(StockItem));
            StockItemId.FormType = typeof(FStockItem);

            UnitMeasureId.DisplayMember = "Initials";
            UnitMeasureId.ValueMember = "Id";
            UnitMeasureId.ObjetoApp = new InvokeMethod(typeof(UnitMeasureController), TypeExecute.SearchAll, "ListUnitMeasure", typeof(UnitMeasure));
            UnitMeasureId.FormType = typeof(FUnitMeasure);

            ImageSource = Properties.Resources.ion_composition;
        }
    }
}
