namespace Esr.Module.ControlPainel.Forms.FiltersCompanies
{
    partial class FFilterCompany
    {
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridFilterCompany = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridFilterCompany);
            this.panel1.Size = new System.Drawing.Size(845, 531);
            // 
            // gridFilterCompany
            // 
            this.gridFilterCompany.ButtonAction = Esr.Core.Component.ButtonAction.None;
            this.gridFilterCompany.Caption = "";
            this.gridFilterCompany.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.gridFilterCompany.CenterCaption = false;
            this.gridFilterCompany.ComponentBackColor = System.Drawing.Color.White;
            this.gridFilterCompany.Disable = true;
            this.gridFilterCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFilterCompany.FieldValid = true;
            this.gridFilterCompany.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gridFilterCompany.Form = null;
            this.gridFilterCompany.FormType = null;
            this.gridFilterCompany.IsDependecyUkey = false;
            this.gridFilterCompany.IsSearch = false;
            this.gridFilterCompany.ListColunas = null;
            this.gridFilterCompany.Location = new System.Drawing.Point(0, 0);
            this.gridFilterCompany.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridFilterCompany.Name = "gridFilterCompany";
            this.gridFilterCompany.ObjectControl = null;
            this.gridFilterCompany.ObjetoApp = null;
            this.gridFilterCompany.Others = null;
            this.gridFilterCompany.PropertyControl = null;
            this.gridFilterCompany.PropertyDependecyUkey = null;
            this.gridFilterCompany.PropertyInfos = null;
            this.gridFilterCompany.ScreenSecondary = false;
            this.gridFilterCompany.Size = new System.Drawing.Size(845, 531);
            this.gridFilterCompany.TabIndex = 0;
            this.gridFilterCompany.TabStop = false;
            this.gridFilterCompany.Text = "sGrid1";
            this.gridFilterCompany.ToolTipContext = null;
            this.gridFilterCompany.Validations = null;
            this.gridFilterCompany.ValueControl = null;
            // 
            // FFilterCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 741);
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "FFilterCompany";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Core.Component.SGrid gridFilterCompany;
    }
}