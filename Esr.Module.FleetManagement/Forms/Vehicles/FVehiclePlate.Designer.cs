namespace Esr.Module.FleetManagement.Forms.Vehicles
{
    partial class FVehiclePlate
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVehiclePlate));
            this.Plate = new Esr.Core.Component.SMasckEdit();
            this.VehicleId = new Esr.Core.Component.SComboBox();
            this.ModelVehicleId = new Esr.Core.Component.SComboBox();
            this.ColorId = new Esr.Core.Component.SComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ColorId);
            this.panel1.Controls.Add(this.ModelVehicleId);
            this.panel1.Controls.Add(this.VehicleId);
            this.panel1.Controls.Add(this.Plate);
            this.panel1.Size = new System.Drawing.Size(439, 248);
            // 
            // Plate
            // 
            this.Plate.Caption = "";
            this.Plate.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Plate.CenterCaption = false;
            this.Plate.ComponentBackColor = System.Drawing.Color.White;
            this.Plate.Disable = true;
            this.Plate.FieldValid = true;
            this.Plate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Plate.Form = null;
            this.Plate.FormType = null;
            this.Plate.IsDependecyUkey = false;
            this.Plate.Location = new System.Drawing.Point(12, 6);
            this.Plate.Mask = "";
            this.Plate.Name = "Plate";
            this.Plate.ObjectControl = null;
            this.Plate.ObjetoApp = null;
            this.Plate.PropertyControl = null;
            this.Plate.PropertyDependecyUkey = null;
            this.Plate.Size = new System.Drawing.Size(142, 56);
            this.Plate.TabIndex = 0;
            this.Plate.TabStop = false;
            this.Plate.Text = "Plate";
            this.Plate.ToolTipContext = null;
            this.Plate.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Plate.Validations")));
            this.Plate.ValueControl = "";
            // 
            // VehicleId
            // 
            this.VehicleId.Caption = "";
            this.VehicleId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.VehicleId.CenterCaption = false;
            this.VehicleId.ComponentBackColor = System.Drawing.Color.White;
            this.VehicleId.DefaultValue = false;
            this.VehicleId.Disable = true;
            this.VehicleId.DisplayMember = "";
            this.VehicleId.FieldValid = true;
            this.VehicleId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.VehicleId.Form = null;
            this.VehicleId.FormType = null;
            this.VehicleId.IsDependecyUkey = false;
            this.VehicleId.Location = new System.Drawing.Point(12, 68);
            this.VehicleId.Name = "VehicleId";
            this.VehicleId.ObjectControl = null;
            this.VehicleId.ObjetoApp = null;
            this.VehicleId.PropertyControl = null;
            this.VehicleId.PropertyDependecyUkey = null;
            this.VehicleId.Size = new System.Drawing.Size(416, 55);
            this.VehicleId.StandardValue = null;
            this.VehicleId.TabIndex = 1;
            this.VehicleId.TabStop = false;
            this.VehicleId.Text = "VehicleId";
            this.VehicleId.ToolTipContext = null;
            this.VehicleId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("VehicleId.Validations")));
            this.VehicleId.ValueControl = null;
            this.VehicleId.ValueMember = "";
            // 
            // ModelVehicleId
            // 
            this.ModelVehicleId.Caption = "";
            this.ModelVehicleId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ModelVehicleId.CenterCaption = false;
            this.ModelVehicleId.ComponentBackColor = System.Drawing.Color.White;
            this.ModelVehicleId.DefaultValue = false;
            this.ModelVehicleId.Disable = true;
            this.ModelVehicleId.DisplayMember = "";
            this.ModelVehicleId.FieldValid = true;
            this.ModelVehicleId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ModelVehicleId.Form = null;
            this.ModelVehicleId.FormType = null;
            this.ModelVehicleId.IsDependecyUkey = false;
            this.ModelVehicleId.Location = new System.Drawing.Point(12, 129);
            this.ModelVehicleId.Name = "ModelVehicleId";
            this.ModelVehicleId.ObjectControl = null;
            this.ModelVehicleId.ObjetoApp = null;
            this.ModelVehicleId.PropertyControl = null;
            this.ModelVehicleId.PropertyDependecyUkey = null;
            this.ModelVehicleId.Size = new System.Drawing.Size(416, 55);
            this.ModelVehicleId.StandardValue = null;
            this.ModelVehicleId.TabIndex = 2;
            this.ModelVehicleId.TabStop = false;
            this.ModelVehicleId.Text = "ModelVehicleId";
            this.ModelVehicleId.ToolTipContext = null;
            this.ModelVehicleId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ModelVehicleId.Validations")));
            this.ModelVehicleId.ValueControl = null;
            this.ModelVehicleId.ValueMember = "";
            // 
            // ColorId
            // 
            this.ColorId.Caption = "";
            this.ColorId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ColorId.CenterCaption = false;
            this.ColorId.ComponentBackColor = System.Drawing.Color.White;
            this.ColorId.DefaultValue = false;
            this.ColorId.Disable = true;
            this.ColorId.DisplayMember = "";
            this.ColorId.FieldValid = true;
            this.ColorId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ColorId.Form = null;
            this.ColorId.FormType = null;
            this.ColorId.IsDependecyUkey = false;
            this.ColorId.Location = new System.Drawing.Point(12, 190);
            this.ColorId.Name = "ColorId";
            this.ColorId.ObjectControl = null;
            this.ColorId.ObjetoApp = null;
            this.ColorId.PropertyControl = null;
            this.ColorId.PropertyDependecyUkey = null;
            this.ColorId.Size = new System.Drawing.Size(416, 55);
            this.ColorId.StandardValue = null;
            this.ColorId.TabIndex = 3;
            this.ColorId.TabStop = false;
            this.ColorId.Text = "ColorId";
            this.ColorId.ToolTipContext = null;
            this.ColorId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ColorId.Validations")));
            this.ColorId.ValueControl = null;
            this.ColorId.ValueMember = "";
            // 
            // FVehiclePlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(439, 412);
            this.Name = "FVehiclePlate";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SMasckEdit Plate;
        private Core.Component.SComboBox ColorId;
        private Core.Component.SComboBox ModelVehicleId;
        private Core.Component.SComboBox VehicleId;
    }
}
