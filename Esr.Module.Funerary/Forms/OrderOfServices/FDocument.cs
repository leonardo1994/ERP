using System;
using System.Collections.Generic;
using Esr.Core.Component;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.Funerary.Controllers;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.DependencyInjection;

namespace Esr.Module.Funerary.Forms.OrderOfServices
{
    public partial class FDocument : FForm
    {
        public FDocument()
        {
            Module = "Funerária";

            InvokeMethod = new InvokeMethod(typeof(OsDocumentController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListOsDocument" }
            }, typeof(OsDocument));

            ObjectControl = new List<OsDocument>();

            InitializeComponent();
            Archive.Disable = false;
            SelectedFile.OpenFileDialog = true;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            SelectedFile.NameFolder = new OsDocumentController(new RepositoryInjection().GetClass<IFactoryConnection>()).GetNumberOs(((OsDocument)CurrentControl).OrderOfServiceId);
            Archive.SComponent.Enabled = false;
            base.OnVisibleChanged(e);
        }
    }
}
