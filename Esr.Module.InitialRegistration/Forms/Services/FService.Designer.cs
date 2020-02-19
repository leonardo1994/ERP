namespace Esr.Module.InitialRegistration.Forms.Services
{
    partial class FService
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FService));
            this.Code = new Esr.Core.Component.STextBox();
            this.Description = new Esr.Core.Component.STextBox();
            this.TypeServiceId = new Esr.Core.Component.SComboBox();
            this.Cost = new Esr.Core.Component.SNumeric();
            this.TypeValueCommission = new Esr.Core.Component.SComboBox();
            this.ValueService = new Esr.Core.Component.SNumeric();
            this.Commission = new Esr.Core.Component.SNumeric();
            this.Profit = new Esr.Core.Component.SNumeric();
            this.TypeValueProfit = new Esr.Core.Component.SComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Profit);
            this.panel1.Controls.Add(this.TypeValueProfit);
            this.panel1.Controls.Add(this.Commission);
            this.panel1.Controls.Add(this.ValueService);
            this.panel1.Controls.Add(this.TypeValueCommission);
            this.panel1.Controls.Add(this.Cost);
            this.panel1.Controls.Add(this.TypeServiceId);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.Code);
            this.panel1.Size = new System.Drawing.Size(601, 245);
            // 
            // Code
            // 
            this.Code.Caption = "";
            this.Code.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Code.CenterCaption = false;
            this.Code.ComponentBackColor = System.Drawing.Color.White;
            this.Code.Disable = true;
            this.Code.FieldValid = true;
            this.Code.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Code.Form = null;
            this.Code.FormType = null;
            this.Code.IsDependecyUkey = false;
            this.Code.Location = new System.Drawing.Point(12, 6);
            this.Code.Name = "Code";
            this.Code.ObjectControl = null;
            this.Code.ObjetoApp = null;
            this.Code.PropertyControl = null;
            this.Code.PropertyDependecyUkey = null;
            this.Code.Size = new System.Drawing.Size(170, 54);
            this.Code.TabIndex = 0;
            this.Code.TabStop = false;
            this.Code.Text = "sTextBox1";
            this.Code.ToolTipContext = null;
            this.Code.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Code.Validations")));
            this.Code.ValueControl = "";
            // 
            // Description
            // 
            this.Description.Caption = "";
            this.Description.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Description.CenterCaption = false;
            this.Description.ComponentBackColor = System.Drawing.Color.White;
            this.Description.Disable = true;
            this.Description.FieldValid = true;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Description.Form = null;
            this.Description.FormType = null;
            this.Description.IsDependecyUkey = false;
            this.Description.Location = new System.Drawing.Point(188, 6);
            this.Description.Name = "Description";
            this.Description.ObjectControl = null;
            this.Description.ObjetoApp = null;
            this.Description.PropertyControl = null;
            this.Description.PropertyDependecyUkey = null;
            this.Description.Size = new System.Drawing.Size(402, 54);
            this.Description.TabIndex = 1;
            this.Description.TabStop = false;
            this.Description.Text = "sTextBox1";
            this.Description.ToolTipContext = null;
            this.Description.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Description.Validations")));
            this.Description.ValueControl = "";
            // 
            // TypeServiceId
            // 
            this.TypeServiceId.Caption = "";
            this.TypeServiceId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypeServiceId.CenterCaption = false;
            this.TypeServiceId.ComponentBackColor = System.Drawing.Color.White;
            this.TypeServiceId.DefaultValue = false;
            this.TypeServiceId.Disable = true;
            this.TypeServiceId.DisplayMember = "";
            this.TypeServiceId.FieldValid = true;
            this.TypeServiceId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeServiceId.Form = null;
            this.TypeServiceId.FormType = null;
            this.TypeServiceId.IsDependecyUkey = false;
            this.TypeServiceId.Location = new System.Drawing.Point(12, 66);
            this.TypeServiceId.Name = "TypeServiceId";
            this.TypeServiceId.ObjectControl = null;
            this.TypeServiceId.ObjetoApp = null;
            this.TypeServiceId.PropertyControl = null;
            this.TypeServiceId.PropertyDependecyUkey = null;
            this.TypeServiceId.Size = new System.Drawing.Size(578, 54);
            this.TypeServiceId.StandardValue = null;
            this.TypeServiceId.TabIndex = 2;
            this.TypeServiceId.TabStop = false;
            this.TypeServiceId.Text = "sComboBox1";
            this.TypeServiceId.ToolTipContext = null;
            this.TypeServiceId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TypeServiceId.Validations")));
            this.TypeServiceId.ValueControl = null;
            this.TypeServiceId.ValueMember = "";
            // 
            // Cost
            // 
            this.Cost.Caption = "";
            this.Cost.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Cost.CenterCaption = false;
            this.Cost.ComponentBackColor = System.Drawing.Color.White;
            this.Cost.DecimalPlaces = 0;
            this.Cost.Disable = true;
            this.Cost.FieldValid = true;
            this.Cost.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Cost.Form = null;
            this.Cost.FormType = null;
            this.Cost.IsDependecyUkey = false;
            this.Cost.Location = new System.Drawing.Point(12, 124);
            this.Cost.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Cost.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Cost.Name = "Cost";
            this.Cost.ObjectControl = null;
            this.Cost.ObjetoApp = null;
            this.Cost.PropertyControl = null;
            this.Cost.PropertyDependecyUkey = null;
            this.Cost.Size = new System.Drawing.Size(170, 55);
            this.Cost.TabIndex = 3;
            this.Cost.TabStop = false;
            this.Cost.Text = "sNumeric1";
            this.Cost.ThousandsSeparator = false;
            this.Cost.ToolTipContext = null;
            this.Cost.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Cost.Validations")));
            this.Cost.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TypeValueCommission
            // 
            this.TypeValueCommission.Caption = "";
            this.TypeValueCommission.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypeValueCommission.CenterCaption = false;
            this.TypeValueCommission.ComponentBackColor = System.Drawing.Color.White;
            this.TypeValueCommission.DefaultValue = false;
            this.TypeValueCommission.Disable = true;
            this.TypeValueCommission.DisplayMember = "";
            this.TypeValueCommission.FieldValid = true;
            this.TypeValueCommission.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeValueCommission.Form = null;
            this.TypeValueCommission.FormType = null;
            this.TypeValueCommission.IsDependecyUkey = false;
            this.TypeValueCommission.Location = new System.Drawing.Point(346, 126);
            this.TypeValueCommission.Name = "TypeValueCommission";
            this.TypeValueCommission.ObjectControl = null;
            this.TypeValueCommission.ObjetoApp = null;
            this.TypeValueCommission.PropertyControl = null;
            this.TypeValueCommission.PropertyDependecyUkey = null;
            this.TypeValueCommission.Size = new System.Drawing.Size(68, 53);
            this.TypeValueCommission.StandardValue = null;
            this.TypeValueCommission.TabIndex = 4;
            this.TypeValueCommission.TabStop = false;
            this.TypeValueCommission.Text = "sComboBox1";
            this.TypeValueCommission.ToolTipContext = null;
            this.TypeValueCommission.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TypeValueCommission.Validations")));
            this.TypeValueCommission.ValueControl = null;
            this.TypeValueCommission.ValueMember = "";
            // 
            // ValueService
            // 
            this.ValueService.Caption = "";
            this.ValueService.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ValueService.CenterCaption = false;
            this.ValueService.ComponentBackColor = System.Drawing.Color.White;
            this.ValueService.DecimalPlaces = 0;
            this.ValueService.Disable = true;
            this.ValueService.FieldValid = true;
            this.ValueService.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ValueService.Form = null;
            this.ValueService.FormType = null;
            this.ValueService.IsDependecyUkey = false;
            this.ValueService.Location = new System.Drawing.Point(12, 183);
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
            this.ValueService.PropertyControl = null;
            this.ValueService.PropertyDependecyUkey = null;
            this.ValueService.Size = new System.Drawing.Size(170, 55);
            this.ValueService.TabIndex = 6;
            this.ValueService.TabStop = false;
            this.ValueService.Text = "sNumeric2";
            this.ValueService.ThousandsSeparator = false;
            this.ValueService.ToolTipContext = null;
            this.ValueService.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ValueService.Validations")));
            this.ValueService.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Commission
            // 
            this.Commission.Caption = "";
            this.Commission.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Commission.CenterCaption = false;
            this.Commission.ComponentBackColor = System.Drawing.Color.White;
            this.Commission.DecimalPlaces = 0;
            this.Commission.Disable = true;
            this.Commission.FieldValid = true;
            this.Commission.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Commission.Form = null;
            this.Commission.FormType = null;
            this.Commission.IsDependecyUkey = false;
            this.Commission.Location = new System.Drawing.Point(420, 126);
            this.Commission.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Commission.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Commission.Name = "Commission";
            this.Commission.ObjectControl = null;
            this.Commission.ObjetoApp = null;
            this.Commission.PropertyControl = null;
            this.Commission.PropertyDependecyUkey = null;
            this.Commission.Size = new System.Drawing.Size(170, 55);
            this.Commission.TabIndex = 5;
            this.Commission.TabStop = false;
            this.Commission.Text = "sNumeric3";
            this.Commission.ThousandsSeparator = false;
            this.Commission.ToolTipContext = null;
            this.Commission.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Commission.Validations")));
            this.Commission.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Profit
            // 
            this.Profit.Caption = "";
            this.Profit.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Profit.CenterCaption = false;
            this.Profit.ComponentBackColor = System.Drawing.Color.White;
            this.Profit.DecimalPlaces = 0;
            this.Profit.Disable = true;
            this.Profit.FieldValid = true;
            this.Profit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Profit.Form = null;
            this.Profit.FormType = null;
            this.Profit.IsDependecyUkey = false;
            this.Profit.Location = new System.Drawing.Point(420, 187);
            this.Profit.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Profit.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Profit.Name = "Profit";
            this.Profit.ObjectControl = null;
            this.Profit.ObjetoApp = null;
            this.Profit.PropertyControl = null;
            this.Profit.PropertyDependecyUkey = null;
            this.Profit.Size = new System.Drawing.Size(170, 55);
            this.Profit.TabIndex = 8;
            this.Profit.TabStop = false;
            this.Profit.Text = "sNumeric4";
            this.Profit.ThousandsSeparator = false;
            this.Profit.ToolTipContext = null;
            this.Profit.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Profit.Validations")));
            this.Profit.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TypeValueProfit
            // 
            this.TypeValueProfit.Caption = "";
            this.TypeValueProfit.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypeValueProfit.CenterCaption = false;
            this.TypeValueProfit.ComponentBackColor = System.Drawing.Color.White;
            this.TypeValueProfit.DefaultValue = false;
            this.TypeValueProfit.Disable = true;
            this.TypeValueProfit.DisplayMember = "";
            this.TypeValueProfit.FieldValid = true;
            this.TypeValueProfit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeValueProfit.Form = null;
            this.TypeValueProfit.FormType = null;
            this.TypeValueProfit.IsDependecyUkey = false;
            this.TypeValueProfit.Location = new System.Drawing.Point(346, 185);
            this.TypeValueProfit.Name = "TypeValueProfit";
            this.TypeValueProfit.ObjectControl = null;
            this.TypeValueProfit.ObjetoApp = null;
            this.TypeValueProfit.PropertyControl = null;
            this.TypeValueProfit.PropertyDependecyUkey = null;
            this.TypeValueProfit.Size = new System.Drawing.Size(68, 53);
            this.TypeValueProfit.StandardValue = null;
            this.TypeValueProfit.TabIndex = 7;
            this.TypeValueProfit.TabStop = false;
            this.TypeValueProfit.Text = "sComboBox2";
            this.TypeValueProfit.ToolTipContext = null;
            this.TypeValueProfit.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TypeValueProfit.Validations")));
            this.TypeValueProfit.ValueControl = null;
            this.TypeValueProfit.ValueMember = "";
            // 
            // FService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(601, 409);
            this.Name = "FService";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox Code;
        private Core.Component.STextBox Description;
        private Core.Component.SComboBox TypeServiceId;
        private Core.Component.SNumeric Cost;
        private Core.Component.SNumeric Profit;
        private Core.Component.SComboBox TypeValueProfit;
        private Core.Component.SNumeric Commission;
        private Core.Component.SNumeric ValueService;
        private Core.Component.SComboBox TypeValueCommission;
    }
}
