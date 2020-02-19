using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Windows.Forms;

namespace Esr.Core.Component
{
    public class STextBox : SControl<TextBox>
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            SComponent.TextChanged += SComponent_TextChanged;
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

        private void SComponent_TextChanged(object sender, EventArgs e)
        {
            ValueControl = SComponent.Text;
        }

        protected override string DisplayName(PropertyInfo propertyInfo)
        {
            try
            {
                if (propertyInfo != null)
                    if (GetAttribute<DataTypeAttribute>(propertyInfo).DataType == DataType.Password)
                        SComponent.UseSystemPasswordChar = true;
            }
            catch (Exception)
            {
                //
            }

            return base.DisplayName(propertyInfo);
        }

        public override void Refresh()
        {
            base.Refresh();
            SComponent.Text = (string)ValueControl;
        }

        public override void Clear()
        {
            base.Clear();
            ValueControl = "";
        }
    }
}