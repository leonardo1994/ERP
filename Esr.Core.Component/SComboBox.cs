using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Windows.Controls.Ribbon;
using System.Windows.Forms;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;

namespace Esr.Core.Component
{
    public class SComboBox : SControl<ComboBox>
    {
        private readonly SReflection _sReflection = new SReflection();

        public bool DefaultValue { get; set; }

        public object StandardValue { get; set; }

        private RibbonTab RibbonTab { get; set; }

        public string ValueMember { get { return SComponent.ValueMember; } set { SComponent.ValueMember = value; } }

        public string DisplayMember { get { return SComponent.DisplayMember; } set { SComponent.DisplayMember = value; } }

        public SComboBox ComboBoxMultiForms { get; set; }

        /// <summary>
        /// Propriedade de pesquisa, caso o usuário digite texto no combo será feito uma pesquisa.
        /// Necessário que coluna esteja disponível na select.
        /// </summary>
        public string PropertySearch { get; set; }

        private object _lastValue { get; set; }

        public SComboBox()
        {
            SComponent.DropDownClosed += SComponentOnDropDownClosed;
            //SComponent.DropDown += SComponentOnDropDown;
            SComponent.GotFocus += SComponentOnGotFocus;
            SComponent.LostFocus += SComponentOnLostFocus;
            SComponent.KeyDown += SComponentOnKeyDown;
            SComponent.AutoCompleteMode = AutoCompleteMode.Suggest;
            SComponent.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void SComponent_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox)?.SelectedIndex >= 0)
            {
                ValueControl = SComponent.SelectedValue;

                var appendValue = GetAttribute<AppendValue>(PropertyControl);
                if (appendValue == null) return;
                for (var i = 0; i < appendValue.PropertiesGetValue.Count(); i++)
                {
                    var property =
                        _sReflection
                            .GetProperties(SComponent.SelectedItem)?.FirstOrDefault(c => c.Name == appendValue.PropertiesGetValue[i]);
                    var value = property?.GetValue(SComponent.SelectedItem);
                    var component = GetSForm().GetListControls().FirstOrDefault(c => c.Name == appendValue.PropertiesSetValue[i]);
                    if (component == null) continue;
                    component.ValueControl = value;
                }
            }
        }

        private void SComponentOnKeyDown(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.KeyCode == Keys.Down)
                SComponent.DroppedDown = true;
        }

        private void SComponentOnDropDownClosed(object sender, EventArgs eventArgs)
        {
            ValueControl = SComponent.SelectedValue;
            var appendValue = GetAttribute<AppendValue>(PropertyControl);
            if (appendValue == null) return;
            for (var i = 0; i < appendValue.PropertiesGetValue.Count(); i++)
            {
                var property =
                    _sReflection
                        .GetProperties(SComponent.SelectedItem)?.FirstOrDefault(c => c.Name == appendValue.PropertiesGetValue[i]);
                var value = property?.GetValue(SComponent.SelectedItem);
                var component = GetSForm().GetListControls().FirstOrDefault(c => c.Name == appendValue.PropertiesSetValue[i]);
                if (component == null) continue;
                component.ValueControl = value;
            }
        }

        private void SComponentOnDropDown(object sender, EventArgs eventArgs)
        {
            if (ObjetoApp == null) return;
            var value = SComponent.SelectedValue;
            SetList();
            if (SComponent.Items.Count <= 0) return;
            if (value == null)
                SComponent.SelectedIndex = 0;
            else
                SComponent.SelectedValue = value;
        }

        private void SComponentOnLostFocus(object sender, EventArgs eventArgs)
        {
            if (RibbonTab != null)
                GetSForm().RemoveAba(RibbonTab);

            if (!string.IsNullOrEmpty(PropertySearch))
            {
                var property = ObjetoApp.TypeModel.GetProperty(PropertySearch);
                if (property != null && !string.IsNullOrEmpty(SComponent.Text))
                {
                    var dataSource = SComponent.DataSource as IList;
                    var item = dataSource.Where(PropertySearch + " = @0", SComponent.Text).Select("Id");
                    if (!item.Any())
                    {
                        var rt = MessageBox.Show("Item não existe na lista, deseja cadastrar novo ?", "ESR Softwares", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(rt == DialogResult.Yes)
                        {
                            if (Form == null && FormType != null)
                                Form = new SReflection().CreateNewInstance<FForm>(FormType);
                            Form.StateForm = StateForm.Inserting;
                            if (Form.CurrentControl == null)
                                Form.bindingSource.AddNew();
                            var property1 = Form.CurrentControl.GetType().GetProperty(PropertySearch);
                            property1.SetValue(Form.CurrentControl, SComponent.Text);
                            Form.ShowDialog();
                        }
                        else
                        {
                            SComponent.SelectedIndex = -1;
                            SComponent.Text = "";
                            ValueControl = null;
                        }
                    }
                    foreach (var item1 in item)
                    {
                        SComponent.SelectedValue = item1;
                    }
                }
            }
        }

        private void SComponentOnGotFocus(object sender, EventArgs eventArgs)
        {
            try
            {
                if (Form == null && FormType != null)
                    Form = new SReflection().CreateNewInstance<FForm>(FormType);
                if (FormType != null)
                    RibbonTab = GetSForm().AddTab(Form, this);
                var value = SComponent.SelectedIndex;
                SComponent.SelectedIndex = value;
            }
            catch (Exception)
            {
                // Ignore
            }
        }

        public override object ValueControl
        {
            set
            {
                if (_lastValue == null || !_lastValue.Equals(value) && value != null)
                {
                    base.ValueControl = value;
                    if (value == null) return;
                    SComponent.SelectedValue = value;
                    UpdateChilds();
                    _lastValue = value;
                }
            }
            get
            {
                return base.ValueControl ??
                    SComponent.SelectedValue;
            }
        }

        public override void Clear()
        {
            ValueControl = new SReflection().ConvertProperty(PropertyControl);
            SComponent.SelectedIndex = -1;
            SComponent.BackColor = Color.White;
            base.Clear();
        }

        public override void Refresh()
        {
            base.Refresh();
            if (GetSForm()?.StateForm == StateForm.Waiting)
            {
                return;
            }
            if (SComponent.DisplayMember != string.Empty && SComponent.ValueMember != string.Empty)
                SetList();
            base.Refresh();
            if (GetSForm()?.CurrentControl?.Id == 0)
            {
                if (SComponent.Items.Count <= 0) return;
                if (GetAttribute<RequiredAttribute>(PropertyControl) != null)
                {
                    SComponent.SelectedIndex = 0;
                    ValueControl = SComponent.SelectedValue;
                }
                else
                {
                    SComponent.SelectedIndex = -1;
                }
                if (SComponent.SelectedValue == null)
                {
                    if (DefaultValue)
                        ValueControl = StandardValue;
                    return;
                }
                if (GetSForm().StateForm == StateForm.Inserting)
                {
                    if (DefaultValue)
                        ValueControl = StandardValue;
                    return;
                }
                ValueControl = SComponent.SelectedValue;
            }
            else
            {

                if (SComponent.Items.Count > 0)
                    if (ValueControl == null)
                    {
                        SComponent.SelectedIndex = -1;
                    }
                    else
                    {
                        SComponent.SelectedValue = ValueControl;
                    }
            }

            if (DefaultValue)
                ValueControl = StandardValue;
        }

        /// <summary>
        /// Atualiza todos os objetos filhos do elemento.
        /// </summary>
        public void UpdateChilds()
        {
            if (ValueControl == null) return;

            // Pego todos os filhos do elemento.
            var getChilds = GetSForm()?.GetListControls()?.Where(c => GetAttribute<DependencyKey>(c.PropertyControl)?.NamePropertyDependent == Name);

            //Atualizo os filhos.
            if (getChilds != null && getChilds.Any())
                foreach (var item in getChilds)
                {
                    var child = item as SComboBox;
                    if (child == null) continue;
                    var childApp = child.ObjetoApp;

                    var reflection = new SReflection();

                    // Crio uma expressão, para pesquisar na tabela de relacionamento, com Id da tabela principal.
                    var typeDataSource = childApp.TypeModel;
                    var property = typeDataSource.GetProperty(Name);

                    if(property == null)
                    {
                        
                        MessageBox.Show("Não será possível carregar os componentes filhos [" + (GlobalUser.Translates.FirstOrDefault(c => c.PropertyName == child.Name)?.Portugues ?? child.Name) + "].\nCausa: Propriedade " + Name + " não encontrada para o Modelo: " + childApp.TypeModel.Name + " definido no componente: " + child.Name,
                            "ESR SOFTWARES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var itemt = Expression.Parameter(typeDataSource);

                    var soap = Expression.Constant(ValueControl);
                    var prop = Expression.Property(itemt, property);
                    Expression equal = property.PropertyType == typeof(int?) ? Expression.Equal(prop, Expression.Convert(soap, typeof(int?))) : Expression.Equal(prop, soap);

                    var delegateType = typeof(Func<,>).MakeGenericType(typeDataSource, typeof(bool));

                    var yourExpression = Expression.Lambda(delegateType, equal, true, itemt);

                    var method = childApp.Methods.FirstOrDefault(c => c.Key == TypeExecute.Search).Value;
                    if (string.IsNullOrEmpty(method))
                    {
                        MessageBox.Show("Método Search não configurado para controller: " + childApp.TypeController.Name + " Componente: " + child.Name);
                        return;
                    }

                    var childList = _sReflection.GetListContext(childApp.TypeController, method, yourExpression);

                    if (!childList.Any())
                        childList.Clear();
                    child.SetList(childList);
                    child.Refresh();
                }
        }

        #region Tratamento DataSource
        /// <summary>
        /// Método para passar um enum para DataSource.
        /// </summary>
        /// <param name="value"></param>
        public void SetEnumItems<T>(Enum value)
        {
            var enuns = EnumHelper<T>.GetListObject(value);
            SComponent.DisplayMember = "Description";
            SComponent.ValueMember = "Id";
            SComponent.DataSource = enuns;
            if (base.ValueControl != null)
                SComponent.SelectedValue = base.ValueControl;

            SComponent.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void SetEnumItems(Type value)
        {
            var enuns = (from object item in value.GetEnumValues()
                         select new
                         {
                             Id = item,
                             Description = item.ToString().Replace("_", " ")
                         }).

        Cast<object>().ToList();
            SComponent.DisplayMember = "Description";
            SComponent.ValueMember = "Id";
            SComponent.DataSource = enuns;
            if (base.ValueControl != null)
                SComponent.SelectedValue = base.ValueControl;

            SComponent.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void SetList()
        {
            SComponent.SelectedValueChanged -= SComponent_SelectedValueChanged;

            if (ObjetoApp != null && GetAttribute<DependencyKey>(PropertyControl) == null)
            {
                var method = ObjetoApp.Methods.FirstOrDefault(c => c.Key == TypeExecute.SearchAll).Value;
                if (string.IsNullOrEmpty(method))
                {
                    MessageBox.Show("Método SearchAll não definido para Controller: " + ObjetoApp.TypeController.Name + " Componente: " + Name);
                    return;
                }
                var query = _sReflection.GetListContext(ObjetoApp.TypeController, method);
                SComponent.DataSource = query;

                if (query != null && query.Count > 0)
                {
                    SComponent.SelectedValueChanged += SComponent_SelectedValueChanged;
                }
                else
                {
                    SComponent.SelectedValueChanged -= SComponent_SelectedValueChanged;
                }
            }

            /*
            var dependencyKey = GetAttribute<DependencyKey>(PropertyControl);
            if (ObjetoApp != null && PropertyControl != null && dependencyKey != null)
            {
                if (CurrentControl == null) return;
                var reflection = new SReflection();

                var componentDependecy = ((SComboBox)GetSForm().GetListControls().First(c => c.Name == dependencyKey.NamePropertyDependent));

                var value = componentDependecy.SComponent.SelectedValue;

                componentDependecy.Refresh();

                if(value != null)
                {
                    componentDependecy.ValueControl = value;
                    componentDependecy.SComponent.SelectedValue = value;
                    componentDependecy.SComponent.SelectedItem = value;
                }

                // Crio uma expressão, para pesquisar na tabela de relacionamento, com Id da tabela principal.
                var typeDataSource = reflection.GetTypeProperty(CurrentControl.GetType().GetProperty(Name.Replace("Id", "")));
                PropertyInfo propriedade = null;
                propriedade = typeDataSource.GetProperty(!string.IsNullOrEmpty(dependencyKey.NameProperySearch) ? dependencyKey.NameProperySearch : dependencyKey.NamePropertyDependent);

                // Caso a propriedade não seja encontrada, eu busco o tipo pelo App passado. 
                if (propriedade == null)
                {
                    typeDataSource = _sReflection.GetTypeObjectCollection(_sReflection.GetListContext(ObjetoApp.TypeClass, "SearchAll").Where("1=0"));
                    propriedade = typeDataSource.GetProperty(dependencyKey.NamePropertyDependent);
                }

                var item = Expression.Parameter(typeDataSource);

                if (value == null) return;
                var soap = Expression.Constant(value);
                var prop = Expression.Property(item, propriedade);
                Expression equal = propriedade.PropertyType == typeof(int?) ? Expression.Equal(prop, Expression.Convert(soap, typeof(int?))) : Expression.Equal(prop, soap);

                var delegateType = typeof(Func<,>).MakeGenericType(typeDataSource, typeof(bool));

                var yourExpression = Expression.Lambda(delegateType, equal, true, item);

                if (string.IsNullOrEmpty(ObjetoApp.NameMethod))
                    SComponent.DataSource =
                        (IQueryable)_sReflection.GetListContext(ObjetoApp.TypeClass, "Search", yourExpression);
                else
                    SComponent.DataSource =
                    (IQueryable)_sReflection.GetListContext(ObjetoApp.TypeClass, ObjetoApp.NameMethod, yourExpression);
            }
            */
        }
        public void SetList(IList list)
        {
            SComponent.DataSource = list;
        }
        #endregion
    }

    public class CustomComboBox : ComboBox
    {
        public override bool PreProcessMessage(ref Message msg)
        {
            int WM_SYSKEYDOWN = 0x100;

            bool handled = false;

            if (msg.Msg == WM_SYSKEYDOWN)
            {
                Keys keyCode = (Keys)msg.WParam & Keys.KeyCode;

                switch (keyCode)
                {
                    case Keys.Down:
                        handled = true;
                        break;
                }
            }

            if (false == handled)
                handled = base.PreProcessMessage(ref msg);

            return handled;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x201:
                case 0x203:
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }
    }
}