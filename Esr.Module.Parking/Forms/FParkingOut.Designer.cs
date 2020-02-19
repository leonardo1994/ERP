namespace Esr.Module.Parking.Forms
{
    partial class FParkingOut
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FParkingOut));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TicketViewBindingSource = new System.Windows.Forms.BindingSource();
            this.TicketNumber = new Esr.Core.Component.SNumeric();
            this.AmountPaid = new Esr.Core.Component.SNumeric();
            this.DiscountValueReal = new Esr.Core.Component.SNumeric();
            this.ChangeOfMoney = new Esr.Core.Component.SNumeric();
            this.DiscountValuePorcent = new Esr.Core.Component.SNumeric();
            this.TotalValue = new Esr.Core.Component.SNumeric();
            this.TotalPayable = new Esr.Core.Component.SNumeric();
            this.ParkingAgreementId = new Esr.Core.Component.SComboBox();
            this.FormOfPaymentId = new Esr.Core.Component.SComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FormOfPaymentId);
            this.panel1.Controls.Add(this.ParkingAgreementId);
            this.panel1.Controls.Add(this.TotalPayable);
            this.panel1.Controls.Add(this.TotalValue);
            this.panel1.Controls.Add(this.DiscountValuePorcent);
            this.panel1.Controls.Add(this.ChangeOfMoney);
            this.panel1.Controls.Add(this.DiscountValueReal);
            this.panel1.Controls.Add(this.AmountPaid);
            this.panel1.Controls.Add(this.TicketNumber);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Size = new System.Drawing.Size(706, 307);
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Yellow;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            reportDataSource1.Name = "DataSetTicket";
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Esr.Module.Parking.Reports.Ticket.RTicket.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowPageNavigationControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowPrintButton = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(354, 307);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // TicketNumber
            // 
            this.TicketNumber.Caption = "";
            this.TicketNumber.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TicketNumber.CenterCaption = false;
            this.TicketNumber.ComponentBackColor = System.Drawing.Color.White;
            this.TicketNumber.DecimalPlaces = 0;
            this.TicketNumber.Disable = true;
            this.TicketNumber.DisabledAutomaticNumbering = false;
            this.TicketNumber.FieldValid = true;
            this.TicketNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TicketNumber.Form = null;
            this.TicketNumber.FormType = null;
            this.TicketNumber.IsDependecyUkey = false;
            this.TicketNumber.Location = new System.Drawing.Point(361, 7);
            this.TicketNumber.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.TicketNumber.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TicketNumber.Name = "TicketNumber";
            this.TicketNumber.ObjectControl = null;
            this.TicketNumber.ObjetoApp = null;
            this.TicketNumber.Others = null;
            this.TicketNumber.PropertyControl = null;
            this.TicketNumber.PropertyDependecyUkey = null;
            this.TicketNumber.Size = new System.Drawing.Size(338, 55);
            this.TicketNumber.TabIndex = 0;
            this.TicketNumber.TabStop = false;
            this.TicketNumber.Text = "sNumeric1";
            this.TicketNumber.ThousandsSeparator = false;
            this.TicketNumber.ToolTipContext = null;
            this.TicketNumber.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TicketNumber.Validations")));
            this.TicketNumber.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // AmountPaid
            // 
            this.AmountPaid.Caption = "";
            this.AmountPaid.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.AmountPaid.CenterCaption = false;
            this.AmountPaid.ComponentBackColor = System.Drawing.Color.White;
            this.AmountPaid.DecimalPlaces = 2;
            this.AmountPaid.Disable = true;
            this.AmountPaid.DisabledAutomaticNumbering = false;
            this.AmountPaid.FieldValid = true;
            this.AmountPaid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AmountPaid.Form = null;
            this.AmountPaid.FormType = null;
            this.AmountPaid.IsDependecyUkey = false;
            this.AmountPaid.Location = new System.Drawing.Point(590, 188);
            this.AmountPaid.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.AmountPaid.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AmountPaid.Name = "AmountPaid";
            this.AmountPaid.ObjectControl = null;
            this.AmountPaid.ObjetoApp = null;
            this.AmountPaid.Others = null;
            this.AmountPaid.PropertyControl = null;
            this.AmountPaid.PropertyDependecyUkey = null;
            this.AmountPaid.Size = new System.Drawing.Size(109, 55);
            this.AmountPaid.TabIndex = 5;
            this.AmountPaid.TabStop = false;
            this.AmountPaid.Text = "sNumeric1";
            this.AmountPaid.ThousandsSeparator = true;
            this.AmountPaid.ToolTipContext = null;
            this.AmountPaid.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("AmountPaid.Validations")));
            this.AmountPaid.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // DiscountValueReal
            // 
            this.DiscountValueReal.Caption = "";
            this.DiscountValueReal.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DiscountValueReal.CenterCaption = false;
            this.DiscountValueReal.ComponentBackColor = System.Drawing.Color.White;
            this.DiscountValueReal.DecimalPlaces = 2;
            this.DiscountValueReal.Disable = true;
            this.DiscountValueReal.DisabledAutomaticNumbering = false;
            this.DiscountValueReal.FieldValid = true;
            this.DiscountValueReal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DiscountValueReal.Form = null;
            this.DiscountValueReal.FormType = null;
            this.DiscountValueReal.IsDependecyUkey = false;
            this.DiscountValueReal.Location = new System.Drawing.Point(361, 188);
            this.DiscountValueReal.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.DiscountValueReal.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.DiscountValueReal.Name = "DiscountValueReal";
            this.DiscountValueReal.ObjectControl = null;
            this.DiscountValueReal.ObjetoApp = null;
            this.DiscountValueReal.Others = null;
            this.DiscountValueReal.PropertyControl = null;
            this.DiscountValueReal.PropertyDependecyUkey = null;
            this.DiscountValueReal.Size = new System.Drawing.Size(109, 55);
            this.DiscountValueReal.TabIndex = 3;
            this.DiscountValueReal.TabStop = false;
            this.DiscountValueReal.Text = "sNumeric1";
            this.DiscountValueReal.ThousandsSeparator = true;
            this.DiscountValueReal.ToolTipContext = null;
            this.DiscountValueReal.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("DiscountValueReal.Validations")));
            this.DiscountValueReal.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // ChangeOfMoney
            // 
            this.ChangeOfMoney.Caption = "";
            this.ChangeOfMoney.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ChangeOfMoney.CenterCaption = false;
            this.ChangeOfMoney.ComponentBackColor = System.Drawing.Color.White;
            this.ChangeOfMoney.DecimalPlaces = 2;
            this.ChangeOfMoney.Disable = true;
            this.ChangeOfMoney.DisabledAutomaticNumbering = false;
            this.ChangeOfMoney.FieldValid = true;
            this.ChangeOfMoney.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ChangeOfMoney.Form = null;
            this.ChangeOfMoney.FormType = null;
            this.ChangeOfMoney.IsDependecyUkey = false;
            this.ChangeOfMoney.Location = new System.Drawing.Point(590, 249);
            this.ChangeOfMoney.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ChangeOfMoney.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ChangeOfMoney.Name = "ChangeOfMoney";
            this.ChangeOfMoney.ObjectControl = null;
            this.ChangeOfMoney.ObjetoApp = null;
            this.ChangeOfMoney.Others = null;
            this.ChangeOfMoney.PropertyControl = null;
            this.ChangeOfMoney.PropertyDependecyUkey = null;
            this.ChangeOfMoney.Size = new System.Drawing.Size(109, 55);
            this.ChangeOfMoney.TabIndex = 8;
            this.ChangeOfMoney.TabStop = false;
            this.ChangeOfMoney.Text = "sNumeric1";
            this.ChangeOfMoney.ThousandsSeparator = true;
            this.ChangeOfMoney.ToolTipContext = null;
            this.ChangeOfMoney.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ChangeOfMoney.Validations")));
            this.ChangeOfMoney.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // DiscountValuePorcent
            // 
            this.DiscountValuePorcent.Caption = "";
            this.DiscountValuePorcent.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DiscountValuePorcent.CenterCaption = false;
            this.DiscountValuePorcent.ComponentBackColor = System.Drawing.Color.White;
            this.DiscountValuePorcent.DecimalPlaces = 2;
            this.DiscountValuePorcent.Disable = true;
            this.DiscountValuePorcent.DisabledAutomaticNumbering = false;
            this.DiscountValuePorcent.FieldValid = true;
            this.DiscountValuePorcent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DiscountValuePorcent.Form = null;
            this.DiscountValuePorcent.FormType = null;
            this.DiscountValuePorcent.IsDependecyUkey = false;
            this.DiscountValuePorcent.Location = new System.Drawing.Point(476, 188);
            this.DiscountValuePorcent.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.DiscountValuePorcent.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.DiscountValuePorcent.Name = "DiscountValuePorcent";
            this.DiscountValuePorcent.ObjectControl = null;
            this.DiscountValuePorcent.ObjetoApp = null;
            this.DiscountValuePorcent.Others = null;
            this.DiscountValuePorcent.PropertyControl = null;
            this.DiscountValuePorcent.PropertyDependecyUkey = null;
            this.DiscountValuePorcent.Size = new System.Drawing.Size(108, 55);
            this.DiscountValuePorcent.TabIndex = 4;
            this.DiscountValuePorcent.TabStop = false;
            this.DiscountValuePorcent.Text = "sNumeric1";
            this.DiscountValuePorcent.ThousandsSeparator = true;
            this.DiscountValuePorcent.ToolTipContext = null;
            this.DiscountValuePorcent.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("DiscountValuePorcent.Validations")));
            this.DiscountValuePorcent.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TotalValue
            // 
            this.TotalValue.Caption = "";
            this.TotalValue.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TotalValue.CenterCaption = false;
            this.TotalValue.ComponentBackColor = System.Drawing.Color.White;
            this.TotalValue.DecimalPlaces = 2;
            this.TotalValue.Disable = true;
            this.TotalValue.DisabledAutomaticNumbering = false;
            this.TotalValue.FieldValid = true;
            this.TotalValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TotalValue.Form = null;
            this.TotalValue.FormType = null;
            this.TotalValue.IsDependecyUkey = false;
            this.TotalValue.Location = new System.Drawing.Point(360, 249);
            this.TotalValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.TotalValue.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.ObjectControl = null;
            this.TotalValue.ObjetoApp = null;
            this.TotalValue.Others = null;
            this.TotalValue.PropertyControl = null;
            this.TotalValue.PropertyDependecyUkey = null;
            this.TotalValue.Size = new System.Drawing.Size(109, 55);
            this.TotalValue.TabIndex = 6;
            this.TotalValue.TabStop = false;
            this.TotalValue.Text = "sNumeric1";
            this.TotalValue.ThousandsSeparator = true;
            this.TotalValue.ToolTipContext = null;
            this.TotalValue.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TotalValue.Validations")));
            this.TotalValue.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TotalPayable
            // 
            this.TotalPayable.Caption = "";
            this.TotalPayable.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TotalPayable.CenterCaption = false;
            this.TotalPayable.ComponentBackColor = System.Drawing.Color.White;
            this.TotalPayable.DecimalPlaces = 2;
            this.TotalPayable.Disable = true;
            this.TotalPayable.DisabledAutomaticNumbering = false;
            this.TotalPayable.FieldValid = true;
            this.TotalPayable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TotalPayable.Form = null;
            this.TotalPayable.FormType = null;
            this.TotalPayable.IsDependecyUkey = false;
            this.TotalPayable.Location = new System.Drawing.Point(475, 249);
            this.TotalPayable.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.TotalPayable.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TotalPayable.Name = "TotalPayable";
            this.TotalPayable.ObjectControl = null;
            this.TotalPayable.ObjetoApp = null;
            this.TotalPayable.Others = null;
            this.TotalPayable.PropertyControl = null;
            this.TotalPayable.PropertyDependecyUkey = null;
            this.TotalPayable.Size = new System.Drawing.Size(109, 55);
            this.TotalPayable.TabIndex = 7;
            this.TotalPayable.TabStop = false;
            this.TotalPayable.Text = "sNumeric2";
            this.TotalPayable.ThousandsSeparator = true;
            this.TotalPayable.ToolTipContext = null;
            this.TotalPayable.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TotalPayable.Validations")));
            this.TotalPayable.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // ParkingAgreementId
            // 
            this.ParkingAgreementId.Caption = "";
            this.ParkingAgreementId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ParkingAgreementId.CenterCaption = false;
            this.ParkingAgreementId.ComboBoxMultiForms = null;
            this.ParkingAgreementId.ComponentBackColor = System.Drawing.Color.White;
            this.ParkingAgreementId.DefaultValue = false;
            this.ParkingAgreementId.Disable = true;
            this.ParkingAgreementId.DisabledAutomaticNumbering = false;
            this.ParkingAgreementId.DisplayMember = "";
            this.ParkingAgreementId.FieldValid = true;
            this.ParkingAgreementId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ParkingAgreementId.Form = null;
            this.ParkingAgreementId.FormType = null;
            this.ParkingAgreementId.IsDependecyUkey = false;
            this.ParkingAgreementId.Location = new System.Drawing.Point(361, 68);
            this.ParkingAgreementId.Name = "ParkingAgreementId";
            this.ParkingAgreementId.ObjectControl = null;
            this.ParkingAgreementId.ObjetoApp = null;
            this.ParkingAgreementId.Others = null;
            this.ParkingAgreementId.PropertyControl = null;
            this.ParkingAgreementId.PropertyDependecyUkey = null;
            this.ParkingAgreementId.PropertySearch = null;
            this.ParkingAgreementId.Size = new System.Drawing.Size(337, 54);
            this.ParkingAgreementId.StandardValue = null;
            this.ParkingAgreementId.TabIndex = 9;
            this.ParkingAgreementId.TabStop = false;
            this.ParkingAgreementId.Text = "sComboBox1";
            this.ParkingAgreementId.ToolTipContext = null;
            this.ParkingAgreementId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ParkingAgreementId.Validations")));
            this.ParkingAgreementId.ValueControl = null;
            this.ParkingAgreementId.ValueMember = "";
            // 
            // FormOfPaymentId
            // 
            this.FormOfPaymentId.Caption = "";
            this.FormOfPaymentId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FormOfPaymentId.CenterCaption = false;
            this.FormOfPaymentId.ComboBoxMultiForms = null;
            this.FormOfPaymentId.ComponentBackColor = System.Drawing.Color.White;
            this.FormOfPaymentId.DefaultValue = false;
            this.FormOfPaymentId.Disable = true;
            this.FormOfPaymentId.DisabledAutomaticNumbering = false;
            this.FormOfPaymentId.DisplayMember = "";
            this.FormOfPaymentId.FieldValid = true;
            this.FormOfPaymentId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormOfPaymentId.Form = null;
            this.FormOfPaymentId.FormType = null;
            this.FormOfPaymentId.IsDependecyUkey = false;
            this.FormOfPaymentId.Location = new System.Drawing.Point(361, 128);
            this.FormOfPaymentId.Name = "FormOfPaymentId";
            this.FormOfPaymentId.ObjectControl = null;
            this.FormOfPaymentId.ObjetoApp = null;
            this.FormOfPaymentId.Others = null;
            this.FormOfPaymentId.PropertyControl = null;
            this.FormOfPaymentId.PropertyDependecyUkey = null;
            this.FormOfPaymentId.PropertySearch = null;
            this.FormOfPaymentId.Size = new System.Drawing.Size(337, 54);
            this.FormOfPaymentId.StandardValue = null;
            this.FormOfPaymentId.TabIndex = 10;
            this.FormOfPaymentId.TabStop = false;
            this.FormOfPaymentId.Text = "sComboBox2";
            this.FormOfPaymentId.ToolTipContext = null;
            this.FormOfPaymentId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FormOfPaymentId.Validations")));
            this.FormOfPaymentId.ValueControl = null;
            this.FormOfPaymentId.ValueMember = "";
            // 
            // FParkingOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(706, 477);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FParkingOut";
            this.Load += new System.EventHandler(this.FParkingOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Core.Component.SNumeric TicketNumber;
        private Core.Component.SNumeric AmountPaid;
        private Core.Component.SNumeric DiscountValueReal;
        private Core.Component.SNumeric ChangeOfMoney;
        private Core.Component.SNumeric DiscountValuePorcent;
        private Core.Component.SNumeric TotalPayable;
        private Core.Component.SNumeric TotalValue;
        private Core.Component.SComboBox FormOfPaymentId;
        private Core.Component.SComboBox ParkingAgreementId;
        private System.Windows.Forms.BindingSource TicketViewBindingSource;
    }
}