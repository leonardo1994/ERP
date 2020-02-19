using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Authentication;
using Esr.Module.ControlPainel.Controllers;

namespace Esr.Module.ControlPainel.Forms
{
    public partial class FGroupAccess : FForm
    {
        public FGroupAccess()
        {
            Module = "Painel de Controle";
            ObjectControl = new List<GroupAccess>();

            InvokeMethod = new InvokeMethod(typeof(GroupAccessController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListGroupAccess" }
            }, typeof(GroupAccess));

            InitializeComponent();

            GroupPermissions.ScreenSecondary = true;
            GroupPermissions.ObjetoApp = new InvokeMethod(typeof(GroupPermissionController),
                new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "Remove" },
                { TypeExecute.RemoveListId, "Remove" },
                { TypeExecute.Search, "ListPermission" },
            }, typeof(GroupPermission));
            GroupPermissions.FormType = typeof(FPermission);
            GroupPermissions.IsDependecyUkey = false;
            GroupPermissions.ScreenSecondary = true;
            GroupPermissions.ValueControl = new List<Permission>();
            GroupPermissions.Caption = "Permissões";
        }
    }
}