using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Core.App.Authentication;
using Esr.Core.Domain.Authentication;
using System.Linq.Expressions;
using System;

namespace Esr.Module.ControlPainel.Controllers
{
    public class GroupPermissionController
    {
        private GroupPermissionApp _GroupPermissionApp;
        private IFactoryConnection _connection;

        public GroupPermissionController(IFactoryConnection connection)
        {
            _connection = connection;
            _GroupPermissionApp = new GroupPermissionApp(connection);
        }

        public bool Save(GroupPermission GroupPermission)
        {
            _GroupPermissionApp.InsertOrUpdate(GroupPermission);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _GroupPermissionApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _GroupPermissionApp.Remove(_GroupPermissionApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de GroupPermissions
        /// </summary>
        /// <returns>{ c.Id, c.Description, c.Title}</returns>
        public IList ListGroupPermission()
        {
            return _GroupPermissionApp.Search()
                .Select(c => new
                { c.Id, c.GroupAccessId, c.PermissionId, c.GroupAccess.Description, c.Permission.NamePermission }).ToList();
        }

        public IList ListPermission(Expression<Func<GroupPermission, bool>> expression)
        {
            return _GroupPermissionApp
                .Search(expression)
                .Select(c => new
                {
                    c.Id,
                    c.PermissionId,
                    c.GroupAccessId,
                    c.Permission.NamePermission,
                    c.Permission.Insert,
                    c.Permission.Delete,
                    c.Permission.Update,
                    c.Permission.Visible
               }).ToList();
        }

        public GroupPermission FindId(int id)
        {
            return _GroupPermissionApp.FindId(id);
        }

        public bool Remove(Expression<Func<GroupPermission, bool>> expression)
        {
            _GroupPermissionApp.Remove(_GroupPermissionApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<GroupPermission, bool>> expression)
        {
            return _GroupPermissionApp.Search(expression).ToList();
        }
    }
}