namespace Esr.Module.Stock.Forms.InputsOutPuts
{
    partial class FItemOutputStock
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FItemInputStock));
            this.Date = new Esr.Core.Component.SDateTimePicker();
            this.LocalStockId = new Esr.Core.Component.SComboBox();
            this.StockItemId = new Esr.Core.Component.SComboBox();
            this.Quantity = new Esr.Core.Component.SNumeric();
            this.UnitMeasureId = new Esr.Core.Component.SComboBox();
            this.UnitaryValue = new Esr.Core.Component.SNumeric();
            this.Total = new Esr.Core.Component.SNumeric();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Total);
            this.panel1.Controls.Add(this.UnitaryValue);
            this.panel1.Controls.Add(this.UnitMeasureId);
            this.panel1.Controls.Add(this.Quantity);
            this.panel1.Controls.Add(this.StockItemId);
            this.panel1.Controls.Add(this.LocalStockId);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Size = new System.Drawing.Size(484, 259);
            // 
            // Date
            // 
            this.Date.Caption = "";
            this.Date.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Date.CenterCaption = false;
            this.Date.ComponentBackColor = System.Drawing.Color.White;
            this.Date.Disable = true;
            this.Date.FieldValid = true;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Date.Form = null;
            this.Date.FormType = null;
            this.Date.IsDependecyUkey = false;
            this.Date.Location = new System.Drawing.Point(12, 6);
            this.Date.Name = "Date";
            this.Date.ObjectControl = null;
            this.Date.ObjetoApp = null;
            this.Date.PropertyControl = null;
            this.Date.PropertyDependecyUkey = null;
            this.Date.Size = new System.Drawing.Size(462, 57);
            this.Date.TabIndex = 0;
            this.Date.TabStop = false;
            this.Date.Text = "sDateTimePicker1";
            this.Date.ToolTipContext = null;
            this.Date.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Date.Validations")));
            this.Date.ValueControl = new System.DateTime(2016, 11, 25, 19, 21, 27, 416);
            // 
            // LocalStockId
            // 
            this.LocalStockId.Caption = "";
            this.LocalStockId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.LocalStockId.CenterCaption = false;
            this.LocalStockId.ComponentBackColor = System.Drawing.Color.White;
            this.LocalStockId.DefaultValue = false;
            this.LocalStockId.Disable = true;
            this.LocalStockId.DisplayMember = "";
            this.LocalStockId.FieldValid = true;
            this.LocalStockId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LocalStockId.Form = null;
            this.LocalStockId.FormType = null;
            this.LocalStockId.IsDependecyUkey = false;
            this.LocalStockId.Location = new System.Drawing.Point(12, 69);
            this.LocalStockId.Name = "LocalStockId";
            this.LocalStockId.ObjectControl = null;
            this.LocalStockId.ObjetoApp = null;
            this.LocalStockId.PropertyControl = null;
            this.LocalStockId.PropertyDependecyUkey = null;
            this.LocalStockId.Size = new System.Drawing.Size(460, 56);
            this.LocalStockId.StandardValue = null;
            this.LocalStockId.TabIndex = 1;
            this.LocalStockId.TabStop = false;
            this.LocalStockId.Text = "sComboBox1";
            this.LocalStockId.ToolTipContext = null;
            this.LocalStockId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("LocalStockId.Validations")));
            this.LocalStockId.ValueControl = null;
            this.LocalStockId.ValueMember = "";
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
            this.StockItemId.Location = new System.Drawing.Point(12, 131);
            this.StockItemId.Name = "StockItemId";
            this.StockItemId.ObjectControl = null;
            this.StockItemId.ObjetoApp = null;
            this.StockItemId.PropertyControl = null;
            this.StockItemId.PropertyDependecyUkey = null;
            this.StockItemId.Size = new System.Drawing.Size(460, 54);
            this.StockItemId.StandardValue = null;
            this.StockItemId.TabIndex = 2;
            this.StockItemId.TabStop = false;
            this.StockItemId.Text = "sComboBox1";
            this.StockItemId.ToolTipContext = null;
            this.StockItemId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("StockItemId.Validations")));
            this.StockItemId.ValueControl = null;
            this.StockItemId.ValueMember = "";
            // 
            // Quantity
            // 
            this.Quantity.Caption = "";
            this.Quantity.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Quantity.CenterCaption = false;
            this.Quantity.ComponentBackColor = System.Drawing.Color.White;
            this.Quantity.DecimalPlaces = 3;
            this.Quantity.Disable = true;
            this.Quantity.FieldValid = true;
            this.Quantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Quantity.Form = null;
            this.Quantity.FormType = null;
            this.Quantity.IsDependecyUkey = false;
            this.Quantity.Location = new System.Drawing.Point(12, 191);
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
            this.Quantity.Size = new System.Drawing.Size(103, 54);
            this.Quantity.TabIndex = 3;
            this.Quantity.TabStop = false;
            this.Quantity.Text = "sNumeric1";
            this.Quantity.ThousandsSeparator = true;
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
            this.UnitMeasureId.Location = new System.Drawing.Point(121, 191);
            this.UnitMeasureId.Name = "UnitMeasureId";
            this.UnitMeasureId.ObjectControl = null;
            this.UnitMeasureId.ObjetoApp = null;
            this.UnitMeasureId.PropertyControl = null;
            this.UnitMeasureId.PropertyDependecyUkey = null;
            this.UnitMeasureId.Size = new System.Drawing.Size(89, 54);
            this.UnitMeasureId.StandardValue = null;
            this.UnitMeasureId.TabIndex = 4;
            this.UnitMeasureId.TabStop = false;
            this.UnitMeasureId.Text = "sComboBox1";
            this.UnitMeasureId.ToolTipContext = null;
            this.UnitMeasureId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("UnitMeasureId.Validations")));
            this.UnitMeasureId.ValueControl = null;
            this.UnitMeasureId.ValueMember = "";
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
            this.UnitaryValue.Location = new System.Drawing.Point(216, 191);
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
            this.UnitaryValue.Size = new System.Drawing.Size(126, 54);
            this.UnitaryValue.TabIndex = 5;
            this.UnitaryValue.TabStop = false;
            this.UnitaryValue.Text = "sNumeric1";
            this.UnitaryValue.ThousandsSeparator = true;
            this.UnitaryValue.ToolTipContext = null;
            this.UnitaryValue.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("UnitaryValue.Validations")));
            this.UnitaryValue.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Total
            // 
            this.Total.Caption = "";
            this.Total.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Total.CenterCaption = false;
            this.Total.ComponentBackColor = System.Drawing.Color.White;
            this.Total.DecimalPlaces = 2;
            this.Total.Disable = true;
            this.Total.FieldValid = true;
            this.Total.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Total.Form = null;
            this.Total.FormType = null;
            this.Total.IsDependecyUkey = false;
            this.Total.Location = new System.Drawing.Point(348, 191);
            this.Total.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Total.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Total.Name = "Total";
            this.Total.ObjectControl = null;
            this.Total.ObjetoApp = null;
            this.Total.PropertyControl = null;
            this.Total.PropertyDependecyUkey = null;
            this.Total.Size = new System.Drawing.Size(124, 54);
            this.Total.TabIndex = 6;
            this.Total.TabStop = false;
            this.Total.Text = "sNumeric2";
            this.Total.ThousandsSeparator = true;
            this.Total.ToolTipContext = null;
            this.Total.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Total.Validations")));
            this.Total.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // FItemInputStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(484, 423);
            this.Name = "FItemInputStock";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SDateTimePicker Date;
        private Core.Component.SComboBox LocalStockId;
        private Core.Component.SComboBox StockItemId;
        private Core.Component.SNumeric Quantity;
        private Core.Component.SComboBox UnitMeasureId;
        private Core.Component.SNumeric UnitaryValue;
        private Core.Component.SNumeric Total;
    }
}
