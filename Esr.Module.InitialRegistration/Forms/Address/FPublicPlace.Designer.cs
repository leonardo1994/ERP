namespace Esr.Module.InitialRegistration.Forms.Address
{
    partial class FPublicPlace
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPublicPlace));
            this.ZipCode = new Esr.Core.Component.STextBox();
            this.Street = new Esr.Core.Component.STextBox();
            this.Neighborhood = new Esr.Core.Component.STextBox();
            this.CityId = new Esr.Core.Component.SComboBox();
            this.StateId = new Esr.Core.Component.SComboBox();
            this.CountryId = new Esr.Core.Component.SComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CountryId);
            this.panel1.Controls.Add(this.StateId);
            this.panel1.Controls.Add(this.CityId);
            this.panel1.Controls.Add(this.Neighborhood);
            this.panel1.Controls.Add(this.Street);
            this.panel1.Controls.Add(this.ZipCode);
            this.panel1.Size = new System.Drawing.Size(599, 193);
            // 
            // ZipCode
            // 
            this.ZipCode.Caption = "";
            this.ZipCode.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ZipCode.CenterCaption = false;
            this.ZipCode.ComponentBackColor = System.Drawing.Color.White;
            this.ZipCode.Disable = true;
            this.ZipCode.FieldValid = true;
            this.ZipCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ZipCode.Form = null;
            this.ZipCode.FormType = null;
            this.ZipCode.IsDependecyUkey = false;
            this.ZipCode.Location = new System.Drawing.Point(12, 6);
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.ObjectControl = null;
            this.ZipCode.ObjetoApp = null;
            this.ZipCode.PropertyControl = null;
            this.ZipCode.PropertyDependecyUkey = null;
            this.ZipCode.Size = new System.Drawing.Size(146, 55);
            this.ZipCode.TabIndex = 0;
            this.ZipCode.TabStop = false;
            this.ZipCode.Text = "sTextBox1";
            this.ZipCode.ToolTipContext = null;
            this.ZipCode.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ZipCode.Validations")));
            this.ZipCode.ValueControl = "";
            // 
            // Street
            // 
            this.Street.Caption = "";
            this.Street.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Street.CenterCaption = false;
            this.Street.ComponentBackColor = System.Drawing.Color.White;
            this.Street.Disable = true;
            this.Street.FieldValid = true;
            this.Street.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Street.Form = null;
            this.Street.FormType = null;
            this.Street.IsDependecyUkey = false;
            this.Street.Location = new System.Drawing.Point(164, 6);
            this.Street.Name = "Street";
            this.Street.ObjectControl = null;
            this.Street.ObjetoApp = null;
            this.Street.PropertyControl = null;
            this.Street.PropertyDependecyUkey = null;
            this.Street.Size = new System.Drawing.Size(425, 55);
            this.Street.TabIndex = 1;
            this.Street.TabStop = false;
            this.Street.Text = "sTextBox2";
            this.Street.ToolTipContext = null;
            this.Street.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Street.Validations")));
            this.Street.ValueControl = "";
            // 
            // Neighborhood
            // 
            this.Neighborhood.Caption = "";
            this.Neighborhood.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Neighborhood.CenterCaption = false;
            this.Neighborhood.ComponentBackColor = System.Drawing.Color.White;
            this.Neighborhood.Disable = true;
            this.Neighborhood.FieldValid = true;
            this.Neighborhood.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Neighborhood.Form = null;
            this.Neighborhood.FormType = null;
            this.Neighborhood.IsDependecyUkey = false;
            this.Neighborhood.Location = new System.Drawing.Point(12, 67);
            this.Neighborhood.Name = "Neighborhood";
            this.Neighborhood.ObjectControl = null;
            this.Neighborhood.ObjetoApp = null;
            this.Neighborhood.PropertyControl = null;
            this.Neighborhood.PropertyDependecyUkey = null;
            this.Neighborhood.Size = new System.Drawing.Size(577, 55);
            this.Neighborhood.TabIndex = 2;
            this.Neighborhood.TabStop = false;
            this.Neighborhood.Text = "sTextBox3";
            this.Neighborhood.ToolTipContext = null;
            this.Neighborhood.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Neighborhood.Validations")));
            this.Neighborhood.ValueControl = "";
            // 
            // CityId
            // 
            this.CityId.Caption = "";
            this.CityId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.CityId.CenterCaption = false;
            this.CityId.ComponentBackColor = System.Drawing.Color.White;
            this.CityId.DefaultValue = false;
            this.CityId.Disable = true;
            this.CityId.DisplayMember = "";
            this.CityId.FieldValid = true;
            this.CityId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CityId.Form = null;
            this.CityId.FormType = null;
            this.CityId.IsDependecyUkey = false;
            this.CityId.Location = new System.Drawing.Point(208, 128);
            this.CityId.Name = "CityId";
            this.CityId.ObjectControl = null;
            this.CityId.ObjetoApp = null;
            this.CityId.PropertyControl = null;
            this.CityId.PropertyDependecyUkey = null;
            this.CityId.Size = new System.Drawing.Size(381, 55);
            this.CityId.StandardValue = null;
            this.CityId.TabIndex = 3;
            this.CityId.TabStop = false;
            this.CityId.Text = "sComboBox1";
            this.CityId.ToolTipContext = null;
            this.CityId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("CityId.Validations")));
            this.CityId.ValueControl = null;
            this.CityId.ValueMember = "";
            // 
            // StateId
            // 
            this.StateId.Caption = "";
            this.StateId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.StateId.CenterCaption = false;
            this.StateId.ComponentBackColor = System.Drawing.Color.White;
            this.StateId.DefaultValue = false;
            this.StateId.Disable = true;
            this.StateId.DisplayMember = "";
            this.StateId.FieldValid = true;
            this.StateId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StateId.Form = null;
            this.StateId.FormType = null;
            this.StateId.IsDependecyUkey = false;
            this.StateId.Location = new System.Drawing.Point(110, 128);
            this.StateId.Name = "StateId";
            this.StateId.ObjectControl = null;
            this.StateId.ObjetoApp = null;
            this.StateId.PropertyControl = null;
            this.StateId.PropertyDependecyUkey = null;
            this.StateId.Size = new System.Drawing.Size(92, 55);
            this.StateId.StandardValue = null;
            this.StateId.TabIndex = 4;
            this.StateId.TabStop = false;
            this.StateId.Text = "sComboBox2";
            this.StateId.ToolTipContext = null;
            this.StateId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("StateId.Validations")));
            this.StateId.ValueControl = null;
            this.StateId.ValueMember = "";
            // 
            // CountryId
            // 
            this.CountryId.Caption = "";
            this.CountryId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.CountryId.CenterCaption = false;
            this.CountryId.ComponentBackColor = System.Drawing.Color.White;
            this.CountryId.DefaultValue = false;
            this.CountryId.Disable = true;
            this.CountryId.DisplayMember = "";
            this.CountryId.FieldValid = true;
            this.CountryId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CountryId.Form = null;
            this.CountryId.FormType = null;
            this.CountryId.IsDependecyUkey = false;
            this.CountryId.Location = new System.Drawing.Point(12, 128);
            this.CountryId.Name = "CountryId";
            this.CountryId.ObjectControl = null;
            this.CountryId.ObjetoApp = null;
            this.CountryId.PropertyControl = null;
            this.CountryId.PropertyDependecyUkey = null;
            this.CountryId.Size = new System.Drawing.Size(92, 55);
            this.CountryId.StandardValue = null;
            this.CountryId.TabIndex = 5;
            this.CountryId.TabStop = false;
            this.CountryId.Text = "sComboBox3";
            this.CountryId.ToolTipContext = null;
            this.CountryId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("CountryId.Validations")));
            this.CountryId.ValueControl = null;
            this.CountryId.ValueMember = "";
            // 
            // FPublicPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(599, 357);
            this.Name = "FPublicPlace";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Core.Component.STextBox ZipCode;
        public Core.Component.STextBox Street;
        public Core.Component.STextBox Neighborhood;
        public Core.Component.SComboBox CountryId;
        public Core.Component.SComboBox StateId;
        public Core.Component.SComboBox CityId;
    }
}
