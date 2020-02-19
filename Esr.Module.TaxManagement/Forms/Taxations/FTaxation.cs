using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.EnumBase;
using Esr.Module.TaxManagement.Domain.Taxations;
using Esr.Module.Stock.Controllers;

namespace Esr.Module.TaxManagement.Forms.Taxations
{
    public partial class FTaxation : FForm
    {
        public FTaxation()
        {
            Module = "Gestão Fiscal";

            InvokeMethod = new InvokeMethod(typeof(TaxationController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListTaxation" }
            }, typeof(Taxation));

            ObjectControl = new List<Taxation>();

            InitializeComponent();

            TaxesOnBooks.SetEnumItems<TaxesOnBooks>(Core.Domain.EnumBase.TaxesOnBooks.Icms);

            this.ImageSource = Properties.Resources.icon_taxation_fw;

        }
    }
}
