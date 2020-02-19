using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Authentication;
using Esr.Module.InitialRegistration.Forms.Address;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.Persons
{
    public partial class FPersonAddress : FPublicPlace
    {
        public FPersonAddress()
            :base(new List<PersonAddress>(), new InvokeMethod(typeof(PersonAddressController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListLegalPerson" }
            }, typeof(PersonAddress)))
        {
            InitializeComponent();
        }
    }
}