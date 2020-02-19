namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    partial class FComposition
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FComposition));
            this.Value = new Esr.Core.Component.SNumeric();
            this.Quantity = new Esr.Core.Component.SNumeric();
            this.UnitMeasureId = new Esr.Core.Component.SComboBox();
            this.StockItemId = new Esr.Core.Component.SComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Value);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.UnitMeasureId);
            this.panel1.Controls.Add(this.StockItemId);
            this.panel1.Size = new System.Drawing.Size(523, 125);
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
            this.Value.Location = new System.Drawing.Point(367, 64);
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
            this.Value.Size = new System.Drawing.Size(148, 54);
            this.Value.TabIndex = 3;
            this.Value.TabStop = false;
            this.Value.Text = "sNumeric2";
            this.Value.ThousandsSeparator = false;
            this.Value.ToolTipContext = null;
            this.Value.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Value.Validations")));
            this.Value.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Quantity
            // 
            this.Quantity.Caption = "";
            this.Quantity.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Quantity.CenterCaption = false;
            this.Quantity.ComponentBackColor = System.Drawing.Color.White;
            this.Quantity.DecimalPlaces = 2;
            this.Quantity.Disable = true;
            this.Quantity.FieldValid = true;
            this.Quantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Quantity.Form = null;
            this.Quantity.FormType = null;
            this.Quantity.IsDependecyUkey = false;
            this.Quantity.Location = new System.Drawing.Point(213, 64);
            this.Quantity.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Quantity.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Quantity.Name = "Quantity";
            this.Quantity.ObjectControl = null;
            this.Quantity.ObjetoApp = null;
            this.Quantity.PropertyControl = null;
            this.Quantity.PropertyDependecyUkey = null;
            this.Quantity.Size = new System.Drawing.Size(148, 54);
            this.Quantity.TabIndex = 2;
            this.Quantity.TabStop = false;
            this.Quantity.Text = "sNumeric1";
            this.Quantity.ThousandsSeparator = false;
            this.Quantity.ToolTipContext = null;
            this.Quantity.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Quantity.Validations")));
            this.Quantity.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // UnitMeasureId
            // 
            this.UnitMeasureId.Caption = "";
            this.UnitMeasureId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.UnitMeasureId.CenterCaption = false;
            this.UnitMeasureId.ComponentBackColor = System.Drawing.Color.White;
            this.UnitMeasureId.DefaultValue = false;
            this.UnitMeasureId.Disable = true;
            this.UnitMeasureId.DisplayMember = "";
            this.UnitMeasureId.FieldValid = true;
            this.UnitMeasureId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UnitMeasureId.Form = null;
            this.UnitMeasureId.FormType = null;
            this.UnitMeasureId.IsDependecyUkey = false;
            this.UnitMeasureId.Location = new System.Drawing.Point(11, 64);
            this.UnitMeasureId.Name = "UnitMeasureId";
            this.UnitMeasureId.ObjectControl = null;
            this.UnitMeasureId.ObjetoApp = null;
            this.UnitMeasureId.PropertyControl = null;
            this.UnitMeasureId.PropertyDependecyUkey = null;
            this.UnitMeasureId.Size = new System.Drawing.Size(196, 54);
            this.UnitMeasureId.StandardValue = null;
            this.UnitMeasureId.TabIndex = 1;
            this.UnitMeasureId.TabStop = false;
            this.UnitMeasureId.Text = "sComboBox1";
            this.UnitMeasureId.ToolTipContext = null;
            this.UnitMeasureId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("UnitMeasureId.Validations")));
            this.UnitMeasureId.ValueControl = null;
            this.UnitMeasureId.ValueMember = "";
            // 
            // StockItemId
            // 
            this.StockItemId.Caption = "";
            this.StockItemId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.StockItemId.CenterCaption = false;
            this.StockItemId.ComponentBackColor = System.Drawing.Color.White;
            this.StockItemId.DefaultValue = false;
            this.StockItemId.Disable = true;
            this.StockItemId.DisplayMember = "";
            this.StockItemId.FieldValid = true;
            this.StockItemId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StockItemId.Form = null;
            this.StockItemId.FormType = null;
            this.StockItemId.IsDependecyUkey = false;
            this.StockItemId.Location = new System.Drawing.Point(12, 6);
            this.StockItemId.Name = "StockItemId";
            this.StockItemId.ObjectControl = null;
            this.StockItemId.ObjetoApp = null;
            this.StockItemId.PropertyControl = null;
            this.StockItemId.PropertyDependecyUkey = null;
            this.StockItemId.Size = new System.Drawing.Size(503, 52);
            this.StockItemId.StandardValue = null;
            this.StockItemId.TabIndex = 0;
            this.StockItemId.TabStop = false;
            this.StockItemId.Text = "sComboBox1";
            this.StockItemId.ToolTipContext = null;
            this.StockItemId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("StockItemId.Validations")));
            this.StockItemId.ValueControl = null;
            this.StockItemId.ValueMember = "";
            // 
            // FComposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(523, 289);
            this.Name = "FComposition";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SNumeric Value;
        private Core.Component.SNumeric Quantity;
        private Core.Component.SComboBox UnitMeasureId;
        private Core.Component.SComboBox StockItemId;
    }
}
