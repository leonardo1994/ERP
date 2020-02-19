using System.Drawing;
using System.Windows.Forms;

namespace Esr.Core.Component
{
    public class SLabel : Label
    {
        public override bool AutoSize { get; set; } = true;
        public override Color BackColor { get; set; } = Color.Transparent;
        public override Font Font { get; set; } = new Font("Segoe UI", 12);
    }
}