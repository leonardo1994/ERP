namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    partial class FItemSuppliers
    {
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProviderId = new Esr.Core.Component.SComboBox();
            this.Value = new Esr.Core.Component.SNumeric();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Value);
            this.panel1.Controls.Add(this.ProviderId);
            this.panel1.Size = new System.Drawing.Size(535, 231);
            // 
            // ProviderId
            // 
            this.ProviderId.Caption = "";
            this.ProviderId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ProviderId.CenterCaption = false;
            this.ProviderId.ComboBoxMultiForms = null;
            this.ProviderId.ComponentBackColor = System.Drawing.Color.White;
            this.ProviderId.DefaultValue = false;
            this.ProviderId.Disable = true;
            this.ProviderId.DisplayMember = "";
            this.ProviderId.FieldValid = true;
            this.ProviderId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProviderId.Form = null;
            this.ProviderId.FormType = null;
            this.ProviderId.IsDependecyUkey = false;
            this.ProviderId.Location = new System.Drawing.Point(51, 24);
            this.ProviderId.Name = "ProviderId";
            this.ProviderId.ObjectControl = null;
            this.ProviderId.ObjetoApp = null;
            this.ProviderId.PropertyControl = null;
            this.ProviderId.PropertyDependecyUkey = null;
            this.ProviderId.Size = new System.Drawing.Size(430, 69);
            this.ProviderId.StandardValue = null;
            this.ProviderId.TabIndex = 0;
            this.ProviderId.TabStop = false;
            this.ProviderId.Text = "sComboBox1";
            this.ProviderId.ToolTipContext = null;
            this.ProviderId.Validations = null;
            this.ProviderId.ValueControl = null;
            this.ProviderId.ValueMember = "";
            // 
            // Value
            // 
            this.Value.Caption = "";
            this.Value.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Value.CenterCaption = false;
            this.Value.ComponentBackColor = System.Drawing.Color.White;
            this.Value.DecimalPlaces = 2;
            this.Value.Disable = true;
            this.Value.FieldValid = true;
            this.Value.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Value.Form = null;
            this.Value.FormType = null;
            this.Value.IsDependecyUkey = false;
            this.Value.Location = new System.Drawing.Point(169, 99);
            this.Value.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Value.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Value.Name = "Value";
            this.Value.ObjectControl = null;
            this.Value.ObjetoApp = null;
            this.Value.PropertyControl = null;
            this.Value.PropertyDependecyUkey = null;
            this.Value.Size = new System.Drawing.Size(174, 54);
            this.Value.TabIndex = 1;
            this.Value.TabStop = false;
            this.Value.Text = "sNumeric1";
            this.Value.ThousandsSeparator = true;
            this.Value.ToolTipContext = null;
            this.Value.Validations = null;
            this.Value.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // FItemSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(535, 395);
            this.Name = "FItemSuppliers";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SComboBox ProviderId;
        private Core.Component.SNumeric Value;
    }
}
