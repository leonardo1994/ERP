namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    partial class FLocalStock
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLocalStock));
            this.LocalCode = new Esr.Core.Component.STextBox();
            this.LocalName = new Esr.Core.Component.STextBox();
            this.TypeStructure = new Esr.Core.Component.SComboBox();
            this.LocalStocks = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LocalStocks);
            this.panel1.Controls.Add(this.TypeStructure);
            this.panel1.Controls.Add(this.LocalName);
            this.panel1.Controls.Add(this.LocalCode);
            this.panel1.Size = new System.Drawing.Size(623, 327);
            // 
            // LocalCode
            // 
            this.LocalCode.Caption = "";
            this.LocalCode.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.LocalCode.CenterCaption = false;
            this.LocalCode.ComponentBackColor = System.Drawing.Color.White;
            this.LocalCode.Disable = true;
            this.LocalCode.FieldValid = true;
            this.LocalCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LocalCode.Form = null;
            this.LocalCode.FormType = null;
            this.LocalCode.IsDependecyUkey = false;
            this.LocalCode.Location = new System.Drawing.Point(12, 6);
            this.LocalCode.Name = "LocalCode";
            this.LocalCode.ObjectControl = null;
            this.LocalCode.ObjetoApp = null;
            this.LocalCode.PropertyControl = null;
            this.LocalCode.PropertyDependecyUkey = null;
            this.LocalCode.Size = new System.Drawing.Size(177, 56);
            this.LocalCode.TabIndex = 0;
            this.LocalCode.TabStop = false;
            this.LocalCode.Text = "sTextBox1";
            this.LocalCode.ToolTipContext = null;
            this.LocalCode.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("LocalCode.Validations")));
            this.LocalCode.ValueControl = "";
            // 
            // LocalName
            // 
            this.LocalName.Caption = "";
            this.LocalName.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.LocalName.CenterCaption = false;
            this.LocalName.ComponentBackColor = System.Drawing.Color.White;
            this.LocalName.Disable = true;
            this.LocalName.FieldValid = true;
            this.LocalName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LocalName.Form = null;
            this.LocalName.FormType = null;
            this.LocalName.IsDependecyUkey = false;
            this.LocalName.Location = new System.Drawing.Point(15, 68);
            this.LocalName.Name = "LocalName";
            this.LocalName.ObjectControl = null;
            this.LocalName.ObjetoApp = null;
            this.LocalName.PropertyControl = null;
            this.LocalName.PropertyDependecyUkey = null;
            this.LocalName.Size = new System.Drawing.Size(596, 56);
            this.LocalName.TabIndex = 3;
            this.LocalName.TabStop = false;
            this.LocalName.Text = "sTextBox1";
            this.LocalName.ToolTipContext = null;
            this.LocalName.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("LocalName.Validations")));
            this.LocalName.ValueControl = "";
            // 
            // TypeStructure
            // 
            this.TypeStructure.Caption = "";
            this.TypeStructure.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypeStructure.CenterCaption = false;
            this.TypeStructure.ComponentBackColor = System.Drawing.Color.White;
            this.TypeStructure.DefaultValue = false;
            this.TypeStructure.Disable = true;
            this.TypeStructure.DisplayMember = "";
            this.TypeStructure.FieldValid = true;
            this.TypeStructure.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeStructure.Form = null;
            this.TypeStructure.FormType = null;
            this.TypeStructure.IsDependecyUkey = false;
            this.TypeStructure.Location = new System.Drawing.Point(431, 6);
            this.TypeStructure.Name = "TypeStructure";
            this.TypeStructure.ObjectControl = null;
            this.TypeStructure.ObjetoApp = null;
            this.TypeStructure.PropertyControl = null;
            this.TypeStructure.PropertyDependecyUkey = null;
            this.TypeStructure.Size = new System.Drawing.Size(174, 56);
            this.TypeStructure.StandardValue = null;
            this.TypeStructure.TabIndex = 1;
            this.TypeStructure.TabStop = false;
            this.TypeStructure.Text = "sComboBox1";
            this.TypeStructure.ToolTipContext = null;
            this.TypeStructure.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TypeStructure.Validations")));
            this.TypeStructure.ValueControl = null;
            this.TypeStructure.ValueMember = "";
            // 
            // LocalStocks
            // 
            this.LocalStocks.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.LocalStocks.Caption = "";
            this.LocalStocks.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.LocalStocks.CenterCaption = false;
            this.LocalStocks.ComponentBackColor = System.Drawing.Color.White;
            this.LocalStocks.Disable = true;
            this.LocalStocks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LocalStocks.FieldValid = true;
            this.LocalStocks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LocalStocks.Form = null;
            this.LocalStocks.FormType = null;
            this.LocalStocks.IsDependecyUkey = false;
            this.LocalStocks.IsSearch = false;
            this.LocalStocks.ListColunas = null;
            this.LocalStocks.Location = new System.Drawing.Point(0, 133);
            this.LocalStocks.Name = "LocalStocks";
            this.LocalStocks.ObjectControl = null;
            this.LocalStocks.ObjetoApp = null;
            this.LocalStocks.PropertyControl = null;
            this.LocalStocks.PropertyDependecyUkey = null;
            this.LocalStocks.PropertyInfos = null;
            this.LocalStocks.ScreenSecondary = false;
            this.LocalStocks.Size = new System.Drawing.Size(623, 194);
            this.LocalStocks.TabIndex = 4;
            this.LocalStocks.TabStop = false;
            this.LocalStocks.Text = "sGrid1";
            this.LocalStocks.ToolTipContext = null;
            this.LocalStocks.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("LocalStocks.Validations")));
            this.LocalStocks.ValueControl = null;
            // 
            // FLocalStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(623, 491);
            this.Name = "FLocalStock";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox LocalCode;
        private Core.Component.STextBox LocalName;
        private Core.Component.SComboBox TypeStructure;
        private Core.Component.SGrid LocalStocks;
    }
}
