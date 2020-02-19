using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using Esr.Core.App.Authentication;
using Esr.Core.Component;
using Esr.Core.Domain.ValueObject;
using Esr.Module.Funerary.App.Contractors;
using Esr.Module.Funerary.App.DebitNotes;
using Esr.Module.Funerary.Domain.Contractors;
using Esr.Module.Funerary.Domain.DebitNotes;
using Esr.Module.Funerary.Forms.Contractors;
using Esr.Module.Funerary.Controllers;

namespace Esr.Module.Funerary.Forms.DebitNotes
{
    public partial class FDebitNotes : FForm
    {
        public override List<SReports> SReportses { get; set; } = new List<SReports>
        {
            new SReports
            {
                Nome = "Nota de débito",
                LocalPath = "NotaDebito.rdlc",
                DataSet = new Dictionary<string, SInvokeMethod>
                {
                    {
                        "DataSetDebitNote", new SInvokeMethod
                        {
                            NameMethod = "QueryNotaDebito",
                            TypeClass = typeof(DebitNotesController)
                        }
                    }
                }
            }
        };

        public FDebitNotes()
        {
            Module = "Funerária";
            ObjectControl = new List<DebitNote>();

            InvokeMethod = new InvokeMethod(typeof(DebitNotesController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListDebitNotes" }
            }, typeof(DebitNote));

            InitializeComponent();

            ContractorId.ObjetoApp = new InvokeMethod(typeof(ContractorController), TypeExecute.SearchAll, "ListContractorOfOrdemDebitNote", typeof(Contractor));
            ContractorId.FormType = typeof(FContractor);
            ContractorId.ValueMember = "Id";
            ContractorId.DisplayMember = "PersonName";

            NumberDebitNote.SComponent.Enabled = false;
        }

        public override bool Salvar()
        {
            if (!IsValid()) return false;
            try
            {
                var returnSave = base.Salvar();

                var msg = MessageBox.Show("Deseja imprimir a nota de débito " + ((DebitNote)CurrentControl).NumberDebitNote,
                    "ESR Softwares",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (msg != MessageBoxResult.Yes) return returnSave;
                var ribbonButton = this.ReportList()[0] as RibbonButton;
                MenuForm().ButtonBase_OnClick(ribbonButton, null);
                return returnSave;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro:", exception.Message);
                return false;
            }
        }
    }
}