namespace Esr.Module.Stock.Forms.InputsOutPuts
{
    partial class FOutputStock
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOutputStock));
            this.Code = new Esr.Core.Component.STextBox();
            this.DateInput = new Esr.Core.Component.SDateTimePicker();
            this.PersonId = new Esr.Core.Component.SComboBox();
            this.ItemOutputStocks = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ItemOutputStocks);
            this.panel1.Controls.Add(this.PersonId);
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
            this.DateInput.CustomFormat = null;
            this.DateInput.Disable = true;
            this.DateInput.FieldValid = true;
            this.DateInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DateInput.Form = null;
            this.DateInput.Format = System.Windows.Forms.DateTimePickerFormat.Long;
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
            // PersonId
            // 
            this.PersonId.Caption = "";
            this.PersonId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.PersonId.CenterCaption = false;
            this.PersonId.ComboBoxMultiForms = null;
            this.PersonId.ComponentBackColor = System.Drawing.Color.White;
            this.PersonId.DefaultValue = false;
            this.PersonId.Disable = true;
            this.PersonId.DisplayMember = "";
            this.PersonId.FieldValid = true;
            this.PersonId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PersonId.Form = null;
            this.PersonId.FormType = null;
            this.PersonId.IsDependecyUkey = false;
            this.PersonId.Location = new System.Drawing.Point(12, 67);
            this.PersonId.Name = "PersonId";
            this.PersonId.ObjectControl = null;
            this.PersonId.ObjetoApp = null;
            this.PersonId.PropertyControl = null;
            this.PersonId.PropertyDependecyUkey = null;
            this.PersonId.Size = new System.Drawing.Size(590, 54);
            this.PersonId.StandardValue = null;
            this.PersonId.TabIndex = 2;
            this.PersonId.TabStop = false;
            this.PersonId.Text = "sComboBox1";
            this.PersonId.ToolTipContext = null;
            this.PersonId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("PersonId.Validations")));
            this.PersonId.ValueControl = null;
            this.PersonId.ValueMember = "";
            // 
            // ItemOutputStocks
            // 
            this.ItemOutputStocks.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.ItemOutputStocks.Caption = "";
            this.ItemOutputStocks.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ItemOutputStocks.CenterCaption = false;
            this.ItemOutputStocks.ComponentBackColor = System.Drawing.Color.White;
            this.ItemOutputStocks.Disable = true;
            this.ItemOutputStocks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemOutputStocks.FieldValid = true;
            this.ItemOutputStocks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ItemOutputStocks.Form = null;
            this.ItemOutputStocks.FormType = null;
            this.ItemOutputStocks.IsDependecyUkey = false;
            this.ItemOutputStocks.IsSearch = false;
            this.ItemOutputStocks.ListColunas = null;
            this.ItemOutputStocks.Location = new System.Drawing.Point(0, 130);
            this.ItemOutputStocks.Name = "ItemOutputStocks";
            this.ItemOutputStocks.ObjectControl = null;
            this.ItemOutputStocks.ObjetoApp = null;
            this.ItemOutputStocks.PropertyControl = null;
            this.ItemOutputStocks.PropertyDependecyUkey = null;
            this.ItemOutputStocks.PropertyInfos = null;
            this.ItemOutputStocks.ScreenSecondary = false;
            this.ItemOutputStocks.Size = new System.Drawing.Size(614, 196);
            this.ItemOutputStocks.TabIndex = 3;
            this.ItemOutputStocks.TabStop = false;
            this.ItemOutputStocks.Text = "sGrid1";
            this.ItemOutputStocks.ToolTipContext = null;
            this.ItemOutputStocks.Validations = null;
            this.ItemOutputStocks.ValueControl = null;
            // 
            // FOutputStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(614, 490);
            this.Name = "FOutputStock";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox Code;
        private Core.Component.SDateTimePicker DateInput;
        private Core.Component.SComboBox PersonId;
        private Core.Component.SGrid ItemOutputStocks;
    }
}
