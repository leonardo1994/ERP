using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;
using Esr.Core.Component;
using Esr.Core.Component.SAttributes;
using Esr.Module.Funerary.App.Contractors;
using Esr.Module.Funerary.App.DebitNotes;
using Esr.Module.Funerary.Forms.Contractors;
using Esr.Module.Funerary.Forms.DebitNotes;

namespace Esr.Module.Funerary
{
    /// <summary>
    /// Interaction logic for SMenu.xaml
    /// </summary>
    [Export(typeof(IModule))]
    public partial class Menu : IModule
    {
        private SGrid _grid;

        public Menu()
        {
            InitializeComponent();
        }

        public ItemCollection ItemsCollection()
        {
            return Items;
        }

        public void SetGrid(SGrid grid)
        {
            _grid = grid;
        }

        private void MenuButtonNotaDebito_OnClick(object sender, RoutedEventArgs e)
        {
            if (_grid == null) return;
            _grid.FormType = typeof(FDebitNotes);
            //_grid.ObjetoApp = new SInvokeMethod(typeof(DebitNoteApp), "SearchAllDebitNote");
            _grid.Caption = "Notas de débito";
            _grid.Refresh();
            _grid.Visible = true;
        }

        private void MenuButtonContratada_OnClick(object sender, RoutedEventArgs e)
        {
            if (_grid == null) return;
            _grid.FormType = typeof(FContractor);
            //_grid.ObjetoApp = new SInvokeMethod(typeof(ContractorApp), "SearchAllContractor");
            _grid.Caption = "Contratadas";
            _grid.Refresh();
            _grid.Visible = true;
        }
    }
}