using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    public partial class FUnitMeasure : FForm
    {
        public FUnitMeasure()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(UnitMeasureController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListUnitMeasure" }
            }, typeof(UnitMeasure));

            ObjectControl = new List<UnitMeasure>();
            InitializeComponent();

            UnitMeasureConversions.FormType = typeof(FUnitMeasureConversion);
            UnitMeasureConversions.ObjetoApp = new InvokeMethod(typeof(UnitMeasureConversionController), TypeExecute.Search, "ListUnitMeasureConversion", typeof(UnitMeasureConversion));
            UnitMeasureConversions.ScreenSecondary = true;
            UnitMeasureConversions.IsDependecyUkey = true;
            UnitMeasureConversions.PropertyDependecyUkey = "FirstUnitMeasureId";
            UnitMeasureConversions.Caption = "Conversões da unidade de medida";

            ImageSource = Properties.Resources.icon_unitMeasure;
        }
    }
}