using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    public partial class FModel : FForm
    {
        public FModel()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(ModelController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListModel" }
            }, typeof(Model));

            ObjectControl = new List<Model>();
            InitializeComponent();

            ImageSource = Properties.Resources.icon_model;
        }
    }
}
