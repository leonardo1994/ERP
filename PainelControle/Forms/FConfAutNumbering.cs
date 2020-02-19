using Esr.Core.Component;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ConfNumbering;
using Esr.Core.Domain.FiltersCompanies;
using Esr.Module.ControlPainel.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace Esr.Module.ControlPainel.Forms
{
    public partial class FConfAutNumbering : FForm
    {
        public FConfAutNumbering()
        {
            ObjectControl = new List<AutomaticNumbering>();

            InvokeMethod = new InvokeMethod(typeof(ConfAutNumeringController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListAutomaticNumering" }
            }, typeof(AutomaticNumbering));

            InitializeComponent();

            DbTableId.ObjetoApp = new InvokeMethod(typeof(DbTableController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListDbTable" }
            }, typeof(DbTable));

            DbTableId.DisplayMember = "TableDescription";
            DbTableId.ValueMember = "Id";
            DbTableId.Caption = "Tabela";

            AfterSave += UpdateAutomaticNumering;
        }

        private void UpdateAutomaticNumering()
        {
            GlobalUser.AutomaticNumberings = AutomaticNumberingApp.Search().ToList();
        }
    }
}