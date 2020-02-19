namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    partial class FNcm
    {
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNcm));
            this.FeaturedNcms = new Esr.Core.Component.SGrid();
            this.NcmName = new Esr.Core.Component.STextBox();
            this.NcmCode = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FeaturedNcms);
            this.panel1.Controls.Add(this.NcmName);
            this.panel1.Controls.Add(this.NcmCode);
            this.panel1.Size = new System.Drawing.Size(523, 258);
            // 
            // FeaturedNcms
            // 
            this.FeaturedNcms.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.FeaturedNcms.Caption = "";
            this.FeaturedNcms.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FeaturedNcms.CenterCaption = false;
            this.FeaturedNcms.ComponentBackColor = System.Drawing.Color.White;
            this.FeaturedNcms.Disable = true;
            this.FeaturedNcms.FieldValid = true;
            this.FeaturedNcms.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FeaturedNcms.Form = null;
            this.FeaturedNcms.FormType = null;
            this.FeaturedNcms.IsDependecyUkey = false;
            this.FeaturedNcms.IsSearch = false;
            this.FeaturedNcms.ListColunas = null;
            this.FeaturedNcms.Location = new System.Drawing.Point(12, 67);
            this.FeaturedNcms.Name = "FeaturedNcms";
            this.FeaturedNcms.ObjectControl = null;
            this.FeaturedNcms.ObjetoApp = null;
            this.FeaturedNcms.PropertyControl = null;
            this.FeaturedNcms.PropertyDependecyUkey = null;
            this.FeaturedNcms.PropertyInfos = null;
            this.FeaturedNcms.ScreenSecondary = false;
            this.FeaturedNcms.Size = new System.Drawing.Size(499, 185);
            this.FeaturedNcms.TabIndex = 2;
            this.FeaturedNcms.TabStop = false;
            this.FeaturedNcms.ToolTipContext = null;
            this.FeaturedNcms.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FeaturedNcms.Validations")));
            this.FeaturedNcms.ValueControl = null;
            // 
            // NcmName
            // 
            this.NcmName.Caption = "";
            this.NcmName.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NcmName.CenterCaption = false;
            this.NcmName.ComponentBackColor = System.Drawing.Color.White;
            this.NcmName.Disable = true;
            this.NcmName.FieldValid = true;
            this.NcmName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NcmName.Form = null;
            this.NcmName.FormType = null;
            this.NcmName.IsDependecyUkey = false;
            this.NcmName.Location = new System.Drawing.Point(180, 6);
            this.NcmName.Name = "NcmName";
            this.NcmName.ObjectControl = null;
            this.NcmName.ObjetoApp = null;
            this.NcmName.PropertyControl = null;
            this.NcmName.PropertyDependecyUkey = null;
            this.NcmName.Size = new System.Drawing.Size(331, 55);
            this.NcmName.TabIndex = 1;
            this.NcmName.TabStop = false;
            this.NcmName.ToolTipContext = null;
            this.NcmName.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NcmName.Validations")));
            this.NcmName.ValueControl = "";
            // 
            // NcmCode
            // 
            this.NcmCode.Caption = "";
            this.NcmCode.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NcmCode.CenterCaption = false;
            this.NcmCode.ComponentBackColor = System.Drawing.Color.White;
            this.NcmCode.Disable = true;
            this.NcmCode.FieldValid = true;
            this.NcmCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NcmCode.Form = null;
            this.NcmCode.FormType = null;
            this.NcmCode.IsDependecyUkey = false;
            this.NcmCode.Location = new System.Drawing.Point(12, 6);
            this.NcmCode.Name = "NcmCode";
            this.NcmCode.ObjectControl = null;
            this.NcmCode.ObjetoApp = null;
            this.NcmCode.PropertyControl = null;
            this.NcmCode.PropertyDependecyUkey = null;
            this.NcmCode.Size = new System.Drawing.Size(162, 55);
            this.NcmCode.TabIndex = 0;
            this.NcmCode.TabStop = false;
            this.NcmCode.ToolTipContext = null;
            this.NcmCode.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NcmCode.Validations")));
            this.NcmCode.ValueControl = "";
            // 
            // FNcm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(523, 422);
            this.Name = "FNcm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SGrid FeaturedNcms;
        private Core.Component.STextBox NcmName;
        private Core.Component.STextBox NcmCode;
    }
}
