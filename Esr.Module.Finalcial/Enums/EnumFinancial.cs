using System.ComponentModel.DataAnnotations;

namespace Esr.Module.Financial.Enums
{
    public enum Participation
    {
        [Display(Name  = "Receber")]
        ToReceive,
        [Display(Name  = "Pagar")]
        Pay
    }
}