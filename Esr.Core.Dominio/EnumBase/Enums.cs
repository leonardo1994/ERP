using System.ComponentModel.DataAnnotations;

namespace Esr.Core.Domain.EnumBase
{
    /// <summary>
    /// Tipo de compania
    /// </summary>
    public enum TypeCompany : byte
    {
        [Display(Name = "Matriz")]
        Matriz,
        [Display(Name = "Filial")]
        Filial
    }

    /// <summary>
    /// Tipo de componente de tela.
    /// </summary>
    public enum TypeComponent : byte
    {
        [Display(Name = "Tela")]
        Screen,
        [Display(Name = "Campo")]
        Field,
        [Display(Name = "Tabela/Coluna")]
        Grid
    }

    /// <summary>
    /// Origem do Item
    /// </summary>
    public enum OriginItem : byte
    {
        /// <summary>
        /// Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8
        /// </summary>
        [Display(Name = "Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8")]
        Origin0,
        /// <summary>
        /// Estrangeira - Importação direta exceta as indicadas no código 6
        /// </summary>
        [Display(Name = "Estrangeira - Importação direta exceta as indicadas no código 6")]
        Origin1,
        /// <summary>
        /// Estrangeira - Adquirida no mercado interno, exceto as indicadas no código 7
        /// </summary>
        [Display(Name = "Estrangeira - Adquirida no mercado interno, exceto as indicadas no código 7")]
        Origin2,
        /// <summary>
        /// Nacional, mercadoria ou bem com Conteúdo de importação superior a 40% e inferior ou igual a 70%
        /// </summary>
        [Display(Name = "Nacional, mercadoria ou bem com Conteúdo de importação superior a 40% e inferior ou igual a 70%")]
        Origin3,
        /// <summary>
        /// Nacional, cuja a produção tenha sido em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos ajustes
        /// </summary>
        [Display(Name = "Nacional, cuja a produção tenha sido em conformidade com os processos produtivos básicos de que tratam as legislações citadas nos ajustes")]
        Origin4,
        /// <summary>
        /// Nacional, mercadoria ou bem com Conteúdo de importação inferior ou igual a 40%
        /// </summary>
        [Display(Name = "Nacional, mercadoria ou bem com Conteúdo de importação inferior ou igual a 40%")]
        Origin5,
        /// <summary>
        /// Estrangeira - Importção direta, sem similar nacional, constante em lista da CAMEX e gás natural
        /// </summary>
        [Display(Name = "Estrangeira - Importção direta, sem similar nacional, constante em lista da CAMEX e gás natural")]
        Origin6,
        /// <summary>
        /// Estrangeira - Adquirida no mercado interno, sem similar nacional, constante em lista da CAMEX e gás natural
        /// </summary>
        [Display(Name = "Estrangeira - Adquirida no mercado interno, sem similar nacional, constante em lista da CAMEX e gás natural")]
        Origin7,
        /// <summary>
        /// Nacional, mercadoria ou bem com Conteúdo de importação superior a 70%
        /// </summary>
        [Display(Name = "Nacional, mercadoria ou bem com Conteúdo de importação superior a 70%")]
        Origin8
    }

    /// <summary>
    /// Uso de Mercadorias
    /// </summary>
    public enum MerchandiseUse : byte
    {
        /// <summary>
        /// Não informado
        /// </summary>
        [Display(Name =  "Não informado")]
        Uninformed,
        /// <summary>
        /// Uso e Consumo
        /// </summary>
        [Display(Name = "Uso e Consumo")]
        UserConsumption,
        /// <summary>
        /// Industrialização
        /// </summary>
        [Display(Name =  "Industrialização")]
        Industrialization,
        /// <summary>
        /// Comercialização
        /// </summary>
        [Display(Name = "Comercialização")]
        Commercialization,
        /// <summary>
        /// Outros
        /// </summary>
        [Display(Name = "Outros")]
        Others
    }

    /// <summary>
    /// Tipo de Estrutura
    /// </summary>
    public enum TypeStructure : byte
    {
        /// <summary>
        /// Sintético
        /// </summary>
        [Display(Name = "Sintético")]
        Sinthetic,
        /// <summary>
        /// Analítico
        /// </summary>
        [Display(Name = "Analítico")]
        Analytical
    }

    /// <summary>
    /// Situação
    /// </summary>
    public enum Situation : byte
    {
        /// <summary>
        /// Ativo
        /// </summary>
        [Display(Name = "Ativo")]
        Active,
        /// <summary>
        /// Inativo
        /// </summary>
        [Display(Name = "Inativo")]
        Inactive
    }

    /// <summary>
    /// Impostos Sobre Livros
    /// </summary>
    public enum TaxesOnBooks : byte
    {
        /// <summary>
        /// ICMS - Impostos Sobre Circulação de Serviços e Mercadorias
        /// </summary>
        [Display(Name = @"ICMS - Impostos Sobre Circulação de Serviços e Mercadorias")]
        Icms,
        /// <summary>
        /// IPI - Impostos Sobre Produto Industrializado
        /// </summary>
        [Display(Name = @"IPI - Impostos Sobre Produto Industrializado")]
        Ipi,
        /// <summary>
        /// ISS - Impostos Sobre Sobre Serviço
        /// </summary>
        [Display(Name = @"ISS - Impostos Sobre Sobre Serviço")]
        Iss,
        /// <summary>
        /// INSS - Instituto Nacional da Seguridade Social
        /// </summary>
        [Display(Name = @"INSS - Instituto Nacional da Seguridade Social")]
        Inss,
        /// <summary>
        /// IR - Impostos de Renda
        /// </summary>
        [Display(Name = @"IR - Impostos de Renda")]
        Ir,
        /// <summary>
        /// PIS/PASEP - Programa de Integração Social
        /// </summary>
        [Display(Name = @"PIS/PASEP - Programa de Integração Social")]
        PisPasep,
        /// <summary>
        /// COFINS - Contribuição para Fins Sociais
        /// </summary>
        [Display(Name = @"COFINS - Contribuição para Fins Sociais")]
        Cofins,
        /// <summary>
        /// ICMS por Substituição Tributária
        /// </summary>
        [Display(Name = @"ICMS por Substituição Tributária")]
        IcmsSt,
        /// <summary>
        /// Outros
        /// </summary>
        [Display(Name = @"Outros")]
        Others,
        /// <summary>
        /// Icms para Diferença de Alíquota
        /// </summary>
        [Display(Name = @"Icms para Diferença de Alíquota")]
        IcmsDifferenceAliquot,
        /// <summary>
        /// IPI - Imposto Sobre Produto Industrializado Retido
        /// </summary>
        [Display(Name = @"IPI - Imposto Sobre Produto Industrializado Retido")]
        IpiIndustrializedWithheld,
        /// <summary>
        /// ISS Retido - Impostos Sobre Serviços
        /// </summary>
        [Display(Name = @"ISS Retido - Impostos Sobre Serviços")]
        IssWithheldService,
        /// <summary>
        /// Ir Retido - Imposto de Renda
        /// </summary>
        [Display(Name = @"Ir Retido - Imposto de Renda")]
        IrWithheld,
        [Display(Name = @"PIS/PASEP Retido - Programa de Integração Social")]
        PisPasepWithheld,
        [Display(Name = @"COFINS Retido - Contribuição para Fins Sociais")]
        CofinsWithheld,
        [Display(Name = @"INSS Retido - Instituto Nacional da Seguridade Social")]
        InssWithheld,
        [Display(Name = @"II - Impostos de Importação")]
        ImportTax,
        [Display(Name = @"IOF - Valor do Imposto Sobre Operações Finaneiras")]
        Iof,
        [Display(Name = @"ICMS com Recolhimento Antecipado")]
        IcmsGathering,
        [Display(Name = @"CSLL - Contribuição Social Sobre Lucro Líquido")]
        Csll,
        [Display(Name = @"PIS/PASEP Sobre Serviços Tomados")]
        PisPasepServiceTaken,
        [Display(Name = @"COFINS Sobre Serviços Tomados")]
        CofinsServiceTaken,
        [Display(Name = @"CSLL Sobre Serviços Tomados")]
        CsllServiceTaken,
        [Display(Name = @"CSLL Retido")]
        CsllWithheld,
        [Display(Name = @"INSS Sobre Serviços Tomados")]
        InssServiceTaken,
        [Display(Name = @"IR Tomando - Imposto de Renda")]
        IrTaken,
        [Display(Name = @"ISS Sobre Serviços Tomados")]
        IssServiceTaken,
        [Display(Name = @"ICMS ST Regime Especial")]
        IcmsStSpecial
    }

    public enum ValidityType : byte
    {
        [Display(Name = @"Minuto (s)")]
        Minute,
        [Display(Name = @"Hora (s)")]
        Hour,
        [Display(Name = @"Dia (s)")]
        Day,
        [Display(Name = @"Semana (s)")]
        Week,
        [Display(Name = @"Mês (es)")]
        Moth,
        [Display(Name = @"Bimestre (s)")]
        TwoMonth,
        [Display(Name = @"Semestre (s)")]
        Half,
        [Display(Name = @"Ano (s)")]
        Year,
        [Display(Name = @"Quilômetro (s)")]
        Kilometer
    }

    public enum TypeValue : byte
    {
        [Display(Name = "%")]
        Porcent,
        [Display(Name = "$")]
        Currency
    }

    public enum TypeOperation : byte
    {
        [Display(Name = "Divisão")]
        Division,
        [Display(Name = "Soma")]
        Sum,
        [Display(Name = "Subtração")]
        Subtraction,
        [Display(Name = "Multiplicação")]
        Multiplication,
        [Display(Name = "Subtrai Porcentual")]
        SubtractionPorcent,
        [Display(Name = "Adição Porcentual")]
        AditionalPorcent,
        [Display(Name = "Valor Porcentual")]
        PorcentValue,
        [Display(Name = "Subtração Invertida")]
        SubtractionInversion
    }

    public enum Gender : byte
    {
        [Display(Name = "Masculino")]
        Male,
        [Display(Name = "Feminino")]
        Female
    }

    public enum ColorRace : byte
    {
        [Display(Name = "Branca")]
        White,
        [Display(Name = "Preta")]
        Black,
        [Display(Name = "Parda")]
        Brown,
        [Display(Name = "Indígina")]
        Indigenouns,
        [Display(Name = "Amarela")]
        Yellow
    }

    public enum MaritalStatus : byte
    {
        [Display(Name = "Casado(a)")]
        Married,
        [Display(Name = "Solteiro(a)")]
        NotMarried,
        [Display(Name = "Divorciado(a)")]
        Divorced,
        [Display(Name = "Viúvo(a)")]
        Widower,
        [Display(Name = "Amasiado")]
        Amassed
    }

    public enum YesNo : byte
    {
        [Display(Name =  "Sim")]
        Yes,
        [Display(Name = "Não")]
        No
    }

    /// <summary>
    /// Tipo de movimento de estoque
    /// </summary>
    public enum StockMovementType
    {
        /// <summary>
        /// Entrada de materiais
        /// </summary>
        [Display(Name = "Entrada de Materiais")]
        Input,
        /// <summary>
        /// Saída de materiais
        /// </summary>
        [Display(Name = "Saída de Materiais")]
        Output,
        /// <summary>
        /// Previsão de entrada de materiais
        /// </summary>
        [Display(Name = "Previsão de Entrada de Materiais")]
        PredictionInput,
        /// <summary>
        /// Previsão de Saída de Materiais
        /// </summary>
        [Display(Name = "Previsão de Saída de Materiais")]
        PredictionOutput,
        /// <summary>
        /// Saída de Materiais para Terceiros
        /// </summary>
        [Display(Name = "Saída de Materiais para Terceiros")]
        ThirdPartyOutput,
        /// <summary>
        /// Entrada de Materiais para Terceiros
        /// </summary>
        [Display(Name = "Entrada de Materiais para Terceiros")]
        ThirdPartyInput,
        /// <summary>
        /// Saída para Assistência Técnica
        /// </summary>
        [Display(Name = "Saída para Assistência Técnica")]
        ExitTechinicalAssistance,
        /// <summary>
        /// Reserva de Material
        /// </summary>
        [Display(Name = "Reserva de Material")]
        Reservation,
        /// <summary>
        /// Requisição de Material
        /// </summary>
        [Display(Name = "Requisição de Material")]
        Request,
        /// <summary>
        /// Alocação para Produção
        /// </summary>
        [Display(Name = "Alocação para Produção")]
        ProductionAllocation,
        /// <summary>
        /// Entrada em produção
        /// </summary>
        [Display(Name = "Em Produção")]
        InProduction,
        /// <summary>
        /// Compras alocadas.
        /// </summary>
        [Display(Name = "Compras Alocadas")]
        AllocatedPurchases
    }

    public enum TimeType
    {
        [Display(Name = "Hora")]
        Hour,
        [Display(Name = "Minuto")]
        Minute
    }
}