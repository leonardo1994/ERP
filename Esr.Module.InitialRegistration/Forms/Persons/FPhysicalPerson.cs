using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Authentication;
using Esr.Module.InitialRegistration.Forms.Address;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Core.Domain.Address;
using Esr.Module.InitialRegistration.Domain.Persons;

namespace Esr.Module.InitialRegistration.Forms.Persons
{
    public partial class FPhysicalPerson : FForm
    {
        public FPhysicalPerson()
        {
            Module = "Cadastros Iniciais";

            ObjectControl = new List<PhysicalPerson>();

            InvokeMethod = new InvokeMethod(typeof(PhysicalPersonController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListPhysicalPerson" }
            }, typeof(PhysicalPerson));

            InitializeComponent();

            ImageSource = Properties.Resources.icon_legalPerson;

            PersonAddresses.ObjetoApp = new InvokeMethod(typeof(PersonAddressController), TypeExecute.Search, "Search", typeof(PersonAddress));
            PersonAddresses.IsDependecyUkey = true;
            PersonAddresses.ScreenSecondary = true;
            PersonAddresses.FormType = typeof(FPersonAddress);
            PersonAddresses.PropertyDependecyUkey = "PersonId";

            CountryId.ObjetoApp = new InvokeMethod(typeof(CountryController), TypeExecute.SearchAll, "ListCountry", typeof(Country));
            CountryId.DisplayMember = "Initials";
            CountryId.ValueMember = "Id";
            CountryId.FormType = typeof(FCountry);

            StateId.ObjetoApp = new InvokeMethod(typeof(StateController), TypeExecute.Search, "ListState", typeof(State));
            StateId.DisplayMember = "Initials";
            StateId.ValueMember = "Id";
            StateId.FormType = typeof(FState);

            CityId.ObjetoApp = new InvokeMethod(typeof(CityController), TypeExecute.Search, "ListCity", typeof(City));
            CityId.DisplayMember = "CityName";
            CityId.ValueMember = "Id";
            CityId.FormType = typeof(FCity);
        }
    }
}