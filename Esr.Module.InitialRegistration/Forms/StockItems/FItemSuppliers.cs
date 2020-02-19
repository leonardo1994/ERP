using Esr.Core.Component;
using Esr.Module.InitialRegistration.App.ItemSupplierss;
using Esr.Module.InitialRegistration.App.Providers;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.InitialRegistration.Domain.Providers;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Forms.Providers;
using System.Collections.Generic;

namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    public partial class FItemSuppliers : FForm
    {
        public FItemSuppliers()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(ItemSuppliersController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListItemSuppliers" }
            }, typeof(ItemSuppliers));

            ObjectControl = new List<ItemSuppliers>();
            InitializeComponent();

            ProviderId.DisplayMember = "PersonName";
            ProviderId.ValueMember = "Id";
            ProviderId.ObjetoApp = new InvokeMethod(typeof(ProviderController), TypeExecute.SearchAll, "ListProvider", typeof(Provider));
            ProviderId.FormType = typeof(FProvider);

            ImageSource = Properties.Resources.icon_provider;
        }
    }
}