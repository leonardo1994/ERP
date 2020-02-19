using System;
using System.Linq;
using System.Windows.Forms;
using Esr.Core.App.Authentication;
using Esr.Core.App.FiltersCompanies;
using Esr.Core.Component;
using Esr.Core.Repository.DependencyInjection;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;

namespace Esr.Module.ControlPainel.Forms.FiltersCompanies
{
    public partial class FFilterCompany : FProcess
    {
        private readonly FilterCompanyApp _filterCompanyApp;
        private readonly CompanyApp _companyApp;
        private readonly DbTableApp _dbTableApp;
        private readonly IFactoryConnection _conn;

        public FFilterCompany()
        {
            StateForm = StateForm.Editing;

            InitializeComponent();

            sMenuProcess1.Visibility = System.Windows.Visibility.Hidden;
            elementHost1.Visible = false;

            gridFilterCompany.SMenuComponent.Visible = false;
            gridFilterCompany.Label.Visible = false;
            gridFilterCompany.SComponent.SelectionMode = DataGridViewSelectionMode.CellSelect;

            var ri = new RepositoryInjection();

            _conn = ri.GetClass<IFactoryConnection>();

            _filterCompanyApp = new FilterCompanyApp(_conn);
            _companyApp = new CompanyApp(_conn);
            _dbTableApp = new DbTableApp(_conn);

            InitializeStrutureColumns();
            UpdateDataSource();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            gridFilterCompany.SComponent.ContextMenuStrip.Items[0].Visible = false; // Visualizar
            gridFilterCompany.SComponent.ContextMenuStrip.Items[1].Visible = false; // Adicionar
            gridFilterCompany.SComponent.ContextMenuStrip.Items[3].Visible = false; // Excluir

            gridFilterCompany.SComponent.ContextMenuStrip.Items[2].Visible = true;
            gridFilterCompany.SComponent.ContextMenuStrip.Items[2].Click += ContextMenuStrip_Alterar_Click;
            gridFilterCompany.SComponent.ContextMenuStrip.Items[4].Click += ContextMenuStrip_Update_Click;

            RefreshControls();
        }

        private void ContextMenuStrip_Update_Click(object sender, EventArgs e)
        {
            UpdateDataSource();
        }

        private void ContextMenuStrip_Alterar_Click(object sender, EventArgs e)
        {
            var cell = gridFilterCompany.SComponent.SelectedCells[0];
            if (cell.Tag == null) return;
            new FFilterCompany_001((int)cell.OwningColumn.Tag, (int)cell.OwningRow.Tag, _conn).ShowDialog();
        }

        private void InitializeStrutureColumns()
        {
            try
            {
                var column1 = new DataGridViewTextBoxColumn
                {
                    Name = "TableName",
                    HeaderText = @"Tabelas",
                    ValueType = typeof(string)
                };

                gridFilterCompany.SComponent.Columns.Add(column1);

                var companies = _companyApp.Search().ToList();
                foreach (var item in companies)
                {
                    gridFilterCompany.SComponent.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Tag = item.Id,
                        Name = $"Column{ item.Id }",
                        HeaderText = item.CorporateName,
                        ValueType = typeof(string),
                    });
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void UpdateDataSource()
        {
            gridFilterCompany.SComponent.Rows.Clear();
            var filters = _filterCompanyApp.Search()
                .Include(c => c.DbTable)
                .Include(c => c.CompanyLeft)
                .Include(c => c.CompanyRight)
                .ToList()
                .GroupBy(c => c.DbTable);
            var linesCount = filters.ToList().Count;
            gridFilterCompany.SComponent.Rows.Add(linesCount);

            var nCont = 0;

            foreach (var filterCompany in filters)
            {
                var cell = gridFilterCompany.SComponent[0, nCont];
                cell.OwningRow.Tag = filterCompany.Key.Id;
                cell.Style = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleLeft,
                    BackColor = System.Drawing.Color.White,
                    ForeColor = System.Drawing.Color.Black
                };

                cell.Value = $"Tabela: {filterCompany.Key.TableName}\nDescrição: {filterCompany.Key.TableDescription}";

                var grupo = filterCompany.GroupBy(c => c.CompanyLeft);

                foreach (var grupoCompany in grupo)
                {
                    var coluna = $"Column{ grupoCompany.Key.Id}";

                    var dataCell = gridFilterCompany.SComponent[coluna, nCont];
                    foreach (var company in grupoCompany)
                    {
                        dataCell.Tag = company.CompanyLeftId;
                        dataCell.Value = dataCell.Value + company.CompanyRight.CorporateName + "\n";
                        if (!company.Active)
                            dataCell.Style = new DataGridViewCellStyle()
                            {
                                BackColor = System.Drawing.Color.DarkRed,
                                ForeColor = System.Drawing.Color.White
                            };
                    }
                }
                nCont++;
            }

            gridFilterCompany.SComponent.Columns[0].Frozen = true;
        }
    }
}