using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.ValueObject;

namespace Esr.Core.Component
{
    public class SMasckEdit : SControl<MaskedTextBox>
    {
        public SMasckEdit()
        {
            SComponent.TextChanged += SComponent_TextChanged;
        }

        public string Mask
        {
            get { return SComponent.Mask; }
            set { SComponent.Mask = value; }
        }

        public override object ValueControl
        {
            set
            {
                if (Mask == string.Empty)
                {
                    if (GetAttribute<CnpjValidator>(PropertyControl) != null)
                    {
                        Mask = "99,999,999/9999-99";
                    }
                    if (GetAttribute<CpfValidator>(PropertyControl) != null)
                    {
                        Mask = "999,999,999-99";
                    }
                }
                if (value == null)
                {
                    SComponent.Clear();
                    base.ValueControl = null;
                    return;
                }
                base.ValueControl = value;
                SComponent.Text = (string) base.ValueControl;
            }
            get { return base.ValueControl ?? SComponent.Text; }
        }

        private void SComponent_TextChanged(object sender, EventArgs e)
        {
            SComponent.MaxLength = Mask.Length;
            ValueControl = ((Control)sender).Text;
        }
    }
}