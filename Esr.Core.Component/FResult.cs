using System.Collections;
using System.Windows.Forms;

namespace Esr.Core.Component
{
    public partial class FResult : Form
    {
        private object _dataSource;

        public FResult()
        {
            InitializeComponent();
            GridResult.Label.Visible = false;
            GridResult.SMenuComponent.Dock = DockStyle.None;
            GridResult.SMenuComponent.Visible = false;
            GridResult.STextBox.Dock = DockStyle.Top;
            GridResult.STextBox.Width = GridResult.Width;
            GridResult.ScreenSecondary = false;
            GridResult.IsDependecyUkey = false;
            GridResult.IsSearch = true;
            GridResult.SComponent.MouseDoubleClick += SComponent_MouseDoubleClick;
        }

        private void SComponent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Hide();
        }

        /// <summary>
        /// Método para setar uma coleção no grid de resultado.
        /// </summary>
        /// <param name="dataSource"></param>
        public void SetDataSource(object dataSource)
        {
            _dataSource = dataSource;
            GridResult.SComponent.DataSource = _dataSource;
        }
    }
}
