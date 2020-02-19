namespace Esr.Module.Funerary.Forms.DebitNotes
{
    partial class FDebitNotes
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDebitNotes));
            this.NumberDebitNote = new Esr.Core.Component.STextBox();
            this.Value = new Esr.Core.Component.SNumeric();
            this.Date = new Esr.Core.Component.SDateTimePicker();
            this.ProcessNumber = new Esr.Core.Component.STextBox();
            this.ContractorId = new Esr.Core.Component.SComboBox();
            this.DeadName = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NumberDebitNote);
            this.panel1.Controls.Add(this.Value);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.ProcessNumber);
            this.panel1.Controls.Add(this.ContractorId);
            this.panel1.Controls.Add(this.DeadName);
            this.panel1.Size = new System.Drawing.Size(718, 200);
            // 
            // NumberDebitNote
            // 
            this.NumberDebitNote.Caption = "";
            this.NumberDebitNote.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NumberDebitNote.CenterCaption = false;
            this.NumberDebitNote.ComponentBackColor = System.Drawing.Color.White;
            this.NumberDebitNote.Disable = true;
            this.NumberDebitNote.FieldValid = true;
            this.NumberDebitNote.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NumberDebitNote.Form = null;
            this.NumberDebitNote.FormType = null;
            this.NumberDebitNote.IsDependecyUkey = false;
            this.NumberDebitNote.Location = new System.Drawing.Point(13, 15);
            this.NumberDebitNote.Name = "NumberDebitNote";
            this.NumberDebitNote.ObjectControl = null;
            this.NumberDebitNote.ObjetoApp = null;
            this.NumberDebitNote.PropertyControl = null;
            this.NumberDebitNote.PropertyDependecyUkey = null;
            this.NumberDebitNote.Size = new System.Drawing.Size(116, 53);
            this.NumberDebitNote.TabIndex = 0;
            this.NumberDebitNote.TabStop = false;
            this.NumberDebitNote.ToolTipContext = null;
            this.NumberDebitNote.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NumberDebitNote.Validations")));
            this.NumberDebitNote.ValueControl = "";
            // 
            // Value
            // 
            this.Value.Caption = "";
            this.Value.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Value.CenterCaption = false;
            this.Value.ComponentBackColor = System.Drawing.Color.White;
            this.Value.DecimalPlaces = 2;
            this.Value.Disable = true;
            this.Value.FieldValid = true;
            this.Value.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Value.Form = null;
            this.Value.FormType = null;
            this.Value.IsDependecyUkey = false;
            this.Value.Location = new System.Drawing.Point(430, 135);
            this.Value.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Value.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Value.Name = "Value";
            this.Value.ObjectControl = null;
            this.Value.ObjetoApp = null;
            this.Value.PropertyControl = null;
            this.Value.PropertyDependecyUkey = null;
            this.Value.Size = new System.Drawing.Size(277, 54);
            this.Value.TabIndex = 5;
            this.Value.TabStop = false;
            this.Value.ThousandsSeparator = true;
            this.Value.ToolTipContext = null;
            this.Value.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Value.Validations")));
            this.Value.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // Date
            // 
            this.Date.Caption = "";
            this.Date.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Date.CenterCaption = false;
            this.Date.ComponentBackColor = System.Drawing.Color.White;
            this.Date.Disable = true;
            this.Date.FieldValid = true;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Date.Form = null;
            this.Date.FormType = null;
            this.Date.IsDependecyUkey = false;
            this.Date.Location = new System.Drawing.Point(13, 135);
            this.Date.Name = "Date";
            this.Date.ObjectControl = null;
            this.Date.ObjetoApp = null;
            this.Date.PropertyControl = null;
            this.Date.PropertyDependecyUkey = null;
            this.Date.Size = new System.Drawing.Size(411, 54);
            this.Date.TabIndex = 4;
            this.Date.TabStop = false;
            this.Date.ToolTipContext = null;
            this.Date.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Date.Validations")));
            this.Date.ValueControl = new System.DateTime(2016, 11, 10, 22, 29, 0, 672);
            // 
            // ProcessNumber
            // 
            this.ProcessNumber.Caption = "";
            this.ProcessNumber.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ProcessNumber.CenterCaption = false;
            this.ProcessNumber.ComponentBackColor = System.Drawing.Color.White;
            this.ProcessNumber.Disable = true;
            this.ProcessNumber.FieldValid = true;
            this.ProcessNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProcessNumber.Form = null;
            this.ProcessNumber.FormType = null;
            this.ProcessNumber.IsDependecyUkey = false;
            this.ProcessNumber.Location = new System.Drawing.Point(135, 15);
            this.ProcessNumber.Name = "ProcessNumber";
            this.ProcessNumber.ObjectControl = null;
            this.ProcessNumber.ObjetoApp = null;
            this.ProcessNumber.PropertyControl = null;
            this.ProcessNumber.PropertyDependecyUkey = null;
            this.ProcessNumber.Size = new System.Drawing.Size(186, 54);
            this.ProcessNumber.TabIndex = 1;
            this.ProcessNumber.TabStop = false;
            this.ProcessNumber.ToolTipContext = null;
            this.ProcessNumber.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ProcessNumber.Validations")));
            this.ProcessNumber.ValueControl = "";
            // 
            // ContractorId
            // 
            this.ContractorId.Caption = "";
            this.ContractorId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ContractorId.CenterCaption = false;
            this.ContractorId.ComponentBackColor = System.Drawing.Color.White;
            this.ContractorId.DefaultValue = false;
            this.ContractorId.Disable = true;
            this.ContractorId.DisplayMember = "";
            this.ContractorId.FieldValid = true;
            this.ContractorId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ContractorId.Form = null;
            this.ContractorId.FormType = null;
            this.ContractorId.IsDependecyUkey = false;
            this.ContractorId.Location = new System.Drawing.Point(327, 15);
            this.ContractorId.Name = "ContractorId";
            this.ContractorId.ObjectControl = null;
            this.ContractorId.ObjetoApp = null;
            this.ContractorId.PropertyControl = null;
            this.ContractorId.PropertyDependecyUkey = null;
            this.ContractorId.Size = new System.Drawing.Size(380, 54);
            this.ContractorId.StandardValue = null;
            this.ContractorId.TabIndex = 2;
            this.ContractorId.TabStop = false;
            this.ContractorId.ToolTipContext = null;
            this.ContractorId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ContractorId.Validations")));
            this.ContractorId.ValueControl = null;
            this.ContractorId.ValueMember = "";
            // 
            // DeadName
            // 
            this.DeadName.Caption = "";
            this.DeadName.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.DeadName.CenterCaption = false;
            this.DeadName.ComponentBackColor = System.Drawing.Color.White;
            this.DeadName.Disable = true;
            this.DeadName.FieldValid = true;
            this.DeadName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeadName.Form = null;
            this.DeadName.FormType = null;
            this.DeadName.IsDependecyUkey = false;
            this.DeadName.Location = new System.Drawing.Point(13, 75);
            this.DeadName.Name = "DeadName";
            this.DeadName.ObjectControl = null;
            this.DeadName.ObjetoApp = null;
            this.DeadName.PropertyControl = null;
            this.DeadName.PropertyDependecyUkey = null;
            this.DeadName.Size = new System.Drawing.Size(694, 54);
            this.DeadName.TabIndex = 3;
            this.DeadName.TabStop = false;
            this.DeadName.ToolTipContext = null;
            this.DeadName.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("DeadName.Validations")));
            this.DeadName.ValueControl = "";
            // 
            // FDebitNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(718, 364);
            this.ImageSource = global::Esr.Module.Funerary.Properties.Resources.icon_nt;
            this.Name = "FDebitNotes";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox NumberDebitNote;
        private Core.Component.SNumeric Value;
        private Core.Component.SDateTimePicker Date;
        private Core.Component.STextBox ProcessNumber;
        private Core.Component.SComboBox ContractorId;
        private Core.Component.STextBox DeadName;
    }
}
