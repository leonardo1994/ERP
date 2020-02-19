using System;
using System.Drawing;

namespace Esr.Core.Component.SAttributes
{
    public class ImageForm : Attribute
    {
        public Image Image { get; }

        public ImageForm(string image)
        {
            Image = Image.FromFile(image);
        }
    }
}
