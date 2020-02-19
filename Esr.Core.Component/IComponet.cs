using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace Esr.Core.Component
{
    public interface IComponent
    {
        bool IsDependecyUkey { get; set; }
        bool Visible { get; set; }
        Point Location { get; set; }
        string Name { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        string Text { get; set; }
        int Index { get; }
        object ValueControl { get; set; }
        Color ComponentBackColor { get; set; }
        object Others { get; set; }
        bool DisabledAutomaticNumbering { get; set; }

        Dictionary<string, bool> Validations { get; set; }
        PropertyInfo PropertyControl { get; set; }
        object ObjectControl { get; set; }
        bool FieldValid { get; set; } 

        string Caption { get; set; }
        CaptionAlign CaptionAlign { get; set; }
        bool CenterCaption { get; set; }
        string ToolTipContext { get; set; }
        bool Disable { get; set; }

        void Clear();
        void RemoveErrorProvider();
        void SetFocus();
        void Refresh();
        void SetError(string message, int padding = 0);
    }
}
