using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Esr.Core.App.Authentication;
using Esr.Core.Component;
using Esr.Core.Domain.Authentication;
using Esr.Module.ControlPainel.Forms;
using Esr.Core.App.Translation;
using Esr.Core.App.Catalog;
using Esr.Core.App.FiltersCompanies;
using Esr.Core.Repository.DependencyInjection;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.ControlPainel.Controllers;
using Esr.Core.Domain.ConfNumbering;
using Esr.Core.App.ConfNumbering;

namespace Esr.Main
{
    public partial class FLogin : Form
    {
        private readonly UserController _userController;
        private readonly UserApp _userApp;
        private readonly CompanyApp _companyApp;
        private readonly TranslateApp _translateApp;
        private readonly TableApp _tableApp;
        private readonly DbTableApp _dbTableApp;
        private readonly AutomaticNumberingApp _automaticNumberingApp;

        private readonly SplashScreen _splashScreen;

        public bool Confirmed { get; set; }

        public FLogin(SplashScreen splash)
        {
            _splashScreen = splash;
            var ri = new RepositoryInjection();
            var conn = ri.GetClass<IFactoryConnection>();

            _userApp = new UserApp(conn);
            _companyApp = new CompanyApp(conn);
            _translateApp = new TranslateApp(conn);
            _tableApp = new TableApp(conn);
            _dbTableApp = new DbTableApp(conn);
            _automaticNumberingApp = new AutomaticNumberingApp(conn);

            _userController = new UserController(conn);

            GlobalUser.Forms = _tableApp.Search().ToList();
            GlobalUser.Translates = _translateApp.Search().ToList();
            GlobalUser.Tables = _dbTableApp.Search().ToList();
            GlobalUser.AutomaticNumberings = _automaticNumberingApp.Search().ToList();

            InitializeComponent();

            Unidade.ObjetoApp = new InvokeMethod(typeof(CompanyController), TypeExecute.SearchAll, "ListCompany", typeof(Company));
            Unidade.DisplayMember = "PersonName";
            Unidade.ValueMember = "Id";
            Unidade.Enabled = false;
            Unidade.Refresh();
            Unidade.SComponent.DropDown += SComponentOnDropDown;
            Unidade.Caption = "Unidade";

            EntrarButton.SComponent.BackColor = Color.DarkSlateGray;
            EntrarButton.SComponent.ForeColor = Color.White;
            EntrarButton.SComponent.Text = @"Entrar";
            EntrarButton.SComponent.Click += EntrarButton_Click;
            EntrarButton.Enabled = false;

            SenhaTextBox.SComponent.PasswordChar = '*';
            SenhaTextBox.Caption = "Senha";
            SenhaTextBox.SComponent.TextChanged += SenhaComponentOnTextChanged;

            UsuarioTextBox.SComponent.TextChanged += UsuarioComponentOnTextChanged;
            UsuarioTextBox.Caption = "Login";

            var cont = false;

            if (_companyApp.Search().Any())
            {
                if (!_userApp.Search().Any())
                {
                    MessageBox.Show(@"Necessário cadastrar um usuário",
                        @"BEM VINDO AO ESR SOFTWARES", MessageBoxButtons.OK);
                    var fuser = new FUser
                    {
                        StateForm = StateForm.Inserting,
                        ClosedAfterSave = true
                    };
                    fuser.RefreshControls();
                    ((User)fuser.CurrentControl).IsAdministrator = true;
                    _splashScreen.Close();
                    fuser.ShowDialog();
                }
                return;
            };
            MessageBox.Show(@"Este é o seu primeiro acesso ao sistema, por favor, cadastre sua empresa.",
                @"BEM VINDO AO ESR SOFTWARES", MessageBoxButtons.OK);

            do
            {
                var fcompany = new FCompany()
                {
                    StateForm = StateForm.Inserting,
                    ClosedAfterSave = true
                };
                fcompany.RefreshControls();
                _splashScreen.Close();
                fcompany.ShowDialog();
                if (!_companyApp.Search().Any())
                {
                    cont = MessageBox.Show(@"Necessário cadastrar uma empresa, deseja continuar ?",
                        @"BEM VINDO AO ESR SOFTWARES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                           DialogResult.Yes;
                }
            } while (cont);

            if (!_companyApp.Search().Any())
            {
                Close();
            }
            else
            {
                if (_userApp.Search().Any()) return;
                MessageBox.Show(@"Necessário cadastrar um usuário",
                    @"BEM VINDO AO ESR SOFTWARES", MessageBoxButtons.OK);
                var fuser = new FUser
                {
                    ClosedAfterSave = true,
                    StateForm = StateForm.Inserting,
                };
                ((User)fuser.CurrentControl).IsAdministrator = true;
                _splashScreen.Close();
                fuser.ShowDialog();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            _splashScreen.Close();
            base.OnShown(e);
        }

        private void SComponentOnDropDown(object sender, EventArgs eventArgs)
        {
            var user = _userApp.Search(c => c.Login == UsuarioTextBox.SComponent.Text).FirstOrDefault();
            if (user == null)
            {
                Unidade.Enabled = false;
                Unidade.Clear();
                return;
            }
            if (user.AccessAllCompanies)
                Unidade.SetList();
            else
                Unidade.SetList((from company in user.UsersCompanies select new { company.Company.PersonName, company.Company.Id }).ToList());
            Unidade.Enabled = true;
        }

        private void SenhaComponentOnTextChanged(object sender, EventArgs eventArgs)
        {
            EntrarButton.Enabled = !string.IsNullOrEmpty(((TextBox)sender).Text);
        }

        private void UsuarioComponentOnTextChanged(object sender, EventArgs eventArgs)
        {
            var user = _userApp.Search(c => c.Login == ((TextBox)sender).Text).FirstOrDefault();
            if (user == null)
            {
                Unidade.Enabled = false;
                Unidade.Clear();
                return;
            }
            if (user.AccessAllCompanies)
                Unidade.SetList();
            else
                Unidade.SetList((from company in user.UsersCompanies select new { company.Company.PersonName, company.Company.Id }).ToList());
            Unidade.Enabled = true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl(ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var login = UsuarioTextBox.ValueControl;
                var senha = SenhaTextBox.ValueControl;

                var listUsuario = _userController.FindUser(login.ToString(), senha.ToString());

                if (listUsuario != null)
                {
                    GlobalUser.User = listUsuario;
                    if (GlobalUser.User.AccessAllCompanies || GlobalUser.User.UsersCompanies.Any(c => c.CompanyId == (int)Unidade.SComponent.SelectedValue))
                    {
                        var company = _companyApp.FindId((int)Unidade.SComponent.SelectedValue);
                        GlobalUser.Company = company;
                        Confirmed = true;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(@"Você não tem acesso à esta unidade", @"Login Erro", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        Confirmed = false;
                    }

                }
                else
                {
                    MessageBox.Show(@"Login ou Senha incorreta!!", @"Login Erro", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Confirmed = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Ocorreu um erro : " + ex.Message);
                Confirmed = false;
            }
        }
    }
}