using Esr.Module.Parking.Controllers;
using Esr.Module.Parking.Domain;
using System.Windows.Forms;
using System.Linq;

namespace Esr.Module.Parking.Forms
{
    public partial class FParkingParameter : Core.Component.FBase
    {
        public FParkingParameter()
        {
            InitializeComponent();
            GridParameter.SMenuComponent.Visible = false;
            InitiliazeGrid();
        }

        private void InitiliazeGrid()
        {
            GridColumn();
            GridRows();
        }

        private void GridColumn()
        {
            GridParameter.SComponent.Columns.Add(new DataGridViewColumn()
            {
                HeaderText = "ID",
                Name = "ID",
                ReadOnly = true
            });

            GridParameter.SComponent.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Parâmetro",
                Name = "Parametro",
                ReadOnly = true
            });

            GridParameter.SComponent.Columns.Add(new DataGridViewComboBoxColumn()
            {
                HeaderText = "Valor",
                Name = "Valor",
                ReadOnly = false
            });

            GridParameter.STextBox.Visible = false;
            GridParameter.SComponent.EditingControlShowing += SComponent_EditingControlShowing;
            GridParameter.SComponent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridParameter.SComponent.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
        }

        private void SComponent_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (GridParameter.SComponent.CurrentCell.ColumnIndex == 2 && e.Control is ComboBox)
            {
                var comboBox = (ComboBox)e.Control;
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged; ;
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var parameterCtrl = new ParkingParameterController(FactoryConnection);

            var p = parameterCtrl.ListParameter();
        }

        public void GridRows()
        {
            // Tabela de Preço Padrão
            var tableOfPriceCtr = new ParkingTableOfPriceController(FactoryConnection);
            var listTableOfPrice = tableOfPriceCtr.ListParkingTableOfPrice();

            var rowTBOfPrice = new DataGridViewRow();

            rowTBOfPrice.Cells.Add(new DataGridViewTextBoxCell() { Value = "StandardTableOfPriceId" });
            rowTBOfPrice.Cells.Add(new DataGridViewTextBoxCell() { Value = "Tabela de Preço Padrão" });
            rowTBOfPrice.Cells.Add(new DataGridViewComboBoxCell() { ValueMember = "Id", DataSource = listTableOfPrice, DisplayMember = "Description", ReadOnly = false, DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox });

            GridParameter.SComponent.Rows.Add(rowTBOfPrice);
        }
    }
}