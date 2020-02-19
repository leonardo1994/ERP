using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.Funerary.Forms.Contractors;
using Esr.Module.InitialRegistration.Forms.StockItems;
using Esr.Module.Funerary.Controllers;
using Esr.Module.Funerary.Domain.Contractors;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.InitialRegistration.Domain.StockItems;

namespace Esr.Module.Funerary.Forms.OrderOfServices
{
    public partial class FOsContractorProduct : FForm
    {
        public FOsContractorProduct()
        {
            Module = "Funerária";

            InvokeMethod = new InvokeMethod(typeof(OsContractorProductController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListContractor" }
            }, typeof(OsContractorProduct));

            ObjectControl = new List<OsContractorProduct>();

            InitializeComponent();

            ContractorId.DisplayMember = "PersonName";
            ContractorId.ValueMember = "Id";
            ContractorId.ObjetoApp = new InvokeMethod(typeof(ContractorController), TypeExecute.SearchAll, "ListContractor", typeof(Contractor));
            ContractorId.FormType = typeof(FContractor);

            StockItemId.ValueMember = "Id";
            StockItemId.DisplayMember = "Description";
            StockItemId.ObjetoApp = new InvokeMethod(typeof(StockItemController), TypeExecute.SearchAll, "ListStockItem", typeof(StockItem));
            StockItemId.FormType = typeof(FStockItem);

            UnitMeasureId.DisplayMember = "Initials";
            UnitMeasureId.ValueMember = "Id";
            UnitMeasureId.ObjetoApp = new InvokeMethod(typeof(UnitMeasureController), TypeExecute.SearchAll, "ListUnitMeasure", typeof(UnitMeasure));
            UnitMeasureId.FormType = typeof(FUnitMeasure);
        }
    }
}
