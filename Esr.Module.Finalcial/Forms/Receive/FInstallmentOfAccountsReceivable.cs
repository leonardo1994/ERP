using Esr.Core.Component;
using Esr.Module.Financial.Controllers.Receive;
using Esr.Module.Financial.Domain.Receive;
using System.Collections.Generic;

namespace Esr.Module.Financial.Forms.Receive
{
    public partial class FInstallmentOfAccountsReceivable : Esr.Core.Component.FForm
    {
        public FInstallmentOfAccountsReceivable()
        {
            Module = "Contas a Receber";

            InvokeMethod = new InvokeMethod(typeof(InstallmentOfAccountsReceivableController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListInstallmentOfAccountsReceivable" }
            }, typeof(InstallmentOfAccountsReceivable));

            ObjectControl = new List<InstallmentOfAccountsReceivable>();

            InitializeComponent();
        }
    }
}