namespace Esr.Module.InitialRegistration.Forms.StockItems
{
    partial class FUnitMeasure
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUnitMeasure));
            this.Description = new Esr.Core.Component.STextBox();
            this.Initials = new Esr.Core.Component.STextBox();
            this.UnitMeasureConversions = new Esr.Core.Component.SGrid();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UnitMeasureConversions);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.Initials);
            this.panel1.Size = new System.Drawing.Size(522, 285);
            // 
            // Description
            // 
            this.Description.Caption = "";
            this.Description.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Description.CenterCaption = false;
            this.Description.ComponentBackColor = System.Drawing.Color.White;
            this.Description.Disable = true;
            this.Description.DisabledAutomaticNumbering = false;
            this.Description.FieldValid = true;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Description.Form = null;
            this.Description.FormType = null;
            this.Description.IsDependecyUkey = false;
            this.Description.Location = new System.Drawing.Point(167, 6);
            this.Description.Name = "Description";
            this.Description.ObjectControl = null;
            this.Description.ObjetoApp = null;
            this.Description.Others = null;
            this.Description.PropertyControl = null;
            this.Description.PropertyDependecyUkey = null;
            this.Description.Size = new System.Drawing.Size(344, 54);
            this.Description.TabIndex = 1;
            this.Description.TabStop = false;
            this.Description.Text = "sTextBox2";
            this.Description.ToolTipContext = null;
            this.Description.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Description.Validations")));
            this.Description.ValueControl = "";
            // 
            // Initials
            // 
            this.Initials.Caption = "";
            this.Initials.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Initials.CenterCaption = false;
            this.Initials.ComponentBackColor = System.Drawing.Color.White;
            this.Initials.Disable = true;
            this.Initials.DisabledAutomaticNumbering = false;
            this.Initials.FieldValid = true;
            this.Initials.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Initials.Form = null;
            this.Initials.FormType = null;
            this.Initials.IsDependecyUkey = false;
            this.Initials.Location = new System.Drawing.Point(12, 6);
            this.Initials.Name = "Initials";
            this.Initials.ObjectControl = null;
            this.Initials.ObjetoApp = null;
            this.Initials.Others = null;
            this.Initials.PropertyControl = null;
            this.Initials.PropertyDependecyUkey = null;
            this.Initials.Size = new System.Drawing.Size(149, 54);
            this.Initials.TabIndex = 0;
            this.Initials.TabStop = false;
            this.Initials.ToolTipContext = null;
            this.Initials.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Initials.Validations")));
            this.Initials.ValueControl = "";
            // 
            // UnitMeasureConversions
            // 
            this.UnitMeasureConversions.ButtonAction = Esr.Core.Component.ButtonAction.None;
            this.UnitMeasureConversions.Caption = "";
            this.UnitMeasureConversions.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.UnitMeasureConversions.CenterCaption = false;
            this.UnitMeasureConversions.ComponentBackColor = System.Drawing.Color.White;
            this.UnitMeasureConversions.Disable = true;
            this.UnitMeasureConversions.DisabledAutomaticNumbering = false;
            this.UnitMeasureConversions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UnitMeasureConversions.FieldValid = true;
            this.UnitMeasureConversions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UnitMeasureConversions.Form = null;
            this.UnitMeasureConversions.FormType = null;
            this.UnitMeasureConversions.IsDependecyUkey = false;
            this.UnitMeasureConversions.IsSearch = false;
            this.UnitMeasureConversions.ListColunas = null;
            this.UnitMeasureConversions.Location = new System.Drawing.Point(0, 66);
            this.UnitMeasureConversions.Name = "UnitMeasureConversions";
            this.UnitMeasureConversions.ObjectControl = null;
            this.UnitMeasureConversions.ObjetoApp = null;
            this.UnitMeasureConversions.Others = null;
            this.UnitMeasureConversions.PropertyControl = null;
            this.UnitMeasureConversions.PropertyDependecyUkey = null;
            this.UnitMeasureConversions.PropertyInfos = null;
            this.UnitMeasureConversions.ScreenSecondary = false;
            this.UnitMeasureConversions.Size = new System.Drawing.Size(522, 219);
            this.UnitMeasureConversions.TabIndex = 2;
            this.UnitMeasureConversions.TabStop = false;
            this.UnitMeasureConversions.Text = "sGrid1";
            this.UnitMeasureConversions.ToolTipContext = null;
            this.UnitMeasureConversions.Validations = null;
            this.UnitMeasureConversions.ValueControl = null;
            // 
            // FUnitMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(522, 449);
            this.Name = "FUnitMeasure";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox Description;
        private Core.Component.STextBox Initials;
        private Core.Component.SGrid UnitMeasureConversions;
    }
}
