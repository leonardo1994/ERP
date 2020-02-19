namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    partial class FSpecialTax
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSpecialTax));
            this.Iva = new Esr.Core.Component.SNumeric();
            this.Aliquot = new Esr.Core.Component.SNumeric();
            this.TaxationId = new Esr.Core.Component.SComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Iva);
            this.panel1.Controls.Add(this.Aliquot);
            this.panel1.Controls.Add(this.TaxationId);
            this.panel1.Size = new System.Drawing.Size(451, 133);
            // 
            // Iva
            // 
            this.Iva.Caption = "";
            this.Iva.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Iva.CenterCaption = false;
            this.Iva.ComponentBackColor = System.Drawing.Color.White;
            this.Iva.DecimalPlaces = 2;
            this.Iva.Disable = true;
            this.Iva.FieldValid = true;
            this.Iva.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Iva.Form = null;
            this.Iva.FormType = null;
            this.Iva.IsDependecyUkey = false;
            this.Iva.Location = new System.Drawing.Point(232, 67);
            this.Iva.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Iva.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Iva.Name = "Iva";
            this.Iva.ObjectControl = null;
            this.Iva.ObjetoApp = null;
            this.Iva.PropertyControl = null;
            this.Iva.PropertyDependecyUkey = null;
            this.Iva.Size = new System.Drawing.Size(207, 53);
            this.Iva.TabIndex = 2;
            this.Iva.TabStop = false;
            this.Iva.Text = "sNumeric1";
            this.Iva.ThousandsSeparator = false;
            this.Iva.ToolTipContext = null;
            this.Iva.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Iva.Validations")));
            this.Iva.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Aliquot
            // 
            this.Aliquot.Caption = "";
            this.Aliquot.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Aliquot.CenterCaption = false;
            this.Aliquot.ComponentBackColor = System.Drawing.Color.White;
            this.Aliquot.DecimalPlaces = 2;
            this.Aliquot.Disable = true;
            this.Aliquot.FieldValid = true;
            this.Aliquot.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Aliquot.Form = null;
            this.Aliquot.FormType = null;
            this.Aliquot.IsDependecyUkey = false;
            this.Aliquot.Location = new System.Drawing.Point(19, 67);
            this.Aliquot.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Aliquot.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Aliquot.Name = "Aliquot";
            this.Aliquot.ObjectControl = null;
            this.Aliquot.ObjetoApp = null;
            this.Aliquot.PropertyControl = null;
            this.Aliquot.PropertyDependecyUkey = null;
            this.Aliquot.Size = new System.Drawing.Size(207, 53);
            this.Aliquot.TabIndex = 1;
            this.Aliquot.TabStop = false;
            this.Aliquot.Text = "sNumeric1";
            this.Aliquot.ThousandsSeparator = false;
            this.Aliquot.ToolTipContext = null;
            this.Aliquot.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Aliquot.Validations")));
            this.Aliquot.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TaxationId
            // 
            this.TaxationId.Caption = "";
            this.TaxationId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TaxationId.CenterCaption = false;
            this.TaxationId.ComponentBackColor = System.Drawing.Color.White;
            this.TaxationId.DefaultValue = false;
            this.TaxationId.Disable = true;
            this.TaxationId.DisplayMember = "";
            this.TaxationId.FieldValid = true;
            this.TaxationId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TaxationId.Form = null;
            this.TaxationId.FormType = null;
            this.TaxationId.IsDependecyUkey = false;
            this.TaxationId.Location = new System.Drawing.Point(12, 6);
            this.TaxationId.Name = "TaxationId";
            this.TaxationId.ObjectControl = null;
            this.TaxationId.ObjetoApp = null;
            this.TaxationId.PropertyControl = null;
            this.TaxationId.PropertyDependecyUkey = null;
            this.TaxationId.Size = new System.Drawing.Size(427, 55);
            this.TaxationId.StandardValue = null;
            this.TaxationId.TabIndex = 0;
            this.TaxationId.TabStop = false;
            this.TaxationId.Text = "sComboBox1";
            this.TaxationId.ToolTipContext = null;
            this.TaxationId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TaxationId.Validations")));
            this.TaxationId.ValueControl = null;
            this.TaxationId.ValueMember = "";
            // 
            // FSpecialTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(451, 297);
            this.Name = "FSpecialTax";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SNumeric Iva;
        private Core.Component.SNumeric Aliquot;
        private Core.Component.SComboBox TaxationId;
    }
}
