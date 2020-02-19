using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Core.Domain.Translation;
using Esr.Module.ControlPainel.Controllers;

namespace Esr.Module.ControlPainel.Forms
{
    public partial class FTranslate : FForm
    {
        public FTranslate()
        {
            Module = "Painel de Controle";

            ObjectControl = new List<Translate>();

            InvokeMethod = new InvokeMethod(typeof(TranslateController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListTranslate" }
            }, typeof(Translate));

            InitializeComponent();
        }
    }
}
