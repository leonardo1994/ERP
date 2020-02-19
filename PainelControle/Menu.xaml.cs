using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using Esr.Core.App.Authentication;
using Esr.Core.App.Translation;
using Esr.Core.Component;
using Esr.Core.Component.SAttributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.Translation;
using Esr.Module.ControlPainel.Forms;

namespace Esr.Module.ControlPainel
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

        public void SetGrid(SGrid grid)
        {
            _grid = grid;
        }

        public ItemCollection ItemsCollection()
        {
            return Items;
        }

        private void MenuButtonUsuario_OnClick(object sender, RoutedEventArgs e)
        {
            if (_grid == null) return;
            _grid.FormType = typeof(FUser);
            //_grid.ObjetoApp = new InvokeMethod(typeof());
            _grid.ValueControl = new List<User>();
            _grid.Caption = "Usuários";
            _grid.Refresh();
            _grid.Visible = true;
        }

        private void MenuButtonEmpresa_OnClick(object sender, RoutedEventArgs e)
        {
            if (_grid == null) return;
            _grid.FormType = typeof(FCompany);
            //_grid.ObjetoApp = new SInvokeMethod(typeof(CompanyApp), "SearchAllCompany");
            _grid.ValueControl = new List<Company>();
            _grid.Caption = "Empresas";
            _grid.Refresh();
            _grid.Visible = true;
        }

        private void MenuButtonTradutor_OnClick(object sender, RoutedEventArgs e)
        {
            if (_grid == null) return;
            _grid.FormType = typeof(FTranslate);
            //_grid.ObjetoApp = new SInvokeMethod(typeof(TranslateApp), "SearchAll");
            _grid.ValueControl = new List<Translate>();
            _grid.Caption = "Traduções";
            _grid.Refresh();
            _grid.Visible = true;
        }

        private void MenuButtonGrupoAcesso_OnClick(object sender, RoutedEventArgs e)
        {
            if (_grid == null) return;
            _grid.FormType = typeof(FGroupAccess);
            //_grid.ObjetoApp = new SInvokeMethod(typeof(GroupAccessApp), "SearchAll");
            _grid.Caption = "Grupos de acesso";
            _grid.Refresh();
            _grid.Visible = true;
        }
    }
}