using System.Drawing;
using System.Windows.Forms;
using Esr.Core.Component.Properties;

namespace Esr.Core.Component
{
    public class SMenuComponent : MenuStrip
    {
        /// <summary>
        /// Itens padões do menu dos componentes.
        /// </summary>
        public ToolStripMenuItem MenuItemSearch;
        public ToolStripMenuItem MenuItemNew;
        public ToolStripMenuItem MenuItemEdit;
        public ToolStripMenuItem MenuItemRemove;
        public ToolStripMenuItem MenuItemReports;
        public ToolStripMenuItem MenuItemUpdates;

        public SMenuComponent()
        {
            LoadMenu();
            LoadMenuItem();
            MenuHorizontal();
        }

        private void LoadMenu()
        {
            Stretch = true;
            Visible = true;
            Dock = DockStyle.None;
            BackColor = Color.DimGray;
        }

        /// <summary>
        /// Instancia os objetos do menu.
        /// </summary>
        private void LoadMenuItem()
        {
            MenuItemSearch = new ToolStripMenuItem()
            {
                Image = Resources.icon_folder_search,
                ImageScaling = ToolStripItemImageScaling.None,
                ImageAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Width = 45,
                Height = 45,
                ToolTipText = @"Visualizar"
            };

            MenuItemNew = new ToolStripMenuItem()
            {
                Image = Resources.icon_folder_new,
                ImageScaling = ToolStripItemImageScaling.None,
                ImageAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Width = 45,
                Height = 45,
                ToolTipText = @"Adicionar"
            };

            MenuItemEdit = new ToolStripMenuItem()
            {
                Image = Resources.icon_folder_edit,
                ImageScaling = ToolStripItemImageScaling.None,
                ImageAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Width = 45,
                Height = 45,
                ToolTipText = @"Alterar"
            };

            MenuItemRemove = new ToolStripMenuItem()
            {
                Image = Resources.icon_folder_remove,
                ImageScaling = ToolStripItemImageScaling.None,
                ImageAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Width = 45,
                Height = 45,
                ToolTipText = @"Excluir"
            };

            MenuItemReports = new ToolStripMenuItem()
            {
                Image = Resources.icon_folder_printer_fw,
                ImageScaling = ToolStripItemImageScaling.None,
                ImageAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Width = 45,
                Height = 45,
                ToolTipText = @"Relatórios"
            };

            MenuItemUpdates = new ToolStripMenuItem()
            {
                Image = Resources.icon_folder_updates_fw,
                ImageScaling = ToolStripItemImageScaling.None,
                ImageAlign = ContentAlignment.MiddleCenter,
                AutoSize = false,
                Width = 45,
                Height = 45,
                ToolTipText = @"Atualiza"
            };
        }

        /// <summary>
        /// Método para criação do menu, correspondente dos controles.
        /// Posicionamento Horizontal.
        /// </summary>
        private void MenuHorizontal()
        {
            Items.AddRange(new ToolStripItem[]
            {
                MenuItemSearch,
                MenuItemNew,
                MenuItemEdit,
                MenuItemRemove,
                MenuItemReports,
                MenuItemUpdates
            });
            AutoSize = true;
        }
    }
}
