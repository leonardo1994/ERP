namespace Esr.Module.ControlPainel.Forms.FiltersCompanies
{
    partial class FFilterCompany_001
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckListBoxCompanies = new Esr.Core.Component.SCheckListBox();
            this.SuspendLayout();
            // 
            // CheckListBoxCompanies
            // 
            this.CheckListBoxCompanies.Caption = "Selecione as empresas";
            this.CheckListBoxCompanies.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.CheckListBoxCompanies.CenterCaption = false;
            this.CheckListBoxCompanies.ComponentBackColor = System.Drawing.Color.White;
            this.CheckListBoxCompanies.Disable = true;
            this.CheckListBoxCompanies.DisplayMember = "";
            this.CheckListBoxCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckListBoxCompanies.FieldValid = true;
            this.CheckListBoxCompanies.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CheckListBoxCompanies.Form = null;
            this.CheckListBoxCompanies.FormType = null;
            this.CheckListBoxCompanies.IsDependecyUkey = false;
            this.CheckListBoxCompanies.Location = new System.Drawing.Point(0, 141);
            this.CheckListBoxCompanies.Name = "CheckListBoxCompanies";
            this.CheckListBoxCompanies.ObjectControl = null;
            this.CheckListBoxCompanies.ObjetoApp = null;
            this.CheckListBoxCompanies.Others = null;
            this.CheckListBoxCompanies.PropertyControl = null;
            this.CheckListBoxCompanies.PropertyDependecyUkey = null;
            this.CheckListBoxCompanies.Size = new System.Drawing.Size(485, 320);
            this.CheckListBoxCompanies.TabIndex = 0;
            this.CheckListBoxCompanies.TabStop = false;
            this.CheckListBoxCompanies.Text = "sCheckListBox1";
            this.CheckListBoxCompanies.ToolTipContext = null;
            this.CheckListBoxCompanies.Validations = null;
            this.CheckListBoxCompanies.ValueMember = "";
            // 
            // FFilterCompany_001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 461);
            this.Controls.Add(this.CheckListBoxCompanies);
            this.Name = "FFilterCompany_001";
            this.Text = "FFilterCompany_001";
            this.Controls.SetChildIndex(this.CheckListBoxCompanies, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SCheckListBox CheckListBoxCompanies;
    }
}