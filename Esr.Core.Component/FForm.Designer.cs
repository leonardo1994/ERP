using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Esr.Core.Component
{
    partial class FForm
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuHost = new System.Windows.Forms.Integration.ElementHost();
            this._sMenu = new SMenu();
            // 
            // MenuHost
            // 
            this.MenuHost.AutoSize = true;
            this.MenuHost.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuHost.Location = new System.Drawing.Point(0, 0);
            this.MenuHost.Name = "MenuHost";
            this.MenuHost.Size = new System.Drawing.Size(614, 138);
            this.MenuHost.TabIndex = 3;
            this.MenuHost.Text = "Menu";
            MenuHost.Child = this._sMenu;

            this.Controls.Add(MenuHost);
        }

        #endregion
        private System.Windows.Forms.Integration.ElementHost MenuHost;
        private SMenu _sMenu;
    }
}