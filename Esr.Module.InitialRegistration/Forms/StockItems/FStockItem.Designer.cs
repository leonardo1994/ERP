namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    partial class FStockItem
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStockItem));
            this.TabControl = new Esr.Core.Component.STabControl();
            this.Geral = new System.Windows.Forms.TabPage();
            this.FeaturedNcmId = new Esr.Core.Component.SComboBox();
            this.NotNegativeBalance = new Esr.Core.Component.SCheckBox();
            this.AllowsUnavaliableMovement = new Esr.Core.Component.SCheckBox();
            this.EvaluateAvailability = new Esr.Core.Component.SCheckBox();
            this.NcmId = new Esr.Core.Component.SComboBox();
            this.FamilyId = new Esr.Core.Component.SComboBox();
            this.MerchandiseUse = new Esr.Core.Component.SComboBox();
            this.OriginItem = new Esr.Core.Component.SComboBox();
            this.Description = new Esr.Core.Component.STextBox();
            this.Situation = new Esr.Core.Component.SComboBox();
            this.UnitMeasureId = new Esr.Core.Component.SComboBox();
            this.SecundaryCode = new Esr.Core.Component.STextBox();
            this.Code = new Esr.Core.Component.STextBox();
            this.Values = new System.Windows.Forms.TabPage();
            this.ValidityType = new Esr.Core.Component.SComboBox();
            this.QuantityValidity = new Esr.Core.Component.SNumeric();
            this.Ressuply = new Esr.Core.Component.SNumeric();
            this.MaximumQuantity = new Esr.Core.Component.SNumeric();
            this.MinimumQuantity = new Esr.Core.Component.SNumeric();
            this.ValueSale = new Esr.Core.Component.SNumeric();
            this.MinimumValue = new Esr.Core.Component.SNumeric();
            this.TypeValueProfit = new Esr.Core.Component.SComboBox();
            this.Profit = new Esr.Core.Component.SNumeric();
            this.TypeValueCommission = new Esr.Core.Component.SComboBox();
            this.Cost = new Esr.Core.Component.SNumeric();
            this.Commission = new Esr.Core.Component.SNumeric();
            this.Taxation = new System.Windows.Forms.TabPage();
            this.SpecialTaxs = new Esr.Core.Component.SGrid();
            this.Others = new System.Windows.Forms.TabPage();
            this.ModelId = new Esr.Core.Component.SComboBox();
            this.MarkId = new Esr.Core.Component.SComboBox();
            this.Ilustrator = new System.Windows.Forms.TabPage();
            this.Image = new Esr.Core.Component.SPictureBox();
            this.Composition = new System.Windows.Forms.TabPage();
            this.Compositions = new Esr.Core.Component.SGrid();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ItemSuppliers = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.Geral.SuspendLayout();
            this.Values.SuspendLayout();
            this.Taxation.SuspendLayout();
            this.Others.SuspendLayout();
            this.Ilustrator.SuspendLayout();
            this.Composition.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabControl);
            this.panel1.Size = new System.Drawing.Size(609, 479);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Geral);
            this.TabControl.Controls.Add(this.Values);
            this.TabControl.Controls.Add(this.Taxation);
            this.TabControl.Controls.Add(this.Others);
            this.TabControl.Controls.Add(this.Ilustrator);
            this.TabControl.Controls.Add(this.Composition);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(609, 479);
            this.TabControl.TabIndex = 0;
            // 
            // Geral
            // 
            this.Geral.Controls.Add(this.FeaturedNcmId);
            this.Geral.Controls.Add(this.NotNegativeBalance);
            this.Geral.Controls.Add(this.AllowsUnavaliableMovement);
            this.Geral.Controls.Add(this.EvaluateAvailability);
            this.Geral.Controls.Add(this.NcmId);
            this.Geral.Controls.Add(this.FamilyId);
            this.Geral.Controls.Add(this.MerchandiseUse);
            this.Geral.Controls.Add(this.OriginItem);
            this.Geral.Controls.Add(this.Description);
            this.Geral.Controls.Add(this.Situation);
            this.Geral.Controls.Add(this.UnitMeasureId);
            this.Geral.Controls.Add(this.SecundaryCode);
            this.Geral.Controls.Add(this.Code);
            this.Geral.Location = new System.Drawing.Point(4, 26);
            this.Geral.Name = "Geral";
            this.Geral.Padding = new System.Windows.Forms.Padding(3);
            this.Geral.Size = new System.Drawing.Size(601, 449);
            this.Geral.TabIndex = 0;
            this.Geral.Text = "Geral";
            this.Geral.UseVisualStyleBackColor = true;
            // 
            // FeaturedNcmId
            // 
            this.FeaturedNcmId.Caption = "";
            this.FeaturedNcmId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FeaturedNcmId.CenterCaption = false;
            this.FeaturedNcmId.ComboBoxMultiForms = null;
            this.FeaturedNcmId.ComponentBackColor = System.Drawing.Color.White;
            this.FeaturedNcmId.DefaultValue = false;
            this.FeaturedNcmId.Disable = true;
            this.FeaturedNcmId.DisplayMember = "";
            this.FeaturedNcmId.FieldValid = true;
            this.FeaturedNcmId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FeaturedNcmId.Form = null;
            this.FeaturedNcmId.FormType = null;
            this.FeaturedNcmId.IsDependecyUkey = false;
            this.FeaturedNcmId.Location = new System.Drawing.Point(7, 307);
            this.FeaturedNcmId.Name = "FeaturedNcmId";
            this.FeaturedNcmId.ObjectControl = null;
            this.FeaturedNcmId.ObjetoApp = null;
            this.FeaturedNcmId.PropertyControl = null;
            this.FeaturedNcmId.PropertyDependecyUkey = null;
            this.FeaturedNcmId.Size = new System.Drawing.Size(584, 54);
            this.FeaturedNcmId.StandardValue = null;
            this.FeaturedNcmId.TabIndex = 9;
            this.FeaturedNcmId.TabStop = false;
            this.FeaturedNcmId.ToolTipContext = null;
            this.FeaturedNcmId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FeaturedNcmId.Validations")));
            this.FeaturedNcmId.ValueControl = null;
            this.FeaturedNcmId.ValueMember = "";
            // 
            // NotNegativeBalance
            // 
            this.NotNegativeBalance.Caption = "";
            this.NotNegativeBalance.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NotNegativeBalance.CenterCaption = false;
            this.NotNegativeBalance.ComponentBackColor = System.Drawing.Color.White;
            this.NotNegativeBalance.Disable = true;
            this.NotNegativeBalance.FieldValid = true;
            this.NotNegativeBalance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NotNegativeBalance.Form = null;
            this.NotNegativeBalance.FormType = null;
            this.NotNegativeBalance.IsDependecyUkey = false;
            this.NotNegativeBalance.Location = new System.Drawing.Point(7, 423);
            this.NotNegativeBalance.Name = "NotNegativeBalance";
            this.NotNegativeBalance.ObjectControl = null;
            this.NotNegativeBalance.ObjetoApp = null;
            this.NotNegativeBalance.PropertyControl = null;
            this.NotNegativeBalance.PropertyDependecyUkey = null;
            this.NotNegativeBalance.Size = new System.Drawing.Size(584, 22);
            this.NotNegativeBalance.TabIndex = 12;
            this.NotNegativeBalance.TabStop = false;
            this.NotNegativeBalance.ToolTipContext = null;
            this.NotNegativeBalance.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NotNegativeBalance.Validations")));
            this.NotNegativeBalance.ValueControl = false;
            // 
            // AllowsUnavaliableMovement
            // 
            this.AllowsUnavaliableMovement.Caption = "";
            this.AllowsUnavaliableMovement.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.AllowsUnavaliableMovement.CenterCaption = false;
            this.AllowsUnavaliableMovement.ComponentBackColor = System.Drawing.Color.White;
            this.AllowsUnavaliableMovement.Disable = true;
            this.AllowsUnavaliableMovement.FieldValid = true;
            this.AllowsUnavaliableMovement.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AllowsUnavaliableMovement.Form = null;
            this.AllowsUnavaliableMovement.FormType = null;
            this.AllowsUnavaliableMovement.IsDependecyUkey = false;
            this.AllowsUnavaliableMovement.Location = new System.Drawing.Point(7, 395);
            this.AllowsUnavaliableMovement.Name = "AllowsUnavaliableMovement";
            this.AllowsUnavaliableMovement.ObjectControl = null;
            this.AllowsUnavaliableMovement.ObjetoApp = null;
            this.AllowsUnavaliableMovement.PropertyControl = null;
            this.AllowsUnavaliableMovement.PropertyDependecyUkey = null;
            this.AllowsUnavaliableMovement.Size = new System.Drawing.Size(584, 22);
            this.AllowsUnavaliableMovement.TabIndex = 11;
            this.AllowsUnavaliableMovement.TabStop = false;
            this.AllowsUnavaliableMovement.ToolTipContext = null;
            this.AllowsUnavaliableMovement.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("AllowsUnavaliableMovement.Validations")));
            this.AllowsUnavaliableMovement.ValueControl = false;
            // 
            // EvaluateAvailability
            // 
            this.EvaluateAvailability.Caption = "";
            this.EvaluateAvailability.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.EvaluateAvailability.CenterCaption = false;
            this.EvaluateAvailability.ComponentBackColor = System.Drawing.Color.White;
            this.EvaluateAvailability.Disable = true;
            this.EvaluateAvailability.FieldValid = true;
            this.EvaluateAvailability.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EvaluateAvailability.Form = null;
            this.EvaluateAvailability.FormType = null;
            this.EvaluateAvailability.IsDependecyUkey = false;
            this.EvaluateAvailability.Location = new System.Drawing.Point(7, 367);
            this.EvaluateAvailability.Name = "EvaluateAvailability";
            this.EvaluateAvailability.ObjectControl = null;
            this.EvaluateAvailability.ObjetoApp = null;
            this.EvaluateAvailability.PropertyControl = null;
            this.EvaluateAvailability.PropertyDependecyUkey = null;
            this.EvaluateAvailability.Size = new System.Drawing.Size(584, 22);
            this.EvaluateAvailability.TabIndex = 10;
            this.EvaluateAvailability.TabStop = false;
            this.EvaluateAvailability.ToolTipContext = null;
            this.EvaluateAvailability.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("EvaluateAvailability.Validations")));
            this.EvaluateAvailability.ValueControl = false;
            // 
            // NcmId
            // 
            this.NcmId.Caption = "";
            this.NcmId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NcmId.CenterCaption = false;
            this.NcmId.ComboBoxMultiForms = null;
            this.NcmId.ComponentBackColor = System.Drawing.Color.White;
            this.NcmId.DefaultValue = false;
            this.NcmId.Disable = true;
            this.NcmId.DisplayMember = "";
            this.NcmId.FieldValid = true;
            this.NcmId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NcmId.Form = null;
            this.NcmId.FormType = null;
            this.NcmId.IsDependecyUkey = false;
            this.NcmId.Location = new System.Drawing.Point(9, 247);
            this.NcmId.Name = "NcmId";
            this.NcmId.ObjectControl = null;
            this.NcmId.ObjetoApp = null;
            this.NcmId.PropertyControl = null;
            this.NcmId.PropertyDependecyUkey = null;
            this.NcmId.Size = new System.Drawing.Size(584, 54);
            this.NcmId.StandardValue = null;
            this.NcmId.TabIndex = 8;
            this.NcmId.TabStop = false;
            this.NcmId.Text = "sComboBox2";
            this.NcmId.ToolTipContext = null;
            this.NcmId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NcmId.Validations")));
            this.NcmId.ValueControl = null;
            this.NcmId.ValueMember = "";
            // 
            // FamilyId
            // 
            this.FamilyId.Caption = "";
            this.FamilyId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FamilyId.CenterCaption = false;
            this.FamilyId.ComboBoxMultiForms = null;
            this.FamilyId.ComponentBackColor = System.Drawing.Color.White;
            this.FamilyId.DefaultValue = false;
            this.FamilyId.Disable = true;
            this.FamilyId.DisplayMember = "";
            this.FamilyId.FieldValid = true;
            this.FamilyId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FamilyId.Form = null;
            this.FamilyId.FormType = null;
            this.FamilyId.IsDependecyUkey = false;
            this.FamilyId.Location = new System.Drawing.Point(9, 187);
            this.FamilyId.Name = "FamilyId";
            this.FamilyId.ObjectControl = null;
            this.FamilyId.ObjetoApp = null;
            this.FamilyId.PropertyControl = null;
            this.FamilyId.PropertyDependecyUkey = null;
            this.FamilyId.Size = new System.Drawing.Size(584, 54);
            this.FamilyId.StandardValue = null;
            this.FamilyId.TabIndex = 7;
            this.FamilyId.TabStop = false;
            this.FamilyId.Text = "sComboBox2";
            this.FamilyId.ToolTipContext = null;
            this.FamilyId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FamilyId.Validations")));
            this.FamilyId.ValueControl = null;
            this.FamilyId.ValueMember = "";
            // 
            // MerchandiseUse
            // 
            this.MerchandiseUse.Caption = "";
            this.MerchandiseUse.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.MerchandiseUse.CenterCaption = false;
            this.MerchandiseUse.ComboBoxMultiForms = null;
            this.MerchandiseUse.ComponentBackColor = System.Drawing.Color.White;
            this.MerchandiseUse.DefaultValue = false;
            this.MerchandiseUse.Disable = true;
            this.MerchandiseUse.DisplayMember = "";
            this.MerchandiseUse.FieldValid = true;
            this.MerchandiseUse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MerchandiseUse.Form = null;
            this.MerchandiseUse.FormType = null;
            this.MerchandiseUse.IsDependecyUkey = false;
            this.MerchandiseUse.Location = new System.Drawing.Point(443, 127);
            this.MerchandiseUse.Name = "MerchandiseUse";
            this.MerchandiseUse.ObjectControl = null;
            this.MerchandiseUse.ObjetoApp = null;
            this.MerchandiseUse.PropertyControl = null;
            this.MerchandiseUse.PropertyDependecyUkey = null;
            this.MerchandiseUse.Size = new System.Drawing.Size(150, 54);
            this.MerchandiseUse.StandardValue = null;
            this.MerchandiseUse.TabIndex = 6;
            this.MerchandiseUse.TabStop = false;
            this.MerchandiseUse.Text = "sComboBox2";
            this.MerchandiseUse.ToolTipContext = null;
            this.MerchandiseUse.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("MerchandiseUse.Validations")));
            this.MerchandiseUse.ValueControl = null;
            this.MerchandiseUse.ValueMember = "";
            // 
            // OriginItem
            // 
            this.OriginItem.Caption = "";
            this.OriginItem.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.OriginItem.CenterCaption = false;
            this.OriginItem.ComboBoxMultiForms = null;
            this.OriginItem.ComponentBackColor = System.Drawing.Color.White;
            this.OriginItem.DefaultValue = false;
            this.OriginItem.Disable = true;
            this.OriginItem.DisplayMember = "";
            this.OriginItem.FieldValid = true;
            this.OriginItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OriginItem.Form = null;
            this.OriginItem.FormType = null;
            this.OriginItem.IsDependecyUkey = false;
            this.OriginItem.Location = new System.Drawing.Point(9, 127);
            this.OriginItem.Name = "OriginItem";
            this.OriginItem.ObjectControl = null;
            this.OriginItem.ObjetoApp = null;
            this.OriginItem.PropertyControl = null;
            this.OriginItem.PropertyDependecyUkey = null;
            this.OriginItem.Size = new System.Drawing.Size(428, 54);
            this.OriginItem.StandardValue = null;
            this.OriginItem.TabIndex = 5;
            this.OriginItem.TabStop = false;
            this.OriginItem.Text = "sComboBox2";
            this.OriginItem.ToolTipContext = null;
            this.OriginItem.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("OriginItem.Validations")));
            this.OriginItem.ValueControl = null;
            this.OriginItem.ValueMember = "";
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
            this.Description.Location = new System.Drawing.Point(9, 67);
            this.Description.Name = "Description";
            this.Description.ObjectControl = null;
            this.Description.ObjetoApp = null;
            this.Description.PropertyControl = null;
            this.Description.PropertyDependecyUkey = null;
            this.Description.Size = new System.Drawing.Size(584, 54);
            this.Description.TabIndex = 4;
            this.Description.TabStop = false;
            this.Description.ToolTipContext = null;
            this.Description.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Description.Validations")));
            this.Description.ValueControl = "";
            // 
            // Situation
            // 
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
            this.Situation.Location = new System.Drawing.Point(495, 6);
            this.Situation.Name = "Situation";
            this.Situation.ObjectControl = null;
            this.Situation.ObjetoApp = null;
            this.Situation.PropertyControl = null;
            this.Situation.PropertyDependecyUkey = null;
            this.Situation.Size = new System.Drawing.Size(98, 54);
            this.Situation.StandardValue = null;
            this.Situation.TabIndex = 3;
            this.Situation.TabStop = false;
            this.Situation.Text = "sComboBox2";
            this.Situation.ToolTipContext = null;
            this.Situation.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Situation.Validations")));
            this.Situation.ValueControl = null;
            this.Situation.ValueMember = "";
            // 
            // UnitMeasureId
            // 
            this.UnitMeasureId.Caption = "";
            this.UnitMeasureId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.UnitMeasureId.CenterCaption = false;
            this.UnitMeasureId.ComboBoxMultiForms = null;
            this.UnitMeasureId.ComponentBackColor = System.Drawing.Color.White;
            this.UnitMeasureId.DefaultValue = false;
            this.UnitMeasureId.Disable = true;
            this.UnitMeasureId.DisplayMember = "";
            this.UnitMeasureId.FieldValid = true;
            this.UnitMeasureId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UnitMeasureId.Form = null;
            this.UnitMeasureId.FormType = null;
            this.UnitMeasureId.IsDependecyUkey = false;
            this.UnitMeasureId.Location = new System.Drawing.Point(431, 7);
            this.UnitMeasureId.Name = "UnitMeasureId";
            this.UnitMeasureId.ObjectControl = null;
            this.UnitMeasureId.ObjetoApp = null;
            this.UnitMeasureId.PropertyControl = null;
            this.UnitMeasureId.PropertyDependecyUkey = null;
            this.UnitMeasureId.Size = new System.Drawing.Size(58, 54);
            this.UnitMeasureId.StandardValue = null;
            this.UnitMeasureId.TabIndex = 2;
            this.UnitMeasureId.TabStop = false;
            this.UnitMeasureId.ToolTipContext = null;
            this.UnitMeasureId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("UnitMeasureId.Validations")));
            this.UnitMeasureId.ValueControl = null;
            this.UnitMeasureId.ValueMember = "";
            // 
            // SecundaryCode
            // 
            this.SecundaryCode.Caption = "";
            this.SecundaryCode.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.SecundaryCode.CenterCaption = false;
            this.SecundaryCode.ComponentBackColor = System.Drawing.Color.White;
            this.SecundaryCode.Disable = true;
            this.SecundaryCode.FieldValid = true;
            this.SecundaryCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SecundaryCode.Form = null;
            this.SecundaryCode.FormType = null;
            this.SecundaryCode.IsDependecyUkey = false;
            this.SecundaryCode.Location = new System.Drawing.Point(227, 7);
            this.SecundaryCode.Name = "SecundaryCode";
            this.SecundaryCode.ObjectControl = null;
            this.SecundaryCode.ObjetoApp = null;
            this.SecundaryCode.PropertyControl = null;
            this.SecundaryCode.PropertyDependecyUkey = null;
            this.SecundaryCode.Size = new System.Drawing.Size(198, 54);
            this.SecundaryCode.TabIndex = 1;
            this.SecundaryCode.TabStop = false;
            this.SecundaryCode.ToolTipContext = null;
            this.SecundaryCode.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("SecundaryCode.Validations")));
            this.SecundaryCode.ValueControl = "";
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
            this.Code.Location = new System.Drawing.Point(9, 7);
            this.Code.Name = "Code";
            this.Code.ObjectControl = null;
            this.Code.ObjetoApp = null;
            this.Code.PropertyControl = null;
            this.Code.PropertyDependecyUkey = null;
            this.Code.Size = new System.Drawing.Size(212, 54);
            this.Code.TabIndex = 0;
            this.Code.TabStop = false;
            this.Code.ToolTipContext = null;
            this.Code.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Code.Validations")));
            this.Code.ValueControl = "";
            // 
            // Values
            // 
            this.Values.Controls.Add(this.ValidityType);
            this.Values.Controls.Add(this.QuantityValidity);
            this.Values.Controls.Add(this.Ressuply);
            this.Values.Controls.Add(this.MaximumQuantity);
            this.Values.Controls.Add(this.MinimumQuantity);
            this.Values.Controls.Add(this.ValueSale);
            this.Values.Controls.Add(this.MinimumValue);
            this.Values.Controls.Add(this.TypeValueProfit);
            this.Values.Controls.Add(this.Profit);
            this.Values.Controls.Add(this.TypeValueCommission);
            this.Values.Controls.Add(this.Cost);
            this.Values.Controls.Add(this.Commission);
            this.Values.Location = new System.Drawing.Point(4, 26);
            this.Values.Name = "Values";
            this.Values.Padding = new System.Windows.Forms.Padding(3);
            this.Values.Size = new System.Drawing.Size(601, 449);
            this.Values.TabIndex = 1;
            this.Values.Text = "Valores";
            this.Values.UseVisualStyleBackColor = true;
            // 
            // ValidityType
            // 
            this.ValidityType.Caption = "";
            this.ValidityType.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ValidityType.CenterCaption = false;
            this.ValidityType.ComboBoxMultiForms = null;
            this.ValidityType.ComponentBackColor = System.Drawing.Color.White;
            this.ValidityType.DefaultValue = false;
            this.ValidityType.Disable = true;
            this.ValidityType.DisplayMember = "";
            this.ValidityType.FieldValid = true;
            this.ValidityType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ValidityType.Form = null;
            this.ValidityType.FormType = null;
            this.ValidityType.IsDependecyUkey = false;
            this.ValidityType.Location = new System.Drawing.Point(400, 134);
            this.ValidityType.Name = "ValidityType";
            this.ValidityType.ObjectControl = null;
            this.ValidityType.ObjetoApp = null;
            this.ValidityType.PropertyControl = null;
            this.ValidityType.PropertyDependecyUkey = null;
            this.ValidityType.Size = new System.Drawing.Size(115, 55);
            this.ValidityType.StandardValue = null;
            this.ValidityType.TabIndex = 8;
            this.ValidityType.TabStop = false;
            this.ValidityType.Text = "sComboBox2";
            this.ValidityType.ToolTipContext = null;
            this.ValidityType.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ValidityType.Validations")));
            this.ValidityType.ValueControl = null;
            this.ValidityType.ValueMember = "";
            // 
            // QuantityValidity
            // 
            this.QuantityValidity.Caption = "";
            this.QuantityValidity.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.QuantityValidity.CenterCaption = false;
            this.QuantityValidity.ComponentBackColor = System.Drawing.Color.White;
            this.QuantityValidity.DecimalPlaces = 2;
            this.QuantityValidity.Disable = true;
            this.QuantityValidity.FieldValid = true;
            this.QuantityValidity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.QuantityValidity.Form = null;
            this.QuantityValidity.FormType = null;
            this.QuantityValidity.IsDependecyUkey = false;
            this.QuantityValidity.Location = new System.Drawing.Point(521, 134);
            this.QuantityValidity.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.QuantityValidity.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.QuantityValidity.Name = "QuantityValidity";
            this.QuantityValidity.ObjectControl = null;
            this.QuantityValidity.ObjetoApp = null;
            this.QuantityValidity.PropertyControl = null;
            this.QuantityValidity.PropertyDependecyUkey = null;
            this.QuantityValidity.Size = new System.Drawing.Size(69, 55);
            this.QuantityValidity.TabIndex = 9;
            this.QuantityValidity.TabStop = false;
            this.QuantityValidity.Text = "sNumeric1";
            this.QuantityValidity.ThousandsSeparator = false;
            this.QuantityValidity.ToolTipContext = null;
            this.QuantityValidity.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("QuantityValidity.Validations")));
            this.QuantityValidity.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Ressuply
            // 
            this.Ressuply.Caption = "";
            this.Ressuply.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Ressuply.CenterCaption = false;
            this.Ressuply.ComponentBackColor = System.Drawing.Color.White;
            this.Ressuply.DecimalPlaces = 2;
            this.Ressuply.Disable = true;
            this.Ressuply.FieldValid = true;
            this.Ressuply.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Ressuply.Form = null;
            this.Ressuply.FormType = null;
            this.Ressuply.IsDependecyUkey = false;
            this.Ressuply.Location = new System.Drawing.Point(400, 70);
            this.Ressuply.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Ressuply.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Ressuply.Name = "Ressuply";
            this.Ressuply.ObjectControl = null;
            this.Ressuply.ObjetoApp = null;
            this.Ressuply.PropertyControl = null;
            this.Ressuply.PropertyDependecyUkey = null;
            this.Ressuply.Size = new System.Drawing.Size(190, 58);
            this.Ressuply.TabIndex = 5;
            this.Ressuply.TabStop = false;
            this.Ressuply.Text = "sNumeric1";
            this.Ressuply.ThousandsSeparator = false;
            this.Ressuply.ToolTipContext = null;
            this.Ressuply.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Ressuply.Validations")));
            this.Ressuply.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // MaximumQuantity
            // 
            this.MaximumQuantity.Caption = "";
            this.MaximumQuantity.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.MaximumQuantity.CenterCaption = false;
            this.MaximumQuantity.ComponentBackColor = System.Drawing.Color.White;
            this.MaximumQuantity.DecimalPlaces = 2;
            this.MaximumQuantity.Disable = true;
            this.MaximumQuantity.FieldValid = true;
            this.MaximumQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MaximumQuantity.Form = null;
            this.MaximumQuantity.FormType = null;
            this.MaximumQuantity.IsDependecyUkey = false;
            this.MaximumQuantity.Location = new System.Drawing.Point(204, 70);
            this.MaximumQuantity.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.MaximumQuantity.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.MaximumQuantity.Name = "MaximumQuantity";
            this.MaximumQuantity.ObjectControl = null;
            this.MaximumQuantity.ObjetoApp = null;
            this.MaximumQuantity.PropertyControl = null;
            this.MaximumQuantity.PropertyDependecyUkey = null;
            this.MaximumQuantity.Size = new System.Drawing.Size(190, 58);
            this.MaximumQuantity.TabIndex = 4;
            this.MaximumQuantity.TabStop = false;
            this.MaximumQuantity.Text = "sNumeric1";
            this.MaximumQuantity.ThousandsSeparator = false;
            this.MaximumQuantity.ToolTipContext = null;
            this.MaximumQuantity.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("MaximumQuantity.Validations")));
            this.MaximumQuantity.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // MinimumQuantity
            // 
            this.MinimumQuantity.Caption = "";
            this.MinimumQuantity.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.MinimumQuantity.CenterCaption = false;
            this.MinimumQuantity.ComponentBackColor = System.Drawing.Color.White;
            this.MinimumQuantity.DecimalPlaces = 2;
            this.MinimumQuantity.Disable = true;
            this.MinimumQuantity.FieldValid = true;
            this.MinimumQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MinimumQuantity.Form = null;
            this.MinimumQuantity.FormType = null;
            this.MinimumQuantity.IsDependecyUkey = false;
            this.MinimumQuantity.Location = new System.Drawing.Point(8, 70);
            this.MinimumQuantity.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.MinimumQuantity.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.MinimumQuantity.Name = "MinimumQuantity";
            this.MinimumQuantity.ObjectControl = null;
            this.MinimumQuantity.ObjetoApp = null;
            this.MinimumQuantity.PropertyControl = null;
            this.MinimumQuantity.PropertyDependecyUkey = null;
            this.MinimumQuantity.Size = new System.Drawing.Size(190, 58);
            this.MinimumQuantity.TabIndex = 3;
            this.MinimumQuantity.TabStop = false;
            this.MinimumQuantity.Text = "sNumeric1";
            this.MinimumQuantity.ThousandsSeparator = false;
            this.MinimumQuantity.ToolTipContext = null;
            this.MinimumQuantity.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("MinimumQuantity.Validations")));
            this.MinimumQuantity.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // ValueSale
            // 
            this.ValueSale.Caption = "";
            this.ValueSale.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ValueSale.CenterCaption = false;
            this.ValueSale.ComponentBackColor = System.Drawing.Color.White;
            this.ValueSale.DecimalPlaces = 2;
            this.ValueSale.Disable = true;
            this.ValueSale.FieldValid = true;
            this.ValueSale.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ValueSale.Form = null;
            this.ValueSale.FormType = null;
            this.ValueSale.IsDependecyUkey = false;
            this.ValueSale.Location = new System.Drawing.Point(400, 6);
            this.ValueSale.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ValueSale.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ValueSale.Name = "ValueSale";
            this.ValueSale.ObjectControl = null;
            this.ValueSale.ObjetoApp = null;
            this.ValueSale.PropertyControl = null;
            this.ValueSale.PropertyDependecyUkey = null;
            this.ValueSale.Size = new System.Drawing.Size(190, 58);
            this.ValueSale.TabIndex = 2;
            this.ValueSale.TabStop = false;
            this.ValueSale.Text = "sNumeric1";
            this.ValueSale.ThousandsSeparator = false;
            this.ValueSale.ToolTipContext = null;
            this.ValueSale.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ValueSale.Validations")));
            this.ValueSale.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // MinimumValue
            // 
            this.MinimumValue.Caption = "";
            this.MinimumValue.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.MinimumValue.CenterCaption = false;
            this.MinimumValue.ComponentBackColor = System.Drawing.Color.White;
            this.MinimumValue.DecimalPlaces = 2;
            this.MinimumValue.Disable = true;
            this.MinimumValue.FieldValid = true;
            this.MinimumValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MinimumValue.Form = null;
            this.MinimumValue.FormType = null;
            this.MinimumValue.IsDependecyUkey = false;
            this.MinimumValue.Location = new System.Drawing.Point(8, 6);
            this.MinimumValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.MinimumValue.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.MinimumValue.Name = "MinimumValue";
            this.MinimumValue.ObjectControl = null;
            this.MinimumValue.ObjetoApp = null;
            this.MinimumValue.PropertyControl = null;
            this.MinimumValue.PropertyDependecyUkey = null;
            this.MinimumValue.Size = new System.Drawing.Size(190, 58);
            this.MinimumValue.TabIndex = 0;
            this.MinimumValue.TabStop = false;
            this.MinimumValue.Text = "sNumeric1";
            this.MinimumValue.ThousandsSeparator = false;
            this.MinimumValue.ToolTipContext = null;
            this.MinimumValue.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("MinimumValue.Validations")));
            this.MinimumValue.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TypeValueProfit
            // 
            this.TypeValueProfit.Caption = "";
            this.TypeValueProfit.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypeValueProfit.CenterCaption = false;
            this.TypeValueProfit.ComboBoxMultiForms = null;
            this.TypeValueProfit.ComponentBackColor = System.Drawing.Color.White;
            this.TypeValueProfit.DefaultValue = false;
            this.TypeValueProfit.Disable = true;
            this.TypeValueProfit.DisplayMember = "";
            this.TypeValueProfit.FieldValid = true;
            this.TypeValueProfit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeValueProfit.Form = null;
            this.TypeValueProfit.FormType = null;
            this.TypeValueProfit.IsDependecyUkey = false;
            this.TypeValueProfit.Location = new System.Drawing.Point(8, 195);
            this.TypeValueProfit.Name = "TypeValueProfit";
            this.TypeValueProfit.ObjectControl = null;
            this.TypeValueProfit.ObjetoApp = null;
            this.TypeValueProfit.PropertyControl = null;
            this.TypeValueProfit.PropertyDependecyUkey = null;
            this.TypeValueProfit.Size = new System.Drawing.Size(49, 55);
            this.TypeValueProfit.StandardValue = null;
            this.TypeValueProfit.TabIndex = 9;
            this.TypeValueProfit.TabStop = false;
            this.TypeValueProfit.Text = "sComboBox2";
            this.TypeValueProfit.ToolTipContext = null;
            this.TypeValueProfit.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TypeValueProfit.Validations")));
            this.TypeValueProfit.ValueControl = null;
            this.TypeValueProfit.ValueMember = "";
            // 
            // Profit
            // 
            this.Profit.Caption = "";
            this.Profit.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Profit.CenterCaption = false;
            this.Profit.ComponentBackColor = System.Drawing.Color.White;
            this.Profit.DecimalPlaces = 2;
            this.Profit.Disable = true;
            this.Profit.FieldValid = true;
            this.Profit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Profit.Form = null;
            this.Profit.FormType = null;
            this.Profit.IsDependecyUkey = false;
            this.Profit.Location = new System.Drawing.Point(63, 195);
            this.Profit.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Profit.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Profit.Name = "Profit";
            this.Profit.ObjectControl = null;
            this.Profit.ObjetoApp = null;
            this.Profit.PropertyControl = null;
            this.Profit.PropertyDependecyUkey = null;
            this.Profit.Size = new System.Drawing.Size(135, 55);
            this.Profit.TabIndex = 10;
            this.Profit.TabStop = false;
            this.Profit.Text = "sNumeric1";
            this.Profit.ThousandsSeparator = false;
            this.Profit.ToolTipContext = null;
            this.Profit.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Profit.Validations")));
            this.Profit.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TypeValueCommission
            // 
            this.TypeValueCommission.Caption = "";
            this.TypeValueCommission.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypeValueCommission.CenterCaption = false;
            this.TypeValueCommission.ComboBoxMultiForms = null;
            this.TypeValueCommission.ComponentBackColor = System.Drawing.Color.White;
            this.TypeValueCommission.DefaultValue = false;
            this.TypeValueCommission.Disable = true;
            this.TypeValueCommission.DisplayMember = "";
            this.TypeValueCommission.FieldValid = true;
            this.TypeValueCommission.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeValueCommission.Form = null;
            this.TypeValueCommission.FormType = null;
            this.TypeValueCommission.IsDependecyUkey = false;
            this.TypeValueCommission.Location = new System.Drawing.Point(8, 134);
            this.TypeValueCommission.Name = "TypeValueCommission";
            this.TypeValueCommission.ObjectControl = null;
            this.TypeValueCommission.ObjetoApp = null;
            this.TypeValueCommission.PropertyControl = null;
            this.TypeValueCommission.PropertyDependecyUkey = null;
            this.TypeValueCommission.Size = new System.Drawing.Size(49, 55);
            this.TypeValueCommission.StandardValue = null;
            this.TypeValueCommission.TabIndex = 6;
            this.TypeValueCommission.TabStop = false;
            this.TypeValueCommission.Text = "sComboBox1";
            this.TypeValueCommission.ToolTipContext = null;
            this.TypeValueCommission.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TypeValueCommission.Validations")));
            this.TypeValueCommission.ValueControl = null;
            this.TypeValueCommission.ValueMember = "";
            // 
            // Cost
            // 
            this.Cost.Caption = "";
            this.Cost.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Cost.CenterCaption = false;
            this.Cost.ComponentBackColor = System.Drawing.Color.White;
            this.Cost.DecimalPlaces = 2;
            this.Cost.Disable = true;
            this.Cost.FieldValid = true;
            this.Cost.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Cost.Form = null;
            this.Cost.FormType = null;
            this.Cost.IsDependecyUkey = false;
            this.Cost.Location = new System.Drawing.Point(204, 6);
            this.Cost.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Cost.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Cost.Name = "Cost";
            this.Cost.ObjectControl = null;
            this.Cost.ObjetoApp = null;
            this.Cost.PropertyControl = null;
            this.Cost.PropertyDependecyUkey = null;
            this.Cost.Size = new System.Drawing.Size(190, 58);
            this.Cost.TabIndex = 1;
            this.Cost.TabStop = false;
            this.Cost.Text = "sNumeric1";
            this.Cost.ThousandsSeparator = false;
            this.Cost.ToolTipContext = null;
            this.Cost.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Cost.Validations")));
            this.Cost.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Commission
            // 
            this.Commission.Caption = "";
            this.Commission.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Commission.CenterCaption = false;
            this.Commission.ComponentBackColor = System.Drawing.Color.White;
            this.Commission.DecimalPlaces = 2;
            this.Commission.Disable = true;
            this.Commission.FieldValid = true;
            this.Commission.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Commission.Form = null;
            this.Commission.FormType = null;
            this.Commission.IsDependecyUkey = false;
            this.Commission.Location = new System.Drawing.Point(63, 134);
            this.Commission.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Commission.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Commission.Name = "Commission";
            this.Commission.ObjectControl = null;
            this.Commission.ObjetoApp = null;
            this.Commission.PropertyControl = null;
            this.Commission.PropertyDependecyUkey = null;
            this.Commission.Size = new System.Drawing.Size(135, 55);
            this.Commission.TabIndex = 7;
            this.Commission.TabStop = false;
            this.Commission.Text = "sNumeric1";
            this.Commission.ThousandsSeparator = false;
            this.Commission.ToolTipContext = null;
            this.Commission.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Commission.Validations")));
            this.Commission.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Taxation
            // 
            this.Taxation.Controls.Add(this.SpecialTaxs);
            this.Taxation.Location = new System.Drawing.Point(4, 26);
            this.Taxation.Name = "Taxation";
            this.Taxation.Padding = new System.Windows.Forms.Padding(3);
            this.Taxation.Size = new System.Drawing.Size(601, 449);
            this.Taxation.TabIndex = 4;
            this.Taxation.Text = "Impostos";
            this.Taxation.UseVisualStyleBackColor = true;
            // 
            // SpecialTaxs
            // 
            this.SpecialTaxs.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.SpecialTaxs.Caption = "";
            this.SpecialTaxs.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.SpecialTaxs.CenterCaption = false;
            this.SpecialTaxs.ComponentBackColor = System.Drawing.Color.White;
            this.SpecialTaxs.Disable = true;
            this.SpecialTaxs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpecialTaxs.FieldValid = true;
            this.SpecialTaxs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SpecialTaxs.Form = null;
            this.SpecialTaxs.FormType = null;
            this.SpecialTaxs.IsDependecyUkey = false;
            this.SpecialTaxs.IsSearch = false;
            this.SpecialTaxs.ListColunas = null;
            this.SpecialTaxs.Location = new System.Drawing.Point(3, 3);
            this.SpecialTaxs.Name = "SpecialTaxs";
            this.SpecialTaxs.ObjectControl = null;
            this.SpecialTaxs.ObjetoApp = null;
            this.SpecialTaxs.PropertyControl = null;
            this.SpecialTaxs.PropertyDependecyUkey = null;
            this.SpecialTaxs.PropertyInfos = null;
            this.SpecialTaxs.ScreenSecondary = false;
            this.SpecialTaxs.Size = new System.Drawing.Size(595, 443);
            this.SpecialTaxs.TabIndex = 0;
            this.SpecialTaxs.TabStop = false;
            this.SpecialTaxs.ToolTipContext = null;
            this.SpecialTaxs.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("SpecialTaxs.Validations")));
            this.SpecialTaxs.ValueControl = null;
            // 
            // Others
            // 
            this.Others.Controls.Add(this.ModelId);
            this.Others.Controls.Add(this.MarkId);
            this.Others.Location = new System.Drawing.Point(4, 26);
            this.Others.Name = "Others";
            this.Others.Padding = new System.Windows.Forms.Padding(3);
            this.Others.Size = new System.Drawing.Size(601, 449);
            this.Others.TabIndex = 2;
            this.Others.Text = "Outros";
            this.Others.UseVisualStyleBackColor = true;
            // 
            // ModelId
            // 
            this.ModelId.Caption = "";
            this.ModelId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ModelId.CenterCaption = false;
            this.ModelId.ComboBoxMultiForms = null;
            this.ModelId.ComponentBackColor = System.Drawing.Color.White;
            this.ModelId.DefaultValue = false;
            this.ModelId.Disable = true;
            this.ModelId.DisplayMember = "";
            this.ModelId.FieldValid = true;
            this.ModelId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ModelId.Form = null;
            this.ModelId.FormType = null;
            this.ModelId.IsDependecyUkey = false;
            this.ModelId.Location = new System.Drawing.Point(8, 66);
            this.ModelId.Name = "ModelId";
            this.ModelId.ObjectControl = null;
            this.ModelId.ObjetoApp = null;
            this.ModelId.PropertyControl = null;
            this.ModelId.PropertyDependecyUkey = null;
            this.ModelId.Size = new System.Drawing.Size(585, 54);
            this.ModelId.StandardValue = null;
            this.ModelId.TabIndex = 0;
            this.ModelId.TabStop = false;
            this.ModelId.Text = "sComboBox3";
            this.ModelId.ToolTipContext = null;
            this.ModelId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ModelId.Validations")));
            this.ModelId.ValueControl = null;
            this.ModelId.ValueMember = "";
            // 
            // MarkId
            // 
            this.MarkId.Caption = "";
            this.MarkId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.MarkId.CenterCaption = false;
            this.MarkId.ComboBoxMultiForms = null;
            this.MarkId.ComponentBackColor = System.Drawing.Color.White;
            this.MarkId.DefaultValue = false;
            this.MarkId.Disable = true;
            this.MarkId.DisplayMember = "";
            this.MarkId.FieldValid = true;
            this.MarkId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MarkId.Form = null;
            this.MarkId.FormType = null;
            this.MarkId.IsDependecyUkey = false;
            this.MarkId.Location = new System.Drawing.Point(8, 6);
            this.MarkId.Name = "MarkId";
            this.MarkId.ObjectControl = null;
            this.MarkId.ObjetoApp = null;
            this.MarkId.PropertyControl = null;
            this.MarkId.PropertyDependecyUkey = null;
            this.MarkId.Size = new System.Drawing.Size(585, 54);
            this.MarkId.StandardValue = null;
            this.MarkId.TabIndex = 0;
            this.MarkId.TabStop = false;
            this.MarkId.Text = "sComboBox2";
            this.MarkId.ToolTipContext = null;
            this.MarkId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("MarkId.Validations")));
            this.MarkId.ValueControl = null;
            this.MarkId.ValueMember = "";
            // 
            // Ilustrator
            // 
            this.Ilustrator.Controls.Add(this.Image);
            this.Ilustrator.Location = new System.Drawing.Point(4, 26);
            this.Ilustrator.Name = "Ilustrator";
            this.Ilustrator.Padding = new System.Windows.Forms.Padding(3);
            this.Ilustrator.Size = new System.Drawing.Size(601, 449);
            this.Ilustrator.TabIndex = 3;
            this.Ilustrator.Text = "Ilustração";
            this.Ilustrator.UseVisualStyleBackColor = true;
            // 
            // Image
            // 
            this.Image.Caption = "";
            this.Image.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Image.CenterCaption = false;
            this.Image.ComponentBackColor = System.Drawing.Color.White;
            this.Image.Disable = true;
            this.Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Image.FieldValid = true;
            this.Image.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Image.Form = null;
            this.Image.FormType = null;
            this.Image.IsDependecyUkey = false;
            this.Image.Location = new System.Drawing.Point(3, 3);
            this.Image.Name = "Image";
            this.Image.ObjectControl = null;
            this.Image.ObjetoApp = null;
            this.Image.PropertyControl = null;
            this.Image.PropertyDependecyUkey = null;
            this.Image.Size = new System.Drawing.Size(595, 443);
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            this.Image.Text = "sPictureBox1";
            this.Image.ToolTipContext = null;
            this.Image.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Image.Validations")));
            this.Image.ValueControl = null;
            // 
            // Composition
            // 
            this.Composition.Controls.Add(this.Compositions);
            this.Composition.Location = new System.Drawing.Point(4, 26);
            this.Composition.Name = "Composition";
            this.Composition.Padding = new System.Windows.Forms.Padding(3);
            this.Composition.Size = new System.Drawing.Size(601, 449);
            this.Composition.TabIndex = 5;
            this.Composition.Text = "Composição";
            this.Composition.UseVisualStyleBackColor = true;
            // 
            // Compositions
            // 
            this.Compositions.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.Compositions.Caption = "";
            this.Compositions.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Compositions.CenterCaption = false;
            this.Compositions.ComponentBackColor = System.Drawing.Color.White;
            this.Compositions.Disable = true;
            this.Compositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Compositions.FieldValid = true;
            this.Compositions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Compositions.Form = null;
            this.Compositions.FormType = null;
            this.Compositions.IsDependecyUkey = false;
            this.Compositions.IsSearch = false;
            this.Compositions.ListColunas = null;
            this.Compositions.Location = new System.Drawing.Point(3, 3);
            this.Compositions.Name = "Compositions";
            this.Compositions.ObjectControl = null;
            this.Compositions.ObjetoApp = null;
            this.Compositions.PropertyControl = null;
            this.Compositions.PropertyDependecyUkey = null;
            this.Compositions.PropertyInfos = null;
            this.Compositions.ScreenSecondary = false;
            this.Compositions.Size = new System.Drawing.Size(595, 443);
            this.Compositions.TabIndex = 0;
            this.Compositions.TabStop = false;
            this.Compositions.ToolTipContext = null;
            this.Compositions.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Compositions.Validations")));
            this.Compositions.ValueControl = null;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ItemSuppliers);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 449);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Fornecedores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ItemSuppliers
            // 
            this.ItemSuppliers.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.ItemSuppliers.Caption = "";
            this.ItemSuppliers.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ItemSuppliers.CenterCaption = false;
            this.ItemSuppliers.ComponentBackColor = System.Drawing.Color.White;
            this.ItemSuppliers.Disable = true;
            this.ItemSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemSuppliers.FieldValid = true;
            this.ItemSuppliers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ItemSuppliers.Form = null;
            this.ItemSuppliers.FormType = null;
            this.ItemSuppliers.IsDependecyUkey = false;
            this.ItemSuppliers.IsSearch = false;
            this.ItemSuppliers.ListColunas = null;
            this.ItemSuppliers.Location = new System.Drawing.Point(3, 3);
            this.ItemSuppliers.Name = "ItemSuppliers";
            this.ItemSuppliers.ObjectControl = null;
            this.ItemSuppliers.ObjetoApp = null;
            this.ItemSuppliers.PropertyControl = null;
            this.ItemSuppliers.PropertyDependecyUkey = null;
            this.ItemSuppliers.PropertyInfos = null;
            this.ItemSuppliers.ScreenSecondary = false;
            this.ItemSuppliers.Size = new System.Drawing.Size(595, 443);
            this.ItemSuppliers.TabIndex = 1;
            this.ItemSuppliers.TabStop = false;
            this.ItemSuppliers.ToolTipContext = null;
            this.ItemSuppliers.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ItemSuppliers.Validations")));
            this.ItemSuppliers.ValueControl = null;
            // 
            // FStockItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(609, 643);
            this.Name = "FStockItem";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.Geral.ResumeLayout(false);
            this.Geral.PerformLayout();
            this.Values.ResumeLayout(false);
            this.Values.PerformLayout();
            this.Taxation.ResumeLayout(false);
            this.Taxation.PerformLayout();
            this.Others.ResumeLayout(false);
            this.Others.PerformLayout();
            this.Ilustrator.ResumeLayout(false);
            this.Ilustrator.PerformLayout();
            this.Composition.ResumeLayout(false);
            this.Composition.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STabControl TabControl;
        private System.Windows.Forms.TabPage Geral;
        private Core.Component.SComboBox FeaturedNcmId;
        private Core.Component.SCheckBox NotNegativeBalance;
        private Core.Component.SCheckBox AllowsUnavaliableMovement;
        private Core.Component.SCheckBox EvaluateAvailability;
        private Core.Component.SComboBox NcmId;
        private Core.Component.SComboBox FamilyId;
        private Core.Component.SComboBox MerchandiseUse;
        private Core.Component.SComboBox OriginItem;
        private Core.Component.STextBox Description;
        private Core.Component.SComboBox Situation;
        private Core.Component.SComboBox UnitMeasureId;
        private Core.Component.STextBox SecundaryCode;
        private Core.Component.STextBox Code;
        private System.Windows.Forms.TabPage Values;
        private Core.Component.SComboBox ValidityType;
        private Core.Component.SNumeric QuantityValidity;
        private Core.Component.SNumeric Ressuply;
        private Core.Component.SNumeric MaximumQuantity;
        private Core.Component.SNumeric MinimumQuantity;
        private Core.Component.SNumeric ValueSale;
        private Core.Component.SNumeric MinimumValue;
        private Core.Component.SComboBox TypeValueProfit;
        private Core.Component.SNumeric Profit;
        private Core.Component.SComboBox TypeValueCommission;
        private Core.Component.SNumeric Cost;
        private Core.Component.SNumeric Commission;
        private System.Windows.Forms.TabPage Taxation;
        private Core.Component.SGrid SpecialTaxs;
        private System.Windows.Forms.TabPage Others;
        private Core.Component.SComboBox ModelId;
        private Core.Component.SComboBox MarkId;
        private System.Windows.Forms.TabPage Ilustrator;
        private Core.Component.SPictureBox Image;
        private System.Windows.Forms.TabPage Composition;
        private Core.Component.SGrid Compositions;
        private System.Windows.Forms.TabPage tabPage1;
        private Core.Component.SGrid ItemSuppliers;
    }
}
