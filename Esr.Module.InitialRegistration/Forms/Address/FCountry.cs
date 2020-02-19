using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Address;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.Address
{
    public partial class FCountry : FForm
    {
        public FCountry()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(CountryController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListCountry" }
            }, typeof(Country));

            ObjectControl = new List<Country>();

            InitializeComponent();

            ImageSource = Properties.Resources.icon_country;
        }
    }
}
