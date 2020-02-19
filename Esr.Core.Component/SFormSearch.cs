using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls.Ribbon;
using System.Windows.Forms;
using Esr.Core.App.Queries;
using Esr.Core.App.Translation;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.Queries;
using Point = System.Drawing.Point;
using System.Collections;
using Esr.Core.Domain.Translation;
using Esr.Core.Domain.Authentication;

namespace Esr.Core.Component
{
    public partial class SFormSearch : Form
    {
        private SReflection Reflection { get; set; } = new SReflection();

        public string Query { get; set; }

        public int QtdPesquisada { get; set; }

        /// <summary>
        /// Lista de relatórios que serão exibidos.
        /// </summary>
        public List<SReports> SReportses { get; set; }

        public BindingSource BindingSource { get; set; } = new BindingSource();

        public object ObjectControl
        {
            get { return BindingSource.DataSource; }
            set
            {
                BindingSource.DataSource = value;
            }
        }

        public SInvokeMethod ObjetoApp { get; set; }

        public IEntityBase CurrentControl => BindingSource.Current as IEntityBase;

        public SReflection SReflection { get; set; } = new SReflection();

        public SFormSearch(FForm form)
        {
            InitializeComponent();
            GridResult.Label.Visible = false;
            GridResult.SMenuComponent.Dock = DockStyle.None;
            GridResult.SMenuComponent.Visible = false;
            GridResult.STextBox.Dock = DockStyle.Top;
            GridResult.STextBox.Width = GridResult.Width;
            GridResult.ScreenSecondary = false;
            GridResult.IsDependecyUkey = false;

            ComboBox.Caption = "Lista de Pesquisa";
            ComboBox.DisplayMember = "Display";
            ComboBox.ValueMember = "QueryId";
            //ComboBox.ObjetoApp = new SInvokeMethod(typeof(ReportApp), "SearchAll");
            ComboBox.SComponent.DataSource = SReflection.GetListContext(typeof(ReportApp), "SearchAllReport", form.Name) as IList;
            ComboBox.Refresh();
            ComboBox.SComponent.DropDownClosed += SComponentOnDropDownClosed;

            SReportses = form.SReportses;

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
                item.Click += RibbonButtonOnClick;
                //if (sMenuSearch1.RibbonMenuButtonReports.Items.Cast<object>().All(item1 => ((RibbonButton)item1).Name != item.Name))
                //{
                //    sMenuSearch1.RibbonMenuButtonReports.Items.Add(item);
                //}

            }
        }

        private void SComponentOnDropDownClosed(object sender, EventArgs eventArgs)
        {
            if (ComboBox.SComponent.SelectedValue != null)
                InicializarComponetesPesquisa((int)ComboBox.SComponent.SelectedValue);
        }

        private void SFormSearch_Load(object sender, EventArgs e)
        {
            sMenuSearch1.Tag = this;
            GridResult.SComponent.DoubleClick += SComponentOnDoubleClick;
            GridResult.Refresh();
            //InicializarComponetesPesquisa();
        }

        private void SComponentOnDoubleClick(object sender, EventArgs eventArgs)
        {
            Hide();
        }

        #region Controlador dos objetos de pesquisa.
        private void InicializarComponetesPesquisa(int queryId)
        {
            var query = new QueryApp().FindId(queryId);
            if (query == null) return;
            Query = query.Sql;
            var filters = query.Filters;
            panel1.Controls.Clear();
            var localionY = 10;
            foreach (var item in filters)
            {
                var typeItem = item.TypeComponent;
                var display = GlobalUser.Translates.FirstOrDefault(c => c.PropertyName == item.Display)?.Portugues ?? item.Display;

                IComponent componete;
                switch (typeItem)
                {
                    case TypeFilterComponent.ComboBox:
                        var cb = new SComboBox();
                        cb.SetEnumItems(Type.GetType(item.NameColumn));
                        componete = cb;
                        break;
                    case TypeFilterComponent.Numeric:
                        componete = new SNumeric();
                        break;
                    case TypeFilterComponent.TextBox:
                        componete = new STextBox();
                        break;
                    case TypeFilterComponent.Date:
                        componete = new SDateTimePicker
                        {
                            Format = DateTimePickerFormat.Custom,
                            CustomFormat = "dd/MM/yyyy"
                        };
                        break;
                    case TypeFilterComponent.Time:
                        componete = new SDateTimePicker
                        {
                            Format = DateTimePickerFormat.Custom,
                            CustomFormat = "hh:mm:ss"
                        };
                        break;
                    case TypeFilterComponent.DateTime:
                        componete = new SDateTimePicker
                        {
                            Format = DateTimePickerFormat.Custom,
                            CustomFormat = "dd/MM/yyyy hh:mm:ss"
                        };
                        break;
                    case TypeFilterComponent.CheckBox:
                        componete = new SCheckBox();
                        break;
                    default:
                        continue;
                }
                componete.Caption = display;
                componete.Location = new Point(10, localionY);
                //componete. = item.NameTable;
                componete.Name = item.NameColumn;
                componete.ToolTipContext = item.Code;
                componete.Others = item.NameTable;
                componete.Visible = true;
                componete.Width = 200;
                componete.Height = 52;

                var comboBox = new SComboBox()
                {
                    Caption = "Selecione o Filtro",
                    Location = new Point(200 + 20, localionY),
                    Name = "F" + item.NameColumn,
                    SComponent = { Name = "F" + item.NameColumn },
                    Visible = true,
                    Width = 200,
                    Height = 52
                };

                comboBox.SetEnumItems<TypeFilter>(item.DefaultTypeFilter);
                var removeFilters = comboBox.SComponent.DataSource as IList<SEnum<TypeFilter>>;
                var newFilters = new List<SEnum<TypeFilter>>();

                foreach (var filter in removeFilters)
                {
                    if (!item.InactiveFilters.Any(c => c.TypeFilter == filter.Id))
                        newFilters.Add(filter);
                }

                comboBox.SComponent.DataSource = newFilters;

                comboBox.SComponent.SelectedValue = item.DefaultTypeFilter;

                comboBox.SComponent.Tag = item.TypeComponent;

                comboBox.SComponent.SelectedIndexChanged += SComponentOnSelectedIndexChanged;
                Control[] controls =
                {
                    (Control) componete,
                    comboBox
                };
                panel1.Controls.AddRange(controls);
                localionY = localionY + 55;
                if (typeItem != TypeFilterComponent.CheckBox) continue;
                ((SCheckBox)componete).SComponent.Parent.Dock = DockStyle.Bottom;
                ((SCheckBox)componete).SComponent.Parent.AutoSize = false;
                ((SCheckBox)componete).SComponent.Parent.Height = 30;
            }
        }

        private void RibbonButtonOnClick(object sender, RoutedEventArgs routedEventArgs)
        {
            var item = sender as RibbonButton;
            if (item == null) return;

            var lista = GridResult.SComponent.DataSource;

            var dataSources = item.Tag as Dictionary<string, SInvokeMethod>;
            var data = new Dictionary<string, object>();

            if (dataSources != null)
                foreach (var dataSource in dataSources)
                {
                    var invokeMethod = dataSource.Value;
                    if (invokeMethod == null) return;

                    var returnMethod = SReflection.GetListContext(invokeMethod.TypeClass, invokeMethod.NameMethod, lista);
                    data.Add(dataSource.Key, lista);
                }

            new FormVisualisador(
                item.ToolTip.ToString(),
                data).Show();
        }

        private void SComponentOnSelectedIndexChanged(object sender, EventArgs eventArgs)
        {

            var combobox = (ComboBox)sender;
            if (combobox == null) return;
            var filtro = ((SEnum<TypeFilter>)combobox.SelectedItem).Id;
            var name = combobox.Name.Substring(1);

            if (filtro != TypeFilter.Between)
            {
                panel1.Controls.RemoveByKey(combobox.Name + "And");
                return;
            }

            Control componete = null;

            var typeComponent = (TypeFilterComponent)combobox.Tag;

            switch (typeComponent)
            {
                case TypeFilterComponent.ComboBox:
                    var cb = new SComboBox();
                    cb.SetList(combobox.DataSource as IList);
                    componete = cb;
                    break;
                case TypeFilterComponent.Numeric:
                    componete = new SNumeric();
                    break;
                case TypeFilterComponent.TextBox:
                    componete = new STextBox();
                    break;
                case TypeFilterComponent.Date:
                    componete = new SDateTimePicker()
                    {
                        SComponent = {Format = DateTimePickerFormat.Short,
                        ShowCheckBox = true}
                    };
                    break;
                case TypeFilterComponent.CheckBox:
                    componete = new SCheckBox();
                    break;
                case TypeFilterComponent.DateTime:
                    {
                        componete = new SDateTimePicker()
                        {
                            SComponent = {Format = DateTimePickerFormat.Short,
                        ShowCheckBox = true}
                        };
                    }
                    break;
            }

            if (componete == null) return;
            componete.Location = new Point((combobox.Parent.Parent.Location.X + combobox.Parent.Parent.Width + 10), combobox.Parent.Parent.Location.Y);
            componete.Name = combobox.Name + "And";
            componete.Visible = true;
            componete.Width = 200;
            componete.Height = 52;
            panel1.Controls.Add(componete);
        }
        #endregion
    }
}