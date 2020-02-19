using System.Windows.Forms;

namespace Esr.Core.Component
{
    internal class SToolTipText : ToolTip
    {
        /// <summary>
        /// Descrição: Texto que será apresentado no panel, com informações detalhadas do campo em foco.
        /// </summary>
        public string Context { get; set; }

        public SToolTipText()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // 
            // SToolTipText
            // 
            AutomaticDelay = 0;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            IsBalloon = true;
            ToolTipIcon = ToolTipIcon.Info;
        }
    }
}