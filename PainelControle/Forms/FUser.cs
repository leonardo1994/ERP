using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Authentication;
using Esr.Module.ControlPainel.Controllers;

namespace Esr.Module.ControlPainel.Forms
{
    public partial class FUser : FForm
    {
        public FUser()
        {
            Module = "Painel de Controle";

            ObjectControl = new List<User>();

            InvokeMethod = new InvokeMethod(typeof(UserController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListUser" }
            }, typeof(User));

            InitializeComponent();

            GroupUsers.ScreenSecondary = true;
            GroupUsers.ObjetoApp = new InvokeMethod(typeof(GroupUserController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "Remove" },
                { TypeExecute.RemoveListId, "Remove" },
                { TypeExecute.Search, "ListGroupUser" },
            }, typeof(GroupUser));
            GroupUsers.FormType = typeof(FGroupAccess);
            GroupUsers.IsDependecyUkey = false;
            GroupUsers.ScreenSecondary = true;
            GroupUsers.ValueControl = new List<GroupAccess>();
            GroupUsers.Caption = "Grupos de acesso";

            UsersCompanies.ScreenSecondary = true;
            UsersCompanies.ObjetoApp = new InvokeMethod(typeof(UserCompanyController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "Remove" },
                { TypeExecute.RemoveListId, "Remove" },
                { TypeExecute.Search, "CompaniesSearch" },
            }, typeof(UserCompany));
            UsersCompanies.FormType = typeof(FCompany);
            UsersCompanies.ValueControl = new List<UserCompany>();
            UsersCompanies.IsDependecyUkey = false;
            UsersCompanies.ScreenSecondary = true;
            UsersCompanies.Caption = "Empresas";
            UsersCompanies.SMenuComponent.MenuItemNew.Visible = false;
            UsersCompanies.SMenuComponent.MenuItemEdit.Visible = false;
        }
    }
}