using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Forms;
using Esr.Core.Domain.ClassBase;
using Expression = System.Linq.Expressions.Expression;
using MessageBox = System.Windows.Forms.MessageBox;
using Esr.Core.Domain.Authentication;
using System.Collections;

namespace Esr.Core.Component
{
    public partial class FForm : FBase
    {
        public FForm()
        {

            Load += SForm_Load;
            InitializeComponent();
            _sMenu.Tag = this;
            KeyDown += OnKeyDown;
            try
            {
                FormResources = new ComponentResourceManager(typeof(FForm));
                Icon = ((System.Drawing.Icon)(FormResources.GetObject("$this.Icon")));
            }
            catch (Exception)
            {
            }
        }

        public override object ObjectControl
        {
            get { return bindingSource?.DataSource; }
            set
            {
                if (value == null) return;
                if (((IList)value).Count == 0)
                {
                    try
                    {
                        bindingSource.DataSource = value;
                        bindingSource?.AddNew();
                    }
                    catch (Exception)
                    {
                        return;
                    }

                    return;
                }
                bindingSource.DataSource = value;
            }
        }

        public override IEntityBase CurrentControl
        {
            get
            {
                // Retorna o registro atual posicionado.
                return bindingSource?.Current as IEntityBase;
            }
            set
            {
                // Quando adicionado registro, e removido o atual, sabendo que o mesmo não pode ser substituido.
                bindingSource.RemoveCurrent();
                // Passado um novo para contexto.
                bindingSource.Add(value);
                // Procuro o index no qual o novo registro foi adicionado.
                var indexOf = bindingSource.IndexOf(value);
                // Pesquisa a posição que se encontra e posiciono novamente.
                for (var i = 0; i < indexOf; i++)
                {
                    bindingSource.MoveNext();
                }
            }
        }

        /// <summary>
        /// Propridade para controle do status da tela.
        /// </summary>
        public override StateForm StateForm
        {
            // retorna status atual da tela.
            get { return _stateForm; }
            set
            {
                try
                {
                    // passa para menu a tela atual.
                    _sMenu.Tag = this;
                    // guarda o status atual informado.
                    _stateForm = value;
                    // para para menu realiza controle do seu status de acordo com paramentro informado.
                    _sMenu.ControlMenu(value);
                    // para para método responsável do form para controlar o comportamento dos objetos nele contido.
                    ControlReadOnly(value);
                }
                catch (Exception)
                {
                    // em caso de falha retorna apenas o status atual.
                    _stateForm = value;
                }

            }
        }

        /// <summary>
        /// Propriedade do menu principal do form.
        /// </summary>
        public SMenu SMenuPrincipal { get; set; }

        #region Controle Salvar/Editar/Excluir
        /// <summary>
        /// Método responsável em realizar o salvamento dos registros na tela.
        /// </summary>
        /// <returns></returns>
        public override bool Salvar()
        {
            try
            {
                // Verifica se todos os campos foram validados.
                if (!IsValid()) return false;
                var ret = ExecuteApp(TypeAction.Insert);
                AfterSave?.Invoke();
                ShowLog();
                return ret;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Erro ao Salvar", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ShowLog();
                return false;
            }
        }

        private static void ShowLog()
        {
            if (GlobalUser.Logs != null && GlobalUser.Logs.Any())
            {
                new FLog(GlobalUser.Logs).Show();
                GlobalUser.Logs.Clear();
            }
        }

        /// <summary>
        /// Método responsável em excluir resgitros na base de dados.
        /// </summary>
        /// <returns></returns>
        public virtual bool Excluir()
        {
            try
            {
                // Verifica se o registro atual foi salvo pela capa ou item, caso cancelada remove do banco.
                if (StateForm == StateForm.NoConfirmed)
                {
                    ExecuteApp(TypeAction.Remove);
                }
                else
                {
                    var resultMessage = MessageBox.Show(@"Deseja realmente excluir?", @"Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultMessage != DialogResult.Yes) return false;
                    ExecuteApp(TypeAction.Remove);
                }
                ShowLog();
                return true;
            }
            catch (Exception exception)
            {
                if (exception.InnerException?.InnerException != null)
                    MessageBox.Show(exception.InnerException.InnerException.Message, @"Erro ao Salvar", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show(exception.InnerException.Message, @"Erro ao Salvar", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                ShowLog();
                return false;
            }
        }
        /// <summary>
        /// Método responsável em executar o crud da tela.
        /// </summary>
        /// <param name="typeAction"></param>
        private bool ExecuteApp(TypeAction typeAction)
        {
            var nameMethod = string.Empty;
            object obj = null;
            if (typeAction != TypeAction.Insert)
            {
                if (typeAction == TypeAction.Remove)
                {
                    nameMethod = InvokeMethod.Methods.FirstOrDefault(c => c.Key == TypeExecute.Remove).Value;
                    if (string.IsNullOrEmpty(nameMethod))
                        MessageBox.Show("Método Remove não configurado\nController: " + InvokeMethod.TypeController.Name,
                            "ESR Softwares", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    obj = CurrentControl.Id;
                }
            }
            else
            {
                nameMethod = InvokeMethod.Methods.FirstOrDefault(c => c.Key == TypeExecute.InsertOrUpdate).Value;
                if (string.IsNullOrEmpty(nameMethod))
                    MessageBox.Show("Método InsertOrUpdate não configurado\nController: " + InvokeMethod.TypeController.Name,
                            "ESR Softwares", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                obj = CurrentControl;
            }

            // Via reflexão executa método crud, passando o registro atual.
            var lReturn = SReflection.ExecuteContext(InvokeMethod.TypeController, nameMethod, obj);
            return lReturn;
        }
        #endregion

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _sMenu.ControlMenu(StateForm);
            if (SReportses == null || !SReportses.Any()) return;
            foreach (var sReportse in SReportses)
            {
                var item = new RibbonButton
                {
                    Label = sReportse.Nome,
                    ToolTip = sReportse.LocalPath,
                    Tag = sReportse.DataSet,
                    Name = sReportse.DataSet.FirstOrDefault().Key
                };
                item.Click += _sMenu.ButtonBase_OnClick;
                if (_sMenu.RibbonButtonReports.Items.Cast<object>().All(item1 => ((RibbonButton)item1).Name != item.Name))
                {
                    _sMenu.RibbonButtonReports.Items.Add(item);
                }

            }

        }

        public void SForm_Load(object sender, EventArgs e)
        {
        }

        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.S:
                        if (_sMenu.MenuButtonSave.IsEnabled)
                            _sMenu.MenuButtonSave_OnClick(this, null);
                        return;
                    case Keys.E:
                        if (_sMenu.MenuButtonEdit.IsEnabled)
                            _sMenu.MenuButtonEdit_OnClick(this, null);
                        return;
                    case Keys.P:
                        if (_sMenu.MenuButtonSearch.IsEnabled)
                            _sMenu.MenuButtonSearch_OnClick(this, null);
                        return;
                    case Keys.Delete:
                        if (_sMenu.MenuButtonRemove.IsEnabled)
                            _sMenu.MenuButtonRemove_OnClick(this, null);
                        return;
                    case Keys.Back:
                        if (_sMenu.MenuButtonCancel.IsEnabled)
                            _sMenu.MenuButtonCancel_OnClick(this, null);
                        return;
                }
            }

            switch (e.KeyCode)
            {
                case Keys.PageDown:
                    if (_sMenu.MenuButtonDown.IsEnabled)
                        _sMenu.MenuButtonDown_OnClick(this, null);
                    return;
                case Keys.PageUp:
                    if (_sMenu.MenuButtonUp.IsEnabled)
                        _sMenu.MenuButtonUp_OnClick(this, null);
                    return;
                case Keys.Escape:
                    Close();
                    return;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            try
            {
                if (StateForm == StateForm.Editing || StateForm == StateForm.Inserting)
                {
                    _sMenu.MenuButtonCancel_OnClick(this, null);
                    e.Cancel = true;
                    return;
                }
            }
            catch (Exception)
            {

            }
            base.OnClosing(e);
        }

        /// <summary>
        /// Responsável em passar para menu, qual form será acrescentado na aba
        /// </summary>
        /// <param name="form">Form que será referenciado</param>
        /// <param name="sender">Component que solicitou a adição da aba.</param>
        /// <returns>Retorna a aba adicionada, para proprio component que a chamou finalize sua solicitação, quando necessário.</returns>
        public override RibbonTab AddTab(FBase form, object sender)
        {
            return _sMenu.AddTab(form, sender);
        }

        /// <summary>
        /// Remove a aba adicionada.
        /// </summary>
        /// <param name="ribbonTab">Recebe como parametro a aba que deseja remover.</param>
        public override void RemoveAba(RibbonTab ribbonTab)
        {
            if (ribbonTab != null)
                _sMenu.Ribbon.Items.Remove(ribbonTab);
        }

        /// <summary>
        /// Chama tela de pesquisa do menu.
        /// </summary>
        /// <param name="sender">Component que solicitou a chamada da tela de pesquisa.</param>
        /// <param name="e"></param>
        public override void Search(SGrid sGrid, object p)
        {
            base.Search(sGrid, p);
            _sMenu.MenuButtonSearch_OnClick(sGrid, null);
        }

        /// <summary>
        /// Retorna a coleção de reports criados no menu.
        /// Como telas filhas não tem acesso restrito ao menu, este método reponsável passar os relatórios gerados,
        /// para controle específico das telas filhas.
        /// </summary>
        /// <returns>Lista de RibbonButton criados para acesso aos relatórios</returns>
        public ItemCollection ReportList()
        {
            return _sMenu.RibbonButtonReports.Items;
        }

        /// <summary>
        /// Retorna o próprio menu.
        /// </summary>
        /// <returns></returns>
        public SMenu MenuForm()
        {
            return _sMenu;
        }

        /// <summary>
        /// Recebe um método é executado após o salvamento da tela.
        /// </summary>
        public override Action AfterSave { get; set; }
    }

}