using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.Funerary.Forms.Contractors;
using Esr.Module.InitialRegistration.Forms.Services;
using Esr.Module.Funerary.Controllers;
using Esr.Module.Funerary.Domain.Contractors;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.InitialRegistration.Domain.Services;

namespace Esr.Module.Funerary.Forms.OrderOfServices
{
    public partial class FOscontractorService : FForm
    {
        public FOscontractorService()
        {
            Module = "Funerária";

            InvokeMethod = new InvokeMethod(typeof(OsContractorServiceController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListOsContractorService" }
            }, typeof(OsContractorService));

            ObjectControl = new List<OsContractorService>();

            InitializeComponent();

            ContractorId.DisplayMember = "PersonName";
            ContractorId.ValueMember = "Id";
            ContractorId.ObjetoApp = new InvokeMethod(typeof(ContractorController), TypeExecute.SearchAll, "ListContractor", typeof(Contractor));
            ContractorId.FormType = typeof(FContractor);
            ContractorId.Caption = "Contratada";

            ServiceId.ValueMember = "Id";
            ServiceId.DisplayMember = "Description";
            ServiceId.ObjetoApp = new InvokeMethod(typeof(ServiceController), TypeExecute.SearchAll, "ListService", typeof(Service));
            ServiceId.FormType = typeof(FService);
        }
    }
}
