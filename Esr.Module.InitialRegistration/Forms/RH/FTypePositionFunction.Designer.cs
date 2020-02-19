namespace Esr.Module.InitialRegistration.Forms.RH
{
    partial class FTypePositionFunction
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTypePositionFunction));
            this.TypePositionFunctionCode = new Esr.Core.Component.STextBox();
            this.TypePositionFunctionDescription = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TypePositionFunctionDescription);
            this.panel1.Controls.Add(this.TypePositionFunctionCode);
            this.panel1.Size = new System.Drawing.Size(614, 74);
            // 
            // TypeOfficeFunctionCode
            // 
            this.TypePositionFunctionCode.Caption = "";
            this.TypePositionFunctionCode.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypePositionFunctionCode.CenterCaption = false;
            this.TypePositionFunctionCode.ComponentBackColor = System.Drawing.Color.White;
            this.TypePositionFunctionCode.Disable = true;
            this.TypePositionFunctionCode.FieldValid = true;
            this.TypePositionFunctionCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypePositionFunctionCode.Form = null;
            this.TypePositionFunctionCode.FormType = null;
            this.TypePositionFunctionCode.IsDependecyUkey = false;
            this.TypePositionFunctionCode.Location = new System.Drawing.Point(12, 6);
            this.TypePositionFunctionCode.Name = "TypePositionFunctionCode";
            this.TypePositionFunctionCode.ObjectControl = null;
            this.TypePositionFunctionCode.ObjetoApp = null;
            this.TypePositionFunctionCode.PropertyControl = null;
            this.TypePositionFunctionCode.PropertyDependecyUkey = null;
            this.TypePositionFunctionCode.Size = new System.Drawing.Size(162, 54);
            this.TypePositionFunctionCode.TabIndex = 0;
            this.TypePositionFunctionCode.TabStop = false;
            this.TypePositionFunctionCode.Text = "sTextBox1";
            this.TypePositionFunctionCode.ToolTipContext = null;
            this.TypePositionFunctionCode.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TypeOfficeFunctionCode.Validations")));
            this.TypePositionFunctionCode.ValueControl = "";
            // 
            // TypeOfficeFunctionDescription
            // 
            this.TypePositionFunctionDescription.Caption = "";
            this.TypePositionFunctionDescription.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypePositionFunctionDescription.CenterCaption = false;
            this.TypePositionFunctionDescription.ComponentBackColor = System.Drawing.Color.White;
            this.TypePositionFunctionDescription.Disable = true;
            this.TypePositionFunctionDescription.FieldValid = true;
            this.TypePositionFunctionDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypePositionFunctionDescription.Form = null;
            this.TypePositionFunctionDescription.FormType = null;
            this.TypePositionFunctionDescription.IsDependecyUkey = false;
            this.TypePositionFunctionDescription.Location = new System.Drawing.Point(180, 6);
            this.TypePositionFunctionDescription.Name = "TypePositionFunctionDescription";
            this.TypePositionFunctionDescription.ObjectControl = null;
            this.TypePositionFunctionDescription.ObjetoApp = null;
            this.TypePositionFunctionDescription.PropertyControl = null;
            this.TypePositionFunctionDescription.PropertyDependecyUkey = null;
            this.TypePositionFunctionDescription.Size = new System.Drawing.Size(422, 54);
            this.TypePositionFunctionDescription.TabIndex = 1;
            this.TypePositionFunctionDescription.TabStop = false;
            this.TypePositionFunctionDescription.Text = "sTextBox2";
            this.TypePositionFunctionDescription.ToolTipContext = null;
            this.TypePositionFunctionDescription.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TypeOfficeFunctionDescription.Validations")));
            this.TypePositionFunctionDescription.ValueControl = "";
            // 
            // FTypePositionFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 238);
            this.Name = "FTypePositionFunction";
            this.Text = "FTypePositionFunction";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox TypePositionFunctionCode;
        private Core.Component.STextBox TypePositionFunctionDescription;
    }
}