using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.InitialRegistration.Domain.Colors;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.Colors
{
    public partial class FColor : FForm
    {
        public FColor()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(ColorController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListColor" }
            }, typeof(Color));

            ObjectControl = new List<Color>();

            InitializeComponent();

            ImageSource = Properties.Resources.icon_color;
        }
    }
}
