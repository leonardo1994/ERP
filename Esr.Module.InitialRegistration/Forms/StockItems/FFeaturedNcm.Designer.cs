namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    partial class FFeaturedNcm
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFeaturedNcm));
            this.NcmId = new Esr.Core.Component.SComboBox();
            this.Description = new Esr.Core.Component.STextBox();
            this.Code = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NcmId);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.Code);
            this.panel1.Size = new System.Drawing.Size(707, 126);
            // 
            // NcmId
            // 
            this.NcmId.Caption = "";
            this.NcmId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NcmId.CenterCaption = false;
            this.NcmId.ComponentBackColor = System.Drawing.Color.White;
            this.NcmId.DefaultValue = false;
            this.NcmId.Disable = true;
            this.NcmId.DisplayMember = "";
            this.NcmId.FieldValid = true;
            this.NcmId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NcmId.Form = null;
            this.NcmId.FormType = null;
            this.NcmId.IsDependecyUkey = false;
            this.NcmId.Location = new System.Drawing.Point(12, 6);
            this.NcmId.Name = "NcmId";
            this.NcmId.ObjectControl = null;
            this.NcmId.ObjetoApp = null;
            this.NcmId.PropertyControl = null;
            this.NcmId.PropertyDependecyUkey = null;
            this.NcmId.Size = new System.Drawing.Size(683, 54);
            this.NcmId.StandardValue = null;
            this.NcmId.TabIndex = 0;
            this.NcmId.TabStop = false;
            this.NcmId.ToolTipContext = null;
            this.NcmId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NcmId.Validations")));
            this.NcmId.ValueControl = null;
            this.NcmId.ValueMember = "";
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
            this.Description.Location = new System.Drawing.Point(173, 66);
            this.Description.Name = "Description";
            this.Description.ObjectControl = null;
            this.Description.ObjetoApp = null;
            this.Description.PropertyControl = null;
            this.Description.PropertyDependecyUkey = null;
            this.Description.Size = new System.Drawing.Size(522, 53);
            this.Description.TabIndex = 3;
            this.Description.TabStop = false;
            this.Description.Text = "sTextBox2";
            this.Description.ToolTipContext = null;
            this.Description.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Description.Validations")));
            this.Description.ValueControl = "";
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
            this.Code.Location = new System.Drawing.Point(12, 66);
            this.Code.Name = "Code";
            this.Code.ObjectControl = null;
            this.Code.ObjetoApp = null;
            this.Code.PropertyControl = null;
            this.Code.PropertyDependecyUkey = null;
            this.Code.Size = new System.Drawing.Size(155, 53);
            this.Code.TabIndex = 1;
            this.Code.TabStop = false;
            this.Code.ToolTipContext = null;
            this.Code.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Code.Validations")));
            this.Code.ValueControl = "";
            // 
            // FFeaturedNcm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(707, 290);
            this.Name = "FFeaturedNcm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SComboBox NcmId;
        private Core.Component.STextBox Description;
        private Core.Component.STextBox Code;
    }
}
