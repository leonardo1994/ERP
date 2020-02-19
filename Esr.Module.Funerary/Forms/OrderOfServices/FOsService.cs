using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.InitialRegistration.Forms.Services;
using Esr.Module.InitialRegistration.Forms.Persons;
using Esr.Module.Funerary.Controllers;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.InitialRegistration.Domain.Services;
using Esr.Core.Domain.Authentication;

namespace Esr.Module.Funerary.Forms.OrderOfServices
{
    public partial class FOsService : FForm
    {
        public FOsService()
        {
            Module = "Funerária";

            InvokeMethod = new InvokeMethod(typeof(OsServiceController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListOsService" }
            }, typeof(OsService));

            ObjectControl = new List<OsService>();

            InitializeComponent();

            ServiceId.ValueMember = "Id";
            ServiceId.DisplayMember = "Description";
            ServiceId.ObjetoApp = new InvokeMethod(typeof(ServiceController), TypeExecute.SearchAll, "ListService", typeof(Service));
            ServiceId.FormType = typeof(FService);

            LegalPersonId.ValueMember = "Id";
            LegalPersonId.DisplayMember = "CorporateName";
            LegalPersonId.ObjetoApp = new InvokeMethod(typeof(LegalPersonController), TypeExecute.SearchAll, "ListLegalPerson", typeof(LegalPerson));
            LegalPersonId.FormType = typeof(FLegalPerson);
        }
    }
}
