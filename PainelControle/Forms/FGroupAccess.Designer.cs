namespace Esr.Module.ControlPainel.Forms
{
    partial class FGroupAccess
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGroupAccess));
            this.GroupPermissions = new Esr.Core.Component.SGrid();
            this.Description = new Esr.Core.Component.STextBox();
            this.Title = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GroupPermissions);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Size = new System.Drawing.Size(668, 321);
            // 
            // GroupPermissions
            // 
            this.GroupPermissions.ButtonAction = Esr.Core.Component.ButtonAction.Insert;
            this.GroupPermissions.Caption = "";
            this.GroupPermissions.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.GroupPermissions.CenterCaption = false;
            this.GroupPermissions.ComponentBackColor = System.Drawing.Color.White;
            this.GroupPermissions.Disable = true;
            this.GroupPermissions.FieldValid = true;
            this.GroupPermissions.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GroupPermissions.Form = null;
            this.GroupPermissions.FormType = null;
            this.GroupPermissions.IsDependecyUkey = false;
            this.GroupPermissions.IsSearch = false;
            this.GroupPermissions.ListColunas = null;
            this.GroupPermissions.Location = new System.Drawing.Point(9, 75);
            this.GroupPermissions.Name = "GroupPermissions";
            this.GroupPermissions.ObjectControl = null;
            this.GroupPermissions.ObjetoApp = null;
            this.GroupPermissions.PropertyControl = null;
            this.GroupPermissions.PropertyDependecyUkey = null;
            this.GroupPermissions.PropertyInfos = null;
            this.GroupPermissions.ScreenSecondary = false;
            this.GroupPermissions.Size = new System.Drawing.Size(647, 237);
            this.GroupPermissions.TabIndex = 2;
            this.GroupPermissions.TabStop = false;
            this.GroupPermissions.ToolTipContext = null;
            this.GroupPermissions.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("GroupPermissions.Validations")));
            this.GroupPermissions.ValueControl = null;
            // 
            // Description
            // 
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
            this.Description.Location = new System.Drawing.Point(281, 16);
            this.Description.Name = "Description";
            this.Description.ObjectControl = null;
            this.Description.ObjetoApp = null;
            this.Description.PropertyControl = null;
            this.Description.PropertyDependecyUkey = null;
            this.Description.Size = new System.Drawing.Size(375, 53);
            this.Description.TabIndex = 1;
            this.Description.TabStop = false;
            this.Description.ToolTipContext = null;
            this.Description.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Description.Validations")));
            this.Description.ValueControl = "";
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
            this.Title.Location = new System.Drawing.Point(9, 16);
            this.Title.Name = "Title";
            this.Title.ObjectControl = null;
            this.Title.ObjetoApp = null;
            this.Title.PropertyControl = null;
            this.Title.PropertyDependecyUkey = null;
            this.Title.Size = new System.Drawing.Size(266, 53);
            this.Title.TabIndex = 0;
            this.Title.TabStop = false;
            this.Title.ToolTipContext = null;
            this.Title.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Title.Validations")));
            this.Title.ValueControl = "";
            // 
            // FGroupAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 485);
            this.Name = "FGroupAccess";
            this.Text = "FGroupAccess";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.SGrid GroupPermissions;
        private Core.Component.STextBox Description;
        private Core.Component.STextBox Title;
    }
}