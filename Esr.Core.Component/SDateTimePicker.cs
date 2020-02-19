using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Esr.Core.Component
{
    public class SDateTimePicker : SControl<DateTimePicker>
    {
        public DateTimePickerFormat Format
        {
            get { return SComponent.Format; }
            set { SComponent.Format = value; }
        }

        public string CustomFormat
        {
            get { return SComponent.CustomFormat; }
            set { SComponent.CustomFormat = value; }
        }

        protected override void InitLayout()
        {
            base.InitLayout();
            SComponent.ValueChanged += SComponentOnValueChanged;
            SComponent.GotFocus += SComponentOnGotFocus;
            SComponent.LostFocus += SComponentOnLostFocus;
        }

        private void SComponentOnLostFocus(object sender, EventArgs eventArgs)
        {
            if (SComponent.Checked) return;
            SComponent.ShowCheckBox = false;
            CustomFormat = " ";
            ValueControl = null;
        }

        private void SComponentOnGotFocus(object sender, EventArgs eventArgs)
        {
            if (Format != DateTimePickerFormat.Custom || !string.IsNullOrWhiteSpace(CustomFormat)) return;
            var typeFormat = (GetAttribute<DataTypeAttribute>(PropertyControl));
            if (typeFormat != null)
            {
                Format = DateTimePickerFormat.Custom;
                if (typeFormat.DataType == DataType.Custom)
                    CustomFormat = typeFormat.CustomDataType;
                if (typeFormat.DataType == DataType.Date)
                    CustomFormat = "dd/MM/yyyy";
                if (typeFormat.DataType == DataType.DateTime)
                    CustomFormat = "dd/MM/yyyy HH:mm:ss tt";
                if (typeFormat.DataType == DataType.Time)
                    CustomFormat = "HH:mm:mm";
            }
            else
            {
                Format = DateTimePickerFormat.Short;
            }
            ValueControl = DateTime.Now;
            if (GetAttribute<RequiredAttribute>(PropertyControl) == null)
                SComponent.ShowCheckBox = true;
            SComponent.Checked = true;
        }

        private void SComponentOnValueChanged(object sender, EventArgs eventArgs)
        {
            ValueControl = SComponent.Value;
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
                    SComponent.Value = (DateTime)(base.ValueControl ?? value);
                }
            }
            get { return base.ValueControl ?? SComponent.Value; }
        }

        public override void Refresh()
        {
            if (GetSForm()?.CurrentControl?.Id == 0)
            {
                if (GetAttribute<RequiredAttribute>(PropertyControl) != null)
                {
                    SComponent.Value = DateTime.Now;
                }
                else
                {
                    if (GetAttribute<RequiredAttribute>(PropertyControl) == null)
                        SComponent.Checked = false;
                    ValueControl = null;
                    Format = DateTimePickerFormat.Custom;
                    CustomFormat = " ";
                }
            }

            base.Refresh();
        }

        public override void Clear()
        {
            if (GetAttribute<RequiredAttribute>(PropertyControl) != null)
            {
                SComponent.Value = DateTime.Now;
            }
            else
            {
                SComponent.Checked = false;
                ValueControl = null;
                Format = DateTimePickerFormat.Custom;
                CustomFormat = " ";
            }
        }
    }
}