using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Core.App.Authentication;
using Esr.Core.Domain.Authentication;
using System.Data.Entity;
using System;
using System.Linq.Expressions;

namespace Esr.Module.ControlPainel.Controllers
{
    public class UserController
    {
        private UserApp _UserApp;
        private IFactoryConnection _connection;

        public UserController(IFactoryConnection connection)
        {
            _connection = connection;
            _UserApp = new UserApp(connection);
        }

        public User FindId(int id)
        {
            var user = _UserApp.FindId(id);
            user.PasswordCompare = user.Password;
            return user;
        }

        public bool Save(User User)
        {
            _UserApp.InsertOrUpdate(User);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _UserApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _UserApp.Remove(_UserApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        public bool Remove(Expression<Func<User, bool>> expression)
        {
            _UserApp.Remove(_UserApp.Search(expression).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de Users
        /// </summary>
        /// <returns>{ c.Id, c.UserName, c.Login, c.IsAdministrator, c.AccessAllCompanies }</returns>
        public IList ListUser()
        {
            return _UserApp.Search()
                .Select(c => new
                { c.Id, c.UserName, c.Login, c.IsAdministrator, c.AccessAllCompanies }).ToList();
        }

        /// <summary>
        /// Lista de Users
        /// </summary>
        /// <returns>{ c.Id, c.UserName, c.Login, c.IsAdministrator, c.AccessAllCompanies }</returns>
        public IList<User> Search(Expression<Func<User, bool>> expression)
        {
            var listUser = _UserApp.Search(expression).ToList();
            listUser.ForEach(c => c.PasswordCompare = c.Password);
            return listUser;
        }

        public User FindUser(string login, string password)
        {
            return _UserApp.Search(c => c.Login == login && c.Password == password)
                .Include(d => d.GroupUsers.Select(e => e.GroupAccess.GroupPermissions.Select(f => f.Permission)))
                .Include(d => d.UsersCompanies)
                .FirstOrDefault();
        }
    }
}