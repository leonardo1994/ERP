namespace Esr.Module.InitialRegistration.Forms.Address
{
    partial class FCountry
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCountry));
            this.Initials = new Esr.Core.Component.STextBox();
            this.CountryName = new Esr.Core.Component.STextBox();
            this.CodeIbge = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CodeIbge);
            this.panel1.Controls.Add(this.Initials);
            this.panel1.Controls.Add(this.CountryName);
            this.panel1.Size = new System.Drawing.Size(647, 85);
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
            this.Initials.Location = new System.Drawing.Point(9, 12);
            this.Initials.Name = "Initials";
            this.Initials.ObjectControl = null;
            this.Initials.ObjetoApp = null;
            this.Initials.PropertyControl = null;
            this.Initials.PropertyDependecyUkey = null;
            this.Initials.Size = new System.Drawing.Size(150, 52);
            this.Initials.TabIndex = 5;
            this.Initials.TabStop = false;
            this.Initials.ToolTipContext = null;
            this.Initials.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Initials.Validations")));
            this.Initials.ValueControl = "";
            // 
            // CountryName
            // 
            this.CountryName.Caption = "";
            this.CountryName.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.CountryName.CenterCaption = false;
            this.CountryName.ComponentBackColor = System.Drawing.Color.White;
            this.CountryName.Disable = true;
            this.CountryName.FieldValid = true;
            this.CountryName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CountryName.Form = null;
            this.CountryName.FormType = null;
            this.CountryName.IsDependecyUkey = false;
            this.CountryName.Location = new System.Drawing.Point(165, 12);
            this.CountryName.Name = "CountryName";
            this.CountryName.ObjectControl = null;
            this.CountryName.ObjetoApp = null;
            this.CountryName.PropertyControl = null;
            this.CountryName.PropertyDependecyUkey = null;
            this.CountryName.Size = new System.Drawing.Size(314, 51);
            this.CountryName.TabIndex = 6;
            this.CountryName.TabStop = false;
            this.CountryName.Text = "sTextBox1";
            this.CountryName.ToolTipContext = null;
            this.CountryName.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("CountryName.Validations")));
            this.CountryName.ValueControl = "";
            // 
            // CodeIbge
            // 
            this.CodeIbge.Caption = "";
            this.CodeIbge.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.CodeIbge.CenterCaption = false;
            this.CodeIbge.ComponentBackColor = System.Drawing.Color.White;
            this.CodeIbge.Disable = true;
            this.CodeIbge.FieldValid = true;
            this.CodeIbge.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CodeIbge.Form = null;
            this.CodeIbge.FormType = null;
            this.CodeIbge.IsDependecyUkey = false;
            this.CodeIbge.Location = new System.Drawing.Point(485, 12);
            this.CodeIbge.Name = "CodeIbge";
            this.CodeIbge.ObjectControl = null;
            this.CodeIbge.ObjetoApp = null;
            this.CodeIbge.PropertyControl = null;
            this.CodeIbge.PropertyDependecyUkey = null;
            this.CodeIbge.Size = new System.Drawing.Size(150, 52);
            this.CodeIbge.TabIndex = 7;
            this.CodeIbge.TabStop = false;
            this.CodeIbge.ToolTipContext = null;
            this.CodeIbge.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("CodeIbge.Validations")));
            this.CodeIbge.ValueControl = "";
            // 
            // FCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(647, 249);
            this.Name = "FCountry";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox Initials;
        private Core.Component.STextBox CountryName;
        private Core.Component.STextBox CodeIbge;
    }
}
