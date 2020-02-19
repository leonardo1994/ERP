using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;

namespace Esr.Module.InitialRegistration.Domain.StockItems
{
    [DisplayName(@"Item de Estoque")]
    public class StockItem : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        /// <summary>
        /// Código
        /// </summary>
        [DisplayName(@"Código"), Required, Unique]
        public string Code { get; set; }

        /// <summary>
        /// Código secundário
        /// </summary>
        [DisplayName(@"Código Secundário"), Required, Unique]
        public string SecundaryCode { get; set; }

        /// <summary>
        /// Descrição do item de estoque
        /// </summary>
        [DisplayName(@"Descrição"), Required]
        public string Description { get; set; }

        /// <summary>
        /// ID da situação
        /// </summary>
        [Required]
        public virtual int SituationId { get { return (int)Situation; } set { Situation = (Situation)value; } }

        /// <summary>
        /// Situação
        /// </summary>
        [DisplayName(@"Situação")]
        public Situation Situation { get; set; }

        /// <summary>
        /// Unidade de medida
        /// </summary>
        [DisplayName(@"Unidade de Medida"), Required]
        public int UnitMeasureId { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }

        [Required]
        public virtual int OriginItemId { get { return (int)OriginItem; } set { OriginItem = (OriginItem)value; } }

        /// <summary>
        /// Origem do item
        /// </summary>
        [DisplayName(@"Origem"), Required]
        public OriginItem OriginItem { get; set; }

        public virtual int MerchandiseUseId { get { return (int)MerchandiseUse; } set { MerchandiseUse = (MerchandiseUse)value; } }

        /// <summary>
        /// Uso da mercadoria
        /// </summary>
        [DisplayName(@"Uso da mercadoria"), Required]
        public MerchandiseUse MerchandiseUse { get; set; }

        /// <summary>
        /// Familia
        /// </summary>
        [DisplayName(@"Familia")]
        public int? FamilyId { get; set; }
        public virtual Family Family { get; set; }

        /// <summary>
        /// NCM
        /// </summary>
        [DisplayName(@"Código NCM")]
        public int? NcmId { get; set; }
        public virtual Ncm Ncm { get; set; }

        /// <summary>
        /// Destaque da NCM
        /// </summary>
        [DisplayName(@"Destaque da NCM"), DependencyKey("NcmId")]
        public int? FeaturedNcmId { get; set; }
        public virtual FeaturedNcm FeaturedNcm { get; set; }

        /// <summary>
        /// Avalia disponibilidade
        /// </summary>
        [DisplayName(@"Avalia disponibilidade")]
        public bool EvaluateAvailability { get; set; }

        /// <summary>
        /// Permite movimentação sem disponibilidade
        /// </summary>
        [DisplayName(@"Permite movimentação sem disponibilidade")]
        public bool AllowsUnavaliableMovement { get; set; }

        /// <summary>
        /// Não permite saldo físico negativo
        /// </summary>
        [DisplayName(@"Não permite saldo físico negativo")]
        public bool NotNegativeBalance { get; set; }

        /// <summary>
        /// Tipo de Valor de Comission
        /// </summary>
        public virtual int TypeValueCommissionId { get { return (int)TypeValueCommission; } set { TypeValueCommission = (TypeValue)value; } }

        /// <summary>
        /// Tipo de Valor de Comission
        /// </summary>
        public TypeValue TypeValueCommission { get; set; }

        /// <summary>
        /// Valor de comissão
        /// </summary>
        [DisplayName(@"Comissão"), Range(0.00, double.MaxValue)]
        public decimal Commission { get; set; }

        /// <summary>
        /// Custo
        /// </summary>
        [DisplayName(@"Custo")]
        public decimal Cost { get; set; }

        /// <summary>
        /// Valor Mínimo
        /// </summary>
        [DisplayName(@"Valor minímo"), Range(0.00, double.MaxValue)]
        public decimal MinimumValue { get; set; }

        /// <summary>
        /// Tipo de valor do lucro
        /// </summary>
        public virtual int TypeValueProfitId { get { return (int)TypeValueProfit; } set { TypeValueProfit = (TypeValue)value; } }

        /// <summary>
        /// Tipo de valor do lucro
        /// </summary>
        public TypeValue TypeValueProfit { get; set; }

        /// <summary>
        /// Valor de Lucro
        /// </summary>
        [DisplayName(@"Lucro"), Range(0.00, double.MaxValue)]
        public decimal Profit { get; set; }

        /// <summary>
        /// Valor de Venda.
        /// </summary>
        [DisplayName(@"Valor de venda"), Range(0.00, double.MaxValue)]
        public decimal ValueSale { get; set; }

        /// <summary>
        /// Quantidade Mínima
        /// </summary>
        [DisplayName(@"Quantidade Mínima"), Range(0.00, double.MaxValue)]
        public decimal MinimumQuantity { get; set; }

        /// <summary>
        /// Quantidade Máxima
        /// </summary>
        [DisplayName(@"Quantidade Maxima"), Range(0.00, double.MaxValue)]
        public decimal MaximumQuantity { get; set; }

        /// <summary>
        /// Ressuprimento
        /// </summary>
        [DisplayName(@"Ressuprimento"), Range(0.00, double.MaxValue)]
        public decimal Ressuply { get; set; }

        /// <summary>
        /// Peso Líquido
        /// </summary>
        [DisplayName(@"Peso líquido"), Range(0.00, double.MaxValue)]
        public decimal NetHeight { get; set; }

        /// <summary>
        /// Peso Bruto
        /// </summary>
        [DisplayName(@"Peso Bruto"), Range(0.00, double.MaxValue)]
        public decimal GrossWeigth { get; set; }

        /// <summary>
        /// Tipo de Data de Validade
        /// </summary>
        public virtual int ValidityTypeId { get { return (int)ValidityType; } set { ValidityType = (ValidityType)value; } }

        /// <summary>
        /// Tipo de Data de Validade
        /// </summary>
        public ValidityType ValidityType { get; set; }

        /// <summary>
        /// Quantidade em Validade
        /// </summary>
        [DisplayName(@"Validade"), Range(0, double.MaxValue)]
        public decimal QuantityValidity { get; set; }

        /// <summary>
        /// Caminho da imagem do item
        /// </summary>
        [DisplayName(@"Imagem")]
        public string Image { get; set; }

        /// <summary>
        /// Marca
        /// </summary>
        [DisplayName(@"Marca")]
        public int? MarkId { get; set; }
        public virtual Mark Mark { get; set; }

        /// <summary>
        /// Modelo
        /// </summary>
        [DisplayName(@"Modelo")]
        public int? ModelId { get; set; }
        public virtual Model Model { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public bool Integration { get; set; }

        public virtual ICollection<SpecialTax> SpecialTaxs { get; set; }
        public virtual ICollection<Composition> Compositions { get; set; }
        public virtual ICollection<ItemSuppliers> ItemSuppliers { get; set; }

        public virtual ICollection<UnitMeasureConversion> UnitMeasureConversions { get; set; }
    }
}