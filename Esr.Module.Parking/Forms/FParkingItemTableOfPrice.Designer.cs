namespace Esr.Module.Parking.Forms
{
    partial class FParkingItemTableOfPrice
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TimeOvertime = new Esr.Core.Component.SNumeric();
            this.TypeTimeOvertime = new Esr.Core.Component.SComboBox();
            this.sLabel1 = new Esr.Core.Component.SLabel();
            this.Situation = new Esr.Core.Component.SComboBox();
            this.MaxinumPrice = new Esr.Core.Component.SNumeric();
            this.ValueOvertime = new Esr.Core.Component.SNumeric();
            this.Description = new Esr.Core.Component.STextBox();
            this.Tolerance = new Esr.Core.Component.SNumeric();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Holiday = new Esr.Core.Component.SCheckBox();
            this.Sunday = new Esr.Core.Component.SCheckBox();
            this.Saturday = new Esr.Core.Component.SCheckBox();
            this.Friday = new Esr.Core.Component.SCheckBox();
            this.Thursday = new Esr.Core.Component.SCheckBox();
            this.Wednesday = new Esr.Core.Component.SCheckBox();
            this.Tuesday = new Esr.Core.Component.SCheckBox();
            this.Monday = new Esr.Core.Component.SCheckBox();
            this.ParkingHoursVariations = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ParkingHoursVariations);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Size = new System.Drawing.Size(626, 519);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TimeOvertime);
            this.groupBox2.Controls.Add(this.TypeTimeOvertime);
            this.groupBox2.Controls.Add(this.sLabel1);
            this.groupBox2.Controls.Add(this.Situation);
            this.groupBox2.Controls.Add(this.MaxinumPrice);
            this.groupBox2.Controls.Add(this.ValueOvertime);
            this.groupBox2.Controls.Add(this.Description);
            this.groupBox2.Controls.Add(this.Tolerance);
            this.groupBox2.Location = new System.Drawing.Point(11, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 266);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Serviço";
            // 
            // TimeOvertime
            // 
            this.TimeOvertime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeOvertime.Caption = "";
            this.TimeOvertime.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TimeOvertime.CenterCaption = false;
            this.TimeOvertime.ComponentBackColor = System.Drawing.Color.White;
            this.TimeOvertime.DecimalPlaces = 0;
            this.TimeOvertime.Disable = true;
            this.TimeOvertime.DisabledAutomaticNumbering = false;
            this.TimeOvertime.FieldValid = true;
            this.TimeOvertime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TimeOvertime.Form = null;
            this.TimeOvertime.FormType = null;
            this.TimeOvertime.IsDependecyUkey = false;
            this.TimeOvertime.Location = new System.Drawing.Point(6, 136);
            this.TimeOvertime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.TimeOvertime.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TimeOvertime.Name = "TimeOvertime";
            this.TimeOvertime.ObjectControl = null;
            this.TimeOvertime.ObjetoApp = null;
            this.TimeOvertime.Others = null;
            this.TimeOvertime.PropertyControl = null;
            this.TimeOvertime.PropertyDependecyUkey = null;
            this.TimeOvertime.Size = new System.Drawing.Size(127, 56);
            this.TimeOvertime.TabIndex = 13;
            this.TimeOvertime.TabStop = false;
            this.TimeOvertime.Text = "sNumeric1";
            this.TimeOvertime.ThousandsSeparator = true;
            this.TimeOvertime.ToolTipContext = null;
            this.TimeOvertime.Validations = null;
            this.TimeOvertime.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TypeTimeOvertime
            // 
            this.TypeTimeOvertime.Caption = "";
            this.TypeTimeOvertime.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypeTimeOvertime.CenterCaption = false;
            this.TypeTimeOvertime.ComboBoxMultiForms = null;
            this.TypeTimeOvertime.ComponentBackColor = System.Drawing.Color.White;
            this.TypeTimeOvertime.DefaultValue = false;
            this.TypeTimeOvertime.Disable = true;
            this.TypeTimeOvertime.DisabledAutomaticNumbering = false;
            this.TypeTimeOvertime.DisplayMember = "";
            this.TypeTimeOvertime.FieldValid = true;
            this.TypeTimeOvertime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeTimeOvertime.Form = null;
            this.TypeTimeOvertime.FormType = null;
            this.TypeTimeOvertime.IsDependecyUkey = false;
            this.TypeTimeOvertime.Location = new System.Drawing.Point(139, 136);
            this.TypeTimeOvertime.Name = "TypeTimeOvertime";
            this.TypeTimeOvertime.ObjectControl = null;
            this.TypeTimeOvertime.ObjetoApp = null;
            this.TypeTimeOvertime.Others = null;
            this.TypeTimeOvertime.PropertyControl = null;
            this.TypeTimeOvertime.PropertyDependecyUkey = null;
            this.TypeTimeOvertime.PropertySearch = null;
            this.TypeTimeOvertime.Size = new System.Drawing.Size(139, 56);
            this.TypeTimeOvertime.StandardValue = null;
            this.TypeTimeOvertime.TabIndex = 12;
            this.TypeTimeOvertime.TabStop = false;
            this.TypeTimeOvertime.Text = "sComboBox1";
            this.TypeTimeOvertime.ToolTipContext = null;
            this.TypeTimeOvertime.Validations = null;
            this.TypeTimeOvertime.ValueControl = null;
            this.TypeTimeOvertime.ValueMember = "";
            // 
            // sLabel1
            // 
            this.sLabel1.AutoSize = true;
            this.sLabel1.Location = new System.Drawing.Point(284, 105);
            this.sLabel1.Name = "sLabel1";
            this.sLabel1.Size = new System.Drawing.Size(93, 21);
            this.sLabel1.TabIndex = 11;
            this.sLabel1.Text = "Em minutos";
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
            this.Situation.DisabledAutomaticNumbering = false;
            this.Situation.DisplayMember = "";
            this.Situation.FieldValid = true;
            this.Situation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Situation.Form = null;
            this.Situation.FormType = null;
            this.Situation.IsDependecyUkey = false;
            this.Situation.Location = new System.Drawing.Point(284, 24);
            this.Situation.Name = "Situation";
            this.Situation.ObjectControl = null;
            this.Situation.ObjetoApp = null;
            this.Situation.Others = null;
            this.Situation.PropertyControl = null;
            this.Situation.PropertyDependecyUkey = null;
            this.Situation.PropertySearch = null;
            this.Situation.Size = new System.Drawing.Size(142, 53);
            this.Situation.StandardValue = null;
            this.Situation.TabIndex = 10;
            this.Situation.TabStop = false;
            this.Situation.Text = "sComboBox1";
            this.Situation.ToolTipContext = null;
            this.Situation.Validations = null;
            this.Situation.ValueControl = null;
            this.Situation.ValueMember = "";
            // 
            // MaxinumPrice
            // 
            this.MaxinumPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxinumPrice.Caption = "";
            this.MaxinumPrice.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.MaxinumPrice.CenterCaption = false;
            this.MaxinumPrice.ComponentBackColor = System.Drawing.Color.White;
            this.MaxinumPrice.DecimalPlaces = 2;
            this.MaxinumPrice.Disable = true;
            this.MaxinumPrice.DisabledAutomaticNumbering = false;
            this.MaxinumPrice.FieldValid = true;
            this.MaxinumPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MaxinumPrice.Form = null;
            this.MaxinumPrice.FormType = null;
            this.MaxinumPrice.IsDependecyUkey = false;
            this.MaxinumPrice.Location = new System.Drawing.Point(6, 198);
            this.MaxinumPrice.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.MaxinumPrice.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.MaxinumPrice.Name = "MaxinumPrice";
            this.MaxinumPrice.ObjectControl = null;
            this.MaxinumPrice.ObjetoApp = null;
            this.MaxinumPrice.Others = null;
            this.MaxinumPrice.PropertyControl = null;
            this.MaxinumPrice.PropertyDependecyUkey = null;
            this.MaxinumPrice.Size = new System.Drawing.Size(420, 56);
            this.MaxinumPrice.TabIndex = 9;
            this.MaxinumPrice.TabStop = false;
            this.MaxinumPrice.Text = "sNumeric2";
            this.MaxinumPrice.ThousandsSeparator = true;
            this.MaxinumPrice.ToolTipContext = null;
            this.MaxinumPrice.Validations = null;
            this.MaxinumPrice.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // ValueOvertime
            // 
            this.ValueOvertime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueOvertime.Caption = "";
            this.ValueOvertime.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ValueOvertime.CenterCaption = false;
            this.ValueOvertime.ComponentBackColor = System.Drawing.Color.White;
            this.ValueOvertime.DecimalPlaces = 2;
            this.ValueOvertime.Disable = true;
            this.ValueOvertime.DisabledAutomaticNumbering = false;
            this.ValueOvertime.FieldValid = true;
            this.ValueOvertime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ValueOvertime.Form = null;
            this.ValueOvertime.FormType = null;
            this.ValueOvertime.IsDependecyUkey = false;
            this.ValueOvertime.Location = new System.Drawing.Point(284, 136);
            this.ValueOvertime.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ValueOvertime.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ValueOvertime.Name = "ValueOvertime";
            this.ValueOvertime.ObjectControl = null;
            this.ValueOvertime.ObjetoApp = null;
            this.ValueOvertime.Others = null;
            this.ValueOvertime.PropertyControl = null;
            this.ValueOvertime.PropertyDependecyUkey = null;
            this.ValueOvertime.Size = new System.Drawing.Size(143, 56);
            this.ValueOvertime.TabIndex = 8;
            this.ValueOvertime.TabStop = false;
            this.ValueOvertime.Text = "sNumeric1";
            this.ValueOvertime.ThousandsSeparator = true;
            this.ValueOvertime.ToolTipContext = null;
            this.ValueOvertime.Validations = null;
            this.ValueOvertime.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            this.Description.DisabledAutomaticNumbering = false;
            this.Description.FieldValid = true;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Description.Form = null;
            this.Description.FormType = null;
            this.Description.IsDependecyUkey = false;
            this.Description.Location = new System.Drawing.Point(6, 24);
            this.Description.Name = "Description";
            this.Description.ObjectControl = null;
            this.Description.ObjetoApp = null;
            this.Description.Others = null;
            this.Description.PropertyControl = null;
            this.Description.PropertyDependecyUkey = null;
            this.Description.Size = new System.Drawing.Size(272, 53);
            this.Description.TabIndex = 7;
            this.Description.TabStop = false;
            this.Description.Text = "sTextBox1";
            this.Description.ToolTipContext = null;
            this.Description.Validations = null;
            this.Description.ValueControl = "";
            // 
            // Tolerance
            // 
            this.Tolerance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tolerance.Caption = "";
            this.Tolerance.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Tolerance.CenterCaption = false;
            this.Tolerance.ComponentBackColor = System.Drawing.Color.White;
            this.Tolerance.DecimalPlaces = 0;
            this.Tolerance.Disable = true;
            this.Tolerance.DisabledAutomaticNumbering = false;
            this.Tolerance.FieldValid = true;
            this.Tolerance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Tolerance.Form = null;
            this.Tolerance.FormType = null;
            this.Tolerance.IsDependecyUkey = false;
            this.Tolerance.Location = new System.Drawing.Point(6, 80);
            this.Tolerance.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Tolerance.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Tolerance.Name = "Tolerance";
            this.Tolerance.ObjectControl = null;
            this.Tolerance.ObjetoApp = null;
            this.Tolerance.Others = null;
            this.Tolerance.PropertyControl = null;
            this.Tolerance.PropertyDependecyUkey = null;
            this.Tolerance.Size = new System.Drawing.Size(272, 56);
            this.Tolerance.TabIndex = 6;
            this.Tolerance.TabStop = false;
            this.Tolerance.Text = "sNumeric1";
            this.Tolerance.ThousandsSeparator = true;
            this.Tolerance.ToolTipContext = null;
            this.Tolerance.Validations = null;
            this.Tolerance.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            this.groupBox3.Location = new System.Drawing.Point(450, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 266);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dias de funcionamento";
            // 
            // Holiday
            // 
            this.Holiday.Caption = "";
            this.Holiday.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Holiday.CenterCaption = false;
            this.Holiday.ComponentBackColor = System.Drawing.Color.White;
            this.Holiday.Disable = true;
            this.Holiday.DisabledAutomaticNumbering = false;
            this.Holiday.FieldValid = true;
            this.Holiday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Holiday.Form = null;
            this.Holiday.FormType = null;
            this.Holiday.IsDependecyUkey = false;
            this.Holiday.Location = new System.Drawing.Point(16, 229);
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
            this.Sunday.DisabledAutomaticNumbering = false;
            this.Sunday.FieldValid = true;
            this.Sunday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Sunday.Form = null;
            this.Sunday.FormType = null;
            this.Sunday.IsDependecyUkey = false;
            this.Sunday.Location = new System.Drawing.Point(16, 201);
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
            this.Saturday.DisabledAutomaticNumbering = false;
            this.Saturday.FieldValid = true;
            this.Saturday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Saturday.Form = null;
            this.Saturday.FormType = null;
            this.Saturday.IsDependecyUkey = false;
            this.Saturday.Location = new System.Drawing.Point(16, 173);
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
            this.Friday.DisabledAutomaticNumbering = false;
            this.Friday.FieldValid = true;
            this.Friday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Friday.Form = null;
            this.Friday.FormType = null;
            this.Friday.IsDependecyUkey = false;
            this.Friday.Location = new System.Drawing.Point(16, 145);
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
            this.Thursday.DisabledAutomaticNumbering = false;
            this.Thursday.FieldValid = true;
            this.Thursday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Thursday.Form = null;
            this.Thursday.FormType = null;
            this.Thursday.IsDependecyUkey = false;
            this.Thursday.Location = new System.Drawing.Point(16, 117);
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
            this.Wednesday.DisabledAutomaticNumbering = false;
            this.Wednesday.FieldValid = true;
            this.Wednesday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Wednesday.Form = null;
            this.Wednesday.FormType = null;
            this.Wednesday.IsDependecyUkey = false;
            this.Wednesday.Location = new System.Drawing.Point(16, 89);
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
            this.Tuesday.DisabledAutomaticNumbering = false;
            this.Tuesday.FieldValid = true;
            this.Tuesday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Tuesday.Form = null;
            this.Tuesday.FormType = null;
            this.Tuesday.IsDependecyUkey = false;
            this.Tuesday.Location = new System.Drawing.Point(16, 61);
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
            this.Monday.DisabledAutomaticNumbering = false;
            this.Monday.FieldValid = true;
            this.Monday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Monday.Form = null;
            this.Monday.FormType = null;
            this.Monday.IsDependecyUkey = false;
            this.Monday.Location = new System.Drawing.Point(16, 33);
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
            // ParkingHoursVariations
            // 
            this.ParkingHoursVariations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParkingHoursVariations.ButtonAction = Esr.Core.Component.ButtonAction.None;
            this.ParkingHoursVariations.Caption = "";
            this.ParkingHoursVariations.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ParkingHoursVariations.CenterCaption = false;
            this.ParkingHoursVariations.ComponentBackColor = System.Drawing.Color.White;
            this.ParkingHoursVariations.Disable = true;
            this.ParkingHoursVariations.DisabledAutomaticNumbering = false;
            this.ParkingHoursVariations.FieldValid = true;
            this.ParkingHoursVariations.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ParkingHoursVariations.Form = null;
            this.ParkingHoursVariations.FormType = null;
            this.ParkingHoursVariations.IsDependecyUkey = false;
            this.ParkingHoursVariations.IsSearch = false;
            this.ParkingHoursVariations.ListColunas = null;
            this.ParkingHoursVariations.Location = new System.Drawing.Point(11, 277);
            this.ParkingHoursVariations.Name = "ParkingHoursVariations";
            this.ParkingHoursVariations.ObjectControl = null;
            this.ParkingHoursVariations.ObjetoApp = null;
            this.ParkingHoursVariations.Others = null;
            this.ParkingHoursVariations.PropertyControl = null;
            this.ParkingHoursVariations.PropertyDependecyUkey = null;
            this.ParkingHoursVariations.PropertyInfos = null;
            this.ParkingHoursVariations.ScreenSecondary = false;
            this.ParkingHoursVariations.Size = new System.Drawing.Size(608, 238);
            this.ParkingHoursVariations.TabIndex = 15;
            this.ParkingHoursVariations.TabStop = false;
            this.ParkingHoursVariations.Text = "sGrid1";
            this.ParkingHoursVariations.ToolTipContext = null;
            this.ParkingHoursVariations.Validations = null;
            this.ParkingHoursVariations.ValueControl = null;
            // 
            // FParkingItemTableOfPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 683);
            this.Name = "FParkingItemTableOfPrice";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private Core.Component.SNumeric Tolerance;
        private Core.Component.STextBox Description;
        private Core.Component.SNumeric MaxinumPrice;
        private Core.Component.SNumeric ValueOvertime;
        private Core.Component.SGrid ParkingHoursVariations;
        private Core.Component.SComboBox Situation;
        private Core.Component.SLabel sLabel1;
        private Core.Component.SNumeric TimeOvertime;
        private Core.Component.SComboBox TypeTimeOvertime;
    }
}