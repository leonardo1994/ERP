namespace Esr.Module.ControlPainel.Forms
{
    partial class FFilter
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new Esr.Core.Component.STabControl();
            this.tabPageFilter = new System.Windows.Forms.TabPage();
            this.DefaultTypeFilter = new Esr.Core.Component.SComboBox();
            this.NameTable = new Esr.Core.Component.STextBox();
            this.NameColumn = new Esr.Core.Component.STextBox();
            this.Display = new Esr.Core.Component.STextBox();
            this.Code = new Esr.Core.Component.STextBox();
            this.QueryId = new Esr.Core.Component.SComboBox();
            this.tabPageInactiveFilter = new System.Windows.Forms.TabPage();
            this.InactiveFilters = new Esr.Core.Component.SGrid();
            this.TypeComponent = new Esr.Core.Component.SComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPageFilter.SuspendLayout();
            this.tabPageInactiveFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabControl);
            this.panel1.Size = new System.Drawing.Size(453, 453);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPageFilter);
            this.TabControl.Controls.Add(this.tabPageInactiveFilter);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(453, 453);
            this.TabControl.TabIndex = 0;
            // 
            // tabPageFilter
            // 
            this.tabPageFilter.Controls.Add(this.TypeComponent);
            this.tabPageFilter.Controls.Add(this.DefaultTypeFilter);
            this.tabPageFilter.Controls.Add(this.NameTable);
            this.tabPageFilter.Controls.Add(this.NameColumn);
            this.tabPageFilter.Controls.Add(this.Display);
            this.tabPageFilter.Controls.Add(this.Code);
            this.tabPageFilter.Controls.Add(this.QueryId);
            this.tabPageFilter.Location = new System.Drawing.Point(4, 26);
            this.tabPageFilter.Name = "tabPageFilter";
            this.tabPageFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilter.Size = new System.Drawing.Size(445, 423);
            this.tabPageFilter.TabIndex = 0;
            this.tabPageFilter.Text = "Filtro";
            this.tabPageFilter.UseVisualStyleBackColor = true;
            // 
            // DefaultTypeFilter
            // 
            this.DefaultTypeFilter.Caption = "";
            this.DefaultTypeFilter.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DefaultTypeFilter.CenterCaption = false;
            this.DefaultTypeFilter.ComboBoxMultiForms = null;
            this.DefaultTypeFilter.ComponentBackColor = System.Drawing.Color.White;
            this.DefaultTypeFilter.DefaultValue = false;
            this.DefaultTypeFilter.Disable = true;
            this.DefaultTypeFilter.DisplayMember = "";
            this.DefaultTypeFilter.FieldValid = true;
            this.DefaultTypeFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DefaultTypeFilter.Form = null;
            this.DefaultTypeFilter.FormType = null;
            this.DefaultTypeFilter.IsDependecyUkey = false;
            this.DefaultTypeFilter.Location = new System.Drawing.Point(11, 360);
            this.DefaultTypeFilter.Name = "DefaultTypeFilter";
            this.DefaultTypeFilter.ObjectControl = null;
            this.DefaultTypeFilter.ObjetoApp = null;
            this.DefaultTypeFilter.PropertyControl = null;
            this.DefaultTypeFilter.PropertyDependecyUkey = null;
            this.DefaultTypeFilter.Size = new System.Drawing.Size(423, 57);
            this.DefaultTypeFilter.StandardValue = null;
            this.DefaultTypeFilter.TabIndex = 11;
            this.DefaultTypeFilter.TabStop = false;
            this.DefaultTypeFilter.Text = "sComboBox2";
            this.DefaultTypeFilter.ToolTipContext = null;
            this.DefaultTypeFilter.Validations = null;
            this.DefaultTypeFilter.ValueControl = null;
            this.DefaultTypeFilter.ValueMember = "";
            // 
            // NameTable
            // 
            this.NameTable.Caption = "";
            this.NameTable.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NameTable.CenterCaption = false;
            this.NameTable.ComponentBackColor = System.Drawing.Color.White;
            this.NameTable.Disable = true;
            this.NameTable.FieldValid = true;
            this.NameTable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NameTable.Form = null;
            this.NameTable.FormType = null;
            this.NameTable.IsDependecyUkey = false;
            this.NameTable.Location = new System.Drawing.Point(11, 246);
            this.NameTable.Name = "NameTable";
            this.NameTable.ObjectControl = null;
            this.NameTable.ObjetoApp = null;
            this.NameTable.PropertyControl = null;
            this.NameTable.PropertyDependecyUkey = null;
            this.NameTable.Size = new System.Drawing.Size(423, 53);
            this.NameTable.TabIndex = 10;
            this.NameTable.TabStop = false;
            this.NameTable.Text = "sTextBox4";
            this.NameTable.ToolTipContext = null;
            this.NameTable.Validations = null;
            this.NameTable.ValueControl = "";
            // 
            // NameColumn
            // 
            this.NameColumn.Caption = "";
            this.NameColumn.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NameColumn.CenterCaption = false;
            this.NameColumn.ComponentBackColor = System.Drawing.Color.White;
            this.NameColumn.Disable = true;
            this.NameColumn.FieldValid = true;
            this.NameColumn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NameColumn.Form = null;
            this.NameColumn.FormType = null;
            this.NameColumn.IsDependecyUkey = false;
            this.NameColumn.Location = new System.Drawing.Point(11, 187);
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ObjectControl = null;
            this.NameColumn.ObjetoApp = null;
            this.NameColumn.PropertyControl = null;
            this.NameColumn.PropertyDependecyUkey = null;
            this.NameColumn.Size = new System.Drawing.Size(423, 53);
            this.NameColumn.TabIndex = 9;
            this.NameColumn.TabStop = false;
            this.NameColumn.Text = "sTextBox3";
            this.NameColumn.ToolTipContext = null;
            this.NameColumn.Validations = null;
            this.NameColumn.ValueControl = "";
            // 
            // Display
            // 
            this.Display.Caption = "";
            this.Display.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Display.CenterCaption = false;
            this.Display.ComponentBackColor = System.Drawing.Color.White;
            this.Display.Disable = true;
            this.Display.FieldValid = true;
            this.Display.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Display.Form = null;
            this.Display.FormType = null;
            this.Display.IsDependecyUkey = false;
            this.Display.Location = new System.Drawing.Point(11, 128);
            this.Display.Name = "Display";
            this.Display.ObjectControl = null;
            this.Display.ObjetoApp = null;
            this.Display.PropertyControl = null;
            this.Display.PropertyDependecyUkey = null;
            this.Display.Size = new System.Drawing.Size(423, 53);
            this.Display.TabIndex = 8;
            this.Display.TabStop = false;
            this.Display.Text = "sTextBox2";
            this.Display.ToolTipContext = null;
            this.Display.Validations = null;
            this.Display.ValueControl = "";
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
            this.Code.Location = new System.Drawing.Point(11, 69);
            this.Code.Name = "Code";
            this.Code.ObjectControl = null;
            this.Code.ObjetoApp = null;
            this.Code.PropertyControl = null;
            this.Code.PropertyDependecyUkey = null;
            this.Code.Size = new System.Drawing.Size(423, 53);
            this.Code.TabIndex = 7;
            this.Code.TabStop = false;
            this.Code.Text = "sTextBox1";
            this.Code.ToolTipContext = null;
            this.Code.Validations = null;
            this.Code.ValueControl = "";
            // 
            // QueryId
            // 
            this.QueryId.Caption = "";
            this.QueryId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.QueryId.CenterCaption = false;
            this.QueryId.ComboBoxMultiForms = null;
            this.QueryId.ComponentBackColor = System.Drawing.Color.White;
            this.QueryId.DefaultValue = false;
            this.QueryId.Disable = true;
            this.QueryId.DisplayMember = "";
            this.QueryId.FieldValid = true;
            this.QueryId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.QueryId.Form = null;
            this.QueryId.FormType = null;
            this.QueryId.IsDependecyUkey = false;
            this.QueryId.Location = new System.Drawing.Point(11, 6);
            this.QueryId.Name = "QueryId";
            this.QueryId.ObjectControl = null;
            this.QueryId.ObjetoApp = null;
            this.QueryId.PropertyControl = null;
            this.QueryId.PropertyDependecyUkey = null;
            this.QueryId.Size = new System.Drawing.Size(423, 57);
            this.QueryId.StandardValue = null;
            this.QueryId.TabIndex = 6;
            this.QueryId.TabStop = false;
            this.QueryId.Text = "sComboBox1";
            this.QueryId.ToolTipContext = null;
            this.QueryId.Validations = null;
            this.QueryId.ValueControl = null;
            this.QueryId.ValueMember = "";
            // 
            // tabPageInactiveFilter
            // 
            this.tabPageInactiveFilter.Controls.Add(this.InactiveFilters);
            this.tabPageInactiveFilter.Location = new System.Drawing.Point(4, 26);
            this.tabPageInactiveFilter.Name = "tabPageInactiveFilter";
            this.tabPageInactiveFilter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInactiveFilter.Size = new System.Drawing.Size(606, 201);
            this.tabPageInactiveFilter.TabIndex = 1;
            this.tabPageInactiveFilter.Text = "Filtros Inativos";
            this.tabPageInactiveFilter.UseVisualStyleBackColor = true;
            // 
            // InactiveFilters
            // 
            this.InactiveFilters.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.InactiveFilters.Caption = "";
            this.InactiveFilters.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.InactiveFilters.CenterCaption = false;
            this.InactiveFilters.ComponentBackColor = System.Drawing.Color.White;
            this.InactiveFilters.Disable = true;
            this.InactiveFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InactiveFilters.FieldValid = true;
            this.InactiveFilters.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.InactiveFilters.Form = null;
            this.InactiveFilters.FormType = null;
            this.InactiveFilters.IsDependecyUkey = false;
            this.InactiveFilters.IsSearch = false;
            this.InactiveFilters.ListColunas = null;
            this.InactiveFilters.Location = new System.Drawing.Point(3, 3);
            this.InactiveFilters.Name = "InactiveFilters";
            this.InactiveFilters.ObjectControl = null;
            this.InactiveFilters.ObjetoApp = null;
            this.InactiveFilters.PropertyControl = null;
            this.InactiveFilters.PropertyDependecyUkey = null;
            this.InactiveFilters.PropertyInfos = null;
            this.InactiveFilters.ScreenSecondary = false;
            this.InactiveFilters.Size = new System.Drawing.Size(600, 195);
            this.InactiveFilters.TabIndex = 0;
            this.InactiveFilters.TabStop = false;
            this.InactiveFilters.Text = "sGrid1";
            this.InactiveFilters.ToolTipContext = null;
            this.InactiveFilters.Validations = null;
            this.InactiveFilters.ValueControl = null;
            // 
            // TypeComponent
            // 
            this.TypeComponent.Caption = "";
            this.TypeComponent.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypeComponent.CenterCaption = false;
            this.TypeComponent.ComboBoxMultiForms = null;
            this.TypeComponent.ComponentBackColor = System.Drawing.Color.White;
            this.TypeComponent.DefaultValue = false;
            this.TypeComponent.Disable = true;
            this.TypeComponent.DisplayMember = "";
            this.TypeComponent.FieldValid = true;
            this.TypeComponent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeComponent.Form = null;
            this.TypeComponent.FormType = null;
            this.TypeComponent.IsDependecyUkey = false;
            this.TypeComponent.Location = new System.Drawing.Point(11, 305);
            this.TypeComponent.Name = "TypeComponent";
            this.TypeComponent.ObjectControl = null;
            this.TypeComponent.ObjetoApp = null;
            this.TypeComponent.PropertyControl = null;
            this.TypeComponent.PropertyDependecyUkey = null;
            this.TypeComponent.Size = new System.Drawing.Size(423, 57);
            this.TypeComponent.StandardValue = null;
            this.TypeComponent.TabIndex = 12;
            this.TypeComponent.TabStop = false;
            this.TypeComponent.Text = "sComboBox2";
            this.TypeComponent.ToolTipContext = null;
            this.TypeComponent.Validations = null;
            this.TypeComponent.ValueControl = null;
            this.TypeComponent.ValueMember = "";
            // 
            // FFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(453, 617);
            this.Name = "FFilter";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPageFilter.ResumeLayout(false);
            this.tabPageFilter.PerformLayout();
            this.tabPageInactiveFilter.ResumeLayout(false);
            this.tabPageInactiveFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STabControl TabControl;
        private System.Windows.Forms.TabPage tabPageFilter;
        private Core.Component.SComboBox DefaultTypeFilter;
        private Core.Component.STextBox NameTable;
        private Core.Component.STextBox NameColumn;
        private Core.Component.STextBox Display;
        private Core.Component.STextBox Code;
        private Core.Component.SComboBox QueryId;
        private System.Windows.Forms.TabPage tabPageInactiveFilter;
        private Core.Component.SGrid InactiveFilters;
        private Core.Component.SComboBox TypeComponent;
    }
}
