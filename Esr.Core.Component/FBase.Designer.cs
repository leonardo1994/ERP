using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Esr.Core.Component
{
    partial class FBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected IContainer components = null;

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
            components = new Container();
            statusStrip = new StatusStrip();
            toolStripProgressBar = new ToolStripProgressBar();
            toolStripStatusLabel = new ToolStripStatusLabel();
            eventLog = new EventLog();
            notifyIcon = new NotifyIcon(components);
            bindingSource = new BindingSource(components);
            panel1 = new Panel();
            statusStrip.SuspendLayout();
            ((ISupportInitialize)(eventLog)).BeginInit();
            ((ISupportInitialize)(bindingSource)).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();

            // 
            // statusStrip
            // 
            statusStrip.Font = new Font("Segoe UI", 12F);
            statusStrip.Items.AddRange(new ToolStripItem[] {
            toolStripProgressBar,
            toolStripStatusLabel});
            statusStrip.Location = new Point(0, 369);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(614, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Font = new Font("Segoe UI", 12F);
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(100, 20);
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 21);
            // 
            // eventLog
            // 
            eventLog.SynchronizingObject = this;
            // 
            // notifyIcon
            // 
            notifyIcon.Text = "notifyIcon";
            notifyIcon.Visible = true;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 231);
            panel1.TabIndex = 4;
            //
            // Form
            //
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            KeyPreview = true;
            BackColor = Color.White;
            ClientSize = new Size(614, 395);
            Controls.Add(panel1);
            Controls.Add(statusStrip);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "SForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ESR SOFTWARES";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((ISupportInitialize)(eventLog)).EndInit();
            ((ISupportInitialize)(bindingSource)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public StatusStrip statusStrip;
        public ToolStripProgressBar toolStripProgressBar;
        public EventLog eventLog;
        public NotifyIcon notifyIcon;
        public BindingSource bindingSource;
        public ToolStripStatusLabel toolStripStatusLabel;
        public Panel panel1;
    }
}