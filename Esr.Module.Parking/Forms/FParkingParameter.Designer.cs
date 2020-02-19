namespace Esr.Module.Parking.Forms
{
    partial class FParkingParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FParkingParameter));
            this.GridParameter = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GridParameter);
            this.panel1.Size = new System.Drawing.Size(976, 383);
            // 
            // GridParameter
            // 
            this.GridParameter.ButtonAction = Esr.Core.Component.ButtonAction.None;
            this.GridParameter.Caption = "";
            this.GridParameter.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.GridParameter.CenterCaption = false;
            this.GridParameter.ComponentBackColor = System.Drawing.Color.White;
            this.GridParameter.Disable = true;
            this.GridParameter.DisabledAutomaticNumbering = false;
            this.GridParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridParameter.FieldValid = true;
            this.GridParameter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GridParameter.Form = null;
            this.GridParameter.FormType = null;
            this.GridParameter.IsDependecyUkey = false;
            this.GridParameter.IsSearch = false;
            this.GridParameter.ListColunas = null;
            this.GridParameter.Location = new System.Drawing.Point(0, 0);
            this.GridParameter.Name = "GridParameter";
            this.GridParameter.ObjectControl = null;
            this.GridParameter.ObjetoApp = null;
            this.GridParameter.Others = null;
            this.GridParameter.PropertyControl = null;
            this.GridParameter.PropertyDependecyUkey = null;
            this.GridParameter.PropertyInfos = null;
            this.GridParameter.ScreenSecondary = false;
            this.GridParameter.Size = new System.Drawing.Size(976, 383);
            this.GridParameter.TabIndex = 0;
            this.GridParameter.TabStop = false;
            this.GridParameter.Text = "sGrid1";
            this.GridParameter.ToolTipContext = null;
            this.GridParameter.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("GridParameter.Validations")));
            this.GridParameter.ValueControl = null;
            // 
            // FParkingParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(976, 409);
            this.Name = "FParkingParameter";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SGrid GridParameter;
    }
}
