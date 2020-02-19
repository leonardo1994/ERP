using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;
using Esr.Core.Component;
using Esr.Core.Component.SAttributes;
using Esr.Module.InitialRegistration.Forms.StockItems;

namespace Esr.Module.Stock
{
    /// <summary>
    /// Interaction logic for SMenu.xaml
    /// </summary>
    [Export(typeof(IModule))]
    public partial class Menu : IModule
    {
        private SGrid _grid;

        public ItemCollection ItemsCollection()
        {
            return Items;
        }

        public Menu()
        {
            InitializeComponent();
        }

        public void SetGrid(SGrid grid)
        {
            _grid = grid;
        }

        private void MenuButtonItemEstoque_OnClick(object sender, RoutedEventArgs e)
        {
            if (_grid == null) return;
            _grid.FormType = typeof(FStockItem);
            //_grid.ObjetoApp = new SInvokeMethod(typeof(StockItemApp), "SearchAllStockItem");
            _grid.Caption = "item de estoque";
            _grid.Refresh();
            _grid.Visible = true;
        }

        private void MenuButtonFamilia_OnClick(object sender, RoutedEventArgs e)
        {
            if (_grid == null) return;
            _grid.FormType = typeof(FFamily);
            //_grid.ObjetoApp = new SInvokeMethod(typeof(FamilyApp), "SearchAllFamily");
            _grid.Caption = "Familia do item";
            _grid.Refresh();
            _grid.Visible = true;
        }

        private void MenuItemUnidadeMedidad_OnClick(object sender, RoutedEventArgs e)
        {
            if (_grid == null) return;
            _grid.FormType = typeof(FUnitMeasure);
            //_grid.ObjetoApp = new SInvokeMethod(typeof(UnitMeasureApp), "SearchAllUnitMeasure");
            _grid.Caption = "Unidades de Medida";
            _grid.Refresh();
            _grid.Visible = true;
        }

        private void MenuButtonMarca_OnClick(object sender, RoutedEventArgs e)
        {
            if (_grid == null) return;
            _grid.FormType = typeof(FMark);
            //_grid.ObjetoApp = new SInvokeMethod(typeof(MarkApp), "SearchAllMark");
            _grid.Caption = "Marcas";
            _grid.Refresh();
            _grid.Visible = true;
        }

        private void MenuButtonModel_OnClick(object sender, RoutedEventArgs e)
        {
            if (_grid == null) return;
            _grid.FormType = typeof(FModel);
            //_grid.ObjetoApp = new SInvokeMethod(typeof(ModelApp), "SearchAllModel");
            _grid.Caption = "Modelos";
            _grid.Refresh();
            _grid.Visible = true;
        }

        private void MenuButtonNcm_OnClick(object sender, RoutedEventArgs e)
        {
            if (_grid == null) return;
            _grid.FormType = typeof(FNcm);
            //_grid.ObjetoApp = new SInvokeMethod(typeof(NcmApp), "SearchAllNcm");
            _grid.Caption = "NCM - Nomenclatura Comum do Mercosul";
            _grid.Refresh();
            _grid.Visible = true;
        }
    }
}