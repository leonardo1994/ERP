using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Core.App.Queries;
using Esr.Core.Domain.Queries;
using Esr.Core.App.Authentication;
using Esr.Core.Domain.Authentication;
using System.Linq.Expressions;
using System;

namespace Esr.Module.ControlPainel.Controllers
{
    public class PermissionController
    {
        private PermissionApp _PermissionApp;
        private IFactoryConnection _connection;

        public PermissionController(IFactoryConnection connection)
        {
            _connection = connection;
            _PermissionApp = new PermissionApp(connection);
        }

        public bool Save(Permission Permission)
        {
            _PermissionApp.InsertOrUpdate(Permission);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _PermissionApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _PermissionApp.Remove(_PermissionApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Permission, bool>> expression)
        {
            return _PermissionApp.Search(expression).ToList();
        }

        /// <summary>
        /// Lista de Permissões
        /// </summary>
        /// <returns>{ c.Id, c.NamePermission, c.Insert, c.Update, c.Delete, c.Visible }</returns>
        public IList ListPermission()
        {
            return _PermissionApp.Search()
                .Select(c => new
                { c.Id, c.NamePermission, c.Insert, c.Update, c.Delete, c.Visible }).ToList();
        }

        public Permission FindId(int id)
        {
            return _PermissionApp.FindId(id);
        }

        public bool Remove(Expression<Func<Permission, bool>> expression)
        {
            _PermissionApp.Remove(_PermissionApp.Search(expression).ToList());
            return _connection.Save();
        }
    }
}