namespace Esr.Module.Parking.Forms
{
    partial class FParkingAgreement
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Holiday = new Esr.Core.Component.SCheckBox();
            this.Sunday = new Esr.Core.Component.SCheckBox();
            this.Saturday = new Esr.Core.Component.SCheckBox();
            this.Friday = new Esr.Core.Component.SCheckBox();
            this.Thursday = new Esr.Core.Component.SCheckBox();
            this.Wednesday = new Esr.Core.Component.SCheckBox();
            this.Tuesday = new Esr.Core.Component.SCheckBox();
            this.Monday = new Esr.Core.Component.SCheckBox();
            this.Situation = new Esr.Core.Component.SComboBox();
            this.Description = new Esr.Core.Component.STextBox();
            this.LegalPersonId = new Esr.Core.Component.SComboBox();
            this.DiscountValueReal = new Esr.Core.Component.SNumeric();
            this.DiscountValuePorcent = new Esr.Core.Component.SNumeric();
            this.Code = new Esr.Core.Component.STextBox();
            this.ParkingFinalHour = new Esr.Core.Component.SDateTimePicker();
            this.ParkingFixedTime = new Esr.Core.Component.SCheckBox();
            this.ParkingStartingTime = new Esr.Core.Component.SDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ParkingFinalHour);
            this.panel1.Controls.Add(this.ParkingFixedTime);
            this.panel1.Controls.Add(this.ParkingStartingTime);
            this.panel1.Controls.Add(this.Code);
            this.panel1.Controls.Add(this.DiscountValuePorcent);
            this.panel1.Controls.Add(this.DiscountValueReal);
            this.panel1.Controls.Add(this.LegalPersonId);
            this.panel1.Controls.Add(this.Situation);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Size = new System.Drawing.Size(788, 317);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.Holiday);
            this.groupBox3.Controls.Add(this.Sunday);
            this.groupBox3.Controls.Add(this.Saturday);
            this.groupBox3.Controls.Add(this.Friday);
            this.groupBox3.Controls.Add(this.Thursday);
            this.groupBox3.Controls.Add(this.Wednesday);
            this.groupBox3.Controls.Add(this.Tuesday);
            this.groupBox3.Controls.Add(this.Monday);
            this.groupBox3.Location = new System.Drawing.Point(590, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 301);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dias da Semana";
            // 
            // Holiday
            // 
            this.Holiday.Caption = "";
            this.Holiday.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Holiday.CenterCaption = false;
            this.Holiday.ComponentBackColor = System.Drawing.Color.White;
            this.Holiday.Disable = true;
            this.Holiday.FieldValid = true;
            this.Holiday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Holiday.Form = null;
            this.Holiday.FormType = null;
            this.Holiday.IsDependecyUkey = false;
            this.Holiday.Location = new System.Drawing.Point(16, 225);
            this.Holiday.Name = "Holiday";
            this.Holiday.ObjectControl = null;
            this.Holiday.ObjetoApp = null;
            this.Holiday.Others = null;
            this.Holiday.PropertyControl = null;
            this.Holiday.PropertyDependecyUkey = null;
            this.Holiday.Size = new System.Drawing.Size(145, 23);
            this.Holiday.TabIndex = 20;
            this.Holiday.TabStop = false;
            this.Holiday.Text = "sCheckBox9";
            this.Holiday.ToolTipContext = null;
            this.Holiday.Validations = null;
            this.Holiday.ValueControl = false;
            // 
            // Sunday
            // 
            this.Sunday.Caption = "";
            this.Sunday.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Sunday.CenterCaption = false;
            this.Sunday.ComponentBackColor = System.Drawing.Color.White;
            this.Sunday.Disable = true;
            this.Sunday.FieldValid = true;
            this.Sunday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Sunday.Form = null;
            this.Sunday.FormType = null;
            this.Sunday.IsDependecyUkey = false;
            this.Sunday.Location = new System.Drawing.Point(16, 197);
            this.Sunday.Name = "Sunday";
            this.Sunday.ObjectControl = null;
            this.Sunday.ObjetoApp = null;
            this.Sunday.Others = null;
            this.Sunday.PropertyControl = null;
            this.Sunday.PropertyDependecyUkey = null;
            this.Sunday.Size = new System.Drawing.Size(145, 23);
            this.Sunday.TabIndex = 19;
            this.Sunday.TabStop = false;
            this.Sunday.Text = "sCheckBox8";
            this.Sunday.ToolTipContext = null;
            this.Sunday.Validations = null;
            this.Sunday.ValueControl = false;
            // 
            // Saturday
            // 
            this.Saturday.Caption = "";
            this.Saturday.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Saturday.CenterCaption = false;
            this.Saturday.ComponentBackColor = System.Drawing.Color.White;
            this.Saturday.Disable = true;
            this.Saturday.FieldValid = true;
            this.Saturday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Saturday.Form = null;
            this.Saturday.FormType = null;
            this.Saturday.IsDependecyUkey = false;
            this.Saturday.Location = new System.Drawing.Point(16, 169);
            this.Saturday.Name = "Saturday";
            this.Saturday.ObjectControl = null;
            this.Saturday.ObjetoApp = null;
            this.Saturday.Others = null;
            this.Saturday.PropertyControl = null;
            this.Saturday.PropertyDependecyUkey = null;
            this.Saturday.Size = new System.Drawing.Size(145, 23);
            this.Saturday.TabIndex = 18;
            this.Saturday.TabStop = false;
            this.Saturday.Text = "sCheckBox7";
            this.Saturday.ToolTipContext = null;
            this.Saturday.Validations = null;
            this.Saturday.ValueControl = false;
            // 
            // Friday
            // 
            this.Friday.Caption = "";
            this.Friday.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Friday.CenterCaption = false;
            this.Friday.ComponentBackColor = System.Drawing.Color.White;
            this.Friday.Disable = true;
            this.Friday.FieldValid = true;
            this.Friday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Friday.Form = null;
            this.Friday.FormType = null;
            this.Friday.IsDependecyUkey = false;
            this.Friday.Location = new System.Drawing.Point(16, 141);
            this.Friday.Name = "Friday";
            this.Friday.ObjectControl = null;
            this.Friday.ObjetoApp = null;
            this.Friday.Others = null;
            this.Friday.PropertyControl = null;
            this.Friday.PropertyDependecyUkey = null;
            this.Friday.Size = new System.Drawing.Size(145, 23);
            this.Friday.TabIndex = 17;
            this.Friday.TabStop = false;
            this.Friday.Text = "sCheckBox6";
            this.Friday.ToolTipContext = null;
            this.Friday.Validations = null;
            this.Friday.ValueControl = false;
            // 
            // Thursday
            // 
            this.Thursday.Caption = "";
            this.Thursday.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Thursday.CenterCaption = false;
            this.Thursday.ComponentBackColor = System.Drawing.Color.White;
            this.Thursday.Disable = true;
            this.Thursday.FieldValid = true;
            this.Thursday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Thursday.Form = null;
            this.Thursday.FormType = null;
            this.Thursday.IsDependecyUkey = false;
            this.Thursday.Location = new System.Drawing.Point(16, 113);
            this.Thursday.Name = "Thursday";
            this.Thursday.ObjectControl = null;
            this.Thursday.ObjetoApp = null;
            this.Thursday.Others = null;
            this.Thursday.PropertyControl = null;
            this.Thursday.PropertyDependecyUkey = null;
            this.Thursday.Size = new System.Drawing.Size(145, 23);
            this.Thursday.TabIndex = 16;
            this.Thursday.TabStop = false;
            this.Thursday.Text = "sCheckBox5";
            this.Thursday.ToolTipContext = null;
            this.Thursday.Validations = null;
            this.Thursday.ValueControl = false;
            // 
            // Wednesday
            // 
            this.Wednesday.Caption = "";
            this.Wednesday.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Wednesday.CenterCaption = false;
            this.Wednesday.ComponentBackColor = System.Drawing.Color.White;
            this.Wednesday.Disable = true;
            this.Wednesday.FieldValid = true;
            this.Wednesday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Wednesday.Form = null;
            this.Wednesday.FormType = null;
            this.Wednesday.IsDependecyUkey = false;
            this.Wednesday.Location = new System.Drawing.Point(16, 85);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ObjectControl = null;
            this.Wednesday.ObjetoApp = null;
            this.Wednesday.Others = null;
            this.Wednesday.PropertyControl = null;
            this.Wednesday.PropertyDependecyUkey = null;
            this.Wednesday.Size = new System.Drawing.Size(145, 23);
            this.Wednesday.TabIndex = 15;
            this.Wednesday.TabStop = false;
            this.Wednesday.Text = "sCheckBox4";
            this.Wednesday.ToolTipContext = null;
            this.Wednesday.Validations = null;
            this.Wednesday.ValueControl = false;
            // 
            // Tuesday
            // 
            this.Tuesday.Caption = "";
            this.Tuesday.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Tuesday.CenterCaption = false;
            this.Tuesday.ComponentBackColor = System.Drawing.Color.White;
            this.Tuesday.Disable = true;
            this.Tuesday.FieldValid = true;
            this.Tuesday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Tuesday.Form = null;
            this.Tuesday.FormType = null;
            this.Tuesday.IsDependecyUkey = false;
            this.Tuesday.Location = new System.Drawing.Point(16, 57);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ObjectControl = null;
            this.Tuesday.ObjetoApp = null;
            this.Tuesday.Others = null;
            this.Tuesday.PropertyControl = null;
            this.Tuesday.PropertyDependecyUkey = null;
            this.Tuesday.Size = new System.Drawing.Size(145, 23);
            this.Tuesday.TabIndex = 14;
            this.Tuesday.TabStop = false;
            this.Tuesday.Text = "sCheckBox3";
            this.Tuesday.ToolTipContext = null;
            this.Tuesday.Validations = null;
            this.Tuesday.ValueControl = false;
            // 
            // Monday
            // 
            this.Monday.Caption = "";
            this.Monday.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Monday.CenterCaption = false;
            this.Monday.ComponentBackColor = System.Drawing.Color.White;
            this.Monday.Disable = true;
            this.Monday.FieldValid = true;
            this.Monday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Monday.Form = null;
            this.Monday.FormType = null;
            this.Monday.IsDependecyUkey = false;
            this.Monday.Location = new System.Drawing.Point(16, 29);
            this.Monday.Name = "Monday";
            this.Monday.ObjectControl = null;
            this.Monday.ObjetoApp = null;
            this.Monday.Others = null;
            this.Monday.PropertyControl = null;
            this.Monday.PropertyDependecyUkey = null;
            this.Monday.Size = new System.Drawing.Size(145, 23);
            this.Monday.TabIndex = 13;
            this.Monday.TabStop = false;
            this.Monday.Text = "sCheckBox2";
            this.Monday.ToolTipContext = null;
            this.Monday.Validations = null;
            this.Monday.ValueControl = false;
            // 
            // Situation
            // 
            this.Situation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Situation.Caption = "";
            this.Situation.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Situation.CenterCaption = false;
            this.Situation.ComboBoxMultiForms = null;
            this.Situation.ComponentBackColor = System.Drawing.Color.White;
            this.Situation.DefaultValue = false;
            this.Situation.Disable = true;
            this.Situation.DisplayMember = "";
            this.Situation.FieldValid = true;
            this.Situation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Situation.Form = null;
            this.Situation.FormType = null;
            this.Situation.IsDependecyUkey = false;
            this.Situation.Location = new System.Drawing.Point(442, 9);
            this.Situation.Name = "Situation";
            this.Situation.ObjectControl = null;
            this.Situation.ObjetoApp = null;
            this.Situation.Others = null;
            this.Situation.PropertyControl = null;
            this.Situation.PropertyDependecyUkey = null;
            this.Situation.Size = new System.Drawing.Size(142, 53);
            this.Situation.StandardValue = null;
            this.Situation.TabIndex = 17;
            this.Situation.TabStop = false;
            this.Situation.Text = "sComboBox1";
            this.Situation.ToolTipContext = null;
            this.Situation.Validations = null;
            this.Situation.ValueControl = null;
            this.Situation.ValueMember = "";
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Description.Location = new System.Drawing.Point(152, 9);
            this.Description.Name = "Description";
            this.Description.ObjectControl = null;
            this.Description.ObjetoApp = null;
            this.Description.Others = null;
            this.Description.PropertyControl = null;
            this.Description.PropertyDependecyUkey = null;
            this.Description.Size = new System.Drawing.Size(284, 53);
            this.Description.TabIndex = 16;
            this.Description.TabStop = false;
            this.Description.Text = "sTextBox1";
            this.Description.ToolTipContext = null;
            this.Description.Validations = null;
            this.Description.ValueControl = "";
            // 
            // LegalPersonId
            // 
            this.LegalPersonId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LegalPersonId.Caption = "";
            this.LegalPersonId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.LegalPersonId.CenterCaption = false;
            this.LegalPersonId.ComboBoxMultiForms = null;
            this.LegalPersonId.ComponentBackColor = System.Drawing.Color.White;
            this.LegalPersonId.DefaultValue = false;
            this.LegalPersonId.Disable = true;
            this.LegalPersonId.DisplayMember = "";
            this.LegalPersonId.FieldValid = true;
            this.LegalPersonId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LegalPersonId.Form = null;
            this.LegalPersonId.FormType = null;
            this.LegalPersonId.IsDependecyUkey = false;
            this.LegalPersonId.Location = new System.Drawing.Point(12, 68);
            this.LegalPersonId.Name = "LegalPersonId";
            this.LegalPersonId.ObjectControl = null;
            this.LegalPersonId.ObjetoApp = null;
            this.LegalPersonId.Others = null;
            this.LegalPersonId.PropertyControl = null;
            this.LegalPersonId.PropertyDependecyUkey = null;
            this.LegalPersonId.Size = new System.Drawing.Size(572, 53);
            this.LegalPersonId.StandardValue = null;
            this.LegalPersonId.TabIndex = 18;
            this.LegalPersonId.TabStop = false;
            this.LegalPersonId.Text = "sComboBox1";
            this.LegalPersonId.ToolTipContext = null;
            this.LegalPersonId.Validations = null;
            this.LegalPersonId.ValueControl = null;
            this.LegalPersonId.ValueMember = "";
            // 
            // DiscountValueReal
            // 
            this.DiscountValueReal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountValueReal.Caption = "";
            this.DiscountValueReal.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DiscountValueReal.CenterCaption = false;
            this.DiscountValueReal.ComponentBackColor = System.Drawing.Color.White;
            this.DiscountValueReal.DecimalPlaces = 2;
            this.DiscountValueReal.Disable = true;
            this.DiscountValueReal.FieldValid = true;
            this.DiscountValueReal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DiscountValueReal.Form = null;
            this.DiscountValueReal.FormType = null;
            this.DiscountValueReal.IsDependecyUkey = false;
            this.DiscountValueReal.Location = new System.Drawing.Point(12, 188);
            this.DiscountValueReal.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.DiscountValueReal.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.DiscountValueReal.Name = "DiscountValueReal";
            this.DiscountValueReal.ObjectControl = null;
            this.DiscountValueReal.ObjetoApp = null;
            this.DiscountValueReal.Others = null;
            this.DiscountValueReal.PropertyControl = null;
            this.DiscountValueReal.PropertyDependecyUkey = null;
            this.DiscountValueReal.Size = new System.Drawing.Size(572, 56);
            this.DiscountValueReal.TabIndex = 19;
            this.DiscountValueReal.TabStop = false;
            this.DiscountValueReal.Text = "sNumeric1";
            this.DiscountValueReal.ThousandsSeparator = true;
            this.DiscountValueReal.ToolTipContext = null;
            this.DiscountValueReal.Validations = null;
            this.DiscountValueReal.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // DiscountValuePorcent
            // 
            this.DiscountValuePorcent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountValuePorcent.Caption = "";
            this.DiscountValuePorcent.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DiscountValuePorcent.CenterCaption = false;
            this.DiscountValuePorcent.ComponentBackColor = System.Drawing.Color.White;
            this.DiscountValuePorcent.DecimalPlaces = 2;
            this.DiscountValuePorcent.Disable = true;
            this.DiscountValuePorcent.FieldValid = true;
            this.DiscountValuePorcent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DiscountValuePorcent.Form = null;
            this.DiscountValuePorcent.FormType = null;
            this.DiscountValuePorcent.IsDependecyUkey = false;
            this.DiscountValuePorcent.Location = new System.Drawing.Point(12, 250);
            this.DiscountValuePorcent.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.DiscountValuePorcent.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.DiscountValuePorcent.Name = "DiscountValuePorcent";
            this.DiscountValuePorcent.ObjectControl = null;
            this.DiscountValuePorcent.ObjetoApp = null;
            this.DiscountValuePorcent.Others = null;
            this.DiscountValuePorcent.PropertyControl = null;
            this.DiscountValuePorcent.PropertyDependecyUkey = null;
            this.DiscountValuePorcent.Size = new System.Drawing.Size(572, 56);
            this.DiscountValuePorcent.TabIndex = 20;
            this.DiscountValuePorcent.TabStop = false;
            this.DiscountValuePorcent.Text = "sNumeric1";
            this.DiscountValuePorcent.ThousandsSeparator = true;
            this.DiscountValuePorcent.ToolTipContext = null;
            this.DiscountValuePorcent.Validations = null;
            this.DiscountValuePorcent.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            this.Code.Others = null;
            this.Code.PropertyControl = null;
            this.Code.PropertyDependecyUkey = null;
            this.Code.Size = new System.Drawing.Size(134, 53);
            this.Code.TabIndex = 21;
            this.Code.TabStop = false;
            this.Code.Text = "sTextBox1";
            this.Code.ToolTipContext = null;
            this.Code.Validations = null;
            this.Code.ValueControl = "";
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
            this.ParkingFinalHour.Location = new System.Drawing.Point(386, 129);
            this.ParkingFinalHour.Name = "ParkingFinalHour";
            this.ParkingFinalHour.ObjectControl = null;
            this.ParkingFinalHour.ObjetoApp = null;
            this.ParkingFinalHour.Others = null;
            this.ParkingFinalHour.PropertyControl = null;
            this.ParkingFinalHour.PropertyDependecyUkey = null;
            this.ParkingFinalHour.Size = new System.Drawing.Size(198, 53);
            this.ParkingFinalHour.TabIndex = 24;
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
            this.ParkingFixedTime.Location = new System.Drawing.Point(12, 150);
            this.ParkingFixedTime.Name = "ParkingFixedTime";
            this.ParkingFixedTime.ObjectControl = null;
            this.ParkingFixedTime.ObjetoApp = null;
            this.ParkingFixedTime.Others = null;
            this.ParkingFixedTime.PropertyControl = null;
            this.ParkingFixedTime.PropertyDependecyUkey = null;
            this.ParkingFixedTime.Size = new System.Drawing.Size(164, 23);
            this.ParkingFixedTime.TabIndex = 22;
            this.ParkingFixedTime.TabStop = false;
            this.ParkingFixedTime.Text = "sCheckBox1";
            this.ParkingFixedTime.ToolTipContext = null;
            this.ParkingFixedTime.Validations = null;
            this.ParkingFixedTime.ValueControl = false;
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
            this.ParkingStartingTime.Location = new System.Drawing.Point(182, 129);
            this.ParkingStartingTime.Name = "ParkingStartingTime";
            this.ParkingStartingTime.ObjectControl = null;
            this.ParkingStartingTime.ObjetoApp = null;
            this.ParkingStartingTime.Others = null;
            this.ParkingStartingTime.PropertyControl = null;
            this.ParkingStartingTime.PropertyDependecyUkey = null;
            this.ParkingStartingTime.Size = new System.Drawing.Size(198, 53);
            this.ParkingStartingTime.TabIndex = 23;
            this.ParkingStartingTime.TabStop = false;
            this.ParkingStartingTime.Text = "sDateTimePicker1";
            this.ParkingStartingTime.ToolTipContext = null;
            this.ParkingStartingTime.Validations = null;
            this.ParkingStartingTime.ValueControl = new System.DateTime(2017, 10, 15, 10, 35, 0, 600);
            // 
            // FParkingAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 481);
            this.Name = "FParkingAgreement";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private Core.Component.SCheckBox Holiday;
        private Core.Component.SCheckBox Sunday;
        private Core.Component.SCheckBox Saturday;
        private Core.Component.SCheckBox Friday;
        private Core.Component.SCheckBox Thursday;
        private Core.Component.SCheckBox Wednesday;
        private Core.Component.SCheckBox Tuesday;
        private Core.Component.SCheckBox Monday;
        private Core.Component.SComboBox LegalPersonId;
        private Core.Component.SComboBox Situation;
        private Core.Component.STextBox Description;
        private Core.Component.SNumeric DiscountValuePorcent;
        private Core.Component.SNumeric DiscountValueReal;
        private Core.Component.STextBox Code;
        private Core.Component.SDateTimePicker ParkingFinalHour;
        private Core.Component.SCheckBox ParkingFixedTime;
        private Core.Component.SDateTimePicker ParkingStartingTime;
    }
}