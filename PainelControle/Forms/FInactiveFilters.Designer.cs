namespace Esr.Module.ControlPainel.Forms
{
    partial class FInactiveFilters
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TypeFilter = new Esr.Core.Component.SComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TypeFilter);
            this.panel1.Size = new System.Drawing.Size(536, 104);
            // 
            // TypeFilter
            // 
            this.TypeFilter.Caption = "";
            this.TypeFilter.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TypeFilter.CenterCaption = false;
            this.TypeFilter.ComboBoxMultiForms = null;
            this.TypeFilter.ComponentBackColor = System.Drawing.Color.White;
            this.TypeFilter.DefaultValue = false;
            this.TypeFilter.Disable = true;
            this.TypeFilter.DisplayMember = "";
            this.TypeFilter.FieldValid = true;
            this.TypeFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeFilter.Form = null;
            this.TypeFilter.FormType = null;
            this.TypeFilter.IsDependecyUkey = false;
            this.TypeFilter.Location = new System.Drawing.Point(12, 27);
            this.TypeFilter.Name = "TypeFilter";
            this.TypeFilter.ObjectControl = null;
            this.TypeFilter.ObjetoApp = null;
            this.TypeFilter.PropertyControl = null;
            this.TypeFilter.PropertyDependecyUkey = null;
            this.TypeFilter.Size = new System.Drawing.Size(512, 55);
            this.TypeFilter.StandardValue = null;
            this.TypeFilter.TabIndex = 0;
            this.TypeFilter.TabStop = false;
            this.TypeFilter.Text = "sComboBox1";
            this.TypeFilter.ToolTipContext = null;
            this.TypeFilter.Validations = null;
            this.TypeFilter.ValueControl = null;
            this.TypeFilter.ValueMember = "";
            // 
            // FInactiveFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(536, 268);
            this.Name = "FInactiveFilters";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SComboBox TypeFilter;
    }
}
