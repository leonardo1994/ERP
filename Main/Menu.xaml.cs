using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using Esr.Core.App.Authentication;
using Esr.Core.Component;
using Esr.Core.Component.SAttributes;
using Esr.Module.FleetManagement.Forms.Drives;
using Esr.Module.FleetManagement.Forms.Vehicles;
using Esr.Module.Funerary.Forms.Contractors;
using Esr.Module.Funerary.Forms.DataDeceaseds;
using Esr.Module.Funerary.Forms.DebitNotes;
using Esr.Module.Funerary.Forms.GroupAttendants;
using Esr.Module.Funerary.Forms.OrderOfServices;
using Esr.Module.Funerary.Forms.Plans;
using Esr.Module.Funerary.Forms.Religions;
using Esr.Module.InitialRegistration.Forms.Address;
using Esr.Module.InitialRegistration.Forms.Colors;
using Esr.Module.InitialRegistration.Forms.Persons;
using Esr.Module.InitialRegistration.Forms.Providers;
using Esr.Module.InitialRegistration.Forms.Services;
using Esr.Module.InitialRegistration.Forms.StockItems;
using Esr.Module.Stock.Forms.InputsOutPuts;
using Esr.Module.TaxManagement.Forms.Taxations;
using Esr.Core.Domain.Authentication;
using System.Windows.Controls.Ribbon;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.DependencyInjection;
using Esr.Module.ControlPainel.Forms;
using Esr.Module.ControlPainel.Controllers;
using Esr.Module.InitialRegistration.Controllers;
using Esr.Module.Funerary.Controllers;
using Esr.Module.Stock.Controllers;
using Esr.Module.FleetManagement.Controllers;
using Esr.Core.Domain.Translation;
using Esr.Module.Funerary.Domain.DebitNotes;
using Esr.Module.Funerary.Domain.Contractors;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.TaxManagement.Domain.Taxations;
using Esr.Module.Stock.Domain.Movements;
using Esr.Module.InitialRegistration.Domain.Providers;
using Esr.Module.InitialRegistration.Domain.Services;
using Esr.Module.InitialRegistration.Domain.Colors;
using Esr.Module.FleetManagement.Domain.Vehicles;
using Esr.Module.FleetManagement.Domain.Drives;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.Funerary.Domain.GroupAttendants;
using Esr.Module.Funerary.Domain.Religions;
using Esr.Module.Funerary.Domain.Plans;
using Esr.Core.Domain.Address;
using Esr.Module.Funerary.Domain.DataDeceaseds;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.ConfNumbering;
using Esr.Module.Parking.Forms;
using Esr.Module.Parking.Controllers;
using Esr.Module.Parking.Domain;
using Esr.Module.InitialRegistration.Forms.Sales;
using Esr.Module.InitialRegistration.Domain.Sales;
using Esr.Module.Financial.Forms.Financial;
using Esr.Module.Financial.Controllers.Financial;
using Esr.Module.Financial.Domain.Financial;
using Esr.Module.Financial.Forms.Receive;
using Esr.Module.Financial.Controllers.Receive;

namespace Esr.Main
{

    /// <summary>
    /// Interaction logic for SMenu.xaml
    /// </summary>

    public partial class Menu : IModule
    {
        [ImportMany(typeof(IModule))]
        public IEnumerable<IModule> Modules { get; set; }

        private IFactoryConnection _conn;

        public Menu()
        {
            _conn = new RepositoryInjection().GetClass<IFactoryConnection>();

            InitializeComponent();
            //var catalog = new AggregateCatalog(new AssemblyCatalog(Assembly.GetExecutingAssembly()), new DirectoryCatalog("."));
            //var container = new CompositionContainer(catalog);
            //container.ComposeParts(this);

            //foreach (var plugin in Modules)
            //{
            //    //plugin.SetGrid(((FMain)Tag).GridSearch);
            //    foreach (var item in plugin.ItemsCollection())
            //    {
            //        this.Items().Add(item);
            //    }
            //}

            if (GlobalUser.User == null) return;

            MenuPaindelControle.Visibility = GlobalUser.User.IsAdministrator ? Visibility.Visible : Visibility.Collapsed;

            //ModuleEstacionamento.Visibility = Visibility.Collapsed;

            var companies = new CompanyApp(_conn).Search(c => GlobalUser.User.AccessAllCompanies || c.UsersCompanies.Any(d => d.UserId == GlobalUser.User.Id));

            foreach (var item in companies)
            {
                var itemMenu = new RibbonApplicationMenuItem() { Header = string.Format("{0} - {1}", item.Id, item.CorporateName), Tag = item };
                itemMenu.Click += MenuItemCompanies_Click;
                ListCompanies.Items.Add(
                    itemMenu
                );
            }
        }

        private void MenuItemCompanies_Click(object sender, RoutedEventArgs e)
        {
            Ribbon.ApplicationMenu.Label = "ESR SOFTWARES";
            var ribbonItem = (RibbonApplicationMenuItem)sender;
            GlobalUser.Company = (Company)ribbonItem.Tag;
            System.Windows.MessageBox.Show(string.Format("Empresa alterada para {0}", GlobalUser.Company.CorporateName), "ESR SOFTWARES", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public ItemCollection ItemsCollection()
        {
            return Items();
        }

        private void SetGrid()
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.Form = new SReflection().CreateNewInstance<FForm>(form.GridSearch.FormType);
            if (!form.GridSearch.Visible)
            {
                form.GridSearch.IsDependecyUkey = false;
                form.GridSearch.ScreenSecondary = false;
                var layout = form.GridSearch.STextBox.Parent;
                form.GridSearch.SMenuComponent.Dock = DockStyle.Bottom;
                form.GridSearch.STextBox.Dock = DockStyle.Bottom;
                layout.Controls.Add(form.GridSearch.SMenuComponent);
                form.GridSearch.Visible = true;
                form.GridSearch.Name = "GridMain";
            }
            form.GridSearch.Refresh();
        }

        private void MenuButtonUsuario_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FUser);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(UserController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListUser"},
                    { TypeExecute.RemoveListId, "Remove"}
                }, typeof(User));
            form.GridSearch.Caption = "Usuários";
            SetGrid();
        }

        private void MenuButtonEmpresa_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FCompany);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(CompanyController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListCompany"},
                    { TypeExecute.RemoveListId, "Remove"}
                }, typeof(Company));
            form.GridSearch.Caption = "Empresas";
            SetGrid();
        }

        private void MenuButtonTradutor_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FTranslate);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(TranslateController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListTranslate"},
                    { TypeExecute.RemoveListId, "Remove"}
                }, typeof(Translate));
            form.GridSearch.Caption = "Traduções";
            SetGrid();
        }

        private void MenuButtonGrupoAcesso_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FGroupAccess);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(GroupAccessController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListGroupAccess"},
                    { TypeExecute.RemoveListId, "Remove"}
                }, typeof(GroupAccess));
            new SInvokeMethod(typeof(GroupAccessController), "ListGroupAccess");
            form.GridSearch.Caption = "Grupos de acesso";
            SetGrid();
        }

        private void MenuButtonPessoaJuridica_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FLegalPerson);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(LegalPersonController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListLegalPerson"},
                    { TypeExecute.RemoveListId, "Remove"}
                }, typeof(LegalPerson));
            form.GridSearch.Caption = "Pessoa Jurídica";
            SetGrid();
        }

        private void MenuButtonNotaDebito_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FDebitNotes);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(DebitNotesController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListDebitNotes"},
                    { TypeExecute.RemoveListId, "Remove"}
                },
                typeof(DebitNote));
            form.GridSearch.Caption = "Notas de débito";
            SetGrid();
        }

        private void MenuButtonContratada_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FContractor);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(ContractorController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListContractor"},
                    { TypeExecute.RemoveListId, "Remove"},
                },
                typeof(Contractor));
            form.GridSearch.Caption = "Contratadas";
            SetGrid();
        }

        private void MenuButtonItemEstoque_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FStockItem);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(StockItemController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListStockItem"},
                    { TypeExecute.RemoveListId, "Remove"}
                },
                typeof(StockItem));
            form.GridSearch.Caption = "Item de Estoque";
            SetGrid();
        }

        private void MenuButtonImpostos_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FTaxation);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(TaxationController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListTaxation"},
                    { TypeExecute.RemoveListId, "Remove"}
                },
                typeof(Taxation));
            form.GridSearch.Caption = "Impostos";
            SetGrid();
        }

        private void MenuButtonFamilia_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FFamily);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(FamilyController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListFamily"},
                    { TypeExecute.RemoveListId, "Remove"}
                },
                typeof(Family));
            form.GridSearch.Caption = "Familia do item";
            SetGrid();
        }

        private void MenuItemUnidadeMedidad_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FUnitMeasure);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(UnitMeasureController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListUnitMeasure"},
                    { TypeExecute.RemoveListId, "Remove"}
                }, typeof(UnitMeasure));
            form.GridSearch.Caption = "Unidades de Medida";
            SetGrid();
        }

        private void MenuButtonMarca_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FMark);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(MarkController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListMark"},
                    { TypeExecute.RemoveListId, "Remove"}
                }, typeof(Mark));
            form.GridSearch.Caption = "Marcas";
            SetGrid();
        }

        private void MenuButtonModel_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FModel);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(ModelController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListModel"},
                    { TypeExecute.RemoveListId, "Remove"}
                }, typeof(Model));
            form.GridSearch.Caption = "Modelos";
            SetGrid();
        }

        private void MenuButtonNcm_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FNcm);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(NcmController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListNcm"},
                    { TypeExecute.RemoveListId, "Remove"}
                }, typeof(Ncm));
            form.GridSearch.Caption = "NCM - Nomenclatura Comum do Mercosul";
            SetGrid();
        }

        private void MenuButtonLocal_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FLocalStock);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(LocalStockController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListLocalStock"},
                    { TypeExecute.RemoveListId, "Remove"}
                }, typeof(LocalStock));
            form.GridSearch.Caption = "Locais de estoque";
            SetGrid();
        }

        public void SetGrid(SGrid sGrid)
        {

        }

        public ItemCollection Items()
        {
            return null;
        }

        private void MenuButtonEntradaEstoque_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FInputStock);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(InputStockController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListInputStock"},
                    { TypeExecute.RemoveListId, "Remove"}
                }, typeof(InputStock));
            form.GridSearch.Caption = "Entradas no Estoque";
            SetGrid();
        }

        private void MenuButtonSaidaEstoque_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FOutputStock);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(OutputStockController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListOutputStock"},
                    { TypeExecute.RemoveListId, "Remove"}
                }, typeof(OutputStock));
            form.GridSearch.Caption = "Saídas do Estoque";
            SetGrid();
        }

        private void MenuButtonFornecedor_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FProvider);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(ProviderController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListProvider"},
                    { TypeExecute.RemoveListId, "Remove"}
                }, typeof(Provider));
            form.GridSearch.Caption = "Fornecedores";
            SetGrid();
        }

        private void MenuButtonServico_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FService);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(ServiceController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListService"},
                    { TypeExecute.RemoveListId, "Remove"}
                }, typeof(Service));
            form.GridSearch.Caption = "Serviços";
            SetGrid();
        }

        private void MenuButtonTipoServico_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FTypeService);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(TypeServiceController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListTypeService" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(TypeService));
            form.GridSearch.Caption = "Tipos de Serviços";
            SetGrid();
        }

        private void MenuButtonCor_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FColor);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(ColorController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListColor" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(Color));
            form.GridSearch.Caption = "Cores";
            SetGrid();
        }

        private void MenuButtonPlaca_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FVehiclePlate);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(VehiclePlateController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListVehiclePlate" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(VehiclePlate));
            form.GridSearch.Caption = "Placas Associadas";
            SetGrid();
        }

        private void MenuButtonVeiculo_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FVehicle);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(VehicleController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListVehicle" },
                    { TypeExecute.RemoveListId, "Remove" }
                },
                typeof(Vehicle));
            form.GridSearch.Caption = "Veículos";
            SetGrid();
        }

        private void MenubuttonModelo_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FModelVehicle);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(ModelVehicleController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListModelVehicle" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(ModelVehicle));
            form.GridSearch.Caption = "Modelos de Veículo";
            SetGrid();
        }

        private void MenuButtonMotorista_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FDrive);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(DriveController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListDrive" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(Drive));
            form.GridSearch.Caption = "Motoristas";
            SetGrid();
        }

        private void MenuButtonOrderServico_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FOrdemOfService);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(OrderOfServiceController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListOrderOfService" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(OrderOfService));
            form.GridSearch.Caption = "Ordem de Serviço";
            SetGrid();
        }

        private void RibbonButtonAttendant_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FGroupAttendant);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(GroupAttendantController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListGroupAttendant" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(GroupAttendant));
            form.GridSearch.Caption = "Grupo de Atendente";
            SetGrid();
        }

        private void RibbonButtonReligion_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FReligion);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(ReligionController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListReligion" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(Religion));
            form.GridSearch.Caption = "Religião";
            SetGrid();
        }

        private void RibbonButtonPlan_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FPlan);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(PlanController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListPlan" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(Plan));
            form.GridSearch.Caption = "Plano";
            SetGrid();
        }

        private void RibbonButtonCidade_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FCity);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(CityController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListCity" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(City));
            new SInvokeMethod(typeof(CityController), "ListCity");
            form.GridSearch.Caption = "Cidade";
            SetGrid();
        }

        private void RibbonButtonEstado_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FState);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(StateController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListState" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(State));
            form.GridSearch.Caption = "Estado";
            SetGrid();
        }

        private void RibbonButtonPais_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FCountry);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(StateController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListState" },
                    { TypeExecute.RemoveListId, "Remove" }
                }
                , typeof(State));
            form.GridSearch.Caption = "País";
            SetGrid();
        }

        private void MenuButtonDadosFalecido_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FDataDeceased);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(DataDeceasedController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListDataDeceased" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(DataDeceased));
            form.GridSearch.Caption = "Dados do Falecido";
            SetGrid();
        }

        private void MenuButtonQuery_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FQuery);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(QueryController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListQuery" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(Query));
            form.GridSearch.Caption = "Queries";
            SetGrid();
        }

        private void MenuButtonFilter_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FFilter);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(FilterController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListFilter" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(Filter));
            form.GridSearch.Caption = "Filtros";
            SetGrid();
        }

        private void MenuButtonReport_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FReport);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(ReportController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListReport" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(Report));
            form.GridSearch.Caption = "Relatórios";
            SetGrid();
        }

        private void MenuButtonConsult_OnClick(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FConsult);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(ConsultController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListConsult" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(Consult));
            form.GridSearch.Caption = "Consultas";
            SetGrid();
        }

        private void MenuButtonAutNumbering_Click(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FConfAutNumbering);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(ConfAutNumeringController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListAutomaticNumering" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(AutomaticNumbering));
            form.GridSearch.Caption = "Numeração Automática";
            SetGrid();
        }

        private void MenuButtonFiltros_Click(object sender, RoutedEventArgs e)
        {
            new Esr.Module.ControlPainel.Forms.FiltersCompanies.FFilterCompany().Show();
        }

        private void MenuButtonEntradaSaida_Click(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            //form.GridSearch.FormType = typeof(FParkingInOut);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(ParkingInOutController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListParkingInOut" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(ParkingInOut));
            form.GridSearch.Caption = "Controle de Entrada e Saída";
            SetGrid();
        }

        private void MenuButtonTabelaPreco_Click(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FParkingTableOfPrice);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(ParkingTableOfPriceController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListParkingTableOfPrice" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(ParkingTableOfPrice));
            form.GridSearch.Caption = "Tabela de Preços";
            SetGrid();
        }

        private void MenuButtonEntradaEstacionamento_Click(object sender, RoutedEventArgs e)
        {
            new FParkingIn().ShowDialog();
        }

        private void MenuButtonSaídaEstacionamento_Click(object sender, RoutedEventArgs e)
        {
            new FParkingOut().ShowDialog();
        }

        private void MenuButtonFormaPagamento_Click(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FFormOfPayment);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(FormOfPaymentController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListFormOfPayment" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(FormOfPayment));
            form.GridSearch.Caption = "Formas de Pagamento";
            SetGrid();
        }

        private void MenuButtonAgreement_Click(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FParkingAgreement);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(ParkingAgreementController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListParkingAgreement" },
                    { TypeExecute.RemoveListId, "Remove" }
                }, typeof(ParkingAgreement));
            form.GridSearch.Caption = "Convênios";
            SetGrid();
        }

        private void MnVeiculo_Click(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(Esr.Module.FleetManagement.Forms.FVechicle);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(VehicleController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListVehicle" },
                    { TypeExecute.RemoveListId, "Remove" }
                },
                typeof(Vehicle));
            form.GridSearch.Caption = "Veículos";
            SetGrid();
        }

        private void MnTipoVeiculo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MnModelo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MnMarca_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MnCorVeiculo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuPaindelControle_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void MenuButtonContasReceber_Click(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FBillsToReceive);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(BillsToReceiveController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListBillsToReceive" },
                    { TypeExecute.RemoveListId, "Remove" }
                },
                typeof(Vehicle));
            form.GridSearch.Caption = "Contas a Receber";
            SetGrid();
        }

        private void MenuButtonTipoDocumento_Click(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FTypeDocumentFinancial);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(TypeDocumentFinancialController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListTypeDocumentFinancial" },
                    { TypeExecute.RemoveListId, "Remove" }
                },
                typeof(TypeDocumentFinancial));

            form.GridSearch.Caption = "Tipo de Documento";
            SetGrid();
        }

        private void MenuButtonConversaoUndMedida_Click(object sender, RoutedEventArgs e)
        {
            var form = Tag as FMain;
            if (form == null) return;
            form.GridSearch.FormType = typeof(FUnitMeasureConversion);
            form.GridSearch.ObjetoApp = new InvokeMethod(typeof(UnitMeasureConversionController),
                new Dictionary<TypeExecute, string>()
                {
                    { TypeExecute.SearchAll, "ListUnitMeasureConversion" },
                    { TypeExecute.RemoveListId, "Remove" }
                },
                typeof(UnitMeasureConversion));

            form.GridSearch.Caption = "Conversão de Unidade de Medida";
            SetGrid();
        }
    }
}