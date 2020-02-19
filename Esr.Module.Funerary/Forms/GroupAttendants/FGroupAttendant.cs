using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.Funerary.Domain.GroupAttendants;
using Esr.Module.Funerary.Controllers;
using Esr.Module.ControlPainel.Forms;

namespace Esr.Module.Funerary.Forms.GroupAttendants
{
    public partial class FGroupAttendant : FForm
    {
        public FGroupAttendant()
        {
            Module = "Funerária";

            InvokeMethod = new InvokeMethod(typeof(GroupAttendantController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListGroupAttendant" }
            }, typeof(GroupAttendant));

            ObjectControl = new List<GroupAttendant>();

            InitializeComponent();

            Attendants.ObjetoApp = new InvokeMethod(typeof(AttendentController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListAttendent" }
            }, typeof(Attendant));
            Attendants.FormType = typeof(FUser);
            Attendants.ScreenSecondary = true;
            Attendants.IsDependecyUkey = false;
            Attendants.SMenuComponent.MenuItemEdit.Visible = false;
            Attendants.SMenuComponent.MenuItemNew.Visible = false;
        }
    }
}