using Esr.Core.Component;
using Esr.Module.Financial.Controllers.Financial;
using Esr.Module.Financial.Domain.Financial;
using Esr.Module.Financial.Enums;
using System.Collections.Generic;

namespace Esr.Module.Financial.Forms.Financial
{
    public partial class FTypeDocumentFinancial : FForm
    {
        public FTypeDocumentFinancial()
        {
            Module = "Financeiro";

            InvokeMethod = new InvokeMethod(typeof(TypeDocumentFinancialController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListTypeDocumentFinancial" }
            }, typeof(TypeDocumentFinancial));

            ObjectControl = new List<TypeDocumentFinancial>();

            InitializeComponent();

            Participation.SetEnumItems<Participation>(Enums.Participation.ToReceive);

            ImageSource = Properties.Resources.Icon_FinancialDocument;
        }
    }
}