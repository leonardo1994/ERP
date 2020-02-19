namespace Esr.Module.Financial.Forms.Receive
{
    partial class FInstallmentOfAccountsReceivable
    {

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortionNumber = new Esr.Core.Component.STextBox();
            this.ActualMaturity = new Esr.Core.Component.SDateTimePicker();
            this.NominalMaturity = new Esr.Core.Component.SDateTimePicker();
            this.PlotValue = new Esr.Core.Component.SNumeric();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PlotValue);
            this.panel1.Controls.Add(this.NominalMaturity);
            this.panel1.Controls.Add(this.ActualMaturity);
            this.panel1.Controls.Add(this.PortionNumber);
            this.panel1.Size = new System.Drawing.Size(614, 77);
            // 
            // PortionNumber
            // 
            this.PortionNumber.Caption = "";
            this.PortionNumber.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.PortionNumber.CenterCaption = false;
            this.PortionNumber.ComponentBackColor = System.Drawing.Color.White;
            this.PortionNumber.Disable = true;
            this.PortionNumber.DisabledAutomaticNumbering = false;
            this.PortionNumber.FieldValid = true;
            this.PortionNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PortionNumber.Form = null;
            this.PortionNumber.FormType = null;
            this.PortionNumber.IsDependecyUkey = false;
            this.PortionNumber.Location = new System.Drawing.Point(12, 6);
            this.PortionNumber.Name = "PortionNumber";
            this.PortionNumber.ObjectControl = null;
            this.PortionNumber.ObjetoApp = null;
            this.PortionNumber.Others = null;
            this.PortionNumber.PropertyControl = null;
            this.PortionNumber.PropertyDependecyUkey = null;
            this.PortionNumber.Size = new System.Drawing.Size(125, 54);
            this.PortionNumber.TabIndex = 0;
            this.PortionNumber.TabStop = false;
            this.PortionNumber.Text = "sTextBox1";
            this.PortionNumber.ToolTipContext = null;
            this.PortionNumber.Validations = null;
            this.PortionNumber.ValueControl = "";
            // 
            // ActualMaturity
            // 
            this.ActualMaturity.Caption = "";
            this.ActualMaturity.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ActualMaturity.CenterCaption = false;
            this.ActualMaturity.ComponentBackColor = System.Drawing.Color.White;
            this.ActualMaturity.CustomFormat = null;
            this.ActualMaturity.Disable = true;
            this.ActualMaturity.DisabledAutomaticNumbering = false;
            this.ActualMaturity.FieldValid = true;
            this.ActualMaturity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ActualMaturity.Form = null;
            this.ActualMaturity.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ActualMaturity.FormType = null;
            this.ActualMaturity.IsDependecyUkey = false;
            this.ActualMaturity.Location = new System.Drawing.Point(143, 6);
            this.ActualMaturity.Name = "ActualMaturity";
            this.ActualMaturity.ObjectControl = null;
            this.ActualMaturity.ObjetoApp = null;
            this.ActualMaturity.Others = null;
            this.ActualMaturity.PropertyControl = null;
            this.ActualMaturity.PropertyDependecyUkey = null;
            this.ActualMaturity.Size = new System.Drawing.Size(129, 54);
            this.ActualMaturity.TabIndex = 1;
            this.ActualMaturity.TabStop = false;
            this.ActualMaturity.Text = "sDateTimePicker1";
            this.ActualMaturity.ToolTipContext = null;
            this.ActualMaturity.Validations = null;
            this.ActualMaturity.ValueControl = new System.DateTime(2018, 3, 30, 9, 15, 42, 626);
            // 
            // NominalMaturity
            // 
            this.NominalMaturity.Caption = "";
            this.NominalMaturity.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NominalMaturity.CenterCaption = false;
            this.NominalMaturity.ComponentBackColor = System.Drawing.Color.White;
            this.NominalMaturity.CustomFormat = null;
            this.NominalMaturity.Disable = true;
            this.NominalMaturity.DisabledAutomaticNumbering = false;
            this.NominalMaturity.FieldValid = true;
            this.NominalMaturity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NominalMaturity.Form = null;
            this.NominalMaturity.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NominalMaturity.FormType = null;
            this.NominalMaturity.IsDependecyUkey = false;
            this.NominalMaturity.Location = new System.Drawing.Point(278, 6);
            this.NominalMaturity.Name = "NominalMaturity";
            this.NominalMaturity.ObjectControl = null;
            this.NominalMaturity.ObjetoApp = null;
            this.NominalMaturity.Others = null;
            this.NominalMaturity.PropertyControl = null;
            this.NominalMaturity.PropertyDependecyUkey = null;
            this.NominalMaturity.Size = new System.Drawing.Size(129, 54);
            this.NominalMaturity.TabIndex = 2;
            this.NominalMaturity.TabStop = false;
            this.NominalMaturity.Text = "sDateTimePicker2";
            this.NominalMaturity.ToolTipContext = null;
            this.NominalMaturity.Validations = null;
            this.NominalMaturity.ValueControl = new System.DateTime(2018, 3, 30, 9, 15, 42, 626);
            // 
            // PlotValue
            // 
            this.PlotValue.Caption = "";
            this.PlotValue.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.PlotValue.CenterCaption = false;
            this.PlotValue.ComponentBackColor = System.Drawing.Color.White;
            this.PlotValue.DecimalPlaces = 0;
            this.PlotValue.Disable = true;
            this.PlotValue.DisabledAutomaticNumbering = false;
            this.PlotValue.FieldValid = true;
            this.PlotValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PlotValue.Form = null;
            this.PlotValue.FormType = null;
            this.PlotValue.IsDependecyUkey = false;
            this.PlotValue.Location = new System.Drawing.Point(413, 6);
            this.PlotValue.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PlotValue.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PlotValue.Name = "PlotValue";
            this.PlotValue.ObjectControl = null;
            this.PlotValue.ObjetoApp = null;
            this.PlotValue.Others = null;
            this.PlotValue.PropertyControl = null;
            this.PlotValue.PropertyDependecyUkey = null;
            this.PlotValue.Size = new System.Drawing.Size(189, 54);
            this.PlotValue.TabIndex = 3;
            this.PlotValue.TabStop = false;
            this.PlotValue.Text = "sNumeric1";
            this.PlotValue.ThousandsSeparator = false;
            this.PlotValue.ToolTipContext = null;
            this.PlotValue.Validations = null;
            this.PlotValue.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // FInstallmentOfAccountsReceivable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(614, 241);
            this.Name = "FInstallmentOfAccountsReceivable";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox PortionNumber;
        private Core.Component.SDateTimePicker NominalMaturity;
        private Core.Component.SDateTimePicker ActualMaturity;
        private Core.Component.SNumeric PlotValue;
    }
}
