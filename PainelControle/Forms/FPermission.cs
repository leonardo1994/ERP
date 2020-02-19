using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.EnumBase;
using Esr.Module.ControlPainel.Controllers;

namespace Esr.Module.ControlPainel.Forms
{
    public partial class FPermission : FForm
    {
        public FPermission()
        {
            Module = "Painel de Controle";
            ObjectControl = new List<Permission>();

            InvokeMethod = new InvokeMethod(typeof(PermissionController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListPermission" }
            }, typeof(Permission));

            InitializeComponent();
            TypeComponent.SetEnumItems<TypeComponent>(Core.Domain.EnumBase.TypeComponent.Screen);
        }
    }
}
