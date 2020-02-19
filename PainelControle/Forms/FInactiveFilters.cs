using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Queries;
using Esr.Module.ControlPainel.Controllers;

namespace Esr.Module.ControlPainel.Forms
{
    public partial class FInactiveFilters : FForm
    {
        public FInactiveFilters()
        {
            InvokeMethod = new InvokeMethod(typeof(InactiveFiltersController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListInactiveFilters" }
            }, typeof(InactiveFilters));

            ObjectControl = new List<InactiveFilters>();

            InitializeComponent();

            TypeFilter.SetEnumItems<TypeFilter>(Core.Domain.Queries.TypeFilter.Equal);
        }
    }
}
