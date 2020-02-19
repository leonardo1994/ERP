using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Queries;
using Esr.Module.ControlPainel.Controllers;

namespace Esr.Module.ControlPainel.Forms
{
    public partial class FQuery : FForm
    {
        public FQuery()
        {
            InvokeMethod = new InvokeMethod(typeof(QueryController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListQuery" }
            }, typeof(Query));

            ObjectControl = new List<Query>();

            InitializeComponent();

            Filters.ObjetoApp = new InvokeMethod(typeof(FilterController), TypeExecute.Search, "FiltersSearch", typeof(Filter));
            Filters.IsDependecyUkey = true;
            Filters.ScreenSecondary = true;
            Filters.FormType = typeof(FFilter);

            Reports.ObjetoApp = new InvokeMethod(typeof(ReportController), TypeExecute.Search, "ReportsSearch", typeof(Report));
            Reports.ScreenSecondary = true;
            Reports.IsDependecyUkey = true;
            Reports.FormType = typeof(FReport);

            Consults.ObjetoApp = new InvokeMethod(typeof(ConsultController), TypeExecute.Search, "ConsultSearch", typeof(Consult));
            Consults.ScreenSecondary = true;
            Consults.IsDependecyUkey = true;
            Consults.FormType = typeof(FConsult);

            ImageSource = Properties.Resources.icon_sql;

        }
    }
}