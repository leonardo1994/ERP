namespace Esr.Module.Parking.Forms
{
    partial class FParkingTableOfPrice
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Code = new Esr.Core.Component.STextBox();
            this.Description = new Esr.Core.Component.STextBox();
            this.ParkingItemsTableOfPrice = new Esr.Core.Component.SGrid();
            this.Situation = new Esr.Core.Component.SComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Situation);
            this.panel1.Controls.Add(this.ParkingItemsTableOfPrice);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.Code);
            this.panel1.Size = new System.Drawing.Size(792, 319);
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
            this.Code.Location = new System.Drawing.Point(12, 7);
            this.Code.Name = "Code";
            this.Code.ObjectControl = null;
            this.Code.ObjetoApp = null;
            this.Code.Others = null;
            this.Code.PropertyControl = null;
            this.Code.PropertyDependecyUkey = null;
            this.Code.Size = new System.Drawing.Size(168, 53);
            this.Code.TabIndex = 0;
            this.Code.TabStop = false;
            this.Code.Text = "sTextBox1";
            this.Code.ToolTipContext = null;
            this.Code.Validations = null;
            this.Code.ValueControl = "";
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.Caption = "";
            this.Description.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Description.CenterCaption = false;
            this.Description.ComponentBackColor = System.Drawing.Color.White;
            this.Description.Disable = true;
            this.Description.FieldValid = true;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Description.Form = null;
            this.Description.FormType = null;
            this.Description.IsDependecyUkey = false;
            this.Description.Location = new System.Drawing.Point(186, 7);
            this.Description.Name = "Description";
            this.Description.ObjectControl = null;
            this.Description.ObjetoApp = null;
            this.Description.Others = null;
            this.Description.PropertyControl = null;
            this.Description.PropertyDependecyUkey = null;
            this.Description.Size = new System.Drawing.Size(411, 53);
            this.Description.TabIndex = 1;
            this.Description.TabStop = false;
            this.Description.Text = "sTextBox2";
            this.Description.ToolTipContext = null;
            this.Description.Validations = null;
            this.Description.ValueControl = "";
            // 
            // ParkingItemsTableOfPrice
            // 
            this.ParkingItemsTableOfPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParkingItemsTableOfPrice.ButtonAction = Esr.Core.Component.ButtonAction.None;
            this.ParkingItemsTableOfPrice.Caption = "";
            this.ParkingItemsTableOfPrice.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ParkingItemsTableOfPrice.CenterCaption = false;
            this.ParkingItemsTableOfPrice.ComponentBackColor = System.Drawing.Color.White;
            this.ParkingItemsTableOfPrice.Disable = true;
            this.ParkingItemsTableOfPrice.FieldValid = true;
            this.ParkingItemsTableOfPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ParkingItemsTableOfPrice.Form = null;
            this.ParkingItemsTableOfPrice.FormType = null;
            this.ParkingItemsTableOfPrice.IsDependecyUkey = false;
            this.ParkingItemsTableOfPrice.IsSearch = false;
            this.ParkingItemsTableOfPrice.ListColunas = null;
            this.ParkingItemsTableOfPrice.Location = new System.Drawing.Point(0, 70);
            this.ParkingItemsTableOfPrice.Name = "ParkingItemsTableOfPrice";
            this.ParkingItemsTableOfPrice.ObjectControl = null;
            this.ParkingItemsTableOfPrice.ObjetoApp = null;
            this.ParkingItemsTableOfPrice.Others = null;
            this.ParkingItemsTableOfPrice.PropertyControl = null;
            this.ParkingItemsTableOfPrice.PropertyDependecyUkey = null;
            this.ParkingItemsTableOfPrice.PropertyInfos = null;
            this.ParkingItemsTableOfPrice.ScreenSecondary = false;
            this.ParkingItemsTableOfPrice.Size = new System.Drawing.Size(789, 246);
            this.ParkingItemsTableOfPrice.TabIndex = 2;
            this.ParkingItemsTableOfPrice.TabStop = false;
            this.ParkingItemsTableOfPrice.Text = "sGrid1";
            this.ParkingItemsTableOfPrice.ToolTipContext = null;
            this.ParkingItemsTableOfPrice.Validations = null;
            this.ParkingItemsTableOfPrice.ValueControl = null;
            // 
            // Situation
            // 
            this.Situation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Situation.Caption = "";
            this.Situation.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Situation.CenterCaption = false;
            this.Situation.ComboBoxMultiForms = null;
            this.Situation.ComponentBackColor = System.Drawing.Color.White;
            this.Situation.DefaultValue = false;
            this.Situation.Disable = true;
            this.Situation.DisplayMember = "";
            this.Situation.FieldValid = true;
            this.Situation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Situation.Form = null;
            this.Situation.FormType = null;
            this.Situation.IsDependecyUkey = false;
            this.Situation.Location = new System.Drawing.Point(603, 7);
            this.Situation.Name = "Situation";
            this.Situation.ObjectControl = null;
            this.Situation.ObjetoApp = null;
            this.Situation.Others = null;
            this.Situation.PropertyControl = null;
            this.Situation.PropertyDependecyUkey = null;
            this.Situation.Size = new System.Drawing.Size(184, 53);
            this.Situation.StandardValue = null;
            this.Situation.TabIndex = 3;
            this.Situation.TabStop = false;
            this.Situation.Text = "sComboBox1";
            this.Situation.ToolTipContext = null;
            this.Situation.Validations = null;
            this.Situation.ValueControl = null;
            this.Situation.ValueMember = "";
            // 
            // FParkingTableOfPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 483);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FParkingTableOfPrice";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SGrid ParkingItemsTableOfPrice;
        private Core.Component.STextBox Description;
        private Core.Component.STextBox Code;
        private Core.Component.SComboBox Situation;
    }
}