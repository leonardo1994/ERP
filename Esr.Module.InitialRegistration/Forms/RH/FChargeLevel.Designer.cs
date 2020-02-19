namespace Esr.Module.InitialRegistration.Forms.RH
{
    partial class FChargeLevel
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChargeLevel));
            this.ChargeLevelCode = new Esr.Core.Component.STextBox();
            this.ChargeLevelDescription = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChargeLevelDescription);
            this.panel1.Controls.Add(this.ChargeLevelCode);
            this.panel1.Size = new System.Drawing.Size(614, 74);
            // 
            // ChargeLevelCode
            // 
            this.ChargeLevelCode.Caption = "";
            this.ChargeLevelCode.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ChargeLevelCode.CenterCaption = false;
            this.ChargeLevelCode.ComponentBackColor = System.Drawing.Color.White;
            this.ChargeLevelCode.Disable = true;
            this.ChargeLevelCode.FieldValid = true;
            this.ChargeLevelCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ChargeLevelCode.Form = null;
            this.ChargeLevelCode.FormType = null;
            this.ChargeLevelCode.IsDependecyUkey = false;
            this.ChargeLevelCode.Location = new System.Drawing.Point(12, 6);
            this.ChargeLevelCode.Name = "ChargeLevelCode";
            this.ChargeLevelCode.ObjectControl = null;
            this.ChargeLevelCode.ObjetoApp = null;
            this.ChargeLevelCode.PropertyControl = null;
            this.ChargeLevelCode.PropertyDependecyUkey = null;
            this.ChargeLevelCode.Size = new System.Drawing.Size(162, 54);
            this.ChargeLevelCode.TabIndex = 0;
            this.ChargeLevelCode.TabStop = false;
            this.ChargeLevelCode.Text = "sTextBox1";
            this.ChargeLevelCode.ToolTipContext = null;
            this.ChargeLevelCode.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ChargeLevelCode.Validations")));
            this.ChargeLevelCode.ValueControl = "";
            // 
            // ChargeLevelDescription
            // 
            this.ChargeLevelDescription.Caption = "";
            this.ChargeLevelDescription.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ChargeLevelDescription.CenterCaption = false;
            this.ChargeLevelDescription.ComponentBackColor = System.Drawing.Color.White;
            this.ChargeLevelDescription.Disable = true;
            this.ChargeLevelDescription.FieldValid = true;
            this.ChargeLevelDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ChargeLevelDescription.Form = null;
            this.ChargeLevelDescription.FormType = null;
            this.ChargeLevelDescription.IsDependecyUkey = false;
            this.ChargeLevelDescription.Location = new System.Drawing.Point(180, 6);
            this.ChargeLevelDescription.Name = "ChargeLevelDescription";
            this.ChargeLevelDescription.ObjectControl = null;
            this.ChargeLevelDescription.ObjetoApp = null;
            this.ChargeLevelDescription.PropertyControl = null;
            this.ChargeLevelDescription.PropertyDependecyUkey = null;
            this.ChargeLevelDescription.Size = new System.Drawing.Size(422, 54);
            this.ChargeLevelDescription.TabIndex = 1;
            this.ChargeLevelDescription.TabStop = false;
            this.ChargeLevelDescription.Text = "sTextBox2";
            this.ChargeLevelDescription.ToolTipContext = null;
            this.ChargeLevelDescription.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ChargeLevelDescription.Validations")));
            this.ChargeLevelDescription.ValueControl = "";
            // 
            // FChargeLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 238);
            this.Name = "FChargeLevel";
            this.Text = "FTypePositionFunction";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox ChargeLevelCode;
        private Core.Component.STextBox ChargeLevelDescription;
    }
}