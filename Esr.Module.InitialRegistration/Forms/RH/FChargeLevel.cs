using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.RH
{
    public partial class FChargeLevel : FForm
    {
        public FChargeLevel()
        {
            InvokeMethod = new InvokeMethod(typeof(ChargeLevelController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListChargeLevel" }
            }, typeof(ChargeLevel));

            ObjectControl = new List<ChargeLevel>();

            InitializeComponent();
        }
    }
}
