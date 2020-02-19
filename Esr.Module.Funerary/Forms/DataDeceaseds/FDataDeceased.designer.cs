using System.Windows.Forms;
using Esr.Core.Component;

namespace Esr.Module.Funerary.Forms.DataDeceaseds
{
    sealed partial class FDataDeceased
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDataDeceased));
            this.geraltoolTip = new System.Windows.Forms.ToolTip();
            this.dadosDoFalecidoTabControl = new Esr.Core.Component.STabControl();
            this.dadosDoFalecidoTabPage = new System.Windows.Forms.TabPage();
            this.dadoTabControl = new Esr.Core.Component.STabControl();
            this.dadosFalecidotabPage = new System.Windows.Forms.TabPage();
            this.FalecidoVotava = new Esr.Core.Component.SComboBox();
            this.FalecidoInss = new Esr.Core.Component.SComboBox();
            this.FalecidoProfissaoId = new Esr.Core.Component.SComboBox();
            this.FalecidoReservista = new Esr.Core.Component.SComboBox();
            this.FalecidoSecaoTitulo = new Esr.Core.Component.STextBox();
            this.FalecidoZonaTitulo = new Esr.Core.Component.STextBox();
            this.FalecidoNumeroTitulo = new Esr.Core.Component.STextBox();
            this.FalecidoCidadeTituloEleitor = new Esr.Core.Component.STextBox();
            this.FalecidoCpf = new Esr.Core.Component.STextBox();
            this.FalecidoRg = new Esr.Core.Component.STextBox();
            this.FalecidoEstadoId = new Esr.Core.Component.SComboBox();
            this.FalecidoCidadeId = new Esr.Core.Component.SComboBox();
            this.FalecidoBairro = new Esr.Core.Component.STextBox();
            this.FalecidoEndereco = new Esr.Core.Component.STextBox();
            this.FalecidoReligiaoId = new Esr.Core.Component.SComboBox();
            this.FalecidoEtadoCivil = new Esr.Core.Component.SComboBox();
            this.FalecidoNatural = new Esr.Core.Component.STextBox();
            this.FalecidoTestamento = new Esr.Core.Component.SComboBox();
            this.FalecidoDeixaBens = new Esr.Core.Component.SComboBox();
            this.FalecidoNascimento = new Esr.Core.Component.SDateTimePicker();
            this.FalecidoCor = new Esr.Core.Component.SComboBox();
            this.FalecidoSexo = new Esr.Core.Component.SComboBox();
            this.FalecidoNome = new Esr.Core.Component.STextBox();
            this.filiacaotabPage = new System.Windows.Forms.TabPage();
            this.FalecidoFiliacaoEstadoId = new Esr.Core.Component.SComboBox();
            this.FalecidoFiliacaoCidadeId = new Esr.Core.Component.SComboBox();
            this.FalecidoFiliacaoBairro = new Esr.Core.Component.STextBox();
            this.FalecidoFiliacaoEndereco = new Esr.Core.Component.STextBox();
            this.FalecidoFiliacaoMaeDocumento = new Esr.Core.Component.STextBox();
            this.FalecidoFiliacaoMaeProfissaoId = new Esr.Core.Component.SComboBox();
            this.FalecidoFiliacaoMaeNatural = new Esr.Core.Component.STextBox();
            this.FalecidoFiliacaoMaeIdade = new Esr.Core.Component.SNumeric();
            this.FalecidoFiliacaoMaeEtadoCivil = new Esr.Core.Component.SComboBox();
            this.FalecidoFiliacaoNomeMae = new Esr.Core.Component.STextBox();
            this.FalecidoFiliacaoPaiDocumento = new Esr.Core.Component.STextBox();
            this.FalecidoFiliacaoPaiProfissaoId = new Esr.Core.Component.SComboBox();
            this.FalecidoFiliacaoPaiNatural = new Esr.Core.Component.STextBox();
            this.FalecidoFiliacaoPaiIdade = new Esr.Core.Component.SNumeric();
            this.FalecidoFiliacaoPaiEstadoCivil = new Esr.Core.Component.SComboBox();
            this.FalecidoFiliacaoNomePai = new Esr.Core.Component.STextBox();
            this.conjuguetabPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FalecidoNumero = new Esr.Core.Component.STextBox();
            this.FalecidoFolha = new Esr.Core.Component.STextBox();
            this.FalecidoLivro = new Esr.Core.Component.STextBox();
            this.FalecidoDataNupcias = new Esr.Core.Component.SDateTimePicker();
            this.FalecidoCartorioNupcias = new Esr.Core.Component.STextBox();
            this.FalecidoNomeConjugue = new Esr.Core.Component.STextBox();
            this.filhosObservacoestabPage = new System.Windows.Forms.TabPage();
            this.panel = new System.Windows.Forms.Panel();
            this.FalecidoObservacao = new Esr.Core.Component.SRichText();
            this.FalecidoFilhos = new Esr.Core.Component.SRichText();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FalecidoData = new Esr.Core.Component.SDateTimePicker();
            this.Id = new Esr.Core.Component.SNumeric();
            this.dadosDoObitoTabPage = new System.Windows.Forms.TabPage();
            this.DadosObitotabControl = new Esr.Core.Component.STabControl();
            this.dadosGeraistabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ObitoEstadoSepultamentoId = new Esr.Core.Component.SComboBox();
            this.ObitoCidadeSepultamentoId = new Esr.Core.Component.SComboBox();
            this.ObitoHoraSepultamento = new Esr.Core.Component.SDateTimePicker();
            this.ObitoDataSepultamento = new Esr.Core.Component.SDateTimePicker();
            this.ObitoLocalSepultamento = new Esr.Core.Component.STextBox();
            this.ObitoEstadoFalecimentoId = new Esr.Core.Component.SComboBox();
            this.ObitoCidadeFalecimentoId = new Esr.Core.Component.SComboBox();
            this.ObitoHoraFalecimento = new Esr.Core.Component.SDateTimePicker();
            this.ObitoDataFalecimento = new Esr.Core.Component.SDateTimePicker();
            this.ObitoLocalFalecimento = new Esr.Core.Component.STextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ObitoCausaMorte = new Esr.Core.Component.SRichText();
            this.ObitoMedico2Crm = new Esr.Core.Component.STextBox();
            this.ObitoMedico2 = new Esr.Core.Component.STextBox();
            this.ObitoMedicoCrm = new Esr.Core.Component.STextBox();
            this.ObitoMedico1 = new Esr.Core.Component.STextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ObitoEnderecoCartorio = new Esr.Core.Component.STextBox();
            this.ObitoNota = new Esr.Core.Component.STextBox();
            this.ObitoCartorio = new Esr.Core.Component.STextBox();
            this.ObitoAgencia = new Esr.Core.Component.STextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ObitoDeclaranteTelefone = new Esr.Core.Component.STextBox();
            this.ObitoDeclaranteEstadoId = new Esr.Core.Component.SComboBox();
            this.ObitoDeclaranteCidadeId = new Esr.Core.Component.SComboBox();
            this.ObitoDeclaranteBairro = new Esr.Core.Component.STextBox();
            this.ObitoDeclaranteEndereco = new Esr.Core.Component.STextBox();
            this.ObitoDeclaranteCep = new Esr.Core.Component.STextBox();
            this.ObitoDeclaranteProfissaoId = new Esr.Core.Component.SComboBox();
            this.ObitoDeclaranteGrauParentesco = new Esr.Core.Component.STextBox();
            this.ObitoDeclaranteCpf = new Esr.Core.Component.STextBox();
            this.ObitoDeclaranteRg = new Esr.Core.Component.STextBox();
            this.ObitoDeclarante = new Esr.Core.Component.STextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.SObitoAtendente2Id = new Esr.Core.Component.SComboBox();
            this.SObitoAtendente1Id = new Esr.Core.Component.SComboBox();
            this.DadosNatimortoTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new Esr.Core.Component.STabControl();
            this.dadosNatMortoTabPage = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.NatimortoHoraNascimento = new Esr.Core.Component.SDateTimePicker();
            this.NatimortoIdade = new Esr.Core.Component.SNumeric();
            this.NatimortoAvosMaternos = new Esr.Core.Component.STextBox();
            this.NatimortoAvosPaternos = new Esr.Core.Component.STextBox();
            this.NatimortoDuracao = new Esr.Core.Component.SComboBox();
            this.NatimortoGestao = new Esr.Core.Component.SComboBox();
            this.NatimortoLocalNascimento = new Esr.Core.Component.STextBox();
            this.NatimortoDescIdade = new Esr.Core.Component.SNumeric();
            this.testemunhasTabPage = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.NatimortoTestemunha2EstadoId = new Esr.Core.Component.SComboBox();
            this.NatimortoTestemunha2Idade = new Esr.Core.Component.SNumeric();
            this.NatimortoTestemunha2CidadeId = new Esr.Core.Component.SComboBox();
            this.NatimortoTestemunha2Bairro = new Esr.Core.Component.STextBox();
            this.NatimortoTestemunha2Endereco = new Esr.Core.Component.STextBox();
            this.NatimortoTestemunha2EstadoIdCivil = new Esr.Core.Component.SComboBox();
            this.NatimortoTestemunha2Nascionalidade = new Esr.Core.Component.STextBox();
            this.NatimortoTestemunha2ProfissaoId = new Esr.Core.Component.SComboBox();
            this.NatimortoTestemunha2Documento = new Esr.Core.Component.STextBox();
            this.NatimortoTestemunha2Nome = new Esr.Core.Component.STextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.NatimortoTestemunha1EstadoId = new Esr.Core.Component.SComboBox();
            this.NatimortoTestemunha1Idade = new Esr.Core.Component.SNumeric();
            this.NatimortoTestemunha1CidadeId = new Esr.Core.Component.SComboBox();
            this.NatimortoTestemunha1Bairro = new Esr.Core.Component.STextBox();
            this.NatimortoTestemunha1Endereco = new Esr.Core.Component.STextBox();
            this.NatimortoTestemunha1EstadoCivil = new Esr.Core.Component.SComboBox();
            this.NatimortoTestemunha1Nascionalidade = new Esr.Core.Component.STextBox();
            this.NatimortoTestemunha1ProfissaoId = new Esr.Core.Component.SComboBox();
            this.NatimortoTestemunha1Documento = new Esr.Core.Component.STextBox();
            this.NatimortoTestemunha1Nome = new Esr.Core.Component.STextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.dadosDoFalecidoTabControl.SuspendLayout();
            this.dadosDoFalecidoTabPage.SuspendLayout();
            this.dadoTabControl.SuspendLayout();
            this.dadosFalecidotabPage.SuspendLayout();
            this.filiacaotabPage.SuspendLayout();
            this.conjuguetabPage.SuspendLayout();
            this.panel4.SuspendLayout();
            this.filhosObservacoestabPage.SuspendLayout();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.dadosDoObitoTabPage.SuspendLayout();
            this.DadosObitotabControl.SuspendLayout();
            this.dadosGeraistabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.DadosNatimortoTabPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.dadosNatMortoTabPage.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.testemunhasTabPage.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dadosDoFalecidoTabControl);
            this.panel1.Size = new System.Drawing.Size(1075, 523);
            // 
            // geraltoolTip
            // 
            this.geraltoolTip.ToolTipTitle = "Inserir novo filho.";
            // 
            // dadosDoFalecidoTabControl
            // 
            this.dadosDoFalecidoTabControl.Controls.Add(this.dadosDoFalecidoTabPage);
            this.dadosDoFalecidoTabControl.Controls.Add(this.dadosDoObitoTabPage);
            this.dadosDoFalecidoTabControl.Controls.Add(this.DadosNatimortoTabPage);
            this.dadosDoFalecidoTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dadosDoFalecidoTabControl.Location = new System.Drawing.Point(0, 0);
            this.dadosDoFalecidoTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dadosDoFalecidoTabControl.Name = "dadosDoFalecidoTabControl";
            this.dadosDoFalecidoTabControl.SelectedIndex = 0;
            this.dadosDoFalecidoTabControl.Size = new System.Drawing.Size(1075, 523);
            this.dadosDoFalecidoTabControl.TabIndex = 7;
            // 
            // dadosDoFalecidoTabPage
            // 
            this.dadosDoFalecidoTabPage.BackColor = System.Drawing.Color.White;
            this.dadosDoFalecidoTabPage.Controls.Add(this.dadoTabControl);
            this.dadosDoFalecidoTabPage.Controls.Add(this.groupBox1);
            this.dadosDoFalecidoTabPage.Location = new System.Drawing.Point(4, 30);
            this.dadosDoFalecidoTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dadosDoFalecidoTabPage.Name = "dadosDoFalecidoTabPage";
            this.dadosDoFalecidoTabPage.Size = new System.Drawing.Size(1067, 489);
            this.dadosDoFalecidoTabPage.TabIndex = 0;
            this.dadosDoFalecidoTabPage.Text = "DADOS DO FALECIDO";
            // 
            // dadoTabControl
            // 
            this.dadoTabControl.Controls.Add(this.dadosFalecidotabPage);
            this.dadoTabControl.Controls.Add(this.filiacaotabPage);
            this.dadoTabControl.Controls.Add(this.conjuguetabPage);
            this.dadoTabControl.Controls.Add(this.filhosObservacoestabPage);
            this.dadoTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dadoTabControl.Location = new System.Drawing.Point(0, 101);
            this.dadoTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dadoTabControl.Name = "dadoTabControl";
            this.dadoTabControl.SelectedIndex = 0;
            this.dadoTabControl.Size = new System.Drawing.Size(1067, 388);
            this.dadoTabControl.TabIndex = 93;
            // 
            // dadosFalecidotabPage
            // 
            this.dadosFalecidotabPage.BackColor = System.Drawing.Color.White;
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoVotava);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoInss);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoProfissaoId);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoReservista);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoSecaoTitulo);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoZonaTitulo);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoNumeroTitulo);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoCidadeTituloEleitor);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoCpf);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoRg);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoEstadoId);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoCidadeId);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoBairro);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoEndereco);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoReligiaoId);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoEtadoCivil);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoNatural);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoTestamento);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoDeixaBens);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoNascimento);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoCor);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoSexo);
            this.dadosFalecidotabPage.Controls.Add(this.FalecidoNome);
            this.dadosFalecidotabPage.Location = new System.Drawing.Point(4, 30);
            this.dadosFalecidotabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dadosFalecidotabPage.Name = "dadosFalecidotabPage";
            this.dadosFalecidotabPage.Size = new System.Drawing.Size(1059, 354);
            this.dadosFalecidotabPage.TabIndex = 0;
            this.dadosFalecidotabPage.Text = "Dados do Falecido";
            // 
            // FalecidoVotava
            // 
            this.FalecidoVotava.Caption = "";
            this.FalecidoVotava.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoVotava.CenterCaption = false;
            this.FalecidoVotava.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoVotava.DefaultValue = false;
            this.FalecidoVotava.Disable = true;
            this.FalecidoVotava.DisplayMember = "";
            this.FalecidoVotava.FieldValid = true;
            this.FalecidoVotava.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoVotava.Form = null;
            this.FalecidoVotava.FormType = null;
            this.FalecidoVotava.IsDependecyUkey = false;
            this.FalecidoVotava.Location = new System.Drawing.Point(315, 138);
            this.FalecidoVotava.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoVotava.Name = "FalecidoVotava";
            this.FalecidoVotava.ObjectControl = null;
            this.FalecidoVotava.ObjetoApp = null;
            this.FalecidoVotava.PropertyControl = null;
            this.FalecidoVotava.PropertyDependecyUkey = null;
            this.FalecidoVotava.Size = new System.Drawing.Size(90, 54);
            this.FalecidoVotava.StandardValue = null;
            this.FalecidoVotava.TabIndex = 154;
            this.FalecidoVotava.TabStop = false;
            this.FalecidoVotava.ToolTipContext = null;
            this.FalecidoVotava.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoVotava.Validations")));
            this.FalecidoVotava.ValueControl = null;
            this.FalecidoVotava.ValueMember = "";
            // 
            // FalecidoInss
            // 
            this.FalecidoInss.Caption = "";
            this.FalecidoInss.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoInss.CenterCaption = false;
            this.FalecidoInss.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoInss.DefaultValue = false;
            this.FalecidoInss.Disable = true;
            this.FalecidoInss.DisplayMember = "";
            this.FalecidoInss.FieldValid = true;
            this.FalecidoInss.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoInss.Form = null;
            this.FalecidoInss.FormType = null;
            this.FalecidoInss.IsDependecyUkey = false;
            this.FalecidoInss.Location = new System.Drawing.Point(217, 138);
            this.FalecidoInss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoInss.Name = "FalecidoInss";
            this.FalecidoInss.ObjectControl = null;
            this.FalecidoInss.ObjetoApp = null;
            this.FalecidoInss.PropertyControl = null;
            this.FalecidoInss.PropertyDependecyUkey = null;
            this.FalecidoInss.Size = new System.Drawing.Size(90, 54);
            this.FalecidoInss.StandardValue = null;
            this.FalecidoInss.TabIndex = 151;
            this.FalecidoInss.TabStop = false;
            this.FalecidoInss.ToolTipContext = null;
            this.FalecidoInss.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoInss.Validations")));
            this.FalecidoInss.ValueControl = null;
            this.FalecidoInss.ValueMember = "";
            // 
            // FalecidoProfissaoId
            // 
            this.FalecidoProfissaoId.Caption = "";
            this.FalecidoProfissaoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoProfissaoId.CenterCaption = false;
            this.FalecidoProfissaoId.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoProfissaoId.DefaultValue = false;
            this.FalecidoProfissaoId.Disable = true;
            this.FalecidoProfissaoId.DisplayMember = "";
            this.FalecidoProfissaoId.FieldValid = true;
            this.FalecidoProfissaoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoProfissaoId.Form = null;
            this.FalecidoProfissaoId.FormType = null;
            this.FalecidoProfissaoId.IsDependecyUkey = false;
            this.FalecidoProfissaoId.Location = new System.Drawing.Point(301, 202);
            this.FalecidoProfissaoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoProfissaoId.Name = "FalecidoProfissaoId";
            this.FalecidoProfissaoId.ObjectControl = null;
            this.FalecidoProfissaoId.ObjetoApp = null;
            this.FalecidoProfissaoId.PropertyControl = null;
            this.FalecidoProfissaoId.PropertyDependecyUkey = null;
            this.FalecidoProfissaoId.Size = new System.Drawing.Size(220, 54);
            this.FalecidoProfissaoId.StandardValue = null;
            this.FalecidoProfissaoId.TabIndex = 105;
            this.FalecidoProfissaoId.TabStop = false;
            this.FalecidoProfissaoId.ToolTipContext = null;
            this.FalecidoProfissaoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoProfissaoId.Validations")));
            this.FalecidoProfissaoId.ValueControl = null;
            this.FalecidoProfissaoId.ValueMember = "";
            // 
            // FalecidoReservista
            // 
            this.FalecidoReservista.Caption = "";
            this.FalecidoReservista.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoReservista.CenterCaption = false;
            this.FalecidoReservista.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoReservista.DefaultValue = false;
            this.FalecidoReservista.Disable = true;
            this.FalecidoReservista.DisplayMember = "";
            this.FalecidoReservista.FieldValid = true;
            this.FalecidoReservista.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoReservista.Form = null;
            this.FalecidoReservista.FormType = null;
            this.FalecidoReservista.IsDependecyUkey = false;
            this.FalecidoReservista.Location = new System.Drawing.Point(185, 202);
            this.FalecidoReservista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoReservista.Name = "FalecidoReservista";
            this.FalecidoReservista.ObjectControl = null;
            this.FalecidoReservista.ObjetoApp = null;
            this.FalecidoReservista.PropertyControl = null;
            this.FalecidoReservista.PropertyDependecyUkey = null;
            this.FalecidoReservista.Size = new System.Drawing.Size(108, 54);
            this.FalecidoReservista.StandardValue = null;
            this.FalecidoReservista.TabIndex = 100;
            this.FalecidoReservista.TabStop = false;
            this.FalecidoReservista.ToolTipContext = null;
            this.FalecidoReservista.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoReservista.Validations")));
            this.FalecidoReservista.ValueControl = null;
            this.FalecidoReservista.ValueMember = "";
            // 
            // FalecidoSecaoTitulo
            // 
            this.FalecidoSecaoTitulo.Caption = "";
            this.FalecidoSecaoTitulo.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoSecaoTitulo.CenterCaption = false;
            this.FalecidoSecaoTitulo.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoSecaoTitulo.Disable = true;
            this.FalecidoSecaoTitulo.FieldValid = true;
            this.FalecidoSecaoTitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoSecaoTitulo.Form = null;
            this.FalecidoSecaoTitulo.FormType = null;
            this.FalecidoSecaoTitulo.IsDependecyUkey = false;
            this.FalecidoSecaoTitulo.Location = new System.Drawing.Point(98, 202);
            this.FalecidoSecaoTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoSecaoTitulo.Name = "FalecidoSecaoTitulo";
            this.FalecidoSecaoTitulo.ObjectControl = null;
            this.FalecidoSecaoTitulo.ObjetoApp = null;
            this.FalecidoSecaoTitulo.PropertyControl = null;
            this.FalecidoSecaoTitulo.PropertyDependecyUkey = null;
            this.FalecidoSecaoTitulo.Size = new System.Drawing.Size(82, 54);
            this.FalecidoSecaoTitulo.TabIndex = 98;
            this.FalecidoSecaoTitulo.TabStop = false;
            this.FalecidoSecaoTitulo.ToolTipContext = null;
            this.FalecidoSecaoTitulo.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoSecaoTitulo.Validations")));
            this.FalecidoSecaoTitulo.ValueControl = "";
            // 
            // FalecidoZonaTitulo
            // 
            this.FalecidoZonaTitulo.Caption = "";
            this.FalecidoZonaTitulo.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoZonaTitulo.CenterCaption = false;
            this.FalecidoZonaTitulo.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoZonaTitulo.Disable = true;
            this.FalecidoZonaTitulo.FieldValid = true;
            this.FalecidoZonaTitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoZonaTitulo.Form = null;
            this.FalecidoZonaTitulo.FormType = null;
            this.FalecidoZonaTitulo.IsDependecyUkey = false;
            this.FalecidoZonaTitulo.Location = new System.Drawing.Point(8, 202);
            this.FalecidoZonaTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoZonaTitulo.Name = "FalecidoZonaTitulo";
            this.FalecidoZonaTitulo.ObjectControl = null;
            this.FalecidoZonaTitulo.ObjetoApp = null;
            this.FalecidoZonaTitulo.PropertyControl = null;
            this.FalecidoZonaTitulo.PropertyDependecyUkey = null;
            this.FalecidoZonaTitulo.Size = new System.Drawing.Size(86, 54);
            this.FalecidoZonaTitulo.TabIndex = 96;
            this.FalecidoZonaTitulo.TabStop = false;
            this.FalecidoZonaTitulo.ToolTipContext = null;
            this.FalecidoZonaTitulo.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoZonaTitulo.Validations")));
            this.FalecidoZonaTitulo.ValueControl = "";
            // 
            // FalecidoNumeroTitulo
            // 
            this.FalecidoNumeroTitulo.Caption = "";
            this.FalecidoNumeroTitulo.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoNumeroTitulo.CenterCaption = false;
            this.FalecidoNumeroTitulo.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoNumeroTitulo.Disable = true;
            this.FalecidoNumeroTitulo.FieldValid = true;
            this.FalecidoNumeroTitulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoNumeroTitulo.Form = null;
            this.FalecidoNumeroTitulo.FormType = null;
            this.FalecidoNumeroTitulo.IsDependecyUkey = false;
            this.FalecidoNumeroTitulo.Location = new System.Drawing.Point(902, 138);
            this.FalecidoNumeroTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoNumeroTitulo.Name = "FalecidoNumeroTitulo";
            this.FalecidoNumeroTitulo.ObjectControl = null;
            this.FalecidoNumeroTitulo.ObjetoApp = null;
            this.FalecidoNumeroTitulo.PropertyControl = null;
            this.FalecidoNumeroTitulo.PropertyDependecyUkey = null;
            this.FalecidoNumeroTitulo.Size = new System.Drawing.Size(133, 54);
            this.FalecidoNumeroTitulo.TabIndex = 94;
            this.FalecidoNumeroTitulo.TabStop = false;
            this.FalecidoNumeroTitulo.ToolTipContext = null;
            this.FalecidoNumeroTitulo.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoNumeroTitulo.Validations")));
            this.FalecidoNumeroTitulo.ValueControl = "";
            // 
            // FalecidoCidadeTituloEleitor
            // 
            this.FalecidoCidadeTituloEleitor.Caption = "";
            this.FalecidoCidadeTituloEleitor.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoCidadeTituloEleitor.CenterCaption = false;
            this.FalecidoCidadeTituloEleitor.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoCidadeTituloEleitor.Disable = true;
            this.FalecidoCidadeTituloEleitor.FieldValid = true;
            this.FalecidoCidadeTituloEleitor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoCidadeTituloEleitor.Form = null;
            this.FalecidoCidadeTituloEleitor.FormType = null;
            this.FalecidoCidadeTituloEleitor.IsDependecyUkey = false;
            this.FalecidoCidadeTituloEleitor.Location = new System.Drawing.Point(413, 138);
            this.FalecidoCidadeTituloEleitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoCidadeTituloEleitor.Name = "FalecidoCidadeTituloEleitor";
            this.FalecidoCidadeTituloEleitor.ObjectControl = null;
            this.FalecidoCidadeTituloEleitor.ObjetoApp = null;
            this.FalecidoCidadeTituloEleitor.PropertyControl = null;
            this.FalecidoCidadeTituloEleitor.PropertyDependecyUkey = null;
            this.FalecidoCidadeTituloEleitor.Size = new System.Drawing.Size(481, 54);
            this.FalecidoCidadeTituloEleitor.TabIndex = 92;
            this.FalecidoCidadeTituloEleitor.TabStop = false;
            this.FalecidoCidadeTituloEleitor.ToolTipContext = null;
            this.FalecidoCidadeTituloEleitor.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoCidadeTituloEleitor.Validations")));
            this.FalecidoCidadeTituloEleitor.ValueControl = "";
            // 
            // FalecidoCpf
            // 
            this.FalecidoCpf.Caption = "";
            this.FalecidoCpf.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoCpf.CenterCaption = false;
            this.FalecidoCpf.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoCpf.Disable = true;
            this.FalecidoCpf.FieldValid = true;
            this.FalecidoCpf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoCpf.Form = null;
            this.FalecidoCpf.FormType = null;
            this.FalecidoCpf.IsDependecyUkey = false;
            this.FalecidoCpf.Location = new System.Drawing.Point(8, 138);
            this.FalecidoCpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoCpf.Name = "FalecidoCpf";
            this.FalecidoCpf.ObjectControl = null;
            this.FalecidoCpf.ObjetoApp = null;
            this.FalecidoCpf.PropertyControl = null;
            this.FalecidoCpf.PropertyDependecyUkey = null;
            this.FalecidoCpf.Size = new System.Drawing.Size(201, 54);
            this.FalecidoCpf.TabIndex = 90;
            this.FalecidoCpf.TabStop = false;
            this.FalecidoCpf.ToolTipContext = null;
            this.FalecidoCpf.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoCpf.Validations")));
            this.FalecidoCpf.ValueControl = "";
            // 
            // FalecidoRg
            // 
            this.FalecidoRg.Caption = "";
            this.FalecidoRg.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoRg.CenterCaption = false;
            this.FalecidoRg.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoRg.Disable = true;
            this.FalecidoRg.FieldValid = true;
            this.FalecidoRg.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoRg.Form = null;
            this.FalecidoRg.FormType = null;
            this.FalecidoRg.IsDependecyUkey = false;
            this.FalecidoRg.Location = new System.Drawing.Point(793, 74);
            this.FalecidoRg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoRg.Name = "FalecidoRg";
            this.FalecidoRg.ObjectControl = null;
            this.FalecidoRg.ObjetoApp = null;
            this.FalecidoRg.PropertyControl = null;
            this.FalecidoRg.PropertyDependecyUkey = null;
            this.FalecidoRg.Size = new System.Drawing.Size(242, 54);
            this.FalecidoRg.TabIndex = 88;
            this.FalecidoRg.TabStop = false;
            this.FalecidoRg.ToolTipContext = null;
            this.FalecidoRg.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoRg.Validations")));
            this.FalecidoRg.ValueControl = "";
            // 
            // FalecidoEstadoId
            // 
            this.FalecidoEstadoId.Caption = "";
            this.FalecidoEstadoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoEstadoId.CenterCaption = false;
            this.FalecidoEstadoId.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoEstadoId.DefaultValue = false;
            this.FalecidoEstadoId.Disable = true;
            this.FalecidoEstadoId.DisplayMember = "";
            this.FalecidoEstadoId.FieldValid = true;
            this.FalecidoEstadoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoEstadoId.Form = null;
            this.FalecidoEstadoId.FormType = null;
            this.FalecidoEstadoId.IsDependecyUkey = false;
            this.FalecidoEstadoId.Location = new System.Drawing.Point(958, 266);
            this.FalecidoEstadoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoEstadoId.Name = "FalecidoEstadoId";
            this.FalecidoEstadoId.ObjectControl = null;
            this.FalecidoEstadoId.ObjetoApp = null;
            this.FalecidoEstadoId.PropertyControl = null;
            this.FalecidoEstadoId.PropertyDependecyUkey = null;
            this.FalecidoEstadoId.Size = new System.Drawing.Size(77, 54);
            this.FalecidoEstadoId.StandardValue = null;
            this.FalecidoEstadoId.TabIndex = 86;
            this.FalecidoEstadoId.TabStop = false;
            this.FalecidoEstadoId.ToolTipContext = null;
            this.FalecidoEstadoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoEstadoId.Validations")));
            this.FalecidoEstadoId.ValueControl = null;
            this.FalecidoEstadoId.ValueMember = "";
            // 
            // FalecidoCidadeId
            // 
            this.FalecidoCidadeId.Caption = "";
            this.FalecidoCidadeId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoCidadeId.CenterCaption = false;
            this.FalecidoCidadeId.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoCidadeId.DefaultValue = false;
            this.FalecidoCidadeId.Disable = true;
            this.FalecidoCidadeId.DisplayMember = "";
            this.FalecidoCidadeId.FieldValid = true;
            this.FalecidoCidadeId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoCidadeId.Form = null;
            this.FalecidoCidadeId.FormType = null;
            this.FalecidoCidadeId.IsDependecyUkey = false;
            this.FalecidoCidadeId.Location = new System.Drawing.Point(492, 266);
            this.FalecidoCidadeId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoCidadeId.Name = "FalecidoCidadeId";
            this.FalecidoCidadeId.ObjectControl = null;
            this.FalecidoCidadeId.ObjetoApp = null;
            this.FalecidoCidadeId.PropertyControl = null;
            this.FalecidoCidadeId.PropertyDependecyUkey = null;
            this.FalecidoCidadeId.Size = new System.Drawing.Size(458, 54);
            this.FalecidoCidadeId.StandardValue = null;
            this.FalecidoCidadeId.TabIndex = 83;
            this.FalecidoCidadeId.TabStop = false;
            this.FalecidoCidadeId.ToolTipContext = null;
            this.FalecidoCidadeId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoCidadeId.Validations")));
            this.FalecidoCidadeId.ValueControl = null;
            this.FalecidoCidadeId.ValueMember = "";
            // 
            // FalecidoBairro
            // 
            this.FalecidoBairro.Caption = "";
            this.FalecidoBairro.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoBairro.CenterCaption = false;
            this.FalecidoBairro.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoBairro.Disable = true;
            this.FalecidoBairro.FieldValid = true;
            this.FalecidoBairro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoBairro.Form = null;
            this.FalecidoBairro.FormType = null;
            this.FalecidoBairro.IsDependecyUkey = false;
            this.FalecidoBairro.Location = new System.Drawing.Point(8, 266);
            this.FalecidoBairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoBairro.Name = "FalecidoBairro";
            this.FalecidoBairro.ObjectControl = null;
            this.FalecidoBairro.ObjetoApp = null;
            this.FalecidoBairro.PropertyControl = null;
            this.FalecidoBairro.PropertyDependecyUkey = null;
            this.FalecidoBairro.Size = new System.Drawing.Size(476, 54);
            this.FalecidoBairro.TabIndex = 81;
            this.FalecidoBairro.TabStop = false;
            this.FalecidoBairro.ToolTipContext = null;
            this.FalecidoBairro.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoBairro.Validations")));
            this.FalecidoBairro.ValueControl = "";
            // 
            // FalecidoEndereco
            // 
            this.FalecidoEndereco.Caption = "";
            this.FalecidoEndereco.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoEndereco.CenterCaption = false;
            this.FalecidoEndereco.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoEndereco.Disable = true;
            this.FalecidoEndereco.FieldValid = true;
            this.FalecidoEndereco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoEndereco.Form = null;
            this.FalecidoEndereco.FormType = null;
            this.FalecidoEndereco.IsDependecyUkey = false;
            this.FalecidoEndereco.Location = new System.Drawing.Point(529, 202);
            this.FalecidoEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoEndereco.Name = "FalecidoEndereco";
            this.FalecidoEndereco.ObjectControl = null;
            this.FalecidoEndereco.ObjetoApp = null;
            this.FalecidoEndereco.PropertyControl = null;
            this.FalecidoEndereco.PropertyDependecyUkey = null;
            this.FalecidoEndereco.Size = new System.Drawing.Size(506, 54);
            this.FalecidoEndereco.TabIndex = 79;
            this.FalecidoEndereco.TabStop = false;
            this.FalecidoEndereco.ToolTipContext = null;
            this.FalecidoEndereco.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoEndereco.Validations")));
            this.FalecidoEndereco.ValueControl = "";
            // 
            // FalecidoReligiaoId
            // 
            this.FalecidoReligiaoId.Caption = "";
            this.FalecidoReligiaoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoReligiaoId.CenterCaption = false;
            this.FalecidoReligiaoId.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoReligiaoId.DefaultValue = false;
            this.FalecidoReligiaoId.Disable = true;
            this.FalecidoReligiaoId.DisplayMember = "";
            this.FalecidoReligiaoId.FieldValid = true;
            this.FalecidoReligiaoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoReligiaoId.Form = null;
            this.FalecidoReligiaoId.FormType = null;
            this.FalecidoReligiaoId.IsDependecyUkey = false;
            this.FalecidoReligiaoId.Location = new System.Drawing.Point(533, 74);
            this.FalecidoReligiaoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoReligiaoId.Name = "FalecidoReligiaoId";
            this.FalecidoReligiaoId.ObjectControl = null;
            this.FalecidoReligiaoId.ObjetoApp = null;
            this.FalecidoReligiaoId.PropertyControl = null;
            this.FalecidoReligiaoId.PropertyDependecyUkey = null;
            this.FalecidoReligiaoId.Size = new System.Drawing.Size(252, 54);
            this.FalecidoReligiaoId.StandardValue = null;
            this.FalecidoReligiaoId.TabIndex = 77;
            this.FalecidoReligiaoId.TabStop = false;
            this.FalecidoReligiaoId.ToolTipContext = null;
            this.FalecidoReligiaoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoReligiaoId.Validations")));
            this.FalecidoReligiaoId.ValueControl = null;
            this.FalecidoReligiaoId.ValueMember = "";
            // 
            // FalecidoEtadoCivil
            // 
            this.FalecidoEtadoCivil.Caption = "";
            this.FalecidoEtadoCivil.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoEtadoCivil.CenterCaption = false;
            this.FalecidoEtadoCivil.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoEtadoCivil.DefaultValue = false;
            this.FalecidoEtadoCivil.Disable = true;
            this.FalecidoEtadoCivil.DisplayMember = "";
            this.FalecidoEtadoCivil.FieldValid = true;
            this.FalecidoEtadoCivil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoEtadoCivil.Form = null;
            this.FalecidoEtadoCivil.FormType = null;
            this.FalecidoEtadoCivil.IsDependecyUkey = false;
            this.FalecidoEtadoCivil.Location = new System.Drawing.Point(432, 74);
            this.FalecidoEtadoCivil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoEtadoCivil.Name = "FalecidoEtadoCivil";
            this.FalecidoEtadoCivil.ObjectControl = null;
            this.FalecidoEtadoCivil.ObjetoApp = null;
            this.FalecidoEtadoCivil.PropertyControl = null;
            this.FalecidoEtadoCivil.PropertyDependecyUkey = null;
            this.FalecidoEtadoCivil.Size = new System.Drawing.Size(93, 54);
            this.FalecidoEtadoCivil.StandardValue = null;
            this.FalecidoEtadoCivil.TabIndex = 74;
            this.FalecidoEtadoCivil.TabStop = false;
            this.FalecidoEtadoCivil.ToolTipContext = null;
            this.FalecidoEtadoCivil.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoEtadoCivil.Validations")));
            this.FalecidoEtadoCivil.ValueControl = null;
            this.FalecidoEtadoCivil.ValueMember = "";
            // 
            // FalecidoNatural
            // 
            this.FalecidoNatural.Caption = "";
            this.FalecidoNatural.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoNatural.CenterCaption = false;
            this.FalecidoNatural.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoNatural.Disable = true;
            this.FalecidoNatural.FieldValid = true;
            this.FalecidoNatural.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoNatural.Form = null;
            this.FalecidoNatural.FormType = null;
            this.FalecidoNatural.IsDependecyUkey = false;
            this.FalecidoNatural.Location = new System.Drawing.Point(206, 74);
            this.FalecidoNatural.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoNatural.Name = "FalecidoNatural";
            this.FalecidoNatural.ObjectControl = null;
            this.FalecidoNatural.ObjetoApp = null;
            this.FalecidoNatural.PropertyControl = null;
            this.FalecidoNatural.PropertyDependecyUkey = null;
            this.FalecidoNatural.Size = new System.Drawing.Size(218, 54);
            this.FalecidoNatural.TabIndex = 71;
            this.FalecidoNatural.TabStop = false;
            this.FalecidoNatural.ToolTipContext = null;
            this.FalecidoNatural.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoNatural.Validations")));
            this.FalecidoNatural.ValueControl = "";
            // 
            // FalecidoTestamento
            // 
            this.FalecidoTestamento.Caption = "";
            this.FalecidoTestamento.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoTestamento.CenterCaption = false;
            this.FalecidoTestamento.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoTestamento.DefaultValue = false;
            this.FalecidoTestamento.Disable = true;
            this.FalecidoTestamento.DisplayMember = "";
            this.FalecidoTestamento.FieldValid = true;
            this.FalecidoTestamento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoTestamento.Form = null;
            this.FalecidoTestamento.FormType = null;
            this.FalecidoTestamento.IsDependecyUkey = false;
            this.FalecidoTestamento.Location = new System.Drawing.Point(106, 74);
            this.FalecidoTestamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoTestamento.Name = "FalecidoTestamento";
            this.FalecidoTestamento.ObjectControl = null;
            this.FalecidoTestamento.ObjetoApp = null;
            this.FalecidoTestamento.PropertyControl = null;
            this.FalecidoTestamento.PropertyDependecyUkey = null;
            this.FalecidoTestamento.Size = new System.Drawing.Size(92, 54);
            this.FalecidoTestamento.StandardValue = null;
            this.FalecidoTestamento.TabIndex = 69;
            this.FalecidoTestamento.TabStop = false;
            this.FalecidoTestamento.ToolTipContext = null;
            this.FalecidoTestamento.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoTestamento.Validations")));
            this.FalecidoTestamento.ValueControl = null;
            this.FalecidoTestamento.ValueMember = "";
            // 
            // FalecidoDeixaBens
            // 
            this.FalecidoDeixaBens.Caption = "";
            this.FalecidoDeixaBens.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoDeixaBens.CenterCaption = false;
            this.FalecidoDeixaBens.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoDeixaBens.DefaultValue = false;
            this.FalecidoDeixaBens.Disable = true;
            this.FalecidoDeixaBens.DisplayMember = "";
            this.FalecidoDeixaBens.FieldValid = true;
            this.FalecidoDeixaBens.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoDeixaBens.Form = null;
            this.FalecidoDeixaBens.FormType = null;
            this.FalecidoDeixaBens.IsDependecyUkey = false;
            this.FalecidoDeixaBens.Location = new System.Drawing.Point(8, 74);
            this.FalecidoDeixaBens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoDeixaBens.Name = "FalecidoDeixaBens";
            this.FalecidoDeixaBens.ObjectControl = null;
            this.FalecidoDeixaBens.ObjetoApp = null;
            this.FalecidoDeixaBens.PropertyControl = null;
            this.FalecidoDeixaBens.PropertyDependecyUkey = null;
            this.FalecidoDeixaBens.Size = new System.Drawing.Size(90, 54);
            this.FalecidoDeixaBens.StandardValue = null;
            this.FalecidoDeixaBens.TabIndex = 66;
            this.FalecidoDeixaBens.TabStop = false;
            this.FalecidoDeixaBens.ToolTipContext = null;
            this.FalecidoDeixaBens.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoDeixaBens.Validations")));
            this.FalecidoDeixaBens.ValueControl = null;
            this.FalecidoDeixaBens.ValueMember = "";
            // 
            // FalecidoNascimento
            // 
            this.FalecidoNascimento.Caption = "";
            this.FalecidoNascimento.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoNascimento.CenterCaption = false;
            this.FalecidoNascimento.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoNascimento.CustomFormat = null;
            this.FalecidoNascimento.Disable = true;
            this.FalecidoNascimento.FieldValid = true;
            this.FalecidoNascimento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoNascimento.Form = null;
            this.FalecidoNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FalecidoNascimento.FormType = null;
            this.FalecidoNascimento.IsDependecyUkey = false;
            this.FalecidoNascimento.Location = new System.Drawing.Point(901, 10);
            this.FalecidoNascimento.Name = "FalecidoNascimento";
            this.FalecidoNascimento.ObjectControl = null;
            this.FalecidoNascimento.ObjetoApp = null;
            this.FalecidoNascimento.PropertyControl = null;
            this.FalecidoNascimento.PropertyDependecyUkey = null;
            this.FalecidoNascimento.Size = new System.Drawing.Size(134, 54);
            this.FalecidoNascimento.TabIndex = 62;
            this.FalecidoNascimento.TabStop = false;
            this.FalecidoNascimento.ToolTipContext = null;
            this.FalecidoNascimento.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoNascimento.Validations")));
            this.FalecidoNascimento.ValueControl = new System.DateTime(2016, 12, 31, 15, 9, 22, 928);
            // 
            // FalecidoCor
            // 
            this.FalecidoCor.Caption = "";
            this.FalecidoCor.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoCor.CenterCaption = false;
            this.FalecidoCor.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoCor.DefaultValue = false;
            this.FalecidoCor.Disable = true;
            this.FalecidoCor.DisplayMember = "";
            this.FalecidoCor.FieldValid = true;
            this.FalecidoCor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoCor.Form = null;
            this.FalecidoCor.FormType = null;
            this.FalecidoCor.IsDependecyUkey = false;
            this.FalecidoCor.Location = new System.Drawing.Point(788, 10);
            this.FalecidoCor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoCor.Name = "FalecidoCor";
            this.FalecidoCor.ObjectControl = null;
            this.FalecidoCor.ObjetoApp = null;
            this.FalecidoCor.PropertyControl = null;
            this.FalecidoCor.PropertyDependecyUkey = null;
            this.FalecidoCor.Size = new System.Drawing.Size(106, 54);
            this.FalecidoCor.StandardValue = null;
            this.FalecidoCor.TabIndex = 61;
            this.FalecidoCor.TabStop = false;
            this.FalecidoCor.ToolTipContext = null;
            this.FalecidoCor.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoCor.Validations")));
            this.FalecidoCor.ValueControl = null;
            this.FalecidoCor.ValueMember = "";
            // 
            // FalecidoSexo
            // 
            this.FalecidoSexo.Caption = "";
            this.FalecidoSexo.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoSexo.CenterCaption = false;
            this.FalecidoSexo.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoSexo.DefaultValue = false;
            this.FalecidoSexo.Disable = true;
            this.FalecidoSexo.DisplayMember = "";
            this.FalecidoSexo.FieldValid = true;
            this.FalecidoSexo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoSexo.Form = null;
            this.FalecidoSexo.FormType = null;
            this.FalecidoSexo.IsDependecyUkey = false;
            this.FalecidoSexo.Location = new System.Drawing.Point(654, 10);
            this.FalecidoSexo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoSexo.Name = "FalecidoSexo";
            this.FalecidoSexo.ObjectControl = null;
            this.FalecidoSexo.ObjetoApp = null;
            this.FalecidoSexo.PropertyControl = null;
            this.FalecidoSexo.PropertyDependecyUkey = null;
            this.FalecidoSexo.Size = new System.Drawing.Size(126, 54);
            this.FalecidoSexo.StandardValue = null;
            this.FalecidoSexo.TabIndex = 56;
            this.FalecidoSexo.TabStop = false;
            this.FalecidoSexo.ToolTipContext = null;
            this.FalecidoSexo.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoSexo.Validations")));
            this.FalecidoSexo.ValueControl = null;
            this.FalecidoSexo.ValueMember = "";
            // 
            // FalecidoNome
            // 
            this.FalecidoNome.Caption = "";
            this.FalecidoNome.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoNome.CenterCaption = false;
            this.FalecidoNome.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoNome.Disable = true;
            this.FalecidoNome.FieldValid = true;
            this.FalecidoNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoNome.Form = null;
            this.FalecidoNome.FormType = null;
            this.FalecidoNome.IsDependecyUkey = false;
            this.FalecidoNome.Location = new System.Drawing.Point(8, 10);
            this.FalecidoNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoNome.Name = "FalecidoNome";
            this.FalecidoNome.ObjectControl = null;
            this.FalecidoNome.ObjetoApp = null;
            this.FalecidoNome.PropertyControl = null;
            this.FalecidoNome.PropertyDependecyUkey = null;
            this.FalecidoNome.Size = new System.Drawing.Size(640, 54);
            this.FalecidoNome.TabIndex = 54;
            this.FalecidoNome.TabStop = false;
            this.FalecidoNome.ToolTipContext = null;
            this.FalecidoNome.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoNome.Validations")));
            this.FalecidoNome.ValueControl = "";
            // 
            // filiacaotabPage
            // 
            this.filiacaotabPage.BackColor = System.Drawing.Color.White;
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoEstadoId);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoCidadeId);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoBairro);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoEndereco);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoMaeDocumento);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoMaeProfissaoId);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoMaeNatural);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoMaeIdade);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoMaeEtadoCivil);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoNomeMae);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoPaiDocumento);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoPaiProfissaoId);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoPaiNatural);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoPaiIdade);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoPaiEstadoCivil);
            this.filiacaotabPage.Controls.Add(this.FalecidoFiliacaoNomePai);
            this.filiacaotabPage.Location = new System.Drawing.Point(4, 30);
            this.filiacaotabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filiacaotabPage.Name = "filiacaotabPage";
            this.filiacaotabPage.Size = new System.Drawing.Size(598, 354);
            this.filiacaotabPage.TabIndex = 1;
            this.filiacaotabPage.Text = "Filiação";
            // 
            // FalecidoFiliacaoEstadoId
            // 
            this.FalecidoFiliacaoEstadoId.Caption = "";
            this.FalecidoFiliacaoEstadoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoEstadoId.CenterCaption = false;
            this.FalecidoFiliacaoEstadoId.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoEstadoId.DefaultValue = false;
            this.FalecidoFiliacaoEstadoId.Disable = true;
            this.FalecidoFiliacaoEstadoId.DisplayMember = "";
            this.FalecidoFiliacaoEstadoId.FieldValid = true;
            this.FalecidoFiliacaoEstadoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoEstadoId.Form = null;
            this.FalecidoFiliacaoEstadoId.FormType = null;
            this.FalecidoFiliacaoEstadoId.IsDependecyUkey = false;
            this.FalecidoFiliacaoEstadoId.Location = new System.Drawing.Point(938, 280);
            this.FalecidoFiliacaoEstadoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFiliacaoEstadoId.Name = "FalecidoFiliacaoEstadoId";
            this.FalecidoFiliacaoEstadoId.ObjectControl = null;
            this.FalecidoFiliacaoEstadoId.ObjetoApp = null;
            this.FalecidoFiliacaoEstadoId.PropertyControl = null;
            this.FalecidoFiliacaoEstadoId.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoEstadoId.Size = new System.Drawing.Size(68, 50);
            this.FalecidoFiliacaoEstadoId.StandardValue = null;
            this.FalecidoFiliacaoEstadoId.TabIndex = 149;
            this.FalecidoFiliacaoEstadoId.TabStop = false;
            this.FalecidoFiliacaoEstadoId.ToolTipContext = null;
            this.FalecidoFiliacaoEstadoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoEstadoId.Validations")));
            this.FalecidoFiliacaoEstadoId.ValueControl = null;
            this.FalecidoFiliacaoEstadoId.ValueMember = "";
            // 
            // FalecidoFiliacaoCidadeId
            // 
            this.FalecidoFiliacaoCidadeId.Caption = "";
            this.FalecidoFiliacaoCidadeId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoCidadeId.CenterCaption = false;
            this.FalecidoFiliacaoCidadeId.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoCidadeId.DefaultValue = false;
            this.FalecidoFiliacaoCidadeId.Disable = true;
            this.FalecidoFiliacaoCidadeId.DisplayMember = "";
            this.FalecidoFiliacaoCidadeId.FieldValid = true;
            this.FalecidoFiliacaoCidadeId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoCidadeId.Form = null;
            this.FalecidoFiliacaoCidadeId.FormType = null;
            this.FalecidoFiliacaoCidadeId.IsDependecyUkey = false;
            this.FalecidoFiliacaoCidadeId.Location = new System.Drawing.Point(518, 280);
            this.FalecidoFiliacaoCidadeId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFiliacaoCidadeId.Name = "FalecidoFiliacaoCidadeId";
            this.FalecidoFiliacaoCidadeId.ObjectControl = null;
            this.FalecidoFiliacaoCidadeId.ObjetoApp = null;
            this.FalecidoFiliacaoCidadeId.PropertyControl = null;
            this.FalecidoFiliacaoCidadeId.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoCidadeId.Size = new System.Drawing.Size(412, 50);
            this.FalecidoFiliacaoCidadeId.StandardValue = null;
            this.FalecidoFiliacaoCidadeId.TabIndex = 148;
            this.FalecidoFiliacaoCidadeId.TabStop = false;
            this.FalecidoFiliacaoCidadeId.ToolTipContext = null;
            this.FalecidoFiliacaoCidadeId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoCidadeId.Validations")));
            this.FalecidoFiliacaoCidadeId.ValueControl = null;
            this.FalecidoFiliacaoCidadeId.ValueMember = "";
            // 
            // FalecidoFiliacaoBairro
            // 
            this.FalecidoFiliacaoBairro.Caption = "";
            this.FalecidoFiliacaoBairro.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoBairro.CenterCaption = false;
            this.FalecidoFiliacaoBairro.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoBairro.Disable = true;
            this.FalecidoFiliacaoBairro.FieldValid = true;
            this.FalecidoFiliacaoBairro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoBairro.Form = null;
            this.FalecidoFiliacaoBairro.FormType = null;
            this.FalecidoFiliacaoBairro.IsDependecyUkey = false;
            this.FalecidoFiliacaoBairro.Location = new System.Drawing.Point(5, 280);
            this.FalecidoFiliacaoBairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFiliacaoBairro.Name = "FalecidoFiliacaoBairro";
            this.FalecidoFiliacaoBairro.ObjectControl = null;
            this.FalecidoFiliacaoBairro.ObjetoApp = null;
            this.FalecidoFiliacaoBairro.PropertyControl = null;
            this.FalecidoFiliacaoBairro.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoBairro.Size = new System.Drawing.Size(505, 50);
            this.FalecidoFiliacaoBairro.TabIndex = 147;
            this.FalecidoFiliacaoBairro.TabStop = false;
            this.FalecidoFiliacaoBairro.ToolTipContext = null;
            this.FalecidoFiliacaoBairro.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoBairro.Validations")));
            this.FalecidoFiliacaoBairro.ValueControl = "";
            // 
            // FalecidoFiliacaoEndereco
            // 
            this.FalecidoFiliacaoEndereco.Caption = "";
            this.FalecidoFiliacaoEndereco.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoEndereco.CenterCaption = false;
            this.FalecidoFiliacaoEndereco.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoEndereco.Disable = true;
            this.FalecidoFiliacaoEndereco.FieldValid = true;
            this.FalecidoFiliacaoEndereco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoEndereco.Form = null;
            this.FalecidoFiliacaoEndereco.FormType = null;
            this.FalecidoFiliacaoEndereco.IsDependecyUkey = false;
            this.FalecidoFiliacaoEndereco.Location = new System.Drawing.Point(374, 215);
            this.FalecidoFiliacaoEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFiliacaoEndereco.Name = "FalecidoFiliacaoEndereco";
            this.FalecidoFiliacaoEndereco.ObjectControl = null;
            this.FalecidoFiliacaoEndereco.ObjetoApp = null;
            this.FalecidoFiliacaoEndereco.PropertyControl = null;
            this.FalecidoFiliacaoEndereco.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoEndereco.Size = new System.Drawing.Size(629, 55);
            this.FalecidoFiliacaoEndereco.TabIndex = 146;
            this.FalecidoFiliacaoEndereco.TabStop = false;
            this.FalecidoFiliacaoEndereco.ToolTipContext = null;
            this.FalecidoFiliacaoEndereco.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoEndereco.Validations")));
            this.FalecidoFiliacaoEndereco.ValueControl = "";
            // 
            // FalecidoFiliacaoMaeDocumento
            // 
            this.FalecidoFiliacaoMaeDocumento.Caption = "";
            this.FalecidoFiliacaoMaeDocumento.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoMaeDocumento.CenterCaption = false;
            this.FalecidoFiliacaoMaeDocumento.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoMaeDocumento.Disable = true;
            this.FalecidoFiliacaoMaeDocumento.FieldValid = true;
            this.FalecidoFiliacaoMaeDocumento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoMaeDocumento.Form = null;
            this.FalecidoFiliacaoMaeDocumento.FormType = null;
            this.FalecidoFiliacaoMaeDocumento.IsDependecyUkey = false;
            this.FalecidoFiliacaoMaeDocumento.Location = new System.Drawing.Point(204, 215);
            this.FalecidoFiliacaoMaeDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFiliacaoMaeDocumento.Name = "FalecidoFiliacaoMaeDocumento";
            this.FalecidoFiliacaoMaeDocumento.ObjectControl = null;
            this.FalecidoFiliacaoMaeDocumento.ObjetoApp = null;
            this.FalecidoFiliacaoMaeDocumento.PropertyControl = null;
            this.FalecidoFiliacaoMaeDocumento.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoMaeDocumento.Size = new System.Drawing.Size(162, 55);
            this.FalecidoFiliacaoMaeDocumento.TabIndex = 145;
            this.FalecidoFiliacaoMaeDocumento.TabStop = false;
            this.FalecidoFiliacaoMaeDocumento.ToolTipContext = null;
            this.FalecidoFiliacaoMaeDocumento.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoMaeDocumento.Validations")));
            this.FalecidoFiliacaoMaeDocumento.ValueControl = "";
            // 
            // FalecidoFiliacaoMaeProfissaoId
            // 
            this.FalecidoFiliacaoMaeProfissaoId.Caption = "";
            this.FalecidoFiliacaoMaeProfissaoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoMaeProfissaoId.CenterCaption = false;
            this.FalecidoFiliacaoMaeProfissaoId.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoMaeProfissaoId.DefaultValue = false;
            this.FalecidoFiliacaoMaeProfissaoId.Disable = true;
            this.FalecidoFiliacaoMaeProfissaoId.DisplayMember = "";
            this.FalecidoFiliacaoMaeProfissaoId.FieldValid = true;
            this.FalecidoFiliacaoMaeProfissaoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoMaeProfissaoId.Form = null;
            this.FalecidoFiliacaoMaeProfissaoId.FormType = null;
            this.FalecidoFiliacaoMaeProfissaoId.IsDependecyUkey = false;
            this.FalecidoFiliacaoMaeProfissaoId.Location = new System.Drawing.Point(10, 215);
            this.FalecidoFiliacaoMaeProfissaoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFiliacaoMaeProfissaoId.Name = "FalecidoFiliacaoMaeProfissaoId";
            this.FalecidoFiliacaoMaeProfissaoId.ObjectControl = null;
            this.FalecidoFiliacaoMaeProfissaoId.ObjetoApp = null;
            this.FalecidoFiliacaoMaeProfissaoId.PropertyControl = null;
            this.FalecidoFiliacaoMaeProfissaoId.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoMaeProfissaoId.Size = new System.Drawing.Size(186, 55);
            this.FalecidoFiliacaoMaeProfissaoId.StandardValue = null;
            this.FalecidoFiliacaoMaeProfissaoId.TabIndex = 144;
            this.FalecidoFiliacaoMaeProfissaoId.TabStop = false;
            this.FalecidoFiliacaoMaeProfissaoId.ToolTipContext = null;
            this.FalecidoFiliacaoMaeProfissaoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoMaeProfissaoId.Validations")));
            this.FalecidoFiliacaoMaeProfissaoId.ValueControl = null;
            this.FalecidoFiliacaoMaeProfissaoId.ValueMember = "";
            // 
            // FalecidoFiliacaoMaeNatural
            // 
            this.FalecidoFiliacaoMaeNatural.Caption = "";
            this.FalecidoFiliacaoMaeNatural.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoMaeNatural.CenterCaption = false;
            this.FalecidoFiliacaoMaeNatural.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoMaeNatural.Disable = true;
            this.FalecidoFiliacaoMaeNatural.FieldValid = true;
            this.FalecidoFiliacaoMaeNatural.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoMaeNatural.Form = null;
            this.FalecidoFiliacaoMaeNatural.FormType = null;
            this.FalecidoFiliacaoMaeNatural.IsDependecyUkey = false;
            this.FalecidoFiliacaoMaeNatural.Location = new System.Drawing.Point(883, 147);
            this.FalecidoFiliacaoMaeNatural.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFiliacaoMaeNatural.Name = "FalecidoFiliacaoMaeNatural";
            this.FalecidoFiliacaoMaeNatural.ObjectControl = null;
            this.FalecidoFiliacaoMaeNatural.ObjetoApp = null;
            this.FalecidoFiliacaoMaeNatural.PropertyControl = null;
            this.FalecidoFiliacaoMaeNatural.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoMaeNatural.Size = new System.Drawing.Size(123, 58);
            this.FalecidoFiliacaoMaeNatural.TabIndex = 143;
            this.FalecidoFiliacaoMaeNatural.TabStop = false;
            this.FalecidoFiliacaoMaeNatural.ToolTipContext = null;
            this.FalecidoFiliacaoMaeNatural.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoMaeNatural.Validations")));
            this.FalecidoFiliacaoMaeNatural.ValueControl = "";
            // 
            // FalecidoFiliacaoMaeIdade
            // 
            this.FalecidoFiliacaoMaeIdade.Caption = "";
            this.FalecidoFiliacaoMaeIdade.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoMaeIdade.CenterCaption = false;
            this.FalecidoFiliacaoMaeIdade.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoMaeIdade.DecimalPlaces = 0;
            this.FalecidoFiliacaoMaeIdade.Disable = true;
            this.FalecidoFiliacaoMaeIdade.FieldValid = true;
            this.FalecidoFiliacaoMaeIdade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoMaeIdade.Form = null;
            this.FalecidoFiliacaoMaeIdade.FormType = null;
            this.FalecidoFiliacaoMaeIdade.IsDependecyUkey = false;
            this.FalecidoFiliacaoMaeIdade.Location = new System.Drawing.Point(802, 147);
            this.FalecidoFiliacaoMaeIdade.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.FalecidoFiliacaoMaeIdade.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.FalecidoFiliacaoMaeIdade.Name = "FalecidoFiliacaoMaeIdade";
            this.FalecidoFiliacaoMaeIdade.ObjectControl = null;
            this.FalecidoFiliacaoMaeIdade.ObjetoApp = null;
            this.FalecidoFiliacaoMaeIdade.PropertyControl = null;
            this.FalecidoFiliacaoMaeIdade.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoMaeIdade.Size = new System.Drawing.Size(73, 58);
            this.FalecidoFiliacaoMaeIdade.TabIndex = 142;
            this.FalecidoFiliacaoMaeIdade.TabStop = false;
            this.FalecidoFiliacaoMaeIdade.ThousandsSeparator = false;
            this.FalecidoFiliacaoMaeIdade.ToolTipContext = null;
            this.FalecidoFiliacaoMaeIdade.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoMaeIdade.Validations")));
            this.FalecidoFiliacaoMaeIdade.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // FalecidoFiliacaoMaeEtadoCivil
            // 
            this.FalecidoFiliacaoMaeEtadoCivil.Caption = "";
            this.FalecidoFiliacaoMaeEtadoCivil.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoMaeEtadoCivil.CenterCaption = false;
            this.FalecidoFiliacaoMaeEtadoCivil.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoMaeEtadoCivil.DefaultValue = false;
            this.FalecidoFiliacaoMaeEtadoCivil.Disable = true;
            this.FalecidoFiliacaoMaeEtadoCivil.DisplayMember = "";
            this.FalecidoFiliacaoMaeEtadoCivil.FieldValid = true;
            this.FalecidoFiliacaoMaeEtadoCivil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoMaeEtadoCivil.Form = null;
            this.FalecidoFiliacaoMaeEtadoCivil.FormType = null;
            this.FalecidoFiliacaoMaeEtadoCivil.IsDependecyUkey = false;
            this.FalecidoFiliacaoMaeEtadoCivil.Location = new System.Drawing.Point(702, 147);
            this.FalecidoFiliacaoMaeEtadoCivil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFiliacaoMaeEtadoCivil.Name = "FalecidoFiliacaoMaeEtadoCivil";
            this.FalecidoFiliacaoMaeEtadoCivil.ObjectControl = null;
            this.FalecidoFiliacaoMaeEtadoCivil.ObjetoApp = null;
            this.FalecidoFiliacaoMaeEtadoCivil.PropertyControl = null;
            this.FalecidoFiliacaoMaeEtadoCivil.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoMaeEtadoCivil.Size = new System.Drawing.Size(93, 58);
            this.FalecidoFiliacaoMaeEtadoCivil.StandardValue = null;
            this.FalecidoFiliacaoMaeEtadoCivil.TabIndex = 141;
            this.FalecidoFiliacaoMaeEtadoCivil.TabStop = false;
            this.FalecidoFiliacaoMaeEtadoCivil.ToolTipContext = null;
            this.FalecidoFiliacaoMaeEtadoCivil.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoMaeEtadoCivil.Validations")));
            this.FalecidoFiliacaoMaeEtadoCivil.ValueControl = null;
            this.FalecidoFiliacaoMaeEtadoCivil.ValueMember = "";
            // 
            // FalecidoFiliacaoNomeMae
            // 
            this.FalecidoFiliacaoNomeMae.Caption = "";
            this.FalecidoFiliacaoNomeMae.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoNomeMae.CenterCaption = false;
            this.FalecidoFiliacaoNomeMae.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoNomeMae.Disable = true;
            this.FalecidoFiliacaoNomeMae.FieldValid = true;
            this.FalecidoFiliacaoNomeMae.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoNomeMae.Form = null;
            this.FalecidoFiliacaoNomeMae.FormType = null;
            this.FalecidoFiliacaoNomeMae.IsDependecyUkey = false;
            this.FalecidoFiliacaoNomeMae.Location = new System.Drawing.Point(10, 147);
            this.FalecidoFiliacaoNomeMae.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFiliacaoNomeMae.Name = "FalecidoFiliacaoNomeMae";
            this.FalecidoFiliacaoNomeMae.ObjectControl = null;
            this.FalecidoFiliacaoNomeMae.ObjetoApp = null;
            this.FalecidoFiliacaoNomeMae.PropertyControl = null;
            this.FalecidoFiliacaoNomeMae.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoNomeMae.Size = new System.Drawing.Size(684, 58);
            this.FalecidoFiliacaoNomeMae.TabIndex = 140;
            this.FalecidoFiliacaoNomeMae.TabStop = false;
            this.FalecidoFiliacaoNomeMae.ToolTipContext = null;
            this.FalecidoFiliacaoNomeMae.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoNomeMae.Validations")));
            this.FalecidoFiliacaoNomeMae.ValueControl = "";
            // 
            // FalecidoFiliacaoPaiDocumento
            // 
            this.FalecidoFiliacaoPaiDocumento.Caption = "";
            this.FalecidoFiliacaoPaiDocumento.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoPaiDocumento.CenterCaption = false;
            this.FalecidoFiliacaoPaiDocumento.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoPaiDocumento.Disable = true;
            this.FalecidoFiliacaoPaiDocumento.FieldValid = true;
            this.FalecidoFiliacaoPaiDocumento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoPaiDocumento.Form = null;
            this.FalecidoFiliacaoPaiDocumento.FormType = null;
            this.FalecidoFiliacaoPaiDocumento.IsDependecyUkey = false;
            this.FalecidoFiliacaoPaiDocumento.Location = new System.Drawing.Point(204, 80);
            this.FalecidoFiliacaoPaiDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFiliacaoPaiDocumento.Name = "FalecidoFiliacaoPaiDocumento";
            this.FalecidoFiliacaoPaiDocumento.ObjectControl = null;
            this.FalecidoFiliacaoPaiDocumento.ObjetoApp = null;
            this.FalecidoFiliacaoPaiDocumento.PropertyControl = null;
            this.FalecidoFiliacaoPaiDocumento.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoPaiDocumento.Size = new System.Drawing.Size(422, 57);
            this.FalecidoFiliacaoPaiDocumento.TabIndex = 139;
            this.FalecidoFiliacaoPaiDocumento.TabStop = false;
            this.FalecidoFiliacaoPaiDocumento.ToolTipContext = null;
            this.FalecidoFiliacaoPaiDocumento.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoPaiDocumento.Validations")));
            this.FalecidoFiliacaoPaiDocumento.ValueControl = "";
            // 
            // FalecidoFiliacaoPaiProfissaoId
            // 
            this.FalecidoFiliacaoPaiProfissaoId.Caption = "";
            this.FalecidoFiliacaoPaiProfissaoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoPaiProfissaoId.CenterCaption = false;
            this.FalecidoFiliacaoPaiProfissaoId.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoPaiProfissaoId.DefaultValue = false;
            this.FalecidoFiliacaoPaiProfissaoId.Disable = true;
            this.FalecidoFiliacaoPaiProfissaoId.DisplayMember = "";
            this.FalecidoFiliacaoPaiProfissaoId.FieldValid = true;
            this.FalecidoFiliacaoPaiProfissaoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoPaiProfissaoId.Form = null;
            this.FalecidoFiliacaoPaiProfissaoId.FormType = null;
            this.FalecidoFiliacaoPaiProfissaoId.IsDependecyUkey = false;
            this.FalecidoFiliacaoPaiProfissaoId.Location = new System.Drawing.Point(10, 80);
            this.FalecidoFiliacaoPaiProfissaoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFiliacaoPaiProfissaoId.Name = "FalecidoFiliacaoPaiProfissaoId";
            this.FalecidoFiliacaoPaiProfissaoId.ObjectControl = null;
            this.FalecidoFiliacaoPaiProfissaoId.ObjetoApp = null;
            this.FalecidoFiliacaoPaiProfissaoId.PropertyControl = null;
            this.FalecidoFiliacaoPaiProfissaoId.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoPaiProfissaoId.Size = new System.Drawing.Size(186, 60);
            this.FalecidoFiliacaoPaiProfissaoId.StandardValue = null;
            this.FalecidoFiliacaoPaiProfissaoId.TabIndex = 138;
            this.FalecidoFiliacaoPaiProfissaoId.TabStop = false;
            this.FalecidoFiliacaoPaiProfissaoId.ToolTipContext = null;
            this.FalecidoFiliacaoPaiProfissaoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoPaiProfissaoId.Validations")));
            this.FalecidoFiliacaoPaiProfissaoId.ValueControl = null;
            this.FalecidoFiliacaoPaiProfissaoId.ValueMember = "";
            // 
            // FalecidoFiliacaoPaiNatural
            // 
            this.FalecidoFiliacaoPaiNatural.Caption = "";
            this.FalecidoFiliacaoPaiNatural.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoPaiNatural.CenterCaption = false;
            this.FalecidoFiliacaoPaiNatural.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoPaiNatural.Disable = true;
            this.FalecidoFiliacaoPaiNatural.FieldValid = true;
            this.FalecidoFiliacaoPaiNatural.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoPaiNatural.Form = null;
            this.FalecidoFiliacaoPaiNatural.FormType = null;
            this.FalecidoFiliacaoPaiNatural.IsDependecyUkey = false;
            this.FalecidoFiliacaoPaiNatural.Location = new System.Drawing.Point(883, 14);
            this.FalecidoFiliacaoPaiNatural.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFiliacaoPaiNatural.Name = "FalecidoFiliacaoPaiNatural";
            this.FalecidoFiliacaoPaiNatural.ObjectControl = null;
            this.FalecidoFiliacaoPaiNatural.ObjetoApp = null;
            this.FalecidoFiliacaoPaiNatural.PropertyControl = null;
            this.FalecidoFiliacaoPaiNatural.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoPaiNatural.Size = new System.Drawing.Size(123, 56);
            this.FalecidoFiliacaoPaiNatural.TabIndex = 137;
            this.FalecidoFiliacaoPaiNatural.TabStop = false;
            this.FalecidoFiliacaoPaiNatural.ToolTipContext = null;
            this.FalecidoFiliacaoPaiNatural.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoPaiNatural.Validations")));
            this.FalecidoFiliacaoPaiNatural.ValueControl = "";
            // 
            // FalecidoFiliacaoPaiIdade
            // 
            this.FalecidoFiliacaoPaiIdade.Caption = "";
            this.FalecidoFiliacaoPaiIdade.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoPaiIdade.CenterCaption = false;
            this.FalecidoFiliacaoPaiIdade.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoPaiIdade.DecimalPlaces = 0;
            this.FalecidoFiliacaoPaiIdade.Disable = true;
            this.FalecidoFiliacaoPaiIdade.FieldValid = true;
            this.FalecidoFiliacaoPaiIdade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoPaiIdade.Form = null;
            this.FalecidoFiliacaoPaiIdade.FormType = null;
            this.FalecidoFiliacaoPaiIdade.IsDependecyUkey = false;
            this.FalecidoFiliacaoPaiIdade.Location = new System.Drawing.Point(803, 14);
            this.FalecidoFiliacaoPaiIdade.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.FalecidoFiliacaoPaiIdade.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.FalecidoFiliacaoPaiIdade.Name = "FalecidoFiliacaoPaiIdade";
            this.FalecidoFiliacaoPaiIdade.ObjectControl = null;
            this.FalecidoFiliacaoPaiIdade.ObjetoApp = null;
            this.FalecidoFiliacaoPaiIdade.PropertyControl = null;
            this.FalecidoFiliacaoPaiIdade.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoPaiIdade.Size = new System.Drawing.Size(73, 56);
            this.FalecidoFiliacaoPaiIdade.TabIndex = 136;
            this.FalecidoFiliacaoPaiIdade.TabStop = false;
            this.FalecidoFiliacaoPaiIdade.ThousandsSeparator = false;
            this.FalecidoFiliacaoPaiIdade.ToolTipContext = null;
            this.FalecidoFiliacaoPaiIdade.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoPaiIdade.Validations")));
            this.FalecidoFiliacaoPaiIdade.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // FalecidoFiliacaoPaiEstadoCivil
            // 
            this.FalecidoFiliacaoPaiEstadoCivil.Caption = "";
            this.FalecidoFiliacaoPaiEstadoCivil.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoPaiEstadoCivil.CenterCaption = false;
            this.FalecidoFiliacaoPaiEstadoCivil.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoPaiEstadoCivil.DefaultValue = false;
            this.FalecidoFiliacaoPaiEstadoCivil.Disable = true;
            this.FalecidoFiliacaoPaiEstadoCivil.DisplayMember = "";
            this.FalecidoFiliacaoPaiEstadoCivil.FieldValid = true;
            this.FalecidoFiliacaoPaiEstadoCivil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoPaiEstadoCivil.Form = null;
            this.FalecidoFiliacaoPaiEstadoCivil.FormType = null;
            this.FalecidoFiliacaoPaiEstadoCivil.IsDependecyUkey = false;
            this.FalecidoFiliacaoPaiEstadoCivil.Location = new System.Drawing.Point(702, 14);
            this.FalecidoFiliacaoPaiEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFiliacaoPaiEstadoCivil.Name = "FalecidoFiliacaoPaiEstadoCivil";
            this.FalecidoFiliacaoPaiEstadoCivil.ObjectControl = null;
            this.FalecidoFiliacaoPaiEstadoCivil.ObjetoApp = null;
            this.FalecidoFiliacaoPaiEstadoCivil.PropertyControl = null;
            this.FalecidoFiliacaoPaiEstadoCivil.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoPaiEstadoCivil.Size = new System.Drawing.Size(93, 56);
            this.FalecidoFiliacaoPaiEstadoCivil.StandardValue = null;
            this.FalecidoFiliacaoPaiEstadoCivil.TabIndex = 135;
            this.FalecidoFiliacaoPaiEstadoCivil.TabStop = false;
            this.FalecidoFiliacaoPaiEstadoCivil.ToolTipContext = null;
            this.FalecidoFiliacaoPaiEstadoCivil.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoPaiEstadoCivil.Validations")));
            this.FalecidoFiliacaoPaiEstadoCivil.ValueControl = null;
            this.FalecidoFiliacaoPaiEstadoCivil.ValueMember = "";
            // 
            // FalecidoFiliacaoNomePai
            // 
            this.FalecidoFiliacaoNomePai.Caption = "";
            this.FalecidoFiliacaoNomePai.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFiliacaoNomePai.CenterCaption = false;
            this.FalecidoFiliacaoNomePai.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFiliacaoNomePai.Disable = true;
            this.FalecidoFiliacaoNomePai.FieldValid = true;
            this.FalecidoFiliacaoNomePai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFiliacaoNomePai.Form = null;
            this.FalecidoFiliacaoNomePai.FormType = null;
            this.FalecidoFiliacaoNomePai.IsDependecyUkey = false;
            this.FalecidoFiliacaoNomePai.Location = new System.Drawing.Point(10, 14);
            this.FalecidoFiliacaoNomePai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFiliacaoNomePai.Name = "FalecidoFiliacaoNomePai";
            this.FalecidoFiliacaoNomePai.ObjectControl = null;
            this.FalecidoFiliacaoNomePai.ObjetoApp = null;
            this.FalecidoFiliacaoNomePai.PropertyControl = null;
            this.FalecidoFiliacaoNomePai.PropertyDependecyUkey = null;
            this.FalecidoFiliacaoNomePai.Size = new System.Drawing.Size(684, 56);
            this.FalecidoFiliacaoNomePai.TabIndex = 134;
            this.FalecidoFiliacaoNomePai.TabStop = false;
            this.FalecidoFiliacaoNomePai.ToolTipContext = null;
            this.FalecidoFiliacaoNomePai.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFiliacaoNomePai.Validations")));
            this.FalecidoFiliacaoNomePai.ValueControl = "";
            // 
            // conjuguetabPage
            // 
            this.conjuguetabPage.BackColor = System.Drawing.Color.White;
            this.conjuguetabPage.Controls.Add(this.panel4);
            this.conjuguetabPage.Location = new System.Drawing.Point(4, 30);
            this.conjuguetabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.conjuguetabPage.Name = "conjuguetabPage";
            this.conjuguetabPage.Size = new System.Drawing.Size(598, 354);
            this.conjuguetabPage.TabIndex = 2;
            this.conjuguetabPage.Text = "Conjugue";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.FalecidoNumero);
            this.panel4.Controls.Add(this.FalecidoFolha);
            this.panel4.Controls.Add(this.FalecidoLivro);
            this.panel4.Controls.Add(this.FalecidoDataNupcias);
            this.panel4.Controls.Add(this.FalecidoCartorioNupcias);
            this.panel4.Controls.Add(this.FalecidoNomeConjugue);
            this.panel4.Location = new System.Drawing.Point(147, 66);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(751, 135);
            this.panel4.TabIndex = 1;
            // 
            // FalecidoNumero
            // 
            this.FalecidoNumero.Caption = "";
            this.FalecidoNumero.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoNumero.CenterCaption = false;
            this.FalecidoNumero.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoNumero.Disable = true;
            this.FalecidoNumero.FieldValid = true;
            this.FalecidoNumero.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoNumero.Form = null;
            this.FalecidoNumero.FormType = null;
            this.FalecidoNumero.IsDependecyUkey = false;
            this.FalecidoNumero.Location = new System.Drawing.Point(608, 68);
            this.FalecidoNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoNumero.Name = "FalecidoNumero";
            this.FalecidoNumero.ObjectControl = null;
            this.FalecidoNumero.ObjetoApp = null;
            this.FalecidoNumero.PropertyControl = null;
            this.FalecidoNumero.PropertyDependecyUkey = null;
            this.FalecidoNumero.Size = new System.Drawing.Size(130, 53);
            this.FalecidoNumero.TabIndex = 70;
            this.FalecidoNumero.TabStop = false;
            this.FalecidoNumero.ToolTipContext = null;
            this.FalecidoNumero.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoNumero.Validations")));
            this.FalecidoNumero.ValueControl = "";
            // 
            // FalecidoFolha
            // 
            this.FalecidoFolha.Caption = "";
            this.FalecidoFolha.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFolha.CenterCaption = false;
            this.FalecidoFolha.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFolha.Disable = true;
            this.FalecidoFolha.FieldValid = true;
            this.FalecidoFolha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFolha.Form = null;
            this.FalecidoFolha.FormType = null;
            this.FalecidoFolha.IsDependecyUkey = false;
            this.FalecidoFolha.Location = new System.Drawing.Point(470, 68);
            this.FalecidoFolha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoFolha.Name = "FalecidoFolha";
            this.FalecidoFolha.ObjectControl = null;
            this.FalecidoFolha.ObjetoApp = null;
            this.FalecidoFolha.PropertyControl = null;
            this.FalecidoFolha.PropertyDependecyUkey = null;
            this.FalecidoFolha.Size = new System.Drawing.Size(130, 53);
            this.FalecidoFolha.TabIndex = 68;
            this.FalecidoFolha.TabStop = false;
            this.FalecidoFolha.ToolTipContext = null;
            this.FalecidoFolha.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFolha.Validations")));
            this.FalecidoFolha.ValueControl = "";
            // 
            // FalecidoLivro
            // 
            this.FalecidoLivro.Caption = "";
            this.FalecidoLivro.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoLivro.CenterCaption = false;
            this.FalecidoLivro.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoLivro.Disable = true;
            this.FalecidoLivro.FieldValid = true;
            this.FalecidoLivro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoLivro.Form = null;
            this.FalecidoLivro.FormType = null;
            this.FalecidoLivro.IsDependecyUkey = false;
            this.FalecidoLivro.Location = new System.Drawing.Point(332, 68);
            this.FalecidoLivro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoLivro.Name = "FalecidoLivro";
            this.FalecidoLivro.ObjectControl = null;
            this.FalecidoLivro.ObjetoApp = null;
            this.FalecidoLivro.PropertyControl = null;
            this.FalecidoLivro.PropertyDependecyUkey = null;
            this.FalecidoLivro.Size = new System.Drawing.Size(130, 53);
            this.FalecidoLivro.TabIndex = 66;
            this.FalecidoLivro.TabStop = false;
            this.FalecidoLivro.ToolTipContext = null;
            this.FalecidoLivro.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoLivro.Validations")));
            this.FalecidoLivro.ValueControl = "";
            // 
            // FalecidoDataNupcias
            // 
            this.FalecidoDataNupcias.Caption = "";
            this.FalecidoDataNupcias.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoDataNupcias.CenterCaption = false;
            this.FalecidoDataNupcias.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoDataNupcias.CustomFormat = null;
            this.FalecidoDataNupcias.Disable = true;
            this.FalecidoDataNupcias.FieldValid = true;
            this.FalecidoDataNupcias.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoDataNupcias.Form = null;
            this.FalecidoDataNupcias.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FalecidoDataNupcias.FormType = null;
            this.FalecidoDataNupcias.IsDependecyUkey = false;
            this.FalecidoDataNupcias.Location = new System.Drawing.Point(191, 68);
            this.FalecidoDataNupcias.Name = "FalecidoDataNupcias";
            this.FalecidoDataNupcias.ObjectControl = null;
            this.FalecidoDataNupcias.ObjetoApp = null;
            this.FalecidoDataNupcias.PropertyControl = null;
            this.FalecidoDataNupcias.PropertyDependecyUkey = null;
            this.FalecidoDataNupcias.Size = new System.Drawing.Size(134, 53);
            this.FalecidoDataNupcias.TabIndex = 64;
            this.FalecidoDataNupcias.TabStop = false;
            this.FalecidoDataNupcias.ToolTipContext = null;
            this.FalecidoDataNupcias.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoDataNupcias.Validations")));
            this.FalecidoDataNupcias.ValueControl = new System.DateTime(2016, 12, 31, 15, 9, 23, 170);
            // 
            // FalecidoCartorioNupcias
            // 
            this.FalecidoCartorioNupcias.Caption = "";
            this.FalecidoCartorioNupcias.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoCartorioNupcias.CenterCaption = false;
            this.FalecidoCartorioNupcias.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoCartorioNupcias.Disable = true;
            this.FalecidoCartorioNupcias.FieldValid = true;
            this.FalecidoCartorioNupcias.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoCartorioNupcias.Form = null;
            this.FalecidoCartorioNupcias.FormType = null;
            this.FalecidoCartorioNupcias.IsDependecyUkey = false;
            this.FalecidoCartorioNupcias.Location = new System.Drawing.Point(13, 68);
            this.FalecidoCartorioNupcias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoCartorioNupcias.Name = "FalecidoCartorioNupcias";
            this.FalecidoCartorioNupcias.ObjectControl = null;
            this.FalecidoCartorioNupcias.ObjetoApp = null;
            this.FalecidoCartorioNupcias.PropertyControl = null;
            this.FalecidoCartorioNupcias.PropertyDependecyUkey = null;
            this.FalecidoCartorioNupcias.Size = new System.Drawing.Size(171, 53);
            this.FalecidoCartorioNupcias.TabIndex = 60;
            this.FalecidoCartorioNupcias.TabStop = false;
            this.FalecidoCartorioNupcias.ToolTipContext = null;
            this.FalecidoCartorioNupcias.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoCartorioNupcias.Validations")));
            this.FalecidoCartorioNupcias.ValueControl = "";
            // 
            // FalecidoNomeConjugue
            // 
            this.FalecidoNomeConjugue.Caption = "";
            this.FalecidoNomeConjugue.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoNomeConjugue.CenterCaption = false;
            this.FalecidoNomeConjugue.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoNomeConjugue.Disable = true;
            this.FalecidoNomeConjugue.FieldValid = true;
            this.FalecidoNomeConjugue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoNomeConjugue.Form = null;
            this.FalecidoNomeConjugue.FormType = null;
            this.FalecidoNomeConjugue.IsDependecyUkey = false;
            this.FalecidoNomeConjugue.Location = new System.Drawing.Point(13, 5);
            this.FalecidoNomeConjugue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FalecidoNomeConjugue.Name = "FalecidoNomeConjugue";
            this.FalecidoNomeConjugue.ObjectControl = null;
            this.FalecidoNomeConjugue.ObjetoApp = null;
            this.FalecidoNomeConjugue.PropertyControl = null;
            this.FalecidoNomeConjugue.PropertyDependecyUkey = null;
            this.FalecidoNomeConjugue.Size = new System.Drawing.Size(725, 53);
            this.FalecidoNomeConjugue.TabIndex = 58;
            this.FalecidoNomeConjugue.TabStop = false;
            this.FalecidoNomeConjugue.ToolTipContext = null;
            this.FalecidoNomeConjugue.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoNomeConjugue.Validations")));
            this.FalecidoNomeConjugue.ValueControl = "";
            // 
            // filhosObservacoestabPage
            // 
            this.filhosObservacoestabPage.BackColor = System.Drawing.Color.White;
            this.filhosObservacoestabPage.Controls.Add(this.panel);
            this.filhosObservacoestabPage.Location = new System.Drawing.Point(4, 30);
            this.filhosObservacoestabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filhosObservacoestabPage.Name = "filhosObservacoestabPage";
            this.filhosObservacoestabPage.Size = new System.Drawing.Size(598, 354);
            this.filhosObservacoestabPage.TabIndex = 3;
            this.filhosObservacoestabPage.Text = "Filhos/Observacões";
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.FalecidoObservacao);
            this.panel.Controls.Add(this.FalecidoFilhos);
            this.panel.Location = new System.Drawing.Point(18, 68);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1007, 223);
            this.panel.TabIndex = 0;
            // 
            // FalecidoObservacao
            // 
            this.FalecidoObservacao.Caption = "";
            this.FalecidoObservacao.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoObservacao.CenterCaption = false;
            this.FalecidoObservacao.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoObservacao.Disable = true;
            this.FalecidoObservacao.FieldValid = true;
            this.FalecidoObservacao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoObservacao.Form = null;
            this.FalecidoObservacao.FormType = null;
            this.FalecidoObservacao.IsDependecyUkey = false;
            this.FalecidoObservacao.Location = new System.Drawing.Point(498, 3);
            this.FalecidoObservacao.Name = "FalecidoObservacao";
            this.FalecidoObservacao.ObjectControl = null;
            this.FalecidoObservacao.ObjetoApp = null;
            this.FalecidoObservacao.PropertyControl = null;
            this.FalecidoObservacao.PropertyDependecyUkey = null;
            this.FalecidoObservacao.Size = new System.Drawing.Size(504, 210);
            this.FalecidoObservacao.TabIndex = 5;
            this.FalecidoObservacao.TabStop = false;
            this.FalecidoObservacao.ToolTipContext = null;
            this.FalecidoObservacao.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoObservacao.Validations")));
            this.FalecidoObservacao.ValueControl = "";
            // 
            // FalecidoFilhos
            // 
            this.FalecidoFilhos.Caption = "";
            this.FalecidoFilhos.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoFilhos.CenterCaption = false;
            this.FalecidoFilhos.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoFilhos.Disable = true;
            this.FalecidoFilhos.FieldValid = true;
            this.FalecidoFilhos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoFilhos.Form = null;
            this.FalecidoFilhos.FormType = null;
            this.FalecidoFilhos.IsDependecyUkey = false;
            this.FalecidoFilhos.Location = new System.Drawing.Point(3, 3);
            this.FalecidoFilhos.Name = "FalecidoFilhos";
            this.FalecidoFilhos.ObjectControl = null;
            this.FalecidoFilhos.ObjetoApp = null;
            this.FalecidoFilhos.PropertyControl = null;
            this.FalecidoFilhos.PropertyDependecyUkey = null;
            this.FalecidoFilhos.Size = new System.Drawing.Size(489, 210);
            this.FalecidoFilhos.TabIndex = 0;
            this.FalecidoFilhos.TabStop = false;
            this.FalecidoFilhos.ToolTipContext = null;
            this.FalecidoFilhos.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoFilhos.Validations")));
            this.FalecidoFilhos.ValueControl = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FalecidoData);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Location = new System.Drawing.Point(14, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1053, 81);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // FalecidoData
            // 
            this.FalecidoData.Caption = "";
            this.FalecidoData.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.FalecidoData.CenterCaption = false;
            this.FalecidoData.ComponentBackColor = System.Drawing.Color.White;
            this.FalecidoData.CustomFormat = null;
            this.FalecidoData.Disable = true;
            this.FalecidoData.FieldValid = true;
            this.FalecidoData.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FalecidoData.Form = null;
            this.FalecidoData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FalecidoData.FormType = null;
            this.FalecidoData.IsDependecyUkey = false;
            this.FalecidoData.Location = new System.Drawing.Point(179, 17);
            this.FalecidoData.Name = "FalecidoData";
            this.FalecidoData.ObjectControl = null;
            this.FalecidoData.ObjetoApp = null;
            this.FalecidoData.PropertyControl = null;
            this.FalecidoData.PropertyDependecyUkey = null;
            this.FalecidoData.Size = new System.Drawing.Size(134, 56);
            this.FalecidoData.TabIndex = 77;
            this.FalecidoData.TabStop = false;
            this.FalecidoData.ToolTipContext = null;
            this.FalecidoData.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("FalecidoData.Validations")));
            this.FalecidoData.ValueControl = new System.DateTime(2016, 12, 31, 15, 9, 23, 331);
            // 
            // Id
            // 
            this.Id.Caption = "";
            this.Id.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.Id.CenterCaption = false;
            this.Id.ComponentBackColor = System.Drawing.Color.White;
            this.Id.DecimalPlaces = 0;
            this.Id.Disable = true;
            this.Id.Enabled = false;
            this.Id.FieldValid = true;
            this.Id.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Id.Form = null;
            this.Id.FormType = null;
            this.Id.IsDependecyUkey = false;
            this.Id.Location = new System.Drawing.Point(8, 17);
            this.Id.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Id.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Id.Name = "Id";
            this.Id.ObjectControl = null;
            this.Id.ObjetoApp = null;
            this.Id.PropertyControl = null;
            this.Id.PropertyDependecyUkey = null;
            this.Id.Size = new System.Drawing.Size(165, 56);
            this.Id.TabIndex = 76;
            this.Id.TabStop = false;
            this.Id.Text = "sNumeric1";
            this.Id.ThousandsSeparator = false;
            this.Id.ToolTipContext = null;
            this.Id.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("Id.Validations")));
            this.Id.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dadosDoObitoTabPage
            // 
            this.dadosDoObitoTabPage.BackColor = System.Drawing.Color.White;
            this.dadosDoObitoTabPage.Controls.Add(this.DadosObitotabControl);
            this.dadosDoObitoTabPage.Location = new System.Drawing.Point(4, 30);
            this.dadosDoObitoTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dadosDoObitoTabPage.Name = "dadosDoObitoTabPage";
            this.dadosDoObitoTabPage.Size = new System.Drawing.Size(606, 197);
            this.dadosDoObitoTabPage.TabIndex = 1;
            this.dadosDoObitoTabPage.Text = "DADOS DO ÓBITO";
            // 
            // DadosObitotabControl
            // 
            this.DadosObitotabControl.Controls.Add(this.dadosGeraistabPage);
            this.DadosObitotabControl.Controls.Add(this.tabPage2);
            this.DadosObitotabControl.Controls.Add(this.tabPage1);
            this.DadosObitotabControl.Controls.Add(this.tabPage3);
            this.DadosObitotabControl.Controls.Add(this.tabPage4);
            this.DadosObitotabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DadosObitotabControl.Location = new System.Drawing.Point(0, 0);
            this.DadosObitotabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DadosObitotabControl.Name = "DadosObitotabControl";
            this.DadosObitotabControl.SelectedIndex = 0;
            this.DadosObitotabControl.Size = new System.Drawing.Size(606, 197);
            this.DadosObitotabControl.TabIndex = 2;
            // 
            // dadosGeraistabPage
            // 
            this.dadosGeraistabPage.BackColor = System.Drawing.Color.White;
            this.dadosGeraistabPage.Controls.Add(this.groupBox2);
            this.dadosGeraistabPage.Location = new System.Drawing.Point(4, 30);
            this.dadosGeraistabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dadosGeraistabPage.Name = "dadosGeraistabPage";
            this.dadosGeraistabPage.Size = new System.Drawing.Size(598, 163);
            this.dadosGeraistabPage.TabIndex = 0;
            this.dadosGeraistabPage.Text = "Dados Gerais";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ObitoEstadoSepultamentoId);
            this.groupBox2.Controls.Add(this.ObitoCidadeSepultamentoId);
            this.groupBox2.Controls.Add(this.ObitoHoraSepultamento);
            this.groupBox2.Controls.Add(this.ObitoDataSepultamento);
            this.groupBox2.Controls.Add(this.ObitoLocalSepultamento);
            this.groupBox2.Controls.Add(this.ObitoEstadoFalecimentoId);
            this.groupBox2.Controls.Add(this.ObitoCidadeFalecimentoId);
            this.groupBox2.Controls.Add(this.ObitoHoraFalecimento);
            this.groupBox2.Controls.Add(this.ObitoDataFalecimento);
            this.groupBox2.Controls.Add(this.ObitoLocalFalecimento);
            this.groupBox2.Location = new System.Drawing.Point(5, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1027, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Gerais";
            // 
            // ObitoEstadoSepultamentoId
            // 
            this.ObitoEstadoSepultamentoId.Caption = "";
            this.ObitoEstadoSepultamentoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoEstadoSepultamentoId.CenterCaption = false;
            this.ObitoEstadoSepultamentoId.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoEstadoSepultamentoId.DefaultValue = false;
            this.ObitoEstadoSepultamentoId.Disable = true;
            this.ObitoEstadoSepultamentoId.DisplayMember = "";
            this.ObitoEstadoSepultamentoId.FieldValid = true;
            this.ObitoEstadoSepultamentoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoEstadoSepultamentoId.Form = null;
            this.ObitoEstadoSepultamentoId.FormType = null;
            this.ObitoEstadoSepultamentoId.IsDependecyUkey = false;
            this.ObitoEstadoSepultamentoId.Location = new System.Drawing.Point(320, 213);
            this.ObitoEstadoSepultamentoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoEstadoSepultamentoId.Name = "ObitoEstadoSepultamentoId";
            this.ObitoEstadoSepultamentoId.ObjectControl = null;
            this.ObitoEstadoSepultamentoId.ObjetoApp = null;
            this.ObitoEstadoSepultamentoId.PropertyControl = null;
            this.ObitoEstadoSepultamentoId.PropertyDependecyUkey = null;
            this.ObitoEstadoSepultamentoId.Size = new System.Drawing.Size(155, 53);
            this.ObitoEstadoSepultamentoId.StandardValue = null;
            this.ObitoEstadoSepultamentoId.TabIndex = 100;
            this.ObitoEstadoSepultamentoId.TabStop = false;
            this.ObitoEstadoSepultamentoId.ToolTipContext = null;
            this.ObitoEstadoSepultamentoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoEstadoSepultamentoId.Validations")));
            this.ObitoEstadoSepultamentoId.ValueControl = null;
            this.ObitoEstadoSepultamentoId.ValueMember = "";
            // 
            // ObitoCidadeSepultamentoId
            // 
            this.ObitoCidadeSepultamentoId.Caption = "";
            this.ObitoCidadeSepultamentoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoCidadeSepultamentoId.CenterCaption = false;
            this.ObitoCidadeSepultamentoId.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoCidadeSepultamentoId.DefaultValue = false;
            this.ObitoCidadeSepultamentoId.Disable = true;
            this.ObitoCidadeSepultamentoId.DisplayMember = "";
            this.ObitoCidadeSepultamentoId.FieldValid = true;
            this.ObitoCidadeSepultamentoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoCidadeSepultamentoId.Form = null;
            this.ObitoCidadeSepultamentoId.FormType = null;
            this.ObitoCidadeSepultamentoId.IsDependecyUkey = false;
            this.ObitoCidadeSepultamentoId.Location = new System.Drawing.Point(7, 213);
            this.ObitoCidadeSepultamentoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoCidadeSepultamentoId.Name = "ObitoCidadeSepultamentoId";
            this.ObitoCidadeSepultamentoId.ObjectControl = null;
            this.ObitoCidadeSepultamentoId.ObjetoApp = null;
            this.ObitoCidadeSepultamentoId.PropertyControl = null;
            this.ObitoCidadeSepultamentoId.PropertyDependecyUkey = null;
            this.ObitoCidadeSepultamentoId.Size = new System.Drawing.Size(305, 53);
            this.ObitoCidadeSepultamentoId.StandardValue = null;
            this.ObitoCidadeSepultamentoId.TabIndex = 99;
            this.ObitoCidadeSepultamentoId.TabStop = false;
            this.ObitoCidadeSepultamentoId.ToolTipContext = null;
            this.ObitoCidadeSepultamentoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoCidadeSepultamentoId.Validations")));
            this.ObitoCidadeSepultamentoId.ValueControl = null;
            this.ObitoCidadeSepultamentoId.ValueMember = "";
            // 
            // ObitoHoraSepultamento
            // 
            this.ObitoHoraSepultamento.Caption = "";
            this.ObitoHoraSepultamento.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoHoraSepultamento.CenterCaption = false;
            this.ObitoHoraSepultamento.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoHoraSepultamento.CustomFormat = null;
            this.ObitoHoraSepultamento.Disable = true;
            this.ObitoHoraSepultamento.FieldValid = true;
            this.ObitoHoraSepultamento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoHoraSepultamento.Form = null;
            this.ObitoHoraSepultamento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ObitoHoraSepultamento.FormType = null;
            this.ObitoHoraSepultamento.IsDependecyUkey = false;
            this.ObitoHoraSepultamento.Location = new System.Drawing.Point(147, 152);
            this.ObitoHoraSepultamento.Name = "ObitoHoraSepultamento";
            this.ObitoHoraSepultamento.ObjectControl = null;
            this.ObitoHoraSepultamento.ObjetoApp = null;
            this.ObitoHoraSepultamento.PropertyControl = null;
            this.ObitoHoraSepultamento.PropertyDependecyUkey = null;
            this.ObitoHoraSepultamento.Size = new System.Drawing.Size(100, 53);
            this.ObitoHoraSepultamento.TabIndex = 98;
            this.ObitoHoraSepultamento.TabStop = false;
            this.ObitoHoraSepultamento.ToolTipContext = null;
            this.ObitoHoraSepultamento.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoHoraSepultamento.Validations")));
            this.ObitoHoraSepultamento.ValueControl = new System.DateTime(2016, 12, 31, 15, 9, 23, 433);
            // 
            // ObitoDataSepultamento
            // 
            this.ObitoDataSepultamento.Caption = "";
            this.ObitoDataSepultamento.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoDataSepultamento.CenterCaption = false;
            this.ObitoDataSepultamento.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoDataSepultamento.CustomFormat = null;
            this.ObitoDataSepultamento.Disable = true;
            this.ObitoDataSepultamento.FieldValid = true;
            this.ObitoDataSepultamento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoDataSepultamento.Form = null;
            this.ObitoDataSepultamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ObitoDataSepultamento.FormType = null;
            this.ObitoDataSepultamento.IsDependecyUkey = false;
            this.ObitoDataSepultamento.Location = new System.Drawing.Point(7, 152);
            this.ObitoDataSepultamento.Name = "ObitoDataSepultamento";
            this.ObitoDataSepultamento.ObjectControl = null;
            this.ObitoDataSepultamento.ObjetoApp = null;
            this.ObitoDataSepultamento.PropertyControl = null;
            this.ObitoDataSepultamento.PropertyDependecyUkey = null;
            this.ObitoDataSepultamento.Size = new System.Drawing.Size(134, 53);
            this.ObitoDataSepultamento.TabIndex = 97;
            this.ObitoDataSepultamento.TabStop = false;
            this.ObitoDataSepultamento.ToolTipContext = null;
            this.ObitoDataSepultamento.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoDataSepultamento.Validations")));
            this.ObitoDataSepultamento.ValueControl = new System.DateTime(2016, 12, 31, 15, 9, 23, 436);
            // 
            // ObitoLocalSepultamento
            // 
            this.ObitoLocalSepultamento.Caption = "";
            this.ObitoLocalSepultamento.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoLocalSepultamento.CenterCaption = false;
            this.ObitoLocalSepultamento.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoLocalSepultamento.Disable = true;
            this.ObitoLocalSepultamento.FieldValid = true;
            this.ObitoLocalSepultamento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoLocalSepultamento.Form = null;
            this.ObitoLocalSepultamento.FormType = null;
            this.ObitoLocalSepultamento.IsDependecyUkey = false;
            this.ObitoLocalSepultamento.Location = new System.Drawing.Point(254, 154);
            this.ObitoLocalSepultamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoLocalSepultamento.Name = "ObitoLocalSepultamento";
            this.ObitoLocalSepultamento.ObjectControl = null;
            this.ObitoLocalSepultamento.ObjetoApp = null;
            this.ObitoLocalSepultamento.PropertyControl = null;
            this.ObitoLocalSepultamento.PropertyDependecyUkey = null;
            this.ObitoLocalSepultamento.Size = new System.Drawing.Size(765, 53);
            this.ObitoLocalSepultamento.TabIndex = 96;
            this.ObitoLocalSepultamento.TabStop = false;
            this.ObitoLocalSepultamento.ToolTipContext = null;
            this.ObitoLocalSepultamento.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoLocalSepultamento.Validations")));
            this.ObitoLocalSepultamento.ValueControl = "";
            // 
            // ObitoEstadoFalecimentoId
            // 
            this.ObitoEstadoFalecimentoId.Caption = "";
            this.ObitoEstadoFalecimentoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoEstadoFalecimentoId.CenterCaption = false;
            this.ObitoEstadoFalecimentoId.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoEstadoFalecimentoId.DefaultValue = false;
            this.ObitoEstadoFalecimentoId.Disable = true;
            this.ObitoEstadoFalecimentoId.DisplayMember = "";
            this.ObitoEstadoFalecimentoId.FieldValid = true;
            this.ObitoEstadoFalecimentoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoEstadoFalecimentoId.Form = null;
            this.ObitoEstadoFalecimentoId.FormType = null;
            this.ObitoEstadoFalecimentoId.IsDependecyUkey = false;
            this.ObitoEstadoFalecimentoId.Location = new System.Drawing.Point(320, 91);
            this.ObitoEstadoFalecimentoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoEstadoFalecimentoId.Name = "ObitoEstadoFalecimentoId";
            this.ObitoEstadoFalecimentoId.ObjectControl = null;
            this.ObitoEstadoFalecimentoId.ObjetoApp = null;
            this.ObitoEstadoFalecimentoId.PropertyControl = null;
            this.ObitoEstadoFalecimentoId.PropertyDependecyUkey = null;
            this.ObitoEstadoFalecimentoId.Size = new System.Drawing.Size(155, 53);
            this.ObitoEstadoFalecimentoId.StandardValue = null;
            this.ObitoEstadoFalecimentoId.TabIndex = 87;
            this.ObitoEstadoFalecimentoId.TabStop = false;
            this.ObitoEstadoFalecimentoId.ToolTipContext = null;
            this.ObitoEstadoFalecimentoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoEstadoFalecimentoId.Validations")));
            this.ObitoEstadoFalecimentoId.ValueControl = null;
            this.ObitoEstadoFalecimentoId.ValueMember = "";
            // 
            // ObitoCidadeFalecimentoId
            // 
            this.ObitoCidadeFalecimentoId.Caption = "";
            this.ObitoCidadeFalecimentoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoCidadeFalecimentoId.CenterCaption = false;
            this.ObitoCidadeFalecimentoId.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoCidadeFalecimentoId.DefaultValue = false;
            this.ObitoCidadeFalecimentoId.Disable = true;
            this.ObitoCidadeFalecimentoId.DisplayMember = "";
            this.ObitoCidadeFalecimentoId.FieldValid = true;
            this.ObitoCidadeFalecimentoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoCidadeFalecimentoId.Form = null;
            this.ObitoCidadeFalecimentoId.FormType = null;
            this.ObitoCidadeFalecimentoId.IsDependecyUkey = false;
            this.ObitoCidadeFalecimentoId.Location = new System.Drawing.Point(7, 91);
            this.ObitoCidadeFalecimentoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoCidadeFalecimentoId.Name = "ObitoCidadeFalecimentoId";
            this.ObitoCidadeFalecimentoId.ObjectControl = null;
            this.ObitoCidadeFalecimentoId.ObjetoApp = null;
            this.ObitoCidadeFalecimentoId.PropertyControl = null;
            this.ObitoCidadeFalecimentoId.PropertyDependecyUkey = null;
            this.ObitoCidadeFalecimentoId.Size = new System.Drawing.Size(305, 53);
            this.ObitoCidadeFalecimentoId.StandardValue = null;
            this.ObitoCidadeFalecimentoId.TabIndex = 84;
            this.ObitoCidadeFalecimentoId.TabStop = false;
            this.ObitoCidadeFalecimentoId.ToolTipContext = null;
            this.ObitoCidadeFalecimentoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoCidadeFalecimentoId.Validations")));
            this.ObitoCidadeFalecimentoId.ValueControl = null;
            this.ObitoCidadeFalecimentoId.ValueMember = "";
            // 
            // ObitoHoraFalecimento
            // 
            this.ObitoHoraFalecimento.Caption = "";
            this.ObitoHoraFalecimento.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoHoraFalecimento.CenterCaption = false;
            this.ObitoHoraFalecimento.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoHoraFalecimento.CustomFormat = null;
            this.ObitoHoraFalecimento.Disable = true;
            this.ObitoHoraFalecimento.FieldValid = true;
            this.ObitoHoraFalecimento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoHoraFalecimento.Form = null;
            this.ObitoHoraFalecimento.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ObitoHoraFalecimento.FormType = null;
            this.ObitoHoraFalecimento.IsDependecyUkey = false;
            this.ObitoHoraFalecimento.Location = new System.Drawing.Point(147, 30);
            this.ObitoHoraFalecimento.Name = "ObitoHoraFalecimento";
            this.ObitoHoraFalecimento.ObjectControl = null;
            this.ObitoHoraFalecimento.ObjetoApp = null;
            this.ObitoHoraFalecimento.PropertyControl = null;
            this.ObitoHoraFalecimento.PropertyDependecyUkey = null;
            this.ObitoHoraFalecimento.Size = new System.Drawing.Size(100, 53);
            this.ObitoHoraFalecimento.TabIndex = 82;
            this.ObitoHoraFalecimento.TabStop = false;
            this.ObitoHoraFalecimento.ToolTipContext = null;
            this.ObitoHoraFalecimento.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoHoraFalecimento.Validations")));
            this.ObitoHoraFalecimento.ValueControl = new System.DateTime(2016, 12, 31, 15, 9, 23, 452);
            // 
            // ObitoDataFalecimento
            // 
            this.ObitoDataFalecimento.Caption = "";
            this.ObitoDataFalecimento.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoDataFalecimento.CenterCaption = false;
            this.ObitoDataFalecimento.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoDataFalecimento.CustomFormat = null;
            this.ObitoDataFalecimento.Disable = true;
            this.ObitoDataFalecimento.FieldValid = true;
            this.ObitoDataFalecimento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoDataFalecimento.Form = null;
            this.ObitoDataFalecimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ObitoDataFalecimento.FormType = null;
            this.ObitoDataFalecimento.IsDependecyUkey = false;
            this.ObitoDataFalecimento.Location = new System.Drawing.Point(7, 30);
            this.ObitoDataFalecimento.Name = "ObitoDataFalecimento";
            this.ObitoDataFalecimento.ObjectControl = null;
            this.ObitoDataFalecimento.ObjetoApp = null;
            this.ObitoDataFalecimento.PropertyControl = null;
            this.ObitoDataFalecimento.PropertyDependecyUkey = null;
            this.ObitoDataFalecimento.Size = new System.Drawing.Size(134, 53);
            this.ObitoDataFalecimento.TabIndex = 77;
            this.ObitoDataFalecimento.TabStop = false;
            this.ObitoDataFalecimento.ToolTipContext = null;
            this.ObitoDataFalecimento.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoDataFalecimento.Validations")));
            this.ObitoDataFalecimento.ValueControl = new System.DateTime(2016, 12, 31, 15, 9, 23, 455);
            // 
            // ObitoLocalFalecimento
            // 
            this.ObitoLocalFalecimento.Caption = "";
            this.ObitoLocalFalecimento.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoLocalFalecimento.CenterCaption = false;
            this.ObitoLocalFalecimento.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoLocalFalecimento.Disable = true;
            this.ObitoLocalFalecimento.FieldValid = true;
            this.ObitoLocalFalecimento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoLocalFalecimento.Form = null;
            this.ObitoLocalFalecimento.FormType = null;
            this.ObitoLocalFalecimento.IsDependecyUkey = false;
            this.ObitoLocalFalecimento.Location = new System.Drawing.Point(254, 32);
            this.ObitoLocalFalecimento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoLocalFalecimento.Name = "ObitoLocalFalecimento";
            this.ObitoLocalFalecimento.ObjectControl = null;
            this.ObitoLocalFalecimento.ObjetoApp = null;
            this.ObitoLocalFalecimento.PropertyControl = null;
            this.ObitoLocalFalecimento.PropertyDependecyUkey = null;
            this.ObitoLocalFalecimento.Size = new System.Drawing.Size(765, 53);
            this.ObitoLocalFalecimento.TabIndex = 75;
            this.ObitoLocalFalecimento.TabStop = false;
            this.ObitoLocalFalecimento.ToolTipContext = null;
            this.ObitoLocalFalecimento.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoLocalFalecimento.Validations")));
            this.ObitoLocalFalecimento.ValueControl = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1059, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Declaração Médica";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ObitoCausaMorte);
            this.groupBox3.Controls.Add(this.ObitoMedico2Crm);
            this.groupBox3.Controls.Add(this.ObitoMedico2);
            this.groupBox3.Controls.Add(this.ObitoMedicoCrm);
            this.groupBox3.Controls.Add(this.ObitoMedico1);
            this.groupBox3.Location = new System.Drawing.Point(24, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(940, 304);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Declaração Médica";
            // 
            // ObitoCausaMorte
            // 
            this.ObitoCausaMorte.Caption = "";
            this.ObitoCausaMorte.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoCausaMorte.CenterCaption = false;
            this.ObitoCausaMorte.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoCausaMorte.Disable = true;
            this.ObitoCausaMorte.FieldValid = true;
            this.ObitoCausaMorte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoCausaMorte.Form = null;
            this.ObitoCausaMorte.FormType = null;
            this.ObitoCausaMorte.IsDependecyUkey = false;
            this.ObitoCausaMorte.Location = new System.Drawing.Point(8, 156);
            this.ObitoCausaMorte.Name = "ObitoCausaMorte";
            this.ObitoCausaMorte.ObjectControl = null;
            this.ObitoCausaMorte.ObjetoApp = null;
            this.ObitoCausaMorte.PropertyControl = null;
            this.ObitoCausaMorte.PropertyDependecyUkey = null;
            this.ObitoCausaMorte.Size = new System.Drawing.Size(920, 134);
            this.ObitoCausaMorte.TabIndex = 85;
            this.ObitoCausaMorte.TabStop = false;
            this.ObitoCausaMorte.ToolTipContext = null;
            this.ObitoCausaMorte.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoCausaMorte.Validations")));
            this.ObitoCausaMorte.ValueControl = "";
            // 
            // ObitoMedico2Crm
            // 
            this.ObitoMedico2Crm.Caption = "";
            this.ObitoMedico2Crm.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoMedico2Crm.CenterCaption = false;
            this.ObitoMedico2Crm.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoMedico2Crm.Disable = true;
            this.ObitoMedico2Crm.FieldValid = true;
            this.ObitoMedico2Crm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoMedico2Crm.Form = null;
            this.ObitoMedico2Crm.FormType = null;
            this.ObitoMedico2Crm.IsDependecyUkey = false;
            this.ObitoMedico2Crm.Location = new System.Drawing.Point(556, 95);
            this.ObitoMedico2Crm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoMedico2Crm.Name = "ObitoMedico2Crm";
            this.ObitoMedico2Crm.ObjectControl = null;
            this.ObitoMedico2Crm.ObjetoApp = null;
            this.ObitoMedico2Crm.PropertyControl = null;
            this.ObitoMedico2Crm.PropertyDependecyUkey = null;
            this.ObitoMedico2Crm.Size = new System.Drawing.Size(372, 53);
            this.ObitoMedico2Crm.TabIndex = 84;
            this.ObitoMedico2Crm.TabStop = false;
            this.ObitoMedico2Crm.ToolTipContext = null;
            this.ObitoMedico2Crm.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoMedico2Crm.Validations")));
            this.ObitoMedico2Crm.ValueControl = "";
            // 
            // ObitoMedico2
            // 
            this.ObitoMedico2.Caption = "";
            this.ObitoMedico2.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoMedico2.CenterCaption = false;
            this.ObitoMedico2.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoMedico2.Disable = true;
            this.ObitoMedico2.FieldValid = true;
            this.ObitoMedico2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoMedico2.Form = null;
            this.ObitoMedico2.FormType = null;
            this.ObitoMedico2.IsDependecyUkey = false;
            this.ObitoMedico2.Location = new System.Drawing.Point(8, 95);
            this.ObitoMedico2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoMedico2.Name = "ObitoMedico2";
            this.ObitoMedico2.ObjectControl = null;
            this.ObitoMedico2.ObjetoApp = null;
            this.ObitoMedico2.PropertyControl = null;
            this.ObitoMedico2.PropertyDependecyUkey = null;
            this.ObitoMedico2.Size = new System.Drawing.Size(540, 53);
            this.ObitoMedico2.TabIndex = 81;
            this.ObitoMedico2.TabStop = false;
            this.ObitoMedico2.ToolTipContext = null;
            this.ObitoMedico2.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoMedico2.Validations")));
            this.ObitoMedico2.ValueControl = "";
            // 
            // ObitoMedicoCrm
            // 
            this.ObitoMedicoCrm.Caption = "";
            this.ObitoMedicoCrm.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoMedicoCrm.CenterCaption = false;
            this.ObitoMedicoCrm.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoMedicoCrm.Disable = true;
            this.ObitoMedicoCrm.FieldValid = true;
            this.ObitoMedicoCrm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoMedicoCrm.Form = null;
            this.ObitoMedicoCrm.FormType = null;
            this.ObitoMedicoCrm.IsDependecyUkey = false;
            this.ObitoMedicoCrm.Location = new System.Drawing.Point(556, 32);
            this.ObitoMedicoCrm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoMedicoCrm.Name = "ObitoMedicoCrm";
            this.ObitoMedicoCrm.ObjectControl = null;
            this.ObitoMedicoCrm.ObjetoApp = null;
            this.ObitoMedicoCrm.PropertyControl = null;
            this.ObitoMedicoCrm.PropertyDependecyUkey = null;
            this.ObitoMedicoCrm.Size = new System.Drawing.Size(372, 53);
            this.ObitoMedicoCrm.TabIndex = 79;
            this.ObitoMedicoCrm.TabStop = false;
            this.ObitoMedicoCrm.ToolTipContext = null;
            this.ObitoMedicoCrm.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoMedicoCrm.Validations")));
            this.ObitoMedicoCrm.ValueControl = "";
            // 
            // ObitoMedico1
            // 
            this.ObitoMedico1.Caption = "";
            this.ObitoMedico1.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoMedico1.CenterCaption = false;
            this.ObitoMedico1.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoMedico1.Disable = true;
            this.ObitoMedico1.FieldValid = true;
            this.ObitoMedico1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoMedico1.Form = null;
            this.ObitoMedico1.FormType = null;
            this.ObitoMedico1.IsDependecyUkey = false;
            this.ObitoMedico1.Location = new System.Drawing.Point(8, 32);
            this.ObitoMedico1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoMedico1.Name = "ObitoMedico1";
            this.ObitoMedico1.ObjectControl = null;
            this.ObitoMedico1.ObjetoApp = null;
            this.ObitoMedico1.PropertyControl = null;
            this.ObitoMedico1.PropertyDependecyUkey = null;
            this.ObitoMedico1.Size = new System.Drawing.Size(540, 53);
            this.ObitoMedico1.TabIndex = 77;
            this.ObitoMedico1.TabStop = false;
            this.ObitoMedico1.ToolTipContext = null;
            this.ObitoMedico1.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoMedico1.Validations")));
            this.ObitoMedico1.ValueControl = "";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1059, 459);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Dados da Declaração";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ObitoEnderecoCartorio);
            this.groupBox4.Controls.Add(this.ObitoNota);
            this.groupBox4.Controls.Add(this.ObitoCartorio);
            this.groupBox4.Controls.Add(this.ObitoAgencia);
            this.groupBox4.Location = new System.Drawing.Point(165, 80);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(709, 162);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Declaração Médica";
            // 
            // ObitoEnderecoCartorio
            // 
            this.ObitoEnderecoCartorio.Caption = "";
            this.ObitoEnderecoCartorio.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoEnderecoCartorio.CenterCaption = false;
            this.ObitoEnderecoCartorio.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoEnderecoCartorio.Disable = true;
            this.ObitoEnderecoCartorio.FieldValid = true;
            this.ObitoEnderecoCartorio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoEnderecoCartorio.Form = null;
            this.ObitoEnderecoCartorio.FormType = null;
            this.ObitoEnderecoCartorio.IsDependecyUkey = false;
            this.ObitoEnderecoCartorio.Location = new System.Drawing.Point(8, 93);
            this.ObitoEnderecoCartorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoEnderecoCartorio.Name = "ObitoEnderecoCartorio";
            this.ObitoEnderecoCartorio.ObjectControl = null;
            this.ObitoEnderecoCartorio.ObjetoApp = null;
            this.ObitoEnderecoCartorio.PropertyControl = null;
            this.ObitoEnderecoCartorio.PropertyDependecyUkey = null;
            this.ObitoEnderecoCartorio.Size = new System.Drawing.Size(688, 51);
            this.ObitoEnderecoCartorio.TabIndex = 85;
            this.ObitoEnderecoCartorio.TabStop = false;
            this.ObitoEnderecoCartorio.ToolTipContext = null;
            this.ObitoEnderecoCartorio.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoEnderecoCartorio.Validations")));
            this.ObitoEnderecoCartorio.ValueControl = "";
            // 
            // ObitoNota
            // 
            this.ObitoNota.Caption = "";
            this.ObitoNota.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoNota.CenterCaption = false;
            this.ObitoNota.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoNota.Disable = true;
            this.ObitoNota.FieldValid = true;
            this.ObitoNota.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoNota.Form = null;
            this.ObitoNota.FormType = null;
            this.ObitoNota.IsDependecyUkey = false;
            this.ObitoNota.Location = new System.Drawing.Point(472, 32);
            this.ObitoNota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoNota.Name = "ObitoNota";
            this.ObitoNota.ObjectControl = null;
            this.ObitoNota.ObjetoApp = null;
            this.ObitoNota.PropertyControl = null;
            this.ObitoNota.PropertyDependecyUkey = null;
            this.ObitoNota.Size = new System.Drawing.Size(224, 51);
            this.ObitoNota.TabIndex = 83;
            this.ObitoNota.TabStop = false;
            this.ObitoNota.ToolTipContext = null;
            this.ObitoNota.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoNota.Validations")));
            this.ObitoNota.ValueControl = "";
            // 
            // ObitoCartorio
            // 
            this.ObitoCartorio.Caption = "";
            this.ObitoCartorio.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoCartorio.CenterCaption = false;
            this.ObitoCartorio.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoCartorio.Disable = true;
            this.ObitoCartorio.FieldValid = true;
            this.ObitoCartorio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoCartorio.Form = null;
            this.ObitoCartorio.FormType = null;
            this.ObitoCartorio.IsDependecyUkey = false;
            this.ObitoCartorio.Location = new System.Drawing.Point(240, 32);
            this.ObitoCartorio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoCartorio.Name = "ObitoCartorio";
            this.ObitoCartorio.ObjectControl = null;
            this.ObitoCartorio.ObjetoApp = null;
            this.ObitoCartorio.PropertyControl = null;
            this.ObitoCartorio.PropertyDependecyUkey = null;
            this.ObitoCartorio.Size = new System.Drawing.Size(224, 51);
            this.ObitoCartorio.TabIndex = 81;
            this.ObitoCartorio.TabStop = false;
            this.ObitoCartorio.ToolTipContext = null;
            this.ObitoCartorio.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoCartorio.Validations")));
            this.ObitoCartorio.ValueControl = "";
            // 
            // ObitoAgencia
            // 
            this.ObitoAgencia.Caption = "";
            this.ObitoAgencia.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoAgencia.CenterCaption = false;
            this.ObitoAgencia.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoAgencia.Disable = true;
            this.ObitoAgencia.FieldValid = true;
            this.ObitoAgencia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoAgencia.Form = null;
            this.ObitoAgencia.FormType = null;
            this.ObitoAgencia.IsDependecyUkey = false;
            this.ObitoAgencia.Location = new System.Drawing.Point(8, 32);
            this.ObitoAgencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoAgencia.Name = "ObitoAgencia";
            this.ObitoAgencia.ObjectControl = null;
            this.ObitoAgencia.ObjetoApp = null;
            this.ObitoAgencia.PropertyControl = null;
            this.ObitoAgencia.PropertyDependecyUkey = null;
            this.ObitoAgencia.Size = new System.Drawing.Size(224, 51);
            this.ObitoAgencia.TabIndex = 79;
            this.ObitoAgencia.TabStop = false;
            this.ObitoAgencia.ToolTipContext = null;
            this.ObitoAgencia.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoAgencia.Validations")));
            this.ObitoAgencia.ValueControl = "";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1059, 459);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Dados do Declarante";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ObitoDeclaranteTelefone);
            this.groupBox5.Controls.Add(this.ObitoDeclaranteEstadoId);
            this.groupBox5.Controls.Add(this.ObitoDeclaranteCidadeId);
            this.groupBox5.Controls.Add(this.ObitoDeclaranteBairro);
            this.groupBox5.Controls.Add(this.ObitoDeclaranteEndereco);
            this.groupBox5.Controls.Add(this.ObitoDeclaranteCep);
            this.groupBox5.Controls.Add(this.ObitoDeclaranteProfissaoId);
            this.groupBox5.Controls.Add(this.ObitoDeclaranteGrauParentesco);
            this.groupBox5.Controls.Add(this.ObitoDeclaranteCpf);
            this.groupBox5.Controls.Add(this.ObitoDeclaranteRg);
            this.groupBox5.Controls.Add(this.ObitoDeclarante);
            this.groupBox5.Location = new System.Drawing.Point(19, 27);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(1016, 280);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            // 
            // ObitoDeclaranteTelefone
            // 
            this.ObitoDeclaranteTelefone.Caption = "";
            this.ObitoDeclaranteTelefone.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoDeclaranteTelefone.CenterCaption = false;
            this.ObitoDeclaranteTelefone.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoDeclaranteTelefone.Disable = true;
            this.ObitoDeclaranteTelefone.FieldValid = true;
            this.ObitoDeclaranteTelefone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoDeclaranteTelefone.Form = null;
            this.ObitoDeclaranteTelefone.FormType = null;
            this.ObitoDeclaranteTelefone.IsDependecyUkey = false;
            this.ObitoDeclaranteTelefone.Location = new System.Drawing.Point(8, 93);
            this.ObitoDeclaranteTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoDeclaranteTelefone.Name = "ObitoDeclaranteTelefone";
            this.ObitoDeclaranteTelefone.ObjectControl = null;
            this.ObitoDeclaranteTelefone.ObjetoApp = null;
            this.ObitoDeclaranteTelefone.PropertyControl = null;
            this.ObitoDeclaranteTelefone.PropertyDependecyUkey = null;
            this.ObitoDeclaranteTelefone.Size = new System.Drawing.Size(182, 51);
            this.ObitoDeclaranteTelefone.TabIndex = 103;
            this.ObitoDeclaranteTelefone.TabStop = false;
            this.ObitoDeclaranteTelefone.ToolTipContext = null;
            this.ObitoDeclaranteTelefone.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoDeclaranteTelefone.Validations")));
            this.ObitoDeclaranteTelefone.ValueControl = "";
            // 
            // ObitoDeclaranteEstadoId
            // 
            this.ObitoDeclaranteEstadoId.Caption = "";
            this.ObitoDeclaranteEstadoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoDeclaranteEstadoId.CenterCaption = false;
            this.ObitoDeclaranteEstadoId.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoDeclaranteEstadoId.DefaultValue = false;
            this.ObitoDeclaranteEstadoId.Disable = true;
            this.ObitoDeclaranteEstadoId.DisplayMember = "";
            this.ObitoDeclaranteEstadoId.FieldValid = true;
            this.ObitoDeclaranteEstadoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoDeclaranteEstadoId.Form = null;
            this.ObitoDeclaranteEstadoId.FormType = null;
            this.ObitoDeclaranteEstadoId.IsDependecyUkey = false;
            this.ObitoDeclaranteEstadoId.Location = new System.Drawing.Point(901, 154);
            this.ObitoDeclaranteEstadoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoDeclaranteEstadoId.Name = "ObitoDeclaranteEstadoId";
            this.ObitoDeclaranteEstadoId.ObjectControl = null;
            this.ObitoDeclaranteEstadoId.ObjetoApp = null;
            this.ObitoDeclaranteEstadoId.PropertyControl = null;
            this.ObitoDeclaranteEstadoId.PropertyDependecyUkey = null;
            this.ObitoDeclaranteEstadoId.Size = new System.Drawing.Size(88, 51);
            this.ObitoDeclaranteEstadoId.StandardValue = null;
            this.ObitoDeclaranteEstadoId.TabIndex = 101;
            this.ObitoDeclaranteEstadoId.TabStop = false;
            this.ObitoDeclaranteEstadoId.ToolTipContext = null;
            this.ObitoDeclaranteEstadoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoDeclaranteEstadoId.Validations")));
            this.ObitoDeclaranteEstadoId.ValueControl = null;
            this.ObitoDeclaranteEstadoId.ValueMember = "";
            // 
            // ObitoDeclaranteCidadeId
            // 
            this.ObitoDeclaranteCidadeId.Caption = "";
            this.ObitoDeclaranteCidadeId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoDeclaranteCidadeId.CenterCaption = false;
            this.ObitoDeclaranteCidadeId.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoDeclaranteCidadeId.DefaultValue = false;
            this.ObitoDeclaranteCidadeId.Disable = true;
            this.ObitoDeclaranteCidadeId.DisplayMember = "";
            this.ObitoDeclaranteCidadeId.FieldValid = true;
            this.ObitoDeclaranteCidadeId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoDeclaranteCidadeId.Form = null;
            this.ObitoDeclaranteCidadeId.FormType = null;
            this.ObitoDeclaranteCidadeId.IsDependecyUkey = false;
            this.ObitoDeclaranteCidadeId.Location = new System.Drawing.Point(481, 154);
            this.ObitoDeclaranteCidadeId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoDeclaranteCidadeId.Name = "ObitoDeclaranteCidadeId";
            this.ObitoDeclaranteCidadeId.ObjectControl = null;
            this.ObitoDeclaranteCidadeId.ObjetoApp = null;
            this.ObitoDeclaranteCidadeId.PropertyControl = null;
            this.ObitoDeclaranteCidadeId.PropertyDependecyUkey = null;
            this.ObitoDeclaranteCidadeId.Size = new System.Drawing.Size(412, 51);
            this.ObitoDeclaranteCidadeId.StandardValue = null;
            this.ObitoDeclaranteCidadeId.TabIndex = 98;
            this.ObitoDeclaranteCidadeId.TabStop = false;
            this.ObitoDeclaranteCidadeId.ToolTipContext = null;
            this.ObitoDeclaranteCidadeId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoDeclaranteCidadeId.Validations")));
            this.ObitoDeclaranteCidadeId.ValueControl = null;
            this.ObitoDeclaranteCidadeId.ValueMember = "";
            // 
            // ObitoDeclaranteBairro
            // 
            this.ObitoDeclaranteBairro.Caption = "";
            this.ObitoDeclaranteBairro.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoDeclaranteBairro.CenterCaption = false;
            this.ObitoDeclaranteBairro.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoDeclaranteBairro.Disable = true;
            this.ObitoDeclaranteBairro.FieldValid = true;
            this.ObitoDeclaranteBairro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoDeclaranteBairro.Form = null;
            this.ObitoDeclaranteBairro.FormType = null;
            this.ObitoDeclaranteBairro.IsDependecyUkey = false;
            this.ObitoDeclaranteBairro.Location = new System.Drawing.Point(8, 154);
            this.ObitoDeclaranteBairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoDeclaranteBairro.Name = "ObitoDeclaranteBairro";
            this.ObitoDeclaranteBairro.ObjectControl = null;
            this.ObitoDeclaranteBairro.ObjetoApp = null;
            this.ObitoDeclaranteBairro.PropertyControl = null;
            this.ObitoDeclaranteBairro.PropertyDependecyUkey = null;
            this.ObitoDeclaranteBairro.Size = new System.Drawing.Size(465, 51);
            this.ObitoDeclaranteBairro.TabIndex = 96;
            this.ObitoDeclaranteBairro.TabStop = false;
            this.ObitoDeclaranteBairro.ToolTipContext = null;
            this.ObitoDeclaranteBairro.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoDeclaranteBairro.Validations")));
            this.ObitoDeclaranteBairro.ValueControl = "";
            // 
            // ObitoDeclaranteEndereco
            // 
            this.ObitoDeclaranteEndereco.Caption = "";
            this.ObitoDeclaranteEndereco.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoDeclaranteEndereco.CenterCaption = false;
            this.ObitoDeclaranteEndereco.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoDeclaranteEndereco.Disable = true;
            this.ObitoDeclaranteEndereco.FieldValid = true;
            this.ObitoDeclaranteEndereco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoDeclaranteEndereco.Form = null;
            this.ObitoDeclaranteEndereco.FormType = null;
            this.ObitoDeclaranteEndereco.IsDependecyUkey = false;
            this.ObitoDeclaranteEndereco.Location = new System.Drawing.Point(364, 93);
            this.ObitoDeclaranteEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoDeclaranteEndereco.Name = "ObitoDeclaranteEndereco";
            this.ObitoDeclaranteEndereco.ObjectControl = null;
            this.ObitoDeclaranteEndereco.ObjetoApp = null;
            this.ObitoDeclaranteEndereco.PropertyControl = null;
            this.ObitoDeclaranteEndereco.PropertyDependecyUkey = null;
            this.ObitoDeclaranteEndereco.Size = new System.Drawing.Size(625, 51);
            this.ObitoDeclaranteEndereco.TabIndex = 94;
            this.ObitoDeclaranteEndereco.TabStop = false;
            this.ObitoDeclaranteEndereco.ToolTipContext = null;
            this.ObitoDeclaranteEndereco.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoDeclaranteEndereco.Validations")));
            this.ObitoDeclaranteEndereco.ValueControl = "";
            // 
            // ObitoDeclaranteCep
            // 
            this.ObitoDeclaranteCep.Caption = "";
            this.ObitoDeclaranteCep.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoDeclaranteCep.CenterCaption = false;
            this.ObitoDeclaranteCep.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoDeclaranteCep.Disable = true;
            this.ObitoDeclaranteCep.FieldValid = true;
            this.ObitoDeclaranteCep.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoDeclaranteCep.Form = null;
            this.ObitoDeclaranteCep.FormType = null;
            this.ObitoDeclaranteCep.IsDependecyUkey = false;
            this.ObitoDeclaranteCep.Location = new System.Drawing.Point(198, 93);
            this.ObitoDeclaranteCep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoDeclaranteCep.Name = "ObitoDeclaranteCep";
            this.ObitoDeclaranteCep.ObjectControl = null;
            this.ObitoDeclaranteCep.ObjetoApp = null;
            this.ObitoDeclaranteCep.PropertyControl = null;
            this.ObitoDeclaranteCep.PropertyDependecyUkey = null;
            this.ObitoDeclaranteCep.Size = new System.Drawing.Size(158, 51);
            this.ObitoDeclaranteCep.TabIndex = 92;
            this.ObitoDeclaranteCep.TabStop = false;
            this.ObitoDeclaranteCep.ToolTipContext = null;
            this.ObitoDeclaranteCep.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoDeclaranteCep.Validations")));
            this.ObitoDeclaranteCep.ValueControl = "";
            // 
            // ObitoDeclaranteProfissaoId
            // 
            this.ObitoDeclaranteProfissaoId.Caption = "";
            this.ObitoDeclaranteProfissaoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoDeclaranteProfissaoId.CenterCaption = false;
            this.ObitoDeclaranteProfissaoId.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoDeclaranteProfissaoId.DefaultValue = false;
            this.ObitoDeclaranteProfissaoId.Disable = true;
            this.ObitoDeclaranteProfissaoId.DisplayMember = "";
            this.ObitoDeclaranteProfissaoId.FieldValid = true;
            this.ObitoDeclaranteProfissaoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoDeclaranteProfissaoId.Form = null;
            this.ObitoDeclaranteProfissaoId.FormType = null;
            this.ObitoDeclaranteProfissaoId.IsDependecyUkey = false;
            this.ObitoDeclaranteProfissaoId.Location = new System.Drawing.Point(8, 215);
            this.ObitoDeclaranteProfissaoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoDeclaranteProfissaoId.Name = "ObitoDeclaranteProfissaoId";
            this.ObitoDeclaranteProfissaoId.ObjectControl = null;
            this.ObitoDeclaranteProfissaoId.ObjetoApp = null;
            this.ObitoDeclaranteProfissaoId.PropertyControl = null;
            this.ObitoDeclaranteProfissaoId.PropertyDependecyUkey = null;
            this.ObitoDeclaranteProfissaoId.Size = new System.Drawing.Size(360, 51);
            this.ObitoDeclaranteProfissaoId.StandardValue = null;
            this.ObitoDeclaranteProfissaoId.TabIndex = 90;
            this.ObitoDeclaranteProfissaoId.TabStop = false;
            this.ObitoDeclaranteProfissaoId.ToolTipContext = null;
            this.ObitoDeclaranteProfissaoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoDeclaranteProfissaoId.Validations")));
            this.ObitoDeclaranteProfissaoId.ValueControl = null;
            this.ObitoDeclaranteProfissaoId.ValueMember = "";
            // 
            // ObitoDeclaranteGrauParentesco
            // 
            this.ObitoDeclaranteGrauParentesco.Caption = "";
            this.ObitoDeclaranteGrauParentesco.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoDeclaranteGrauParentesco.CenterCaption = false;
            this.ObitoDeclaranteGrauParentesco.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoDeclaranteGrauParentesco.Disable = true;
            this.ObitoDeclaranteGrauParentesco.FieldValid = true;
            this.ObitoDeclaranteGrauParentesco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoDeclaranteGrauParentesco.Form = null;
            this.ObitoDeclaranteGrauParentesco.FormType = null;
            this.ObitoDeclaranteGrauParentesco.IsDependecyUkey = false;
            this.ObitoDeclaranteGrauParentesco.Location = new System.Drawing.Point(826, 32);
            this.ObitoDeclaranteGrauParentesco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoDeclaranteGrauParentesco.Name = "ObitoDeclaranteGrauParentesco";
            this.ObitoDeclaranteGrauParentesco.ObjectControl = null;
            this.ObitoDeclaranteGrauParentesco.ObjetoApp = null;
            this.ObitoDeclaranteGrauParentesco.PropertyControl = null;
            this.ObitoDeclaranteGrauParentesco.PropertyDependecyUkey = null;
            this.ObitoDeclaranteGrauParentesco.Size = new System.Drawing.Size(164, 51);
            this.ObitoDeclaranteGrauParentesco.TabIndex = 87;
            this.ObitoDeclaranteGrauParentesco.TabStop = false;
            this.ObitoDeclaranteGrauParentesco.ToolTipContext = null;
            this.ObitoDeclaranteGrauParentesco.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoDeclaranteGrauParentesco.Validations")));
            this.ObitoDeclaranteGrauParentesco.ValueControl = "";
            // 
            // ObitoDeclaranteCpf
            // 
            this.ObitoDeclaranteCpf.Caption = "";
            this.ObitoDeclaranteCpf.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoDeclaranteCpf.CenterCaption = false;
            this.ObitoDeclaranteCpf.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoDeclaranteCpf.Disable = true;
            this.ObitoDeclaranteCpf.FieldValid = true;
            this.ObitoDeclaranteCpf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoDeclaranteCpf.Form = null;
            this.ObitoDeclaranteCpf.FormType = null;
            this.ObitoDeclaranteCpf.IsDependecyUkey = false;
            this.ObitoDeclaranteCpf.Location = new System.Drawing.Point(673, 32);
            this.ObitoDeclaranteCpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoDeclaranteCpf.Name = "ObitoDeclaranteCpf";
            this.ObitoDeclaranteCpf.ObjectControl = null;
            this.ObitoDeclaranteCpf.ObjetoApp = null;
            this.ObitoDeclaranteCpf.PropertyControl = null;
            this.ObitoDeclaranteCpf.PropertyDependecyUkey = null;
            this.ObitoDeclaranteCpf.Size = new System.Drawing.Size(145, 51);
            this.ObitoDeclaranteCpf.TabIndex = 85;
            this.ObitoDeclaranteCpf.TabStop = false;
            this.ObitoDeclaranteCpf.ToolTipContext = null;
            this.ObitoDeclaranteCpf.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoDeclaranteCpf.Validations")));
            this.ObitoDeclaranteCpf.ValueControl = "";
            // 
            // ObitoDeclaranteRg
            // 
            this.ObitoDeclaranteRg.Caption = "";
            this.ObitoDeclaranteRg.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoDeclaranteRg.CenterCaption = false;
            this.ObitoDeclaranteRg.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoDeclaranteRg.Disable = true;
            this.ObitoDeclaranteRg.FieldValid = true;
            this.ObitoDeclaranteRg.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoDeclaranteRg.Form = null;
            this.ObitoDeclaranteRg.FormType = null;
            this.ObitoDeclaranteRg.IsDependecyUkey = false;
            this.ObitoDeclaranteRg.Location = new System.Drawing.Point(521, 32);
            this.ObitoDeclaranteRg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoDeclaranteRg.Name = "ObitoDeclaranteRg";
            this.ObitoDeclaranteRg.ObjectControl = null;
            this.ObitoDeclaranteRg.ObjetoApp = null;
            this.ObitoDeclaranteRg.PropertyControl = null;
            this.ObitoDeclaranteRg.PropertyDependecyUkey = null;
            this.ObitoDeclaranteRg.Size = new System.Drawing.Size(144, 51);
            this.ObitoDeclaranteRg.TabIndex = 83;
            this.ObitoDeclaranteRg.TabStop = false;
            this.ObitoDeclaranteRg.ToolTipContext = null;
            this.ObitoDeclaranteRg.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoDeclaranteRg.Validations")));
            this.ObitoDeclaranteRg.ValueControl = "";
            // 
            // ObitoDeclarante
            // 
            this.ObitoDeclarante.Caption = "";
            this.ObitoDeclarante.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.ObitoDeclarante.CenterCaption = false;
            this.ObitoDeclarante.ComponentBackColor = System.Drawing.Color.White;
            this.ObitoDeclarante.Disable = true;
            this.ObitoDeclarante.FieldValid = true;
            this.ObitoDeclarante.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ObitoDeclarante.Form = null;
            this.ObitoDeclarante.FormType = null;
            this.ObitoDeclarante.IsDependecyUkey = false;
            this.ObitoDeclarante.Location = new System.Drawing.Point(8, 32);
            this.ObitoDeclarante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ObitoDeclarante.Name = "ObitoDeclarante";
            this.ObitoDeclarante.ObjectControl = null;
            this.ObitoDeclarante.ObjetoApp = null;
            this.ObitoDeclarante.PropertyControl = null;
            this.ObitoDeclarante.PropertyDependecyUkey = null;
            this.ObitoDeclarante.Size = new System.Drawing.Size(505, 51);
            this.ObitoDeclarante.TabIndex = 81;
            this.ObitoDeclarante.TabStop = false;
            this.ObitoDeclarante.ToolTipContext = null;
            this.ObitoDeclarante.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("ObitoDeclarante.Validations")));
            this.ObitoDeclarante.ValueControl = "";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1059, 459);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Atendente";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.SObitoAtendente2Id);
            this.groupBox6.Controls.Add(this.SObitoAtendente1Id);
            this.groupBox6.Location = new System.Drawing.Point(48, 50);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(924, 181);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // SObitoAtendente2Id
            // 
            this.SObitoAtendente2Id.Caption = "";
            this.SObitoAtendente2Id.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.SObitoAtendente2Id.CenterCaption = false;
            this.SObitoAtendente2Id.ComponentBackColor = System.Drawing.Color.White;
            this.SObitoAtendente2Id.DefaultValue = false;
            this.SObitoAtendente2Id.Disable = true;
            this.SObitoAtendente2Id.DisplayMember = "";
            this.SObitoAtendente2Id.FieldValid = true;
            this.SObitoAtendente2Id.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SObitoAtendente2Id.Form = null;
            this.SObitoAtendente2Id.FormType = null;
            this.SObitoAtendente2Id.IsDependecyUkey = false;
            this.SObitoAtendente2Id.Location = new System.Drawing.Point(19, 95);
            this.SObitoAtendente2Id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SObitoAtendente2Id.Name = "SObitoAtendente2Id";
            this.SObitoAtendente2Id.ObjectControl = null;
            this.SObitoAtendente2Id.ObjetoApp = null;
            this.SObitoAtendente2Id.PropertyControl = null;
            this.SObitoAtendente2Id.PropertyDependecyUkey = null;
            this.SObitoAtendente2Id.Size = new System.Drawing.Size(897, 53);
            this.SObitoAtendente2Id.StandardValue = null;
            this.SObitoAtendente2Id.TabIndex = 105;
            this.SObitoAtendente2Id.TabStop = false;
            this.SObitoAtendente2Id.ToolTipContext = null;
            this.SObitoAtendente2Id.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("SObitoAtendente2Id.Validations")));
            this.SObitoAtendente2Id.ValueControl = null;
            this.SObitoAtendente2Id.ValueMember = "";
            // 
            // SObitoAtendente1Id
            // 
            this.SObitoAtendente1Id.Caption = "";
            this.SObitoAtendente1Id.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.SObitoAtendente1Id.CenterCaption = false;
            this.SObitoAtendente1Id.ComponentBackColor = System.Drawing.Color.White;
            this.SObitoAtendente1Id.DefaultValue = false;
            this.SObitoAtendente1Id.Disable = true;
            this.SObitoAtendente1Id.DisplayMember = "";
            this.SObitoAtendente1Id.FieldValid = true;
            this.SObitoAtendente1Id.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SObitoAtendente1Id.Form = null;
            this.SObitoAtendente1Id.FormType = null;
            this.SObitoAtendente1Id.IsDependecyUkey = false;
            this.SObitoAtendente1Id.Location = new System.Drawing.Point(19, 32);
            this.SObitoAtendente1Id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SObitoAtendente1Id.Name = "SObitoAtendente1Id";
            this.SObitoAtendente1Id.ObjectControl = null;
            this.SObitoAtendente1Id.ObjetoApp = null;
            this.SObitoAtendente1Id.PropertyControl = null;
            this.SObitoAtendente1Id.PropertyDependecyUkey = null;
            this.SObitoAtendente1Id.Size = new System.Drawing.Size(897, 53);
            this.SObitoAtendente1Id.StandardValue = null;
            this.SObitoAtendente1Id.TabIndex = 104;
            this.SObitoAtendente1Id.TabStop = false;
            this.SObitoAtendente1Id.ToolTipContext = null;
            this.SObitoAtendente1Id.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("SObitoAtendente1Id.Validations")));
            this.SObitoAtendente1Id.ValueControl = null;
            this.SObitoAtendente1Id.ValueMember = "";
            // 
            // DadosNatimortoTabPage
            // 
            this.DadosNatimortoTabPage.BackColor = System.Drawing.Color.White;
            this.DadosNatimortoTabPage.Controls.Add(this.tabControl1);
            this.DadosNatimortoTabPage.Location = new System.Drawing.Point(4, 30);
            this.DadosNatimortoTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DadosNatimortoTabPage.Name = "DadosNatimortoTabPage";
            this.DadosNatimortoTabPage.Size = new System.Drawing.Size(1067, 489);
            this.DadosNatimortoTabPage.TabIndex = 2;
            this.DadosNatimortoTabPage.Text = "INFORMAÇÕES ADICIONAIS Natimorto";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.dadosNatMortoTabPage);
            this.tabControl1.Controls.Add(this.testemunhasTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // dadosNatMortoTabPage
            // 
            this.dadosNatMortoTabPage.BackColor = System.Drawing.Color.White;
            this.dadosNatMortoTabPage.Controls.Add(this.groupBox7);
            this.dadosNatMortoTabPage.Location = new System.Drawing.Point(4, 30);
            this.dadosNatMortoTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dadosNatMortoTabPage.Name = "dadosNatMortoTabPage";
            this.dadosNatMortoTabPage.Size = new System.Drawing.Size(1059, 455);
            this.dadosNatMortoTabPage.TabIndex = 0;
            this.dadosNatMortoTabPage.Text = "DADOS DO Natimorto";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.NatimortoHoraNascimento);
            this.groupBox7.Controls.Add(this.NatimortoIdade);
            this.groupBox7.Controls.Add(this.NatimortoAvosMaternos);
            this.groupBox7.Controls.Add(this.NatimortoAvosPaternos);
            this.groupBox7.Controls.Add(this.NatimortoDuracao);
            this.groupBox7.Controls.Add(this.NatimortoGestao);
            this.groupBox7.Controls.Add(this.NatimortoLocalNascimento);
            this.groupBox7.Controls.Add(this.NatimortoDescIdade);
            this.groupBox7.Location = new System.Drawing.Point(17, 46);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox7.Size = new System.Drawing.Size(1025, 283);
            this.groupBox7.TabIndex = 45;
            this.groupBox7.TabStop = false;
            // 
            // NatimortoHoraNascimento
            // 
            this.NatimortoHoraNascimento.Caption = "";
            this.NatimortoHoraNascimento.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoHoraNascimento.CenterCaption = false;
            this.NatimortoHoraNascimento.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoHoraNascimento.CustomFormat = null;
            this.NatimortoHoraNascimento.Disable = true;
            this.NatimortoHoraNascimento.FieldValid = true;
            this.NatimortoHoraNascimento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoHoraNascimento.Form = null;
            this.NatimortoHoraNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NatimortoHoraNascimento.FormType = null;
            this.NatimortoHoraNascimento.IsDependecyUkey = false;
            this.NatimortoHoraNascimento.Location = new System.Drawing.Point(207, 28);
            this.NatimortoHoraNascimento.Name = "NatimortoHoraNascimento";
            this.NatimortoHoraNascimento.ObjectControl = null;
            this.NatimortoHoraNascimento.ObjetoApp = null;
            this.NatimortoHoraNascimento.PropertyControl = null;
            this.NatimortoHoraNascimento.PropertyDependecyUkey = null;
            this.NatimortoHoraNascimento.Size = new System.Drawing.Size(121, 51);
            this.NatimortoHoraNascimento.TabIndex = 108;
            this.NatimortoHoraNascimento.TabStop = false;
            this.NatimortoHoraNascimento.ToolTipContext = null;
            this.NatimortoHoraNascimento.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoHoraNascimento.Validations")));
            this.NatimortoHoraNascimento.ValueControl = new System.DateTime(2016, 12, 31, 15, 9, 23, 812);
            // 
            // NatimortoIdade
            // 
            this.NatimortoIdade.Caption = "";
            this.NatimortoIdade.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoIdade.CenterCaption = false;
            this.NatimortoIdade.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoIdade.DecimalPlaces = 0;
            this.NatimortoIdade.Disable = true;
            this.NatimortoIdade.FieldValid = true;
            this.NatimortoIdade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoIdade.Form = null;
            this.NatimortoIdade.FormType = null;
            this.NatimortoIdade.IsDependecyUkey = false;
            this.NatimortoIdade.Location = new System.Drawing.Point(7, 30);
            this.NatimortoIdade.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NatimortoIdade.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NatimortoIdade.Name = "NatimortoIdade";
            this.NatimortoIdade.ObjectControl = null;
            this.NatimortoIdade.ObjetoApp = null;
            this.NatimortoIdade.PropertyControl = null;
            this.NatimortoIdade.PropertyDependecyUkey = null;
            this.NatimortoIdade.Size = new System.Drawing.Size(71, 51);
            this.NatimortoIdade.TabIndex = 106;
            this.NatimortoIdade.TabStop = false;
            this.NatimortoIdade.ThousandsSeparator = false;
            this.NatimortoIdade.ToolTipContext = null;
            this.NatimortoIdade.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoIdade.Validations")));
            this.NatimortoIdade.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // NatimortoAvosMaternos
            // 
            this.NatimortoAvosMaternos.Caption = "";
            this.NatimortoAvosMaternos.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoAvosMaternos.CenterCaption = false;
            this.NatimortoAvosMaternos.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoAvosMaternos.Disable = true;
            this.NatimortoAvosMaternos.FieldValid = true;
            this.NatimortoAvosMaternos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoAvosMaternos.Form = null;
            this.NatimortoAvosMaternos.FormType = null;
            this.NatimortoAvosMaternos.IsDependecyUkey = false;
            this.NatimortoAvosMaternos.Location = new System.Drawing.Point(8, 209);
            this.NatimortoAvosMaternos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoAvosMaternos.Name = "NatimortoAvosMaternos";
            this.NatimortoAvosMaternos.ObjectControl = null;
            this.NatimortoAvosMaternos.ObjetoApp = null;
            this.NatimortoAvosMaternos.PropertyControl = null;
            this.NatimortoAvosMaternos.PropertyDependecyUkey = null;
            this.NatimortoAvosMaternos.Size = new System.Drawing.Size(1008, 50);
            this.NatimortoAvosMaternos.TabIndex = 97;
            this.NatimortoAvosMaternos.TabStop = false;
            this.NatimortoAvosMaternos.ToolTipContext = null;
            this.NatimortoAvosMaternos.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoAvosMaternos.Validations")));
            this.NatimortoAvosMaternos.ValueControl = "";
            // 
            // NatimortoAvosPaternos
            // 
            this.NatimortoAvosPaternos.Caption = "";
            this.NatimortoAvosPaternos.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoAvosPaternos.CenterCaption = false;
            this.NatimortoAvosPaternos.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoAvosPaternos.Disable = true;
            this.NatimortoAvosPaternos.FieldValid = true;
            this.NatimortoAvosPaternos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoAvosPaternos.Form = null;
            this.NatimortoAvosPaternos.FormType = null;
            this.NatimortoAvosPaternos.IsDependecyUkey = false;
            this.NatimortoAvosPaternos.Location = new System.Drawing.Point(8, 149);
            this.NatimortoAvosPaternos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoAvosPaternos.Name = "NatimortoAvosPaternos";
            this.NatimortoAvosPaternos.ObjectControl = null;
            this.NatimortoAvosPaternos.ObjetoApp = null;
            this.NatimortoAvosPaternos.PropertyControl = null;
            this.NatimortoAvosPaternos.PropertyDependecyUkey = null;
            this.NatimortoAvosPaternos.Size = new System.Drawing.Size(1008, 50);
            this.NatimortoAvosPaternos.TabIndex = 95;
            this.NatimortoAvosPaternos.TabStop = false;
            this.NatimortoAvosPaternos.ToolTipContext = null;
            this.NatimortoAvosPaternos.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoAvosPaternos.Validations")));
            this.NatimortoAvosPaternos.ValueControl = "";
            // 
            // NatimortoDuracao
            // 
            this.NatimortoDuracao.Caption = "";
            this.NatimortoDuracao.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoDuracao.CenterCaption = false;
            this.NatimortoDuracao.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoDuracao.DefaultValue = false;
            this.NatimortoDuracao.Disable = true;
            this.NatimortoDuracao.DisplayMember = "";
            this.NatimortoDuracao.FieldValid = true;
            this.NatimortoDuracao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoDuracao.Form = null;
            this.NatimortoDuracao.FormType = null;
            this.NatimortoDuracao.IsDependecyUkey = false;
            this.NatimortoDuracao.Location = new System.Drawing.Point(193, 89);
            this.NatimortoDuracao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoDuracao.Name = "NatimortoDuracao";
            this.NatimortoDuracao.ObjectControl = null;
            this.NatimortoDuracao.ObjetoApp = null;
            this.NatimortoDuracao.PropertyControl = null;
            this.NatimortoDuracao.PropertyDependecyUkey = null;
            this.NatimortoDuracao.Size = new System.Drawing.Size(178, 50);
            this.NatimortoDuracao.StandardValue = null;
            this.NatimortoDuracao.TabIndex = 93;
            this.NatimortoDuracao.TabStop = false;
            this.NatimortoDuracao.ToolTipContext = null;
            this.NatimortoDuracao.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoDuracao.Validations")));
            this.NatimortoDuracao.ValueControl = null;
            this.NatimortoDuracao.ValueMember = "";
            // 
            // NatimortoGestao
            // 
            this.NatimortoGestao.Caption = "";
            this.NatimortoGestao.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoGestao.CenterCaption = false;
            this.NatimortoGestao.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoGestao.DefaultValue = false;
            this.NatimortoGestao.Disable = true;
            this.NatimortoGestao.DisplayMember = "";
            this.NatimortoGestao.FieldValid = true;
            this.NatimortoGestao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoGestao.Form = null;
            this.NatimortoGestao.FormType = null;
            this.NatimortoGestao.IsDependecyUkey = false;
            this.NatimortoGestao.Location = new System.Drawing.Point(7, 89);
            this.NatimortoGestao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoGestao.Name = "NatimortoGestao";
            this.NatimortoGestao.ObjectControl = null;
            this.NatimortoGestao.ObjetoApp = null;
            this.NatimortoGestao.PropertyControl = null;
            this.NatimortoGestao.PropertyDependecyUkey = null;
            this.NatimortoGestao.Size = new System.Drawing.Size(178, 50);
            this.NatimortoGestao.StandardValue = null;
            this.NatimortoGestao.TabIndex = 90;
            this.NatimortoGestao.TabStop = false;
            this.NatimortoGestao.ToolTipContext = null;
            this.NatimortoGestao.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoGestao.Validations")));
            this.NatimortoGestao.ValueControl = null;
            this.NatimortoGestao.ValueMember = "";
            // 
            // NatimortoLocalNascimento
            // 
            this.NatimortoLocalNascimento.Caption = "";
            this.NatimortoLocalNascimento.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoLocalNascimento.CenterCaption = false;
            this.NatimortoLocalNascimento.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoLocalNascimento.Disable = true;
            this.NatimortoLocalNascimento.FieldValid = true;
            this.NatimortoLocalNascimento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoLocalNascimento.Form = null;
            this.NatimortoLocalNascimento.FormType = null;
            this.NatimortoLocalNascimento.IsDependecyUkey = false;
            this.NatimortoLocalNascimento.Location = new System.Drawing.Point(335, 28);
            this.NatimortoLocalNascimento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoLocalNascimento.Name = "NatimortoLocalNascimento";
            this.NatimortoLocalNascimento.ObjectControl = null;
            this.NatimortoLocalNascimento.ObjetoApp = null;
            this.NatimortoLocalNascimento.PropertyControl = null;
            this.NatimortoLocalNascimento.PropertyDependecyUkey = null;
            this.NatimortoLocalNascimento.Size = new System.Drawing.Size(678, 51);
            this.NatimortoLocalNascimento.TabIndex = 79;
            this.NatimortoLocalNascimento.TabStop = false;
            this.NatimortoLocalNascimento.ToolTipContext = null;
            this.NatimortoLocalNascimento.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoLocalNascimento.Validations")));
            this.NatimortoLocalNascimento.ValueControl = "";
            // 
            // NatimortoDescIdade
            // 
            this.NatimortoDescIdade.Caption = "";
            this.NatimortoDescIdade.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoDescIdade.CenterCaption = false;
            this.NatimortoDescIdade.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoDescIdade.DecimalPlaces = 0;
            this.NatimortoDescIdade.Disable = true;
            this.NatimortoDescIdade.FieldValid = true;
            this.NatimortoDescIdade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoDescIdade.Form = null;
            this.NatimortoDescIdade.FormType = null;
            this.NatimortoDescIdade.IsDependecyUkey = false;
            this.NatimortoDescIdade.Location = new System.Drawing.Point(85, 28);
            this.NatimortoDescIdade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoDescIdade.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NatimortoDescIdade.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NatimortoDescIdade.Name = "NatimortoDescIdade";
            this.NatimortoDescIdade.ObjectControl = null;
            this.NatimortoDescIdade.ObjetoApp = null;
            this.NatimortoDescIdade.PropertyControl = null;
            this.NatimortoDescIdade.PropertyDependecyUkey = null;
            this.NatimortoDescIdade.Size = new System.Drawing.Size(115, 51);
            this.NatimortoDescIdade.TabIndex = 77;
            this.NatimortoDescIdade.TabStop = false;
            this.NatimortoDescIdade.ThousandsSeparator = false;
            this.NatimortoDescIdade.ToolTipContext = null;
            this.NatimortoDescIdade.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoDescIdade.Validations")));
            this.NatimortoDescIdade.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // testemunhasTabPage
            // 
            this.testemunhasTabPage.BackColor = System.Drawing.Color.White;
            this.testemunhasTabPage.Controls.Add(this.groupBox9);
            this.testemunhasTabPage.Controls.Add(this.groupBox8);
            this.testemunhasTabPage.Location = new System.Drawing.Point(4, 30);
            this.testemunhasTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.testemunhasTabPage.Name = "testemunhasTabPage";
            this.testemunhasTabPage.Size = new System.Drawing.Size(1059, 455);
            this.testemunhasTabPage.TabIndex = 1;
            this.testemunhasTabPage.Text = "TESTEMUNHAS";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.NatimortoTestemunha2EstadoId);
            this.groupBox9.Controls.Add(this.NatimortoTestemunha2Idade);
            this.groupBox9.Controls.Add(this.NatimortoTestemunha2CidadeId);
            this.groupBox9.Controls.Add(this.NatimortoTestemunha2Bairro);
            this.groupBox9.Controls.Add(this.NatimortoTestemunha2Endereco);
            this.groupBox9.Controls.Add(this.NatimortoTestemunha2EstadoIdCivil);
            this.groupBox9.Controls.Add(this.NatimortoTestemunha2Nascionalidade);
            this.groupBox9.Controls.Add(this.NatimortoTestemunha2ProfissaoId);
            this.groupBox9.Controls.Add(this.NatimortoTestemunha2Documento);
            this.groupBox9.Controls.Add(this.NatimortoTestemunha2Nome);
            this.groupBox9.Location = new System.Drawing.Point(10, 204);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox9.Size = new System.Drawing.Size(1032, 209);
            this.groupBox9.TabIndex = 139;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Testemunha 2";
            // 
            // NatimortoTestemunha2EstadoId
            // 
            this.NatimortoTestemunha2EstadoId.Caption = "";
            this.NatimortoTestemunha2EstadoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha2EstadoId.CenterCaption = false;
            this.NatimortoTestemunha2EstadoId.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha2EstadoId.DefaultValue = false;
            this.NatimortoTestemunha2EstadoId.Disable = true;
            this.NatimortoTestemunha2EstadoId.DisplayMember = "";
            this.NatimortoTestemunha2EstadoId.FieldValid = true;
            this.NatimortoTestemunha2EstadoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha2EstadoId.Form = null;
            this.NatimortoTestemunha2EstadoId.FormType = null;
            this.NatimortoTestemunha2EstadoId.IsDependecyUkey = false;
            this.NatimortoTestemunha2EstadoId.Location = new System.Drawing.Point(944, 152);
            this.NatimortoTestemunha2EstadoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha2EstadoId.Name = "NatimortoTestemunha2EstadoId";
            this.NatimortoTestemunha2EstadoId.ObjectControl = null;
            this.NatimortoTestemunha2EstadoId.ObjetoApp = null;
            this.NatimortoTestemunha2EstadoId.PropertyControl = null;
            this.NatimortoTestemunha2EstadoId.PropertyDependecyUkey = null;
            this.NatimortoTestemunha2EstadoId.Size = new System.Drawing.Size(70, 50);
            this.NatimortoTestemunha2EstadoId.StandardValue = null;
            this.NatimortoTestemunha2EstadoId.TabIndex = 179;
            this.NatimortoTestemunha2EstadoId.TabStop = false;
            this.NatimortoTestemunha2EstadoId.ToolTipContext = null;
            this.NatimortoTestemunha2EstadoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha2EstadoId.Validations")));
            this.NatimortoTestemunha2EstadoId.ValueControl = null;
            this.NatimortoTestemunha2EstadoId.ValueMember = "";
            // 
            // NatimortoTestemunha2Idade
            // 
            this.NatimortoTestemunha2Idade.Caption = "";
            this.NatimortoTestemunha2Idade.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha2Idade.CenterCaption = false;
            this.NatimortoTestemunha2Idade.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha2Idade.DecimalPlaces = 0;
            this.NatimortoTestemunha2Idade.Disable = true;
            this.NatimortoTestemunha2Idade.FieldValid = true;
            this.NatimortoTestemunha2Idade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha2Idade.Form = null;
            this.NatimortoTestemunha2Idade.FormType = null;
            this.NatimortoTestemunha2Idade.IsDependecyUkey = false;
            this.NatimortoTestemunha2Idade.Location = new System.Drawing.Point(565, 34);
            this.NatimortoTestemunha2Idade.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NatimortoTestemunha2Idade.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NatimortoTestemunha2Idade.Name = "NatimortoTestemunha2Idade";
            this.NatimortoTestemunha2Idade.ObjectControl = null;
            this.NatimortoTestemunha2Idade.ObjetoApp = null;
            this.NatimortoTestemunha2Idade.PropertyControl = null;
            this.NatimortoTestemunha2Idade.PropertyDependecyUkey = null;
            this.NatimortoTestemunha2Idade.Size = new System.Drawing.Size(67, 50);
            this.NatimortoTestemunha2Idade.TabIndex = 192;
            this.NatimortoTestemunha2Idade.TabStop = false;
            this.NatimortoTestemunha2Idade.ThousandsSeparator = false;
            this.NatimortoTestemunha2Idade.ToolTipContext = null;
            this.NatimortoTestemunha2Idade.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha2Idade.Validations")));
            this.NatimortoTestemunha2Idade.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // NatimortoTestemunha2CidadeId
            // 
            this.NatimortoTestemunha2CidadeId.Caption = "";
            this.NatimortoTestemunha2CidadeId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha2CidadeId.CenterCaption = false;
            this.NatimortoTestemunha2CidadeId.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha2CidadeId.DefaultValue = false;
            this.NatimortoTestemunha2CidadeId.Disable = true;
            this.NatimortoTestemunha2CidadeId.DisplayMember = "";
            this.NatimortoTestemunha2CidadeId.FieldValid = true;
            this.NatimortoTestemunha2CidadeId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha2CidadeId.Form = null;
            this.NatimortoTestemunha2CidadeId.FormType = null;
            this.NatimortoTestemunha2CidadeId.IsDependecyUkey = false;
            this.NatimortoTestemunha2CidadeId.Location = new System.Drawing.Point(471, 152);
            this.NatimortoTestemunha2CidadeId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha2CidadeId.Name = "NatimortoTestemunha2CidadeId";
            this.NatimortoTestemunha2CidadeId.ObjectControl = null;
            this.NatimortoTestemunha2CidadeId.ObjetoApp = null;
            this.NatimortoTestemunha2CidadeId.PropertyControl = null;
            this.NatimortoTestemunha2CidadeId.PropertyDependecyUkey = null;
            this.NatimortoTestemunha2CidadeId.Size = new System.Drawing.Size(465, 50);
            this.NatimortoTestemunha2CidadeId.StandardValue = null;
            this.NatimortoTestemunha2CidadeId.TabIndex = 176;
            this.NatimortoTestemunha2CidadeId.TabStop = false;
            this.NatimortoTestemunha2CidadeId.ToolTipContext = null;
            this.NatimortoTestemunha2CidadeId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha2CidadeId.Validations")));
            this.NatimortoTestemunha2CidadeId.ValueControl = null;
            this.NatimortoTestemunha2CidadeId.ValueMember = "";
            // 
            // NatimortoTestemunha2Bairro
            // 
            this.NatimortoTestemunha2Bairro.Caption = "";
            this.NatimortoTestemunha2Bairro.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha2Bairro.CenterCaption = false;
            this.NatimortoTestemunha2Bairro.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha2Bairro.Disable = true;
            this.NatimortoTestemunha2Bairro.FieldValid = true;
            this.NatimortoTestemunha2Bairro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha2Bairro.Form = null;
            this.NatimortoTestemunha2Bairro.FormType = null;
            this.NatimortoTestemunha2Bairro.IsDependecyUkey = false;
            this.NatimortoTestemunha2Bairro.Location = new System.Drawing.Point(10, 152);
            this.NatimortoTestemunha2Bairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha2Bairro.Name = "NatimortoTestemunha2Bairro";
            this.NatimortoTestemunha2Bairro.ObjectControl = null;
            this.NatimortoTestemunha2Bairro.ObjetoApp = null;
            this.NatimortoTestemunha2Bairro.PropertyControl = null;
            this.NatimortoTestemunha2Bairro.PropertyDependecyUkey = null;
            this.NatimortoTestemunha2Bairro.Size = new System.Drawing.Size(455, 50);
            this.NatimortoTestemunha2Bairro.TabIndex = 174;
            this.NatimortoTestemunha2Bairro.TabStop = false;
            this.NatimortoTestemunha2Bairro.ToolTipContext = null;
            this.NatimortoTestemunha2Bairro.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha2Bairro.Validations")));
            this.NatimortoTestemunha2Bairro.ValueControl = "";
            // 
            // NatimortoTestemunha2Endereco
            // 
            this.NatimortoTestemunha2Endereco.Caption = "";
            this.NatimortoTestemunha2Endereco.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha2Endereco.CenterCaption = false;
            this.NatimortoTestemunha2Endereco.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha2Endereco.Disable = true;
            this.NatimortoTestemunha2Endereco.FieldValid = true;
            this.NatimortoTestemunha2Endereco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha2Endereco.Form = null;
            this.NatimortoTestemunha2Endereco.FormType = null;
            this.NatimortoTestemunha2Endereco.IsDependecyUkey = false;
            this.NatimortoTestemunha2Endereco.Location = new System.Drawing.Point(286, 92);
            this.NatimortoTestemunha2Endereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha2Endereco.Name = "NatimortoTestemunha2Endereco";
            this.NatimortoTestemunha2Endereco.ObjectControl = null;
            this.NatimortoTestemunha2Endereco.ObjetoApp = null;
            this.NatimortoTestemunha2Endereco.PropertyControl = null;
            this.NatimortoTestemunha2Endereco.PropertyDependecyUkey = null;
            this.NatimortoTestemunha2Endereco.Size = new System.Drawing.Size(728, 50);
            this.NatimortoTestemunha2Endereco.TabIndex = 172;
            this.NatimortoTestemunha2Endereco.TabStop = false;
            this.NatimortoTestemunha2Endereco.ToolTipContext = null;
            this.NatimortoTestemunha2Endereco.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha2Endereco.Validations")));
            this.NatimortoTestemunha2Endereco.ValueControl = "";
            // 
            // NatimortoTestemunha2EstadoIdCivil
            // 
            this.NatimortoTestemunha2EstadoIdCivil.Caption = "";
            this.NatimortoTestemunha2EstadoIdCivil.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha2EstadoIdCivil.CenterCaption = false;
            this.NatimortoTestemunha2EstadoIdCivil.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha2EstadoIdCivil.DefaultValue = false;
            this.NatimortoTestemunha2EstadoIdCivil.Disable = true;
            this.NatimortoTestemunha2EstadoIdCivil.DisplayMember = "";
            this.NatimortoTestemunha2EstadoIdCivil.FieldValid = true;
            this.NatimortoTestemunha2EstadoIdCivil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha2EstadoIdCivil.Form = null;
            this.NatimortoTestemunha2EstadoIdCivil.FormType = null;
            this.NatimortoTestemunha2EstadoIdCivil.IsDependecyUkey = false;
            this.NatimortoTestemunha2EstadoIdCivil.Location = new System.Drawing.Point(148, 92);
            this.NatimortoTestemunha2EstadoIdCivil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha2EstadoIdCivil.Name = "NatimortoTestemunha2EstadoIdCivil";
            this.NatimortoTestemunha2EstadoIdCivil.ObjectControl = null;
            this.NatimortoTestemunha2EstadoIdCivil.ObjetoApp = null;
            this.NatimortoTestemunha2EstadoIdCivil.PropertyControl = null;
            this.NatimortoTestemunha2EstadoIdCivil.PropertyDependecyUkey = null;
            this.NatimortoTestemunha2EstadoIdCivil.Size = new System.Drawing.Size(130, 50);
            this.NatimortoTestemunha2EstadoIdCivil.StandardValue = null;
            this.NatimortoTestemunha2EstadoIdCivil.TabIndex = 170;
            this.NatimortoTestemunha2EstadoIdCivil.TabStop = false;
            this.NatimortoTestemunha2EstadoIdCivil.ToolTipContext = null;
            this.NatimortoTestemunha2EstadoIdCivil.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha2EstadoIdCivil.Validations")));
            this.NatimortoTestemunha2EstadoIdCivil.ValueControl = null;
            this.NatimortoTestemunha2EstadoIdCivil.ValueMember = "";
            // 
            // NatimortoTestemunha2Nascionalidade
            // 
            this.NatimortoTestemunha2Nascionalidade.Caption = "";
            this.NatimortoTestemunha2Nascionalidade.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha2Nascionalidade.CenterCaption = false;
            this.NatimortoTestemunha2Nascionalidade.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha2Nascionalidade.Disable = true;
            this.NatimortoTestemunha2Nascionalidade.FieldValid = true;
            this.NatimortoTestemunha2Nascionalidade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha2Nascionalidade.Form = null;
            this.NatimortoTestemunha2Nascionalidade.FormType = null;
            this.NatimortoTestemunha2Nascionalidade.IsDependecyUkey = false;
            this.NatimortoTestemunha2Nascionalidade.Location = new System.Drawing.Point(10, 92);
            this.NatimortoTestemunha2Nascionalidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha2Nascionalidade.Name = "NatimortoTestemunha2Nascionalidade";
            this.NatimortoTestemunha2Nascionalidade.ObjectControl = null;
            this.NatimortoTestemunha2Nascionalidade.ObjetoApp = null;
            this.NatimortoTestemunha2Nascionalidade.PropertyControl = null;
            this.NatimortoTestemunha2Nascionalidade.PropertyDependecyUkey = null;
            this.NatimortoTestemunha2Nascionalidade.Size = new System.Drawing.Size(132, 50);
            this.NatimortoTestemunha2Nascionalidade.TabIndex = 167;
            this.NatimortoTestemunha2Nascionalidade.TabStop = false;
            this.NatimortoTestemunha2Nascionalidade.ToolTipContext = null;
            this.NatimortoTestemunha2Nascionalidade.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha2Nascionalidade.Validations")));
            this.NatimortoTestemunha2Nascionalidade.ValueControl = "";
            // 
            // NatimortoTestemunha2ProfissaoId
            // 
            this.NatimortoTestemunha2ProfissaoId.Caption = "";
            this.NatimortoTestemunha2ProfissaoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha2ProfissaoId.CenterCaption = false;
            this.NatimortoTestemunha2ProfissaoId.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha2ProfissaoId.DefaultValue = false;
            this.NatimortoTestemunha2ProfissaoId.Disable = true;
            this.NatimortoTestemunha2ProfissaoId.DisplayMember = "";
            this.NatimortoTestemunha2ProfissaoId.FieldValid = true;
            this.NatimortoTestemunha2ProfissaoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha2ProfissaoId.Form = null;
            this.NatimortoTestemunha2ProfissaoId.FormType = null;
            this.NatimortoTestemunha2ProfissaoId.IsDependecyUkey = false;
            this.NatimortoTestemunha2ProfissaoId.Location = new System.Drawing.Point(787, 34);
            this.NatimortoTestemunha2ProfissaoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha2ProfissaoId.Name = "NatimortoTestemunha2ProfissaoId";
            this.NatimortoTestemunha2ProfissaoId.ObjectControl = null;
            this.NatimortoTestemunha2ProfissaoId.ObjetoApp = null;
            this.NatimortoTestemunha2ProfissaoId.PropertyControl = null;
            this.NatimortoTestemunha2ProfissaoId.PropertyDependecyUkey = null;
            this.NatimortoTestemunha2ProfissaoId.Size = new System.Drawing.Size(227, 50);
            this.NatimortoTestemunha2ProfissaoId.StandardValue = null;
            this.NatimortoTestemunha2ProfissaoId.TabIndex = 165;
            this.NatimortoTestemunha2ProfissaoId.TabStop = false;
            this.NatimortoTestemunha2ProfissaoId.ToolTipContext = null;
            this.NatimortoTestemunha2ProfissaoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha2ProfissaoId.Validations")));
            this.NatimortoTestemunha2ProfissaoId.ValueControl = null;
            this.NatimortoTestemunha2ProfissaoId.ValueMember = "";
            // 
            // NatimortoTestemunha2Documento
            // 
            this.NatimortoTestemunha2Documento.Caption = "";
            this.NatimortoTestemunha2Documento.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha2Documento.CenterCaption = false;
            this.NatimortoTestemunha2Documento.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha2Documento.Disable = true;
            this.NatimortoTestemunha2Documento.FieldValid = true;
            this.NatimortoTestemunha2Documento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha2Documento.Form = null;
            this.NatimortoTestemunha2Documento.FormType = null;
            this.NatimortoTestemunha2Documento.IsDependecyUkey = false;
            this.NatimortoTestemunha2Documento.Location = new System.Drawing.Point(639, 34);
            this.NatimortoTestemunha2Documento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha2Documento.Name = "NatimortoTestemunha2Documento";
            this.NatimortoTestemunha2Documento.ObjectControl = null;
            this.NatimortoTestemunha2Documento.ObjetoApp = null;
            this.NatimortoTestemunha2Documento.PropertyControl = null;
            this.NatimortoTestemunha2Documento.PropertyDependecyUkey = null;
            this.NatimortoTestemunha2Documento.Size = new System.Drawing.Size(140, 50);
            this.NatimortoTestemunha2Documento.TabIndex = 162;
            this.NatimortoTestemunha2Documento.TabStop = false;
            this.NatimortoTestemunha2Documento.ToolTipContext = null;
            this.NatimortoTestemunha2Documento.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha2Documento.Validations")));
            this.NatimortoTestemunha2Documento.ValueControl = "";
            // 
            // NatimortoTestemunha2Nome
            // 
            this.NatimortoTestemunha2Nome.Caption = "";
            this.NatimortoTestemunha2Nome.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha2Nome.CenterCaption = false;
            this.NatimortoTestemunha2Nome.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha2Nome.Disable = true;
            this.NatimortoTestemunha2Nome.FieldValid = true;
            this.NatimortoTestemunha2Nome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha2Nome.Form = null;
            this.NatimortoTestemunha2Nome.FormType = null;
            this.NatimortoTestemunha2Nome.IsDependecyUkey = false;
            this.NatimortoTestemunha2Nome.Location = new System.Drawing.Point(8, 32);
            this.NatimortoTestemunha2Nome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha2Nome.Name = "NatimortoTestemunha2Nome";
            this.NatimortoTestemunha2Nome.ObjectControl = null;
            this.NatimortoTestemunha2Nome.ObjetoApp = null;
            this.NatimortoTestemunha2Nome.PropertyControl = null;
            this.NatimortoTestemunha2Nome.PropertyDependecyUkey = null;
            this.NatimortoTestemunha2Nome.Size = new System.Drawing.Size(550, 50);
            this.NatimortoTestemunha2Nome.TabIndex = 160;
            this.NatimortoTestemunha2Nome.TabStop = false;
            this.NatimortoTestemunha2Nome.ToolTipContext = null;
            this.NatimortoTestemunha2Nome.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha2Nome.Validations")));
            this.NatimortoTestemunha2Nome.ValueControl = "";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.NatimortoTestemunha1EstadoId);
            this.groupBox8.Controls.Add(this.NatimortoTestemunha1Idade);
            this.groupBox8.Controls.Add(this.NatimortoTestemunha1CidadeId);
            this.groupBox8.Controls.Add(this.NatimortoTestemunha1Bairro);
            this.groupBox8.Controls.Add(this.NatimortoTestemunha1Endereco);
            this.groupBox8.Controls.Add(this.NatimortoTestemunha1EstadoCivil);
            this.groupBox8.Controls.Add(this.NatimortoTestemunha1Nascionalidade);
            this.groupBox8.Controls.Add(this.NatimortoTestemunha1ProfissaoId);
            this.groupBox8.Controls.Add(this.NatimortoTestemunha1Documento);
            this.groupBox8.Controls.Add(this.NatimortoTestemunha1Nome);
            this.groupBox8.Location = new System.Drawing.Point(10, 8);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox8.Size = new System.Drawing.Size(1024, 196);
            this.groupBox8.TabIndex = 138;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Testemunha 1";
            // 
            // NatimortoTestemunha1EstadoId
            // 
            this.NatimortoTestemunha1EstadoId.Caption = "";
            this.NatimortoTestemunha1EstadoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha1EstadoId.CenterCaption = false;
            this.NatimortoTestemunha1EstadoId.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha1EstadoId.DefaultValue = false;
            this.NatimortoTestemunha1EstadoId.Disable = true;
            this.NatimortoTestemunha1EstadoId.DisplayMember = "";
            this.NatimortoTestemunha1EstadoId.FieldValid = true;
            this.NatimortoTestemunha1EstadoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha1EstadoId.Form = null;
            this.NatimortoTestemunha1EstadoId.FormType = null;
            this.NatimortoTestemunha1EstadoId.IsDependecyUkey = false;
            this.NatimortoTestemunha1EstadoId.Location = new System.Drawing.Point(944, 136);
            this.NatimortoTestemunha1EstadoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha1EstadoId.Name = "NatimortoTestemunha1EstadoId";
            this.NatimortoTestemunha1EstadoId.ObjectControl = null;
            this.NatimortoTestemunha1EstadoId.ObjetoApp = null;
            this.NatimortoTestemunha1EstadoId.PropertyControl = null;
            this.NatimortoTestemunha1EstadoId.PropertyDependecyUkey = null;
            this.NatimortoTestemunha1EstadoId.Size = new System.Drawing.Size(70, 50);
            this.NatimortoTestemunha1EstadoId.StandardValue = null;
            this.NatimortoTestemunha1EstadoId.TabIndex = 179;
            this.NatimortoTestemunha1EstadoId.TabStop = false;
            this.NatimortoTestemunha1EstadoId.ToolTipContext = null;
            this.NatimortoTestemunha1EstadoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha1EstadoId.Validations")));
            this.NatimortoTestemunha1EstadoId.ValueControl = null;
            this.NatimortoTestemunha1EstadoId.ValueMember = "";
            // 
            // NatimortoTestemunha1Idade
            // 
            this.NatimortoTestemunha1Idade.Caption = "";
            this.NatimortoTestemunha1Idade.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha1Idade.CenterCaption = false;
            this.NatimortoTestemunha1Idade.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha1Idade.DecimalPlaces = 0;
            this.NatimortoTestemunha1Idade.Disable = true;
            this.NatimortoTestemunha1Idade.FieldValid = true;
            this.NatimortoTestemunha1Idade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha1Idade.Form = null;
            this.NatimortoTestemunha1Idade.FormType = null;
            this.NatimortoTestemunha1Idade.IsDependecyUkey = false;
            this.NatimortoTestemunha1Idade.Location = new System.Drawing.Point(565, 22);
            this.NatimortoTestemunha1Idade.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.NatimortoTestemunha1Idade.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NatimortoTestemunha1Idade.Name = "NatimortoTestemunha1Idade";
            this.NatimortoTestemunha1Idade.ObjectControl = null;
            this.NatimortoTestemunha1Idade.ObjetoApp = null;
            this.NatimortoTestemunha1Idade.PropertyControl = null;
            this.NatimortoTestemunha1Idade.PropertyDependecyUkey = null;
            this.NatimortoTestemunha1Idade.Size = new System.Drawing.Size(67, 50);
            this.NatimortoTestemunha1Idade.TabIndex = 192;
            this.NatimortoTestemunha1Idade.TabStop = false;
            this.NatimortoTestemunha1Idade.ThousandsSeparator = false;
            this.NatimortoTestemunha1Idade.ToolTipContext = null;
            this.NatimortoTestemunha1Idade.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha1Idade.Validations")));
            this.NatimortoTestemunha1Idade.ValueControl = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // NatimortoTestemunha1CidadeId
            // 
            this.NatimortoTestemunha1CidadeId.Caption = "";
            this.NatimortoTestemunha1CidadeId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha1CidadeId.CenterCaption = false;
            this.NatimortoTestemunha1CidadeId.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha1CidadeId.DefaultValue = false;
            this.NatimortoTestemunha1CidadeId.Disable = true;
            this.NatimortoTestemunha1CidadeId.DisplayMember = "";
            this.NatimortoTestemunha1CidadeId.FieldValid = true;
            this.NatimortoTestemunha1CidadeId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha1CidadeId.Form = null;
            this.NatimortoTestemunha1CidadeId.FormType = null;
            this.NatimortoTestemunha1CidadeId.IsDependecyUkey = false;
            this.NatimortoTestemunha1CidadeId.Location = new System.Drawing.Point(471, 136);
            this.NatimortoTestemunha1CidadeId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha1CidadeId.Name = "NatimortoTestemunha1CidadeId";
            this.NatimortoTestemunha1CidadeId.ObjectControl = null;
            this.NatimortoTestemunha1CidadeId.ObjetoApp = null;
            this.NatimortoTestemunha1CidadeId.PropertyControl = null;
            this.NatimortoTestemunha1CidadeId.PropertyDependecyUkey = null;
            this.NatimortoTestemunha1CidadeId.Size = new System.Drawing.Size(465, 50);
            this.NatimortoTestemunha1CidadeId.StandardValue = null;
            this.NatimortoTestemunha1CidadeId.TabIndex = 176;
            this.NatimortoTestemunha1CidadeId.TabStop = false;
            this.NatimortoTestemunha1CidadeId.ToolTipContext = null;
            this.NatimortoTestemunha1CidadeId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha1CidadeId.Validations")));
            this.NatimortoTestemunha1CidadeId.ValueControl = null;
            this.NatimortoTestemunha1CidadeId.ValueMember = "";
            // 
            // NatimortoTestemunha1Bairro
            // 
            this.NatimortoTestemunha1Bairro.Caption = "";
            this.NatimortoTestemunha1Bairro.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha1Bairro.CenterCaption = false;
            this.NatimortoTestemunha1Bairro.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha1Bairro.Disable = true;
            this.NatimortoTestemunha1Bairro.FieldValid = true;
            this.NatimortoTestemunha1Bairro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha1Bairro.Form = null;
            this.NatimortoTestemunha1Bairro.FormType = null;
            this.NatimortoTestemunha1Bairro.IsDependecyUkey = false;
            this.NatimortoTestemunha1Bairro.Location = new System.Drawing.Point(8, 136);
            this.NatimortoTestemunha1Bairro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha1Bairro.Name = "NatimortoTestemunha1Bairro";
            this.NatimortoTestemunha1Bairro.ObjectControl = null;
            this.NatimortoTestemunha1Bairro.ObjetoApp = null;
            this.NatimortoTestemunha1Bairro.PropertyControl = null;
            this.NatimortoTestemunha1Bairro.PropertyDependecyUkey = null;
            this.NatimortoTestemunha1Bairro.Size = new System.Drawing.Size(455, 50);
            this.NatimortoTestemunha1Bairro.TabIndex = 174;
            this.NatimortoTestemunha1Bairro.TabStop = false;
            this.NatimortoTestemunha1Bairro.ToolTipContext = null;
            this.NatimortoTestemunha1Bairro.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha1Bairro.Validations")));
            this.NatimortoTestemunha1Bairro.ValueControl = "";
            // 
            // NatimortoTestemunha1Endereco
            // 
            this.NatimortoTestemunha1Endereco.Caption = "";
            this.NatimortoTestemunha1Endereco.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha1Endereco.CenterCaption = false;
            this.NatimortoTestemunha1Endereco.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha1Endereco.Disable = true;
            this.NatimortoTestemunha1Endereco.FieldValid = true;
            this.NatimortoTestemunha1Endereco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha1Endereco.Form = null;
            this.NatimortoTestemunha1Endereco.FormType = null;
            this.NatimortoTestemunha1Endereco.IsDependecyUkey = false;
            this.NatimortoTestemunha1Endereco.Location = new System.Drawing.Point(286, 78);
            this.NatimortoTestemunha1Endereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha1Endereco.Name = "NatimortoTestemunha1Endereco";
            this.NatimortoTestemunha1Endereco.ObjectControl = null;
            this.NatimortoTestemunha1Endereco.ObjetoApp = null;
            this.NatimortoTestemunha1Endereco.PropertyControl = null;
            this.NatimortoTestemunha1Endereco.PropertyDependecyUkey = null;
            this.NatimortoTestemunha1Endereco.Size = new System.Drawing.Size(728, 50);
            this.NatimortoTestemunha1Endereco.TabIndex = 172;
            this.NatimortoTestemunha1Endereco.TabStop = false;
            this.NatimortoTestemunha1Endereco.ToolTipContext = null;
            this.NatimortoTestemunha1Endereco.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha1Endereco.Validations")));
            this.NatimortoTestemunha1Endereco.ValueControl = "";
            // 
            // NatimortoTestemunha1EstadoCivil
            // 
            this.NatimortoTestemunha1EstadoCivil.Caption = "";
            this.NatimortoTestemunha1EstadoCivil.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha1EstadoCivil.CenterCaption = false;
            this.NatimortoTestemunha1EstadoCivil.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha1EstadoCivil.DefaultValue = false;
            this.NatimortoTestemunha1EstadoCivil.Disable = true;
            this.NatimortoTestemunha1EstadoCivil.DisplayMember = "";
            this.NatimortoTestemunha1EstadoCivil.FieldValid = true;
            this.NatimortoTestemunha1EstadoCivil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha1EstadoCivil.Form = null;
            this.NatimortoTestemunha1EstadoCivil.FormType = null;
            this.NatimortoTestemunha1EstadoCivil.IsDependecyUkey = false;
            this.NatimortoTestemunha1EstadoCivil.Location = new System.Drawing.Point(148, 78);
            this.NatimortoTestemunha1EstadoCivil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha1EstadoCivil.Name = "NatimortoTestemunha1EstadoCivil";
            this.NatimortoTestemunha1EstadoCivil.ObjectControl = null;
            this.NatimortoTestemunha1EstadoCivil.ObjetoApp = null;
            this.NatimortoTestemunha1EstadoCivil.PropertyControl = null;
            this.NatimortoTestemunha1EstadoCivil.PropertyDependecyUkey = null;
            this.NatimortoTestemunha1EstadoCivil.Size = new System.Drawing.Size(130, 50);
            this.NatimortoTestemunha1EstadoCivil.StandardValue = null;
            this.NatimortoTestemunha1EstadoCivil.TabIndex = 170;
            this.NatimortoTestemunha1EstadoCivil.TabStop = false;
            this.NatimortoTestemunha1EstadoCivil.ToolTipContext = null;
            this.NatimortoTestemunha1EstadoCivil.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha1EstadoCivil.Validations")));
            this.NatimortoTestemunha1EstadoCivil.ValueControl = null;
            this.NatimortoTestemunha1EstadoCivil.ValueMember = "";
            // 
            // NatimortoTestemunha1Nascionalidade
            // 
            this.NatimortoTestemunha1Nascionalidade.Caption = "";
            this.NatimortoTestemunha1Nascionalidade.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha1Nascionalidade.CenterCaption = false;
            this.NatimortoTestemunha1Nascionalidade.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha1Nascionalidade.Disable = true;
            this.NatimortoTestemunha1Nascionalidade.FieldValid = true;
            this.NatimortoTestemunha1Nascionalidade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha1Nascionalidade.Form = null;
            this.NatimortoTestemunha1Nascionalidade.FormType = null;
            this.NatimortoTestemunha1Nascionalidade.IsDependecyUkey = false;
            this.NatimortoTestemunha1Nascionalidade.Location = new System.Drawing.Point(8, 78);
            this.NatimortoTestemunha1Nascionalidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha1Nascionalidade.Name = "NatimortoTestemunha1Nascionalidade";
            this.NatimortoTestemunha1Nascionalidade.ObjectControl = null;
            this.NatimortoTestemunha1Nascionalidade.ObjetoApp = null;
            this.NatimortoTestemunha1Nascionalidade.PropertyControl = null;
            this.NatimortoTestemunha1Nascionalidade.PropertyDependecyUkey = null;
            this.NatimortoTestemunha1Nascionalidade.Size = new System.Drawing.Size(132, 50);
            this.NatimortoTestemunha1Nascionalidade.TabIndex = 167;
            this.NatimortoTestemunha1Nascionalidade.TabStop = false;
            this.NatimortoTestemunha1Nascionalidade.ToolTipContext = null;
            this.NatimortoTestemunha1Nascionalidade.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha1Nascionalidade.Validations")));
            this.NatimortoTestemunha1Nascionalidade.ValueControl = "";
            // 
            // NatimortoTestemunha1ProfissaoId
            // 
            this.NatimortoTestemunha1ProfissaoId.Caption = "";
            this.NatimortoTestemunha1ProfissaoId.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha1ProfissaoId.CenterCaption = false;
            this.NatimortoTestemunha1ProfissaoId.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha1ProfissaoId.DefaultValue = false;
            this.NatimortoTestemunha1ProfissaoId.Disable = true;
            this.NatimortoTestemunha1ProfissaoId.DisplayMember = "";
            this.NatimortoTestemunha1ProfissaoId.FieldValid = true;
            this.NatimortoTestemunha1ProfissaoId.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha1ProfissaoId.Form = null;
            this.NatimortoTestemunha1ProfissaoId.FormType = null;
            this.NatimortoTestemunha1ProfissaoId.IsDependecyUkey = false;
            this.NatimortoTestemunha1ProfissaoId.Location = new System.Drawing.Point(787, 22);
            this.NatimortoTestemunha1ProfissaoId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha1ProfissaoId.Name = "NatimortoTestemunha1ProfissaoId";
            this.NatimortoTestemunha1ProfissaoId.ObjectControl = null;
            this.NatimortoTestemunha1ProfissaoId.ObjetoApp = null;
            this.NatimortoTestemunha1ProfissaoId.PropertyControl = null;
            this.NatimortoTestemunha1ProfissaoId.PropertyDependecyUkey = null;
            this.NatimortoTestemunha1ProfissaoId.Size = new System.Drawing.Size(227, 50);
            this.NatimortoTestemunha1ProfissaoId.StandardValue = null;
            this.NatimortoTestemunha1ProfissaoId.TabIndex = 165;
            this.NatimortoTestemunha1ProfissaoId.TabStop = false;
            this.NatimortoTestemunha1ProfissaoId.ToolTipContext = null;
            this.NatimortoTestemunha1ProfissaoId.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha1ProfissaoId.Validations")));
            this.NatimortoTestemunha1ProfissaoId.ValueControl = null;
            this.NatimortoTestemunha1ProfissaoId.ValueMember = "";
            // 
            // NatimortoTestemunha1Documento
            // 
            this.NatimortoTestemunha1Documento.Caption = "";
            this.NatimortoTestemunha1Documento.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha1Documento.CenterCaption = false;
            this.NatimortoTestemunha1Documento.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha1Documento.Disable = true;
            this.NatimortoTestemunha1Documento.FieldValid = true;
            this.NatimortoTestemunha1Documento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha1Documento.Form = null;
            this.NatimortoTestemunha1Documento.FormType = null;
            this.NatimortoTestemunha1Documento.IsDependecyUkey = false;
            this.NatimortoTestemunha1Documento.Location = new System.Drawing.Point(639, 22);
            this.NatimortoTestemunha1Documento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha1Documento.Name = "NatimortoTestemunha1Documento";
            this.NatimortoTestemunha1Documento.ObjectControl = null;
            this.NatimortoTestemunha1Documento.ObjetoApp = null;
            this.NatimortoTestemunha1Documento.PropertyControl = null;
            this.NatimortoTestemunha1Documento.PropertyDependecyUkey = null;
            this.NatimortoTestemunha1Documento.Size = new System.Drawing.Size(140, 50);
            this.NatimortoTestemunha1Documento.TabIndex = 162;
            this.NatimortoTestemunha1Documento.TabStop = false;
            this.NatimortoTestemunha1Documento.ToolTipContext = null;
            this.NatimortoTestemunha1Documento.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha1Documento.Validations")));
            this.NatimortoTestemunha1Documento.ValueControl = "";
            // 
            // NatimortoTestemunha1Nome
            // 
            this.NatimortoTestemunha1Nome.Caption = "";
            this.NatimortoTestemunha1Nome.CaptionAlign = Esr.Core.Component.CaptionAlign.Top;
            this.NatimortoTestemunha1Nome.CenterCaption = false;
            this.NatimortoTestemunha1Nome.ComponentBackColor = System.Drawing.Color.White;
            this.NatimortoTestemunha1Nome.Disable = true;
            this.NatimortoTestemunha1Nome.FieldValid = true;
            this.NatimortoTestemunha1Nome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NatimortoTestemunha1Nome.Form = null;
            this.NatimortoTestemunha1Nome.FormType = null;
            this.NatimortoTestemunha1Nome.IsDependecyUkey = false;
            this.NatimortoTestemunha1Nome.Location = new System.Drawing.Point(8, 22);
            this.NatimortoTestemunha1Nome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NatimortoTestemunha1Nome.Name = "NatimortoTestemunha1Nome";
            this.NatimortoTestemunha1Nome.ObjectControl = null;
            this.NatimortoTestemunha1Nome.ObjetoApp = null;
            this.NatimortoTestemunha1Nome.PropertyControl = null;
            this.NatimortoTestemunha1Nome.PropertyDependecyUkey = null;
            this.NatimortoTestemunha1Nome.Size = new System.Drawing.Size(550, 50);
            this.NatimortoTestemunha1Nome.TabIndex = 160;
            this.NatimortoTestemunha1Nome.TabStop = false;
            this.NatimortoTestemunha1Nome.ToolTipContext = null;
            this.NatimortoTestemunha1Nome.Validations = ((System.Collections.Generic.Dictionary<string, bool>)(resources.GetObject("NatimortoTestemunha1Nome.Validations")));
            this.NatimortoTestemunha1Nome.ValueControl = "";
            // 
            // FDataDeceased
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 687);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FDataDeceased";
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.dadosDoFalecidoTabControl.ResumeLayout(false);
            this.dadosDoFalecidoTabPage.ResumeLayout(false);
            this.dadoTabControl.ResumeLayout(false);
            this.dadosFalecidotabPage.ResumeLayout(false);
            this.dadosFalecidotabPage.PerformLayout();
            this.filiacaotabPage.ResumeLayout(false);
            this.filiacaotabPage.PerformLayout();
            this.conjuguetabPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.filhosObservacoestabPage.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dadosDoObitoTabPage.ResumeLayout(false);
            this.DadosObitotabControl.ResumeLayout(false);
            this.dadosGeraistabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.DadosNatimortoTabPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.dadosNatMortoTabPage.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.testemunhasTabPage.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip geraltoolTip;
        private STabControl dadosDoFalecidoTabControl;
        private TabPage dadosDoObitoTabPage;
        private STabControl DadosObitotabControl;
        private TabPage dadosGeraistabPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox6;
        private TabPage DadosNatimortoTabPage;
        private STabControl tabControl1;
        private TabPage dadosNatMortoTabPage;
        private TabPage testemunhasTabPage;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private SDateTimePicker ObitoHoraFalecimento;
        private SDateTimePicker ObitoDataFalecimento;
        private STextBox ObitoLocalFalecimento;
        private SComboBox ObitoEstadoFalecimentoId;
        private SComboBox ObitoCidadeFalecimentoId;
        private SComboBox ObitoEstadoSepultamentoId;
        private SComboBox ObitoCidadeSepultamentoId;
        private SDateTimePicker ObitoHoraSepultamento;
        private SDateTimePicker ObitoDataSepultamento;
        private STextBox ObitoLocalSepultamento;
        private STextBox ObitoMedico2Crm;
        private STextBox ObitoMedico2;
        private STextBox ObitoMedicoCrm;
        private STextBox ObitoMedico1;
        private STextBox ObitoEnderecoCartorio;
        private STextBox ObitoNota;
        private STextBox ObitoCartorio;
        private STextBox ObitoAgencia;
        private STextBox ObitoDeclaranteCpf;
        private STextBox ObitoDeclaranteRg;
        private STextBox ObitoDeclarante;
        private STextBox ObitoDeclaranteGrauParentesco;
        private STextBox ObitoDeclaranteBairro;
        private STextBox ObitoDeclaranteEndereco;
        private STextBox ObitoDeclaranteCep;
        private SComboBox ObitoDeclaranteProfissaoId;
        private STextBox ObitoDeclaranteTelefone;
        private SComboBox ObitoDeclaranteEstadoId;
        private SComboBox ObitoDeclaranteCidadeId;
        private SComboBox SObitoAtendente1Id;
        private STextBox NatimortoAvosMaternos;
        private STextBox NatimortoAvosPaternos;
        private SComboBox NatimortoDuracao;
        private SComboBox NatimortoGestao;
        private STextBox NatimortoLocalNascimento;
        private SNumeric NatimortoDescIdade;
        private STextBox NatimortoTestemunha1Documento;
        private STextBox NatimortoTestemunha1Nome;
        private SComboBox NatimortoTestemunha1CidadeId;
        private STextBox NatimortoTestemunha1Bairro;
        private STextBox NatimortoTestemunha1Endereco;
        private SComboBox NatimortoTestemunha1EstadoCivil;
        private STextBox NatimortoTestemunha1Nascionalidade;
        private SComboBox NatimortoTestemunha1ProfissaoId;
        private SComboBox NatimortoTestemunha1EstadoId;
        private SNumeric NatimortoIdade;
        private SDateTimePicker NatimortoHoraNascimento;
        private SNumeric NatimortoTestemunha1Idade;
        private System.Windows.Forms.GroupBox groupBox9;
        private SComboBox NatimortoTestemunha2EstadoId;
        private SNumeric NatimortoTestemunha2Idade;
        private SComboBox NatimortoTestemunha2CidadeId;
        private STextBox NatimortoTestemunha2Bairro;
        private STextBox NatimortoTestemunha2Endereco;
        private SComboBox NatimortoTestemunha2EstadoIdCivil;
        private STextBox NatimortoTestemunha2Nascionalidade;
        private SComboBox NatimortoTestemunha2ProfissaoId;
        private STextBox NatimortoTestemunha2Documento;
        private STextBox NatimortoTestemunha2Nome;
        private TabPage dadosDoFalecidoTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private SComboBox FalecidoVotava;
        private SRichText FalecidoFilhos;
        private Panel panel;
        private TabPage filhosObservacoestabPage;
        private STextBox FalecidoNomeConjugue;
        private STextBox FalecidoCartorioNupcias;
        private SDateTimePicker FalecidoDataNupcias;
        private STextBox FalecidoLivro;
        private STextBox FalecidoFolha;
        private STextBox FalecidoNumero;
        private System.Windows.Forms.Panel panel4;
        private TabPage conjuguetabPage;
        private TabPage filiacaotabPage;
        private STextBox FalecidoNome;
        private SComboBox FalecidoSexo;
        private SComboBox FalecidoCor;
        private SDateTimePicker FalecidoNascimento;
        private SComboBox FalecidoDeixaBens;
        private SComboBox FalecidoTestamento;
        private STextBox FalecidoNatural;
        private SComboBox FalecidoEtadoCivil;
        private SComboBox FalecidoReligiaoId;
        private STextBox FalecidoEndereco;
        private STextBox FalecidoBairro;
        private SComboBox FalecidoCidadeId;
        private SComboBox FalecidoEstadoId;
        private STextBox FalecidoRg;
        private STextBox FalecidoCpf;
        private STextBox FalecidoCidadeTituloEleitor;
        private STextBox FalecidoNumeroTitulo;
        private STextBox FalecidoZonaTitulo;
        private STextBox FalecidoSecaoTitulo;
        private SComboBox FalecidoReservista;
        private SComboBox FalecidoProfissaoId;
        private SComboBox FalecidoInss;
        private TabPage dadosFalecidotabPage;
        private STabControl dadoTabControl;
        private SRichText FalecidoObservacao;
        private SRichText ObitoCausaMorte;
        private SNumeric Id;
        private SComboBox SObitoAtendente2Id;
        private SComboBox FalecidoFiliacaoEstadoId;
        private SComboBox FalecidoFiliacaoCidadeId;
        private STextBox FalecidoFiliacaoBairro;
        private STextBox FalecidoFiliacaoEndereco;
        private STextBox FalecidoFiliacaoMaeDocumento;
        private SComboBox FalecidoFiliacaoMaeProfissaoId;
        private STextBox FalecidoFiliacaoMaeNatural;
        private SNumeric FalecidoFiliacaoMaeIdade;
        private SComboBox FalecidoFiliacaoMaeEtadoCivil;
        private STextBox FalecidoFiliacaoNomeMae;
        private STextBox FalecidoFiliacaoPaiDocumento;
        private SComboBox FalecidoFiliacaoPaiProfissaoId;
        private STextBox FalecidoFiliacaoPaiNatural;
        private SNumeric FalecidoFiliacaoPaiIdade;
        private SComboBox FalecidoFiliacaoPaiEstadoCivil;
        private STextBox FalecidoFiliacaoNomePai;
        private SDateTimePicker FalecidoData;
    }
}