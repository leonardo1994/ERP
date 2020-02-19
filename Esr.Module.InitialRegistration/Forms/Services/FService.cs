using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.EnumBase;
using Esr.Module.InitialRegistration.Domain.Services;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.Services
{
    public partial class FService : FForm
    {
        public FService()
        {
            Module = "Cadastros Iniciais";

            InvokeMethod = new InvokeMethod(typeof(ServiceController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListService" }
            }, typeof(Service));

            ObjectControl = new List<Service>();

            InitializeComponent();

            TypeServiceId.ValueMember = "Id";
            TypeServiceId.DisplayMember = "Description";
            TypeServiceId.ObjetoApp = new InvokeMethod(typeof(TypeServiceController), TypeExecute.SearchAll, "ListTypeService", typeof(TypeService));
            TypeServiceId.FormType = typeof(FTypeService);

            TypeValueCommission.SetEnumItems<TypeValue>(TypeValue.Porcent);

            TypeValueProfit.SetEnumItems<TypeValue>(TypeValue.Porcent);

            ImageSource = Properties.Resources.icon_service;
        }
    }
}
