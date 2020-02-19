namespace Esr.Module.Financial.Forms.Financial
{
    partial class FTypeDocumentFinancial
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
            this.TypeDocumentCode = new Esr.Core.Component.STextBox();
            this.TypeDocumentDescription = new Esr.Core.Component.STextBox();
            this.Participation = new Esr.Core.Component.SComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Participation);
            this.panel1.Controls.Add(this.TypeDocumentDescription);
            this.panel1.Controls.Add(this.TypeDocumentCode);
            this.panel1.Size = new System.Drawing.Size(614, 74);
            // 
            // TypeDocumentCode
            // 
            this.TypeDocumentCode.Caption = "";
            this.TypeDocumentCode.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypeDocumentCode.CenterCaption = false;
            this.TypeDocumentCode.ComponentBackColor = System.Drawing.Color.White;
            this.TypeDocumentCode.Disable = true;
            this.TypeDocumentCode.DisabledAutomaticNumbering = false;
            this.TypeDocumentCode.FieldValid = true;
            this.TypeDocumentCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeDocumentCode.Form = null;
            this.TypeDocumentCode.FormType = null;
            this.TypeDocumentCode.IsDependecyUkey = false;
            this.TypeDocumentCode.Location = new System.Drawing.Point(12, 6);
            this.TypeDocumentCode.Name = "TypeDocumentCode";
            this.TypeDocumentCode.ObjectControl = null;
            this.TypeDocumentCode.ObjetoApp = null;
            this.TypeDocumentCode.Others = null;
            this.TypeDocumentCode.PropertyControl = null;
            this.TypeDocumentCode.PropertyDependecyUkey = null;
            this.TypeDocumentCode.Size = new System.Drawing.Size(126, 53);
            this.TypeDocumentCode.TabIndex = 0;
            this.TypeDocumentCode.TabStop = false;
            this.TypeDocumentCode.Text = "sTextBox1";
            this.TypeDocumentCode.ToolTipContext = null;
            this.TypeDocumentCode.Validations = null;
            this.TypeDocumentCode.ValueControl = "";
            // 
            // TypeDocumentDescription
            // 
            this.TypeDocumentDescription.Caption = "";
            this.TypeDocumentDescription.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypeDocumentDescription.CenterCaption = false;
            this.TypeDocumentDescription.ComponentBackColor = System.Drawing.Color.White;
            this.TypeDocumentDescription.Disable = true;
            this.TypeDocumentDescription.DisabledAutomaticNumbering = false;
            this.TypeDocumentDescription.FieldValid = true;
            this.TypeDocumentDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeDocumentDescription.Form = null;
            this.TypeDocumentDescription.FormType = null;
            this.TypeDocumentDescription.IsDependecyUkey = false;
            this.TypeDocumentDescription.Location = new System.Drawing.Point(144, 6);
            this.TypeDocumentDescription.Name = "TypeDocumentDescription";
            this.TypeDocumentDescription.ObjectControl = null;
            this.TypeDocumentDescription.ObjetoApp = null;
            this.TypeDocumentDescription.Others = null;
            this.TypeDocumentDescription.PropertyControl = null;
            this.TypeDocumentDescription.PropertyDependecyUkey = null;
            this.TypeDocumentDescription.Size = new System.Drawing.Size(267, 53);
            this.TypeDocumentDescription.TabIndex = 1;
            this.TypeDocumentDescription.TabStop = false;
            this.TypeDocumentDescription.Text = "sTextBox2";
            this.TypeDocumentDescription.ToolTipContext = null;
            this.TypeDocumentDescription.Validations = null;
            this.TypeDocumentDescription.ValueControl = "";
            // 
            // Participation
            // 
            this.Participation.Caption = "";
            this.Participation.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Participation.CenterCaption = false;
            this.Participation.ComboBoxMultiForms = null;
            this.Participation.ComponentBackColor = System.Drawing.Color.White;
            this.Participation.DefaultValue = false;
            this.Participation.Disable = true;
            this.Participation.DisabledAutomaticNumbering = false;
            this.Participation.DisplayMember = "";
            this.Participation.FieldValid = true;
            this.Participation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Participation.Form = null;
            this.Participation.FormType = null;
            this.Participation.IsDependecyUkey = false;
            this.Participation.Location = new System.Drawing.Point(417, 6);
            this.Participation.Name = "Participation";
            this.Participation.ObjectControl = null;
            this.Participation.ObjetoApp = null;
            this.Participation.Others = null;
            this.Participation.PropertyControl = null;
            this.Participation.PropertyDependecyUkey = null;
            this.Participation.PropertySearch = null;
            this.Participation.Size = new System.Drawing.Size(185, 53);
            this.Participation.StandardValue = null;
            this.Participation.TabIndex = 2;
            this.Participation.TabStop = false;
            this.Participation.Text = "sComboBox1";
            this.Participation.ToolTipContext = null;
            this.Participation.Validations = null;
            this.Participation.ValueControl = null;
            this.Participation.ValueMember = "";
            // 
            // FTypeDocumentFinancial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(614, 238);
            this.Name = "FTypeDocumentFinancial";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox TypeDocumentCode;
        private Core.Component.SComboBox Participation;
        private Core.Component.STextBox TypeDocumentDescription;
    }
}
