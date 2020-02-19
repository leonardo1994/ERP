using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.Stock.Domain.Movements;
using Esr.Module.Stock.Controllers;
using Esr.Module.ControlPainel.Controllers;
using Esr.Core.Domain.Authentication;

namespace Esr.Module.Stock.Forms.InputsOutPuts
{
    public partial class FOutputStock : FForm
    {
        public FOutputStock()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(OutputStockController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListOutputStock" }
            }, typeof(OutputStock));

            ObjectControl = new List<OutputStock>();

            InitializeComponent();

            PersonId.DisplayMember = "PersonName";
            PersonId.ValueMember = "Id";
            PersonId.ObjetoApp = new InvokeMethod(typeof(PersonController), TypeExecute.SearchAll, "ListPerson", typeof(Person));

            ItemOutputStocks.FormType = typeof(FItemOutputStock);
            ItemOutputStocks.IsDependecyUkey = true;
            ItemOutputStocks.ScreenSecondary = true;
            ItemOutputStocks.ObjetoApp = new InvokeMethod(typeof(ItemOutputStockController), TypeExecute.Search, "ListItemOutputStock", typeof(ItemOutputStock));
            ItemOutputStocks.Caption = "Itens da saída de materiais";
        }
    }
}