namespace Esr.Core.Component
{
    partial class FSearch
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.GridFilter = new Esr.Core.Component.SGrid();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.MenuSearch = new Esr.Core.Component.SMenuSearch();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 138);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.TreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.GridFilter);
            this.splitContainer1.Size = new System.Drawing.Size(714, 257);
            this.splitContainer1.SplitterDistance = 238;
            this.splitContainer1.TabIndex = 1;
            // 
            // TreeView
            // 
            this.TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView.Location = new System.Drawing.Point(0, 0);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(238, 257);
            this.TreeView.TabIndex = 0;
            this.TreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseClick);
            // 
            // GridFilter
            // 
            this.GridFilter.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.GridFilter.Caption = "";
            this.GridFilter.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.GridFilter.CenterCaption = false;
            this.GridFilter.ComponentBackColor = System.Drawing.Color.White;
            this.GridFilter.Disable = true;
            this.GridFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridFilter.FieldValid = true;
            this.GridFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GridFilter.Form = null;
            this.GridFilter.FormType = null;
            this.GridFilter.IsDependecyUkey = false;
            this.GridFilter.IsSearch = false;
            this.GridFilter.ListColunas = null;
            this.GridFilter.Location = new System.Drawing.Point(0, 0);
            this.GridFilter.Name = "GridFilter";
            this.GridFilter.ObjectControl = null;
            this.GridFilter.ObjetoApp = null;
            this.GridFilter.Others = null;
            this.GridFilter.PropertyControl = null;
            this.GridFilter.PropertyDependecyUkey = null;
            this.GridFilter.PropertyInfos = null;
            this.GridFilter.ScreenSecondary = false;
            this.GridFilter.Size = new System.Drawing.Size(472, 257);
            this.GridFilter.TabIndex = 0;
            this.GridFilter.TabStop = false;
            this.GridFilter.Text = "sGrid1";
            this.GridFilter.ToolTipContext = null;
            this.GridFilter.Validations = null;
            this.GridFilter.ValueControl = null;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Top;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(714, 138);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.MenuSearch;
            // 
            // FSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 395);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.elementHost1);
            this.Name = "FSearch";
            this.Text = "FSearch";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private SMenuSearch MenuSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TreeView TreeView;
        private SGrid GridFilter;
    }
}