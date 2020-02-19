namespace Esr.Module.Funerary.Forms.GroupAttendants
{
    partial class FGroupAttendant
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGroupAttendant));
            this.Code = new Esr.Core.Component.STextBox();
            this.Title = new Esr.Core.Component.STextBox();
            this.Attendants = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Attendants);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.Code);
            this.panel1.Size = new System.Drawing.Size(614, 311);
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
            this.Code.PropertyControl = null;
            this.Code.PropertyDependecyUkey = null;
            this.Code.Size = new System.Drawing.Size(154, 53);
            this.Code.TabIndex = 0;
            this.Code.TabStop = false;
            this.Code.Text = "sTextBox1";
            this.Code.ToolTipContext = null;
            this.Code.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Code.Validations")));
            this.Code.ValueControl = "";
            // 
            // Title
            // 
            this.Title.Caption = "";
            this.Title.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Title.CenterCaption = false;
            this.Title.ComponentBackColor = System.Drawing.Color.White;
            this.Title.Disable = true;
            this.Title.FieldValid = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Title.Form = null;
            this.Title.FormType = null;
            this.Title.IsDependecyUkey = false;
            this.Title.Location = new System.Drawing.Point(172, 6);
            this.Title.Name = "Title";
            this.Title.ObjectControl = null;
            this.Title.ObjetoApp = null;
            this.Title.PropertyControl = null;
            this.Title.PropertyDependecyUkey = null;
            this.Title.Size = new System.Drawing.Size(430, 53);
            this.Title.TabIndex = 1;
            this.Title.TabStop = false;
            this.Title.Text = "sTextBox1";
            this.Title.ToolTipContext = null;
            this.Title.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Title.Validations")));
            this.Title.ValueControl = "";
            // 
            // Attendants
            // 
            this.Attendants.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.Attendants.Caption = "";
            this.Attendants.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Attendants.CenterCaption = false;
            this.Attendants.ComponentBackColor = System.Drawing.Color.White;
            this.Attendants.Disable = true;
            this.Attendants.FieldValid = true;
            this.Attendants.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Attendants.Form = null;
            this.Attendants.FormType = null;
            this.Attendants.IsDependecyUkey = false;
            this.Attendants.IsSearch = false;
            this.Attendants.ListColunas = null;
            this.Attendants.Location = new System.Drawing.Point(12, 65);
            this.Attendants.Name = "Attendants";
            this.Attendants.ObjectControl = null;
            this.Attendants.ObjetoApp = null;
            this.Attendants.PropertyControl = null;
            this.Attendants.PropertyDependecyUkey = null;
            this.Attendants.PropertyInfos = null;
            this.Attendants.ScreenSecondary = false;
            this.Attendants.Size = new System.Drawing.Size(590, 243);
            this.Attendants.TabIndex = 2;
            this.Attendants.TabStop = false;
            this.Attendants.Text = "sGrid1";
            this.Attendants.ToolTipContext = null;
            this.Attendants.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Attendants.Validations")));
            this.Attendants.ValueControl = null;
            // 
            // FGroupAttendant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(614, 475);
            this.Name = "FGroupAttendant";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox Code;
        private Core.Component.STextBox Title;
        private Core.Component.SGrid Attendants;
    }
}
