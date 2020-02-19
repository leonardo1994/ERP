namespace Esr.Module.Funerary.Forms.OrderOfServices
{
    partial class FOsVehicle
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOsVehicle));
            this.DriveId = new Esr.Core.Component.SComboBox();
            this.VehiclePlateId = new Esr.Core.Component.SComboBox();
            this.ServiceId = new Esr.Core.Component.SComboBox();
            this.ValueService = new Esr.Core.Component.SNumeric();
            this.DateTimeInitial = new Esr.Core.Component.SDateTimePicker();
            this.DateTimeFinal = new Esr.Core.Component.SDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DateTimeFinal);
            this.panel1.Controls.Add(this.DateTimeInitial);
            this.panel1.Controls.Add(this.ValueService);
            this.panel1.Controls.Add(this.ServiceId);
            this.panel1.Controls.Add(this.VehiclePlateId);
            this.panel1.Controls.Add(this.DriveId);
            this.panel1.Size = new System.Drawing.Size(669, 189);
            // 
            // DriveId
            // 
            this.DriveId.Caption = "";
            this.DriveId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DriveId.CenterCaption = false;
            this.DriveId.ComponentBackColor = System.Drawing.Color.White;
            this.DriveId.DefaultValue = false;
            this.DriveId.Disable = true;
            this.DriveId.DisplayMember = "";
            this.DriveId.FieldValid = true;
            this.DriveId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DriveId.Form = null;
            this.DriveId.FormType = null;
            this.DriveId.IsDependecyUkey = false;
            this.DriveId.Location = new System.Drawing.Point(12, 6);
            this.DriveId.Name = "DriveId";
            this.DriveId.ObjectControl = null;
            this.DriveId.ObjetoApp = null;
            this.DriveId.PropertyControl = null;
            this.DriveId.PropertyDependecyUkey = null;
            this.DriveId.Size = new System.Drawing.Size(324, 53);
            this.DriveId.StandardValue = null;
            this.DriveId.TabIndex = 0;
            this.DriveId.TabStop = false;
            this.DriveId.Text = "sComboBox1";
            this.DriveId.ToolTipContext = null;
            this.DriveId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("DriveId.Validations")));
            this.DriveId.ValueControl = null;
            this.DriveId.ValueMember = "";
            // 
            // VehiclePlateId
            // 
            this.VehiclePlateId.Caption = "";
            this.VehiclePlateId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.VehiclePlateId.CenterCaption = false;
            this.VehiclePlateId.ComponentBackColor = System.Drawing.Color.White;
            this.VehiclePlateId.DefaultValue = false;
            this.VehiclePlateId.Disable = true;
            this.VehiclePlateId.DisplayMember = "";
            this.VehiclePlateId.FieldValid = true;
            this.VehiclePlateId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.VehiclePlateId.Form = null;
            this.VehiclePlateId.FormType = null;
            this.VehiclePlateId.IsDependecyUkey = false;
            this.VehiclePlateId.Location = new System.Drawing.Point(342, 6);
            this.VehiclePlateId.Name = "VehiclePlateId";
            this.VehiclePlateId.ObjectControl = null;
            this.VehiclePlateId.ObjetoApp = null;
            this.VehiclePlateId.PropertyControl = null;
            this.VehiclePlateId.PropertyDependecyUkey = null;
            this.VehiclePlateId.Size = new System.Drawing.Size(315, 53);
            this.VehiclePlateId.StandardValue = null;
            this.VehiclePlateId.TabIndex = 1;
            this.VehiclePlateId.TabStop = false;
            this.VehiclePlateId.Text = "sComboBox2";
            this.VehiclePlateId.ToolTipContext = null;
            this.VehiclePlateId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("VehiclePlateId.Validations")));
            this.VehiclePlateId.ValueControl = null;
            this.VehiclePlateId.ValueMember = "";
            // 
            // ServiceId
            // 
            this.ServiceId.Caption = "";
            this.ServiceId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ServiceId.CenterCaption = false;
            this.ServiceId.ComponentBackColor = System.Drawing.Color.White;
            this.ServiceId.DefaultValue = false;
            this.ServiceId.Disable = true;
            this.ServiceId.DisplayMember = "";
            this.ServiceId.FieldValid = true;
            this.ServiceId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ServiceId.Form = null;
            this.ServiceId.FormType = null;
            this.ServiceId.IsDependecyUkey = false;
            this.ServiceId.Location = new System.Drawing.Point(12, 65);
            this.ServiceId.Name = "ServiceId";
            this.ServiceId.ObjectControl = null;
            this.ServiceId.ObjetoApp = null;
            this.ServiceId.PropertyControl = null;
            this.ServiceId.PropertyDependecyUkey = null;
            this.ServiceId.Size = new System.Drawing.Size(459, 53);
            this.ServiceId.StandardValue = null;
            this.ServiceId.TabIndex = 2;
            this.ServiceId.TabStop = false;
            this.ServiceId.Text = "sComboBox3";
            this.ServiceId.ToolTipContext = null;
            this.ServiceId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ServiceId.Validations")));
            this.ServiceId.ValueControl = null;
            this.ServiceId.ValueMember = "";
            // 
            // ValueService
            // 
            this.ValueService.Caption = "";
            this.ValueService.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ValueService.CenterCaption = false;
            this.ValueService.ComponentBackColor = System.Drawing.Color.White;
            this.ValueService.DecimalPlaces = 2;
            this.ValueService.Disable = true;
            this.ValueService.FieldValid = true;
            this.ValueService.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ValueService.Form = null;
            this.ValueService.FormType = null;
            this.ValueService.IsDependecyUkey = false;
            this.ValueService.Location = new System.Drawing.Point(477, 65);
            this.ValueService.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ValueService.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ValueService.Name = "ValueService";
            this.ValueService.ObjectControl = null;
            this.ValueService.ObjetoApp = null;
            this.ValueService.PropertyControl = null;
            this.ValueService.PropertyDependecyUkey = null;
            this.ValueService.Size = new System.Drawing.Size(180, 53);
            this.ValueService.TabIndex = 3;
            this.ValueService.TabStop = false;
            this.ValueService.Text = "sNumeric1";
            this.ValueService.ThousandsSeparator = false;
            this.ValueService.ToolTipContext = null;
            this.ValueService.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ValueService.Validations")));
            this.ValueService.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // DateTimeInitial
            // 
            this.DateTimeInitial.Caption = "";
            this.DateTimeInitial.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DateTimeInitial.CenterCaption = false;
            this.DateTimeInitial.ComponentBackColor = System.Drawing.Color.White;
            this.DateTimeInitial.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.DateTimeInitial.Disable = true;
            this.DateTimeInitial.FieldValid = true;
            this.DateTimeInitial.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DateTimeInitial.Form = null;
            this.DateTimeInitial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeInitial.FormType = null;
            this.DateTimeInitial.IsDependecyUkey = false;
            this.DateTimeInitial.Location = new System.Drawing.Point(12, 124);
            this.DateTimeInitial.Name = "DateTimeInitial";
            this.DateTimeInitial.ObjectControl = null;
            this.DateTimeInitial.ObjetoApp = null;
            this.DateTimeInitial.PropertyControl = null;
            this.DateTimeInitial.PropertyDependecyUkey = null;
            this.DateTimeInitial.Size = new System.Drawing.Size(324, 60);
            this.DateTimeInitial.TabIndex = 4;
            this.DateTimeInitial.TabStop = false;
            this.DateTimeInitial.Text = "sDateTimePicker1";
            this.DateTimeInitial.ToolTipContext = null;
            this.DateTimeInitial.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("DateTimeInitial.Validations")));
            this.DateTimeInitial.ValueControl = new System.DateTime(2016, 12, 8, 18, 43, 5, 403);
            // 
            // DateTimeFinal
            // 
            this.DateTimeFinal.Caption = "";
            this.DateTimeFinal.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DateTimeFinal.CenterCaption = false;
            this.DateTimeFinal.ComponentBackColor = System.Drawing.Color.White;
            this.DateTimeFinal.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.DateTimeFinal.Disable = true;
            this.DateTimeFinal.FieldValid = true;
            this.DateTimeFinal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DateTimeFinal.Form = null;
            this.DateTimeFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeFinal.FormType = null;
            this.DateTimeFinal.IsDependecyUkey = false;
            this.DateTimeFinal.Location = new System.Drawing.Point(342, 124);
            this.DateTimeFinal.Name = "DateTimeFinal";
            this.DateTimeFinal.ObjectControl = null;
            this.DateTimeFinal.ObjetoApp = null;
            this.DateTimeFinal.PropertyControl = null;
            this.DateTimeFinal.PropertyDependecyUkey = null;
            this.DateTimeFinal.Size = new System.Drawing.Size(324, 60);
            this.DateTimeFinal.TabIndex = 5;
            this.DateTimeFinal.TabStop = false;
            this.DateTimeFinal.Text = "sDateTimePicker2";
            this.DateTimeFinal.ToolTipContext = null;
            this.DateTimeFinal.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("DateTimeFinal.Validations")));
            this.DateTimeFinal.ValueControl = new System.DateTime(2016, 12, 8, 18, 43, 5, 403);
            // 
            // FOsVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(669, 353);
            this.Name = "FOsVehicle";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SComboBox DriveId;
        private Core.Component.SComboBox VehiclePlateId;
        private Core.Component.SComboBox ServiceId;
        private Core.Component.SNumeric ValueService;
        private Core.Component.SDateTimePicker DateTimeInitial;
        private Core.Component.SDateTimePicker DateTimeFinal;
    }
}
