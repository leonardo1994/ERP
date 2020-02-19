using System.ComponentModel.DataAnnotations;

namespace Esr.Core.Domain.Queries
{
    public enum TypeFilterComponent : byte
    {
        [Display(Name = "TextBox")]
        TextBox = 0,
        [Display(Name = "ComboBox")]
        ComboBox = 1,
        [Display(Name = "Date")]
        Date = 2,
        [Display(Name = "Time")]
        Time = 3,
        [Display(Name = "DateTime")]
        DateTime = 4,
        [Display(Name = "CheckBox")]
        CheckBox = 5,
        [Display(Name = "Numeric")]
        Numeric = 6
    }
}