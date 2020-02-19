using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.EnumBase;
using Esr.Module.ControlPainel.Properties;
using Esr.Core.App.FiltersCompanies;
using System.Linq;
using Esr.Module.ControlPainel.Controllers;

namespace Esr.Module.ControlPainel.Forms
{
    public partial class FCompany : FForm
    {
        private readonly FilterCompanyApp _Filter;

        public FCompany()
        {
            Module = "Painel de Controle";

            ObjectControl = new List<Company>();

            InvokeMethod = new InvokeMethod(typeof(CompanyController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListCompany" }
            }, typeof(Company));

            InitializeComponent();

            TypeCompany.SetEnumItems<TypeCompany>(Core.Domain.EnumBase.TypeCompany.Matriz);
            ImageSource = Resources.img_bussines;
        }
    }
}
