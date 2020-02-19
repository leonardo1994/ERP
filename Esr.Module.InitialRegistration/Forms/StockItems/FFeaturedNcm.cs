using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    public partial class FFeaturedNcm : FForm
    {
        public FFeaturedNcm()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(FeaturedNcmController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListFeaturedNcm" }
            }, typeof(FeaturedNcm));

            ObjectControl = new List<FeaturedNcm>();

            InitializeComponent();

            NcmId.FormType = typeof(FNcm);
            NcmId.ObjetoApp = new InvokeMethod(typeof(FeaturedNcmController), TypeExecute.SearchAll, "SearchAll", typeof(Ncm));
            NcmId.DisplayMember = "NcmName";
            NcmId.ValueMember = "Id";

            ImageSource = Properties.Resources.Icon_stock;
        }
    }
}