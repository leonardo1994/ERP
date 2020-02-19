using System;
using System.ComponentModel;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esr.Module.InitialRegistration.Domain.StockItems
{
    [DisplayName(@"Conversão de Unidade de Medida")]
    [Table("UnitMeasureConversion")]
    public class UnitMeasureConversion : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        /// <summary>
        /// ID da unidade de medida principal
        /// </summary>
        public int FirstUnitMeasureId { get; set; }
        public virtual UnitMeasure FirstUnitMeasure { get; set; }

        /// <summary>
        /// ID da Unidade de Medida para conversão
        /// </summary>
        [DisplayName("Unidade de Medida")]
        public int SecondUnitMeasureId { get; set; }
        public virtual UnitMeasure SecondUnitMeasure { get; set; }

        /// <summary>
        /// ID do item de estoque, para conversão específica.
        /// </summary>
        [DisplayName("Item de Estoque")]
        public int? StockItemId { get; set; }
        public virtual StockItem StockItem { get; set; }

        /// <summary>
        /// ID da Familia de Estoque, para conversão específica.
        /// </summary>
        [DisplayName("Familia")]
        public int? FamilyId { get; set; }
        public virtual Family Family { get; set; }

        /// <summary>
        /// Tipo de operação matemática.
        /// </summary>
        [DisplayName("Tipo de Operação")]
        public int TypeOperationId { get { return (int)TypeOperation; } set { TypeOperation = (TypeOperation)value; } }

        /// <summary>
        /// Tipo de operação matemática.
        /// </summary>
        [DisplayName("Tipo de Operação")]
        public TypeOperation TypeOperation { get; set; }

        /// <summary>
        /// Fator de conversão.
        /// </summary>
        public decimal ConversionFactor { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }
    }
}