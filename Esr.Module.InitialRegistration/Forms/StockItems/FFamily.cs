using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.EnumBase;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    public partial class FFamily : FForm
    {
        public FFamily()
        {
            Module = "Cadastros Iniciais";
            ObjectControl = new List<Family>();
            InvokeMethod = new InvokeMethod(typeof(FamilyController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListFamily" }
            }, typeof(Family));

            InitializeComponent();

            TypeStructure.SetEnumItems<TypeStructure>(Core.Domain.EnumBase.TypeStructure.Sinthetic);

            OriginItem.SetEnumItems<OriginItem>(Core.Domain.EnumBase.OriginItem.Origin0);

            Families.FormType = typeof(FFamily);
            Families.ObjetoApp = new InvokeMethod(typeof(FamilyController), TypeExecute.Search, "Search", typeof(Family));
            Families.ScreenSecondary = true;
            Families.IsDependecyUkey = true;
            Families.PropertyDependecyUkey = "FamilyMasterId";
            Families.Caption = "Sub Familias";

            ImageSource = Properties.Resources.icon_family_stock;
        }
    }
}