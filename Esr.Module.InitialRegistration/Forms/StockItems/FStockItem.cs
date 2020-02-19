using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.EnumBase;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    public partial class FStockItem : FForm
    {
        public FStockItem()
        {
            Module = "Cadastros Iniciais";
            ObjectControl = new List<StockItem>();

            InvokeMethod = new InvokeMethod(typeof(StockItemController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListStockItem" }
            }, typeof(StockItem));

            InitializeComponent();
            ImageSource = Properties.Resources.Icon_stock;

            Situation.SetEnumItems<Situation>(Core.Domain.EnumBase.Situation.Active);

            UnitMeasureId.FormType = typeof(FUnitMeasure);
            UnitMeasureId.ObjetoApp = new InvokeMethod(typeof(UnitMeasureController), TypeExecute.SearchAll, "ListUnitMeasure", typeof(UnitMeasure));
            UnitMeasureId.ValueMember = "Id";
            UnitMeasureId.DisplayMember = "Initials";

            OriginItem.SetEnumItems<OriginItem>(Core.Domain.EnumBase.OriginItem.Origin0);

            MerchandiseUse.SetEnumItems<MerchandiseUse>(Core.Domain.EnumBase.MerchandiseUse.Commercialization);

            FamilyId.FormType = typeof(FFamily);
            FamilyId.ObjetoApp = new InvokeMethod(typeof(FamilyController), TypeExecute.SearchAll, "ListFamily", typeof(Family));
            FamilyId.DisplayMember = "FamilyName";
            FamilyId.ValueMember = "Id";

            NcmId.FormType = typeof(FNcm);
            NcmId.ObjetoApp = new InvokeMethod(typeof(NcmController), TypeExecute.SearchAll, "ListNcm", typeof(Ncm));
            NcmId.DisplayMember = "NcmName";
            NcmId.ValueMember = "Id";

            FeaturedNcmId.ObjetoApp = new InvokeMethod(typeof(FeaturedNcmController), TypeExecute.SearchAll, "ListFeaturedNcm", typeof(FeaturedNcm));
            FeaturedNcmId.DisplayMember = "Description";
            FeaturedNcmId.ValueMember = "Id";
            
            TypeValueCommission.SetEnumItems<TypeValue>(TypeValue.Porcent);

            TypeValueProfit.SetEnumItems<TypeValue>(TypeValue.Porcent);

            ValidityType.SetEnumItems<ValidityType>(Core.Domain.EnumBase.ValidityType.Day);

            MarkId.FormType = typeof(FMark);
            MarkId.ObjetoApp = new InvokeMethod(typeof(MarkController), TypeExecute.SearchAll, "ListMark", typeof(Mark));
            MarkId.DisplayMember = "Description";
            MarkId.ValueMember = "Id";

            ModelId.FormType = typeof(FModel);
            ModelId.ObjetoApp = new InvokeMethod(typeof(ModelController), TypeExecute.SearchAll, "ListModel", typeof(Model)); 
            ModelId.DisplayMember = "Description";
            ModelId.ValueMember = "Id";

            SpecialTaxs.FormType = typeof(FSpecialTax);
            SpecialTaxs.ObjetoApp = new InvokeMethod(typeof(SpecialTaxController), TypeExecute.Search, "Search", typeof(SpecialTax));
            SpecialTaxs.IsDependecyUkey = true;
            SpecialTaxs.ScreenSecondary = true;
            SpecialTaxs.Caption = "Impostos específicos";

            Compositions.FormType = typeof(FComposition);
            Compositions.ObjetoApp = new InvokeMethod(typeof(CompositionController), TypeExecute.Search, "Search", typeof(Composition));
            Compositions.IsDependecyUkey = true;
            Compositions.ScreenSecondary = true;
            Compositions.Caption = "Composição";

            ItemSuppliers.FormType = typeof(FItemSuppliers);
            ItemSuppliers.ObjetoApp = new InvokeMethod(typeof(ItemSuppliersController), TypeExecute.Search, "Search", typeof(ItemSuppliers));
            ItemSuppliers.IsDependecyUkey = true;
            ItemSuppliers.ScreenSecondary = true;
            ItemSuppliers.Caption = "Fornecedores";

            ImageSource = Properties.Resources.Icon_stock;
        }
    }
}