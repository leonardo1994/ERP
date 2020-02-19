namespace Esr.Module.FleetManagement.Forms.Vehicles
{
    partial class FModelVehicle
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FModelVehicle));
            this.Code = new Esr.Core.Component.STextBox();
            this.Description = new Esr.Core.Component.STextBox();
            this.ColorModelVehicles = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ColorModelVehicles);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.Code);
            this.panel1.Size = new System.Drawing.Size(628, 260);
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
            this.Code.Size = new System.Drawing.Size(155, 53);
            this.Code.TabIndex = 0;
            this.Code.TabStop = false;
            this.Code.Text = "sTextBox1";
            this.Code.ToolTipContext = null;
            this.Code.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Code.Validations")));
            this.Code.ValueControl = "";
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
            this.Description.Location = new System.Drawing.Point(173, 6);
            this.Description.Name = "Description";
            this.Description.ObjectControl = null;
            this.Description.ObjetoApp = null;
            this.Description.PropertyControl = null;
            this.Description.PropertyDependecyUkey = null;
            this.Description.Size = new System.Drawing.Size(446, 53);
            this.Description.TabIndex = 1;
            this.Description.TabStop = false;
            this.Description.Text = "sTextBox2";
            this.Description.ToolTipContext = null;
            this.Description.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Description.Validations")));
            this.Description.ValueControl = "";
            // 
            // ColorModelVehicles
            // 
            this.ColorModelVehicles.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.ColorModelVehicles.Caption = "";
            this.ColorModelVehicles.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ColorModelVehicles.CenterCaption = false;
            this.ColorModelVehicles.ComponentBackColor = System.Drawing.Color.White;
            this.ColorModelVehicles.Disable = true;
            this.ColorModelVehicles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ColorModelVehicles.FieldValid = true;
            this.ColorModelVehicles.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ColorModelVehicles.Form = null;
            this.ColorModelVehicles.FormType = null;
            this.ColorModelVehicles.IsDependecyUkey = false;
            this.ColorModelVehicles.IsSearch = false;
            this.ColorModelVehicles.ListColunas = null;
            this.ColorModelVehicles.Location = new System.Drawing.Point(0, 68);
            this.ColorModelVehicles.Name = "ColorModelVehicles";
            this.ColorModelVehicles.ObjectControl = null;
            this.ColorModelVehicles.ObjetoApp = null;
            this.ColorModelVehicles.PropertyControl = null;
            this.ColorModelVehicles.PropertyDependecyUkey = null;
            this.ColorModelVehicles.PropertyInfos = null;
            this.ColorModelVehicles.ScreenSecondary = false;
            this.ColorModelVehicles.Size = new System.Drawing.Size(628, 192);
            this.ColorModelVehicles.TabIndex = 2;
            this.ColorModelVehicles.TabStop = false;
            this.ColorModelVehicles.ToolTipContext = null;
            this.ColorModelVehicles.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ColorModelVehicles.Validations")));
            this.ColorModelVehicles.ValueControl = null;
            // 
            // FModelVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(628, 424);
            this.Name = "FModelVehicle";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox Code;
        private Core.Component.STextBox Description;
        private Core.Component.SGrid ColorModelVehicles;
    }
}
