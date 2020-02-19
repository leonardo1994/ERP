using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.Funerary.Domain.Contractors;
using Esr.Module.InitialRegistration.Forms.Persons;
using Esr.Module.Funerary.Controllers;

namespace Esr.Module.Funerary.Forms.Contractors
{
    public partial class FContractor : FLegalPerson
    {
        public FContractor()
        {
            Module = "Funerária";
            ObjectControl = new List<Contractor>();

            InvokeMethod = new InvokeMethod(typeof(ContractorController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListContractor" }
            }, typeof(Contractor));

            InitializeComponent();
            ImageSource = Properties.Resources.icon_contracor;
        }
    }
}