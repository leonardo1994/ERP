using System;
using System.Windows.Forms;

namespace Esr.Core.Component
{
    public class SCheckBox : SControl<CheckBox>
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            var parent = Label.Parent;
            Label.Parent = null;
            SComponent.Parent = null;
            SComponent.AutoSize = true;
            parent.Controls.Add(SComponent);
            parent.Controls.Add(Label);
            SComponent.CheckedChanged += SComponent_CheckedChanged;
        }

        private void SComponent_CheckedChanged(object sender, EventArgs e)
        {
            ValueControl = SComponent.Checked;
        }

        public override object ValueControl
        {
            set
            {
                if (value == null)
                {
                    base.ValueControl = SComponent.Text;
                }
                else
                {
                    base.ValueControl = value;
                    SComponent.Checked = (bool)(base.ValueControl ?? value);
                }
            }
            get { return base.ValueControl ?? SComponent.Checked; }
        }

        public override void Clear()
        {
            ValueControl = false;
            SComponent.Checked = false;
            base.Clear();
        }

        public override void Refresh()
        {
            base.Refresh();
            SComponent.Checked = (bool)ValueControl;
        }
    }
}
