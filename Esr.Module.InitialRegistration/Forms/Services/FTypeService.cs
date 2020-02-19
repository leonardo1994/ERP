using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.EnumBase;
using Esr.Module.InitialRegistration.App.Services;
using Esr.Module.InitialRegistration.Domain.Services;
using Esr.Module.InitialRegistration.Controllers;

namespace Esr.Module.InitialRegistration.Forms.Services
{
    public partial class FTypeService : FForm
    {
        public FTypeService()
        {
            Module = "Cadastros Iniciais";

            ObjectControl = new List<TypeService>();

            InvokeMethod = new InvokeMethod(typeof(TypeServiceController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListTypeService" }
            }, typeof(TypeService));

            InitializeComponent();

            TypeStructure.SetEnumItems<TypeStructure>(Core.Domain.EnumBase.TypeStructure.Sinthetic);

            TypeServices.FormType = typeof(FTypeService);
            TypeServices.ObjetoApp = new InvokeMethod(typeof(TypeServiceController), TypeExecute.Search, "Search", typeof(TypeService));
            TypeServices.ScreenSecondary = true;
            TypeServices.IsDependecyUkey = true;
            TypeServices.PropertyDependecyUkey = "TypeServiceMasterId";
            TypeServices.Caption = "Sub Tipos de Serviços";

            ImageSource = Properties.Resources.icon_typeService;
        }
    }
}
