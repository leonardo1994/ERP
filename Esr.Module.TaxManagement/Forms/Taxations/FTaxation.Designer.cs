namespace Esr.Module.TaxManagement.Forms.Taxations
{
    partial class FTaxation
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTaxation));
            this.TaxesOnBooks = new Esr.Core.Component.SComboBox();
            this.StandardRate = new Esr.Core.Component.SNumeric();
            this.Description = new Esr.Core.Component.STextBox();
            this.Initials = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TaxesOnBooks);
            this.panel1.Controls.Add(this.StandardRate);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.Initials);
            this.panel1.Size = new System.Drawing.Size(658, 138);
            // 
            // TaxesOnBooks
            // 
            this.TaxesOnBooks.Caption = "";
            this.TaxesOnBooks.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TaxesOnBooks.CenterCaption = false;
            this.TaxesOnBooks.ComponentBackColor = System.Drawing.Color.White;
            this.TaxesOnBooks.DefaultValue = false;
            this.TaxesOnBooks.Disable = true;
            this.TaxesOnBooks.DisplayMember = "";
            this.TaxesOnBooks.FieldValid = true;
            this.TaxesOnBooks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TaxesOnBooks.Form = null;
            this.TaxesOnBooks.FormType = null;
            this.TaxesOnBooks.IsDependecyUkey = false;
            this.TaxesOnBooks.Location = new System.Drawing.Point(13, 68);
            this.TaxesOnBooks.Name = "TaxesOnBooks";
            this.TaxesOnBooks.ObjectControl = null;
            this.TaxesOnBooks.ObjetoApp = null;
            this.TaxesOnBooks.PropertyControl = null;
            this.TaxesOnBooks.PropertyDependecyUkey = null;
            this.TaxesOnBooks.Size = new System.Drawing.Size(533, 52);
            this.TaxesOnBooks.StandardValue = null;
            this.TaxesOnBooks.TabIndex = 2;
            this.TaxesOnBooks.TabStop = false;
            this.TaxesOnBooks.Text = "sComboBox1";
            this.TaxesOnBooks.ToolTipContext = null;
            this.TaxesOnBooks.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TaxesOnBooks.Validations")));
            this.TaxesOnBooks.ValueControl = null;
            this.TaxesOnBooks.ValueMember = "";
            // 
            // StandardRate
            // 
            this.StandardRate.Caption = "";
            this.StandardRate.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.StandardRate.CenterCaption = false;
            this.StandardRate.ComponentBackColor = System.Drawing.Color.White;
            this.StandardRate.DecimalPlaces = 2;
            this.StandardRate.Disable = true;
            this.StandardRate.FieldValid = true;
            this.StandardRate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StandardRate.Form = null;
            this.StandardRate.FormType = null;
            this.StandardRate.IsDependecyUkey = false;
            this.StandardRate.Location = new System.Drawing.Point(552, 67);
            this.StandardRate.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.StandardRate.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.StandardRate.Name = "StandardRate";
            this.StandardRate.ObjectControl = null;
            this.StandardRate.ObjetoApp = null;
            this.StandardRate.PropertyControl = null;
            this.StandardRate.PropertyDependecyUkey = null;
            this.StandardRate.Size = new System.Drawing.Size(94, 53);
            this.StandardRate.TabIndex = 3;
            this.StandardRate.TabStop = false;
            this.StandardRate.Text = "sNumeric1";
            this.StandardRate.ThousandsSeparator = false;
            this.StandardRate.ToolTipContext = null;
            this.StandardRate.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("StandardRate.Validations")));
            this.StandardRate.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            this.Description.Location = new System.Drawing.Point(163, 6);
            this.Description.Name = "Description";
            this.Description.ObjectControl = null;
            this.Description.ObjetoApp = null;
            this.Description.PropertyControl = null;
            this.Description.PropertyDependecyUkey = null;
            this.Description.Size = new System.Drawing.Size(483, 55);
            this.Description.TabIndex = 1;
            this.Description.Text = "sTextBox1";
            this.Description.ToolTipContext = null;
            this.Description.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Description.Validations")));
            this.Description.ValueControl = "";
            // 
            // Initials
            // 
            this.Initials.Caption = "";
            this.Initials.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Initials.CenterCaption = false;
            this.Initials.ComponentBackColor = System.Drawing.Color.White;
            this.Initials.Disable = true;
            this.Initials.FieldValid = true;
            this.Initials.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Initials.Form = null;
            this.Initials.FormType = null;
            this.Initials.IsDependecyUkey = false;
            this.Initials.Location = new System.Drawing.Point(12, 6);
            this.Initials.Name = "Initials";
            this.Initials.ObjectControl = null;
            this.Initials.ObjetoApp = null;
            this.Initials.PropertyControl = null;
            this.Initials.PropertyDependecyUkey = null;
            this.Initials.Size = new System.Drawing.Size(145, 55);
            this.Initials.TabIndex = 0;
            this.Initials.TabStop = false;
            this.Initials.Text = "sTextBox1";
            this.Initials.ToolTipContext = null;
            this.Initials.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Initials.Validations")));
            this.Initials.ValueControl = "";
            // 
            // FTaxation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(658, 302);
            this.Name = "FTaxation";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SComboBox TaxesOnBooks;
        private Core.Component.SNumeric StandardRate;
        private Core.Component.STextBox Description;
        private Core.Component.STextBox Initials;
    }
}
