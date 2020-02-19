namespace Esr.Module.Funerary.Forms.OrderOfServices
{
    partial class FOscontractorService
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOscontractorService));
            this.ContractorId = new Esr.Core.Component.SComboBox();
            this.ServiceId = new Esr.Core.Component.SComboBox();
            this.ValueService = new Esr.Core.Component.SNumeric();
            this.HistoricalService = new Esr.Core.Component.SRichText();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HistoricalService);
            this.panel1.Controls.Add(this.ValueService);
            this.panel1.Controls.Add(this.ServiceId);
            this.panel1.Controls.Add(this.ContractorId);
            this.panel1.Size = new System.Drawing.Size(606, 322);
            // 
            // ContractorId
            // 
            this.ContractorId.Caption = "";
            this.ContractorId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ContractorId.CenterCaption = false;
            this.ContractorId.ComboBoxMultiForms = null;
            this.ContractorId.ComponentBackColor = System.Drawing.Color.White;
            this.ContractorId.DefaultValue = false;
            this.ContractorId.Disable = true;
            this.ContractorId.DisplayMember = "";
            this.ContractorId.FieldValid = true;
            this.ContractorId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ContractorId.Form = null;
            this.ContractorId.FormType = null;
            this.ContractorId.IsDependecyUkey = false;
            this.ContractorId.Location = new System.Drawing.Point(12, 6);
            this.ContractorId.Name = "ContractorId";
            this.ContractorId.ObjectControl = null;
            this.ContractorId.ObjetoApp = null;
            this.ContractorId.Others = null;
            this.ContractorId.PropertyControl = null;
            this.ContractorId.PropertyDependecyUkey = null;
            this.ContractorId.Size = new System.Drawing.Size(582, 54);
            this.ContractorId.StandardValue = null;
            this.ContractorId.TabIndex = 0;
            this.ContractorId.TabStop = false;
            this.ContractorId.Text = "ContractorId";
            this.ContractorId.ToolTipContext = null;
            this.ContractorId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ContractorId.Validations")));
            this.ContractorId.ValueControl = null;
            this.ContractorId.ValueMember = "";
            // 
            // ServiceId
            // 
            this.ServiceId.Caption = "";
            this.ServiceId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ServiceId.CenterCaption = false;
            this.ServiceId.ComboBoxMultiForms = null;
            this.ServiceId.ComponentBackColor = System.Drawing.Color.White;
            this.ServiceId.DefaultValue = false;
            this.ServiceId.Disable = true;
            this.ServiceId.DisplayMember = "";
            this.ServiceId.FieldValid = true;
            this.ServiceId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ServiceId.Form = null;
            this.ServiceId.FormType = null;
            this.ServiceId.IsDependecyUkey = false;
            this.ServiceId.Location = new System.Drawing.Point(10, 66);
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.ObjectControl = null;
            this.ServiceId.ObjetoApp = null;
            this.ServiceId.Others = null;
            this.ServiceId.PropertyControl = null;
            this.ServiceId.PropertyDependecyUkey = null;
            this.ServiceId.Size = new System.Drawing.Size(401, 54);
            this.ServiceId.StandardValue = null;
            this.ServiceId.TabIndex = 1;
            this.ServiceId.TabStop = false;
            this.ServiceId.Text = "ServiceId";
            this.ServiceId.ToolTipContext = null;
            this.ServiceId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ServiceId.Validations")));
            this.ServiceId.ValueControl = null;
            this.ServiceId.ValueMember = "";
            // 
            // ValueService
            // 
            this.ValueService.Caption = "";
            this.ValueService.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ValueService.CenterCaption = false;
            this.ValueService.ComponentBackColor = System.Drawing.Color.White;
            this.ValueService.DecimalPlaces = 2;
            this.ValueService.Disable = true;
            this.ValueService.FieldValid = true;
            this.ValueService.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ValueService.Form = null;
            this.ValueService.FormType = null;
            this.ValueService.IsDependecyUkey = false;
            this.ValueService.Location = new System.Drawing.Point(417, 65);
            this.ValueService.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ValueService.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ValueService.Name = "ValueService";
            this.ValueService.ObjectControl = null;
            this.ValueService.ObjetoApp = null;
            this.ValueService.Others = null;
            this.ValueService.PropertyControl = null;
            this.ValueService.PropertyDependecyUkey = null;
            this.ValueService.Size = new System.Drawing.Size(177, 55);
            this.ValueService.TabIndex = 2;
            this.ValueService.TabStop = false;
            this.ValueService.Text = "ValueService";
            this.ValueService.ThousandsSeparator = true;
            this.ValueService.ToolTipContext = null;
            this.ValueService.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ValueService.Validations")));
            this.ValueService.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // HistoricalService
            // 
            this.HistoricalService.Caption = "";
            this.HistoricalService.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.HistoricalService.CenterCaption = false;
            this.HistoricalService.ComponentBackColor = System.Drawing.Color.White;
            this.HistoricalService.Disable = true;
            this.HistoricalService.FieldValid = true;
            this.HistoricalService.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HistoricalService.Form = null;
            this.HistoricalService.FormType = null;
            this.HistoricalService.IsDependecyUkey = false;
            this.HistoricalService.Location = new System.Drawing.Point(12, 126);
            this.HistoricalService.Name = "HistoricalService";
            this.HistoricalService.ObjectControl = null;
            this.HistoricalService.ObjetoApp = null;
            this.HistoricalService.Others = null;
            this.HistoricalService.PropertyControl = null;
            this.HistoricalService.PropertyDependecyUkey = null;
            this.HistoricalService.Size = new System.Drawing.Size(582, 193);
            this.HistoricalService.TabIndex = 3;
            this.HistoricalService.TabStop = false;
            this.HistoricalService.Text = "sRichText1";
            this.HistoricalService.ToolTipContext = null;
            this.HistoricalService.Validations = null;
            this.HistoricalService.ValueControl = "";
            // 
            // FOscontractorService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(606, 486);
            this.Name = "FOscontractorService";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SComboBox ContractorId;
        private Core.Component.SComboBox ServiceId;
        private Core.Component.SNumeric ValueService;
        private Core.Component.SRichText HistoricalService;
    }
}
