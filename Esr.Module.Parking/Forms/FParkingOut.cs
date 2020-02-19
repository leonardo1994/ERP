using Esr.Core.Component;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.DependencyInjection;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.InitialRegistration.Domain.Sales;
using Esr.Module.InitialRegistration.Forms.Sales;
using Esr.Module.Parking.Controllers;
using Esr.Module.Parking.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows;

namespace Esr.Module.Parking.Forms
{
    public partial class FParkingOut : FProcess
    {
        public FParkingOut()
        {
            Module = "Estacionamento";

            ObjectControl = new List<ParkingInOut>();

            InvokeMethod = new InvokeMethod(typeof(ParkingInOutController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "GerarSaida" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListParkingInOut" }
            }, typeof(ParkingInOut));

            InitializeComponent();

            ParkingAgreementId.DisplayMember = "Description";
            ParkingAgreementId.ValueMember = "Id";
            ParkingAgreementId.ObjetoApp = new InvokeMethod(typeof(ParkingAgreementController), TypeExecute.SearchAll, "ListParkingAgreement", typeof(ParkingAgreement));
            ParkingAgreementId.FormType = typeof(FParkingAgreement);

            FormOfPaymentId.DisplayMember = "Description";
            FormOfPaymentId.ValueMember = "Id";
            FormOfPaymentId.ObjetoApp = new InvokeMethod(typeof(FormOfPaymentController), TypeExecute.SearchAll, "ListFormOfPayment", typeof(FormOfPayment));
            FormOfPaymentId.FormType = typeof(FFormOfPayment);

            TicketNumber.DisabledAutomaticNumbering = true;
            TicketNumber.ObjetoApp = new InvokeMethod(typeof(ParkingInOutController), TypeExecute.Search, "FindByTicketNumber", typeof(ParkingInOut));
            TicketNumber.SComponent.ValueChanged += SComponent_ValueChanged;

            TotalValue.Enabled = false;

            DiscountValuePorcent.SComponent.ValueChanged += SComponent_ValueChanged1;
            DiscountValueReal.SComponent.ValueChanged += SComponent_ValueChanged2;
            ParkingAgreementId.SComponent.SelectedValueChanged += SComponent_SelectedValueChanged;
            FormOfPaymentId.SComponent.SelectedValueChanged += SComponent_SelectedValueChanged1;
            ChangeOfMoney.SComponent.ValueChanged += SComponent_ValueChanged3;
            AmountPaid.SComponent.ValueChanged += SComponent_ValueChanged4;
            TotalValue.SComponent.ValueChanged += SComponent_ValueChanged5;
            TotalPayable.SComponent.ValueChanged += SComponent_ValueChanged6;

            MaximizeBox = false;
        }

        private void SComponent_ValueChanged6(object sender, EventArgs e)
        {
            UpdateReport();
        }

        private void SComponent_ValueChanged5(object sender, EventArgs e)
        {
            UpdateReport();
        }

        private void SComponent_ValueChanged4(object sender, EventArgs e)
        {
            UpdateReport();
        }

        private void SComponent_ValueChanged3(object sender, EventArgs e)
        {
            UpdateReport();
        }

        private void SComponent_SelectedValueChanged1(object sender, EventArgs e)
        {
            UpdateReport();
        }

        private void SComponent_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateReport();
        }

        private void SComponent_ValueChanged2(object sender, EventArgs e)
        {
            var value = ((NumericUpDown)sender).Value;

            if (value > decimal.Zero)
            {
                DiscountValuePorcent.ValueControl = 0;
                DiscountValuePorcent.Enabled = false;
            }else
            {
                DiscountValuePorcent.Enabled = true;
            }
            UpdateReport();
        }

        private void SComponent_ValueChanged1(object sender, EventArgs e)
        {
            var value = ((NumericUpDown)sender).Value;

            if (value > decimal.Zero)
            {
                DiscountValueReal.ValueControl = 0;
                DiscountValueReal.Enabled = false;
            }else
            {
                DiscountValueReal.Enabled = true;
            }
            UpdateReport();
        }

        private void SComponent_ValueChanged(object sender, EventArgs e)
        {
            if(TicketNumber.ObjectControl != null)
            {
                CurrentControl = TicketNumber.ObjectControl as IEntityBase;
                RefreshControls();
                TicketNumber.SComponent.BackColor = System.Drawing.Color.LightGreen;
                UpdateReport();
            }
            else
            {
                var value = ((NumericUpDown)sender).Value;

                CurrentControl = new ParkingInOut()
                {
                    TicketNumber = value
                };

                RefreshControls();
                TicketNumber.SComponent.BackColor = System.Drawing.Color.LightCoral;
                TicketNumber.SetError("Registro não encontrado", -40);
                TicketNumber.SetFocus();
            }
        }

        private void FParkingOut_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }

        private void UpdateReport()
        {
            var ri = new RepositoryInjection();
            var _conn = ri.GetClass<IFactoryConnection>();
            var pioc = new ParkingInOutController(_conn);
            if (CurrentControl != null)
            {
                var r = pioc.ListForReport(CurrentControl.Id);
                foreach (var item in r)
                {
                    item.Convenio = ParkingAgreementId.SComponent.Text;
                    item.Desconto = (decimal)DiscountValuePorcent.ValueControl == decimal.Zero ? (decimal)DiscountValueReal.ValueControl : (decimal)DiscountValuePorcent.ValueControl;
                    item.FormaPagamento = FormOfPaymentId.SComponent.Text;
                    item.Troco = (decimal)ChangeOfMoney.ValueControl;
                    item.ValorPago = (decimal)AmountPaid.ValueControl;
                    item.ValorTotal = (decimal)TotalValue.ValueControl;
                    item.ValorTotalaPagar = (decimal)TotalPayable.ValueControl;
                    item.DataFinal = DateTime.Now;
                }

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetTicket", r));
                reportViewer1.RefreshReport();
            }
        }

        public override void ButtonActive_Click(object sender, RoutedEventArgs e)
        {
            base.ButtonActive_Click(sender, e);
            if (IsValid())
            {
                reportViewer1.PrintDialog();
                CurrentControl = new ParkingInOut();
                RefreshControls();
            }
        }
    }
}