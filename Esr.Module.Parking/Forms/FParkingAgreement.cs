using Esr.Core.Component;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.EnumBase;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.InitialRegistration.Forms.Persons;
using Esr.Module.Parking.Controllers;
using Esr.Module.Parking.Domain;
using System.Collections.Generic;

namespace Esr.Module.Parking.Forms
{
    public partial class FParkingAgreement : FForm
    {
        public FParkingAgreement()
        {
            Module = "Estacionamento";

            ObjectControl = new List<ParkingAgreement>();

            InvokeMethod = new InvokeMethod(typeof(ParkingAgreementController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListParkingAgreement" }
            }, typeof(ParkingAgreement));

            InitializeComponent();

            Situation.SetEnumItems<Situation>(Core.Domain.EnumBase.Situation.Active);

            LegalPersonId.DisplayMember = "PersonName";
            LegalPersonId.ValueMember = "Id";
            LegalPersonId.ObjetoApp = new InvokeMethod(typeof(LegalPersonController), TypeExecute.SearchAll, "ListLegalPerson", typeof(LegalPerson));
            LegalPersonId.FormType = typeof(FLegalPerson);

            ImageSource = Properties.Resources.Icon_Agreement;
        }
    }
}