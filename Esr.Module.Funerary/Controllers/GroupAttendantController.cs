using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Module.Funerary.App.GroupAttendants;
using Esr.Module.Funerary.Domain.GroupAttendants;
using System.Linq.Expressions;
using System;

namespace Esr.Module.Funerary.Controllers
{
    public class GroupAttendantController
    {
        private GroupAttendantApp _GroupAttendantApp;
        private IFactoryConnection _connection;

        public GroupAttendantController(IFactoryConnection connection)
        {
            _connection = connection;
            _GroupAttendantApp = new GroupAttendantApp(connection);
        }

        public IList Search(Expression<Func<GroupAttendant, bool>> expression)
        {
            return _GroupAttendantApp.Search(expression).ToList();
        }

        public bool Save(GroupAttendant GroupAttendant)
        {
            _GroupAttendantApp.InsertOrUpdate(GroupAttendant);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _GroupAttendantApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _GroupAttendantApp.Remove(_GroupAttendantApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// GroupAttendant List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Title }</returns>
        public IList ListGroupAttendant()
        {
            return _GroupAttendantApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.Title }).ToList();
        }

        public bool Remove(Expression<Func<GroupAttendant, bool>> expression)
        {
            _GroupAttendantApp.Remove(_GroupAttendantApp.Search(expression).ToList());
            return _connection.Save();
        }

        public GroupAttendant FindId(int id)
        {
            return _GroupAttendantApp.FindId(id);
        }
    }
}