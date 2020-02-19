namespace Esr.Module.ControlPainel.Forms
{
    partial class FQuery
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FQuery));
            this.TabControl = new Esr.Core.Component.STabControl();
            this.tabPageQuery = new System.Windows.Forms.TabPage();
            this.Code = new Esr.Core.Component.STextBox();
            this.tabPageFilters = new System.Windows.Forms.TabPage();
            this.Filters = new Esr.Core.Component.SGrid();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.Reports = new Esr.Core.Component.SGrid();
            this.tabPageConsultas = new System.Windows.Forms.TabPage();
            this.Consults = new Esr.Core.Component.SGrid();
            this.Sql = new Esr.Core.Component.SRichText();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPageQuery.SuspendLayout();
            this.tabPageFilters.SuspendLayout();
            this.tabPageReports.SuspendLayout();
            this.tabPageConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabControl);
            this.panel1.Size = new System.Drawing.Size(735, 306);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPageQuery);
            this.TabControl.Controls.Add(this.tabPageFilters);
            this.TabControl.Controls.Add(this.tabPageReports);
            this.TabControl.Controls.Add(this.tabPageConsultas);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(735, 306);
            this.TabControl.TabIndex = 0;
            // 
            // tabPageQuery
            // 
            this.tabPageQuery.Controls.Add(this.Sql);
            this.tabPageQuery.Controls.Add(this.Code);
            this.tabPageQuery.Location = new System.Drawing.Point(4, 26);
            this.tabPageQuery.Name = "tabPageQuery";
            this.tabPageQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuery.Size = new System.Drawing.Size(727, 276);
            this.tabPageQuery.TabIndex = 0;
            this.tabPageQuery.Text = "Query";
            this.tabPageQuery.UseVisualStyleBackColor = true;
            // 
            // Code
            // 
            this.Code.Caption = "";
            this.Code.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Code.CenterCaption = false;
            this.Code.ComponentBackColor = System.Drawing.Color.White;
            this.Code.Disable = true;
            this.Code.Dock = System.Windows.Forms.DockStyle.Top;
            this.Code.FieldValid = true;
            this.Code.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Code.Form = null;
            this.Code.FormType = null;
            this.Code.IsDependecyUkey = false;
            this.Code.Location = new System.Drawing.Point(3, 3);
            this.Code.Name = "Code";
            this.Code.ObjectControl = null;
            this.Code.ObjetoApp = null;
            this.Code.Others = null;
            this.Code.PropertyControl = null;
            this.Code.PropertyDependecyUkey = null;
            this.Code.Size = new System.Drawing.Size(721, 54);
            this.Code.TabIndex = 1;
            this.Code.TabStop = false;
            this.Code.Text = "sTextBox1";
            this.Code.ToolTipContext = null;
            this.Code.Validations = null;
            this.Code.ValueControl = "";
            // 
            // tabPageFilters
            // 
            this.tabPageFilters.Controls.Add(this.Filters);
            this.tabPageFilters.Location = new System.Drawing.Point(4, 26);
            this.tabPageFilters.Name = "tabPageFilters";
            this.tabPageFilters.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFilters.Size = new System.Drawing.Size(606, 201);
            this.tabPageFilters.TabIndex = 1;
            this.tabPageFilters.Text = "Filtros";
            this.tabPageFilters.UseVisualStyleBackColor = true;
            // 
            // Filters
            // 
            this.Filters.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.Filters.Caption = "";
            this.Filters.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Filters.CenterCaption = false;
            this.Filters.ComponentBackColor = System.Drawing.Color.White;
            this.Filters.Disable = true;
            this.Filters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Filters.FieldValid = true;
            this.Filters.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Filters.Form = null;
            this.Filters.FormType = null;
            this.Filters.IsDependecyUkey = false;
            this.Filters.IsSearch = false;
            this.Filters.ListColunas = null;
            this.Filters.Location = new System.Drawing.Point(3, 3);
            this.Filters.Name = "Filters";
            this.Filters.ObjectControl = null;
            this.Filters.ObjetoApp = null;
            this.Filters.Others = null;
            this.Filters.PropertyControl = null;
            this.Filters.PropertyDependecyUkey = null;
            this.Filters.PropertyInfos = null;
            this.Filters.ScreenSecondary = false;
            this.Filters.Size = new System.Drawing.Size(600, 195);
            this.Filters.TabIndex = 0;
            this.Filters.TabStop = false;
            this.Filters.Text = "sGrid1";
            this.Filters.ToolTipContext = null;
            this.Filters.Validations = null;
            this.Filters.ValueControl = null;
            // 
            // tabPageReports
            // 
            this.tabPageReports.Controls.Add(this.Reports);
            this.tabPageReports.Location = new System.Drawing.Point(4, 26);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReports.Size = new System.Drawing.Size(606, 201);
            this.tabPageReports.TabIndex = 2;
            this.tabPageReports.Text = "Relatórios";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.Reports.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.Reports.Caption = "";
            this.Reports.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Reports.CenterCaption = false;
            this.Reports.ComponentBackColor = System.Drawing.Color.White;
            this.Reports.Disable = true;
            this.Reports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reports.FieldValid = true;
            this.Reports.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Reports.Form = null;
            this.Reports.FormType = null;
            this.Reports.IsDependecyUkey = false;
            this.Reports.IsSearch = false;
            this.Reports.ListColunas = null;
            this.Reports.Location = new System.Drawing.Point(3, 3);
            this.Reports.Name = "Reports";
            this.Reports.ObjectControl = null;
            this.Reports.ObjetoApp = null;
            this.Reports.Others = null;
            this.Reports.PropertyControl = null;
            this.Reports.PropertyDependecyUkey = null;
            this.Reports.PropertyInfos = null;
            this.Reports.ScreenSecondary = false;
            this.Reports.Size = new System.Drawing.Size(600, 195);
            this.Reports.TabIndex = 1;
            this.Reports.TabStop = false;
            this.Reports.Text = "sGrid2";
            this.Reports.ToolTipContext = null;
            this.Reports.Validations = null;
            this.Reports.ValueControl = null;
            // 
            // tabPageConsultas
            // 
            this.tabPageConsultas.Controls.Add(this.Consults);
            this.tabPageConsultas.Location = new System.Drawing.Point(4, 26);
            this.tabPageConsultas.Name = "tabPageConsultas";
            this.tabPageConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultas.Size = new System.Drawing.Size(606, 201);
            this.tabPageConsultas.TabIndex = 3;
            this.tabPageConsultas.Text = "Consultas";
            this.tabPageConsultas.UseVisualStyleBackColor = true;
            // 
            // Consults
            // 
            this.Consults.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.Consults.Caption = "";
            this.Consults.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Consults.CenterCaption = false;
            this.Consults.ComponentBackColor = System.Drawing.Color.White;
            this.Consults.Disable = true;
            this.Consults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Consults.FieldValid = true;
            this.Consults.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Consults.Form = null;
            this.Consults.FormType = null;
            this.Consults.IsDependecyUkey = false;
            this.Consults.IsSearch = false;
            this.Consults.ListColunas = null;
            this.Consults.Location = new System.Drawing.Point(3, 3);
            this.Consults.Name = "Consults";
            this.Consults.ObjectControl = null;
            this.Consults.ObjetoApp = null;
            this.Consults.Others = null;
            this.Consults.PropertyControl = null;
            this.Consults.PropertyDependecyUkey = null;
            this.Consults.PropertyInfos = null;
            this.Consults.ScreenSecondary = false;
            this.Consults.Size = new System.Drawing.Size(600, 195);
            this.Consults.TabIndex = 2;
            this.Consults.TabStop = false;
            this.Consults.Text = "sGrid3";
            this.Consults.ToolTipContext = null;
            this.Consults.Validations = null;
            this.Consults.ValueControl = null;
            // 
            // Sql
            // 
            this.Sql.Caption = "";
            this.Sql.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Sql.CenterCaption = false;
            this.Sql.ComponentBackColor = System.Drawing.Color.White;
            this.Sql.Disable = true;
            this.Sql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sql.FieldValid = true;
            this.Sql.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Sql.Form = null;
            this.Sql.FormType = null;
            this.Sql.IsDependecyUkey = false;
            this.Sql.Location = new System.Drawing.Point(3, 57);
            this.Sql.Name = "Sql";
            this.Sql.ObjectControl = null;
            this.Sql.ObjetoApp = null;
            this.Sql.Others = null;
            this.Sql.PropertyControl = null;
            this.Sql.PropertyDependecyUkey = null;
            this.Sql.Size = new System.Drawing.Size(721, 216);
            this.Sql.TabIndex = 33;
            this.Sql.TabStop = false;
            this.Sql.Text = "sRichText1";
            this.Sql.ToolTipContext = null;
            this.Sql.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Sql.Validations")));
            this.Sql.ValueControl = "";
            // 
            // FQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(735, 470);
            this.Name = "FQuery";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPageQuery.ResumeLayout(false);
            this.tabPageQuery.PerformLayout();
            this.tabPageFilters.ResumeLayout(false);
            this.tabPageFilters.PerformLayout();
            this.tabPageReports.ResumeLayout(false);
            this.tabPageReports.PerformLayout();
            this.tabPageConsultas.ResumeLayout(false);
            this.tabPageConsultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STabControl TabControl;
        private System.Windows.Forms.TabPage tabPageQuery;
        private System.Windows.Forms.TabPage tabPageFilters;
        private Core.Component.SGrid Filters;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.TabPage tabPageConsultas;
        private Core.Component.SGrid Reports;
        private Core.Component.SGrid Consults;
        private Core.Component.STextBox Code;
        private Core.Component.SRichText Sql;
    }
}
