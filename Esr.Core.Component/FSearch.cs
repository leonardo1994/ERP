using Esr.Core.App.Queries;
using Esr.Core.Domain.Queries;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;
using Esr.Core.Repository.DependencyInjection;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Collections;
using System.Linq.Dynamic;

namespace Esr.Core.Component
{
    public partial class FSearch : Form
    {
        private readonly ReportApp _reports;
        private readonly ConsultApp _consults;
        private readonly string _form;

        public Report Report { get; set; }
        public Consult Consult { get; set; }

        public readonly TypeSearch TypeSearch;
        public object DataSource { get; set; }
        public object GetSelected { get; set; }
        public string CurrentQuery { get; set; }

        public FSearch(string formName, TypeSearch typeSearch, object sender)
        {
            var conn = new RepositoryInjection().GetClass<IFactoryConnection>();
            _reports = new ReportApp(conn);
            _consults = new ConsultApp(conn);

            _form = formName;
            TypeSearch = typeSearch;

            InitializeComponent();

            MenuSearch.Tag = this;

            // Define o style do grid de pesquisa
            GridFilter.SMenuComponent.Visible = false;
            GridFilter.STextBox.Visible = false;
            GridFilter.SComponent.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            // Define as colunas padrões do grid de pesquisa
            GridFilter.SComponent.Columns.Add("Description", "Descrição");
            GridFilter.SComponent.Columns.Add("Filter", "Filtro");
            GridFilter.SComponent.Columns.Add("Value", "Valor");
            GridFilter.SComponent.Columns.Add("Value2", "");
            GridFilter.SComponent.EditingControlShowing += dataGridView1_EditingControlShowing;
            Tag = sender;

            InicitializeTreeView();

            TreeView.ExpandAll();

            TreeView.AfterSelect += TreeView_AfterSelect;

            TreeView.SelectedNode = TreeView.Nodes[0].FirstNode;

            TreeView.Focus();
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            InitializeFiltersInGrid(sender, e.Node);
        }

        /// <summary>
        /// Monta evento para os itens do grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (GridFilter.SComponent.CurrentCell.ColumnIndex == 1 && e.Control is ComboBox)
            {
                var comboBox = (ComboBox)e.Control;
                comboBox.SelectedIndexChanged += LastColumnComboSelectionChanged;
            }
            else if (GridFilter.SComponent.CurrentCell.ColumnIndex == 2 && e.Control is DateTimePicker)
            {
                var datePicker = (DateTimePicker)e.Control;
                datePicker.ValueChanged += SComponent_ValueChanged;
            }
        }

        private void SComponent_ValueChanged(object sender, EventArgs e)
        {
            if (GridFilter.SComponent.CurrentCell.ColumnIndex != 2) return;
            var currentcell = GridFilter.SComponent.CurrentCellAddress;

            if (
                (TypeFilter)((DataGridViewComboBoxCell)GridFilter.SComponent.Rows[currentcell.Y].Cells[1]).Value !=
                TypeFilter.Between) return;
            var sendingCb = sender as DateTimePicker;
            if (sendingCb == null) return;
            var cell3 = GridFilter.SComponent.Rows[currentcell.Y].Cells[3];
            if (cell3.Value == null)
                cell3.Value = sendingCb.Value;
            else if ((DateTime)cell3.Value < sendingCb.Value)
                GridFilter.SComponent.Rows[currentcell.Y].Cells[3].Value = sendingCb.Value;
        }

        /// <summary>
        /// Evento responsável em tratar os filtros selecionados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LastColumnComboSelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Pega a celula atual selecionada.
                var currentcell = GridFilter.SComponent.CurrentCellAddress;
                var sendingCb = sender as DataGridViewComboBoxEditingControl;

                // Verifica se o filtro selecionado é entre
                if (sendingCb != null && (TypeFilter)sendingCb.SelectedValue == TypeFilter.Between)
                {
                    // Passa para a prox. celula com as mesmas caracteristicas da sucessor.
                    GridFilter.SComponent.Rows[currentcell.Y].Cells[3] = new SReflection().CreateNewInstance(GridFilter.SComponent.Rows[currentcell.Y].Cells[2].GetType()) as DataGridViewCell;
                    var dataGridViewCell = GridFilter.SComponent.Rows[currentcell.Y].Cells[3];
                    if (dataGridViewCell != null)
                        dataGridViewCell.ReadOnly = false;
                    if (GridFilter.SComponent.Rows[currentcell.Y].Cells[3] is CalendarCell)
                    {
                        if (GridFilter.SComponent.Rows[currentcell.Y].Cells[2].Value == null)
                            GridFilter.SComponent.Rows[currentcell.Y].Cells[2].Value = DateTime.Now;
                        GridFilter.SComponent.Rows[currentcell.Y].Cells[3].Value = DateTime.Now;
                    }

                }
                else
                {
                    // Mantem a última celula do grid sempre bloqueada.
                    GridFilter.SComponent.Rows[currentcell.Y].Cells[3] = new DataGridViewTextBoxCell();
                    GridFilter.SComponent.Rows[currentcell.Y].Cells[3].ReadOnly = true;
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Monta o objeto TreeViewer dos relatórios e consultas cadastradas
        /// </summary>
        private void InicitializeTreeView()
        {
            if (TypeSearch == TypeSearch.Report)
            {
                // Pesquisa todos os relatórios
                var list = _reports.Search(c => c.ReportForms.Any(d => d.Table.TableName == _form))
                    .Include(c => c.ReportForms)
                    .Include(c => c.Query.Filters)
                    .ToList();

                // Monta lista de relatórios
                var nodeMaster = new TreeNode("Relatórios", list.Select(item => new STreeNode()
                {
                    Name = item.Code,
                    Text = item.Display,
                    Report = item
                }).ToArray());

                TreeView.Nodes.Add(nodeMaster);
            }
            else
            {
                // Pesquisa todos as consultar
                IList<Consult> list = null;
                try
                {
                    list = _consults.Search(c => c.ConsultForms.Any(d => d.Table.TableName == _form))
                        .Include(c => c.ConsultForms)
                        .Include(c => c.Query.Filters)
                        .ToList();

                    // Monta lista de consultas
                    var nodeMaster = new TreeNode("Consultas", list.Select(item => new STreeNode()
                    {
                        Name = item.Code,
                        Text = item.Display,
                        Consult = item
                    }).ToArray());

                    TreeView.Nodes.Add(nodeMaster);
                }
                catch (Exception)
                {

                }
            }
        }

        /// <summary>
        /// Inicializa os filtros dentro do grid de forma dinamica conforme cadastro realizado.
        /// </summary>
        /// <param name="filters"></param>
        private void InitializeFilters(IList<Filter> filters)
        {
            // Utilizo objeto padrão para apenas usar o recurso de gerar lista apartir de um enum
            var sComboBox = new SComboBox();
            sComboBox.SetEnumItems<TypeFilter>(TypeFilter.InitiatedBy);

            GridFilter.Clear();

            foreach (var item in filters)
            {
                var row = new DataGridViewRow()
                {
                    Tag = item
                };

                var comboBox = new DataGridViewComboBoxCell
                {
                    ValueMember = sComboBox.ValueMember,
                    DisplayMember = sComboBox.DisplayMember,
                    DataSource = sComboBox.SComponent.DataSource
                };

                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells.Add(new DataGridViewTextBoxCell());

                row.Cells[1] = comboBox;
                row.Cells[1].Value = item.DefaultTypeFilter;

                switch (item.TypeComponent)
                {

                    case TypeFilterComponent.TextBox:
                        row.Cells[0].Value = item.Display;
                        row.Cells[0].ReadOnly = true;
                        row.Cells[2] = new DataGridViewTextBoxCell();
                        row.Cells[3] = new DataGridViewTextBoxCell();
                        break;
                    case TypeFilterComponent.ComboBox:
                        break;
                    case TypeFilterComponent.Date:
                        row.Cells[0].Value = item.Display;
                        row.Cells[0].ReadOnly = true;
                        row.Cells[2] = new CalendarCell();
                        row.Cells[3] = new CalendarCell();
                        break;
                    case TypeFilterComponent.Time:
                        break;
                    case TypeFilterComponent.DateTime:
                        break;
                    case TypeFilterComponent.CheckBox:
                        break;
                    case TypeFilterComponent.Numeric:
                        break;
                    default:
                        break;
                }

                row.Cells[3].ReadOnly = item.DefaultTypeFilter != TypeFilter.Between;

                GridFilter.SComponent.Rows.Add(row);
            }

            GridFilter.SComponent.Refresh();
        }

        /// <summary>
        /// Após selecionar um item do TreeViewer carrega os filtros cadastrados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            InitializeFiltersInGrid(sender, e.Node);
        }

        public void InitializeFiltersInGrid(object sender, TreeNode e)
        {
            try
            {
                if (GridFilter.Caption == e.Text || e.Level == 0) return;

                GridFilter.SComponent.Rows.Clear();

                var node = ((STreeNode)e);

                // Colaca o display do grid de acordo com selecionado no TreeViewer
                GridFilter.Caption = node.Text;

                if (TypeSearch == TypeSearch.Consult)
                {
                    // Passa lista dos filtros do relatório/consulta para montar os filtros
                    InitializeFilters(node.Consult.Query.Filters.ToList());

                    // Query atual
                    CurrentQuery = node.Consult.Query.Sql;
                }
                else
                {
                    // Passa lista dos filtros do relatório/consulta para montar os filtros
                    InitializeFilters(node.Report.Query.Filters.ToList());

                    // Query atual
                    CurrentQuery = node.Report.Query.Sql;
                }

                Report = node.Report;

                Consult = node.Consult;
            }
            catch (Exception)
            {

            }
        }

        public void RunSearch()
        {
            var countRows = GridFilter.SComponent.RowCount;

            if (countRows > 0)
                CurrentQuery = ((Filter)GridFilter.SComponent.Rows[0].Tag).Query.Sql;

            for (int i = 0; i < countRows; i++)
            {
                var cell2 = GridFilter.SComponent.Rows[i].Cells[2];
                var cell3 = GridFilter.SComponent.Rows[i].Cells[3];
                var filter = (Filter)GridFilter.SComponent.Rows[i].Tag;
                var value = cell2.Value ?? cell2.EditedFormattedValue;
                var value2 = cell3.Value ?? cell3.EditedFormattedValue;

                var typeFilter = (TypeFilter)GridFilter.SComponent.Rows[i].Cells[1].Value;

                var code = "@" + filter.Code;
                var column = value is DateTime ? "cast([" + filter.NameTable + "].[" + filter.NameColumn + "] as date)" : "[" + filter.NameTable + "].[" + filter.NameColumn + "]";
                value = value is DateTime ? ((DateTime)value).ToFormatAmerican() : value;
                value2 = value2 is DateTime ? ((DateTime)value2).ToFormatAmerican() : value2;

                switch (typeFilter)
                {
                    case TypeFilter.Equal:
                        CurrentQuery = value == null ? CurrentQuery.Replace(code, " 1 = 1 ") : CurrentQuery.Replace(code, column + " = '" + value + "'");
                        break;
                    case TypeFilter.Different:
                        CurrentQuery = value == null ? CurrentQuery.Replace(code, " 1 = 1 ") : CurrentQuery.Replace(code, column + " <> '" + value + "'");
                        break;
                    case TypeFilter.Smaller:
                        CurrentQuery = value == null ? CurrentQuery.Replace(code, " 1 = 1 ") : CurrentQuery.Replace(code, column + " < '" + value + "'");
                        break;
                    case TypeFilter.Larger:
                        CurrentQuery = value == null ? CurrentQuery.Replace(code, " 1 = 1 ") : CurrentQuery.Replace(code, column + " > '" + value + "'");
                        break;
                    case TypeFilter.SmallerAndEqual:
                        CurrentQuery = value == null ? CurrentQuery.Replace(code, " 1 = 1 ") : CurrentQuery.Replace(code, column + " <= '" + value + "'");
                        break;
                    case TypeFilter.LargerAndEqual:
                        CurrentQuery = value == null ? CurrentQuery.Replace(code, " 1 = 1 ") : CurrentQuery.Replace(code, column + " >= '" + value + "'");
                        break;
                    case TypeFilter.Contains:
                        CurrentQuery = value == null ? CurrentQuery.Replace(code, " 1 = 1 ") : CurrentQuery.Replace(code, column + " Like '%" + value + "%'");
                        break;
                    case TypeFilter.In:
                        var sqlIn = "'" + value.ToString().Replace(",", "','") + "'";
                        CurrentQuery = value == null ? CurrentQuery.Replace(code, " 1 = 1 ") : CurrentQuery.Replace(code, column + " In (" + sqlIn + ")");
                        break;
                    case TypeFilter.InitiatedBy:
                        CurrentQuery = value == null ? CurrentQuery.Replace(code, " 1 = 1 ") : CurrentQuery.Replace(code, column + " Like '" + value + "%'");
                        break;
                    case TypeFilter.FinalizedBy:
                        CurrentQuery = value == null ? CurrentQuery.Replace(code, " 1 = 1 ") : CurrentQuery.Replace(code, column + " Like '%" + value + "'");
                        break;
                    case TypeFilter.Between:
                        CurrentQuery = value == null ? CurrentQuery.Replace(code, " 1 = 1 ") : CurrentQuery.Replace(code, column + " Between '" + value + "' And '" + value2 + "'");
                        break;
                    default:
                        break;
                }
            }
        }

        private class STreeNode : TreeNode
        {
            public Report Report { get; set; }
            public Consult Consult { get; set; }
        }
    }

    public static class CustomFormat
    {
        public static string ToFormatAmerican(this DateTime datetime)
        {
            return $"{datetime.Year + datetime.Month.ToString().PadLeft(2, '0') + datetime.Day.ToString().PadLeft(2, '0')}";
        }
    }

    public enum TypeSearch
    {
        Report,
        Consult
    }
}