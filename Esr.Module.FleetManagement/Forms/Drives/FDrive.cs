using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.FleetManagement.Domain.Drives;
using Esr.Module.FleetManagement.Controllers;

namespace Esr.Module.FleetManagement.Forms.Drives
{
    public partial class FDrive : FForm
    {
        public FDrive()
        {
            Module = "Gestão de Frotas";

            InvokeMethod = new InvokeMethod(typeof(DriveController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListDrive" }
            }, typeof(Drive));

            ObjectControl = new List<Drive>();

            InitializeComponent();

            ImageSource = Properties.Resources.icon_motorist;
        }
    }
}