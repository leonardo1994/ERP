namespace Esr.Core.Component
{
    partial class FResult
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
            this.GridResult = new Esr.Core.Component.SGrid();
            this.SuspendLayout();
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
            this.GridResult.Others = null;
            this.GridResult.PropertyControl = null;
            this.GridResult.PropertyDependecyUkey = null;
            this.GridResult.PropertyInfos = null;
            this.GridResult.ScreenSecondary = false;
            this.GridResult.Size = new System.Drawing.Size(466, 372);
            this.GridResult.TabIndex = 0;
            this.GridResult.TabStop = false;
            this.GridResult.Text = "sGrid1";
            this.GridResult.ToolTipContext = null;
            this.GridResult.Validations = null;
            this.GridResult.ValueControl = null;
            // 
            // FResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 372);
            this.Controls.Add(this.GridResult);
            this.Name = "FResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public SGrid GridResult;
    }
}