namespace Esr.Module.Funerary.Forms.OrderOfServices
{
    partial class FOsService
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOsService));
            this.ValueService = new Esr.Core.Component.SNumeric();
            this.ServiceId = new Esr.Core.Component.SComboBox();
            this.LegalPersonId = new Esr.Core.Component.SComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LegalPersonId);
            this.panel1.Controls.Add(this.ValueService);
            this.panel1.Controls.Add(this.ServiceId);
            this.panel1.Size = new System.Drawing.Size(607, 132);
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
            this.ValueService.Location = new System.Drawing.Point(419, 65);
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
            this.ValueService.TabIndex = 4;
            this.ValueService.TabStop = false;
            this.ValueService.Text = "ValueService";
            this.ValueService.ThousandsSeparator = false;
            this.ValueService.ToolTipContext = null;
            this.ValueService.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ValueService.Validations")));
            this.ValueService.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            this.ServiceId.Location = new System.Drawing.Point(12, 66);
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.ObjectControl = null;
            this.ServiceId.ObjetoApp = null;
            this.ServiceId.Others = null;
            this.ServiceId.PropertyControl = null;
            this.ServiceId.PropertyDependecyUkey = null;
            this.ServiceId.Size = new System.Drawing.Size(401, 54);
            this.ServiceId.StandardValue = null;
            this.ServiceId.TabIndex = 3;
            this.ServiceId.TabStop = false;
            this.ServiceId.Text = "ServiceId";
            this.ServiceId.ToolTipContext = null;
            this.ServiceId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ServiceId.Validations")));
            this.ServiceId.ValueControl = null;
            this.ServiceId.ValueMember = "";
            // 
            // LegalPersonId
            // 
            this.LegalPersonId.Caption = "";
            this.LegalPersonId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.LegalPersonId.CenterCaption = false;
            this.LegalPersonId.ComboBoxMultiForms = null;
            this.LegalPersonId.ComponentBackColor = System.Drawing.Color.White;
            this.LegalPersonId.DefaultValue = false;
            this.LegalPersonId.Disable = true;
            this.LegalPersonId.DisplayMember = "";
            this.LegalPersonId.FieldValid = true;
            this.LegalPersonId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LegalPersonId.Form = null;
            this.LegalPersonId.FormType = null;
            this.LegalPersonId.IsDependecyUkey = false;
            this.LegalPersonId.Location = new System.Drawing.Point(12, 6);
            this.LegalPersonId.Name = "LegalPersonId";
            this.LegalPersonId.ObjectControl = null;
            this.LegalPersonId.ObjetoApp = null;
            this.LegalPersonId.Others = null;
            this.LegalPersonId.PropertyControl = null;
            this.LegalPersonId.PropertyDependecyUkey = null;
            this.LegalPersonId.Size = new System.Drawing.Size(583, 54);
            this.LegalPersonId.StandardValue = null;
            this.LegalPersonId.TabIndex = 5;
            this.LegalPersonId.TabStop = false;
            this.LegalPersonId.Text = "sComboBox1";
            this.LegalPersonId.ToolTipContext = null;
            this.LegalPersonId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("LegalPersonId.Validations")));
            this.LegalPersonId.ValueControl = null;
            this.LegalPersonId.ValueMember = "";
            // 
            // FOsService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(607, 296);
            this.Name = "FOsService";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SNumeric ValueService;
        private Core.Component.SComboBox ServiceId;
        private Core.Component.SComboBox LegalPersonId;
    }
}
