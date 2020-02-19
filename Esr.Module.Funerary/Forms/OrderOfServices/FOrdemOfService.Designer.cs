namespace Esr.Module.Funerary.Forms.OrderOfServices
{
    partial class FOrdemOfService
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOrdemOfService));
            this.sTabControl1 = new Esr.Core.Component.STabControl();
            this.OsInformation = new System.Windows.Forms.TabPage();
            this.Id = new Esr.Core.Component.SNumeric();
            this.PlaceOfDead = new Esr.Core.Component.STextBox();
            this.BurialTime = new Esr.Core.Component.SDateTimePicker();
            this.BurialDate = new Esr.Core.Component.SDateTimePicker();
            this.DateOfDead = new Esr.Core.Component.SDateTimePicker();
            this.GeneralInformation = new Esr.Core.Component.SRichText();
            this.ContractorId = new Esr.Core.Component.SComboBox();
            this.PlanId = new Esr.Core.Component.SComboBox();
            this.PlanHolder = new Esr.Core.Component.STextBox();
            this.Phone2 = new Esr.Core.Component.SMasckEdit();
            this.Phone1 = new Esr.Core.Component.SMasckEdit();
            this.ResponsibleName = new Esr.Core.Component.STextBox();
            this.HeightDeceadesed = new Esr.Core.Component.SNumeric();
            this.WeigthDeceadesed = new Esr.Core.Component.SNumeric();
            this.BurialPlace = new Esr.Core.Component.STextBox();
            this.WakeLocation = new Esr.Core.Component.STextBox();
            this.DeadName = new Esr.Core.Component.STextBox();
            this.ContractualNote = new Esr.Core.Component.STextBox();
            this.Sinister = new Esr.Core.Component.STextBox();
            this.NumberOs = new Esr.Core.Component.STextBox();
            this.tabPageDocument = new System.Windows.Forms.TabPage();
            this.OsDocuments = new Esr.Core.Component.SGrid();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.OsProducts = new Esr.Core.Component.SGrid();
            this.tabPageService = new System.Windows.Forms.TabPage();
            this.OsServices = new Esr.Core.Component.SGrid();
            this.tabPageContractorService = new System.Windows.Forms.TabPage();
            this.OsContractorServices = new Esr.Core.Component.SGrid();
            this.tabPageServiceFleet = new System.Windows.Forms.TabPage();
            this.OsVehicles = new Esr.Core.Component.SGrid();
            this.tabPageContractorProduct = new System.Windows.Forms.TabPage();
            this.OsContractorProducts = new Esr.Core.Component.SGrid();
            this.DateOfIssure = new Esr.Core.Component.SDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.sTabControl1.SuspendLayout();
            this.OsInformation.SuspendLayout();
            this.tabPageDocument.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            this.tabPageService.SuspendLayout();
            this.tabPageContractorService.SuspendLayout();
            this.tabPageServiceFleet.SuspendLayout();
            this.tabPageContractorProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sTabControl1);
            this.panel1.Size = new System.Drawing.Size(1225, 460);
            // 
            // sTabControl1
            // 
            this.sTabControl1.Controls.Add(this.OsInformation);
            this.sTabControl1.Controls.Add(this.tabPageDocument);
            this.sTabControl1.Controls.Add(this.tabPageProduct);
            this.sTabControl1.Controls.Add(this.tabPageService);
            this.sTabControl1.Controls.Add(this.tabPageContractorService);
            this.sTabControl1.Controls.Add(this.tabPageServiceFleet);
            this.sTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTabControl1.Location = new System.Drawing.Point(0, 0);
            this.sTabControl1.Name = "sTabControl1";
            this.sTabControl1.SelectedIndex = 0;
            this.sTabControl1.Size = new System.Drawing.Size(1225, 460);
            this.sTabControl1.TabIndex = 17;
            // 
            // OsInformation
            // 
            this.OsInformation.Controls.Add(this.DateOfIssure);
            this.OsInformation.Controls.Add(this.Id);
            this.OsInformation.Controls.Add(this.PlaceOfDead);
            this.OsInformation.Controls.Add(this.BurialTime);
            this.OsInformation.Controls.Add(this.BurialDate);
            this.OsInformation.Controls.Add(this.DateOfDead);
            this.OsInformation.Controls.Add(this.GeneralInformation);
            this.OsInformation.Controls.Add(this.ContractorId);
            this.OsInformation.Controls.Add(this.PlanId);
            this.OsInformation.Controls.Add(this.PlanHolder);
            this.OsInformation.Controls.Add(this.Phone2);
            this.OsInformation.Controls.Add(this.Phone1);
            this.OsInformation.Controls.Add(this.ResponsibleName);
            this.OsInformation.Controls.Add(this.HeightDeceadesed);
            this.OsInformation.Controls.Add(this.WeigthDeceadesed);
            this.OsInformation.Controls.Add(this.BurialPlace);
            this.OsInformation.Controls.Add(this.WakeLocation);
            this.OsInformation.Controls.Add(this.DeadName);
            this.OsInformation.Controls.Add(this.ContractualNote);
            this.OsInformation.Controls.Add(this.Sinister);
            this.OsInformation.Controls.Add(this.NumberOs);
            this.OsInformation.Location = new System.Drawing.Point(4, 26);
            this.OsInformation.Name = "OsInformation";
            this.OsInformation.Padding = new System.Windows.Forms.Padding(3);
            this.OsInformation.Size = new System.Drawing.Size(1217, 430);
            this.OsInformation.TabIndex = 6;
            this.OsInformation.Text = "Informações da OS";
            this.OsInformation.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.Caption = "";
            this.Id.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Id.CenterCaption = false;
            this.Id.ComponentBackColor = System.Drawing.Color.White;
            this.Id.DecimalPlaces = 0;
            this.Id.Disable = true;
            this.Id.FieldValid = true;
            this.Id.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Id.Form = null;
            this.Id.FormType = null;
            this.Id.IsDependecyUkey = false;
            this.Id.Location = new System.Drawing.Point(9, 6);
            this.Id.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Id.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Id.Name = "Id";
            this.Id.ObjectControl = null;
            this.Id.ObjetoApp = null;
            this.Id.Others = null;
            this.Id.PropertyControl = null;
            this.Id.PropertyDependecyUkey = null;
            this.Id.Size = new System.Drawing.Size(128, 54);
            this.Id.TabIndex = 37;
            this.Id.TabStop = false;
            this.Id.ThousandsSeparator = false;
            this.Id.ToolTipContext = null;
            this.Id.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Id.Validations")));
            this.Id.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // PlaceOfDead
            // 
            this.PlaceOfDead.Caption = "";
            this.PlaceOfDead.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.PlaceOfDead.CenterCaption = false;
            this.PlaceOfDead.ComponentBackColor = System.Drawing.Color.White;
            this.PlaceOfDead.Disable = true;
            this.PlaceOfDead.FieldValid = true;
            this.PlaceOfDead.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PlaceOfDead.Form = null;
            this.PlaceOfDead.FormType = null;
            this.PlaceOfDead.IsDependecyUkey = false;
            this.PlaceOfDead.Location = new System.Drawing.Point(9, 126);
            this.PlaceOfDead.Name = "PlaceOfDead";
            this.PlaceOfDead.ObjectControl = null;
            this.PlaceOfDead.ObjetoApp = null;
            this.PlaceOfDead.Others = null;
            this.PlaceOfDead.PropertyControl = null;
            this.PlaceOfDead.PropertyDependecyUkey = null;
            this.PlaceOfDead.Size = new System.Drawing.Size(394, 54);
            this.PlaceOfDead.TabIndex = 10;
            this.PlaceOfDead.TabStop = false;
            this.PlaceOfDead.Text = "sTextBox1";
            this.PlaceOfDead.ToolTipContext = null;
            this.PlaceOfDead.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("PlaceOfDead.Validations")));
            this.PlaceOfDead.ValueControl = "";
            // 
            // BurialTime
            // 
            this.BurialTime.Caption = "";
            this.BurialTime.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.BurialTime.CenterCaption = false;
            this.BurialTime.ComponentBackColor = System.Drawing.Color.White;
            this.BurialTime.CustomFormat = null;
            this.BurialTime.Disable = true;
            this.BurialTime.FieldValid = true;
            this.BurialTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BurialTime.Form = null;
            this.BurialTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.BurialTime.FormType = null;
            this.BurialTime.IsDependecyUkey = false;
            this.BurialTime.Location = new System.Drawing.Point(361, 186);
            this.BurialTime.Name = "BurialTime";
            this.BurialTime.ObjectControl = null;
            this.BurialTime.ObjetoApp = null;
            this.BurialTime.Others = null;
            this.BurialTime.PropertyControl = null;
            this.BurialTime.PropertyDependecyUkey = null;
            this.BurialTime.Size = new System.Drawing.Size(179, 53);
            this.BurialTime.TabIndex = 15;
            this.BurialTime.TabStop = false;
            this.BurialTime.Text = "sDateTimePicker3";
            this.BurialTime.ToolTipContext = null;
            this.BurialTime.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("BurialTime.Validations")));
            this.BurialTime.ValueControl = new System.DateTime(2016, 12, 20, 22, 32, 46, 164);
            // 
            // BurialDate
            // 
            this.BurialDate.Caption = "";
            this.BurialDate.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.BurialDate.CenterCaption = false;
            this.BurialDate.ComponentBackColor = System.Drawing.Color.White;
            this.BurialDate.CustomFormat = null;
            this.BurialDate.Disable = true;
            this.BurialDate.FieldValid = true;
            this.BurialDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BurialDate.Form = null;
            this.BurialDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BurialDate.FormType = null;
            this.BurialDate.IsDependecyUkey = false;
            this.BurialDate.Location = new System.Drawing.Point(179, 186);
            this.BurialDate.Name = "BurialDate";
            this.BurialDate.ObjectControl = null;
            this.BurialDate.ObjetoApp = null;
            this.BurialDate.Others = null;
            this.BurialDate.PropertyControl = null;
            this.BurialDate.PropertyDependecyUkey = null;
            this.BurialDate.Size = new System.Drawing.Size(176, 53);
            this.BurialDate.TabIndex = 14;
            this.BurialDate.TabStop = false;
            this.BurialDate.Text = "sDateTimePicker2";
            this.BurialDate.ToolTipContext = null;
            this.BurialDate.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("BurialDate.Validations")));
            this.BurialDate.ValueControl = new System.DateTime(2016, 12, 20, 22, 32, 46, 164);
            // 
            // DateOfDead
            // 
            this.DateOfDead.Caption = "";
            this.DateOfDead.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DateOfDead.CenterCaption = false;
            this.DateOfDead.ComponentBackColor = System.Drawing.Color.White;
            this.DateOfDead.CustomFormat = null;
            this.DateOfDead.Disable = true;
            this.DateOfDead.FieldValid = true;
            this.DateOfDead.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DateOfDead.Form = null;
            this.DateOfDead.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfDead.FormType = null;
            this.DateOfDead.IsDependecyUkey = false;
            this.DateOfDead.Location = new System.Drawing.Point(9, 186);
            this.DateOfDead.Name = "DateOfDead";
            this.DateOfDead.ObjectControl = null;
            this.DateOfDead.ObjetoApp = null;
            this.DateOfDead.Others = null;
            this.DateOfDead.PropertyControl = null;
            this.DateOfDead.PropertyDependecyUkey = null;
            this.DateOfDead.Size = new System.Drawing.Size(164, 53);
            this.DateOfDead.TabIndex = 13;
            this.DateOfDead.TabStop = false;
            this.DateOfDead.Text = "sDateTimePicker1";
            this.DateOfDead.ToolTipContext = null;
            this.DateOfDead.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("DateOfDead.Validations")));
            this.DateOfDead.ValueControl = new System.DateTime(2016, 12, 20, 22, 32, 46, 164);
            // 
            // GeneralInformation
            // 
            this.GeneralInformation.Caption = "";
            this.GeneralInformation.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.GeneralInformation.CenterCaption = false;
            this.GeneralInformation.ComponentBackColor = System.Drawing.Color.White;
            this.GeneralInformation.Disable = true;
            this.GeneralInformation.FieldValid = true;
            this.GeneralInformation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GeneralInformation.Form = null;
            this.GeneralInformation.FormType = null;
            this.GeneralInformation.IsDependecyUkey = false;
            this.GeneralInformation.Location = new System.Drawing.Point(8, 245);
            this.GeneralInformation.Name = "GeneralInformation";
            this.GeneralInformation.ObjectControl = null;
            this.GeneralInformation.ObjetoApp = null;
            this.GeneralInformation.Others = null;
            this.GeneralInformation.PropertyControl = null;
            this.GeneralInformation.PropertyDependecyUkey = null;
            this.GeneralInformation.Size = new System.Drawing.Size(1195, 179);
            this.GeneralInformation.TabIndex = 19;
            this.GeneralInformation.TabStop = false;
            this.GeneralInformation.Text = "sRichText1";
            this.GeneralInformation.ToolTipContext = null;
            this.GeneralInformation.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("GeneralInformation.Validations")));
            this.GeneralInformation.ValueControl = "";
            // 
            // ContractorId
            // 
            this.ContractorId.Caption = "";
            this.ContractorId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ContractorId.CenterCaption = false;
            this.ContractorId.ComboBoxMultiForms = null;
            this.ContractorId.ComponentBackColor = System.Drawing.Color.White;
            this.ContractorId.DefaultValue = false;
            this.ContractorId.Disable = true;
            this.ContractorId.DisplayMember = "";
            this.ContractorId.FieldValid = true;
            this.ContractorId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ContractorId.Form = null;
            this.ContractorId.FormType = null;
            this.ContractorId.IsDependecyUkey = false;
            this.ContractorId.Location = new System.Drawing.Point(903, 6);
            this.ContractorId.Name = "ContractorId";
            this.ContractorId.ObjectControl = null;
            this.ContractorId.ObjetoApp = null;
            this.ContractorId.Others = null;
            this.ContractorId.PropertyControl = null;
            this.ContractorId.PropertyDependecyUkey = null;
            this.ContractorId.Size = new System.Drawing.Size(300, 54);
            this.ContractorId.StandardValue = null;
            this.ContractorId.TabIndex = 5;
            this.ContractorId.TabStop = false;
            this.ContractorId.Text = "sComboBox1";
            this.ContractorId.ToolTipContext = null;
            this.ContractorId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ContractorId.Validations")));
            this.ContractorId.ValueControl = null;
            this.ContractorId.ValueMember = "";
            // 
            // PlanId
            // 
            this.PlanId.Caption = "";
            this.PlanId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.PlanId.CenterCaption = false;
            this.PlanId.ComboBoxMultiForms = null;
            this.PlanId.ComponentBackColor = System.Drawing.Color.White;
            this.PlanId.DefaultValue = false;
            this.PlanId.Disable = true;
            this.PlanId.DisplayMember = "";
            this.PlanId.FieldValid = true;
            this.PlanId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PlanId.Form = null;
            this.PlanId.FormType = null;
            this.PlanId.IsDependecyUkey = false;
            this.PlanId.Location = new System.Drawing.Point(695, 6);
            this.PlanId.Name = "PlanId";
            this.PlanId.ObjectControl = null;
            this.PlanId.ObjetoApp = null;
            this.PlanId.Others = null;
            this.PlanId.PropertyControl = null;
            this.PlanId.PropertyDependecyUkey = null;
            this.PlanId.Size = new System.Drawing.Size(202, 54);
            this.PlanId.StandardValue = null;
            this.PlanId.TabIndex = 4;
            this.PlanId.TabStop = false;
            this.PlanId.Text = "sComboBox1";
            this.PlanId.ToolTipContext = null;
            this.PlanId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("PlanId.Validations")));
            this.PlanId.ValueControl = null;
            this.PlanId.ValueMember = "";
            // 
            // PlanHolder
            // 
            this.PlanHolder.Caption = "";
            this.PlanHolder.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.PlanHolder.CenterCaption = false;
            this.PlanHolder.ComponentBackColor = System.Drawing.Color.White;
            this.PlanHolder.Disable = true;
            this.PlanHolder.FieldValid = true;
            this.PlanHolder.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PlanHolder.Form = null;
            this.PlanHolder.FormType = null;
            this.PlanHolder.IsDependecyUkey = false;
            this.PlanHolder.Location = new System.Drawing.Point(546, 187);
            this.PlanHolder.Name = "PlanHolder";
            this.PlanHolder.ObjectControl = null;
            this.PlanHolder.ObjetoApp = null;
            this.PlanHolder.Others = null;
            this.PlanHolder.PropertyControl = null;
            this.PlanHolder.PropertyDependecyUkey = null;
            this.PlanHolder.Size = new System.Drawing.Size(351, 54);
            this.PlanHolder.TabIndex = 16;
            this.PlanHolder.TabStop = false;
            this.PlanHolder.Text = "sTextBox1";
            this.PlanHolder.ToolTipContext = null;
            this.PlanHolder.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("PlanHolder.Validations")));
            this.PlanHolder.ValueControl = "";
            // 
            // Phone2
            // 
            this.Phone2.Caption = "";
            this.Phone2.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Phone2.CenterCaption = false;
            this.Phone2.ComponentBackColor = System.Drawing.Color.White;
            this.Phone2.Disable = true;
            this.Phone2.FieldValid = true;
            this.Phone2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Phone2.Form = null;
            this.Phone2.FormType = null;
            this.Phone2.IsDependecyUkey = false;
            this.Phone2.Location = new System.Drawing.Point(1045, 186);
            this.Phone2.Mask = "(99) 9 9999 - 9999";
            this.Phone2.Name = "Phone2";
            this.Phone2.ObjectControl = null;
            this.Phone2.ObjetoApp = null;
            this.Phone2.Others = null;
            this.Phone2.PropertyControl = null;
            this.Phone2.PropertyDependecyUkey = null;
            this.Phone2.Size = new System.Drawing.Size(154, 55);
            this.Phone2.TabIndex = 18;
            this.Phone2.TabStop = false;
            this.Phone2.Text = "sMasckEdit1";
            this.Phone2.ToolTipContext = null;
            this.Phone2.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Phone2.Validations")));
            this.Phone2.ValueControl = "(  )        - ";
            // 
            // Phone1
            // 
            this.Phone1.Caption = "";
            this.Phone1.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Phone1.CenterCaption = false;
            this.Phone1.ComponentBackColor = System.Drawing.Color.White;
            this.Phone1.Disable = true;
            this.Phone1.FieldValid = true;
            this.Phone1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Phone1.Form = null;
            this.Phone1.FormType = null;
            this.Phone1.IsDependecyUkey = false;
            this.Phone1.Location = new System.Drawing.Point(903, 187);
            this.Phone1.Mask = "(99) 99999 - 9999";
            this.Phone1.Name = "Phone1";
            this.Phone1.ObjectControl = null;
            this.Phone1.ObjetoApp = null;
            this.Phone1.Others = null;
            this.Phone1.PropertyControl = null;
            this.Phone1.PropertyDependecyUkey = null;
            this.Phone1.Size = new System.Drawing.Size(136, 55);
            this.Phone1.TabIndex = 17;
            this.Phone1.TabStop = false;
            this.Phone1.Text = "sMasckEdit1";
            this.Phone1.ToolTipContext = null;
            this.Phone1.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Phone1.Validations")));
            this.Phone1.ValueControl = "(  )       - ";
            // 
            // ResponsibleName
            // 
            this.ResponsibleName.Caption = "";
            this.ResponsibleName.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ResponsibleName.CenterCaption = false;
            this.ResponsibleName.ComponentBackColor = System.Drawing.Color.White;
            this.ResponsibleName.Disable = true;
            this.ResponsibleName.FieldValid = true;
            this.ResponsibleName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ResponsibleName.Form = null;
            this.ResponsibleName.FormType = null;
            this.ResponsibleName.IsDependecyUkey = false;
            this.ResponsibleName.Location = new System.Drawing.Point(764, 66);
            this.ResponsibleName.Name = "ResponsibleName";
            this.ResponsibleName.ObjectControl = null;
            this.ResponsibleName.ObjetoApp = null;
            this.ResponsibleName.Others = null;
            this.ResponsibleName.PropertyControl = null;
            this.ResponsibleName.PropertyDependecyUkey = null;
            this.ResponsibleName.Size = new System.Drawing.Size(437, 54);
            this.ResponsibleName.TabIndex = 9;
            this.ResponsibleName.TabStop = false;
            this.ResponsibleName.Text = "sTextBox1";
            this.ResponsibleName.ToolTipContext = null;
            this.ResponsibleName.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ResponsibleName.Validations")));
            this.ResponsibleName.ValueControl = "";
            // 
            // HeightDeceadesed
            // 
            this.HeightDeceadesed.Caption = "";
            this.HeightDeceadesed.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.HeightDeceadesed.CenterCaption = false;
            this.HeightDeceadesed.ComponentBackColor = System.Drawing.Color.White;
            this.HeightDeceadesed.DecimalPlaces = 2;
            this.HeightDeceadesed.Disable = true;
            this.HeightDeceadesed.FieldValid = true;
            this.HeightDeceadesed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HeightDeceadesed.Form = null;
            this.HeightDeceadesed.FormType = null;
            this.HeightDeceadesed.IsDependecyUkey = false;
            this.HeightDeceadesed.Location = new System.Drawing.Point(618, 66);
            this.HeightDeceadesed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.HeightDeceadesed.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.HeightDeceadesed.Name = "HeightDeceadesed";
            this.HeightDeceadesed.ObjectControl = null;
            this.HeightDeceadesed.ObjetoApp = null;
            this.HeightDeceadesed.Others = null;
            this.HeightDeceadesed.PropertyControl = null;
            this.HeightDeceadesed.PropertyDependecyUkey = null;
            this.HeightDeceadesed.Size = new System.Drawing.Size(140, 54);
            this.HeightDeceadesed.TabIndex = 8;
            this.HeightDeceadesed.TabStop = false;
            this.HeightDeceadesed.Text = "sNumeric1";
            this.HeightDeceadesed.ThousandsSeparator = false;
            this.HeightDeceadesed.ToolTipContext = null;
            this.HeightDeceadesed.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("HeightDeceadesed.Validations")));
            this.HeightDeceadesed.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // WeigthDeceadesed
            // 
            this.WeigthDeceadesed.Caption = "";
            this.WeigthDeceadesed.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.WeigthDeceadesed.CenterCaption = false;
            this.WeigthDeceadesed.ComponentBackColor = System.Drawing.Color.White;
            this.WeigthDeceadesed.DecimalPlaces = 2;
            this.WeigthDeceadesed.Disable = true;
            this.WeigthDeceadesed.FieldValid = true;
            this.WeigthDeceadesed.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WeigthDeceadesed.Form = null;
            this.WeigthDeceadesed.FormType = null;
            this.WeigthDeceadesed.IsDependecyUkey = false;
            this.WeigthDeceadesed.Location = new System.Drawing.Point(472, 66);
            this.WeigthDeceadesed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.WeigthDeceadesed.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.WeigthDeceadesed.Name = "WeigthDeceadesed";
            this.WeigthDeceadesed.ObjectControl = null;
            this.WeigthDeceadesed.ObjetoApp = null;
            this.WeigthDeceadesed.Others = null;
            this.WeigthDeceadesed.PropertyControl = null;
            this.WeigthDeceadesed.PropertyDependecyUkey = null;
            this.WeigthDeceadesed.Size = new System.Drawing.Size(140, 54);
            this.WeigthDeceadesed.TabIndex = 7;
            this.WeigthDeceadesed.TabStop = false;
            this.WeigthDeceadesed.Text = "sNumeric1";
            this.WeigthDeceadesed.ThousandsSeparator = false;
            this.WeigthDeceadesed.ToolTipContext = null;
            this.WeigthDeceadesed.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("WeigthDeceadesed.Validations")));
            this.WeigthDeceadesed.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // BurialPlace
            // 
            this.BurialPlace.Caption = "";
            this.BurialPlace.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.BurialPlace.CenterCaption = false;
            this.BurialPlace.ComponentBackColor = System.Drawing.Color.White;
            this.BurialPlace.Disable = true;
            this.BurialPlace.FieldValid = true;
            this.BurialPlace.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BurialPlace.Form = null;
            this.BurialPlace.FormType = null;
            this.BurialPlace.IsDependecyUkey = false;
            this.BurialPlace.Location = new System.Drawing.Point(809, 126);
            this.BurialPlace.Name = "BurialPlace";
            this.BurialPlace.ObjectControl = null;
            this.BurialPlace.ObjetoApp = null;
            this.BurialPlace.Others = null;
            this.BurialPlace.PropertyControl = null;
            this.BurialPlace.PropertyDependecyUkey = null;
            this.BurialPlace.Size = new System.Drawing.Size(394, 54);
            this.BurialPlace.TabIndex = 12;
            this.BurialPlace.TabStop = false;
            this.BurialPlace.Text = "sTextBox2";
            this.BurialPlace.ToolTipContext = null;
            this.BurialPlace.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("BurialPlace.Validations")));
            this.BurialPlace.ValueControl = "";
            // 
            // WakeLocation
            // 
            this.WakeLocation.Caption = "";
            this.WakeLocation.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.WakeLocation.CenterCaption = false;
            this.WakeLocation.ComponentBackColor = System.Drawing.Color.White;
            this.WakeLocation.Disable = true;
            this.WakeLocation.FieldValid = true;
            this.WakeLocation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.WakeLocation.Form = null;
            this.WakeLocation.FormType = null;
            this.WakeLocation.IsDependecyUkey = false;
            this.WakeLocation.Location = new System.Drawing.Point(409, 126);
            this.WakeLocation.Name = "WakeLocation";
            this.WakeLocation.ObjectControl = null;
            this.WakeLocation.ObjetoApp = null;
            this.WakeLocation.Others = null;
            this.WakeLocation.PropertyControl = null;
            this.WakeLocation.PropertyDependecyUkey = null;
            this.WakeLocation.Size = new System.Drawing.Size(394, 54);
            this.WakeLocation.TabIndex = 11;
            this.WakeLocation.TabStop = false;
            this.WakeLocation.Text = "sTextBox1";
            this.WakeLocation.ToolTipContext = null;
            this.WakeLocation.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("WakeLocation.Validations")));
            this.WakeLocation.ValueControl = "";
            // 
            // DeadName
            // 
            this.DeadName.Caption = "";
            this.DeadName.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DeadName.CenterCaption = false;
            this.DeadName.ComponentBackColor = System.Drawing.Color.White;
            this.DeadName.Disable = true;
            this.DeadName.FieldValid = true;
            this.DeadName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeadName.Form = null;
            this.DeadName.FormType = null;
            this.DeadName.IsDependecyUkey = false;
            this.DeadName.Location = new System.Drawing.Point(9, 66);
            this.DeadName.Name = "DeadName";
            this.DeadName.ObjectControl = null;
            this.DeadName.ObjetoApp = null;
            this.DeadName.Others = null;
            this.DeadName.PropertyControl = null;
            this.DeadName.PropertyDependecyUkey = null;
            this.DeadName.Size = new System.Drawing.Size(457, 54);
            this.DeadName.TabIndex = 6;
            this.DeadName.TabStop = false;
            this.DeadName.Text = "sTextBox1";
            this.DeadName.ToolTipContext = null;
            this.DeadName.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("DeadName.Validations")));
            this.DeadName.ValueControl = "";
            // 
            // ContractualNote
            // 
            this.ContractualNote.Caption = "";
            this.ContractualNote.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ContractualNote.CenterCaption = false;
            this.ContractualNote.ComponentBackColor = System.Drawing.Color.White;
            this.ContractualNote.Disable = true;
            this.ContractualNote.FieldValid = true;
            this.ContractualNote.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ContractualNote.Form = null;
            this.ContractualNote.FormType = null;
            this.ContractualNote.IsDependecyUkey = false;
            this.ContractualNote.Location = new System.Drawing.Point(546, 6);
            this.ContractualNote.Name = "ContractualNote";
            this.ContractualNote.ObjectControl = null;
            this.ContractualNote.ObjetoApp = null;
            this.ContractualNote.Others = null;
            this.ContractualNote.PropertyControl = null;
            this.ContractualNote.PropertyDependecyUkey = null;
            this.ContractualNote.Size = new System.Drawing.Size(140, 54);
            this.ContractualNote.TabIndex = 3;
            this.ContractualNote.TabStop = false;
            this.ContractualNote.Text = "sTextBox1";
            this.ContractualNote.ToolTipContext = null;
            this.ContractualNote.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ContractualNote.Validations")));
            this.ContractualNote.ValueControl = "";
            // 
            // Sinister
            // 
            this.Sinister.Caption = "";
            this.Sinister.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Sinister.CenterCaption = false;
            this.Sinister.ComponentBackColor = System.Drawing.Color.White;
            this.Sinister.Disable = true;
            this.Sinister.FieldValid = true;
            this.Sinister.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Sinister.Form = null;
            this.Sinister.FormType = null;
            this.Sinister.IsDependecyUkey = false;
            this.Sinister.Location = new System.Drawing.Point(421, 6);
            this.Sinister.Name = "Sinister";
            this.Sinister.ObjectControl = null;
            this.Sinister.ObjetoApp = null;
            this.Sinister.Others = null;
            this.Sinister.PropertyControl = null;
            this.Sinister.PropertyDependecyUkey = null;
            this.Sinister.Size = new System.Drawing.Size(119, 54);
            this.Sinister.TabIndex = 2;
            this.Sinister.TabStop = false;
            this.Sinister.Text = "sTextBox1";
            this.Sinister.ToolTipContext = null;
            this.Sinister.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Sinister.Validations")));
            this.Sinister.ValueControl = "";
            // 
            // NumberOs
            // 
            this.NumberOs.Caption = "";
            this.NumberOs.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NumberOs.CenterCaption = false;
            this.NumberOs.ComponentBackColor = System.Drawing.Color.White;
            this.NumberOs.Disable = true;
            this.NumberOs.FieldValid = true;
            this.NumberOs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NumberOs.Form = null;
            this.NumberOs.FormType = null;
            this.NumberOs.IsDependecyUkey = false;
            this.NumberOs.Location = new System.Drawing.Point(143, 6);
            this.NumberOs.Name = "NumberOs";
            this.NumberOs.ObjectControl = null;
            this.NumberOs.ObjetoApp = null;
            this.NumberOs.Others = null;
            this.NumberOs.PropertyControl = null;
            this.NumberOs.PropertyDependecyUkey = null;
            this.NumberOs.Size = new System.Drawing.Size(135, 54);
            this.NumberOs.TabIndex = 1;
            this.NumberOs.TabStop = false;
            this.NumberOs.Text = "sTextBox1";
            this.NumberOs.ToolTipContext = null;
            this.NumberOs.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NumberOs.Validations")));
            this.NumberOs.ValueControl = "";
            // 
            // tabPageDocument
            // 
            this.tabPageDocument.Controls.Add(this.OsDocuments);
            this.tabPageDocument.Location = new System.Drawing.Point(4, 26);
            this.tabPageDocument.Name = "tabPageDocument";
            this.tabPageDocument.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocument.Size = new System.Drawing.Size(606, 201);
            this.tabPageDocument.TabIndex = 0;
            this.tabPageDocument.Text = "Documentos";
            this.tabPageDocument.UseVisualStyleBackColor = true;
            // 
            // OsDocuments
            // 
            this.OsDocuments.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.OsDocuments.Caption = "";
            this.OsDocuments.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.OsDocuments.CenterCaption = false;
            this.OsDocuments.ComponentBackColor = System.Drawing.Color.White;
            this.OsDocuments.Disable = true;
            this.OsDocuments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OsDocuments.FieldValid = true;
            this.OsDocuments.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OsDocuments.Form = null;
            this.OsDocuments.FormType = null;
            this.OsDocuments.IsDependecyUkey = false;
            this.OsDocuments.IsSearch = false;
            this.OsDocuments.ListColunas = null;
            this.OsDocuments.Location = new System.Drawing.Point(3, 3);
            this.OsDocuments.Name = "OsDocuments";
            this.OsDocuments.ObjectControl = null;
            this.OsDocuments.ObjetoApp = null;
            this.OsDocuments.Others = null;
            this.OsDocuments.PropertyControl = null;
            this.OsDocuments.PropertyDependecyUkey = null;
            this.OsDocuments.PropertyInfos = null;
            this.OsDocuments.ScreenSecondary = false;
            this.OsDocuments.Size = new System.Drawing.Size(600, 195);
            this.OsDocuments.TabIndex = 0;
            this.OsDocuments.TabStop = false;
            this.OsDocuments.Text = "sGrid1";
            this.OsDocuments.ToolTipContext = null;
            this.OsDocuments.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("OsDocuments.Validations")));
            this.OsDocuments.ValueControl = null;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.OsProducts);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 26);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(606, 201);
            this.tabPageProduct.TabIndex = 1;
            this.tabPageProduct.Text = "Produtos";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // OsProducts
            // 
            this.OsProducts.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.OsProducts.Caption = "";
            this.OsProducts.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.OsProducts.CenterCaption = false;
            this.OsProducts.ComponentBackColor = System.Drawing.Color.White;
            this.OsProducts.Disable = true;
            this.OsProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OsProducts.FieldValid = true;
            this.OsProducts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OsProducts.Form = null;
            this.OsProducts.FormType = null;
            this.OsProducts.IsDependecyUkey = false;
            this.OsProducts.IsSearch = false;
            this.OsProducts.ListColunas = null;
            this.OsProducts.Location = new System.Drawing.Point(3, 3);
            this.OsProducts.Name = "OsProducts";
            this.OsProducts.ObjectControl = null;
            this.OsProducts.ObjetoApp = null;
            this.OsProducts.Others = null;
            this.OsProducts.PropertyControl = null;
            this.OsProducts.PropertyDependecyUkey = null;
            this.OsProducts.PropertyInfos = null;
            this.OsProducts.ScreenSecondary = false;
            this.OsProducts.Size = new System.Drawing.Size(600, 195);
            this.OsProducts.TabIndex = 0;
            this.OsProducts.TabStop = false;
            this.OsProducts.Text = "sGrid2";
            this.OsProducts.ToolTipContext = null;
            this.OsProducts.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("OsProducts.Validations")));
            this.OsProducts.ValueControl = null;
            // 
            // tabPageService
            // 
            this.tabPageService.Controls.Add(this.OsServices);
            this.tabPageService.Location = new System.Drawing.Point(4, 26);
            this.tabPageService.Name = "tabPageService";
            this.tabPageService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageService.Size = new System.Drawing.Size(606, 201);
            this.tabPageService.TabIndex = 4;
            this.tabPageService.Text = "Serviços";
            this.tabPageService.UseVisualStyleBackColor = true;
            // 
            // OsServices
            // 
            this.OsServices.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.OsServices.Caption = "";
            this.OsServices.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.OsServices.CenterCaption = false;
            this.OsServices.ComponentBackColor = System.Drawing.Color.White;
            this.OsServices.Disable = true;
            this.OsServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OsServices.FieldValid = true;
            this.OsServices.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OsServices.Form = null;
            this.OsServices.FormType = null;
            this.OsServices.IsDependecyUkey = false;
            this.OsServices.IsSearch = false;
            this.OsServices.ListColunas = null;
            this.OsServices.Location = new System.Drawing.Point(3, 3);
            this.OsServices.Name = "OsServices";
            this.OsServices.ObjectControl = null;
            this.OsServices.ObjetoApp = null;
            this.OsServices.Others = null;
            this.OsServices.PropertyControl = null;
            this.OsServices.PropertyDependecyUkey = null;
            this.OsServices.PropertyInfos = null;
            this.OsServices.ScreenSecondary = false;
            this.OsServices.Size = new System.Drawing.Size(600, 195);
            this.OsServices.TabIndex = 1;
            this.OsServices.TabStop = false;
            this.OsServices.Text = "sGrid3";
            this.OsServices.ToolTipContext = null;
            this.OsServices.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("OsServices.Validations")));
            this.OsServices.ValueControl = null;
            // 
            // tabPageContractorService
            // 
            this.tabPageContractorService.Controls.Add(this.OsContractorServices);
            this.tabPageContractorService.Location = new System.Drawing.Point(4, 26);
            this.tabPageContractorService.Name = "tabPageContractorService";
            this.tabPageContractorService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContractorService.Size = new System.Drawing.Size(606, 201);
            this.tabPageContractorService.TabIndex = 3;
            this.tabPageContractorService.Text = "Contratada X Serviços";
            this.tabPageContractorService.UseVisualStyleBackColor = true;
            // 
            // OsContractorServices
            // 
            this.OsContractorServices.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.OsContractorServices.Caption = "";
            this.OsContractorServices.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.OsContractorServices.CenterCaption = false;
            this.OsContractorServices.ComponentBackColor = System.Drawing.Color.White;
            this.OsContractorServices.Disable = true;
            this.OsContractorServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OsContractorServices.FieldValid = true;
            this.OsContractorServices.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OsContractorServices.Form = null;
            this.OsContractorServices.FormType = null;
            this.OsContractorServices.IsDependecyUkey = false;
            this.OsContractorServices.IsSearch = false;
            this.OsContractorServices.ListColunas = null;
            this.OsContractorServices.Location = new System.Drawing.Point(3, 3);
            this.OsContractorServices.Name = "OsContractorServices";
            this.OsContractorServices.ObjectControl = null;
            this.OsContractorServices.ObjetoApp = null;
            this.OsContractorServices.Others = null;
            this.OsContractorServices.PropertyControl = null;
            this.OsContractorServices.PropertyDependecyUkey = null;
            this.OsContractorServices.PropertyInfos = null;
            this.OsContractorServices.ScreenSecondary = false;
            this.OsContractorServices.Size = new System.Drawing.Size(600, 195);
            this.OsContractorServices.TabIndex = 1;
            this.OsContractorServices.TabStop = false;
            this.OsContractorServices.Text = "sGrid5";
            this.OsContractorServices.ToolTipContext = null;
            this.OsContractorServices.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("OsContractorServices.Validations")));
            this.OsContractorServices.ValueControl = null;
            // 
            // tabPageServiceFleet
            // 
            this.tabPageServiceFleet.Controls.Add(this.OsVehicles);
            this.tabPageServiceFleet.Location = new System.Drawing.Point(4, 26);
            this.tabPageServiceFleet.Name = "tabPageServiceFleet";
            this.tabPageServiceFleet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServiceFleet.Size = new System.Drawing.Size(606, 201);
            this.tabPageServiceFleet.TabIndex = 5;
            this.tabPageServiceFleet.Text = "Serviços de Frota";
            this.tabPageServiceFleet.UseVisualStyleBackColor = true;
            // 
            // OsVehicles
            // 
            this.OsVehicles.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.OsVehicles.Caption = "";
            this.OsVehicles.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.OsVehicles.CenterCaption = false;
            this.OsVehicles.ComponentBackColor = System.Drawing.Color.White;
            this.OsVehicles.Disable = true;
            this.OsVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OsVehicles.FieldValid = true;
            this.OsVehicles.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OsVehicles.Form = null;
            this.OsVehicles.FormType = null;
            this.OsVehicles.IsDependecyUkey = false;
            this.OsVehicles.IsSearch = false;
            this.OsVehicles.ListColunas = null;
            this.OsVehicles.Location = new System.Drawing.Point(3, 3);
            this.OsVehicles.Name = "OsVehicles";
            this.OsVehicles.ObjectControl = null;
            this.OsVehicles.ObjetoApp = null;
            this.OsVehicles.Others = null;
            this.OsVehicles.PropertyControl = null;
            this.OsVehicles.PropertyDependecyUkey = null;
            this.OsVehicles.PropertyInfos = null;
            this.OsVehicles.ScreenSecondary = false;
            this.OsVehicles.Size = new System.Drawing.Size(600, 195);
            this.OsVehicles.TabIndex = 1;
            this.OsVehicles.TabStop = false;
            this.OsVehicles.Text = "sGrid6";
            this.OsVehicles.ToolTipContext = null;
            this.OsVehicles.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("OsVehicles.Validations")));
            this.OsVehicles.ValueControl = null;
            // 
            // tabPageContractorProduct
            // 
            this.tabPageContractorProduct.Controls.Add(this.OsContractorProducts);
            this.tabPageContractorProduct.Location = new System.Drawing.Point(4, 26);
            this.tabPageContractorProduct.Name = "tabPageContractorProduct";
            this.tabPageContractorProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContractorProduct.Size = new System.Drawing.Size(1217, 430);
            this.tabPageContractorProduct.TabIndex = 2;
            this.tabPageContractorProduct.Text = "Contratada X Produtos";
            this.tabPageContractorProduct.UseVisualStyleBackColor = true;
            // 
            // OsContractorProducts
            // 
            this.OsContractorProducts.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.OsContractorProducts.Caption = "";
            this.OsContractorProducts.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.OsContractorProducts.CenterCaption = false;
            this.OsContractorProducts.ComponentBackColor = System.Drawing.Color.White;
            this.OsContractorProducts.Disable = true;
            this.OsContractorProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OsContractorProducts.FieldValid = true;
            this.OsContractorProducts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OsContractorProducts.Form = null;
            this.OsContractorProducts.FormType = null;
            this.OsContractorProducts.IsDependecyUkey = false;
            this.OsContractorProducts.IsSearch = false;
            this.OsContractorProducts.ListColunas = null;
            this.OsContractorProducts.Location = new System.Drawing.Point(3, 3);
            this.OsContractorProducts.Name = "OsContractorProducts";
            this.OsContractorProducts.ObjectControl = null;
            this.OsContractorProducts.ObjetoApp = null;
            this.OsContractorProducts.Others = null;
            this.OsContractorProducts.PropertyControl = null;
            this.OsContractorProducts.PropertyDependecyUkey = null;
            this.OsContractorProducts.PropertyInfos = null;
            this.OsContractorProducts.ScreenSecondary = false;
            this.OsContractorProducts.Size = new System.Drawing.Size(1211, 424);
            this.OsContractorProducts.TabIndex = 1;
            this.OsContractorProducts.TabStop = false;
            this.OsContractorProducts.Text = "sGrid4";
            this.OsContractorProducts.ToolTipContext = null;
            this.OsContractorProducts.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("OsContractorProducts.Validations")));
            this.OsContractorProducts.ValueControl = null;
            // 
            // DateOfIssure
            // 
            this.DateOfIssure.Caption = "";
            this.DateOfIssure.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DateOfIssure.CenterCaption = false;
            this.DateOfIssure.ComponentBackColor = System.Drawing.Color.White;
            this.DateOfIssure.CustomFormat = null;
            this.DateOfIssure.Disable = true;
            this.DateOfIssure.FieldValid = true;
            this.DateOfIssure.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DateOfIssure.Form = null;
            this.DateOfIssure.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfIssure.FormType = null;
            this.DateOfIssure.IsDependecyUkey = false;
            this.DateOfIssure.Location = new System.Drawing.Point(284, 6);
            this.DateOfIssure.Name = "DateOfIssure";
            this.DateOfIssure.ObjectControl = null;
            this.DateOfIssure.ObjetoApp = null;
            this.DateOfIssure.Others = null;
            this.DateOfIssure.PropertyControl = null;
            this.DateOfIssure.PropertyDependecyUkey = null;
            this.DateOfIssure.Size = new System.Drawing.Size(131, 53);
            this.DateOfIssure.TabIndex = 38;
            this.DateOfIssure.TabStop = false;
            this.DateOfIssure.Text = "sDateTimePicker2";
            this.DateOfIssure.ToolTipContext = null;
            this.DateOfIssure.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("DateOfIssure.Validations")));
            this.DateOfIssure.ValueControl = new System.DateTime(2016, 12, 20, 22, 32, 46, 164);
            // 
            // FOrdemOfService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(1225, 624);
            this.Name = "FOrdemOfService";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.sTabControl1.ResumeLayout(false);
            this.OsInformation.ResumeLayout(false);
            this.OsInformation.PerformLayout();
            this.tabPageDocument.ResumeLayout(false);
            this.tabPageDocument.PerformLayout();
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageProduct.PerformLayout();
            this.tabPageService.ResumeLayout(false);
            this.tabPageService.PerformLayout();
            this.tabPageContractorService.ResumeLayout(false);
            this.tabPageContractorService.PerformLayout();
            this.tabPageServiceFleet.ResumeLayout(false);
            this.tabPageServiceFleet.PerformLayout();
            this.tabPageContractorProduct.ResumeLayout(false);
            this.tabPageContractorProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Core.Component.STabControl sTabControl1;
        private System.Windows.Forms.TabPage tabPageDocument;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.TabPage tabPageContractorProduct;
        private System.Windows.Forms.TabPage tabPageContractorService;
        private System.Windows.Forms.TabPage tabPageService;
        private System.Windows.Forms.TabPage tabPageServiceFleet;
        private Core.Component.SGrid OsDocuments;
        private Core.Component.SGrid OsProducts;
        private Core.Component.SGrid OsServices;
        private Core.Component.SGrid OsContractorProducts;
        private Core.Component.SGrid OsContractorServices;
        private Core.Component.SGrid OsVehicles;
        private System.Windows.Forms.TabPage OsInformation;
        private Core.Component.SRichText GeneralInformation;
        private Core.Component.SComboBox ContractorId;
        private Core.Component.SComboBox PlanId;
        private Core.Component.STextBox PlanHolder;
        private Core.Component.SMasckEdit Phone2;
        private Core.Component.SMasckEdit Phone1;
        private Core.Component.STextBox ResponsibleName;
        private Core.Component.SNumeric HeightDeceadesed;
        private Core.Component.SNumeric WeigthDeceadesed;
        private Core.Component.STextBox BurialPlace;
        private Core.Component.STextBox WakeLocation;
        private Core.Component.STextBox DeadName;
        private Core.Component.STextBox ContractualNote;
        private Core.Component.STextBox Sinister;
        private Core.Component.STextBox NumberOs;
        private Core.Component.SDateTimePicker BurialTime;
        private Core.Component.SDateTimePicker BurialDate;
        private Core.Component.SDateTimePicker DateOfDead;
        private Core.Component.STextBox PlaceOfDead;
        private Core.Component.SNumeric Id;
        private Core.Component.SDateTimePicker DateOfIssure;
    }
}
