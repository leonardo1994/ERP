namespace Esr.Module.InitialRegistration.Forms.RH
{
    partial class FNaturePositionFunction
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTypePositionFunction));
            this.NaturePositionFunctionCode = new Esr.Core.Component.STextBox();
            this.NaturePositionFunctionDescription = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NaturePositionFunctionDescription);
            this.panel1.Controls.Add(this.NaturePositionFunctionCode);
            this.panel1.Size = new System.Drawing.Size(614, 74);
            // 
            // TypeOfficeFunctionCode
            // 
            this.NaturePositionFunctionCode.Caption = "";
            this.NaturePositionFunctionCode.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NaturePositionFunctionCode.CenterCaption = false;
            this.NaturePositionFunctionCode.ComponentBackColor = System.Drawing.Color.White;
            this.NaturePositionFunctionCode.Disable = true;
            this.NaturePositionFunctionCode.FieldValid = true;
            this.NaturePositionFunctionCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NaturePositionFunctionCode.Form = null;
            this.NaturePositionFunctionCode.FormType = null;
            this.NaturePositionFunctionCode.IsDependecyUkey = false;
            this.NaturePositionFunctionCode.Location = new System.Drawing.Point(12, 6);
            this.NaturePositionFunctionCode.Name = "NaturePositionFunctionCode";
            this.NaturePositionFunctionCode.ObjectControl = null;
            this.NaturePositionFunctionCode.ObjetoApp = null;
            this.NaturePositionFunctionCode.PropertyControl = null;
            this.NaturePositionFunctionCode.PropertyDependecyUkey = null;
            this.NaturePositionFunctionCode.Size = new System.Drawing.Size(162, 54);
            this.NaturePositionFunctionCode.TabIndex = 0;
            this.NaturePositionFunctionCode.TabStop = false;
            this.NaturePositionFunctionCode.Text = "sTextBox1";
            this.NaturePositionFunctionCode.ToolTipContext = null;
            this.NaturePositionFunctionCode.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TypeOfficeFunctionCode.Validations")));
            this.NaturePositionFunctionCode.ValueControl = "";
            // 
            // TypeOfficeFunctionDescription
            // 
            this.NaturePositionFunctionDescription.Caption = "";
            this.NaturePositionFunctionDescription.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NaturePositionFunctionDescription.CenterCaption = false;
            this.NaturePositionFunctionDescription.ComponentBackColor = System.Drawing.Color.White;
            this.NaturePositionFunctionDescription.Disable = true;
            this.NaturePositionFunctionDescription.FieldValid = true;
            this.NaturePositionFunctionDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NaturePositionFunctionDescription.Form = null;
            this.NaturePositionFunctionDescription.FormType = null;
            this.NaturePositionFunctionDescription.IsDependecyUkey = false;
            this.NaturePositionFunctionDescription.Location = new System.Drawing.Point(180, 6);
            this.NaturePositionFunctionDescription.Name = "NaturePositionFunctionDescription";
            this.NaturePositionFunctionDescription.ObjectControl = null;
            this.NaturePositionFunctionDescription.ObjetoApp = null;
            this.NaturePositionFunctionDescription.PropertyControl = null;
            this.NaturePositionFunctionDescription.PropertyDependecyUkey = null;
            this.NaturePositionFunctionDescription.Size = new System.Drawing.Size(422, 54);
            this.NaturePositionFunctionDescription.TabIndex = 1;
            this.NaturePositionFunctionDescription.TabStop = false;
            this.NaturePositionFunctionDescription.Text = "sTextBox2";
            this.NaturePositionFunctionDescription.ToolTipContext = null;
            this.NaturePositionFunctionDescription.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("TypeOfficeFunctionDescription.Validations")));
            this.NaturePositionFunctionDescription.ValueControl = "";
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

        private Core.Component.STextBox NaturePositionFunctionCode;
        private Core.Component.STextBox NaturePositionFunctionDescription;
    }
}