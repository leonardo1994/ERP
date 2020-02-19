using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.Stock.Domain.Movements;
using Esr.Module.Stock.Controllers;
using Esr.Module.ControlPainel.Controllers;
using Esr.Core.Domain.Authentication;

namespace Esr.Module.Stock.Forms.InputsOutPuts
{
    public partial class FInputStock : FForm
    {
        public FInputStock()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(InputStockController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListInputStock" }
            }, typeof(InputStock));

            ObjectControl = new List<InputStock>();

            InitializeComponent();

            ProviderId.DisplayMember = "PersonName";
            ProviderId.ValueMember = "Id";
            ProviderId.ObjetoApp = new InvokeMethod(typeof(PersonController), TypeExecute.SearchAll, "ListPerson", typeof(Person));

            ItemInputStocks.FormType = typeof(FItemInputStock);
            ItemInputStocks.IsDependecyUkey = true;
            ItemInputStocks.ScreenSecondary = true;
            ItemInputStocks.ObjetoApp = new InvokeMethod(typeof(ItemInputStockController), TypeExecute.Search, "Search", typeof(ItemInputStock));
            ItemInputStocks.Caption = "Itens da entrada de materiais";
        }
    }
}