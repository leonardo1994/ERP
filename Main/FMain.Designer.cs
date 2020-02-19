namespace Esr.Main
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            menu1 = new Menu();
            this.GridSearch = new Esr.Core.Component.SGrid();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.AutoSize = true;
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Top;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(793, 138);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            elementHost1.Child = menu1;
            // 
            // GridSearch
            // 
            GridSearch.ButtonAction = Core.Component.ButtonAction.None;
            this.GridSearch.Caption = "";
            this.GridSearch.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.GridSearch.CenterCaption = false;
            this.GridSearch.Disable = true;
            this.GridSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridSearch.FieldValid = true;
            this.GridSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GridSearch.FormType = null;
            this.GridSearch.IsDependecyUkey = false;
            this.GridSearch.IsSearch = false;
            this.GridSearch.ListColunas = null;
            this.GridSearch.Location = new System.Drawing.Point(0, 138);
            this.GridSearch.Name = "GridSearch";
            this.GridSearch.ObjectControl = null;
            this.GridSearch.ObjetoApp = null;
            this.GridSearch.PropertyControl = null;
            this.GridSearch.PropertyInfos = null;
            this.GridSearch.ScreenSecondary = false;
            this.GridSearch.Size = new System.Drawing.Size(793, 249);
            this.GridSearch.TabIndex = 1;
            this.GridSearch.TabStop = false;
            this.GridSearch.Text = "sGrid1";
            this.GridSearch.ToolTipContext = null;
            this.GridSearch.ValueControl = null;
            this.GridSearch.Visible = false;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 387);
            this.Controls.Add(this.GridSearch);
            this.Controls.Add(this.elementHost1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FMain";
            this.Text = "ESR SOFTWARES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        public Core.Component.SGrid GridSearch;
        private Menu menu1;
    }
}

