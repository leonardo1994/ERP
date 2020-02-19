using System;
using System.Collections.Generic;
using System.Linq;
using Esr.Core.App.Address;
using Esr.Core.Component;
using Esr.Core.Domain.EnumBase;
using Esr.Module.Funerary.App.DataDeceaseds;
using Esr.Module.Funerary.App.Religions;
using Esr.Module.Funerary.Domain.DataDeceaseds;
using Esr.Module.Funerary.Forms.Religions;
using Esr.Module.InitialRegistration.App.RH;
using Esr.Module.InitialRegistration.Forms.Address;
using Esr.Module.InitialRegistration.Forms.RH;
using Microsoft.VisualBasic;
using Esr.Module.Funerary.Controllers;
using Esr.Module.Funerary.Domain.Religions;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Core.Domain.Address;

namespace Esr.Module.Funerary.Forms.DataDeceaseds
{
    public partial class FDataDeceased : FForm
    {
        public override List<SReports> SReportses { get; set; } = new List<SReports>
            {
                new SReports
                {
                    Nome = "Ata Somatoconservação",
                    LocalPath = "AtaSomatoConservacao.rdlc",
                    DataSet = new Dictionary<string, SInvokeMethod>()
                    {
                        {"DadosFalecidoDataSet",new SInvokeMethod
                    {
                        NameMethod = "QueryDadosFalecido",
                        TypeClass = typeof(FDataDeceased)
                    }
}
                    }
                },
                new SReports
                {
                    Nome = "Declaração de Óbito",
                    LocalPath = "Report1.rdlc",
                    DataSet = new Dictionary<string, SInvokeMethod>()
                    {
                        {
                            "DeclaracaoObitoDataSet",
                            new SInvokeMethod
                            {
                                NameMethod = "QueryDeclaracaoObito",
                                TypeClass = typeof(FDataDeceased)
                            }
                        }
                    }
                }
            };

        public FDataDeceased()
        {
            ObjectControl = new List<DataDeceased>();

            InvokeMethod = new InvokeMethod(typeof(DataDeceasedController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListDataDeceased" }
            }, typeof(DataDeceased));

            InitializeComponent();

            FalecidoReligiaoId.FormType = typeof(FReligion);
            FalecidoReligiaoId.ObjetoApp = new InvokeMethod(typeof(ReligionController), TypeExecute.SearchAll, "ListReligion", typeof(Religion));
            FalecidoReligiaoId.DisplayMember = "Description";
            FalecidoReligiaoId.ValueMember = "Id";

            FalecidoProfissaoId.FormType = typeof(FFunction);
            FalecidoProfissaoId.ObjetoApp = new InvokeMethod(typeof(FunctionController), TypeExecute.SearchAll, "ListFunction", typeof(Function));
            FalecidoProfissaoId.DisplayMember = "FunctionDescription";
            FalecidoProfissaoId.ValueMember = "Id";

            FalecidoFiliacaoMaeProfissaoId.FormType = typeof(FFunction);
            FalecidoFiliacaoMaeProfissaoId.ObjetoApp = new InvokeMethod(typeof(FunctionController), TypeExecute.SearchAll, "ListFunction", typeof(Function));
            FalecidoFiliacaoMaeProfissaoId.DisplayMember = "FunctionDescription";
            FalecidoFiliacaoMaeProfissaoId.ValueMember = "Id";

            FalecidoFiliacaoPaiProfissaoId.FormType = typeof(FFunction);
            FalecidoFiliacaoPaiProfissaoId.ObjetoApp = new InvokeMethod(typeof(FunctionController), TypeExecute.SearchAll, "ListFunction", typeof(Function));
            FalecidoFiliacaoPaiProfissaoId.DisplayMember = "FunctionDescription";
            FalecidoFiliacaoPaiProfissaoId.ValueMember = "Id";

            ObitoDeclaranteProfissaoId.FormType = typeof(FFunction);
            ObitoDeclaranteProfissaoId.ObjetoApp = new InvokeMethod(typeof(FunctionController), TypeExecute.SearchAll, "ListFunction", typeof(Function));
            ObitoDeclaranteProfissaoId.DisplayMember = "FunctionDescription";
            ObitoDeclaranteProfissaoId.ValueMember = "Id";

            NatimortoTestemunha1ProfissaoId.FormType = typeof(FFunction);
            NatimortoTestemunha1ProfissaoId.ObjetoApp = new InvokeMethod(typeof(FunctionController), TypeExecute.SearchAll, "ListFunction", typeof(Function));
            NatimortoTestemunha1ProfissaoId.DisplayMember = "FunctionDescription";
            NatimortoTestemunha1ProfissaoId.ValueMember = "Id";

            FalecidoSexo.SetEnumItems<Gender>(Gender.Male);

            FalecidoCor.SetEnumItems<ColorRace>(ColorRace.Black);

            FalecidoEtadoCivil.SetEnumItems<MaritalStatus>(MaritalStatus.Amassed);

            FalecidoDeixaBens.SetEnumItems<YesNo>(YesNo.Yes);

            FalecidoTestamento.SetEnumItems<YesNo>(YesNo.Yes);

            FalecidoInss.SetEnumItems<YesNo>(YesNo.Yes);

            FalecidoVotava.SetEnumItems<YesNo>(YesNo.Yes);

            FalecidoFiliacaoPaiEstadoCivil.SetEnumItems<MaritalStatus>(MaritalStatus.Amassed);

            FalecidoFiliacaoMaeEtadoCivil.SetEnumItems<MaritalStatus>(MaritalStatus.Amassed);

            FalecidoEstadoId.DisplayMember = "Initials";
            FalecidoEstadoId.ValueMember = "Id";
            FalecidoEstadoId.ObjetoApp = new InvokeMethod(typeof(StateController), TypeExecute.SearchAll, "ListState", typeof(State));
            FalecidoEstadoId.FormType = typeof(FState);

            FalecidoFiliacaoEstadoId.DisplayMember = "Initials";
            FalecidoFiliacaoEstadoId.ValueMember = "Id";
            FalecidoFiliacaoEstadoId.ObjetoApp = new InvokeMethod(typeof(StateController), TypeExecute.SearchAll, "ListState", typeof(State));
            FalecidoFiliacaoEstadoId.FormType = typeof(FState);

            ObitoEstadoFalecimentoId.DisplayMember = "Initials";
            ObitoEstadoFalecimentoId.ValueMember = "Id";
            ObitoEstadoFalecimentoId.ObjetoApp = new InvokeMethod(typeof(StateController), TypeExecute.SearchAll, "ListState", typeof(State));
            ObitoEstadoFalecimentoId.FormType = typeof(FState);

            ObitoEstadoSepultamentoId.DisplayMember = "Initials";
            ObitoEstadoSepultamentoId.ValueMember = "Id";
            ObitoEstadoSepultamentoId.ObjetoApp = new InvokeMethod(typeof(StateController), TypeExecute.SearchAll, "ListState", typeof(State));
            ObitoEstadoSepultamentoId.FormType = typeof(FState);

            ObitoDeclaranteEstadoId.DisplayMember = "Initials";
            ObitoDeclaranteEstadoId.ValueMember = "Id";
            ObitoDeclaranteEstadoId.ObjetoApp = new InvokeMethod(typeof(StateController), TypeExecute.SearchAll, "ListState", typeof(State));
            ObitoDeclaranteEstadoId.FormType = typeof(FState);

            NatimortoTestemunha1EstadoId.DisplayMember = "Initials";
            NatimortoTestemunha1EstadoId.ValueMember = "Id";
            NatimortoTestemunha1EstadoId.ObjetoApp = new InvokeMethod(typeof(StateController), TypeExecute.SearchAll, "ListState", typeof(State));
            NatimortoTestemunha1EstadoId.FormType = typeof(FState);

            NatimortoTestemunha2EstadoId.DisplayMember = "Initials";
            NatimortoTestemunha2EstadoId.ValueMember = "Id";
            NatimortoTestemunha2EstadoId.ObjetoApp = new InvokeMethod(typeof(StateController), TypeExecute.SearchAll, "ListState", typeof(State));
            NatimortoTestemunha2EstadoId.FormType = typeof(FState);

            FalecidoCidadeId.DisplayMember = "CityName";
            FalecidoCidadeId.ValueMember = "Id";
            FalecidoCidadeId.ObjetoApp = new InvokeMethod(typeof(CityController), TypeExecute.SearchAll, "ListCity", typeof(City));
            FalecidoCidadeId.FormType = typeof(FCity);

            FalecidoFiliacaoCidadeId.DisplayMember = "CityName";
            FalecidoFiliacaoCidadeId.ValueMember = "Id";
            FalecidoFiliacaoCidadeId.ObjetoApp = new InvokeMethod(typeof(CityController), TypeExecute.SearchAll, "ListCity", typeof(City));
            FalecidoFiliacaoCidadeId.FormType = typeof(FCity);

            NatimortoTestemunha1CidadeId.DisplayMember = "CityName";
            NatimortoTestemunha1CidadeId.ValueMember = "Id";
            NatimortoTestemunha1CidadeId.ObjetoApp = new InvokeMethod(typeof(CityController), TypeExecute.SearchAll, "ListCity", typeof(City));
            NatimortoTestemunha1CidadeId.FormType = typeof(FCity);

            NatimortoTestemunha2CidadeId.DisplayMember = "CityName";
            NatimortoTestemunha2CidadeId.ValueMember = "Id";
            NatimortoTestemunha2CidadeId.ObjetoApp = new InvokeMethod(typeof(CityController), TypeExecute.SearchAll, "ListCity", typeof(City));
            NatimortoTestemunha2CidadeId.FormType = typeof(FCity);

            ObitoDeclaranteCidadeId.DisplayMember = "CityName";
            ObitoDeclaranteCidadeId.ValueMember = "Id";
            ObitoDeclaranteCidadeId.ObjetoApp = new InvokeMethod(typeof(CityController), TypeExecute.SearchAll, "ListCity", typeof(City));
            ObitoDeclaranteCidadeId.FormType = typeof(FCity);
            
            ObitoCidadeSepultamentoId.DisplayMember = "CityName";
            ObitoCidadeSepultamentoId.ValueMember = "Id";
            ObitoCidadeSepultamentoId.ObjetoApp = new InvokeMethod(typeof(CityController), TypeExecute.SearchAll, "ListCity", typeof(City));
            ObitoCidadeSepultamentoId.FormType = typeof(FCity);

            ObitoCidadeFalecimentoId.DisplayMember = "CityName";
            ObitoCidadeFalecimentoId.ValueMember = "Id";
            ObitoCidadeFalecimentoId.ObjetoApp = new InvokeMethod(typeof(CityController), TypeExecute.SearchAll, "ListCity", typeof(City));
            ObitoCidadeFalecimentoId.FormType = typeof(FCity);
        }

        public object QueryDadosFalecido(object obj)
        {
            var lista = new List<object>();
            var sDadosFalecido = obj as IQueryable<DataDeceased>;
            if (sDadosFalecido == null) return lista;
            foreach (var dadosFalecido in sDadosFalecido)
            {
                lista.Add((new List<DataDeceased> { dadosFalecido }
                    .Select
                    (
                        objControl => new
                        {
                            objControl.Id,
                            objControl.DataCadastro,
                            objControl.DataAlteracao,
                            objControl.UltimoAcesso,
                            objControl.FalecidoCpf,
                            objControl.FalecidoNascimento,
                            objControl.FalecidoNome,
                            objControl.SObitoAtendente1,
                            objControl.FalecidoBairro,
                            objControl.FalecidoCartorioNupcias,
                            objControl.FalecidoCidade,
                            objControl.FalecidoCor,
                            objControl.FalecidoCidadeTituloEleitor,
                            objControl.FalecidoData,
                            objControl.FalecidoDataNupcias,
                            objControl.FalecidoDeclaracao,
                            objControl.FalecidoDeixaBens,
                            objControl.FalecidoEleitor,
                            objControl.FalecidoEndereco,
                            objControl.FalecidoEstado,
                            objControl.FalecidoEtadoCivil,
                            objControl.FalecidoFilhos,
                            objControl.FalecidoFiliacaoBairro,
                            objControl.FalecidoFiliacaoCidade,
                            objControl.FalecidoFiliacaoEndereco,
                            objControl.FalecidoFiliacaoEstado,
                            objControl.FalecidoFiliacaoMaeDocumento,
                            objControl.FalecidoFiliacaoMaeEtadoCivil,
                            objControl.FalecidoFiliacaoMaeIdade,
                            objControl.FalecidoFiliacaoMaeNatural,
                            objControl.FalecidoFiliacaoNomeMae,
                            objControl.FalecidoFiliacaoNomePai,
                            objControl.FalecidoFiliacaoPaiDocumento,
                            objControl.FalecidoFiliacaoPaiEstadoCivil,
                            objControl.FalecidoFiliacaoPaiIdade,
                            objControl.FalecidoFiliacaoPaiNatural,
                            objControl.FalecidoFolha,
                            objControl.FalecidoInss,
                            objControl.FalecidoInssIdentificacao,
                            objControl.FalecidoLivro,
                            objControl.FalecidoNatural,
                            objControl.FalecidoNomeConjugue,
                            objControl.FalecidoNumero,
                            objControl.FalecidoNomeResponsavelFamilia,
                            objControl.FalecidoNumeroTitulo,
                            objControl.FalecidoObservacao,
                            objControl.FalecidoReservista,
                            objControl.FalecidoRg,
                            objControl.FalecidoSecaoTitulo,
                            objControl.FalecidoSexo,
                            objControl.FalecidoTestamento,
                            objControl.FalecidoTipo,
                            objControl.FalecidoVotava,
                            objControl.FalecidoZonaTitulo,
                            objControl.LocalVelorio,
                            objControl.ObitoAgencia,
                            objControl.ObitoCartorio,
                            objControl.ObitoCausaMorte,
                            objControl.ObitoCidadeFalecimento,
                            objControl.ObitoCidadeSepultamento,
                            objControl.ObitoDataFalecimento,
                            objControl.ObitoDataSepultamento,
                            objControl.ObitoDeclarante,
                            objControl.ObitoDeclaranteCep,
                            objControl.ObitoDeclaranteBairro,
                            objControl.ObitoDeclaranteCidade,
                            objControl.ObitoDeclaranteCpf,
                            objControl.ObitoDeclaranteEndereco,
                            objControl.ObitoDeclaranteEstado,
                            objControl.ObitoDeclaranteGrauParentesco,
                            objControl.ObitoDeclaranteRg,
                            objControl.ObitoDeclaranteTelefone,
                            objControl.ObitoEnderecoCartorio,
                            objControl.ObitoEstadoFalecimento,
                            ObitoEstadoSepultamento = objControl.ObitoEstadoSepultamentoId,
                            objControl.ObitoHoraFalecimento,
                            ObitoHoraSepultamento = objControl.ObitoHoraFalecimento,
                            objControl.ObitoLocalFalecimento,
                            objControl.ObitoLocalSepultamento,
                            objControl.ObitoMedico1,
                            objControl.ObitoMedico1Crm,
                            objControl.ObitoMedico2,
                            objControl.ObitoMedico2Crm,
                            objControl.ObitoNota,
                            objControl.ObitoRespTratamento,
                            objControl.ObitoSala,
                            objControl.SObitoAtendente1?.UserName,
                            Tecnico = Interaction.InputBox("Nome do Técnico: ", "Ata Somatoconservação"),
                            DataTanato = Interaction.InputBox("Data: ", "Ata Somatoconservação", DateTime.Now.ToShortDateString()),
                            HoraTanato = Interaction.InputBox("Hora: ", "Ata Somatoconservação", DateTime.Now.ToShortTimeString())
                        })).FirstOrDefault());
            }

            return lista;
        }

        public object QueryDeclaracaoObito(object obj)
        {
            var lista = new List<object>();
            var sDadosFalecido = obj as IQueryable<DataDeceased>;
            if (sDadosFalecido == null) return lista;
            foreach (var dadosFalecido in sDadosFalecido)
            {
                lista.Add(dadosFalecido);
                lista.Add(dadosFalecido);
                lista.Add(dadosFalecido);
                lista.Add(dadosFalecido);
                lista.Add(dadosFalecido);
            }

            return lista;
        }
    }
}