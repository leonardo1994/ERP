namespace Esr.Module.Parking.Forms
{
    partial class FParkingHoursVariation
    {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ParkingStartingTime = new Esr.Core.Component.SDateTimePicker();
            this.ParkingFinalHour = new Esr.Core.Component.SDateTimePicker();
            this.ParkingFixedTime = new Esr.Core.Component.SCheckBox();
            this.ParkingValue = new Esr.Core.Component.SNumeric();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ParkingFinalHour);
            this.panel1.Controls.Add(this.ParkingFixedTime);
            this.panel1.Controls.Add(this.ParkingStartingTime);
            this.panel1.Controls.Add(this.ParkingValue);
            this.panel1.Size = new System.Drawing.Size(417, 241);
            // 
            // ParkingStartingTime
            // 
            this.ParkingStartingTime.Caption = "";
            this.ParkingStartingTime.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ParkingStartingTime.CenterCaption = false;
            this.ParkingStartingTime.ComponentBackColor = System.Drawing.Color.White;
            this.ParkingStartingTime.CustomFormat = "HH:mm";
            this.ParkingStartingTime.Disable = true;
            this.ParkingStartingTime.FieldValid = true;
            this.ParkingStartingTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ParkingStartingTime.Form = null;
            this.ParkingStartingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ParkingStartingTime.FormType = null;
            this.ParkingStartingTime.IsDependecyUkey = false;
            this.ParkingStartingTime.Location = new System.Drawing.Point(12, 53);
            this.ParkingStartingTime.Name = "ParkingStartingTime";
            this.ParkingStartingTime.ObjectControl = null;
            this.ParkingStartingTime.ObjetoApp = null;
            this.ParkingStartingTime.Others = null;
            this.ParkingStartingTime.PropertyControl = null;
            this.ParkingStartingTime.PropertyDependecyUkey = null;
            this.ParkingStartingTime.Size = new System.Drawing.Size(390, 53);
            this.ParkingStartingTime.TabIndex = 2;
            this.ParkingStartingTime.TabStop = false;
            this.ParkingStartingTime.Text = "sDateTimePicker1";
            this.ParkingStartingTime.ToolTipContext = null;
            this.ParkingStartingTime.Validations = null;
            this.ParkingStartingTime.ValueControl = new System.DateTime(2017, 10, 15, 10, 35, 0, 600);
            // 
            // ParkingFinalHour
            // 
            this.ParkingFinalHour.Caption = "";
            this.ParkingFinalHour.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ParkingFinalHour.CenterCaption = false;
            this.ParkingFinalHour.ComponentBackColor = System.Drawing.Color.White;
            this.ParkingFinalHour.CustomFormat = "HH:mm";
            this.ParkingFinalHour.Disable = true;
            this.ParkingFinalHour.FieldValid = true;
            this.ParkingFinalHour.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ParkingFinalHour.Form = null;
            this.ParkingFinalHour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ParkingFinalHour.FormType = null;
            this.ParkingFinalHour.IsDependecyUkey = false;
            this.ParkingFinalHour.Location = new System.Drawing.Point(12, 112);
            this.ParkingFinalHour.Name = "ParkingFinalHour";
            this.ParkingFinalHour.ObjectControl = null;
            this.ParkingFinalHour.ObjetoApp = null;
            this.ParkingFinalHour.Others = null;
            this.ParkingFinalHour.PropertyControl = null;
            this.ParkingFinalHour.PropertyDependecyUkey = null;
            this.ParkingFinalHour.Size = new System.Drawing.Size(390, 53);
            this.ParkingFinalHour.TabIndex = 3;
            this.ParkingFinalHour.TabStop = false;
            this.ParkingFinalHour.Text = "sDateTimePicker2";
            this.ParkingFinalHour.ToolTipContext = null;
            this.ParkingFinalHour.Validations = null;
            this.ParkingFinalHour.ValueControl = new System.DateTime(2017, 10, 15, 10, 35, 0, 600);
            // 
            // ParkingFixedTime
            // 
            this.ParkingFixedTime.Caption = "";
            this.ParkingFixedTime.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ParkingFixedTime.CenterCaption = false;
            this.ParkingFixedTime.ComponentBackColor = System.Drawing.Color.White;
            this.ParkingFixedTime.Disable = true;
            this.ParkingFixedTime.FieldValid = true;
            this.ParkingFixedTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ParkingFixedTime.Form = null;
            this.ParkingFixedTime.FormType = null;
            this.ParkingFixedTime.IsDependecyUkey = false;
            this.ParkingFixedTime.Location = new System.Drawing.Point(12, 24);
            this.ParkingFixedTime.Name = "ParkingFixedTime";
            this.ParkingFixedTime.ObjectControl = null;
            this.ParkingFixedTime.ObjetoApp = null;
            this.ParkingFixedTime.Others = null;
            this.ParkingFixedTime.PropertyControl = null;
            this.ParkingFixedTime.PropertyDependecyUkey = null;
            this.ParkingFixedTime.Size = new System.Drawing.Size(390, 23);
            this.ParkingFixedTime.TabIndex = 1;
            this.ParkingFixedTime.TabStop = false;
            this.ParkingFixedTime.Text = "sCheckBox1";
            this.ParkingFixedTime.ToolTipContext = null;
            this.ParkingFixedTime.Validations = null;
            this.ParkingFixedTime.ValueControl = false;
            // 
            // ParkingValue
            // 
            this.ParkingValue.Caption = "";
            this.ParkingValue.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ParkingValue.CenterCaption = false;
            this.ParkingValue.ComponentBackColor = System.Drawing.Color.White;
            this.ParkingValue.DecimalPlaces = 2;
            this.ParkingValue.Disable = true;
            this.ParkingValue.FieldValid = true;
            this.ParkingValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ParkingValue.Form = null;
            this.ParkingValue.FormType = null;
            this.ParkingValue.IsDependecyUkey = false;
            this.ParkingValue.Location = new System.Drawing.Point(12, 171);
            this.ParkingValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ParkingValue.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ParkingValue.Name = "ParkingValue";
            this.ParkingValue.ObjectControl = null;
            this.ParkingValue.ObjetoApp = null;
            this.ParkingValue.Others = null;
            this.ParkingValue.PropertyControl = null;
            this.ParkingValue.PropertyDependecyUkey = null;
            this.ParkingValue.Size = new System.Drawing.Size(390, 54);
            this.ParkingValue.TabIndex = 6;
            this.ParkingValue.TabStop = false;
            this.ParkingValue.Text = "sNumeric1";
            this.ParkingValue.ThousandsSeparator = true;
            this.ParkingValue.ToolTipContext = null;
            this.ParkingValue.Validations = null;
            this.ParkingValue.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // FParkingHoursVariation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 405);
            this.Name = "FParkingHoursVariation";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SDateTimePicker ParkingFinalHour;
        private Core.Component.SCheckBox ParkingFixedTime;
        private Core.Component.SDateTimePicker ParkingStartingTime;
        private Core.Component.SNumeric ParkingValue;
    }
}