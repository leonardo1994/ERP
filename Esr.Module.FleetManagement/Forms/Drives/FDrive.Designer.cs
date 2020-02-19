namespace Esr.Module.FleetManagement.Forms.Drives
{
    partial class FDrive
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDrive));
            this.Code = new Esr.Core.Component.STextBox();
            this.DriveName = new Esr.Core.Component.STextBox();
            this.Cnh = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cnh);
            this.panel1.Controls.Add(this.DriveName);
            this.panel1.Controls.Add(this.Code);
            this.panel1.Size = new System.Drawing.Size(818, 76);
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
            this.Code.Size = new System.Drawing.Size(160, 54);
            this.Code.TabIndex = 0;
            this.Code.TabStop = false;
            this.Code.Text = "sTextBox1";
            this.Code.ToolTipContext = null;
            this.Code.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Code.Validations")));
            this.Code.ValueControl = "";
            // 
            // DriveName
            // 
            this.DriveName.Caption = "";
            this.DriveName.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DriveName.CenterCaption = false;
            this.DriveName.ComponentBackColor = System.Drawing.Color.White;
            this.DriveName.Disable = true;
            this.DriveName.FieldValid = true;
            this.DriveName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DriveName.Form = null;
            this.DriveName.FormType = null;
            this.DriveName.IsDependecyUkey = false;
            this.DriveName.Location = new System.Drawing.Point(178, 6);
            this.DriveName.Name = "DriveName";
            this.DriveName.ObjectControl = null;
            this.DriveName.ObjetoApp = null;
            this.DriveName.PropertyControl = null;
            this.DriveName.PropertyDependecyUkey = null;
            this.DriveName.Size = new System.Drawing.Size(424, 54);
            this.DriveName.TabIndex = 1;
            this.DriveName.TabStop = false;
            this.DriveName.Text = "sTextBox2";
            this.DriveName.ToolTipContext = null;
            this.DriveName.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("DriveName.Validations")));
            this.DriveName.ValueControl = "";
            // 
            // Cnh
            // 
            this.Cnh.Caption = "";
            this.Cnh.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Cnh.CenterCaption = false;
            this.Cnh.ComponentBackColor = System.Drawing.Color.White;
            this.Cnh.Disable = true;
            this.Cnh.FieldValid = true;
            this.Cnh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Cnh.Form = null;
            this.Cnh.FormType = null;
            this.Cnh.IsDependecyUkey = false;
            this.Cnh.Location = new System.Drawing.Point(608, 6);
            this.Cnh.Name = "Cnh";
            this.Cnh.ObjectControl = null;
            this.Cnh.ObjetoApp = null;
            this.Cnh.PropertyControl = null;
            this.Cnh.PropertyDependecyUkey = null;
            this.Cnh.Size = new System.Drawing.Size(195, 55);
            this.Cnh.TabIndex = 2;
            this.Cnh.TabStop = false;
            this.Cnh.Text = "sTextBox3";
            this.Cnh.ToolTipContext = null;
            this.Cnh.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Cnh.Validations")));
            this.Cnh.ValueControl = "";
            // 
            // FDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(818, 240);
            this.Name = "FDrive";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox Code;
        private Core.Component.STextBox DriveName;
        private Core.Component.STextBox Cnh;
    }
}
