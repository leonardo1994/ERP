namespace Esr.Module.InitialRegistration.Forms.Persons
{
    partial class FPersonAddress
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
           
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPersonAddress));
            this.Number = new Esr.Core.Component.SNumeric();
            this.Complement = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Complement);
            this.panel1.Controls.Add(this.Number);
            this.panel1.Size = new System.Drawing.Size(599, 263);
            this.panel1.Controls.SetChildIndex(this.ZipCode, 0);
            this.panel1.Controls.SetChildIndex(this.Street, 0);
            this.panel1.Controls.SetChildIndex(this.Neighborhood, 0);
            this.panel1.Controls.SetChildIndex(this.CityId, 0);
            this.panel1.Controls.SetChildIndex(this.StateId, 0);
            this.panel1.Controls.SetChildIndex(this.CountryId, 0);
            this.panel1.Controls.SetChildIndex(this.Number, 0);
            this.panel1.Controls.SetChildIndex(this.Complement, 0);
            // 
            // Number
            // 
            this.Number.Caption = "";
            this.Number.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Number.CenterCaption = false;
            this.Number.ComponentBackColor = System.Drawing.Color.White;
            this.Number.DecimalPlaces = 0;
            this.Number.Disable = true;
            this.Number.FieldValid = true;
            this.Number.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Number.Form = null;
            this.Number.FormType = null;
            this.Number.IsDependecyUkey = false;
            this.Number.Location = new System.Drawing.Point(13, 190);
          
            this.Number.Name = "Number";
            this.Number.ObjetoApp = null;
            this.Number.PropertyControl = null;
            this.Number.PropertyDependecyUkey = null;
            this.Number.Size = new System.Drawing.Size(91, 59);
            this.Number.TabIndex = 6;
            this.Number.TabStop = false;
            this.Number.Text = "sNumeric1";
            this.Number.ThousandsSeparator = false;
            this.Number.ToolTipContext = null;
        
            // 
            // Complement
            // 
            this.Complement.Caption = "";
            this.Complement.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Complement.CenterCaption = false;
            this.Complement.ComponentBackColor = System.Drawing.Color.White;
            this.Complement.Disable = true;
            this.Complement.FieldValid = true;
            this.Complement.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Complement.Form = null;
            this.Complement.FormType = null;
            this.Complement.IsDependecyUkey = false;
            this.Complement.Location = new System.Drawing.Point(110, 190);
            this.Complement.Name = "Complement";
            this.Complement.ObjetoApp = null;
            this.Complement.PropertyControl = null;
            this.Complement.PropertyDependecyUkey = null;
            this.Complement.Size = new System.Drawing.Size(477, 59);
            this.Complement.TabIndex = 7;
            this.Complement.TabStop = false;
            this.Complement.Text = "sTextBox1";
            this.Complement.ToolTipContext = null;
            // 
            // FPersonAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(599, 427);
            this.Name = "FPersonAddress";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Core.Component.STextBox Complement;
        private Core.Component.SNumeric Number;
    }
}
