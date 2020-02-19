using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.RH
{
    public partial class FFunction : FForm
    {
        public FFunction()
        {
            ObjectControl = new List<Function>();

            InvokeMethod = new InvokeMethod(typeof(FunctionController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListFunction" }
            }, typeof(Function));

            InitializeComponent();

            CboId.DisplayMember = "CboDescription";
            CboId.ValueMember = "Id";
            CboId.ObjetoApp = new InvokeMethod(typeof(CboController), TypeExecute.SearchAll, "ListCbo", typeof(Cbo));

            TypePositionFunctionId.DisplayMember = "TypeOfficeFunctionDescription";
            TypePositionFunctionId.ValueMember = "Id";
            TypePositionFunctionId.ObjetoApp = new InvokeMethod(typeof(TypePositionFunctionController), TypeExecute.SearchAll, "ListTypePositionFunction", typeof(TypePositionFunction));
            TypePositionFunctionId.FormType = typeof(FTypePositionFunction);

            NaturePositionFunctionId.DisplayMember = "NaturePositionFunctionDescription";
            NaturePositionFunctionId.ValueMember = "Id";
            NaturePositionFunctionId.ObjetoApp = new InvokeMethod(typeof(NaturePositionFunctionController), TypeExecute.SearchAll, "ListNaturePositionFunction", typeof(NaturePositionFunction));
            NaturePositionFunctionId.FormType = typeof(FNaturePositionFunction);

            ImageSource = Properties.Resources.icon_schoolbag;
        }
    }
}
