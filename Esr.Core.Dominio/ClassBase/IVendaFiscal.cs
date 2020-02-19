namespace Esr.Core.Domain.ClassBase
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados
    public interface IVendaFiscal
    {
        #region Outras
        int VerificarImpressoraLigada();
        #endregion

        #region Inicialização
        int AlteraSimboloMoeda(string simboloMoeda);
        int ProgramaAliquota(string aliquota, int icmsIss);
        int NomeiaDepartamento(int indice, string departamento);
        int NomeTotalizadorNaoSujeitoIcms(int indice, string totalizador);
        int LinhasEntreCupons(int linhas);
        int EspacoEntreLinhas(int espacoEntreLinhas);
        int ForcaImpactoAgulhas(int forcaImpacto);
        int ProgramaHorarioVerao();
        int ProgramaArrendodamento();
        int ProgramaTruncamento();
        #endregion

        #region Cupom Fiscal
        int AbreCupom(string cpfCnpj);
        int VendeItem(string codigo, string descricao, string aliquota, string tipoQuantidade, string quantidade, int casasDecimais, string valorUnitario, string tipoDesconto, string desconto);
        int VendeItemDepartamento(string codigo, string descricao, string aliquota, string valorUnitario, string quantidade, string acrescimo, string desconto, string indiceDepartamento, string unidadeMedida);
        int CancelaItemAnterior();
        int CancelaItemGenerico(string numeroItem);
        int CancelaCupom();
        int FechaCupomResumido(string formaPagamento, string mensagem);
        int FechaCupom(string formaPagamento, string acrescimoDesconto, string tipoAcrescimoDesconto, string valorAcrescimoDesconto, string valorPago, string mensagem);
        int IniciaFechamentoCupom(string acrescimoDesconto, string tipoAcrescimoDesconto, string valorAcrescimoDesconto);
        int EfetuaFormaPagamento(string formaPagamento, string valorFormaPagamento);
        int EfetuaFormaPagamentoDescricaoForma(string formaPagamento, string valorFormaPagamento, string descricao);
        int TerminaFechamentoCupom(string mensagem);
        int EstornoFormasPagamento(string formaOrigem, string formaDestino, string valor);
        int AumentaDescricaoItem(string descricao);
        int UsaUnidadeMedida(string unidadeMedida);
        int DescontoSubTotal(string valor);
        int AcrescimoSubTotal(string valor);
        int DescontoItem(string item, string valorAcrescimoDesconto);
        int AcrescimoItem(string item, string valorAcrescimoDesconto);
        int DescontoSubPorcentoTotal(string valor);
        int AcrescimoPorcentoSubTotal(string valor);
        int DescontoPorcentoItem(string item, string valorAcrescimoDesconto);
        int AcrescimoPorcentoItem(string item, string valorAcrescimoDesconto);

        #endregion
    }
}
