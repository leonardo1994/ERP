using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using Esr.Core.Component.Properties;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;
using System.Data;

namespace Esr.Core.Component
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados

    /// <summary>
    /// Classe padrão para uso de tabela no sistema.
    /// Ela consiste em realizar interações com outras telas. 
    /// Add, remove e pesquisa automaticamente.
    /// Possui campo de pesquisa generico para qualquer tipo de dado
    /// Autor: Leonardo Teixeira
    /// </summary>
    public class SGrid : SControl<DataGridView>
    {
        private static int _lastDisplayIndex;

        public override Type FormType
        {
            get { return base.FormType; }
            set
            {
                base.FormType = value;
                _typeSource = null;
                _properties = null;
                SetItemsMenuReport();
            }
        }

        private void SetItemsMenuReport()
        {
            var findForm = FindForm();
            if (findForm != null && Form == null && FormType != null && findForm.Visible || (Form != null && Form.GetType() != FormType))
            {
                Form = new SReflection().CreateNewInstance<FForm>(FormType);
            }
            if (Form == null) return;

            if (SComponent.ContextMenuStrip.Items.Count > 5)
                SComponent.ContextMenuStrip.Items.RemoveAt(5);
            if (Form?.SReportses == null || !Form.SReportses.Any()) return;
            var report = new ToolStripMenuItem("Relatórios", Resources.icon_printer_40);
            foreach (var sReportse in Form.SReportses)
            {
                var item = new ToolStripMenuItem
                {
                    Text = sReportse.Nome,
                    ToolTipText = sReportse.LocalPath,
                    Tag = sReportse.DataSet,
                    Name = sReportse.DataSet.FirstOrDefault().Key
                };
                item.Click += OnReportClick;
                report.DropDownItems.Add(item);
            }
            SComponent.ContextMenuStrip.Items.Add(report);
        }

        #region Propriedades do grid
        /// <summary>
        /// Propriedade que verifica se o grid corresponderá com tela secundária.
        /// Para salvar relacionamento de n:n
        /// </summary>
        public bool ScreenSecondary { get; set; }

        /// <summary>
        /// Propriedade indica se grid será usado para resultado de consulta para retorna ao objeto que o invocou.
        /// Caso seja falso: o mesmo tentará abrir o form definido no FormType
        /// </summary>
        public bool IsSearch { get; set; }

        /// <summary>
        /// Propriedade correspondente ao Menu da tabela.
        /// </summary>
        public SMenuComponent SMenuComponent { get; set; }

        /// <summary>
        /// Propriedade correspondente ao textBox de pesquisa genérica no grid.
        /// </summary>
        public STextBox STextBox { get; set; }

        /// <summary>
        /// Propriedade responsável em fazer tratamentos em tempo de execução.
        /// </summary>
        public SReflection SReflection => new SReflection();

        /// <summary>
        /// Controle o evento que os botões do menu foram acionados.
        /// </summary>
        public ButtonAction ButtonAction { get; set; } = ButtonAction.None;
        #endregion

        #region Eventos padrão
        /// <summary>
        /// Método dispara, quando o elemento e redimencionado.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SComponentOnResize(this, e);
        }
        public override void Refresh()
        {
            if (ScreenSecondary)
            {
                base.Refresh();
                UpdateDataSource();
            }
            else
            {
                // Feito isto para forçar atualizar a tabela já que a mesma só é realizada em operação que efetivaram no banco.
                // Então eu simulo que foi incluído algo, e atualizo, depois retorno a Status normal.
                ButtonAction = ButtonAction.Insert;
                UpdateDataSource();
                ButtonAction = ButtonAction.None;
            }
        }
        #endregion

        #region Propriedades Padrão
        public override object ValueControl
        {
            get
            {
                return base.ValueControl;
            }
            set
            {
                if (value == null) return;
                SComponent.DataSource = value as IList;
                SComponent.Refresh();
            }
        }

        public override bool Disable
        {
            get { return base.Disable; }
            // ReSharper disable once ValueParameterNotUsed
            set
            {
                if (value == true)
                {
                    StatusMenu();
                }
                else
                {
                    SComponent.ContextMenuStrip.Items[0].Visible = false;
                    SComponent.ContextMenuStrip.Items[1].Visible = false;
                    SComponent.ContextMenuStrip.Items[2].Visible = false;
                    SComponent.ContextMenuStrip.Items[3].Visible = false;

                    SMenuComponent.MenuItemSearch.Enabled = false;
                    SMenuComponent.MenuItemEdit.Enabled = false;
                    SMenuComponent.MenuItemRemove.Enabled = false;
                    SMenuComponent.MenuItemNew.Enabled = false;
                }
            }
        }

        #endregion

        #region Métodos Padrão
        /// <summary>
        /// Executa ao iniciar component do objeto.
        /// </summary>
        protected override void InitLayout()
        {
            base.InitLayout();
            InitializeComponent();
            InitializeGrid();
            LoadEventItemMenu();
            SComponent.Resize += SComponentOnResize;
            SComponent.DoubleClick += SComponent_DoubleClick;
            SComponent.PreviewKeyDown += SComponent_PreviewKeyDown1;
            SComponent.ColumnDisplayIndexChanged += SComponentOnColumnDisplayIndexChanged;
            STextBox.SComponent.KeyDown += SComponentOnKeyDown;
        }

        private void SComponent_PreviewKeyDown1(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Refresh();
            }
        }

        private void SComponentOnColumnDisplayIndexChanged(object sender, DataGridViewColumnEventArgs dataGridViewColumnEventArgs)
        {
            //dataGridViewColumnEventArgs.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //if (dataGridViewColumnEventArgs.Column.DisplayIndex == _lastDisplayIndex - 1)
            //    dataGridViewColumnEventArgs.Column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        protected override void SetTextLabel(string text)
        {
            base.SetTextLabel(text);
            WidthTextBox();
        }
        #endregion

        #region Métodos específicos
        /// <summary>
        /// Inicialiaza todos os componentes compostos do grid e suas configurações.
        /// </summary>
        private void InitializeComponent()
        {
            SComponent.ColumnAdded += SComponent_ColumnAdded;
            SComponent.DataSourceChanged += SComponentOnDataSourceChanged;
            BackColor = Color.DimGray;
            STextBox = new STextBox
            {
                FlowLayoutPanel =
                {
                    AutoSize = false,
                    Height = 0
                },
                Height = 30
            };
            Label.ForeColor = Color.White;
            Label.Dock = DockStyle.Bottom;
            SMenuComponent = new SMenuComponent { Dock = DockStyle.Right };
            Controls.Add(SMenuComponent);
            WidthTextBox();
            FlowLayoutPanel.Controls.Add(STextBox);
            // Pega o contexto do menu strip do grid para para menu context menu strip.
            var menuItem = new ContextMenuStrip();
            menuItem.Items.Add(SMenuComponent.MenuItemSearch.ToolTipText, SMenuComponent.MenuItemSearch.Image, OnClick);
            menuItem.Items.Add(SMenuComponent.MenuItemNew.ToolTipText, SMenuComponent.MenuItemNew.Image, MenuItemNewOnClick);
            menuItem.Items.Add(SMenuComponent.MenuItemEdit.ToolTipText, SMenuComponent.MenuItemEdit.Image, MenuItemEditOnClick);
            menuItem.Items.Add(SMenuComponent.MenuItemRemove.ToolTipText, SMenuComponent.MenuItemRemove.Image, MenuItemRemoveOnClick);
            menuItem.Items.Add(SMenuComponent.MenuItemUpdates.ToolTipText, SMenuComponent.MenuItemUpdates.Image, MenuItemUpdates_Click);

            SComponent.ContextMenuStrip = menuItem;
        }

        private void OnReportClick(object sender, EventArgs eventArgs)
        {
            var item = sender as ToolStripMenuItem;
            if (item == null) return;

            var lista = GetListSelected();

            var dataSources = item.Tag as Dictionary<string, SInvokeMethod>;
            var data = new Dictionary<string, object>();

            if (dataSources != null)
                foreach (var dataSource in dataSources)
                {
                    var invokeMethod = dataSource.Value;
                    if (invokeMethod == null) return;

                    var returnMethod = SReflection.GetListContext(invokeMethod.TypeClass, invokeMethod.NameMethod, GetExpressionItemsSelected());
                    data.Add(dataSource.Key, returnMethod);
                }

            new FormVisualisador(
                item.ToolTipText,
                data).ShowDialog();
        }
        private void OnClick(object sender, EventArgs eventArgs)
        {
            OpenFormType(StateForm.Viewing);
            //UpdateDataSource();
        }
        private PropertyInfo[] _properties;
        private Type _typeSource;
        /// <summary>
        /// Método responsável em realizar a configuração do tamanho do campo de pesquisa.
        /// </summary>
        private void WidthTextBox()
        {
            try
            {
                if (SMenuComponent.Visible)
                {
                    STextBox.Width = Width - Label.Width - SMenuComponent.Width;
                }
                else
                {
                    STextBox.Width = Width - Label.Width - 6;
                }

                FlowLayoutPanel.Controls.SetChildIndex(Label, 0);
                FlowLayoutPanel.Controls.SetChildIndex(STextBox, 1);
            }
            catch (Exception)
            {
                // ignored
            }
        }
        /// <summary>
        /// Controla os cabeçalhos do grid.
        /// </summary>
        private void HeaderControl(DataGridViewColumn column)
        {
            if (column.Name == "ValueType")
            {

            }
            try
            {
                // Verifica palavra reservada.
                if (column.Name.EndsWith("Id") ||
                    column.Name == "UserControlId" ||
                    column.Name == "CompanyControlId" ||
                    column.Name == "Integration" ||
                    column.Name == "Status")
                {
                    column.Visible = false;
                    return;
                }

                _lastDisplayIndex = _lastDisplayIndex + 1;
                // Passa nome do objeto, para identificação.
                column.ToolTipText = @"Grid: " + Name + @" Coluna: " + column.Name;

                // Verifica tradução do cabeçalho.
                var firstOrDefault = GlobalUser.Translates.FirstOrDefault(c => c.PropertyName == column.Name);
                if (firstOrDefault != null)
                {
                    column.HeaderText = firstOrDefault.Portugues;
                }
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Atualiza os dados do contexto, buscando novamente na base de dados
        ///  </summary>
        private void UpdateDataSource()
        {
            try
            {
                _lastDisplayIndex = 0;
                if (ScreenSecondary)
                {
                    // Crio uma expressão, para pesquisar na tabela de relacionamento, com Id da tabela principal.
                    var typeDataSource = SReflection.GetTypeProperty(PropertyControl);
                    var item = Expression.Parameter(typeDataSource);
                    if (CurrentControl == null)
                    {
                        SComponent.DataSource = null;
                        SComponent.Refresh();
                        return;
                    }

                    var propriedade = typeDataSource.GetProperty(!string.IsNullOrEmpty(PropertyDependecyUkey) ? PropertyDependecyUkey : SReflection.GetTypeObject(CurrentControl).Name + "Id");

                    var prop = Expression.Property(item, propriedade);
                    var soap = Expression.Constant(((IEntityBase)CurrentControl).Id);
                    Expression equal = propriedade.PropertyType == typeof(int?) ? Expression.Equal(prop, Expression.Convert(soap, typeof(int?))) : Expression.Equal(prop, soap);

                    var delegateType = typeof(Func<,>).MakeGenericType(typeDataSource, typeof(bool));

                    var yourExpression = Expression.Lambda(delegateType, equal, true, item);

                    var method = ObjetoApp.Methods.FirstOrDefault(c => c.Key == TypeExecute.Search).Value;

                    if (string.IsNullOrEmpty(method))
                    {
                        MessageBox.Show($"Método SearchAll não configurado do Controller { ObjetoApp.TypeController.Name } para componente { Name } em propriedade: { ObjetoApp.GetType().Name }");
                        return;
                    }

                    var result = SReflection.GetListContext(ObjetoApp.TypeController, method, yourExpression) as IList;
                    SComponent.DataSource = result;
                    SComponent.Refresh();
                    SComponent.ClearSelection();
                }
                else
                {
                    if ((ObjetoApp == null || ButtonAction == ButtonAction.None) ||
                        (ObjetoApp == null || ButtonAction == ButtonAction.View)) return;

                    var method = ObjetoApp.Methods.FirstOrDefault(c => c.Key == TypeExecute.SearchAll).Value;

                    if (string.IsNullOrEmpty(method))
                    {
                        MessageBox.Show($"Método SearchAll não configurado do Controller { ObjetoApp.TypeController.Name } para componente { Name } em propriedade: { ObjetoApp.GetType().Name }");
                        return;
                    }

                    var result = SReflection.GetListContext(ObjetoApp.TypeController, method);

                    SComponent.DataSource = result;
                    SComponent.Refresh();
                    SComponent.ClearSelection();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ESR Softwares", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Abre form passado no parametro FormType
        /// </summary>
        /// <param name="stateForm">Necessário informar o Status que form será apresentado</param>
        private void OpenFormType(StateForm stateForm)
        {
            if (FormType == null) return;
            var result = GetListSelected();

            if (result == null) return;

            // Crio uma instarcia do form do tipo passado no parametro.
            //Form = new SReflection().CreateNewInstance<SForm>(FormType);
            if (Form == null) return;

            Form.IsDialog = true;

            // Passa o item retornado da consulta para contexto do form.
            Form.ObjectControl = result;

            // Inicia form em modo de edição.
            Form.StateForm = stateForm;

            // Verifica se se tela secundária é dependente da tela principal
            if (IsDependecyUkey)
            {
                SetDependecyUkey();
            }

            // Exibindo form para usuário.
            try
            {
                var propertyIntegration = result[0].GetType().GetProperty("Integration");
                if (propertyIntegration == null)
                {
                    MessageBox.Show("Propriedade Integration não encontrada na lista para o modelo: " + ObjetoApp.TypeModel.Name + "\n" + result[0].ToString());
                    return;
                }

                if ((bool)propertyIntegration.GetValue(result[0]))
                    if (stateForm == StateForm.Editing || stateForm == StateForm.Inserting)
                    {
                        MessageBox.Show(@"Este documento é proveniente de integração e não pode ser alterado", @"ESR SOFTWARES");
                        return;
                    }
                Form.AfterSave = UpdateDataSource;
                Form.Show();
            }
            catch (Exception)
            {
                // Ignore
            }
        }

        /// <summary>
        /// Método responsável em passar a Ukey do form pai, para filho de forma automática.
        /// </summary>
        private void SetDependecyUkey()
        {
            var primaryKey = GetSForm().CurrentControl.Id;
            var namedKey = !string.IsNullOrEmpty(PropertyDependecyUkey) ? PropertyDependecyUkey : GetSForm().InvokeMethod.TypeModel.Name + "Id";
            Form.PropertyDependecyUkey = Form.InvokeMethod.TypeModel.GetProperty(namedKey);
            Form.DependecyUkey = primaryKey;
        }

        /// <summary>
        /// Cria uma expression lambida de todos os Id's selecionados no grid.
        /// </summary>
        /// <returns>(param0 => param0.Id == 2 OrElse param0.Id == 3 OrElse param0.Id == 4)</returns>
        private Expression GetExpressionItemsSelected(bool getAllItems = false)
        {
            //if (Form == null && FormType != null)
            Form = new SReflection().CreateNewInstance<FForm>(FormType);

            // Verifico se o item atual não é nulo.
            if (SComponent.CurrentRow == null) return null;

            Expression yourExpression = null;
            Type typeDataSource = null;
            ParameterExpression parameterType = null;

            IList listitems;
            if (getAllItems)
            {
                listitems = SComponent.Rows;
            }
            else
            {
                listitems = SComponent.SelectedRows;
            }

            if (listitems.Count <= 0) return null;
            // Responsável em montar condição de pesquisa via Linq.
            foreach (var selectedRow in listitems)
            {
                // Pega o item atual
                var item = ((DataGridViewRow)selectedRow).DataBoundItem;

                int itemId;

                PropertyInfo propertyId;
                if (ScreenSecondary && ButtonAction != ButtonAction.Remove)
                {
                    // Pego o tipo do contexto.
                    Form = SReflection.CreateNewInstance(FormType) as FForm;
                    typeDataSource = Form.InvokeMethod.TypeModel;

                    propertyId = typeDataSource.GetProperty("Id");

                    var property = item
                        .GetType()
                        .GetProperty(!string.IsNullOrEmpty(PropertyDisplayForm) ? PropertyDisplayForm : "Id");

                    if (property == null)
                    {
                        MessageBox.Show("Propriedade " + (!IsDependecyUkey ? typeDataSource.Name + "Id" : !string.IsNullOrEmpty(PropertyDependecyUkey) ? PropertyDependecyUkey : "Id") +
                            " não encontrada\nController: " + Form.InvokeMethod.TypeController.Name +
                            "\nLocal: " + item.ToString(),
                            "ESR SOFTWARES", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return null;
                    }
                    itemId = (int)property.GetValue(item);
                }
                else
                {
                    typeDataSource = ObjetoApp.TypeModel;
                    //PropertyControl != null ? SReflection.GetTypeProperty(PropertyControl) : SReflection.GetTypeObjectCollection(Form.ObjectControl);
                    propertyId = typeDataSource.GetProperty("Id");

                    // Caso não consiga identificar pelo contexto, pega pelo nome da coluna do objeto
                    try
                    {
                        var propertyIdContext = SReflection.GetTypeObjectCollection(SComponent.DataSource).GetProperty("Id");
                        // Pego o valor da propriedade do objeto atual.
                        itemId = (int)propertyIdContext.GetValue(item);
                    }
                    catch (Exception)
                    {
                        itemId = (int)((DataGridViewRow)selectedRow).Cells["Id"].Value;
                    }
                }

                // se o tipo do objeto já foi informado para mesmo contexto, não é passado mais.
                if (parameterType == null)
                    parameterType = Expression.Parameter(typeDataSource);

                // passa o tipo da propriedade
                var prop = Expression.Property(parameterType, propertyId);
                // converte o tipo do dado, para garantir a identidade do mesmo.
                var convertedValue = Convert.ChangeType(itemId, propertyId.PropertyType);
                // cria expressao do valor que será passada na expressão.
                var soap = Expression.Constant(convertedValue);
                // relaciona a propriedade com o dado. Exemplo: param0 => param0 == 1
                var equal = Expression.Equal(prop, soap);

                yourExpression = yourExpression == null ? equal : Expression.OrElse(equal, yourExpression);
            }

            var delegateType = typeof(Func<,>).MakeGenericType(typeDataSource, typeof(bool));
            return Expression.Lambda(delegateType, yourExpression, true, parameterType);
        }
        /// <summary>
        /// Retorna todos itens selecionados, direto do contexto.
        /// </summary>
        /// <returns></returns>
        public IList GetListSelected()
        {
            try
            {
                var expression = GetExpressionItemsSelected();

                if (expression == null) return null;
                if (Form == null && FormType != null)
                    Form = new SReflection().CreateNewInstance<FForm>(FormType);
                if (Form == null) return null;

                var method = Form.InvokeMethod.Methods.FirstOrDefault(c => c.Key == TypeExecute.Search).Value;
                if (string.IsNullOrEmpty(method))
                    MessageBox.Show("Método Search não encontrado.\nController: " + Form.InvokeMethod.TypeController.Name, "ESR Softwares", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                return SReflection.GetListContext(Form.InvokeMethod.TypeController, method, expression) as IList;
            }
            catch (Exception execption)
            {
                MessageBox.Show(execption.Message, "ESR Softwares", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return null;
            }
        }
        private void StatusMenu()
        {
            if (Disable)
            {
                if (SMenuComponent == null) return;
                if (SComponent.RowCount == 0)
                {
                    var enableNew = (GetSForm()?.StateForm != StateForm.Viewing && GetSForm()?.StateForm != StateForm.Waiting);

                    if (SComponent.ContextMenuStrip != null)
                    {
                        SComponent.ContextMenuStrip.Items[0].Visible = false;
                        SComponent.ContextMenuStrip.Items[2].Visible = false;
                        SComponent.ContextMenuStrip.Items[3].Visible = false;
                        SComponent.ContextMenuStrip.Items[1].Visible = enableNew;
                    }

                    SMenuComponent.MenuItemSearch.Enabled = enableNew;
                    SMenuComponent.MenuItemEdit.Enabled = false;
                    SMenuComponent.MenuItemRemove.Enabled = false;
                    SMenuComponent.MenuItemNew.Enabled = enableNew;
                    return;
                }
                if (GetSForm()?.StateForm == StateForm.Viewing)
                {
                    if (SComponent.ContextMenuStrip != null)
                    {
                        SComponent.ContextMenuStrip.Items[0].Visible = true;
                        SComponent.ContextMenuStrip.Items[1].Visible = false;
                        SComponent.ContextMenuStrip.Items[2].Visible = false;
                        SComponent.ContextMenuStrip.Items[3].Visible = false;
                    }

                    SMenuComponent.MenuItemEdit.Enabled = false;
                    SMenuComponent.MenuItemRemove.Enabled = false;
                    SMenuComponent.MenuItemNew.Enabled = false;
                    SMenuComponent.MenuItemSearch.Enabled = false;
                }
                else
                {
                    if (SComponent.ContextMenuStrip != null)
                    {
                        SComponent.ContextMenuStrip.Items[0].Visible = true;
                        SComponent.ContextMenuStrip.Items[1].Visible = true;
                        SComponent.ContextMenuStrip.Items[2].Visible = true;
                        SComponent.ContextMenuStrip.Items[3].Visible = true;
                    }

                    SMenuComponent.MenuItemEdit.Enabled = true;
                    SMenuComponent.MenuItemRemove.Enabled = true;
                    SMenuComponent.MenuItemNew.Enabled = true;
                    SMenuComponent.MenuItemSearch.Enabled = true;
                }

            }
            else
            {
                if (SMenuComponent == null) return;
                if (SComponent.ContextMenuStrip != null)
                {
                    SComponent.ContextMenuStrip.Items[0].Visible = SComponent.RowCount != 0;
                    SComponent.ContextMenuStrip.Items[1].Visible = false;
                    SComponent.ContextMenuStrip.Items[2].Visible = false;
                    SComponent.ContextMenuStrip.Items[3].Visible = false;
                }

                SMenuComponent.MenuItemSearch.Enabled = false;
                SMenuComponent.MenuItemEdit.Enabled = false;
                SMenuComponent.MenuItemRemove.Enabled = false;
                SMenuComponent.MenuItemNew.Enabled = false;
            }
        }
        private void SComponentOnKeyDown(object sender, KeyEventArgs keyEventArgs)
        {
            var nCount = ((IList)SComponent.DataSource).Count;
            if (keyEventArgs.KeyCode == Keys.Enter && nCount > 50)
            {
                SComponent.DataSource = PesquisarNaLista(STextBox.SComponent.Text, SComponent.DataSource);
            }
            else if (nCount <= 50)
            {
                SComponent.DataSource = PesquisarNaLista(STextBox.SComponent.Text, SComponent.DataSource);
            }
        }

        public string[] PropertyInfos { get; set; }
        public List<string> ListColunas { get; set; }
        private List<object> _objects;
        private List<ArvoreList> _arvoreList;
        private Guid _pai;
        private IList _oldDataSource;

        /// <summary>
        /// Método responsável em realizar pesquisa generíca em uma lista.
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="objectList"></param>
        /// <returns></returns>
        public object PesquisarNaLista(string texto, object objectList)
        {
            try
            {
                if (_oldDataSource == null)
                    _oldDataSource = objectList as IList;
                if (objectList == null)
                    objectList = _oldDataSource;

                // Quando campo pesquisa estiver vazio, retorna todos os valores iniciais.
                if (string.IsNullOrWhiteSpace(texto))
                {
                    //DataSource = objectList;
                    var listCollection = _oldDataSource;
                    _oldDataSource = null;
                    return listCollection;
                }
                if (objectList == null) return null;

                // Pega o tipo da lista contida no dataSource do grid
                var typeDataSource = objectList.GetType().GetGenericArguments().Single();

                // Cria uma nova lista, para receber objeto generico contido no DataSource do SGrid.
                var constructorInfo = typeof(List<>)
                    .MakeGenericType(typeDataSource)
                    .GetConstructor(Type.EmptyTypes);

                if (constructorInfo == null) return null;

                var listDataSource = (IList)constructorInfo
                    .Invoke(null);

                string query = null;
                var index = 0;
                var count = 0;
                var countComp = ((IList)objectList).Count;
                var values = new List<object>();
                _objects = new List<object> { typeDataSource };
                _arvoreList = new List<ArvoreList>();
                var groupBy = ListColunas?.GroupBy(c => c).ToList();
                ListColunas?.Clear();
                if (groupBy != null)
                    foreach (var item in groupBy)
                    {
                        ListColunas.Add(item.Key);
                    }
                //ListColunas = groupBy;
                try
                {
                    foreach (var item in typeDataSource.GetProperties().Where(item => ListColunas.Contains(item.Name)))
                    {
                        try
                        {
                            CreateQuery(ref query, ref index, count, countComp, values, Guid.NewGuid(), item, item.Name);
                        }
                        catch (Exception)
                        {
                            // ignored
                        }
                        count++;
                    }
                }
                catch (Exception)
                {
                    foreach (var item in typeDataSource.GetProperties())
                    {
                        try
                        {
                            CreateQuery(ref query, ref index, count, countComp, values, Guid.NewGuid(), item, item.Name);
                        }
                        catch (Exception)
                        {
                            // ignored
                        }
                        count++;
                    }
                }

                var arrayParam = values.ToArray();
                if (!arrayParam.Any()) return listDataSource;
                if (query == null) return listDataSource;
                {
                    var newQuery = query.Remove(query.Length - 3);
                    {
                        IList listSearch = null;

                        IEnumerable list = _oldDataSource?.AsQueryable().Where(newQuery, arrayParam);
                        listSearch =
                            SReflection.CreateList(
                                ((IList)objectList).GetType().UnderlyingSystemType.GenericTypeArguments.Single());

                        if (list == null) return listSearch;
                        foreach (var item in list)
                        {
                            listSearch.Add(item);
                        }

                        return listSearch;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        private void CreateQuery(ref string query, ref int index, int count, int countComp, ICollection<object> values, Guid guid, PropertyInfo item, string nameArgument)
        {
            try
            {
                if (_objects.Contains(item.PropertyType)) return;
                if (typeof(TypeCode).GetEnumNames().All(i => i != item.PropertyType.Name) && item.PropertyType.Name != "ICollection`1" && Nullable.GetUnderlyingType(item.PropertyType) == null)
                {
                    if (PropertyInfos != null && PropertyInfos.Contains(item.Name))
                    {
                        _objects.Add(item.PropertyType);
                        _pai = guid;
                        guid = Guid.NewGuid();
                        var nomeProp = _arvoreList.FirstOrDefault(c => c.Guid == _pai && !c.Collection)?.NomeProperty;
                        nomeProp = nomeProp?.PadRight(nomeProp.Length + 1, '.') + item.Name;
                        _arvoreList.Add(new ArvoreList() { Guid = guid, Pai = _pai, NomeProperty = nomeProp });
                        var propriedades = item.PropertyType.GetProperties();
                        foreach (var propertyInfo in propriedades)
                        {
                            var nome = _arvoreList.First(c => c.Guid == guid).NomeProperty;
                            _arvoreList.Add(new ArvoreList()
                            {
                                Guid = Guid.NewGuid(),
                                Pai = guid,
                                NomeProperty = propertyInfo.Name
                            });
                            nameArgument = nome + "." + propertyInfo.Name;

                            CreateQuery(ref query, ref index, count, countComp, values, guid, propertyInfo, nameArgument);
                        }
                    }
                }
                else if (item.PropertyType.Name == "ICollection`1")
                {
                    if (PropertyInfos != null && PropertyInfos.Contains(item.Name))
                    {
                        var tipo = item.PropertyType.GetGenericArguments().Single();
                        if (_objects.Contains(tipo)) return;
                        _pai = Guid.NewGuid();

                        _pai = guid;
                        var nomeProp = _arvoreList.FirstOrDefault(c => c.Guid == _pai && !c.Collection)?.NomeProperty;
                        nomeProp = nomeProp?.PadRight(nomeProp.Length + 1, '.') + item.Name;
                        guid = Guid.NewGuid();
                        query = query + nomeProp + ".Where(";
                        _objects.Add(tipo);
                        _arvoreList.Add(new ArvoreList() { Guid = guid, Pai = _pai, NomeProperty = item.Name, Collection = true });
                        foreach (var propertyInfo in tipo.GetProperties())
                        {
                            nameArgument = propertyInfo.Name;
                            CreateQuery(ref query, ref index, count, countComp, values, guid, propertyInfo, nameArgument);
                        }
                        query = query.Remove(query.Length - 3) + ").Any() OR ";
                    }
                }

                if (Type.GetTypeCode(item.PropertyType) == TypeCode.DateTime)
                {
                    query = query + " (" + nameArgument + " != null AND " + nameArgument + ".ToString().Contains(@" + index + (count == countComp ? ")) " : ")) OR ");
                    values.Add(STextBox.SComponent.Text.ToLower());
                    index++;
                }
                else if (item.PropertyType == typeof(DateTime?))
                {
                    query = query + " (" + nameArgument + ".HasValue AND " + nameArgument + ".Value.ToString().Contains(@" + index + (count == countComp ? ")) " : ")) OR ");
                    values.Add(STextBox.SComponent.Text.ToLower());
                    index++;
                }
                else
                {
                    var enumsName = typeof(TypeCode).GetEnumNames().Where(c => c == item.PropertyType.Name);
                    {
                        if (!enumsName.Any()) return;

                        var objColle = _arvoreList.FirstOrDefault(c => c.Guid == guid && c.Collection);
                        if (objColle != null && objColle.Collection)
                        {
                            var firstOrDefault = _arvoreList.FirstOrDefault(c => c.Pai == objColle.Pai);
                            if (firstOrDefault != null && !objColle.Collection)
                            {
                                var nomeProp = firstOrDefault.NomeProperty.PadRight(firstOrDefault.NomeProperty.Length + 1, '.') +
                                                  item.Name;
                                nameArgument = nomeProp;
                            }
                            else
                            {
                                nameArgument = item.Name;
                            }
                        }
                        query = query + " (" + nameArgument + " != null AND " + nameArgument + ".ToString().ToLower().Contains(@" + index + (")) OR ");
                        values.Add(STextBox.SComponent.Text.ToLower());
                        index++;
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region Evento Específicos
        private void SComponent_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode == Keys.P)
                {
                    MenuItemSearchOnClick(this, e);
                }

                if (e.KeyCode == Keys.N)
                {
                    MenuItemNewOnClick(this, e);
                }

                if (e.KeyCode == Keys.R)
                {
                    MenuItemRemoveOnClick(this, e);
                }

                if (e.KeyCode == Keys.E)
                {
                    MenuItemEditOnClick(this, e);
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                (FindForm() as FSearch)?.Hide();
            }
            OnPreviewKeyDown(e);
        }
        /// <summary>
        /// Após clicar 2 vezes na loja, abre o item para edição.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SComponent_DoubleClick(object sender, EventArgs e)
        {
            ButtonAction = ButtonAction.View;
            var table = SComponent.DataSource as DataTable;
            if (table != null)
            {
                if (table.Rows.Count == 0) return;
            }
            else if (SComponent.DataSource is IList)
                if (!((IList)SComponent.DataSource).Any()) return;
            if (!IsSearch)
                OpenFormType(StateForm.Viewing);
        }
        /// <summary>
        /// Controlamos a inserção de cada coluna para seguir tradução de palavras, quanto permissão de visualização.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SComponent_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            HeaderControl(e.Column);
        }
        /// <summary>
        /// Para redefinir tamanho do campo de pesquisa do grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SComponentOnResize(object sender, EventArgs e)
        {
            WidthTextBox();
        }
        /// <summary>
        /// Quando o contexto atualizado, verifica se o mesmo contém informações, caso não redefini o menu, para opções que não 
        /// poderão ser utilizadas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void SComponentOnDataSourceChanged(object sender, EventArgs eventArgs)
        {
            StatusMenu();
        }
        #endregion

        #region Configuração SMenuComponent

        /// <summary>
        /// Distribiu os eventos dos itens do menu.
        /// </summary>
        private void LoadEventItemMenu()
        {
            SMenuComponent.MenuItemSearch.Click += MenuItemSearchOnClick;
            SMenuComponent.MenuItemNew.Click += MenuItemNewOnClick;
            SMenuComponent.MenuItemEdit.Click += MenuItemEditOnClick;
            SMenuComponent.MenuItemRemove.Click += MenuItemRemoveOnClick;
            SMenuComponent.MenuItemReports.Click += MenuItemReports_Click;
            SMenuComponent.MenuItemUpdates.Click += MenuItemUpdates_Click;
        }

        private void MenuItemUpdates_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void MenuItemReports_Click(object sender, EventArgs e)
        {
            new FSearch(Form.Name, TypeSearch.Report, sender).Show();
        }

        /// <summary>
        /// Evento responsável, em deletar registro do banco, de acordo com item selecionado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemRemoveOnClick(object sender, EventArgs e)
        {
            try
            {
                // Crio uma instarcia do form do tipo passado no parametro.
                //Form = new SReflection().CreateNewInstance<SForm>(FormType);
                if (Form == null)
                    Form = new SReflection().CreateNewInstance<FForm>(FormType);

                var permissionDelete = GlobalUser.User.GroupUsers.Any(c1 => c1.GroupAccess.GroupPermissions.Any(c => c.Permission.TypeComponent == TypeComponent.Screen && c.Permission.NamePermission == Form.Name && !c.Permission.Delete));
                if (permissionDelete)
                {
                    MessageBox.Show(@"Você não tem permissão para excluir", @"ESR Softwares", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                ButtonAction = ButtonAction.Remove;
                var countSelected = SComponent.SelectedRows.Count;
                var returnMessage =
                    MessageBox.Show(@"Deseja realmente excluir " + countSelected + (countSelected == 1 ? @" item" : @" itens"),
                        @"ESR Softwares", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (returnMessage != DialogResult.Yes) return;

                var method = ObjetoApp.Methods.FirstOrDefault(c => c.Key == TypeExecute.RemoveListId).Value;
                if (string.IsNullOrEmpty(method))
                {
                    MessageBox.Show("Método RemoveListId não encontrado.\nController: " + ObjetoApp.TypeController.Name + "\nComponente: " + Name, "ESR Softwares", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                SReflection.ExecuteContext(ObjetoApp.TypeController, method, GetExpressionItemsSelected());
                UpdateDataSource();
                ShowLog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + "\n" + exception.InnerException?.Message, @"Erro ao Excluir", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ShowLog();
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
        /// Evento resposável, para abrir tela secundária, para edição do item atual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemEditOnClick(object sender, EventArgs e)
        {
            try
            {
                ButtonAction = ButtonAction.Edit;
                OpenFormType(StateForm.Editing);
            }
            catch (Exception exception)
            {
                if (exception.InnerException?.InnerException != null)
                    MessageBox.Show(exception.InnerException.InnerException.Message, @"Erro ao Editar", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Evento responsável, em disparar tela secundária com relacionamento ou 
        /// apenas tabela de exibição de dados, mas com função de manipular os items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void MenuItemNewOnClick(object sender, EventArgs eventArgs)
        {
            try
            {
                ButtonAction = ButtonAction.Insert;

                if (FormType != null)
                    Form = new SReflection().CreateNewInstance<FForm>(FormType);

                if (Form == null) return;

                // Passo o status NoConfirmed, pois o usuário pode cancelar a inserção.
                Form.StateForm = StateForm.NoConfirmed;

                Form.IsDialog = true;

                Form.bindingSource.Clear();

                if (Form.bindingSource.Count == 0)
                    Form.bindingSource.AddNew();

                // Inicia form em modo de inserção.
                Form.StateForm = StateForm.Inserting;

                // Verifica se tipo do grid será comportado como tela secundária, trabalhando com relacionamento.
                if (ScreenSecondary)
                {
                    // Salva os registros da tela principal
                    if (!GetSForm().Salvar()) return;

                    // Verifica se se tela secundária é dependente da tela principal
                    if (IsDependecyUkey)
                    {
                        SetDependecyUkey();
                    }

                    Form.RefreshControls();

                    // Abre tela para usuário.
                    Form.Show();

                    //SaveRelation();

                    // Atualiza tabela buscando na base de dados.
                    Form.AfterSave = UpdateDataSource;

                    if (!IsDependecyUkey)
                        Form.AfterSave = SaveRelation;
                }
                else
                {
                    if (Form == null) return;

                    Form.IsDialog = true;

                    // Inicializa tela em modo de inserção
                    Form.bindingSource.Clear();
                    Form.bindingSource.AddNew();
                    Form.StateForm = StateForm.Inserting;

                    // Dispara tela para usuário.
                    Form.Show();


                    // Caso o usuário não salvo definitivamente contexto, não continua a atualização.
                    if (Form.CurrentControl == null) return;
                    if (Form.CurrentControl.Id == 0) return;

                    // Se contexto foi atualizado, o grid é atualizado.
                    UpdateDataSource();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    exception.InnerException?.InnerException?.Message ?? exception.Message, @"Erro ao Salvar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento responsável em disparar modal de visualização.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void MenuItemSearchOnClick(object sender, EventArgs eventArgs)
        {
            if (Form == null && FormType != null)
            {
                Form = new SReflection().CreateNewInstance<FForm>(FormType);
            }

            if (Form == null) return;

            if (ScreenSecondary && IsDependecyUkey)
            {
                var selecteds = GetListSelected();

                if (selecteds == null) return;
                Form.SetUkey((from object item in selecteds select ((IEntityBase)item).Id).ToList());
                Form.StateForm = StateForm.Viewing;
                Form.ShowDialog();
            }
            else
            {
                if (ScreenSecondary && !IsDependecyUkey)
                    if (!GetSForm().Salvar()) return;
                Form.Search(this, null);
                if (!ScreenSecondary) SComponent.DataSource = Form.ResultSearch ?? SComponent.DataSource;
                else
                    SaveRelation();
            }
            SComponent.ClearSelection();
        }

        #region Salva tabela de relacionamento
        private void SaveRelation()
        {
            // pego objeto da tela principal
            var primaryControl = (IEntityBase)CurrentControl;

            foreach (var current in Form.bindingSource.List)
            {
                if (((IEntityBase)current).Id == 0)
                {
                    MessageBox.Show(@"Não foi possível criar o relacionamento entre " + GetSForm().Text + @" e " + Form.GetAttribute<DisplayNameAttribute>().DisplayName +
                                @". Causa: não foi possível salvar " + GetSForm().Text, @"ESR Softwares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    continue;
                }

                // Id da tela principal
                var primaryId = primaryControl.Id;

                // Id da tela secundária
                var secondId = ((IEntityBase)current).Id;

                // Pego o tipo do objeto de relacionamento
                var typeDataSource = SReflection.GetTypeProperty(PropertyControl);

                // Cria uma instância do objeto de relacionamento
                var newInstance = SReflection.CreateNewInstance(typeDataSource);

                // Pego as propriedades do objeto de relacionamento.
                var properties = SReflection.GetProperties(newInstance);

                // Pego a propriedade correspondente da tela principal
                var primaryProp = properties.First(c => c.Name == GetSForm().InvokeMethod.TypeModel.Name + "Id");

                // Pego a propriedade correspondente a tela secundária
                var secondProp = properties.First(c => c.Name == Form.InvokeMethod.TypeModel.Name + "Id");

                #region Verifica se o item já existe no relacionamento
                #region Objeto Primário
                var parameter = Expression.Parameter(ObjetoApp.TypeModel);
                var propPrimario = Expression.Property(parameter, primaryProp);
                var valuePrimario = Expression.Constant(primaryId);
                var expressionPrimario = Expression.Equal(propPrimario, valuePrimario);
                #endregion
                #region Objeto secundário
                var propSecundario = Expression.Property(parameter, secondProp);
                var valueSecundario = Expression.Constant(secondId);
                var expressionSecundario = Expression.Equal(propSecundario, valueSecundario);
                #endregion
                var expressionFinal = Expression.And(expressionPrimario, expressionSecundario);
                var delegateType = typeof(Func<,>).MakeGenericType(ObjetoApp.TypeModel, typeof(bool));
                var expression = Expression.Lambda(delegateType, expressionFinal, true, parameter);
                var result = SReflection.GetListContext(ObjetoApp.TypeController, ObjetoApp.Methods[TypeExecute.Search], expression);
                if (result.Any())
                    continue;
                #endregion

                // Passa o Id da tela principal e da tela secundária, para objeto de relacionamento
                primaryProp.SetValue(newInstance, primaryId);
                secondProp.SetValue(newInstance, secondId);

                // Salvo o objeto de relacionamento.
                var methodInsert = ObjetoApp.Methods.FirstOrDefault(c => c.Key == TypeExecute.InsertOrUpdate).Value;

                if (methodInsert == null)
                {
                    MessageBox.Show("Método InsertOrUpdate não informado " +
                           "\nLocal: " + Name + "\nObjeto: " + GetType().Name,
                           "ESR SOFTWARES", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    continue;
                }

                SReflection.ExecuteContext(ObjetoApp.TypeController, methodInsert, newInstance);

                UpdateDataSource();

                ShowLog();
            }
        }
        #endregion

        #endregion

        #region Designer Grid

        private void InitializeGrid()
        {
            SComponent.Top = SComponent.Top + 5;
            SComponent.PreviewKeyDown += SComponent_PreviewKeyDown;

            var dataGridViewCellStyle1 = new DataGridViewCellStyle();
            var dataGridViewCellStyle2 = new DataGridViewCellStyle();
            var dataGridViewCellStyle3 = new DataGridViewCellStyle();

            SComponent.AllowUserToAddRows = false;
            SComponent.AllowUserToDeleteRows = false;
            SComponent.AllowUserToOrderColumns = true;
            SComponent.AllowUserToResizeRows = true;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 64, 64);
            SComponent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;

            SComponent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            SComponent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SComponent.BackgroundColor = Color.White;
            SComponent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SComponent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SComponent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SComponent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            SComponent.DefaultCellStyle = dataGridViewCellStyle3;
            SComponent.EditMode = DataGridViewEditMode.EditProgrammatically;

            SComponent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            SComponent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SComponent.RowHeadersVisible = false;
        }

        #endregion
    }

    public class ArvoreList
    {
        public Guid Guid { get; set; }
        public Guid Pai { get; set; }
        public string NomeProperty { get; set; }
        public bool Collection { get; set; }
    }

    public enum ButtonAction
    {
        None,
        Insert,
        Edit,
        View,
        Remove
    }
}