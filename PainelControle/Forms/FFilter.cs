using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Queries;
using Filter = Esr.Core.Domain.Queries.Filter;
using Esr.Module.ControlPainel.Controllers;

namespace Esr.Module.ControlPainel.Forms
{
    public partial class FFilter : FForm
    {
        public FFilter()
        {
            InvokeMethod = new InvokeMethod(typeof(FilterController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListFilter" }
            }, typeof(Filter));

            ObjectControl = new List<Filter>();

            InitializeComponent();

            QueryId.ObjetoApp = new InvokeMethod(typeof(QueryController), TypeExecute.SearchAll, "ListQuery", typeof(Query));
            QueryId.DisplayMember = "Code";
            QueryId.ValueMember = "Id";
            QueryId.FormType = typeof(FQuery);

            TypeComponent.SetEnumItems<TypeFilterComponent>(TypeFilterComponent.TextBox);

            DefaultTypeFilter.SetEnumItems<TypeFilter>(TypeFilter.Equal);

            InactiveFilters.ObjetoApp = new InvokeMethod(typeof(InactiveFiltersController), TypeExecute.Search, "InactiveFiltersSearch", typeof(InactiveFilters)); 
            InactiveFilters.ScreenSecondary = true;
            InactiveFilters.IsDependecyUkey = true;
            InactiveFilters.FormType = typeof(FInactiveFilters);

            ImageSource = Properties.Resources.icon_filter;
        }
    }
}