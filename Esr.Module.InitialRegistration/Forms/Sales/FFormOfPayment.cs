using Esr.Core.Component;
using Esr.Core.Domain.EnumBase;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.InitialRegistration.Domain.Sales;
using System.Collections.Generic;

namespace Esr.Module.InitialRegistration.Forms.Sales
{
    public partial class FFormOfPayment : FForm
    {
        public FFormOfPayment()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(FormOfPaymentController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListFormOfPayment" }
            }, typeof(FormOfPayment));

            ObjectControl = new List<FormOfPayment>();

            InitializeComponent(); 

           TypePaymant.SetEnumItems<TypePaymant>(Domain.Sales.TypePaymant.Card);

            ImageSource = Properties.Resources.Icon_FormOfPayment;
        }
    }
}
