using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Address;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Module.Funerary.Domain.Religions;

namespace Esr.Module.Funerary.Domain.DataDeceaseds
{
    [DisplayName(@"Dados do Falecido")]
    public class DataDeceased : IEntityBase
    {
        #region Geral
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime UltimoAcesso { get; set; }

        [DisplayName(@"Data"), Required, DataType(DataType.Date)]
        public DateTime FalecidoData { get; set; }
        [DisplayName(@"Natimorto")]
        public string FalecidoNatimorto { get; set; } // verificar
        [DisplayName(@"Tipo")]
        public string FalecidoTipo { get; set; }
        [DisplayName(@"Declaração")]
        public string FalecidoDeclaracao { get; set; }
        #endregion

        #region DadosFalecido
        [Required]
        [DisplayName(@"Nome do Falecido")]
        public string FalecidoNome { get; set; }
        public virtual int TyFalecidoSexoId { get { return (int)FalecidoSexo; } set { FalecidoSexo = (Gender)value; } }
        [DisplayName(@"Sexo")]
        public Gender FalecidoSexo { get; set; }
        public virtual int ColorRaceId { get { return (int)FalecidoCor; } set { FalecidoCor = (ColorRace)value; } }
        [DisplayName(@"Raça/Cor")]
        public ColorRace FalecidoCor { get; set; }
        [DisplayName(@"Nascimento")]
        public DateTime FalecidoNascimento { get; set; }
        public virtual int FalecidoDeixaBensId { get { return (int)FalecidoDeixaBens; } set { FalecidoDeixaBens = (YesNo)value; } }
        [DisplayName(@"Deixa Bens?")]
        public YesNo FalecidoDeixaBens { get; set; } // verificar
        public virtual int FalecidoTestamentoId { get { return (int)FalecidoTestamento; } set { FalecidoTestamento = (YesNo)value; } }
        [DisplayName(@"Testamento?")]
        public YesNo FalecidoTestamento { get; set; } // verificar
        [DisplayName(@"Natural")]
        public string FalecidoNatural { get; set; }
        public virtual int FalecidoEtadoCivilId { get { return (int)FalecidoEtadoCivil; } set { FalecidoEtadoCivil = (MaritalStatus)value; } }
        [DisplayName(@"Estado Cívil")]
        public MaritalStatus FalecidoEtadoCivil { get; set; }
        [DisplayName(@"Endereço")]
        public string FalecidoEndereco { get; set; }
        [DisplayName(@"Bairro")]
        public string FalecidoBairro { get; set; }
        [DisplayName(@"Cidade"), DependencyKey("FalecidoEstadoId", "StateId")]
        public int? FalecidoCidadeId { get; set; }
        public virtual City FalecidoCidade { get; set; }
        [DisplayName(@"Estado")]
        public int? FalecidoEstadoId { get; set; }
        public virtual State FalecidoEstado { get; set; }
        [DisplayName(@"Rg")]
        public string FalecidoRg { get; set; }
        [DisplayName(@"Cpf"), Required, Unique, CpfValidator]
        public string FalecidoCpf { get; set; }
        public virtual int FalecidoEleitorId { get { return (int)FalecidoEleitor; } set { FalecidoEleitor = (YesNo)value; } }
        [DisplayName(@"Eleitor?")]
        public YesNo FalecidoEleitor { get; set; }
        public virtual int FalecidoVotavaId { get { return (int)FalecidoVotava; } set { FalecidoVotava = (YesNo)value; } }
        [DisplayName(@"Votava?")]
        [LockedTrueValue(new[]
        {
            "FalecidoCidadeTituloEleitor",
            "FalecidoNumeroTitulo",
            "FalecidoZonaTitulo",
            "FalecidoSecaoTitulo"
        }, new object[] { YesNo.No }, UniqueValue = true)]
        public YesNo FalecidoVotava { get; set; }
        [DisplayName(@"Cidade Eleitor")]
        public string FalecidoCidadeTituloEleitor { get; set; }
        [DisplayName(@"Numero Titulo")]
        public string FalecidoNumeroTitulo { get; set; }
        [DisplayName(@"Zona Titulo")]
        public string FalecidoZonaTitulo { get; set; }
        [DisplayName(@"Seção Título")]
        public string FalecidoSecaoTitulo { get; set; }

        public virtual int FalecidoReservistaId { get { return (int)FalecidoReservista; } set { FalecidoReservista = (YesNo)value; } }
        [LockedTrueValue(new[]
        {
            "FalecidoReservistaIdentificacao"
        }, new object[] { YesNo.No }, UniqueValue = true)]
        [DisplayName(@"Reservita?")]
        public YesNo FalecidoReservista { get; set; }

        [DisplayName(@"Numero Reservista")]
        public string FalecidoReservistaIdentificacao { get; set; }

        public virtual int FalecidoInssId { get { return (int)FalecidoInss; } set { FalecidoInss = (YesNo)value; } }

        [LockedTrueValue(new[]
        {
            "FalecidoInssIdentificacao"
        }, new object[] { YesNo.No }, UniqueValue = true)]
        [DisplayName(@"INSS?")]
        public YesNo FalecidoInss { get; set; }

        [DisplayName(@"INSS Identificação")]
        public string FalecidoInssIdentificacao { get; set; }

        [DisplayName(@"Religião")]
        public int? FalecidoReligiaoId { get; set; }
        public virtual Religion FalecidoReligiao { get; set; }

        [DisplayName(@"Profissão")]
        public int? FalecidoProfissaoId { get; set; }
        public virtual Function FalecidoProfissao { get; set; }

        [DisplayName(@"Filhos do Falecido")]
        public string FalecidoFilhos { get; set; }

        [DisplayName(@"Observações")]
        public string FalecidoObservacao { get; set; }
        #endregion

        #region Filiacao
        [DisplayName(@"Nome do Pai")]
        public string FalecidoFiliacaoNomePai { get; set; }

        public virtual int? FalecidoFiliacaoPaiEstadoCivilId { get { return (int)FalecidoFiliacaoPaiEstadoCivil; } set { FalecidoFiliacaoPaiEstadoCivil = (MaritalStatus)value; } }

        [DisplayName(@"Estado Cívil do Pai")]
        public MaritalStatus? FalecidoFiliacaoPaiEstadoCivil { get; set; }

        [DisplayName(@"Idade do Pai")]
        public decimal FalecidoFiliacaoPaiIdade { get; set; }
        [DisplayName(@"Naturalidade do Pai")]
        public string FalecidoFiliacaoPaiNatural { get; set; }
        [DisplayName(@"Profissão do Pai")]
        public int? FalecidoFiliacaoPaiProfissaoId { get; set; }
        public virtual Function FalecidoFiliacaoPaiProfissao { get; set; }
        [DisplayName(@"Documento do Pai")]
        public string FalecidoFiliacaoPaiDocumento { get; set; }

        [DisplayName(@"Nome da Mãe")]
        public string FalecidoFiliacaoNomeMae { get; set; }

        public virtual int? FalecidoFiliacaoMaeEtadoCivilId { get { return (int)FalecidoFiliacaoMaeEtadoCivil; } set { FalecidoFiliacaoMaeEtadoCivil = (MaritalStatus)value; } }

        [DisplayName(@"Estado Cívil da Mãe")]
        public MaritalStatus? FalecidoFiliacaoMaeEtadoCivil { get; set; }

        [DisplayName(@"Idade da Mãe")]
        public decimal FalecidoFiliacaoMaeIdade { get; set; }
        [DisplayName(@"Naturalidade da Mãe")]
        public string FalecidoFiliacaoMaeNatural { get; set; }
        [DisplayName(@"Profissão da Mãe")]
        public int? FalecidoFiliacaoMaeProfissaoId { get; set; }
        public virtual Function FalecidoFiliacaoMaeProfissao { get; set; }
        [DisplayName(@"Documento da Mãe")]
        public string FalecidoFiliacaoMaeDocumento { get; set; }

        [DisplayName(@"Endereço dos Filiados")]
        public string FalecidoFiliacaoEndereco { get; set; }
        [DisplayName(@"Bairro dos Filiados")]
        public string FalecidoFiliacaoBairro { get; set; }

        [DisplayName(@"Cidade dos Filiados"), DependencyKey("FalecidoFiliacaoEstadoId", "StateId")]
        public int? FalecidoFiliacaoCidadeId { get; set; }
        public virtual City FalecidoFiliacaoCidade { get; set; }

        [DisplayName(@"Estado dos Filiados")]
        public int? FalecidoFiliacaoEstadoId { get; set; }
        public virtual State FalecidoFiliacaoEstado { get; set; }

        #endregion

        #region Conjugue
        [DisplayName(@"Nome do Conjugue")]
        public string FalecidoNomeConjugue { get; set; }
        [DisplayName(@"Cartório de Nupcias")]
        public string FalecidoCartorioNupcias { get; set; }
        [DisplayName(@"Data de Nupcias")]
        public DateTime? FalecidoDataNupcias { get; set; }
        [DisplayName(@"Livro")]
        public string FalecidoLivro { get; set; }
        [DisplayName(@"Folha")]
        public string FalecidoFolha { get; set; }
        [DisplayName(@"Número")]
        public string FalecidoNumero { get; set; }

        #endregion

        #region Natimorto
        #region DadosGerais
        [DisplayName(@"Natimorto Idade")]
        public decimal NatimortoIdade { get; set; }
        public decimal NatimortoDescIdade { get; set; }
        [DisplayName(@"Natimorto Hora Nascimento")]
        public DateTime? NatimortoHoraNascimento { get; set; }
        [DisplayName(@"Natimorto Gestão")]
        public string NatimortoGestao { get; set; }
        [DisplayName(@"Natimorto Duração")]
        public string NatimortoDuracao { get; set; }
        [DisplayName(@"Natimorto Avos Paternos")]
        public string NatimortoAvosPaternos { get; set; }
        [DisplayName(@"Natimorto Avos Maternos")]
        public string NatimortoAvosMaternos { get; set; }
        [DisplayName(@"Natimorto Local do Nascimento")]
        public string NatimortoLocalNascimento { get; set; }

        #endregion

        #region Testemunhas
        [DisplayName(@"Nome Testemunha 1")]
        public string NatimortoTestemunha1Nome { get; set; }
        [DisplayName(@"Idade Testemunha 1")]
        public decimal NatimortoTestemunha1Idade { get; set; }
        [DisplayName(@"Documento Testemunha 1")]
        public string NatimortoTestemunha1Documento { get; set; }
        [DisplayName(@"Profissão Testemunha 1")]
        public int? NatimortoTestemunha1ProfissaoId { get; set; }
        public virtual Function NatimortoTestemunha1Profissao { get; set; }
        [DisplayName(@"Nacionalidade Testemunha 1")]
        public string NatimortoTestemunha1Nacionalidade { get; set; }

        public virtual int? NatimortoTestemunha1EstadoCivilId { get { return (int)NatimortoTestemunha1EstadoCivil; } set { NatimortoTestemunha1EstadoCivil = (MaritalStatus)value; } }

        [DisplayName(@"Estado Cívil Testemunha 1")]
        public MaritalStatus? NatimortoTestemunha1EstadoCivil { get; set; }

        [DisplayName(@"Endereço Testemunha 1")]
        public string NatimortoTestemunha1Endereco { get; set; }
        [DisplayName(@"Bairro Testemunha 1")]
        public string NatimortoTestemunha1Bairro { get; set; }

        [DisplayName(@"Cidade Testemunha 1"), DependencyKey("NatimortoTestemunha1EstadoId", "StateId")]
        public int? NatimortoTestemunha1CidadeId { get; set; }
        public virtual City NatimortoTestemunha1Cidade { get; set; }

        [DisplayName(@"Estado Testemunha 1")]
        public int? NatimortoTestemunha1EstadoId { get; set; }
        public virtual State NatimortoTestemunha1Estado { get; set; }

        [DisplayName(@"Nome Testemunha 2")]
        public string NatimortoTestemunha2Nome { get; set; }
        [DisplayName(@"Idade Testemunha 2")]
        public decimal NatimortoTestemunha2Idade { get; set; }
        [DisplayName(@"Documento Testemunha 2")]
        public string NatimortoTestemunha2Documento { get; set; }
        [DisplayName(@"Profissão Testemunha 2")]
        public int? NatimortoTestemunha2ProfissaoId { get; set; }
        public virtual Function NatimortoTestemunha2Profissao { get; set; }
        [DisplayName(@"Nacionalidade Testemunha 2")]
        public string NatimortoTestemunha2Nacionalidade { get; set; }

        public virtual int? NatimortoTestemunha2EstadoCivilId { get { return (int) NatimortoTestemunha2EstadoCivil; } set { NatimortoTestemunha2EstadoCivil = (MaritalStatus)value; } }

        [DisplayName(@"Estado Cívil Testemunha 2")]
        public MaritalStatus? NatimortoTestemunha2EstadoCivil { get; set; }

        [DisplayName(@"Endereço Testemunha 2")]
        public string NatimortoTestemunha2Endereco { get; set; }
        [DisplayName(@"Bairro Testemunha 2")]
        public string NatimortoTestemunha2Bairro { get; set; }

        [DisplayName(@"Cidade Testemunha 2"), DependencyKey("NatimortoTestemunha2EstadoId", "StateId")]
        public int? NatimortoTestemunha2CidadeId { get; set; }
        public virtual City NatimortoTestemunha2Cidade { get; set; }

        [DisplayName(@"Estado Testemunha 2")]
        public int? NatimortoTestemunha2EstadoId { get; set; }
        public virtual State NatimortoTestemunha2Estado { get; set; }

        #endregion
        #endregion

        #region Dados Obito
        #region DadosGerais

        [LockedTrueValue(new[] { "ObitoHoraFalecimento" }, new object[] { null })]
        [DisplayName(@"Data Falecimento"), DataType(DataType.Date)]
        public DateTime? ObitoDataFalecimento { get; set; }
        [DisplayName(@"Hora Falecimento"), DataType(DataType.Time)]

        public DateTime? ObitoHoraFalecimento { get; set; }
        [DisplayName(@"Local Falecimento")]
        public string ObitoLocalFalecimento { get; set; }

        [DisplayName(@"Cidade Falecimento"), DependencyKey("ObitoEstadoFalecimentoId", "StateId")]
        public int? ObitoCidadeFalecimentoId { get; set; }
        public virtual City ObitoCidadeFalecimento { get; set; }

        [DisplayName(@"Estadp Falecimento")]
        public int? ObitoEstadoFalecimentoId { get; set; }
        public virtual State ObitoEstadoFalecimento { get; set; }


        [DisplayName(@"Sala")]
        public string ObitoSala { get; set; }
        [DisplayName(@"Data Sepultamento"), DataType(DataType.Date)]
        public DateTime? ObitoDataSepultamento { get; set; }
        [DisplayName(@"Horas Sepultamento"), DataType(DataType.Time)]
        public DateTime? ObitoHoraSepultamento { get; set; }
        [DisplayName(@"Local Sepultamento")]
        public string ObitoLocalSepultamento { get; set; }

        [DisplayName(@"Cidade Sepultamento"), DependencyKey("ObitoEstadoSepultamentoId", "StateId")]
        public int? ObitoCidadeSepultamentoId { get; set; }
        public virtual City ObitoCidadeSepultamento { get; set; }

        [DisplayName(@"Estado Sepultamento")]
        public int? ObitoEstadoSepultamentoId { get; set; }
        public virtual State ObitoEstadoSepultamento { get; set; }
        #endregion

        #region DeclaracaoMedica
        [DisplayName(@"Nome do médico")]
        public string ObitoMedico1 { get; set; }
        [DisplayName(@"CRM")]
        public string ObitoMedico1Crm { get; set; }
        [DisplayName(@"Nome do médido 2")]
        public string ObitoMedico2 { get; set; }
        [DisplayName(@"Nome do médido 2")]
        public string ObitoMedico2Crm { get; set; }
        [DisplayName(@"Causa da Marte")]
        public string ObitoCausaMorte { get; set; }
        #endregion

        #region DadosCartorio
        [DisplayName(@"Agência")]
        public string ObitoAgencia { get; set; }
        [DisplayName(@"Cartorio")]
        public string ObitoCartorio { get; set; }
        [DisplayName(@"Nota")]
        public string ObitoNota { get; set; }
        [DisplayName(@"Endereço do Cartório")]
        public string ObitoEnderecoCartorio { get; set; }
        #endregion

        #region DadosDeclaracao
        [DisplayName(@"Declarante")]
        public string ObitoDeclarante { get; set; }
        [DisplayName(@"RG")]
        public string ObitoDeclaranteRg { get; set; }
        [DisplayName(@"Cpf"), CpfValidator]
        public string ObitoDeclaranteCpf { get; set; }
        [DisplayName(@"Grau de Parantesco")]
        public string ObitoDeclaranteGrauParentesco { get; set; }

        [DisplayName(@"Profissão")]
        public int? ObitoDeclaranteProfissaoId { get; set; }
        public virtual Function ObitoDeclaranteProfissao { get; set; }

        [DisplayName(@"Cep")]
        public string ObitoDeclaranteCep { get; set; }
        [DisplayName(@"Endereço")]
        public string ObitoDeclaranteEndereco { get; set; }
        [DisplayName(@"Bairro")]
        public string ObitoDeclaranteBairro { get; set; }

        [DisplayName(@"Cidade"), DependencyKey("ObitoDeclaranteEstadoId", "StateId")]
        public int? ObitoDeclaranteCidadeId { get; set; }
        public virtual City ObitoDeclaranteCidade { get; set; }

        [DisplayName(@"Estado")]
        public int? ObitoDeclaranteEstadoId { get; set; }
        public virtual State ObitoDeclaranteEstado { get; set; }

        [DisplayName(@"Telefone")]
        public string ObitoDeclaranteTelefone { get; set; }
        #endregion

        #region Atendente
        [DisplayName(@"Atendente 1")]
        public int? SObitoAtendente1Id { get; set; }
        public virtual User SObitoAtendente1 { get; set; }

        [DisplayName(@"Atendente 2")]
        public int? SObitoAtendente2Id { get; set; }
        public virtual User SObitoAtendente2 { get; set; }

        [DisplayName(@"Responsável Tratamento")]
        public string ObitoRespTratamento { get; set; }

        #endregion
        #endregion

        [DisplayName(@"Nome Responsável")]
        public string FalecidoNomeResponsavelFamilia { get; set; }

        [DisplayName(@"Local do Velório")]
        public string LocalVelorio { get; set; }

        public bool Integration { get; set; }
    }
}
