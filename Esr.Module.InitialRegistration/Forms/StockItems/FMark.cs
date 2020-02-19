using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.InitialRegistration.App.StockItems;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    public partial class FMark : FForm
    {
        public FMark()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(MarkController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListMark" }
            }, typeof(Mark));

            ObjectControl = new List<Mark>();
            InitializeComponent();

            ImageSource = Properties.Resources.icon_mark;
        }
    }
}
