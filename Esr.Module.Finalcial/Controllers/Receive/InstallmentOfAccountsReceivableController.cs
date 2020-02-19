using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using System.Linq.Expressions;
using System;
using Esr.Module.Financial.App.Receive;
using Esr.Module.Financial.Domain.Receive;

namespace Esr.Module.Financial.Controllers.Receive
{
    public class InstallmentOfAccountsReceivableController
    {
        private InstallmentOfAccountsReceivableApp _InstallmentOfAccountsReceivableApp;
        private IFactoryConnection _connection;

        public InstallmentOfAccountsReceivableController(IFactoryConnection connection)
        {
            _connection = connection;
            _InstallmentOfAccountsReceivableApp = new InstallmentOfAccountsReceivableApp(connection);
        }

        public bool Save(InstallmentOfAccountsReceivable InstallmentOfAccountsReceivable)
        {
            _InstallmentOfAccountsReceivableApp.InsertOrUpdate(InstallmentOfAccountsReceivable);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _InstallmentOfAccountsReceivableApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _InstallmentOfAccountsReceivableApp.Remove(_InstallmentOfAccountsReceivableApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// InstallmentOfAccountsReceivables List
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.InstallmentOfAccountsReceivableName, c.Cnh }</returns>
        public IList ListInstallmentOfAccountsReceivable()
        {
            return _InstallmentOfAccountsReceivableApp.Search()
                .Select(c => new
                { c.Id, c.PortionNumber, c.ActualMaturity, c.NominalMaturity, c.PlotValue }).ToList();
        }

        public bool Remove(Expression<Func<InstallmentOfAccountsReceivable, bool>> expression)
        {
            _InstallmentOfAccountsReceivableApp.Remove(_InstallmentOfAccountsReceivableApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<InstallmentOfAccountsReceivable, bool>> expression)
        {
            return _InstallmentOfAccountsReceivableApp.Search(expression)
                .Select(c => new { c.PortionNumber, c.ActualMaturity, c.NominalMaturity, c.PlotValue })
                .ToList();
        }

        public InstallmentOfAccountsReceivable FindId(int id)
        {
            return _InstallmentOfAccountsReceivableApp.FindId(id);
        }
    }
}