namespace Esr.Core.Component
{
    partial class SFormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SFormSearch));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboBox = new Esr.Core.Component.SComboBox();
            this.GridResult = new Esr.Core.Component.SGrid();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.sMenuSearch1 = new Esr.Core.Component.SMenuSearch();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 144);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.ComboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridResult);
            this.splitContainer1.Size = new System.Drawing.Size(1040, 337);
            this.splitContainer1.SplitterDistance = 363;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 284);
            this.panel1.TabIndex = 1;
            // 
            // ComboBox
            // 
            this.ComboBox.Caption = "";
            this.ComboBox.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ComboBox.CenterCaption = false;
            this.ComboBox.ComboBoxMultiForms = null;
            this.ComboBox.ComponentBackColor = System.Drawing.Color.White;
            this.ComboBox.DefaultValue = false;
            this.ComboBox.Disable = true;
            this.ComboBox.DisplayMember = "";
            this.ComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox.FieldValid = true;
            this.ComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ComboBox.Form = null;
            this.ComboBox.FormType = null;
            this.ComboBox.IsDependecyUkey = false;
            this.ComboBox.Location = new System.Drawing.Point(0, 0);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.ObjectControl = null;
            this.ComboBox.ObjetoApp = null;
            this.ComboBox.PropertyControl = null;
            this.ComboBox.PropertyDependecyUkey = null;
            this.ComboBox.Size = new System.Drawing.Size(363, 53);
            this.ComboBox.StandardValue = null;
            this.ComboBox.TabIndex = 0;
            this.ComboBox.TabStop = false;
            this.ComboBox.ToolTipContext = null;
            this.ComboBox.Validations = null;
            this.ComboBox.ValueControl = null;
            this.ComboBox.ValueMember = "";
            // 
            // GridResult
            // 
            this.GridResult.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.GridResult.Caption = "";
            this.GridResult.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.GridResult.CenterCaption = false;
            this.GridResult.ComponentBackColor = System.Drawing.Color.White;
            this.GridResult.Disable = true;
            this.GridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridResult.FieldValid = true;
            this.GridResult.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GridResult.Form = null;
            this.GridResult.FormType = null;
            this.GridResult.IsDependecyUkey = false;
            this.GridResult.IsSearch = false;
            this.GridResult.ListColunas = null;
            this.GridResult.Location = new System.Drawing.Point(0, 0);
            this.GridResult.Name = "GridResult";
            this.GridResult.ObjectControl = null;
            this.GridResult.ObjetoApp = null;
            this.GridResult.PropertyControl = null;
            this.GridResult.PropertyDependecyUkey = null;
            this.GridResult.PropertyInfos = null;
            this.GridResult.ScreenSecondary = false;
            this.GridResult.Size = new System.Drawing.Size(673, 337);
            this.GridResult.TabIndex = 5;
            this.GridResult.TabStop = false;
            this.GridResult.ToolTipContext = null;
            this.GridResult.Validations = null;
            this.GridResult.ValueControl = null;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Top;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1040, 144);
            this.elementHost1.TabIndex = 2;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.sMenuSearch1;
            // 
            // SFormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 481);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.elementHost1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SFormSearch";
            this.Text = "SFormSearch";
            this.Load += new System.EventHandler(this.SFormSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public SGrid GridResult;
        private SMenuSearch sMenuSearch1;
        private SComboBox ComboBox;
        public System.Windows.Forms.Panel panel1;
    }
}