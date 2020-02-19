using System.Windows.Forms;

namespace Esr.Main
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            menu1.Tag = this;
        }
    }
}