namespace Esr.Module.ControlPainel.Forms
{
    partial class FConsult
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new Esr.Core.Component.STabControl();
            this.tabPageConsult = new System.Windows.Forms.TabPage();
            this.QueryId = new Esr.Core.Component.SComboBox();
            this.Display = new Esr.Core.Component.STextBox();
            this.Code = new Esr.Core.Component.STextBox();
            this.tabPageForms = new System.Windows.Forms.TabPage();
            this.ConsultForms = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPageConsult.SuspendLayout();
            this.tabPageForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TabControl);
            this.panel1.Size = new System.Drawing.Size(445, 227);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPageConsult);
            this.TabControl.Controls.Add(this.tabPageForms);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(445, 227);
            this.TabControl.TabIndex = 1;
            // 
            // tabPageConsult
            // 
            this.tabPageConsult.Controls.Add(this.QueryId);
            this.tabPageConsult.Controls.Add(this.Display);
            this.tabPageConsult.Controls.Add(this.Code);
            this.tabPageConsult.Location = new System.Drawing.Point(4, 26);
            this.tabPageConsult.Name = "tabPageConsult";
            this.tabPageConsult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsult.Size = new System.Drawing.Size(437, 197);
            this.tabPageConsult.TabIndex = 0;
            this.tabPageConsult.Text = "Consulta";
            this.tabPageConsult.UseVisualStyleBackColor = true;
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
            this.QueryId.Location = new System.Drawing.Point(6, 132);
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
            this.tabPageForms.Controls.Add(this.ConsultForms);
            this.tabPageForms.Location = new System.Drawing.Point(4, 26);
            this.tabPageForms.Name = "tabPageForms";
            this.tabPageForms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageForms.Size = new System.Drawing.Size(437, 197);
            this.tabPageForms.TabIndex = 1;
            this.tabPageForms.Text = "Acesso Forms";
            this.tabPageForms.UseVisualStyleBackColor = true;
            // 
            // ConsultForms
            // 
            this.ConsultForms.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.ConsultForms.Caption = "";
            this.ConsultForms.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ConsultForms.CenterCaption = false;
            this.ConsultForms.ComponentBackColor = System.Drawing.Color.White;
            this.ConsultForms.Disable = true;
            this.ConsultForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsultForms.FieldValid = true;
            this.ConsultForms.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ConsultForms.Form = null;
            this.ConsultForms.FormType = null;
            this.ConsultForms.IsDependecyUkey = false;
            this.ConsultForms.IsSearch = false;
            this.ConsultForms.ListColunas = null;
            this.ConsultForms.Location = new System.Drawing.Point(3, 3);
            this.ConsultForms.Name = "ConsultForms";
            this.ConsultForms.ObjectControl = null;
            this.ConsultForms.ObjetoApp = null;
            this.ConsultForms.PropertyControl = null;
            this.ConsultForms.PropertyDependecyUkey = null;
            this.ConsultForms.PropertyInfos = null;
            this.ConsultForms.ScreenSecondary = false;
            this.ConsultForms.Size = new System.Drawing.Size(431, 191);
            this.ConsultForms.TabIndex = 0;
            this.ConsultForms.TabStop = false;
            this.ConsultForms.ToolTipContext = null;
            this.ConsultForms.Validations = null;
            this.ConsultForms.ValueControl = null;
            // 
            // FConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(445, 391);
            this.Name = "FConsult";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPageConsult.ResumeLayout(false);
            this.tabPageConsult.PerformLayout();
            this.tabPageForms.ResumeLayout(false);
            this.tabPageForms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STabControl TabControl;
        private System.Windows.Forms.TabPage tabPageConsult;
        private Core.Component.SComboBox QueryId;
        private Core.Component.STextBox Display;
        private Core.Component.STextBox Code;
        private System.Windows.Forms.TabPage tabPageForms;
        private Core.Component.SGrid ConsultForms;
    }
}
