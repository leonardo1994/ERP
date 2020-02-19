using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Authentication;
using System.Collections.Generic;

namespace Esr.Core.App.Authentication
{
    public class UserCompanyApp
    {
        private readonly IFactoryCommand<UserCompany> _epr;

        public UserCompanyApp(IFactoryConnection efc)
        {
            _epr = new UserCompanyRepo(efc);
        }

        public UserCompany FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<UserCompany> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(UserCompany UserCompany)
        {
            return _epr.InsertOrUpdate(UserCompany);
        }

        public IQueryable<UserCompany> Search(Expression<Func<UserCompany, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<UserCompany> Search()
        {
            return _epr.Search();
        }

        #region Métodos Adicionais específicos
        /// <summary>
        /// Pesquisa empresas por usuários.
        /// </summary>
        /// <param name="condicao"></param>
        /// <returns>Code, PersonName, Cnpj, CompanyId, Id</returns>
        public IQueryable PesquisarEmpresas(Expression<Func<UserCompany, bool>> condicao)
        {
            return (from UserCompanyCompany in _epr.Search(condicao)
                    select new
                    {
                        UserCompanyCompany.Company.Code,
                        UserCompanyCompany.Company.PersonName,
                        Cnpj = UserCompanyCompany.Company.Cnpj,
                        UserCompanyCompany.CompanyId,
                        UserCompanyCompany.Id
                    });
        }
        /// <summary>
        /// Pesquisa todos os usuário por empresa.
        /// </summary>
        /// <param name="condicao"></param>
        /// <returns>UserCompanyName, Login, Id, UserCompanyId</returns>
        public IQueryable PesquisarUsuarios(Expression<Func<UserCompany, bool>> condicao)
        {
            return (from UserCompanyCompany in _epr.Search(condicao)
                    select new
                    {
                        UserCompanyCompany.User.UserName,
                        UserCompanyCompany.User.Login,
                        UserCompanyCompany.Id,
                        UserCompanyCompany.UserId
                    });
        }
        #endregion
    }
}