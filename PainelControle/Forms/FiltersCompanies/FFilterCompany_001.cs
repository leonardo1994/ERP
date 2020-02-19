using Esr.Core.Component;
using System.Windows;
using Esr.Core.Domain.FiltersCompanies;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.ControlPainel.Controllers;
using System.Linq;

namespace Esr.Module.ControlPainel.Forms.FiltersCompanies
{
    public partial class FFilterCompany_001 : FProcess
    {
        private FilterCompanyController _filterCompanyApp;
        private int _companyLeftId;
        private int _dbTableId;

        public FFilterCompany_001(int companyLeftId, int dbTableId, IFactoryConnection efc)
        {
            InitializeComponent();

            CheckListBoxCompanies.ObjetoApp = new InvokeMethod(typeof(CompanyController), TypeExecute.SearchAll, "ListCompany", typeof(Company));

            CheckListBoxCompanies.UpdateDataSource();
            CheckListBoxCompanies.DisplayMember = "PersonName";
            CheckListBoxCompanies.ValueMember = "Id";

            _companyLeftId = companyLeftId;
            _dbTableId = dbTableId;

            _filterCompanyApp = new FilterCompanyController(efc);

            SetValue();
        }

        private void SetValue()
        {
            var companiesRight = _filterCompanyApp.Search(c => c.CompanyLeftId == _companyLeftId && c.DbTableId == _dbTableId).ToList();

            foreach (var item in companiesRight)
            {
                var index = GetIndex(item.CompanyRight.Id);
                if (index < 0) continue;
                Checked(index);
            }
        }

        private int GetIndex(int itemId)
        {
            var itens = CheckListBoxCompanies.SComponent.Items;

            foreach (var itemC in itens)
            {
                var propertyId = itemC.GetType().GetProperty("Id");
                var id = (int)propertyId.GetValue(itemC);
                if (id == itemId)
                    return CheckListBoxCompanies.SComponent.Items.IndexOf(itemC);
            }

            return -1;
        }

        private void Checked(int index)
        {
            CheckListBoxCompanies.SComponent.SetItemChecked(index, true);
        }

        public override void ButtonActive_Click(object sender, RoutedEventArgs e)
        {
            base.ButtonActive_Click(sender, e);

            _filterCompanyApp.RemoveList(c => c.CompanyLeftId == _companyLeftId && c.DbTableId == _dbTableId);

            if (CheckListBoxCompanies.SComponent.CheckedItems.Count > 0)
            {
                foreach (var item in CheckListBoxCompanies.SComponent.CheckedItems)
                {
                    var propertyId = item.GetType().GetProperty("Id");
                    var id = (int)propertyId.GetValue(item);
                    Insert(id);
                }
                MessageBox.Show("Processo Concluído");
                Close();
            }
            else
            {
                Insert(_companyLeftId, false);
                MessageBox.Show("Processo Concluído, filtro desativado");
                Close();
            }
        }

        private void Insert(int companyRightId, bool active = true)
        {
            _filterCompanyApp.Save(new FilterCompany()
            {
                UserControlId = GlobalUser.User.Id,
                CompanyControlId = GlobalUser.Company.Id,
                DbTableId = _dbTableId,
                CompanyLeftId = _companyLeftId,
                CompanyRightId = companyRightId,
                Active = active
            });
        }

        public override void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            base.ButtonCancel_Click(sender, e);
            Close();
        }
    }
}