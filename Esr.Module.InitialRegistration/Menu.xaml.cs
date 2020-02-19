using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;
using Esr.Core.App.Authentication;
using Esr.Core.Component;
using Esr.Core.Component.SAttributes;
using Esr.Module.InitialRegistration.Forms.Persons;

namespace Esr.Module.InitialRegistration
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

        private void MenuButtonPessoaJuridica_OnClick(object sender, RoutedEventArgs e)
        {
            if (_grid == null) return;
            _grid.FormType = typeof(FLegalPerson);
            //_grid.ObjetoApp = new SInvokeMethod(typeof(LegalPersonApp), "SearchAllLegalPerson");
            _grid.Caption = "Pessoa Jurídica";
            _grid.Refresh();
            _grid.Visible = true;
        }
    }
}