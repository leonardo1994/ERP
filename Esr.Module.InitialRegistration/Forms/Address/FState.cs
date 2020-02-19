using System.Collections.Generic;
using Esr.Core.App.Address;
using Esr.Core.Component;
using Esr.Core.Domain.Address;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.Address
{
    public partial class FState : FForm
    {
        public FState()
        {
            Module = "Cadastro Iniciais";

            ObjectControl = new List<State>();

            InvokeMethod = new InvokeMethod(typeof(StateController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListState" }
            }, typeof(State));

            InitializeComponent();

            CountryId.ValueMember = "Id";
            CountryId.DisplayMember = "Initials";
            CountryId.ObjetoApp = new InvokeMethod(typeof(CountryController), TypeExecute.SearchAll, "ListCountry", typeof(Country));
            CountryId.FormType = typeof(FCountry);

            ImageSource = Properties.Resources.icon_state;
        }
    }
}
