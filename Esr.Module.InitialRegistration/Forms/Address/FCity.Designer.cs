namespace Esr.Module.InitialRegistration.Forms.Address
{
    partial class FCity
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCity));
            this.CityName = new Esr.Core.Component.STextBox();
            this.CodeIbge = new Esr.Core.Component.STextBox();
            this.StateId = new Esr.Core.Component.SComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StateId);
            this.panel1.Controls.Add(this.CodeIbge);
            this.panel1.Controls.Add(this.CityName);
            this.panel1.Size = new System.Drawing.Size(627, 131);
            // 
            // CityName
            // 
            this.CityName.Caption = "";
            this.CityName.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.CityName.CenterCaption = false;
            this.CityName.ComponentBackColor = System.Drawing.Color.White;
            this.CityName.Disable = true;
            this.CityName.FieldValid = true;
            this.CityName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CityName.Form = null;
            this.CityName.FormType = null;
            this.CityName.IsDependecyUkey = false;
            this.CityName.Location = new System.Drawing.Point(12, 6);
            this.CityName.Name = "CityName";
            this.CityName.ObjectControl = null;
            this.CityName.ObjetoApp = null;
            this.CityName.PropertyControl = null;
            this.CityName.PropertyDependecyUkey = null;
            this.CityName.Size = new System.Drawing.Size(420, 56);
            this.CityName.TabIndex = 0;
            this.CityName.TabStop = false;
            this.CityName.Text = "sTextBox1";
            this.CityName.ToolTipContext = null;
            this.CityName.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("CityName.Validations")));
            this.CityName.ValueControl = "";
            // 
            // CodeIbge
            // 
            this.CodeIbge.Caption = "";
            this.CodeIbge.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.CodeIbge.CenterCaption = false;
            this.CodeIbge.ComponentBackColor = System.Drawing.Color.White;
            this.CodeIbge.Disable = true;
            this.CodeIbge.FieldValid = true;
            this.CodeIbge.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CodeIbge.Form = null;
            this.CodeIbge.FormType = null;
            this.CodeIbge.IsDependecyUkey = false;
            this.CodeIbge.Location = new System.Drawing.Point(438, 6);
            this.CodeIbge.Name = "CodeIbge";
            this.CodeIbge.ObjectControl = null;
            this.CodeIbge.ObjetoApp = null;
            this.CodeIbge.PropertyControl = null;
            this.CodeIbge.PropertyDependecyUkey = null;
            this.CodeIbge.Size = new System.Drawing.Size(180, 56);
            this.CodeIbge.TabIndex = 1;
            this.CodeIbge.TabStop = false;
            this.CodeIbge.Text = "sTextBox2";
            this.CodeIbge.ToolTipContext = null;
            this.CodeIbge.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("CodeIbge.Validations")));
            this.CodeIbge.ValueControl = "";
            // 
            // StateId
            // 
            this.StateId.Caption = "";
            this.StateId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.StateId.CenterCaption = false;
            this.StateId.ComponentBackColor = System.Drawing.Color.White;
            this.StateId.DefaultValue = false;
            this.StateId.Disable = true;
            this.StateId.DisplayMember = "";
            this.StateId.FieldValid = true;
            this.StateId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.StateId.Form = null;
            this.StateId.FormType = null;
            this.StateId.IsDependecyUkey = false;
            this.StateId.Location = new System.Drawing.Point(12, 68);
            this.StateId.Name = "StateId";
            this.StateId.ObjectControl = null;
            this.StateId.ObjetoApp = null;
            this.StateId.PropertyControl = null;
            this.StateId.PropertyDependecyUkey = null;
            this.StateId.Size = new System.Drawing.Size(606, 55);
            this.StateId.StandardValue = null;
            this.StateId.TabIndex = 2;
            this.StateId.TabStop = false;
            this.StateId.Text = "sComboBox1";
            this.StateId.ToolTipContext = null;
            this.StateId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("StateId.Validations")));
            this.StateId.ValueControl = null;
            this.StateId.ValueMember = "";
            // 
            // FCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(627, 295);
            this.Name = "FCity";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox CityName;
        private Core.Component.SComboBox StateId;
        private Core.Component.STextBox CodeIbge;
    }
}
