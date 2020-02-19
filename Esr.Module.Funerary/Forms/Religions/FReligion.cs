using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.Funerary.Domain.Religions;
using Esr.Module.Funerary.Controllers;

namespace Esr.Module.Funerary.Forms.Religions
{
    public partial class FReligion : FForm
    {
        public FReligion()
        {
            Module = "Funerária";

            ObjectControl = new List<Religion>();

            InvokeMethod = new InvokeMethod(typeof(ReligionController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListReligion" }
            }, typeof(Religion));

            InitializeComponent();

            ImageSource = Properties.Resources.icon_religion;
        }
    }
}
