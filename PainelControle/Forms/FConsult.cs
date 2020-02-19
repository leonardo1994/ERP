using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Queries;
using Esr.Module.ControlPainel.Controllers;

namespace Esr.Module.ControlPainel.Forms
{
    public partial class FConsult : FForm
    {
        public FConsult()
        {
            InvokeMethod = new InvokeMethod(typeof(ConsultController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListConsult" }
            }, typeof(Consult));

            ObjectControl = new List<Consult>();

            InitializeComponent();

            QueryId.ObjetoApp = new InvokeMethod(typeof(QueryController), TypeExecute.SearchAll, "ListQuery", typeof(Query));
            QueryId.DisplayMember = "Code";
            QueryId.ValueMember = "Id";
            QueryId.FormType = typeof(FQuery);

            ConsultForms.ObjetoApp = new InvokeMethod(typeof(ConsultFormController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "Remove" },
                { TypeExecute.RemoveListId, "Remove" },
                { TypeExecute.Search, "SearchConsult" }
            }, typeof(ConsultForm));
            ConsultForms.ScreenSecondary = true;
            ConsultForms.FormType = typeof(FTable);

            ImageSource = Properties.Resources.icon_query;
        }
    }
}