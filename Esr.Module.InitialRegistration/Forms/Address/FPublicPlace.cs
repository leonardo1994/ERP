using System.Collections.Generic;
using Esr.Core.App.Address;
using Esr.Core.Component;
using Esr.Core.Domain.Address;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.Address
{
    public partial class FPublicPlace : FForm
    {
        public FPublicPlace(object objectControl, InvokeMethod sInvokeMethod)
        {
            InvokeMethod = sInvokeMethod;
            ObjectControl = objectControl;
            InstaceComponents();
        }

        public FPublicPlace()
        {
            InvokeMethod = new InvokeMethod(typeof(PublicPlaceController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListPublicPlace" }
            }, typeof(PublicPlace));

            ObjectControl = new List<PublicPlace>();
            InstaceComponents();
        }

        private void InstaceComponents()
        {
            InitializeComponent();

            CountryId.ObjetoApp = new InvokeMethod(typeof(CountryController), TypeExecute.SearchAll, "ListCountry", typeof(Country));
            CountryId.DisplayMember = "Initials";
            CountryId.ValueMember = "Id";
            CountryId.FormType = typeof(FCountry);

            StateId.ObjetoApp = new InvokeMethod(typeof(StateController), TypeExecute.Search, "Search", typeof(State));
            StateId.DisplayMember = "Initials";
            StateId.ValueMember = "Id";
            StateId.FormType = typeof(FState);

            CityId.ObjetoApp = new InvokeMethod(typeof(CityController), TypeExecute.Search, "Search", typeof(City));
            CityId.DisplayMember = "CityName";
            CityId.ValueMember = "Id";
            CityId.FormType = typeof(FCity);
        }
    }
}
