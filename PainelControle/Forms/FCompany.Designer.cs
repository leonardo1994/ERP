using System.Collections.Generic;

namespace Esr.Module.ControlPainel.Forms
{
    partial class FCompany
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCompany));
            this.Code = new Esr.Core.Component.STextBox();
            this.CorporateName = new Esr.Core.Component.STextBox();
            this.Cnpj = new Esr.Core.Component.SMasckEdit();
            this.TypeCompany = new Esr.Core.Component.SComboBox();
            this.CommercialPhone = new Esr.Core.Component.STextBox();
            this.CellPhone = new Esr.Core.Component.STextBox();
            this.LandLine = new Esr.Core.Component.STextBox();
            this.Email = new Esr.Core.Component.STextBox();
            this.PersonName = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Code);
            this.panel1.Controls.Add(this.PersonName);
            this.panel1.Controls.Add(this.CorporateName);
            this.panel1.Controls.Add(this.Cnpj);
            this.panel1.Controls.Add(this.CellPhone);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.CommercialPhone);
            this.panel1.Controls.Add(this.TypeCompany);
            this.panel1.Controls.Add(this.LandLine);
            this.panel1.Size = new System.Drawing.Size(700, 327);
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
            this.Code.Location = new System.Drawing.Point(6, 16);
            this.Code.Name = "Code";
            this.Code.ObjectControl = null;
            this.Code.ObjetoApp = null;
            this.Code.PropertyControl = null;
            this.Code.PropertyDependecyUkey = null;
            this.Code.Size = new System.Drawing.Size(146, 55);
            this.Code.TabIndex = 0;
            this.Code.TabStop = false;
            this.Code.Text = "sTextBox1";
            this.Code.ToolTipContext = null;
            this.Code.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Code.Validations")));
            this.Code.ValueControl = "";
            // 
            // CorporateName
            // 
            this.CorporateName.Caption = "";
            this.CorporateName.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.CorporateName.CenterCaption = false;
            this.CorporateName.ComponentBackColor = System.Drawing.Color.White;
            this.CorporateName.Disable = true;
            this.CorporateName.FieldValid = true;
            this.CorporateName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CorporateName.Form = null;
            this.CorporateName.FormType = null;
            this.CorporateName.IsDependecyUkey = false;
            this.CorporateName.Location = new System.Drawing.Point(6, 77);
            this.CorporateName.Name = "CorporateName";
            this.CorporateName.ObjectControl = null;
            this.CorporateName.ObjetoApp = null;
            this.CorporateName.PropertyControl = null;
            this.CorporateName.PropertyDependecyUkey = null;
            this.CorporateName.Size = new System.Drawing.Size(682, 55);
            this.CorporateName.TabIndex = 2;
            this.CorporateName.TabStop = false;
            this.CorporateName.Text = "sTextBox1";
            this.CorporateName.ToolTipContext = null;
            this.CorporateName.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("CorporateName.Validations")));
            this.CorporateName.ValueControl = "";
            // 
            // Cnpj
            // 
            this.Cnpj.Caption = "";
            this.Cnpj.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Cnpj.CenterCaption = false;
            this.Cnpj.ComponentBackColor = System.Drawing.Color.White;
            this.Cnpj.Disable = true;
            this.Cnpj.FieldValid = true;
            this.Cnpj.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Cnpj.Form = null;
            this.Cnpj.FormType = null;
            this.Cnpj.IsDependecyUkey = false;
            this.Cnpj.Location = new System.Drawing.Point(6, 138);
            this.Cnpj.Mask = "";
            this.Cnpj.Name = "Cnpj";
            this.Cnpj.ObjectControl = null;
            this.Cnpj.ObjetoApp = null;
            this.Cnpj.PropertyControl = null;
            this.Cnpj.PropertyDependecyUkey = null;
            this.Cnpj.Size = new System.Drawing.Size(323, 56);
            this.Cnpj.TabIndex = 3;
            this.Cnpj.TabStop = false;
            this.Cnpj.ToolTipContext = null;
            this.Cnpj.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Cnpj.Validations")));
            this.Cnpj.ValueControl = "";
            // 
            // TypeCompany
            // 
            this.TypeCompany.Caption = "";
            this.TypeCompany.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypeCompany.CenterCaption = false;
            this.TypeCompany.ComponentBackColor = System.Drawing.Color.White;
            this.TypeCompany.DefaultValue = false;
            this.TypeCompany.Disable = true;
            this.TypeCompany.DisplayMember = "";
            this.TypeCompany.FieldValid = true;
            this.TypeCompany.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeCompany.Form = null;
            this.TypeCompany.FormType = null;
            this.TypeCompany.IsDependecyUkey = false;
            this.TypeCompany.Location = new System.Drawing.Point(335, 138);
            this.TypeCompany.Name = "TypeCompany";
            this.TypeCompany.ObjectControl = null;
            this.TypeCompany.ObjetoApp = null;
            this.TypeCompany.PropertyControl = null;
            this.TypeCompany.PropertyDependecyUkey = null;
            this.TypeCompany.Size = new System.Drawing.Size(353, 56);
            this.TypeCompany.StandardValue = null;
            this.TypeCompany.TabIndex = 4;
            this.TypeCompany.TabStop = false;
            this.TypeCompany.Text = "sComboBox1";
            this.TypeCompany.ToolTipContext = null;
            this.TypeCompany.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TypeCompany.Validations")));
            this.TypeCompany.ValueControl = null;
            this.TypeCompany.ValueMember = "";
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
            this.CommercialPhone.Location = new System.Drawing.Point(218, 264);
            this.CommercialPhone.Name = "CommercialPhone";
            this.CommercialPhone.ObjectControl = null;
            this.CommercialPhone.ObjetoApp = null;
            this.CommercialPhone.PropertyControl = null;
            this.CommercialPhone.PropertyDependecyUkey = null;
            this.CommercialPhone.Size = new System.Drawing.Size(234, 53);
            this.CommercialPhone.TabIndex = 7;
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
            this.CellPhone.Location = new System.Drawing.Point(458, 264);
            this.CellPhone.Name = "CellPhone";
            this.CellPhone.ObjectControl = null;
            this.CellPhone.ObjetoApp = null;
            this.CellPhone.PropertyControl = null;
            this.CellPhone.PropertyDependecyUkey = null;
            this.CellPhone.Size = new System.Drawing.Size(230, 53);
            this.CellPhone.TabIndex = 8;
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
            this.LandLine.Location = new System.Drawing.Point(6, 264);
            this.LandLine.Name = "LandLine";
            this.LandLine.ObjectControl = null;
            this.LandLine.ObjetoApp = null;
            this.LandLine.PropertyControl = null;
            this.LandLine.PropertyDependecyUkey = null;
            this.LandLine.Size = new System.Drawing.Size(206, 53);
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
            this.Email.Location = new System.Drawing.Point(6, 200);
            this.Email.Name = "Email";
            this.Email.ObjectControl = null;
            this.Email.ObjetoApp = null;
            this.Email.PropertyControl = null;
            this.Email.PropertyDependecyUkey = null;
            this.Email.Size = new System.Drawing.Size(682, 58);
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
            this.PersonName.Location = new System.Drawing.Point(158, 16);
            this.PersonName.Name = "PersonName";
            this.PersonName.ObjectControl = null;
            this.PersonName.ObjetoApp = null;
            this.PersonName.PropertyControl = null;
            this.PersonName.PropertyDependecyUkey = null;
            this.PersonName.Size = new System.Drawing.Size(530, 55);
            this.PersonName.TabIndex = 1;
            this.PersonName.TabStop = false;
            this.PersonName.ToolTipContext = null;
            this.PersonName.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("PersonName.Validations")));
            this.PersonName.ValueControl = "";
            // 
            // FCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(700, 491);
            this.Name = "FCompany";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox Code;
        private Core.Component.STextBox CorporateName;
        private Core.Component.SMasckEdit Cnpj;
        private Core.Component.SComboBox TypeCompany;
        private Core.Component.STextBox CommercialPhone;
        private Core.Component.STextBox CellPhone;
        private Core.Component.STextBox LandLine;
        private Core.Component.STextBox Email;
        private Core.Component.STextBox PersonName;
    }
}
