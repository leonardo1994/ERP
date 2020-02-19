using System;
using System.Linq;
using System.Windows.Forms;

namespace Esr.Core.Component
{
    public class SNumeric : SControl<NumericUpDown>, IConvertible
    {
        protected override void InitLayout()
        {
            base.InitLayout();
            SComponent.TextChanged += SComponentOnTextChanged;
            SComponent.ValueChanged += SComponentOnValueChanged;
            SComponent.GotFocus += SComponentOnGotFocus;
            SComponent.LostFocus += SComponentOnLostFocus;
            Maximum = int.MaxValue;
        }

        private void SComponentOnLostFocus(object sender, EventArgs eventArgs)
        {
            if (SComponent.Text != string.Empty) return;
            SComponent.Value = 0;
            SComponent.Text = @"0,00";
        }

        private void SComponentOnTextChanged(object sender, EventArgs eventArgs)
        {
            var textBox = ((NumericUpDown)sender);
            if (textBox.Text != string.Empty) return;
            textBox.Value = 0;
            textBox.Text = string.Empty;
        }

        private void SComponentOnGotFocus(object sender, EventArgs eventArgs)
        {
            var value = ((NumericUpDown)sender).Value;
            if (value == 0)
            {
                SComponent.Text = "";
            }

        }

        public int DecimalPlaces
        {
            get { return SComponent.DecimalPlaces; }
            set { SComponent.DecimalPlaces = value; }
        }

        public decimal Maximum
        {
            get { return SComponent.Maximum; }
            set { SComponent.Maximum = value; }
        }

        public decimal Minimum
        {
            get { return SComponent.Minimum; }
            set { SComponent.Minimum = value; }
        }

        public bool ThousandsSeparator
        {
            get { return SComponent.ThousandsSeparator; }
            set { SComponent.ThousandsSeparator = value; }
        }

        private void SComponentOnValueChanged(object sender, EventArgs eventArgs)
        {
            ValueControl = SComponent.Value;

            if (ObjetoApp != null)
            {
                var method = ObjetoApp.Methods.FirstOrDefault(d => d.Key == TypeExecute.Search).Value;
                ObjectControl = new SReflection().FindIdContext(ObjetoApp.TypeController, method, ValueControl);
                ValueControl = null;
            }
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
                    var changeType = Convert.ChangeType((base.ValueControl ?? value), TypeCode.Decimal);
                    if (changeType != null)
                        SComponent.Value = (decimal)changeType;
                }
            }
            get { return base.ValueControl ?? SComponent.Value; }
        }

        public override void Refresh()
        {
            base.Refresh();

            try
            {
                SComponent.Value = (decimal)ValueControl;
            }
            catch (InvalidCastException)
            {
                var changeType = Convert.ChangeType(base.ValueControl, TypeCode.Decimal);
                if (changeType != null)
                    SComponent.Value = (decimal)changeType;
            }
        }

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }
    }
}
