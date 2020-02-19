namespace Esr.Module.Financial.Forms.Receive
{
    partial class FBillsToReceive
    {

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Series = new Esr.Core.Component.STextBox();
            this.Document = new Esr.Core.Component.STextBox();
            this.DateOfIssure = new Esr.Core.Component.SDateTimePicker();
            this.PersonId = new Esr.Core.Component.SComboBox();
            this.TypeDocumentFinancialId = new Esr.Core.Component.SComboBox();
            this.InstallmentsOfAccountsReceivable = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InstallmentsOfAccountsReceivable);
            this.panel1.Controls.Add(this.TypeDocumentFinancialId);
            this.panel1.Controls.Add(this.PersonId);
            this.panel1.Controls.Add(this.DateOfIssure);
            this.panel1.Controls.Add(this.Document);
            this.panel1.Controls.Add(this.Series);
            this.panel1.Size = new System.Drawing.Size(617, 398);
            // 
            // Series
            // 
            this.Series.Caption = "";
            this.Series.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Series.CenterCaption = false;
            this.Series.ComponentBackColor = System.Drawing.Color.White;
            this.Series.Disable = true;
            this.Series.DisabledAutomaticNumbering = false;
            this.Series.FieldValid = true;
            this.Series.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Series.Form = null;
            this.Series.FormType = null;
            this.Series.IsDependecyUkey = false;
            this.Series.Location = new System.Drawing.Point(145, 6);
            this.Series.Name = "Series";
            this.Series.ObjectControl = null;
            this.Series.ObjetoApp = null;
            this.Series.Others = null;
            this.Series.PropertyControl = null;
            this.Series.PropertyDependecyUkey = null;
            this.Series.Size = new System.Drawing.Size(127, 54);
            this.Series.TabIndex = 0;
            this.Series.TabStop = false;
            this.Series.ToolTipContext = null;
            this.Series.Validations = null;
            this.Series.ValueControl = "";
            // 
            // Document
            // 
            this.Document.Caption = "";
            this.Document.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Document.CenterCaption = false;
            this.Document.ComponentBackColor = System.Drawing.Color.White;
            this.Document.Disable = true;
            this.Document.DisabledAutomaticNumbering = false;
            this.Document.FieldValid = true;
            this.Document.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Document.Form = null;
            this.Document.FormType = null;
            this.Document.IsDependecyUkey = false;
            this.Document.Location = new System.Drawing.Point(12, 6);
            this.Document.Name = "Document";
            this.Document.ObjectControl = null;
            this.Document.ObjetoApp = null;
            this.Document.Others = null;
            this.Document.PropertyControl = null;
            this.Document.PropertyDependecyUkey = null;
            this.Document.Size = new System.Drawing.Size(127, 54);
            this.Document.TabIndex = 1;
            this.Document.TabStop = false;
            this.Document.Text = "sTextBox1";
            this.Document.ToolTipContext = null;
            this.Document.Validations = null;
            this.Document.ValueControl = "";
            // 
            // DateOfIssure
            // 
            this.DateOfIssure.Caption = "";
            this.DateOfIssure.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DateOfIssure.CenterCaption = false;
            this.DateOfIssure.ComponentBackColor = System.Drawing.Color.White;
            this.DateOfIssure.CustomFormat = null;
            this.DateOfIssure.Disable = true;
            this.DateOfIssure.DisabledAutomaticNumbering = false;
            this.DateOfIssure.FieldValid = true;
            this.DateOfIssure.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DateOfIssure.Form = null;
            this.DateOfIssure.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateOfIssure.FormType = null;
            this.DateOfIssure.IsDependecyUkey = false;
            this.DateOfIssure.Location = new System.Drawing.Point(278, 6);
            this.DateOfIssure.Name = "DateOfIssure";
            this.DateOfIssure.ObjectControl = null;
            this.DateOfIssure.ObjetoApp = null;
            this.DateOfIssure.Others = null;
            this.DateOfIssure.PropertyControl = null;
            this.DateOfIssure.PropertyDependecyUkey = null;
            this.DateOfIssure.Size = new System.Drawing.Size(327, 54);
            this.DateOfIssure.TabIndex = 2;
            this.DateOfIssure.TabStop = false;
            this.DateOfIssure.Text = "sDateTimePicker1";
            this.DateOfIssure.ToolTipContext = null;
            this.DateOfIssure.Validations = null;
            this.DateOfIssure.ValueControl = new System.DateTime(2018, 3, 30, 0, 36, 1, 781);
            // 
            // PersonId
            // 
            this.PersonId.Caption = "";
            this.PersonId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.PersonId.CenterCaption = false;
            this.PersonId.ComboBoxMultiForms = null;
            this.PersonId.ComponentBackColor = System.Drawing.Color.White;
            this.PersonId.DefaultValue = false;
            this.PersonId.Disable = true;
            this.PersonId.DisabledAutomaticNumbering = false;
            this.PersonId.DisplayMember = "";
            this.PersonId.FieldValid = true;
            this.PersonId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PersonId.Form = null;
            this.PersonId.FormType = null;
            this.PersonId.IsDependecyUkey = false;
            this.PersonId.Location = new System.Drawing.Point(12, 66);
            this.PersonId.Name = "PersonId";
            this.PersonId.ObjectControl = null;
            this.PersonId.ObjetoApp = null;
            this.PersonId.Others = null;
            this.PersonId.PropertyControl = null;
            this.PersonId.PropertyDependecyUkey = null;
            this.PersonId.PropertySearch = null;
            this.PersonId.Size = new System.Drawing.Size(593, 55);
            this.PersonId.StandardValue = null;
            this.PersonId.TabIndex = 3;
            this.PersonId.TabStop = false;
            this.PersonId.Text = "sComboBox1";
            this.PersonId.ToolTipContext = null;
            this.PersonId.Validations = null;
            this.PersonId.ValueControl = null;
            this.PersonId.ValueMember = "";
            // 
            // TypeDocumentFinancialId
            // 
            this.TypeDocumentFinancialId.Caption = "";
            this.TypeDocumentFinancialId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypeDocumentFinancialId.CenterCaption = false;
            this.TypeDocumentFinancialId.ComboBoxMultiForms = null;
            this.TypeDocumentFinancialId.ComponentBackColor = System.Drawing.Color.White;
            this.TypeDocumentFinancialId.DefaultValue = false;
            this.TypeDocumentFinancialId.Disable = true;
            this.TypeDocumentFinancialId.DisabledAutomaticNumbering = false;
            this.TypeDocumentFinancialId.DisplayMember = "";
            this.TypeDocumentFinancialId.FieldValid = true;
            this.TypeDocumentFinancialId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeDocumentFinancialId.Form = null;
            this.TypeDocumentFinancialId.FormType = null;
            this.TypeDocumentFinancialId.IsDependecyUkey = false;
            this.TypeDocumentFinancialId.Location = new System.Drawing.Point(12, 127);
            this.TypeDocumentFinancialId.Name = "TypeDocumentFinancialId";
            this.TypeDocumentFinancialId.ObjectControl = null;
            this.TypeDocumentFinancialId.ObjetoApp = null;
            this.TypeDocumentFinancialId.Others = null;
            this.TypeDocumentFinancialId.PropertyControl = null;
            this.TypeDocumentFinancialId.PropertyDependecyUkey = null;
            this.TypeDocumentFinancialId.PropertySearch = null;
            this.TypeDocumentFinancialId.Size = new System.Drawing.Size(593, 55);
            this.TypeDocumentFinancialId.StandardValue = null;
            this.TypeDocumentFinancialId.TabIndex = 4;
            this.TypeDocumentFinancialId.TabStop = false;
            this.TypeDocumentFinancialId.Text = "sComboBox1";
            this.TypeDocumentFinancialId.ToolTipContext = null;
            this.TypeDocumentFinancialId.Validations = null;
            this.TypeDocumentFinancialId.ValueControl = null;
            this.TypeDocumentFinancialId.ValueMember = "";
            // 
            // InstallmentsOfAccountsReceivable
            // 
            this.InstallmentsOfAccountsReceivable.ButtonAction = Esr.Core.Component.ButtonAction.None;
            this.InstallmentsOfAccountsReceivable.Caption = "";
            this.InstallmentsOfAccountsReceivable.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.InstallmentsOfAccountsReceivable.CenterCaption = false;
            this.InstallmentsOfAccountsReceivable.ComponentBackColor = System.Drawing.Color.White;
            this.InstallmentsOfAccountsReceivable.Disable = true;
            this.InstallmentsOfAccountsReceivable.DisabledAutomaticNumbering = false;
            this.InstallmentsOfAccountsReceivable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InstallmentsOfAccountsReceivable.FieldValid = true;
            this.InstallmentsOfAccountsReceivable.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.InstallmentsOfAccountsReceivable.Form = null;
            this.InstallmentsOfAccountsReceivable.FormType = null;
            this.InstallmentsOfAccountsReceivable.IsDependecyUkey = false;
            this.InstallmentsOfAccountsReceivable.IsSearch = false;
            this.InstallmentsOfAccountsReceivable.ListColunas = null;
            this.InstallmentsOfAccountsReceivable.Location = new System.Drawing.Point(0, 188);
            this.InstallmentsOfAccountsReceivable.Name = "InstallmentsOfAccountsReceivable";
            this.InstallmentsOfAccountsReceivable.ObjectControl = null;
            this.InstallmentsOfAccountsReceivable.ObjetoApp = null;
            this.InstallmentsOfAccountsReceivable.Others = null;
            this.InstallmentsOfAccountsReceivable.PropertyControl = null;
            this.InstallmentsOfAccountsReceivable.PropertyDependecyUkey = null;
            this.InstallmentsOfAccountsReceivable.PropertyInfos = null;
            this.InstallmentsOfAccountsReceivable.ScreenSecondary = false;
            this.InstallmentsOfAccountsReceivable.Size = new System.Drawing.Size(617, 210);
            this.InstallmentsOfAccountsReceivable.TabIndex = 5;
            this.InstallmentsOfAccountsReceivable.TabStop = false;
            this.InstallmentsOfAccountsReceivable.Text = "sGrid1";
            this.InstallmentsOfAccountsReceivable.ToolTipContext = null;
            this.InstallmentsOfAccountsReceivable.Validations = null;
            this.InstallmentsOfAccountsReceivable.ValueControl = null;
            // 
            // FBillsToReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(617, 562);
            this.Name = "FBillsToReceive";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox Series;
        private Core.Component.STextBox Document;
        private Core.Component.SComboBox PersonId;
        private Core.Component.SDateTimePicker DateOfIssure;
        private Core.Component.SComboBox TypeDocumentFinancialId;
        private Core.Component.SGrid InstallmentsOfAccountsReceivable;
    }
}
