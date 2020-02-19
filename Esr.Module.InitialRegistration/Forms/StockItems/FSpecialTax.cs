using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.TaxManagement.App.Taxations;
using Esr.Module.TaxManagement.Forms.Taxations;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.Stock.Controllers;
using Esr.Module.TaxManagement.Domain.Taxations;

namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    public partial class FSpecialTax : FForm
    {
        public FSpecialTax()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(SpecialTaxController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListSpecialTax" }
            }, typeof(SpecialTax));

            ObjectControl = new List<SpecialTax>();
            InitializeComponent();

            TaxationId.DisplayMember = "Initials";
            TaxationId.ValueMember = "Id";
            TaxationId.ObjetoApp = new InvokeMethod(typeof(TaxationController), TypeExecute.SearchAll, "ListTaxation", typeof(Taxation));
            TaxationId.FormType = typeof(FTaxation);
        }
    }
}