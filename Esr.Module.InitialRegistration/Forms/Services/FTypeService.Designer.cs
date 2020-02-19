namespace Esr.Module.InitialRegistration.Forms.Services
{
    partial class FTypeService
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTypeService));
            this.TypeStructure = new Esr.Core.Component.SComboBox();
            this.Description = new Esr.Core.Component.STextBox();
            this.Code = new Esr.Core.Component.STextBox();
            this.TypeServices = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TypeServices);
            this.panel1.Controls.Add(this.TypeStructure);
            this.panel1.Controls.Add(this.Code);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Size = new System.Drawing.Size(585, 329);
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
            this.TypeStructure.Location = new System.Drawing.Point(400, 9);
            this.TypeStructure.Name = "TypeStructure";
            this.TypeStructure.ObjectControl = null;
            this.TypeStructure.ObjetoApp = null;
            this.TypeStructure.PropertyControl = null;
            this.TypeStructure.PropertyDependecyUkey = null;
            this.TypeStructure.Size = new System.Drawing.Size(173, 55);
            this.TypeStructure.StandardValue = null;
            this.TypeStructure.TabIndex = 1;
            this.TypeStructure.TabStop = false;
            this.TypeStructure.ToolTipContext = null;
            this.TypeStructure.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TypeStructure.Validations")));
            this.TypeStructure.ValueControl = null;
            this.TypeStructure.ValueMember = "";
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
            this.Description.Location = new System.Drawing.Point(12, 70);
            this.Description.Name = "Description";
            this.Description.ObjectControl = null;
            this.Description.ObjetoApp = null;
            this.Description.PropertyControl = null;
            this.Description.PropertyDependecyUkey = null;
            this.Description.Size = new System.Drawing.Size(561, 55);
            this.Description.TabIndex = 2;
            this.Description.TabStop = false;
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
            this.Code.Location = new System.Drawing.Point(12, 9);
            this.Code.Name = "Code";
            this.Code.ObjectControl = null;
            this.Code.ObjetoApp = null;
            this.Code.PropertyControl = null;
            this.Code.PropertyDependecyUkey = null;
            this.Code.Size = new System.Drawing.Size(172, 55);
            this.Code.TabIndex = 0;
            this.Code.TabStop = false;
            this.Code.ToolTipContext = null;
            this.Code.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Code.Validations")));
            this.Code.ValueControl = "";
            // 
            // TypeServices
            // 
            this.TypeServices.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.TypeServices.Caption = "";
            this.TypeServices.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypeServices.CenterCaption = false;
            this.TypeServices.ComponentBackColor = System.Drawing.Color.White;
            this.TypeServices.Disable = true;
            this.TypeServices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TypeServices.FieldValid = true;
            this.TypeServices.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeServices.Form = null;
            this.TypeServices.FormType = null;
            this.TypeServices.IsDependecyUkey = false;
            this.TypeServices.IsSearch = false;
            this.TypeServices.ListColunas = null;
            this.TypeServices.Location = new System.Drawing.Point(0, 135);
            this.TypeServices.Name = "TypeServices";
            this.TypeServices.ObjectControl = null;
            this.TypeServices.ObjetoApp = null;
            this.TypeServices.PropertyControl = null;
            this.TypeServices.PropertyDependecyUkey = null;
            this.TypeServices.PropertyInfos = null;
            this.TypeServices.ScreenSecondary = false;
            this.TypeServices.Size = new System.Drawing.Size(585, 194);
            this.TypeServices.TabIndex = 3;
            this.TypeServices.TabStop = false;
            this.TypeServices.Text = "sGrid1";
            this.TypeServices.ToolTipContext = null;
            this.TypeServices.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TypeServices.Validations")));
            this.TypeServices.ValueControl = null;
            // 
            // FTypeService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(585, 493);
            this.Name = "FTypeService";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SComboBox TypeStructure;
        private Core.Component.STextBox Code;
        private Core.Component.STextBox Description;
        private Core.Component.SGrid TypeServices;
    }
}
