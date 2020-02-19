using System.ComponentModel.DataAnnotations;

namespace Esr.Core.Domain.Queries
{
    public enum TypeFilter : byte
    {
        [Display( Name = @"Igual [=]")]
        Equal = 0,
        [Display(Name = @"Diferente [<>]")]
        Different = 1,
        [Display(Name = @"Menor [<]")]
        Smaller = 2,
        [Display(Name = @"Maior [>]")]
        Larger = 3,
        [Display(Name = @"Menor e Igual [<=]")]
        SmallerAndEqual = 4,
        [Display(Name = @"Maior e Igual [>=]")]
        LargerAndEqual = 5,
        [Display(Name = @"Contém")]
        Contains = 6,
        [Display(Name = @"Está contido ['1', ...]")]
        In = 7,
        [Display(Name = @"Iniciado por")]
        InitiatedBy = 8,
        [Display(Name = @"Terminado por")]
        FinalizedBy = 9,
        [Display(Name = @"Entre")]
        Between = 10
    }
}
