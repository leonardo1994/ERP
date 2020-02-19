using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using System.Linq.Expressions;
using System;
using Esr.Module.Financial.Domain.Pay;
using Esr.Module.Financial.App.Pay;

namespace Esr.Module.Financial.Controllers.Pay
{
    public class InstallmentsOfAccountsPayableController
    {
        private InstallmentsOfAccountsPayableApp _InstallmentsOfAccountsPayableApp;
        private IFactoryConnection _connection;

        public InstallmentsOfAccountsPayableController(IFactoryConnection connection)
        {
            _connection = connection;
            _InstallmentsOfAccountsPayableApp = new InstallmentsOfAccountsPayableApp(connection);
        }

        public bool Save(InstallmentsOfAccountsPayable InstallmentsOfAccountsPayable)
        {
            _InstallmentsOfAccountsPayableApp.InsertOrUpdate(InstallmentsOfAccountsPayable);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _InstallmentsOfAccountsPayableApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _InstallmentsOfAccountsPayableApp.Remove(_InstallmentsOfAccountsPayableApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// InstallmentsOfAccountsPayables List
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.InstallmentsOfAccountsPayableName, c.Cnh }</returns>
        public IList ListInstallmentsOfAccountsPayable()
        {
            return _InstallmentsOfAccountsPayableApp.Search()
                .Select(c => new
                { c.Id, c.PortionNumber, c.ActualMaturity, c.NominalMaturity, c.PlotValue }).ToList();
        }

        public bool Remove(Expression<Func<InstallmentsOfAccountsPayable, bool>> expression)
        {
            _InstallmentsOfAccountsPayableApp.Remove(_InstallmentsOfAccountsPayableApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<InstallmentsOfAccountsPayable, bool>> expression)
        {
            return _InstallmentsOfAccountsPayableApp.Search(expression)
                .Select(c => new { c.PortionNumber, c.ActualMaturity, c.NominalMaturity, c.PlotValue })
                .ToList();
        }

        public InstallmentsOfAccountsPayable FindId(int id)
        {
            return _InstallmentsOfAccountsPayableApp.FindId(id);
        }
    }
}