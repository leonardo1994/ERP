using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Esr.Core.Component
{
    public class SRichText : SControl<CustomRichText>
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            SComponent.Multiline = true;
            SComponent.LostFocus += SComponent_LostFocus;
            SComponent.TextChanged += SComponent_TextChanged;
        }

        private void SComponent_TextChanged(object sender, EventArgs e)
        {
            var currentPosition = SComponent.SelectionStart;
            ValueControl = SComponent.Text;
            SComponent.SelectionStart = currentPosition;
        }

        private void SComponent_LostFocus(object sender, EventArgs e)
        {
            ValueControl = SComponent.Text;
            SComponent.SelectionStart = ValueControl.ToString().Length;
        }

        public override object ValueControl
        {
            set
            {
                if (value == null)
                {
                    base.ValueControl = null;
                }
                else
                {
                    base.ValueControl = value;
                    SComponent.Text = (string)(base.ValueControl ?? value);
                }
            }
            get { return base.ValueControl ?? SComponent.Text; }
        }

        public override void Refresh()
        {
            base.Refresh();
            SComponent.Text = (string)ValueControl;
        }
    }

    public class CustomRichText : RichTextBox
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                SelectionLength = 0;
                SelectedText = new string(' ', 4);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
