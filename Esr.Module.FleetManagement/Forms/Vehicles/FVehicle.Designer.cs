namespace Esr.Module.FleetManagement.Forms.Vehicles
{
    partial class FVehicle
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVehicle));
            this.CodeVehicle = new Esr.Core.Component.STextBox();
            this.NameVehicle = new Esr.Core.Component.STextBox();
            this.VehicleModelVehicles = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VehicleModelVehicles);
            this.panel1.Controls.Add(this.NameVehicle);
            this.panel1.Controls.Add(this.CodeVehicle);
            this.panel1.Size = new System.Drawing.Size(625, 260);
            // 
            // CodeVehicle
            // 
            this.CodeVehicle.Caption = "";
            this.CodeVehicle.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.CodeVehicle.CenterCaption = false;
            this.CodeVehicle.ComponentBackColor = System.Drawing.Color.White;
            this.CodeVehicle.Disable = true;
            this.CodeVehicle.FieldValid = true;
            this.CodeVehicle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CodeVehicle.Form = null;
            this.CodeVehicle.FormType = null;
            this.CodeVehicle.IsDependecyUkey = false;
            this.CodeVehicle.Location = new System.Drawing.Point(3, 6);
            this.CodeVehicle.Name = "CodeVehicle";
            this.CodeVehicle.ObjectControl = null;
            this.CodeVehicle.ObjetoApp = null;
            this.CodeVehicle.PropertyControl = null;
            this.CodeVehicle.PropertyDependecyUkey = null;
            this.CodeVehicle.Size = new System.Drawing.Size(155, 53);
            this.CodeVehicle.TabIndex = 0;
            this.CodeVehicle.TabStop = false;
            this.CodeVehicle.Text = "sTextBox1";
            this.CodeVehicle.ToolTipContext = null;
            this.CodeVehicle.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("CodeVehicle.Validations")));
            this.CodeVehicle.ValueControl = "";
            // 
            // NameVehicle
            // 
            this.NameVehicle.Caption = "";
            this.NameVehicle.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NameVehicle.CenterCaption = false;
            this.NameVehicle.ComponentBackColor = System.Drawing.Color.White;
            this.NameVehicle.Disable = true;
            this.NameVehicle.FieldValid = true;
            this.NameVehicle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NameVehicle.Form = null;
            this.NameVehicle.FormType = null;
            this.NameVehicle.IsDependecyUkey = false;
            this.NameVehicle.Location = new System.Drawing.Point(164, 6);
            this.NameVehicle.Name = "NameVehicle";
            this.NameVehicle.ObjectControl = null;
            this.NameVehicle.ObjetoApp = null;
            this.NameVehicle.PropertyControl = null;
            this.NameVehicle.PropertyDependecyUkey = null;
            this.NameVehicle.Size = new System.Drawing.Size(450, 53);
            this.NameVehicle.TabIndex = 1;
            this.NameVehicle.TabStop = false;
            this.NameVehicle.Text = "sTextBox2";
            this.NameVehicle.ToolTipContext = null;
            this.NameVehicle.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NameVehicle.Validations")));
            this.NameVehicle.ValueControl = "";
            // 
            // VehicleModelVehicles
            // 
            this.VehicleModelVehicles.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.VehicleModelVehicles.Caption = "";
            this.VehicleModelVehicles.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.VehicleModelVehicles.CenterCaption = false;
            this.VehicleModelVehicles.ComponentBackColor = System.Drawing.Color.White;
            this.VehicleModelVehicles.Disable = true;
            this.VehicleModelVehicles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VehicleModelVehicles.FieldValid = true;
            this.VehicleModelVehicles.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.VehicleModelVehicles.Form = null;
            this.VehicleModelVehicles.FormType = null;
            this.VehicleModelVehicles.IsDependecyUkey = false;
            this.VehicleModelVehicles.IsSearch = false;
            this.VehicleModelVehicles.ListColunas = null;
            this.VehicleModelVehicles.Location = new System.Drawing.Point(0, 68);
            this.VehicleModelVehicles.Name = "VehicleModelVehicles";
            this.VehicleModelVehicles.ObjectControl = null;
            this.VehicleModelVehicles.ObjetoApp = null;
            this.VehicleModelVehicles.PropertyControl = null;
            this.VehicleModelVehicles.PropertyDependecyUkey = null;
            this.VehicleModelVehicles.PropertyInfos = null;
            this.VehicleModelVehicles.ScreenSecondary = false;
            this.VehicleModelVehicles.Size = new System.Drawing.Size(625, 192);
            this.VehicleModelVehicles.TabIndex = 2;
            this.VehicleModelVehicles.TabStop = false;
            this.VehicleModelVehicles.ToolTipContext = null;
            this.VehicleModelVehicles.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("VehicleModelVehicles.Validations")));
            this.VehicleModelVehicles.ValueControl = null;
            // 
            // FVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(625, 424);
            this.Name = "FVehicle";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox CodeVehicle;
        private Core.Component.STextBox NameVehicle;
        private Core.Component.SGrid VehicleModelVehicles;
    }
}
