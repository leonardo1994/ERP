namespace Esr.Module.ControlPainel.Forms
{
    partial class FTable
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableName = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TableName);
            this.panel1.Size = new System.Drawing.Size(459, 70);
            // 
            // TableName
            // 
            this.TableName.Caption = "";
            this.TableName.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.TableName.CenterCaption = false;
            this.TableName.ComponentBackColor = System.Drawing.Color.White;
            this.TableName.Disable = true;
            this.TableName.FieldValid = true;
            this.TableName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TableName.Form = null;
            this.TableName.FormType = null;
            this.TableName.IsDependecyUkey = false;
            this.TableName.Location = new System.Drawing.Point(12, 6);
            this.TableName.Name = "TableName";
            this.TableName.ObjectControl = null;
            this.TableName.ObjetoApp = null;
            this.TableName.PropertyControl = null;
            this.TableName.PropertyDependecyUkey = null;
            this.TableName.Size = new System.Drawing.Size(435, 56);
            this.TableName.TabIndex = 0;
            this.TableName.TabStop = false;
            this.TableName.Text = "sTextBox1";
            this.TableName.ToolTipContext = null;
            this.TableName.Validations = null;
            this.TableName.ValueControl = "";
            // 
            // FTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(459, 234);
            this.Name = "FTable";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Core.Component.STextBox TableName;
    }
}
