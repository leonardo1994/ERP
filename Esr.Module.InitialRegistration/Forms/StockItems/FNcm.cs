using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.InitialRegistration.App.StockItems;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    public partial class FNcm : FForm
    {
        public FNcm()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(NcmController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListNcm" }
            }, typeof(Ncm));

            ObjectControl = new List<Ncm>();

            InitializeComponent();

            FeaturedNcms.FormType = typeof(FFeaturedNcm);
            FeaturedNcms.ObjetoApp = new InvokeMethod(typeof(FeaturedNcmController), TypeExecute.Search, "Search", typeof(FFeaturedNcm));
            FeaturedNcms.IsDependecyUkey = true;
            FeaturedNcms.ScreenSecondary = true;
            FeaturedNcms.Caption = "Destaque da NCM";

            ImageSource = Properties.Resources.icon_ncm_fw;
        }
    }
}
