using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.InitialRegistration.Domain.Providers;
using Esr.Module.InitialRegistration.Forms.Persons;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.Providers
{
    public partial class FProvider : FLegalPerson
    {
        public FProvider()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(ProviderController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListProvider" }
            }, typeof(Provider));

            ObjectControl = new List<Provider>();

            InitializeComponent();

            ImageSource = Properties.Resources.icon_provider;
        }
    }
}
