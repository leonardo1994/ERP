using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.RH
{
    public partial class FNaturePositionFunction : FForm
    {
        public FNaturePositionFunction()
        {
            InvokeMethod = new InvokeMethod(typeof(NaturePositionFunctionController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListNaturePositionFunction" }
            }, typeof(NaturePositionFunction));

            ObjectControl = new List<NaturePositionFunction>();

            InitializeComponent();

            ImageSource = Properties.Resources.icon_nature_cf;
        }
    }
}
