using Esr.Core.Component;
using Esr.Core.Domain.EnumBase;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System.Collections.Generic;

namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    public partial class FUnitMeasureConversion : FForm
    {
        public FUnitMeasureConversion()
        {
            Module = "Cadastros Iniciais";
            ObjectControl = new List<UnitMeasureConversion>();
            InvokeMethod = new InvokeMethod(typeof(UnitMeasureConversionController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListUnitMeasureConversion" }
            }, typeof(UnitMeasureConversion));

            InitializeComponent();

            TypeOperation.SetEnumItems<TypeOperation>(Core.Domain.EnumBase.TypeOperation.Multiplication);

            SecondUnitMeasureId.FormType = typeof(FUnitMeasure);
            SecondUnitMeasureId.ObjetoApp = new InvokeMethod(typeof(UnitMeasureController), TypeExecute.SearchAll, "ListUnitMeasure", typeof(UnitMeasure));
            SecondUnitMeasureId.ValueMember = "Id";
            SecondUnitMeasureId.DisplayMember = "Initials";

            FamilyId.FormType = typeof(FFamily);
            FamilyId.ObjetoApp = new InvokeMethod(typeof(FamilyController), TypeExecute.SearchAll, "SearchAll", typeof(Family));
            FamilyId.ValueMember = "Id";
            FamilyId.DisplayMember = "FamilyName";

            StockItemId.FormType = typeof(FStockItem);
            StockItemId.ObjetoApp = new InvokeMethod(typeof(StockItemController), TypeExecute.SearchAll, "SearchAll", typeof(StockItem));
            StockItemId.ValueMember = "Id";
            StockItemId.DisplayMember = "CodeDescription";

            ImageSource = Properties.Resources.icon_unitMeasure;

        }
    }
}