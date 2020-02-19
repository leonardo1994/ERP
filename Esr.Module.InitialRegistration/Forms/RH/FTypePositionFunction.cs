using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.RH
{
    public partial class FTypePositionFunction : FForm
    {
        public FTypePositionFunction()
        {

            InvokeMethod = new InvokeMethod(typeof(TypePositionFunctionController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListTypePositionFunction" }
            }, typeof(TypePositionFunction));

            ObjectControl = new List<TypePositionFunction>();

            InitializeComponent();

            ImageSource = Properties.Resources.Office_32;
        }
    }
}
