using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Esr.Core.App.Translation;
using Esr.Core.Component.SAttributes;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.EnumBase;
using Esr.Core.Domain.Translation;
using Esr.Core.Repository.DependencyInjection;
using Esr.Core.Domain.RepositoryFactory;

namespace Esr.Core.Component
{
    public class SControl<T> : Control, IComponent where T : Control, new()
    {
        #region Propriedades do componente
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        protected IContainer Components { get; }

        /// <summary>
        /// Propriedade responsável em guardar o objeto que será representado dentro do controle pai.
        /// </summary>
        public T SComponent { get; set; }

        /// <summary>
        /// Classe responsável na execução de chamada de tela. 
        /// </summary>
        public virtual Type FormType { get; set; }

        /// <summary>
        /// Propriedade interna protegida apenas para objetos filhos.
        /// </summary>
        public virtual FBase Form { get; set; }

        /// <summary>
        /// Propriedade responsável na execução da Regra de negócio do componente.
        /// </summary>
        public InvokeMethod ObjetoApp { get; set; }

        /// <summary>
        /// Este painel, aloca o component principal, SComponent.
        /// Fica na parte inferior do Layout
        /// </summary>
        public Panel Panel { get; set; }

        /// <summary>
        /// Este painel Fluido, aloca Label de exibição do controle, 
        /// fica na parte Superior do Layout.
        /// </summary>
        public Panel FlowLayoutPanel { get; set; }

        /// <summary>
        /// Verifica se objeto é dependente de Ukey, se acaso for objeto de pesquisa externa
        /// e feito o tratamento na passagem da Ukey da capa, para respectivo item.
        /// </summary>
        public bool IsDependecyUkey { get; set; }

        /// <summary>
        /// Está propriedade pode ser usada caso o nome da Foreing Key não consiga ser resolvida pelo objeto.
        /// Pois o objeto pega o nome da classe pai, por exemplo classe Familia, então o objeto vai busca por uma propriedade chamada
        /// FamiliaId, caso não esteja seguindo está nomenclatura, necessário informar o nome da propriedade, para  o objeto fazer
        /// a ligação de dependência. 
        /// </summary>
        public string PropertyDependecyUkey { get; set; }

        /// <summary>
        /// Informar qual propriedade terá que verificar para abrir a tela secondária, senão preenchido considera a propriedade ID como padrão.
        /// </summary>
        public string PropertyDisplayForm { get; set; }

        /// <summary>
        /// Responsável em pegar o TabIndex, usado para focu do primeiro objeto que falhou na validação de conteúdo. 
        /// </summary>
        public int Index => SComponent.TabIndex;

        /// <summary>
        /// Cor de fundo padrão dos objetos é branco.
        /// </summary>
        public override Color BackColor { get; set; } = Color.White;

        public Color ComponentBackColor
        {
            get { return SComponent.BackColor; }
            set { SComponent.BackColor = value; }
        }

        public object CurrentControl => GetSForm().CurrentControl;

        public object Others { get; set; }

        /// <summary>
        /// Desabilita numeração automática para o componente.
        /// </summary>
        public bool DisabledAutomaticNumbering { get; set; }

        #endregion

        protected SControl()
        {
            Components = new Container();
            LoadLayout();
            SuspendLayout();
            ResumeLayout(false);
            Controls.Add(Panel);
            Controls.Add(FlowLayoutPanel);
            SComponent = new T { Dock = DockStyle.Fill };
            Panel.Controls.Add(SComponent);
        }

        #region Property Custom
        [Category("ESR"), Description("Texto de título do componente")]
        public virtual string Caption { get { return GetTextLabel(); } set { SetTextLabel(value); } }
        [Category("ESR"), Description("Permite selecionar direção do título do component.")]
        public CaptionAlign CaptionAlign { get; set; }
        [Category("ESR"), Description("Centralizar titulo do componente")]
        public bool CenterCaption { get; set; }
        [Category("ESR"), Description("Informação que aparece no efeito Ballon, para detalhes do componente.")]
        public string ToolTipContext { get; set; }
        [Category("ESR"), Description("Habilita e desabilita todo o componente, até os seus dependentes.")]
        public virtual bool Disable
        {
            get
            { return Enabled; }
            set
            { Enabled = Name == "Id" ? false : value; }
        }
        #endregion

        #region Methods Custom
        /// <summary>
        /// Responsável em resetar os valores dos componentes.
        /// </summary>
        public virtual void Clear()
        {
            RemoveErrorProvider();
        }
        /// <summary>
        /// Remove stilo de validação no campo.
        /// </summary>
        public void RemoveErrorProvider()
        {
            _errorProvider.Clear();
            Validations?.Clear();
            SComponent.BackColor = Color.White;
        }
        public void SetFocus()
        {
            SComponent.Focus();
        }
        /// <summary>
        /// Carrega configurações do Layout interno do component. 
        /// Painel e Painel Fluido.
        /// </summary>
        public void LoadLayout()
        {
            FlowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Location = new Point(0, 0),
                AutoSize = true,
                TabIndex = 0,
                WrapContents = false
            };
            Panel = new Panel
            {
                Dock = DockStyle.Fill,
                Location = new Point(0, 100),
                Size = new Size(512, 143),
                TabIndex = 1
            };
        }
        #endregion

        #region Propriedades de controle do Binding
        /// <summary>
        /// Propriedade utilizada, para controle das caracteristas do da propriedade que pertence ao contexto.
        /// </summary>
        public PropertyInfo PropertyControl { get; set; }
        /// <summary>
        /// Propriedade para fazer binding direto ao objeto de contexto.
        /// </summary>
        public object ObjectControl { get; set; }
        /// <summary>
        /// Propriedade para validar se propriedade de contexto o binding foi válido.
        /// </summary>
        public bool FieldValid
        {
            get { return !IsValid().ContainsValue(false); }
            set { }
        }
        /// <summary>
        /// Propriedade que representa o valor do componente.
        /// </summary>
        public virtual object ValueControl
        {
            get { return GetPropertyText(); }
            set
            {
                SetValueProperty(value);
            }
        }
        #endregion

        #region Atributos do componente
        /// <summary>
        /// Propriedade label para caption do objeto.
        /// </summary>
        public readonly SLabel Label = new SLabel();
        /// <summary>
        /// Propriedade para disparar erro de validação.
        /// </summary>
        protected readonly ErrorProvider _errorProvider = new ErrorProvider();
        /// <summary>
        /// Propriedade para disparar ToolTip de informações.
        /// </summary>
        private SToolTipText _sToolTipText;
        #endregion

        #region Eventos padrão
        protected override void InitLayout()
        {
            try
            {
                SetObjectControl();
            }
            catch (Exception)
            {
                //Ignore
            }
            TabStop = false;
            Font = new Font("Segoe UI", 12);
            SComponent.Font = Font;
            SComponent.PreviewKeyDown += SComponent_PreviewKeyDown;
            AutoSize = true;
            SComponent.TabIndex = TabIndex;
            ShootError(IsValid());
            AddLabel();
            base.InitLayout();
        }
        private void SComponent_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode != Keys.F1) return;
            _sToolTipText?.Dispose();
            var displayInfo = (ToolTipContext ?? GetAttribute<DisplayInfoAttribute>(PropertyControl)?.DisplayName) ??
                              "nenhum informação definida";
            var formName = GetSForm()?.Name ?? "Indefinido";
            _sToolTipText = new SToolTipText
            {
                ToolTipTitle = "Campo: " + Name + " | Tela: " + formName + " | Parent: " + Parent.Name,
                Context = "Descrição: " + displayInfo
            };
            _sToolTipText.SetToolTip(SComponent, _sToolTipText.Context);
        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            SComponent.Focus();
        }
        public override void Refresh()
        {
            base.Refresh();
            try
            {
                if (PropertyControl == null)
                {
                    SetObjectControl();
                    AddLabel();
                    return;
                }
                ObjectControl = GetSForm().CurrentControl;
                ValueControl = GetPropertyText();
            }
            catch (InvalidCastException)
            {
                ValueControl = new SReflection().ConvertValue(GetPropertyText(), PropertyControl);
            }
            catch (Exception)
            {
                // ignored
            }
        }
        #endregion

        #region Controle Bnding
        /// <summary>
        /// Método responsável em pegar valores do contexto.
        /// </summary>
        protected virtual void SetObjectControl()
        {
            try
            {
                if (Name == string.Empty) return;
                ObjectControl = GetSForm()?.CurrentControl;
                if (ObjectControl == null) return;
                PropertyControl = GetSForm().InvokeMethod.TypeModel.GetProperty(Name);
                ValueControl = GetPropertyText();
            }
            catch
            {
                // ignored
            }
        }
        /// <summary>
        /// Pega o form ativo.
        /// </summary>
        /// <returns></returns>
        protected FBase GetSForm()
        {
            return FindForm() as FBase;
        }
        private void SetValueProperty(object obj)
        {
            try
            {
                if (PropertyControl == null) return;
                if (GetSForm()?.CurrentControl == null) return;
                if (obj == null)
                    obj = new SReflection().ConvertProperty(PropertyControl);
                PropertyControl.SetValue(GetSForm().CurrentControl, obj);
                ShootError(IsValid());
            }
            catch (Exception)
            {
                // Ignote
            }
        }
        private object GetPropertyText()
        {
            if (GetSForm()?.CurrentControl != null && PropertyControl != null)
                return PropertyControl?.GetValue(GetSForm()?.CurrentControl);
            if (GetSForm() == null)
            {
                RemoveErrorProvider();
                return null;
            }
            RemoveErrorProvider();
            return new SReflection().ConvertProperty(PropertyControl);
        }
        #endregion

        #region Tratamento de atributos

        public Dictionary<string, bool> Validations { get; set; }

        private Dictionary<string, bool> IsValid()
        {
            if (!(FindForm() is FBase)) return new Dictionary<string, bool>();
            if (!(GetSForm().StateForm == StateForm.Inserting || GetSForm().StateForm == StateForm.Editing)) return new Dictionary<string, bool>();
            try
            {
                if (Name == string.Empty) return new Dictionary<string, bool>();
                Validations = new Dictionary<string, bool>();

                if (GetSForm() == null)
                {
                    RemoveErrorProvider();
                    return new Dictionary<string, bool>();
                }
                if (PropertyControl == null) return new Dictionary<string, bool>();
                var validationAttributes = GetAttribute();
                var reflection = new SReflection();
                foreach (var attribute in validationAttributes)
                {
                    try
                    {
                        var validationAttribute = attribute as ValidationAttribute;
                        if (validationAttribute == null) continue;
                        bool isValid;

                        var operatorValue = GetAttribute<OperationValue>(PropertyControl);
                        if (operatorValue != null)
                        {
                            decimal result = 0;
                            var component1 =
                                GetSForm()
                                    .GetListControls()
                                    .FirstOrDefault(c => c.Name == operatorValue.PropertyOperationName);
                            var componentTotal =
                                GetSForm()
                                    .GetListControls()
                                    .FirstOrDefault(c => c.Name == operatorValue.PropertyResultName);
                            if (component1 != null)
                            {
                                if (componentTotal != null)
                                {
                                    switch (operatorValue.TypeOperation)
                                    {
                                        case TypeOperation.Division:
                                            if ((decimal)ValueControl != 0)
                                                result = (decimal)component1.ValueControl / (decimal)ValueControl;
                                            break;
                                        case TypeOperation.Multiplication:
                                            result = (decimal)ValueControl * (decimal)component1.ValueControl;
                                            break;
                                        case TypeOperation.Sum:
                                            result = (decimal)ValueControl + (decimal)component1.ValueControl;
                                            break;
                                        case TypeOperation.Subtraction:
                                            result = (decimal)component1.ValueControl - (decimal)ValueControl;
                                            break;
                                        case TypeOperation.SubtractionInversion:
                                            result = (decimal)ValueControl - (decimal)component1.ValueControl;
                                            break;
                                        case TypeOperation.SubtractionPorcent:
                                            result = (decimal)component1.ValueControl - (((decimal)component1.ValueControl / 100) * (decimal)ValueControl);
                                            break;
                                        case TypeOperation.AditionalPorcent:
                                            result = (decimal)component1.ValueControl + (((decimal)component1.ValueControl / 100) * (decimal)ValueControl);
                                            break;
                                        case TypeOperation.PorcentValue:
                                            result = (((decimal)component1.ValueControl / 100) * (decimal)ValueControl);
                                            break;
                                        default:
                                            result = 0;
                                            break;
                                    }
                                }
                            }
                            componentTotal.Disable = false;
                            componentTotal.ValueControl = result;
                        }

                        if (validationAttribute is LockedTrueValue)
                        {
                            var lockedTrueValue = validationAttribute as LockedTrueValue;
                            var valid = false;
                            if (lockedTrueValue.UniqueValue)
                                valid = lockedTrueValue.Value[0].ToString() != ValueControl.ToString();
                            for (var i = 0; i < lockedTrueValue.PropertyName.Count(); i++)
                            {
                                if (!lockedTrueValue.UniqueValue)
                                    valid = lockedTrueValue.Value[i]?.ToString() != PropertyControl?.GetValue(GetSForm()?.CurrentControl)?.ToString();

                                var component = GetSForm().GetListControls().FirstOrDefault(c => c.Name == lockedTrueValue.PropertyName[i]);
                                component.Disable = valid;
                                if (!valid)
                                    component.Clear();
                            }
                        }

                        if (validationAttribute is CompareAttribute)
                        {
                            var otherName = validationAttribute.GetType().GetProperty("OtherProperty").GetValue(validationAttribute).ToString();
                            var otherProperty = CurrentControl.GetType().GetProperty(otherName);
                            var otherValue = otherProperty.GetValue(CurrentControl);
                            isValid = otherValue?.ToString() == ValueControl.ToString();
                        }
                        else
                        {
                            if (this is SComboBox)
                                isValid = !ValueControl.ToString().Equals("0");
                            else
                                isValid = validationAttribute.IsValid(ValueControl);
                        }
                        var key = validationAttribute.FormatErrorMessage(DisplayName(PropertyControl));
                        if (!isValid && !Validations.ContainsKey(key)) Validations.Add(key, false);

                        var compoundIndex = GetSForm().GetAttribute<CompoundIndex>();
                        var unique = attribute as Unique;

                        if ((compoundIndex != null && compoundIndex.Properties.Contains(Name)) || unique != null)
                        {
                            var typeValue = ValueControl as string;
                            if (!(typeValue != null && ReferenceEquals(ValueControl, string.Empty)))
                            {
                                // Pego o tipo do contexto.
                                var typeDataSource = GetSForm().InvokeMethod.TypeModel;

                                // Para garantia de Lista anonima (generica), pesquisa pela propriedade Id, 
                                // chave primária do objeto.
                                var property = PropertyControl;

                                // Pego o valor da propriedade do objeto atual.
                                var value = ValueControl;

                                // se o tipo do objeto já foi informado para mesmo contexto, não é passado mais.
                                var parameterType = Expression.Parameter(typeDataSource);

                                // passa o tipo da propriedade
                                var prop = Expression.Property(parameterType, property);
                                // converte o tipo do dado, para garantir a identidade do mesmo.
                                var convertedValue = reflection.ChangeType(value, property.PropertyType);
                                // cria expressao do valor que será passada na expressão.
                                var soap = Expression.Constant(convertedValue);
                                // relaciona a propriedade com o dado. Exemplo: param0 => param0 == 1
                                var equal = Expression.Equal(prop, soap);

                                Expression expressionCompound = null;
                                // Se acaso for index composto adiciona mais uma expressão
                                if (compoundIndex != null && compoundIndex.Properties.Contains(Name))
                                {
                                    // Pesquiso  as outras propriedades que fazem parte da composição.
                                    var properties = compoundIndex.Properties.Where(c => c != Name);

                                    expressionCompound = (from index in properties select typeDataSource.GetProperty(index) into propertyCompoundId let propCompoundId = Expression.Property(parameterType, propertyCompoundId) let convertedValueCompoundId = reflection.ChangeType(propertyCompoundId.GetValue(GetSForm().CurrentControl), propertyCompoundId.PropertyType) let soapCompoundId = Expression.Constant(convertedValueCompoundId) select Expression.Equal(propCompoundId, soapCompoundId)).Aggregate(expressionCompound, (current, equalCompoundId) => current == null ? equalCompoundId : Expression.And(equalCompoundId, current));
                                }

                                if (expressionCompound != null)
                                    equal = Expression.And(equal, expressionCompound);

                                var propertyId = typeDataSource.GetProperty("Id");
                                // passa o tipo da propriedade
                                var propId = Expression.Property(parameterType, propertyId);
                                // converte o tipo do dado, para garantir a identidade do mesmo.
                                var convertedValueId = Convert.ChangeType(propertyId.GetValue(GetSForm().CurrentControl), propertyId.PropertyType);
                                // cria expressao do valor que será passada na expressão.
                                var soapId = Expression.Constant(convertedValueId);
                                // relaciona a propriedade com o dado. Exemplo: param0 => param0 == 1
                                var equalId = Expression.NotEqual(propId, soapId);

                                var yourExpression = Expression.And(equal, equalId);

                                var delegateType = typeof(Func<,>).MakeGenericType(typeDataSource, typeof(bool));
                                var expression = Expression.Lambda(delegateType, yourExpression, true, parameterType);
                                var objetoApp = GetSForm().InvokeMethod;
                                var method = objetoApp.Methods.FirstOrDefault(c => c.Key == TypeExecute.Search).Value;
                                if (string.IsNullOrEmpty(method))
                                    MessageBox.Show("Método Search não configurado\nController: " + objetoApp.TypeController.Name,
                                                     "ESR Softwares", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                var result = reflection.GetListContext(objetoApp.TypeController, method, expression);

                                var components = GetSForm().GetListControls().Where(c =>
                                {
                                    if (compoundIndex == null) return false;
                                    foreach (var s in compoundIndex.Properties)
                                    {
                                        if (Equals(s, c.Name))
                                        {
                                            break;
                                        }
                                    }
                                    return false;
                                });

                                if (result.Any())
                                {
                                    if (compoundIndex != null && compoundIndex.Properties.Contains(Name))
                                    {
                                        var enumerable = components as IList<IComponent> ?? components.ToList();
                                        var componentValues = enumerable.Aggregate("", (current, component) => current + component.Caption + " = " + component.ValueControl + " ");
                                        foreach (var component in enumerable)
                                        {
                                            component.SetError("Já existem dados com " + componentValues);
                                            component.ComponentBackColor = Color.FromArgb(255, 255, 173, 178);
                                        }
                                        Validations.Add("Já existem dados com " + (componentValues == "" ? " este registro" : componentValues), false);
                                    }
                                    else
                                    {
                                        Validations.Add("Este " + GetTextLabel() + " já existe, considere em informar outro", false);
                                    }
                                }
                                else
                                {
                                    foreach (var component in components)
                                    {
                                        if (!component.Validations.Values.Contains(false))
                                            component.RemoveErrorProvider();
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                    SComponent.BackColor = Validations.Values.Contains(false) ? Color.FromArgb(255, 255, 173, 178) : Color.White;
                }
                return Validations;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        protected virtual string DisplayName(PropertyInfo propertyInfo)
        {
            if (propertyInfo == null) return string.Empty;

            var conn = new RepositoryInjection().GetClass<IFactoryConnection>();
            var translate = new TranslateApp(conn);

            var displayName = string.Empty;
            try
            {
                var t = GlobalUser.Translates.FirstOrDefault(c => c.PropertyName == Name);

                if (t == null)
                {
                    translate.InsertOrUpdate(new Translate()
                    {
                        PropertyName = Name,
                        Portugues = GetAttribute<DisplayNameAttribute>(propertyInfo).DisplayName,
                        CompanyControlId = GlobalUser.Company.Id,
                        UserControlId = GlobalUser.User.Id
                    });
                    conn.Save();
                }
                else
                {
                    var newDisplayName = GetAttribute<DisplayNameAttribute>(propertyInfo).DisplayName;

                    if (newDisplayName != t.Portugues)
                    {
                        t.Portugues = newDisplayName;
                        translate.InsertOrUpdate(t);
                        conn.Save();
                    }

                    displayName = t.Portugues;
                }
            }
            catch (Exception)
            {
                // ignored
            }

            var display = !string.IsNullOrEmpty(Caption) ? Caption : !string.IsNullOrEmpty(displayName) ? displayName : GetAttribute<DisplayNameAttribute>(propertyInfo)?.DisplayName;

            return display;
        }

        private void ShootError(Dictionary<string, bool> validations)
        {
            if (validations.Count == 0)
            {
                RemoveErrorProvider();
                return;
            }
            var message = new StringBuilder();
            foreach (var validation in validations)
                message.AppendLine(validation.Key);
            SetError(message.ToString());
        }

        public void SetError(string message, int padding = 0)
        {
            _errorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            _errorProvider.SetError(SComponent, message);
            _errorProvider.SetIconAlignment(SComponent, ErrorIconAlignment.MiddleRight);
            _errorProvider.SetIconPadding(SComponent, padding == 0 ? -20 : padding);
        }

        protected TAttribute GetAttribute<TAttribute>(PropertyInfo propertyInfo) where TAttribute : Attribute
        {
            var resultAttributes = propertyInfo?.GetCustomAttributes(typeof(TAttribute), true);
            return resultAttributes?.OfType<TAttribute>().FirstOrDefault(itemAttributes => true);
        }

        private IEnumerable<Attribute> GetAttribute()
        {
            return PropertyControl?.GetCustomAttributes();
        }

        #endregion

        #region Label Caption

        /// <summary>
        /// Adiciona Label no panel superior do objeto.
        /// </summary>
        private void AddLabel()
        {
            Label.Font = Font;
            FlowLayoutPanel.Controls.Add(Label);
            try
            {
                SetTextLabel(DisplayName(PropertyControl));
                //LocationLabel();
            }
            catch (Exception)
            {
                SetTextLabel(Caption);
            }
        }

        /// <summary>
        /// Seta texto no componente label do objeto.
        /// </summary>
        /// <param name="text">Campo texto que será apresentado na label do objeto.</param>
        protected virtual void SetTextLabel(string text)
        {
            Label.Text = text;
        }

        /// <summary>
        /// Retorna texto contido na label do objeto.
        /// </summary>
        /// <returns></returns>
        private string GetTextLabel()
        {
            return Label.Text;
        }

        #endregion
    }

    /// <summary>
    /// Enum para alinhamento da Label.
    /// </summary>
    public enum CaptionAlign
    {
        Top,
        Left,
        Right,
        Buttom
    }
}