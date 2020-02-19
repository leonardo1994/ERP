namespace Esr.Module.ControlPainel.Forms
{
    partial class FReport
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new Esr.Core.Component.STabControl();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.QueryId = new Esr.Core.Component.SComboBox();
            this.ReportName = new Esr.Core.Component.STextBox();
            this.Display = new Esr.Core.Component.STextBox();
            this.Code = new Esr.Core.Component.STextBox();
            this.tabPageForms = new System.Windows.Forms.TabPage();
            this.ReportForms = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            this.tabPageForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabControl);
            this.panel1.Size = new System.Drawing.Size(434, 286);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPageReport);
            this.TabControl.Controls.Add(this.tabPageForms);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(434, 286);
            this.TabControl.TabIndex = 0;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.QueryId);
            this.tabPageReport.Controls.Add(this.ReportName);
            this.tabPageReport.Controls.Add(this.Display);
            this.tabPageReport.Controls.Add(this.Code);
            this.tabPageReport.Location = new System.Drawing.Point(4, 26);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(426, 256);
            this.tabPageReport.TabIndex = 0;
            this.tabPageReport.Text = "Relatório";
            this.tabPageReport.UseVisualStyleBackColor = true;
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
            this.QueryId.Location = new System.Drawing.Point(6, 195);
            this.QueryId.Name = "QueryId";
            this.QueryId.ObjectControl = null;
            this.QueryId.ObjetoApp = null;
            this.QueryId.PropertyControl = null;
            this.QueryId.PropertyDependecyUkey = null;
            this.QueryId.Size = new System.Drawing.Size(414, 55);
            this.QueryId.StandardValue = null;
            this.QueryId.TabIndex = 7;
            this.QueryId.TabStop = false;
            this.QueryId.Text = "sComboBox1";
            this.QueryId.ToolTipContext = null;
            this.QueryId.Validations = null;
            this.QueryId.ValueControl = null;
            this.QueryId.ValueMember = "";
            // 
            // ReportName
            // 
            this.ReportName.Caption = "";
            this.ReportName.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ReportName.CenterCaption = false;
            this.ReportName.ComponentBackColor = System.Drawing.Color.White;
            this.ReportName.Disable = true;
            this.ReportName.FieldValid = true;
            this.ReportName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ReportName.Form = null;
            this.ReportName.FormType = null;
            this.ReportName.IsDependecyUkey = false;
            this.ReportName.Location = new System.Drawing.Point(6, 132);
            this.ReportName.Name = "ReportName";
            this.ReportName.ObjectControl = null;
            this.ReportName.ObjetoApp = null;
            this.ReportName.PropertyControl = null;
            this.ReportName.PropertyDependecyUkey = null;
            this.ReportName.Size = new System.Drawing.Size(414, 57);
            this.ReportName.TabIndex = 6;
            this.ReportName.TabStop = false;
            this.ReportName.Text = "sTextBox3";
            this.ReportName.ToolTipContext = null;
            this.ReportName.Validations = null;
            this.ReportName.ValueControl = "";
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
            this.Display.Location = new System.Drawing.Point(6, 69);
            this.Display.Name = "Display";
            this.Display.ObjectControl = null;
            this.Display.ObjetoApp = null;
            this.Display.PropertyControl = null;
            this.Display.PropertyDependecyUkey = null;
            this.Display.Size = new System.Drawing.Size(414, 57);
            this.Display.TabIndex = 5;
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
            this.Code.Location = new System.Drawing.Point(6, 6);
            this.Code.Name = "Code";
            this.Code.ObjectControl = null;
            this.Code.ObjetoApp = null;
            this.Code.PropertyControl = null;
            this.Code.PropertyDependecyUkey = null;
            this.Code.Size = new System.Drawing.Size(414, 57);
            this.Code.TabIndex = 4;
            this.Code.TabStop = false;
            this.Code.Text = "sTextBox1";
            this.Code.ToolTipContext = null;
            this.Code.Validations = null;
            this.Code.ValueControl = "";
            // 
            // tabPageForms
            // 
            this.tabPageForms.Controls.Add(this.ReportForms);
            this.tabPageForms.Location = new System.Drawing.Point(4, 26);
            this.tabPageForms.Name = "tabPageForms";
            this.tabPageForms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageForms.Size = new System.Drawing.Size(426, 256);
            this.tabPageForms.TabIndex = 1;
            this.tabPageForms.Text = "Acesso Forms";
            this.tabPageForms.UseVisualStyleBackColor = true;
            // 
            // ReportForms
            // 
            this.ReportForms.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.ReportForms.Caption = "";
            this.ReportForms.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ReportForms.CenterCaption = false;
            this.ReportForms.ComponentBackColor = System.Drawing.Color.White;
            this.ReportForms.Disable = true;
            this.ReportForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportForms.FieldValid = true;
            this.ReportForms.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ReportForms.Form = null;
            this.ReportForms.FormType = null;
            this.ReportForms.IsDependecyUkey = false;
            this.ReportForms.IsSearch = false;
            this.ReportForms.ListColunas = null;
            this.ReportForms.Location = new System.Drawing.Point(3, 3);
            this.ReportForms.Name = "ReportForms";
            this.ReportForms.ObjectControl = null;
            this.ReportForms.ObjetoApp = null;
            this.ReportForms.PropertyControl = null;
            this.ReportForms.PropertyDependecyUkey = null;
            this.ReportForms.PropertyInfos = null;
            this.ReportForms.ScreenSecondary = false;
            this.ReportForms.Size = new System.Drawing.Size(420, 250);
            this.ReportForms.TabIndex = 0;
            this.ReportForms.TabStop = false;
            this.ReportForms.ToolTipContext = null;
            this.ReportForms.Validations = null;
            this.ReportForms.ValueControl = null;
            // 
            // FReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Name = "FReport";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPageReport.ResumeLayout(false);
            this.tabPageReport.PerformLayout();
            this.tabPageForms.ResumeLayout(false);
            this.tabPageForms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STabControl TabControl;
        private System.Windows.Forms.TabPage tabPageReport;
        private Core.Component.SComboBox QueryId;
        private Core.Component.STextBox ReportName;
        private Core.Component.STextBox Display;
        private Core.Component.STextBox Code;
        private System.Windows.Forms.TabPage tabPageForms;
        private Core.Component.SGrid ReportForms;
    }
}
