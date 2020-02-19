using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Address;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.Address
{
    public partial class FCity : FForm
    {
        public FCity()
        {
            Module = "Cadastro Iniciais";

            ObjectControl = new List<City>();

            InvokeMethod = new InvokeMethod(typeof(CityController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListCity" }
            }, typeof(City));

            InitializeComponent();

            StateId.DisplayMember = "Initials";
            StateId.ValueMember = "Id";
            StateId.ObjetoApp = new InvokeMethod(typeof(StateController), TypeExecute.SearchAll, "ListState", typeof(State));
            StateId.FormType = typeof(FState);

            ImageSource = Properties.Resources.icon_city;
        }
    }
}
