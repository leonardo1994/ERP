namespace Esr.Module.InitialRegistration.Forms.Sales
{
    partial class FFormOfPayment
    {
       
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TypePaymant = new Esr.Core.Component.SComboBox();
            this.Description = new Esr.Core.Component.STextBox();
            this.Code = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Code);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.TypePaymant);
            this.panel1.Size = new System.Drawing.Size(535, 74);
            // 
            // TypePaymant
            // 
            this.TypePaymant.Caption = "";
            this.TypePaymant.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypePaymant.CenterCaption = false;
            this.TypePaymant.ComboBoxMultiForms = null;
            this.TypePaymant.ComponentBackColor = System.Drawing.Color.White;
            this.TypePaymant.DefaultValue = false;
            this.TypePaymant.Disable = true;
            this.TypePaymant.DisplayMember = "";
            this.TypePaymant.FieldValid = true;
            this.TypePaymant.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypePaymant.Form = null;
            this.TypePaymant.FormType = null;
            this.TypePaymant.IsDependecyUkey = false;
            this.TypePaymant.Location = new System.Drawing.Point(396, 6);
            this.TypePaymant.Name = "TypePaymant";
            this.TypePaymant.ObjectControl = null;
            this.TypePaymant.ObjetoApp = null;
            this.TypePaymant.Others = null;
            this.TypePaymant.PropertyControl = null;
            this.TypePaymant.PropertyDependecyUkey = null;
            this.TypePaymant.Size = new System.Drawing.Size(129, 60);
            this.TypePaymant.StandardValue = null;
            this.TypePaymant.TabIndex = 0;
            this.TypePaymant.TabStop = false;
            this.TypePaymant.Text = "sComboBox1";
            this.TypePaymant.ToolTipContext = null;
            this.TypePaymant.Validations = null;
            this.TypePaymant.ValueControl = null;
            this.TypePaymant.ValueMember = "";
            // 
            // Description
            // 
            this.Description.Caption = "";
            this.Description.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Description.CenterCaption = false;
            this.Description.ComponentBackColor = System.Drawing.Color.White;
            this.Description.Disable = true;
            this.Description.FieldValid = true;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Description.Form = null;
            this.Description.FormType = null;
            this.Description.IsDependecyUkey = false;
            this.Description.Location = new System.Drawing.Point(122, 5);
            this.Description.Name = "Description";
            this.Description.ObjectControl = null;
            this.Description.ObjetoApp = null;
            this.Description.Others = null;
            this.Description.PropertyControl = null;
            this.Description.PropertyDependecyUkey = null;
            this.Description.Size = new System.Drawing.Size(268, 55);
            this.Description.TabIndex = 1;
            this.Description.TabStop = false;
            this.Description.Text = "sTextBox1";
            this.Description.ToolTipContext = null;
            this.Description.Validations = null;
            this.Description.ValueControl = "";
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
            this.Code.Location = new System.Drawing.Point(12, 6);
            this.Code.Name = "Code";
            this.Code.ObjectControl = null;
            this.Code.ObjetoApp = null;
            this.Code.Others = null;
            this.Code.PropertyControl = null;
            this.Code.PropertyDependecyUkey = null;
            this.Code.Size = new System.Drawing.Size(104, 54);
            this.Code.TabIndex = 2;
            this.Code.TabStop = false;
            this.Code.Text = "sTextBox2";
            this.Code.ToolTipContext = null;
            this.Code.Validations = null;
            this.Code.ValueControl = "";
            // 
            // FFormOfPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(535, 238);
            this.Name = "FFormOfPayment";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SComboBox TypePaymant;
        private Core.Component.STextBox Code;
        private Core.Component.STextBox Description;
    }
}
