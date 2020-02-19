namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    partial class FMark
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMark));
            this.MarkDescription = new Esr.Core.Component.STextBox();
            this.MarkCode = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MarkDescription);
            this.panel1.Controls.Add(this.MarkCode);
            this.panel1.Size = new System.Drawing.Size(656, 78);
            // 
            // MarkDescription
            // 
            this.MarkDescription.Caption = "";
            this.MarkDescription.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.MarkDescription.CenterCaption = false;
            this.MarkDescription.ComponentBackColor = System.Drawing.Color.White;
            this.MarkDescription.Disable = true;
            this.MarkDescription.FieldValid = true;
            this.MarkDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MarkDescription.Form = null;
            this.MarkDescription.FormType = null;
            this.MarkDescription.IsDependecyUkey = false;
            this.MarkDescription.Location = new System.Drawing.Point(184, 12);
            this.MarkDescription.Name = "MarkDescription";
            this.MarkDescription.ObjectControl = null;
            this.MarkDescription.ObjetoApp = null;
            this.MarkDescription.PropertyControl = null;
            this.MarkDescription.PropertyDependecyUkey = null;
            this.MarkDescription.Size = new System.Drawing.Size(460, 54);
            this.MarkDescription.TabIndex = 1;
            this.MarkDescription.Text = "sTextBox2";
            this.MarkDescription.ToolTipContext = null;
            this.MarkDescription.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("MarkDescription.Validations")));
            this.MarkDescription.ValueControl = "";
            // 
            // MarkCode
            // 
            this.MarkCode.Caption = "";
            this.MarkCode.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.MarkCode.CenterCaption = false;
            this.MarkCode.ComponentBackColor = System.Drawing.Color.White;
            this.MarkCode.Disable = true;
            this.MarkCode.FieldValid = true;
            this.MarkCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MarkCode.Form = null;
            this.MarkCode.FormType = null;
            this.MarkCode.IsDependecyUkey = false;
            this.MarkCode.Location = new System.Drawing.Point(12, 12);
            this.MarkCode.Name = "MarkCode";
            this.MarkCode.ObjectControl = null;
            this.MarkCode.ObjetoApp = null;
            this.MarkCode.PropertyControl = null;
            this.MarkCode.PropertyDependecyUkey = null;
            this.MarkCode.Size = new System.Drawing.Size(166, 54);
            this.MarkCode.TabIndex = 0;
            this.MarkCode.TabStop = false;
            this.MarkCode.Text = "sTextBox1";
            this.MarkCode.ToolTipContext = null;
            this.MarkCode.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("MarkCode.Validations")));
            this.MarkCode.ValueControl = "";
            // 
            // FMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(656, 242);
            this.Name = "FMark";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox MarkDescription;
        private Core.Component.STextBox MarkCode;
    }
}
