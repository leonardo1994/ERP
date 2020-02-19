namespace Esr.Module.InitialRegistration.Forms.Persons
{
    partial class FPhysicalPerson
    {


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPhysicalPerson));
            this.TabControl = new Esr.Core.Component.STabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Cpf = new Esr.Core.Component.SMasckEdit();
            this.CommercialPhone = new Esr.Core.Component.STextBox();
            this.CellPhone = new Esr.Core.Component.STextBox();
            this.LandLine = new Esr.Core.Component.STextBox();
            this.Email = new Esr.Core.Component.STextBox();
            this.PersonName = new Esr.Core.Component.STextBox();
            this.Code = new Esr.Core.Component.STextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ZipCode = new Esr.Core.Component.SMasckEdit();
            this.CityId = new Esr.Core.Component.SComboBox();
            this.StateId = new Esr.Core.Component.SComboBox();
            this.CountryId = new Esr.Core.Component.SComboBox();
            this.Complement = new Esr.Core.Component.STextBox();
            this.NumberStreet = new Esr.Core.Component.SNumeric();
            this.Street = new Esr.Core.Component.STextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PersonAddresses = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabControl);
            this.panel1.Size = new System.Drawing.Size(620, 271);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(620, 271);
            this.TabControl.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Cpf);
            this.tabPage1.Controls.Add(this.CommercialPhone);
            this.tabPage1.Controls.Add(this.CellPhone);
            this.tabPage1.Controls.Add(this.LandLine);
            this.tabPage1.Controls.Add(this.Email);
            this.tabPage1.Controls.Add(this.PersonName);
            this.tabPage1.Controls.Add(this.Code);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Cpf
            // 
            this.Cpf.Caption = "";
            this.Cpf.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Cpf.CenterCaption = false;
            this.Cpf.ComponentBackColor = System.Drawing.Color.White;
            this.Cpf.Disable = true;
            this.Cpf.FieldValid = true;
            this.Cpf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Cpf.Form = null;
            this.Cpf.FormType = null;
            this.Cpf.IsDependecyUkey = false;
            this.Cpf.Location = new System.Drawing.Point(6, 62);
            this.Cpf.Mask = "";
            this.Cpf.Name = "Cpf";
            this.Cpf.ObjectControl = null;
            this.Cpf.ObjetoApp = null;
            this.Cpf.Others = null;
            this.Cpf.PropertyControl = null;
            this.Cpf.PropertyDependecyUkey = null;
            this.Cpf.Size = new System.Drawing.Size(296, 53);
            this.Cpf.TabIndex = 4;
            this.Cpf.TabStop = false;
            this.Cpf.ToolTipContext = null;
            this.Cpf.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Cpf.Validations")));
            this.Cpf.ValueControl = "";
            // 
            // CommercialPhone
            // 
            this.CommercialPhone.Caption = "";
            this.CommercialPhone.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.CommercialPhone.CenterCaption = false;
            this.CommercialPhone.ComponentBackColor = System.Drawing.Color.White;
            this.CommercialPhone.Disable = true;
            this.CommercialPhone.FieldValid = true;
            this.CommercialPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CommercialPhone.Form = null;
            this.CommercialPhone.FormType = null;
            this.CommercialPhone.IsDependecyUkey = false;
            this.CommercialPhone.Location = new System.Drawing.Point(6, 180);
            this.CommercialPhone.Name = "CommercialPhone";
            this.CommercialPhone.ObjectControl = null;
            this.CommercialPhone.ObjetoApp = null;
            this.CommercialPhone.Others = null;
            this.CommercialPhone.PropertyControl = null;
            this.CommercialPhone.PropertyDependecyUkey = null;
            this.CommercialPhone.Size = new System.Drawing.Size(296, 53);
            this.CommercialPhone.TabIndex = 21;
            this.CommercialPhone.TabStop = false;
            this.CommercialPhone.ToolTipContext = null;
            this.CommercialPhone.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("CommercialPhone.Validations")));
            this.CommercialPhone.ValueControl = "";
            // 
            // CellPhone
            // 
            this.CellPhone.Caption = "";
            this.CellPhone.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.CellPhone.CenterCaption = false;
            this.CellPhone.ComponentBackColor = System.Drawing.Color.White;
            this.CellPhone.Disable = true;
            this.CellPhone.FieldValid = true;
            this.CellPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CellPhone.Form = null;
            this.CellPhone.FormType = null;
            this.CellPhone.IsDependecyUkey = false;
            this.CellPhone.Location = new System.Drawing.Point(308, 121);
            this.CellPhone.Name = "CellPhone";
            this.CellPhone.ObjectControl = null;
            this.CellPhone.ObjetoApp = null;
            this.CellPhone.Others = null;
            this.CellPhone.PropertyControl = null;
            this.CellPhone.PropertyDependecyUkey = null;
            this.CellPhone.Size = new System.Drawing.Size(296, 53);
            this.CellPhone.TabIndex = 7;
            this.CellPhone.TabStop = false;
            this.CellPhone.ToolTipContext = null;
            this.CellPhone.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("CellPhone.Validations")));
            this.CellPhone.ValueControl = "";
            // 
            // LandLine
            // 
            this.LandLine.Caption = "";
            this.LandLine.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.LandLine.CenterCaption = false;
            this.LandLine.ComponentBackColor = System.Drawing.Color.White;
            this.LandLine.Disable = true;
            this.LandLine.FieldValid = true;
            this.LandLine.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LandLine.Form = null;
            this.LandLine.FormType = null;
            this.LandLine.IsDependecyUkey = false;
            this.LandLine.Location = new System.Drawing.Point(6, 121);
            this.LandLine.Name = "LandLine";
            this.LandLine.ObjectControl = null;
            this.LandLine.ObjetoApp = null;
            this.LandLine.Others = null;
            this.LandLine.PropertyControl = null;
            this.LandLine.PropertyDependecyUkey = null;
            this.LandLine.Size = new System.Drawing.Size(296, 53);
            this.LandLine.TabIndex = 6;
            this.LandLine.TabStop = false;
            this.LandLine.ToolTipContext = null;
            this.LandLine.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("LandLine.Validations")));
            this.LandLine.ValueControl = "";
            // 
            // Email
            // 
            this.Email.Caption = "";
            this.Email.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Email.CenterCaption = false;
            this.Email.ComponentBackColor = System.Drawing.Color.White;
            this.Email.Disable = true;
            this.Email.FieldValid = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Email.Form = null;
            this.Email.FormType = null;
            this.Email.IsDependecyUkey = false;
            this.Email.Location = new System.Drawing.Point(308, 62);
            this.Email.Name = "Email";
            this.Email.ObjectControl = null;
            this.Email.ObjetoApp = null;
            this.Email.Others = null;
            this.Email.PropertyControl = null;
            this.Email.PropertyDependecyUkey = null;
            this.Email.Size = new System.Drawing.Size(296, 53);
            this.Email.TabIndex = 5;
            this.Email.TabStop = false;
            this.Email.ToolTipContext = null;
            this.Email.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Email.Validations")));
            this.Email.ValueControl = "";
            // 
            // PersonName
            // 
            this.PersonName.Caption = "";
            this.PersonName.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.PersonName.CenterCaption = false;
            this.PersonName.ComponentBackColor = System.Drawing.Color.White;
            this.PersonName.Disable = true;
            this.PersonName.FieldValid = true;
            this.PersonName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PersonName.Form = null;
            this.PersonName.FormType = null;
            this.PersonName.IsDependecyUkey = false;
            this.PersonName.Location = new System.Drawing.Point(194, 6);
            this.PersonName.Name = "PersonName";
            this.PersonName.ObjectControl = null;
            this.PersonName.ObjetoApp = null;
            this.PersonName.Others = null;
            this.PersonName.PropertyControl = null;
            this.PersonName.PropertyDependecyUkey = null;
            this.PersonName.Size = new System.Drawing.Size(410, 53);
            this.PersonName.TabIndex = 1;
            this.PersonName.TabStop = false;
            this.PersonName.ToolTipContext = null;
            this.PersonName.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("PersonName.Validations")));
            this.PersonName.ValueControl = "";
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
            this.Code.Location = new System.Drawing.Point(6, 6);
            this.Code.Name = "Code";
            this.Code.ObjectControl = null;
            this.Code.ObjetoApp = null;
            this.Code.Others = null;
            this.Code.PropertyControl = null;
            this.Code.PropertyDependecyUkey = null;
            this.Code.Size = new System.Drawing.Size(182, 53);
            this.Code.TabIndex = 0;
            this.Code.TabStop = false;
            this.Code.ToolTipContext = null;
            this.Code.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Code.Validations")));
            this.Code.ValueControl = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ZipCode);
            this.tabPage2.Controls.Add(this.CityId);
            this.tabPage2.Controls.Add(this.StateId);
            this.tabPage2.Controls.Add(this.CountryId);
            this.tabPage2.Controls.Add(this.Complement);
            this.tabPage2.Controls.Add(this.NumberStreet);
            this.tabPage2.Controls.Add(this.Street);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Endereços";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.ZipCode.Location = new System.Drawing.Point(9, 7);
            this.ZipCode.Mask = "99999-999";
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.ObjectControl = null;
            this.ZipCode.ObjetoApp = null;
            this.ZipCode.Others = null;
            this.ZipCode.PropertyControl = null;
            this.ZipCode.PropertyDependecyUkey = null;
            this.ZipCode.Size = new System.Drawing.Size(113, 52);
            this.ZipCode.TabIndex = 10;
            this.ZipCode.TabStop = false;
            this.ZipCode.Text = "sMasckEdit1";
            this.ZipCode.ToolTipContext = null;
            this.ZipCode.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ZipCode.Validations")));
            this.ZipCode.ValueControl = "     -";
            // 
            // CityId
            // 
            this.CityId.Caption = "";
            this.CityId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.CityId.CenterCaption = false;
            this.CityId.ComboBoxMultiForms = null;
            this.CityId.ComponentBackColor = System.Drawing.Color.White;
            this.CityId.DefaultValue = false;
            this.CityId.Disable = true;
            this.CityId.DisplayMember = "";
            this.CityId.FieldValid = true;
            this.CityId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CityId.Form = null;
            this.CityId.FormType = null;
            this.CityId.IsDependecyUkey = false;
            this.CityId.Location = new System.Drawing.Point(247, 66);
            this.CityId.Name = "CityId";
            this.CityId.ObjectControl = null;
            this.CityId.ObjetoApp = null;
            this.CityId.Others = null;
            this.CityId.PropertyControl = null;
            this.CityId.PropertyDependecyUkey = null;
            this.CityId.Size = new System.Drawing.Size(356, 52);
            this.CityId.StandardValue = null;
            this.CityId.TabIndex = 9;
            this.CityId.TabStop = false;
            this.CityId.Text = "sComboBox3";
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
            this.StateId.ComboBoxMultiForms = null;
            this.StateId.ComponentBackColor = System.Drawing.Color.White;
            this.StateId.DefaultValue = false;
            this.StateId.Disable = true;
            this.StateId.DisplayMember = "";
            this.StateId.FieldValid = true;
            this.StateId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StateId.Form = null;
            this.StateId.FormType = null;
            this.StateId.IsDependecyUkey = false;
            this.StateId.Location = new System.Drawing.Point(128, 66);
            this.StateId.Name = "StateId";
            this.StateId.ObjectControl = null;
            this.StateId.ObjetoApp = null;
            this.StateId.Others = null;
            this.StateId.PropertyControl = null;
            this.StateId.PropertyDependecyUkey = null;
            this.StateId.Size = new System.Drawing.Size(113, 52);
            this.StateId.StandardValue = null;
            this.StateId.TabIndex = 8;
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
            this.CountryId.ComboBoxMultiForms = null;
            this.CountryId.ComponentBackColor = System.Drawing.Color.White;
            this.CountryId.DefaultValue = false;
            this.CountryId.Disable = true;
            this.CountryId.DisplayMember = "";
            this.CountryId.FieldValid = true;
            this.CountryId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CountryId.Form = null;
            this.CountryId.FormType = null;
            this.CountryId.IsDependecyUkey = false;
            this.CountryId.Location = new System.Drawing.Point(9, 65);
            this.CountryId.Name = "CountryId";
            this.CountryId.ObjectControl = null;
            this.CountryId.ObjetoApp = null;
            this.CountryId.Others = null;
            this.CountryId.PropertyControl = null;
            this.CountryId.PropertyDependecyUkey = null;
            this.CountryId.Size = new System.Drawing.Size(113, 52);
            this.CountryId.StandardValue = null;
            this.CountryId.TabIndex = 7;
            this.CountryId.TabStop = false;
            this.CountryId.Text = "sComboBox1";
            this.CountryId.ToolTipContext = null;
            this.CountryId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("CountryId.Validations")));
            this.CountryId.ValueControl = null;
            this.CountryId.ValueMember = "";
            // 
            // Complement
            // 
            this.Complement.Caption = "";
            this.Complement.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Complement.CenterCaption = false;
            this.Complement.ComponentBackColor = System.Drawing.Color.White;
            this.Complement.Disable = true;
            this.Complement.FieldValid = true;
            this.Complement.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Complement.Form = null;
            this.Complement.FormType = null;
            this.Complement.IsDependecyUkey = false;
            this.Complement.Location = new System.Drawing.Point(6, 123);
            this.Complement.Name = "Complement";
            this.Complement.ObjectControl = null;
            this.Complement.ObjetoApp = null;
            this.Complement.Others = null;
            this.Complement.PropertyControl = null;
            this.Complement.PropertyDependecyUkey = null;
            this.Complement.Size = new System.Drawing.Size(597, 53);
            this.Complement.TabIndex = 6;
            this.Complement.TabStop = false;
            this.Complement.Text = "sTextBox1";
            this.Complement.ToolTipContext = null;
            this.Complement.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Complement.Validations")));
            this.Complement.ValueControl = "";
            // 
            // NumberStreet
            // 
            this.NumberStreet.Caption = "";
            this.NumberStreet.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NumberStreet.CenterCaption = false;
            this.NumberStreet.ComponentBackColor = System.Drawing.Color.White;
            this.NumberStreet.DecimalPlaces = 0;
            this.NumberStreet.Disable = true;
            this.NumberStreet.FieldValid = true;
            this.NumberStreet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NumberStreet.Form = null;
            this.NumberStreet.FormType = null;
            this.NumberStreet.IsDependecyUkey = false;
            this.NumberStreet.Location = new System.Drawing.Point(519, 6);
            this.NumberStreet.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NumberStreet.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumberStreet.Name = "NumberStreet";
            this.NumberStreet.ObjectControl = null;
            this.NumberStreet.ObjetoApp = null;
            this.NumberStreet.Others = null;
            this.NumberStreet.PropertyControl = null;
            this.NumberStreet.PropertyDependecyUkey = null;
            this.NumberStreet.Size = new System.Drawing.Size(87, 53);
            this.NumberStreet.TabIndex = 2;
            this.NumberStreet.TabStop = false;
            this.NumberStreet.ThousandsSeparator = false;
            this.NumberStreet.ToolTipContext = null;
            this.NumberStreet.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NumberStreet.Validations")));
            this.NumberStreet.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            this.Street.Location = new System.Drawing.Point(128, 6);
            this.Street.Name = "Street";
            this.Street.ObjectControl = null;
            this.Street.ObjetoApp = null;
            this.Street.Others = null;
            this.Street.PropertyControl = null;
            this.Street.PropertyDependecyUkey = null;
            this.Street.Size = new System.Drawing.Size(385, 53);
            this.Street.TabIndex = 1;
            this.Street.TabStop = false;
            this.Street.ToolTipContext = null;
            this.Street.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Street.Validations")));
            this.Street.ValueControl = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.PersonAddresses);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(612, 241);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Endereço de Cobrança";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PersonAddresses
            // 
            this.PersonAddresses.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.PersonAddresses.Caption = "";
            this.PersonAddresses.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.PersonAddresses.CenterCaption = false;
            this.PersonAddresses.ComponentBackColor = System.Drawing.Color.White;
            this.PersonAddresses.Disable = true;
            this.PersonAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonAddresses.FieldValid = true;
            this.PersonAddresses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PersonAddresses.Form = null;
            this.PersonAddresses.FormType = null;
            this.PersonAddresses.IsDependecyUkey = false;
            this.PersonAddresses.IsSearch = false;
            this.PersonAddresses.ListColunas = null;
            this.PersonAddresses.Location = new System.Drawing.Point(3, 3);
            this.PersonAddresses.Name = "PersonAddresses";
            this.PersonAddresses.ObjectControl = null;
            this.PersonAddresses.ObjetoApp = null;
            this.PersonAddresses.Others = null;
            this.PersonAddresses.PropertyControl = null;
            this.PersonAddresses.PropertyDependecyUkey = null;
            this.PersonAddresses.PropertyInfos = null;
            this.PersonAddresses.ScreenSecondary = false;
            this.PersonAddresses.Size = new System.Drawing.Size(606, 235);
            this.PersonAddresses.TabIndex = 0;
            this.PersonAddresses.TabStop = false;
            this.PersonAddresses.Text = "sGrid1";
            this.PersonAddresses.ToolTipContext = null;
            this.PersonAddresses.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("PersonAddresses.Validations")));
            this.PersonAddresses.ValueControl = null;
            // 
            // FPhysicalPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(620, 435);
            this.Name = "FPhysicalPerson";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        public Core.Component.SMasckEdit Cpf;
        public Core.Component.STextBox CommercialPhone;
        public Core.Component.STextBox CellPhone;
        public Core.Component.STextBox LandLine;
        public Core.Component.STextBox Email;
        public Core.Component.STextBox PersonName;
        public Core.Component.STextBox Code;
        public System.Windows.Forms.TabPage tabPage2;
        public Core.Component.STextBox Complement;
        public Core.Component.SNumeric NumberStreet;
        public Core.Component.STextBox Street;
        public System.Windows.Forms.TabPage tabPage3;
        public Core.Component.SComboBox CityId;
        public Core.Component.SComboBox StateId;
        public Core.Component.SComboBox CountryId;
        public Core.Component.SGrid PersonAddresses;
        public Core.Component.SMasckEdit ZipCode;
    }
}
