using System.Collections.Generic;
using System.Windows;
using Esr.Core.Component;
using Esr.Core.Domain.Authentication;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.Funerary.Forms.Contractors;
using Esr.Module.Funerary.Forms.Plans;
using System;
using Esr.Module.Funerary.Controllers;
using Esr.Module.Funerary.Domain.Plans;
using Esr.Module.Funerary.Domain.Contractors;

namespace Esr.Module.Funerary.Forms.OrderOfServices
{
    public partial class FOrdemOfService : FForm
    {
        public override StateForm StateForm
        {
            get { return base.StateForm; }
            set
            {
                if (value == StateForm.Inserting)
                    ((OrderOfService)CurrentControl).UserId = GlobalUser.User.Id;
                base.StateForm = value;
            }
        }

        public override List<SReports> SReportses { get; set; } = new List<SReports>
            {
                new SReports
                {
                    Nome = "Capa Ordem Serviço",
                    LocalPath = "CapaOrdemServico.rdlc",
                    DataSet = new Dictionary<string, SInvokeMethod>()
                    {
                        {
                            "OrderOfServiceDataSet", new SInvokeMethod
                        {
                            NameMethod = "QueryCapaOrdemServico",
                            TypeClass = typeof(OrderOfServiceController)

                            }
                        },
                        {
                            "VehiclesDataSet",
                            new SInvokeMethod()
                            {
                                NameMethod = "QueryMotoristaServico",
                                TypeClass = typeof(OrderOfServiceController)
                            }
                        },
                        {
                            "ContractorServiceDataSet",
                            new SInvokeMethod()
                            {
                                NameMethod = "QueryContratadaServico",
                                TypeClass = typeof(OrderOfServiceController)
                            }
                        }
                    }
                }
            };

        public FOrdemOfService()
        {
            Module = "Funerária";

            InvokeMethod = new InvokeMethod(typeof(OrderOfServiceController), new Dictionary<TypeExecute, string>()
            {
                { TypeExecute.InsertOrUpdate, "Save" },
                { TypeExecute.Remove, "RemoveId" },
                { TypeExecute.FindId, "FindId" },
                { TypeExecute.Search, "Search" },
                { TypeExecute.SearchAll, "ListOrderOfService" }
            }, typeof(OrderOfService));

            ObjectControl = new List<OrderOfService>();

            var controller = new OrderOfServiceController(FactoryConnection);

            if (!controller.Autoratized(GlobalUser.User.Id))
            {
                MessageBox.Show("Usuário não possui perfil de atendente", "ESR Softwares", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                Close();
            }

            InitializeComponent();

            PlanId.DisplayMember = "Description";
            PlanId.ValueMember = "Id";
            PlanId.ObjetoApp = new InvokeMethod(typeof(PlanController), TypeExecute.SearchAll, "ListPlan", typeof(Plan));
            PlanId.FormType = typeof(FPlan);

            ContractorId.DisplayMember = "PersonName";
            ContractorId.ValueMember = "Id";
            ContractorId.ObjetoApp = new InvokeMethod(typeof(ContractorController), TypeExecute.SearchAll, "ListContractor", typeof(Contractor));
            ContractorId.FormType = typeof(FContractor);

            OsDocuments.IsDependecyUkey = true;
            OsDocuments.ScreenSecondary = true;
            OsDocuments.ObjetoApp = new InvokeMethod(typeof(OsDocumentController), TypeExecute.Search, "ListOsDocument", typeof(OsDocument));
            OsDocuments.FormType = typeof(FDocument);
            OsDocuments.Caption = "Documentos";

            OsProducts.IsDependecyUkey = true;
            OsProducts.ScreenSecondary = true;
            OsProducts.ObjetoApp = new InvokeMethod(typeof(OsProductController), TypeExecute.Search, "ListOsProduct", typeof(OsProduct));
            OsProducts.FormType = typeof(FOsProduct);
            OsProducts.Caption = "Produtos";

            OsServices.IsDependecyUkey = true;
            OsServices.ScreenSecondary = true;
            OsServices.ObjetoApp = new InvokeMethod(typeof(OsServiceController), TypeExecute.Search, "ListOsService", typeof(OsService));
            OsServices.FormType = typeof(FOsService);
            OsServices.Caption = "Serviços";

            /*
                OsContractorProducts.IsDependecyUkey = true;
                OsContractorProducts.ScreenSecondary = true;
                OsContractorProducts.ObjetoApp = new SInvokeMethod(typeof(OsContractorProductApp), "SearchAllOsContractorProduct");
                OsContractorProducts.FormType = typeof(FOsContractorProduct);
                OsContractorProducts.Caption = "Contratada X Produtos";
            */

            OsContractorServices.IsDependecyUkey = true;
            OsContractorServices.ScreenSecondary = true;
            OsContractorServices.ObjetoApp = new InvokeMethod(typeof(OsContractorServiceController), TypeExecute.Search, "ListOsContractorService", typeof(OsContractorService));
            OsContractorServices.FormType = typeof(FOscontractorService);
            OsContractorServices.Caption = "Contratada X Serviços";

            OsVehicles.IsDependecyUkey = true;
            OsVehicles.ScreenSecondary = true;
            OsVehicles.ObjetoApp = new InvokeMethod(typeof(OsVehicleController), TypeExecute.Search, "ListOsVehicle", typeof(OsContractorService));
            OsVehicles.FormType = typeof(FOsVehicle);
            OsVehicles.Caption = "Frotas";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var col1 = OsProducts.SComponent.Columns["UnitaryValue"];
            if(col1 != null)
                col1.DefaultCellStyle.Format = "C2";
            var col2 = OsProducts.SComponent.Columns["ValueTotal"];
            if(col2 != null)
                col2.DefaultCellStyle.Format = "C2";
        }
    }
}