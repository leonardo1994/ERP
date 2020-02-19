using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Core.App.Authentication;
using Esr.Core.Domain.Authentication;
using System;
using System.Linq.Expressions;

namespace Esr.Module.ControlPainel.Controllers
{
    public class GroupAccessController
    {
        private GroupAccessApp _GroupAccessApp;
        private IFactoryConnection _connection;

        public GroupAccessController(IFactoryConnection connection)
        {
            _connection = connection;
            _GroupAccessApp = new GroupAccessApp(connection);
        }

        public IList Search(Expression<Func<GroupAccess, bool>> expression)
        {
            return _GroupAccessApp.Search(expression).ToList();
        }

        public bool Save(GroupAccess GroupAccess)
        {
            _GroupAccessApp.InsertOrUpdate(GroupAccess);
            return _connection.Save();
        }

        public bool Remove(Expression<Func<GroupAccess, bool>> expression)
        {
            _GroupAccessApp.Remove(_GroupAccessApp.Search(expression).ToList());
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _GroupAccessApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _GroupAccessApp.Remove(_GroupAccessApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de GroupAccesss
        /// </summary>
        /// <returns>{ c.Id, c.Description, c.Title}</returns>
        public IList ListGroupAccess()
        {
            return _GroupAccessApp.Search()
                .Select(c => new
                { c.Id, c.Description, c.Title, c.Integration }).ToList();
        }

        public GroupAccess FindId(int id)
        {
            return _GroupAccessApp.FindId(id);
        }
    }
}