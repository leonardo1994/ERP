using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Catalog;
using Esr.Module.ControlPainel.Controllers;

namespace Esr.Module.ControlPainel.Forms
{
    public partial class FTable : FForm
    {
        public FTable()
        {
            InvokeMethod = new InvokeMethod(typeof(TableController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListTable" }
            }, typeof(Table));

            ObjectControl = new List<Table>();

            InitializeComponent();

            ImageSource = Properties.Resources.icon_screen;
        }
    }
}
