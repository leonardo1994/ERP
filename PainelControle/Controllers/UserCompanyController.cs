using Esr.Core.Domain.Authentication;
using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.App.Authentication;
using System.Collections;
using System.Linq.Expressions;
using System;

namespace Esr.Module.ControlPainel.Controllers
{
    public class UserCompanyController
    {
        private UserCompanyApp _UserCompanyApp;
        private IFactoryConnection _connection;

        public UserCompanyController(IFactoryConnection connection)
        {
            _connection = connection;
            _UserCompanyApp = new UserCompanyApp(connection);
        }

        public bool Save(UserCompany UserCompany)
        {
            _UserCompanyApp.InsertOrUpdate(UserCompany);
            return _connection.Save();
        }

        public bool Remove(int id)
        {
            _UserCompanyApp.Remove(id);
            return _connection.Save();
        }

        public bool Remove(IList<int> listId)
        {
            _UserCompanyApp.Remove(_UserCompanyApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        public bool Remove(Expression<Func<UserCompany, bool>> expression)
        {
            _UserCompanyApp.Remove(_UserCompanyApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<UserCompany, bool>> expression)
        {
            return _UserCompanyApp.Search(expression).ToList();
        }

        public IList CompaniesSearch(Expression<Func<UserCompany, bool>> expression)
        {
            return _UserCompanyApp.Search(expression)
                .Select(c => new { c.Id, c.Company.PersonName, c.Company.Cnpj }).ToList();
        }

        public UserCompany FindId(int id)
        {
            return _UserCompanyApp.FindId(id);
        }
    }
}