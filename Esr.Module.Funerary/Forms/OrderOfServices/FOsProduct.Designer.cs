namespace Esr.Module.Funerary.Forms.OrderOfServices
{
    partial class FOsProduct
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOsProduct));
            this.UnitaryValue = new Esr.Core.Component.SNumeric();
            this.ValueTotal = new Esr.Core.Component.SNumeric();
            this.UnitMeasureId = new Esr.Core.Component.SComboBox();
            this.Quantity = new Esr.Core.Component.SNumeric();
            this.StockItemId = new Esr.Core.Component.SComboBox();
            this.LocalStockId = new Esr.Core.Component.SComboBox();
            this.ProviderId = new Esr.Core.Component.SComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProviderId);
            this.panel1.Controls.Add(this.LocalStockId);
            this.panel1.Controls.Add(this.UnitaryValue);
            this.panel1.Controls.Add(this.ValueTotal);
            this.panel1.Controls.Add(this.UnitMeasureId);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.StockItemId);
            this.panel1.Size = new System.Drawing.Size(463, 262);
            // 
            // UnitaryValue
            // 
            this.UnitaryValue.Caption = "";
            this.UnitaryValue.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.UnitaryValue.CenterCaption = false;
            this.UnitaryValue.ComponentBackColor = System.Drawing.Color.White;
            this.UnitaryValue.DecimalPlaces = 2;
            this.UnitaryValue.Disable = true;
            this.UnitaryValue.FieldValid = true;
            this.UnitaryValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UnitaryValue.Form = null;
            this.UnitaryValue.FormType = null;
            this.UnitaryValue.IsDependecyUkey = false;
            this.UnitaryValue.Location = new System.Drawing.Point(205, 186);
            this.UnitaryValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.UnitaryValue.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.UnitaryValue.Name = "UnitaryValue";
            this.UnitaryValue.ObjectControl = null;
            this.UnitaryValue.ObjetoApp = null;
            this.UnitaryValue.PropertyControl = null;
            this.UnitaryValue.PropertyDependecyUkey = null;
            this.UnitaryValue.Size = new System.Drawing.Size(117, 56);
            this.UnitaryValue.TabIndex = 10;
            this.UnitaryValue.TabStop = false;
            this.UnitaryValue.Text = "UnitaryValue";
            this.UnitaryValue.ThousandsSeparator = false;
            this.UnitaryValue.ToolTipContext = null;
            this.UnitaryValue.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("UnitaryValue.Validations")));
            this.UnitaryValue.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // ValueTotal
            // 
            this.ValueTotal.Caption = "";
            this.ValueTotal.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ValueTotal.CenterCaption = false;
            this.ValueTotal.ComponentBackColor = System.Drawing.Color.White;
            this.ValueTotal.DecimalPlaces = 2;
            this.ValueTotal.Disable = true;
            this.ValueTotal.FieldValid = true;
            this.ValueTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ValueTotal.Form = null;
            this.ValueTotal.FormType = null;
            this.ValueTotal.IsDependecyUkey = false;
            this.ValueTotal.Location = new System.Drawing.Point(328, 186);
            this.ValueTotal.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ValueTotal.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ValueTotal.Name = "ValueTotal";
            this.ValueTotal.ObjectControl = null;
            this.ValueTotal.ObjetoApp = null;
            this.ValueTotal.PropertyControl = null;
            this.ValueTotal.PropertyDependecyUkey = null;
            this.ValueTotal.Size = new System.Drawing.Size(122, 56);
            this.ValueTotal.TabIndex = 9;
            this.ValueTotal.TabStop = false;
            this.ValueTotal.Text = "ValueTotal";
            this.ValueTotal.ThousandsSeparator = false;
            this.ValueTotal.ToolTipContext = null;
            this.ValueTotal.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ValueTotal.Validations")));
            this.ValueTotal.ValueControl = new decimal(new int[] {
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
            this.UnitMeasureId.ComboBoxMultiForms = null;
            this.UnitMeasureId.ComponentBackColor = System.Drawing.Color.White;
            this.UnitMeasureId.DefaultValue = false;
            this.UnitMeasureId.Disable = true;
            this.UnitMeasureId.DisplayMember = "";
            this.UnitMeasureId.FieldValid = true;
            this.UnitMeasureId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UnitMeasureId.Form = null;
            this.UnitMeasureId.FormType = null;
            this.UnitMeasureId.IsDependecyUkey = false;
            this.UnitMeasureId.Location = new System.Drawing.Point(117, 186);
            this.UnitMeasureId.Name = "UnitMeasureId";
            this.UnitMeasureId.ObjectControl = null;
            this.UnitMeasureId.ObjetoApp = null;
            this.UnitMeasureId.PropertyControl = null;
            this.UnitMeasureId.PropertyDependecyUkey = null;
            this.UnitMeasureId.Size = new System.Drawing.Size(82, 56);
            this.UnitMeasureId.StandardValue = null;
            this.UnitMeasureId.TabIndex = 8;
            this.UnitMeasureId.TabStop = false;
            this.UnitMeasureId.Text = "UnitMeasureId";
            this.UnitMeasureId.ToolTipContext = null;
            this.UnitMeasureId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("UnitMeasureId.Validations")));
            this.UnitMeasureId.ValueControl = null;
            this.UnitMeasureId.ValueMember = "";
            // 
            // Quantity
            // 
            this.Quantity.Caption = "";
            this.Quantity.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Quantity.CenterCaption = false;
            this.Quantity.ComponentBackColor = System.Drawing.Color.White;
            this.Quantity.DecimalPlaces = 0;
            this.Quantity.Disable = true;
            this.Quantity.FieldValid = true;
            this.Quantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Quantity.Form = null;
            this.Quantity.FormType = null;
            this.Quantity.IsDependecyUkey = false;
            this.Quantity.Location = new System.Drawing.Point(12, 186);
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
            this.Quantity.Size = new System.Drawing.Size(99, 56);
            this.Quantity.TabIndex = 7;
            this.Quantity.TabStop = false;
            this.Quantity.Text = "Quantity";
            this.Quantity.ThousandsSeparator = false;
            this.Quantity.ToolTipContext = null;
            this.Quantity.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Quantity.Validations")));
            this.Quantity.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // StockItemId
            // 
            this.StockItemId.Caption = "";
            this.StockItemId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.StockItemId.CenterCaption = false;
            this.StockItemId.ComboBoxMultiForms = null;
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
            this.StockItemId.Size = new System.Drawing.Size(438, 58);
            this.StockItemId.StandardValue = null;
            this.StockItemId.TabIndex = 6;
            this.StockItemId.TabStop = false;
            this.StockItemId.Text = "StockItemId";
            this.StockItemId.ToolTipContext = null;
            this.StockItemId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("StockItemId.Validations")));
            this.StockItemId.ValueControl = null;
            this.StockItemId.ValueMember = "";
            // 
            // LocalStockId
            // 
            this.LocalStockId.Caption = "";
            this.LocalStockId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.LocalStockId.CenterCaption = false;
            this.LocalStockId.ComboBoxMultiForms = null;
            this.LocalStockId.ComponentBackColor = System.Drawing.Color.White;
            this.LocalStockId.DefaultValue = false;
            this.LocalStockId.Disable = true;
            this.LocalStockId.DisplayMember = "";
            this.LocalStockId.FieldValid = true;
            this.LocalStockId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LocalStockId.Form = null;
            this.LocalStockId.FormType = null;
            this.LocalStockId.IsDependecyUkey = false;
            this.LocalStockId.Location = new System.Drawing.Point(12, 70);
            this.LocalStockId.Name = "LocalStockId";
            this.LocalStockId.ObjectControl = null;
            this.LocalStockId.ObjetoApp = null;
            this.LocalStockId.PropertyControl = null;
            this.LocalStockId.PropertyDependecyUkey = null;
            this.LocalStockId.Size = new System.Drawing.Size(438, 58);
            this.LocalStockId.StandardValue = null;
            this.LocalStockId.TabIndex = 11;
            this.LocalStockId.TabStop = false;
            this.LocalStockId.Text = "sComboBox1";
            this.LocalStockId.ToolTipContext = null;
            this.LocalStockId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("LocalStockId.Validations")));
            this.LocalStockId.ValueControl = null;
            this.LocalStockId.ValueMember = "";
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
            this.ProviderId.Location = new System.Drawing.Point(12, 134);
            this.ProviderId.Name = "ProviderId";
            this.ProviderId.ObjectControl = null;
            this.ProviderId.ObjetoApp = null;
            this.ProviderId.PropertyControl = null;
            this.ProviderId.PropertyDependecyUkey = null;
            this.ProviderId.Size = new System.Drawing.Size(438, 58);
            this.ProviderId.StandardValue = null;
            this.ProviderId.TabIndex = 12;
            this.ProviderId.TabStop = false;
            this.ProviderId.Text = "sComboBox1";
            this.ProviderId.ToolTipContext = null;
            this.ProviderId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ProviderId.Validations")));
            this.ProviderId.ValueControl = null;
            this.ProviderId.ValueMember = "";
            // 
            // FOsProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(463, 426);
            this.Name = "FOsProduct";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SNumeric UnitaryValue;
        private Core.Component.SNumeric ValueTotal;
        private Core.Component.SComboBox UnitMeasureId;
        private Core.Component.SNumeric Quantity;
        private Core.Component.SComboBox StockItemId;
        private Core.Component.SComboBox LocalStockId;
        private Core.Component.SComboBox ProviderId;
    }
}
