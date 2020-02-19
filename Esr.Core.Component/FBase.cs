using Esr.Core.App.Catalog;
using Esr.Core.App.ConfNumbering;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Controls.Ribbon;
using System.Windows.Forms;

namespace Esr.Core.Component
{
    public partial class FBase : Form
    {
        public ComponentResourceManager FormResources { get; set; }

        /// <summary>
        /// Pega o nome do modulo em que a tela correponde.
        /// </summary>
        public string Module { get; set; }

        public IFactoryConnection FactoryConnection { get; }

        public FBase()
        {
            InitializeComponent();

            try
            {
                FactoryConnection = new RepositoryInjection().GetClass<IFactoryConnection>();
                _tableApp = new TableApp(FactoryConnection);
                AutomaticNumberingApp = new AutomaticNumberingApp(FactoryConnection);
            }
            catch (Exception)
            {
            }
        }

        protected readonly TableApp _tableApp;

        public AutomaticNumberingApp AutomaticNumberingApp { get; set; }

        /// <summary>
        /// Propriedade indica imagem de assciação a tela, 
        /// será usado para objetos relacionados para trabalhar com menu superior.
        /// </summary>
        public Image ImageSource { get; set; }

        /// <summary>
        /// Indica se a tela será fechada, após salvar.
        /// </summary>
        public virtual bool ClosedAfterSave { get; set; }

        /// <summary>
        /// Propriedade que indica a chave principal
        /// </summary>
        public virtual PropertyInfo PropertyDependecyUkey { get; set; }

        /// <summary>
        /// Id da chave principal
        /// </summary>
        public virtual int DependecyUkey { get; set; }

        /// <summary>
        /// Propriedade que guarda consulta realizada na tela de pesquisa.
        /// </summary>
        public virtual object ResultSearch { get; set; }

        /// <summary>
        /// Verifica se tela é secundária.
        /// Caso seja é fechada automáticamente.
        /// </summary>
        public virtual bool IsDialog { get; set; }

        /// <summary>
        /// Propriedade que guarda a classe que será representada para todo contexto do form.
        /// Exemp.: new List<Type>();
        /// </summary>
        public virtual object ObjectControl { get; set; }

        /// <summary>
        /// Recebe classe de controller do componente.
        /// </summary>
        public virtual InvokeMethod InvokeMethod { get; set; }

        /// <summary>
        /// Propriedade que guarda o registro atual posicionado no BindingSource do form.
        /// </summary>
        public virtual IEntityBase CurrentControl { get; set; }

        /// <summary>
        /// Form por padrão é iniciado em modo de aguardando ação do usuário 
        /// Apenas os botões de pesquisa e adicionar fica disponível.
        /// </summary>
        protected StateForm _stateForm = StateForm.Waiting;

        /// <summary>
        /// Propriedade para executar comandos em tempo de execução.
        /// </summary>
        public readonly SReflection SReflection = new SReflection();

        /// <summary>
        /// Propridade para controle do status da tela.
        /// </summary>
        public virtual StateForm StateForm { get; set; }

        /// <summary>
        /// Lista de relatório que será exibidos no menu.
        /// </summary>
        public virtual List<SReports> SReportses { get; set; }

        public virtual Action AfterSave { get; set; }

        /// <summary>
        /// Verifica se os objetos são todos válidos.
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            var orderedEnumerable = GetListControls().Where(c => c.FieldValid == false);
            if (!orderedEnumerable.Any()) return true;
            orderedEnumerable.OrderBy(c => c.Index);
            orderedEnumerable.First().SetFocus();
            MessageBox.Show(@"Existem campos obrigatórios", @"Preencha os campos em destaque", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        /// <summary>
        /// Força atualização de todos os objetos da tela.
        /// </summary>
        public void RefreshControls()
        {
            try
            {
                var fieldsForm = GetListControls().OrderBy(c => c.Index);
                foreach (var fieldInfo in fieldsForm)
                {
                    if (StateForm != StateForm.Waiting)
                        if (GlobalUser.User != null)
                            foreach (var groupUser in GlobalUser.User.GroupUsers)
                            {
                                foreach (var groupPermission in groupUser.GroupAccess.GroupPermissions)
                                {
                                    if (groupPermission.Permission.TypeComponent != TypeComponent.Field) continue;
                                    if (groupPermission.Permission.NamePermission != fieldInfo.Name) continue;
                                    if (groupPermission.Permission.Delete)
                                        fieldInfo.Disable = false;
                                    else if (groupPermission.Permission.Insert)
                                        fieldInfo.Disable = false;
                                    else if (groupPermission.Permission.Update)
                                        fieldInfo.Disable = false;
                                    else if (groupPermission.Permission.Visible)
                                        fieldInfo.Visible = false;
                                }
                            }
                    fieldInfo.Refresh();
                    if (StateForm == StateForm.Inserting && !fieldInfo.DisabledAutomaticNumbering)
                    {
                        var fieldConf = GlobalUser.AutomaticNumberings.FirstOrDefault(c => c.DbTable.TableName == InvokeMethod.TypeModel.Name && c.FieldName == fieldInfo.Name);
                        if (fieldConf != null)
                        {
                            var sequencia = AutomaticNumberingApp.GerarSequencia(fieldConf.DbTableId, fieldConf.FieldName);
                            if (sequencia.HasValue)
                            {
                                var reflection = new SReflection();
                                var valueConvertido = reflection.ConvertValue(sequencia, fieldInfo.PropertyControl);
                                fieldInfo.ValueControl = valueConvertido;
                                GlobalUser.AutomaticNumberings = AutomaticNumberingApp.Search().ToList();
                            }
                            fieldInfo.Disable = false;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Executa ao iniciar o Form
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            try
            {
                foreach (var groupUser in GlobalUser.User.GroupUsers)
                {
                    foreach (var groupPermission in groupUser.GroupAccess.GroupPermissions)
                    {
                        if (groupPermission.Permission.TypeComponent != TypeComponent.Screen) continue;
                        if (groupPermission.Permission.NamePermission != Name) continue;
                        if (groupPermission.Permission.Visible) continue;
                        MessageBox.Show(@"Você não tem acesso a está tela", @"ESR Softwares", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        StateForm = StateForm.Waiting;
                        Close();
                    }
                }

                var text = "ESR Softwares";

                text = GetAttribute<DisplayNameAttribute>()?.DisplayName ?? Name;

                if (!GlobalUser.Forms.Any(t => t.TableName == Name))
                {
                    var table = new Domain.Catalog.Table()
                    {
                        Status = Status.Confirmed,
                        TableName = Name,
                        DescriptionForm = text
                    };
                    _tableApp.InsertOrUpdate(table);
                    if (FactoryConnection.Save())
                        GlobalUser.Forms.Add(table);
                }

                Text = text;

                RefreshControls();
            }
            catch (Exception)
            {
            }
            base.OnLoad(e);
        }

        #region Controle Componentes Status Tela

        public void ControlReadOnly(StateForm stateForm)
        {
            switch (stateForm)
            {
                case StateForm.Editing:
                    SetReadOnly(true);
                    break;
                case StateForm.Inserting:
                    SetReadOnly(true);
                    break;
                case StateForm.Viewing:
                    SetReadOnly(false);
                    break;
                case StateForm.Waiting:
                    SetReadOnly(false);
                    break;
                case StateForm.NoConfirmed:
                    SetReadOnly(true);
                    break;
            }
        }

        private void SetReadOnly(bool active)
        {
            var fieldsForm = GetListControls();
            foreach (var fieldInfo in fieldsForm)
            {
                fieldInfo.Disable = active;
                switch (StateForm)
                {
                    case StateForm.Viewing:
                        fieldInfo.RemoveErrorProvider();
                        break;
                    case StateForm.Waiting:
                        fieldInfo.Clear();
                        break;
                    case StateForm.Inserting:
                        fieldInfo.Clear();
                        break;
                }
            }
        }

        public IEnumerable<IComponent> GetListControls()
        {
            var list = GetType().GetRuntimeFields().Where(c => c.GetValue(this) is IComponent);
            return list.Select(fieldInfo => (IComponent)fieldInfo.GetValue(this)).ToList();
        }

        #endregion

        #region Controle Atributos da classe

        public TAttribute GetAttribute<TAttribute>() where TAttribute : Attribute
        {
            var resultAttributes = InvokeMethod?.TypeModel?.GetCustomAttributes(typeof(TAttribute), true);
            return resultAttributes?.OfType<TAttribute>().FirstOrDefault(itemAttributes => true);
        }

        #endregion

        public virtual bool Salvar()
        {
            return true;
        }

        /// <summary>
        /// Responsável em passar para menu, qual form será acrescentado na aba
        /// </summary>
        /// <param name="form">Form que será referenciado</param>
        /// <param name="sender">Component que solicitou a adição da aba.</param>
        /// <returns>Retorna a aba adicionada, para proprio component que a chamou finalize sua solicitação, quando necessário.</returns>
        public virtual RibbonTab AddTab(FBase form, object sender)
        {
            return null;
        }

        /// <summary>
        /// Remove a aba adicionada.
        /// </summary>
        /// <param name="ribbonTab">Recebe como parametro a aba que deseja remover.</param>
        public virtual void RemoveAba(RibbonTab ribbonTab)
        {
        }

        public virtual void SetUkey(List<int> ids)
        {
            var nameMethod = InvokeMethod.Methods.FirstOrDefault(c => c.Key == TypeExecute.Search).Value;
            if (string.IsNullOrEmpty(nameMethod))
                MessageBox.Show("Método Search não configurado\nController: " + InvokeMethod.TypeController.Name,
                            "ESR Softwares", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            ObjectControl = SReflection.GetListContext(InvokeMethod.TypeController, nameMethod, GetExpressionItemsSelected(ids));
            RefreshControls();
        }

        public virtual Expression GetExpressionItemsSelected(IEnumerable<int> ids)
        {
            Expression yourExpression = null;
            Type typeDataSource = null;
            ParameterExpression parameterType = null;

            // Responsável em montar condição de pesquisa via Linq.
            foreach (var id in ids)
            {
                // Pego o tipo do contexto.
                typeDataSource = InvokeMethod.TypeModel;

                // Para garantia de Lista anonima (generica), pesquisa pela propriedade Id, 
                // chave primária do objeto.
                var propertyId = typeDataSource.GetProperty("Id");

                // Pego o valor da propriedade do objeto atual.
                var itemId = id;

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

        public virtual void Search(SGrid sGrid, object p)
        {
        }
    }

    /// <summary>
    /// Informa status do form, para controle do menu entre outras ações respectiva.
    /// </summary>
    public enum StateForm
    {
        Inserting,
        Editing,
        Viewing,
        Waiting,
        NoConfirmed
    }


    /// <summary>
    /// Numeração para definir o tipo de ação que será executada.
    /// </summary>
    public enum TypeAction
    {
        Insert,
        Remove
    }
}