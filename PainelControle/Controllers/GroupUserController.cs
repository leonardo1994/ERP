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
    public class GroupUserController
    {
        private GroupUserApp _GroupUserApp;
        private IFactoryConnection _connection;

        public GroupUserController(IFactoryConnection connection)
        {
            _connection = connection;
            _GroupUserApp = new GroupUserApp(connection);
        }

        public IList Search(Expression<Func<GroupUser, bool>> expression)
        {
            return _GroupUserApp.Search(expression).ToList();
        }

        public bool Save(GroupUser GroupUser)
        {
            _GroupUserApp.InsertOrUpdate(GroupUser);
            return _connection.Save();
        }

        public bool Remove(int id)
        {
            _GroupUserApp.Remove(id);
            return _connection.Save();
        }

        public bool Remove(IList<int> listId)
        {
            _GroupUserApp.Remove(_GroupUserApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        public bool Remove(Expression<Func<GroupUser, bool>> expression)
        {
            _GroupUserApp.Remove(_GroupUserApp.Search(expression).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de empresas.
        /// </summary>
        /// <returns>{ c.Id, c.GroupAccess.Description, c.User.UserName }</returns>
        public IList ListGroupUser()
        {
            return _GroupUserApp.Search()
                .Select(c => new
                { c.Id, c.GroupAccess.Description, c.User.UserName }).ToList();
        }

        public IList ListGroupUser(Expression<Func<GroupUser, bool>> expression)
        {
            return _GroupUserApp.Search(expression)
                .Select(c => new
                { c.Id, c.GroupAccess.Description, c.User.UserName, c.GroupAccessId, c.UserId }).ToList();
        }

        public GroupUser FindId(int id)
        {
            return _GroupUserApp.FindId(id);
        }
    }
}