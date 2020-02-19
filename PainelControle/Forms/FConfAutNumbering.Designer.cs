namespace Esr.Module.ControlPainel.Forms
{
    partial class FConfAutNumbering
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DbTableId = new Esr.Core.Component.SComboBox();
            this.FieldName = new Esr.Core.Component.STextBox();
            this.Sequence = new Esr.Core.Component.SCheckBox();
            this.NextNumber = new Esr.Core.Component.SNumeric();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NextNumber);
            this.panel1.Controls.Add(this.Sequence);
            this.panel1.Controls.Add(this.FieldName);
            this.panel1.Controls.Add(this.DbTableId);
            this.panel1.Size = new System.Drawing.Size(491, 190);
            // 
            // TableId
            // 
            this.DbTableId.Caption = "";
            this.DbTableId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DbTableId.CenterCaption = false;
            this.DbTableId.ComboBoxMultiForms = null;
            this.DbTableId.ComponentBackColor = System.Drawing.Color.White;
            this.DbTableId.DefaultValue = false;
            this.DbTableId.Disable = true;
            this.DbTableId.DisplayMember = "";
            this.DbTableId.FieldValid = true;
            this.DbTableId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DbTableId.Form = null;
            this.DbTableId.FormType = null;
            this.DbTableId.IsDependecyUkey = false;
            this.DbTableId.Location = new System.Drawing.Point(12, 6);
            this.DbTableId.Name = "DbTableId";
            this.DbTableId.ObjectControl = null;
            this.DbTableId.ObjetoApp = null;
            this.DbTableId.Others = null;
            this.DbTableId.PropertyControl = null;
            this.DbTableId.PropertyDependecyUkey = null;
            this.DbTableId.Size = new System.Drawing.Size(470, 53);
            this.DbTableId.StandardValue = null;
            this.DbTableId.TabIndex = 0;
            this.DbTableId.TabStop = false;
            this.DbTableId.Text = "sComboBox1";
            this.DbTableId.ToolTipContext = null;
            this.DbTableId.Validations = null;
            this.DbTableId.ValueControl = null;
            this.DbTableId.ValueMember = "";
            // 
            // FieldName
            // 
            this.FieldName.Caption = "";
            this.FieldName.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FieldName.CenterCaption = false;
            this.FieldName.ComponentBackColor = System.Drawing.Color.White;
            this.FieldName.Disable = true;
            this.FieldName.FieldValid = true;
            this.FieldName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FieldName.Form = null;
            this.FieldName.FormType = null;
            this.FieldName.IsDependecyUkey = false;
            this.FieldName.Location = new System.Drawing.Point(12, 65);
            this.FieldName.Name = "FieldName";
            this.FieldName.ObjectControl = null;
            this.FieldName.ObjetoApp = null;
            this.FieldName.Others = null;
            this.FieldName.PropertyControl = null;
            this.FieldName.PropertyDependecyUkey = null;
            this.FieldName.Size = new System.Drawing.Size(467, 53);
            this.FieldName.TabIndex = 1;
            this.FieldName.TabStop = false;
            this.FieldName.Text = "sTextBox1";
            this.FieldName.ToolTipContext = null;
            this.FieldName.Validations = null;
            this.FieldName.ValueControl = "";
            // 
            // Sequence
            // 
            this.Sequence.Caption = "";
            this.Sequence.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Sequence.CenterCaption = false;
            this.Sequence.ComponentBackColor = System.Drawing.Color.White;
            this.Sequence.Disable = true;
            this.Sequence.FieldValid = true;
            this.Sequence.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Sequence.Form = null;
            this.Sequence.FormType = null;
            this.Sequence.IsDependecyUkey = false;
            this.Sequence.Location = new System.Drawing.Point(12, 146);
            this.Sequence.Name = "Sequence";
            this.Sequence.ObjectControl = null;
            this.Sequence.ObjetoApp = null;
            this.Sequence.Others = null;
            this.Sequence.PropertyControl = null;
            this.Sequence.PropertyDependecyUkey = null;
            this.Sequence.Size = new System.Drawing.Size(222, 23);
            this.Sequence.TabIndex = 2;
            this.Sequence.TabStop = false;
            this.Sequence.Text = "sCheckBox1";
            this.Sequence.ToolTipContext = null;
            this.Sequence.Validations = null;
            this.Sequence.ValueControl = false;
            // 
            // NextNumber
            // 
            this.NextNumber.Caption = "";
            this.NextNumber.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NextNumber.CenterCaption = false;
            this.NextNumber.ComponentBackColor = System.Drawing.Color.White;
            this.NextNumber.DecimalPlaces = 0;
            this.NextNumber.Disable = true;
            this.NextNumber.FieldValid = true;
            this.NextNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NextNumber.Form = null;
            this.NextNumber.FormType = null;
            this.NextNumber.IsDependecyUkey = false;
            this.NextNumber.Location = new System.Drawing.Point(241, 125);
            this.NextNumber.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NextNumber.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NextNumber.Name = "NextNumber";
            this.NextNumber.ObjectControl = null;
            this.NextNumber.ObjetoApp = null;
            this.NextNumber.Others = null;
            this.NextNumber.PropertyControl = null;
            this.NextNumber.PropertyDependecyUkey = null;
            this.NextNumber.Size = new System.Drawing.Size(238, 52);
            this.NextNumber.TabIndex = 3;
            this.NextNumber.TabStop = false;
            this.NextNumber.Text = "sNumeric1";
            this.NextNumber.ThousandsSeparator = false;
            this.NextNumber.ToolTipContext = null;
            this.NextNumber.Validations = null;
            this.NextNumber.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // FConfAutNumbering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(491, 354);
            this.Name = "FConfAutNumbering";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SComboBox DbTableId;
        private Core.Component.STextBox FieldName;
        private Core.Component.SCheckBox Sequence;
        private Core.Component.SNumeric NextNumber;
    }
}
