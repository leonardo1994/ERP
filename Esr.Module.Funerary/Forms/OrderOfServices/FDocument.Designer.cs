namespace Esr.Module.Funerary.Forms.OrderOfServices
{
    partial class FDocument
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDocument));
            this.Description = new Esr.Core.Component.STextBox();
            this.Archive = new Esr.Core.Component.STextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectedFile = new Esr.Core.Component.SButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SelectedFile);
            this.panel1.Controls.Add(this.Archive);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Size = new System.Drawing.Size(570, 139);
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
            this.Description.Location = new System.Drawing.Point(12, 6);
            this.Description.Name = "Description";
            this.Description.ObjectControl = null;
            this.Description.ObjetoApp = null;
            this.Description.PropertyControl = null;
            this.Description.PropertyDependecyUkey = null;
            this.Description.Size = new System.Drawing.Size(544, 53);
            this.Description.TabIndex = 0;
            this.Description.TabStop = false;
            this.Description.Text = "sTextBox1";
            this.Description.ToolTipContext = null;
            this.Description.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Description.Validations")));
            this.Description.ValueControl = "";
            // 
            // Archive
            // 
            this.Archive.Caption = "";
            this.Archive.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Archive.CenterCaption = false;
            this.Archive.ComponentBackColor = System.Drawing.Color.White;
            this.Archive.Disable = true;
            this.Archive.FieldValid = true;
            this.Archive.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Archive.Form = null;
            this.Archive.FormType = null;
            this.Archive.IsDependecyUkey = false;
            this.Archive.Location = new System.Drawing.Point(12, 65);
            this.Archive.Name = "Archive";
            this.Archive.ObjectControl = null;
            this.Archive.ObjetoApp = null;
            this.Archive.PropertyControl = null;
            this.Archive.PropertyDependecyUkey = null;
            this.Archive.Size = new System.Drawing.Size(351, 53);
            this.Archive.TabIndex = 1;
            this.Archive.TabStop = false;
            this.Archive.Text = "sTextBox2";
            this.Archive.ToolTipContext = null;
            this.Archive.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Archive.Validations")));
            this.Archive.ValueControl = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // SelectedFile
            // 
            this.SelectedFile.BackgroundImage = global::Esr.Module.Funerary.Properties.Resources.folder_file;
            this.SelectedFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectedFile.Caption = "Selecione o Arquivo";
            this.SelectedFile.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.SelectedFile.CenterCaption = false;
            this.SelectedFile.ComponentBackColor = System.Drawing.Color.White;
            this.SelectedFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectedFile.Disable = true;
            this.SelectedFile.FieldValid = true;
            this.SelectedFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SelectedFile.Form = null;
            this.SelectedFile.FormType = null;
            this.SelectedFile.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectedFile.IsDependecyUkey = false;
            this.SelectedFile.Location = new System.Drawing.Point(369, 84);
            this.SelectedFile.Name = "SelectedFile";
            this.SelectedFile.NameFolder = null;
            this.SelectedFile.ObjectControl = null;
            this.SelectedFile.ObjectName = this.Archive;
            this.SelectedFile.ObjetoApp = null;
            this.SelectedFile.OpenFileDialog = true;
            this.SelectedFile.PropertyControl = null;
            this.SelectedFile.PropertyDependecyUkey = null;
            this.SelectedFile.Size = new System.Drawing.Size(187, 34);
            this.SelectedFile.TabIndex = 2;
            this.SelectedFile.TabStop = false;
            this.SelectedFile.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectedFile.ToolTipContext = null;
            this.SelectedFile.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("SelectedFile.Validations")));
            this.SelectedFile.ValueControl = null;
            // 
            // FDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(570, 303);
            this.Name = "FDocument";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox Description;
        private Core.Component.STextBox Archive;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Core.Component.SButton SelectedFile;
    }
}
