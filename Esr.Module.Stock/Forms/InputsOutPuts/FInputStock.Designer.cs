namespace Esr.Module.Stock.Forms.InputsOutPuts
{
    partial class FInputStock
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInputStock));
            this.Code = new Esr.Core.Component.STextBox();
            this.DateInput = new Esr.Core.Component.SDateTimePicker();
            this.ProviderId = new Esr.Core.Component.SComboBox();
            this.ItemInputStocks = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ItemInputStocks);
            this.panel1.Controls.Add(this.ProviderId);
            this.panel1.Controls.Add(this.DateInput);
            this.panel1.Controls.Add(this.Code);
            this.panel1.Size = new System.Drawing.Size(614, 326);
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
            this.Code.Size = new System.Drawing.Size(155, 55);
            this.Code.TabIndex = 0;
            this.Code.TabStop = false;
            this.Code.Text = "sTextBox1";
            this.Code.ToolTipContext = null;
            this.Code.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Code.Validations")));
            this.Code.ValueControl = "";
            // 
            // DateInput
            // 
            this.DateInput.Caption = "";
            this.DateInput.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DateInput.CenterCaption = false;
            this.DateInput.ComponentBackColor = System.Drawing.Color.White;
            this.DateInput.Disable = true;
            this.DateInput.FieldValid = true;
            this.DateInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DateInput.Form = null;
            this.DateInput.FormType = null;
            this.DateInput.IsDependecyUkey = false;
            this.DateInput.Location = new System.Drawing.Point(173, 6);
            this.DateInput.Name = "DateInput";
            this.DateInput.ObjectControl = null;
            this.DateInput.ObjetoApp = null;
            this.DateInput.PropertyControl = null;
            this.DateInput.PropertyDependecyUkey = null;
            this.DateInput.Size = new System.Drawing.Size(429, 55);
            this.DateInput.TabIndex = 1;
            this.DateInput.TabStop = false;
            this.DateInput.Text = "sDateTimePicker1";
            this.DateInput.ToolTipContext = null;
            this.DateInput.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("DateInput.Validations")));
            this.DateInput.ValueControl = new System.DateTime(2016, 11, 25, 19, 18, 39, 353);
            // 
            // ProviderId
            // 
            this.ProviderId.Caption = "";
            this.ProviderId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ProviderId.CenterCaption = false;
            this.ProviderId.ComponentBackColor = System.Drawing.Color.White;
            this.ProviderId.DefaultValue = false;
            this.ProviderId.Disable = true;
            this.ProviderId.DisplayMember = "";
            this.ProviderId.FieldValid = true;
            this.ProviderId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProviderId.Form = null;
            this.ProviderId.FormType = null;
            this.ProviderId.IsDependecyUkey = false;
            this.ProviderId.Location = new System.Drawing.Point(12, 67);
            this.ProviderId.Name = "ProviderId";
            this.ProviderId.ObjectControl = null;
            this.ProviderId.ObjetoApp = null;
            this.ProviderId.PropertyControl = null;
            this.ProviderId.PropertyDependecyUkey = null;
            this.ProviderId.Size = new System.Drawing.Size(590, 54);
            this.ProviderId.StandardValue = null;
            this.ProviderId.TabIndex = 2;
            this.ProviderId.TabStop = false;
            this.ProviderId.Text = "sComboBox1";
            this.ProviderId.ToolTipContext = null;
            this.ProviderId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ProviderId.Validations")));
            this.ProviderId.ValueControl = null;
            this.ProviderId.ValueMember = "";
            // 
            // ItemInputStocks
            // 
            this.ItemInputStocks.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.ItemInputStocks.Caption = "";
            this.ItemInputStocks.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ItemInputStocks.CenterCaption = false;
            this.ItemInputStocks.ComponentBackColor = System.Drawing.Color.White;
            this.ItemInputStocks.Disable = true;
            this.ItemInputStocks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemInputStocks.FieldValid = true;
            this.ItemInputStocks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ItemInputStocks.Form = null;
            this.ItemInputStocks.FormType = null;
            this.ItemInputStocks.IsDependecyUkey = false;
            this.ItemInputStocks.IsSearch = false;
            this.ItemInputStocks.ListColunas = null;
            this.ItemInputStocks.Location = new System.Drawing.Point(0, 130);
            this.ItemInputStocks.Name = "ItemInputStocks";
            this.ItemInputStocks.ObjectControl = null;
            this.ItemInputStocks.ObjetoApp = null;
            this.ItemInputStocks.PropertyControl = null;
            this.ItemInputStocks.PropertyDependecyUkey = null;
            this.ItemInputStocks.PropertyInfos = null;
            this.ItemInputStocks.ScreenSecondary = false;
            this.ItemInputStocks.Size = new System.Drawing.Size(614, 196);
            this.ItemInputStocks.TabIndex = 3;
            this.ItemInputStocks.TabStop = false;
            this.ItemInputStocks.Text = "sGrid1";
            this.ItemInputStocks.ToolTipContext = null;
            this.ItemInputStocks.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ItemInputStocks.Validations")));
            this.ItemInputStocks.ValueControl = null;
            // 
            // FInputStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(614, 490);
            this.Name = "FInputStock";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox Code;
        private Core.Component.SDateTimePicker DateInput;
        private Core.Component.SComboBox ProviderId;
        private Core.Component.SGrid ItemInputStocks;
    }
}
