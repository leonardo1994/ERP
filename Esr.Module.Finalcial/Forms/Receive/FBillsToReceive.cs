using Esr.Core.Component;
using Esr.Core.Domain.Authentication;
using Esr.Module.ControlPainel.Controllers;
using Esr.Module.Financial.Controllers.Financial;
using Esr.Module.Financial.Controllers.Receive;
using Esr.Module.Financial.Domain.Financial;
using Esr.Module.Financial.Domain.Receive;
using Esr.Module.Financial.Forms.Financial;
using System;
using System.Collections.Generic;

namespace Esr.Module.Financial.Forms.Receive
{
    public partial class FBillsToReceive : FForm
    {
        public FBillsToReceive()
        {
            Module = "Contas a Receber";

            InvokeMethod = new InvokeMethod(typeof(BillsToReceiveController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListBillsToReceive" }
            }, typeof(BillsToReceive));

            ObjectControl = new List<BillsToReceive>();

            InitializeComponent();

            PersonId.DisplayMember = "PersonName";
            PersonId.ValueMember = "Id";
            PersonId.ObjetoApp = new InvokeMethod(typeof(PersonController), TypeExecute.SearchAll, "ListPerson", typeof(Person));

            TypeDocumentFinancialId.ObjetoApp = new InvokeMethod(typeof(TypeDocumentFinancialController), TypeExecute.SearchAll, "ListTypeDocumentFinancial", typeof(TypeDocumentFinancial));
            TypeDocumentFinancialId.FormType = typeof(FTypeDocumentFinancial);
            TypeDocumentFinancialId.ValueMember = "Id";
            TypeDocumentFinancialId.DisplayMember = "GetCodeDescription";

            InstallmentsOfAccountsReceivable.ObjetoApp = new InvokeMethod(typeof(InstallmentOfAccountsReceivableController), TypeExecute.Search, "Search", typeof(InstallmentOfAccountsReceivable));
            InstallmentsOfAccountsReceivable.FormType = typeof(FInstallmentOfAccountsReceivable);
            InstallmentsOfAccountsReceivable.ScreenSecondary = true;
            InstallmentsOfAccountsReceivable.IsDependecyUkey = true;

            ImageSource = Properties.Resources.Icon_BillsReceive;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var colPlotValue = InstallmentsOfAccountsReceivable.SComponent.Columns["PlotValue"];

            if (colPlotValue != null)
                colPlotValue.DefaultCellStyle.Format = "C2";
        }
    }
}