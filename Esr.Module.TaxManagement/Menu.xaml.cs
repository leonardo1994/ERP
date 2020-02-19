using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;
using Esr.Core.Component;
using Esr.Core.Component.SAttributes;
using Esr.Module.TaxManagement.App.Taxations;
using Esr.Module.TaxManagement.Forms.Taxations;

namespace Esr.Module.TaxManagement
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

        private void MenuButtonImpostos_OnClick(object sender, RoutedEventArgs e)
        {
            if (_grid == null) return;
            _grid.FormType = typeof(FTaxation);
            _grid.Caption = "Impostos";
            _grid.Refresh();
            _grid.Visible = true;
        }
    }
}