using Esr.Core.Domain.ClassBase;

namespace Esr.Core.Component
{
    partial class FormVisualisador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualisador));
            this.visualizadorReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // visualizadorReportViewer
            // 
            this.visualizadorReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualizadorReportViewer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizadorReportViewer.Location = new System.Drawing.Point(0, 0);
            this.visualizadorReportViewer.Name = "visualizadorReportViewer";
            this.visualizadorReportViewer.Size = new System.Drawing.Size(403, 249);
            this.visualizadorReportViewer.TabIndex = 0;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Esr.Core.Domain.ClassBase.IEntityBase);
            // 
            // FormVisualisador
            // 
            this.ClientSize = new System.Drawing.Size(403, 249);
            this.Controls.Add(this.visualizadorReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVisualisador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVisualisador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer visualizadorReportViewer;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}