using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Queries;
using Esr.Module.ControlPainel.Controllers;

namespace Esr.Module.ControlPainel.Forms
{
    public partial class FReport : FForm
    {
        public FReport()
        {
            InvokeMethod = new InvokeMethod(typeof(ReportController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListReport" }
            }, typeof(Report));

            ObjectControl = new List<Report>();

            InitializeComponent();

            QueryId.ObjetoApp = new InvokeMethod(typeof(QueryController), TypeExecute.SearchAll, "ListQuery", typeof(Query));
            QueryId.DisplayMember = "Code";
            QueryId.ValueMember = "Id";
            QueryId.FormType = typeof(FQuery);

            ReportForms.ObjetoApp = new InvokeMethod(typeof(ReportFormController), new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.InsertOrUpdate, "Save" },
                    { TypeExecute.Search, "ReportSearch" },
                }, typeof(ReportForm));
            ReportForms.ScreenSecondary = true;
            ReportForms.FormType = typeof(FTable);
        }
    }
}