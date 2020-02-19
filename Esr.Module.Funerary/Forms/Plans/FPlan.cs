using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.Funerary.App.Plans;
using Esr.Module.Funerary.Domain.Plans;
using Esr.Module.Funerary.Controllers;

namespace Esr.Module.Funerary.Forms.Plans
{
    public partial class FPlan : FForm
    {
        public FPlan()
        {
            Module = "Funerária";

            ObjectControl = new List<Plan>();

            InvokeMethod = new InvokeMethod(typeof(PlanController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListPlan" }
            }, typeof(Plan));

            InitializeComponent();

            ImageSource = Properties.Resources.icon_plan;
        }
    }
}
