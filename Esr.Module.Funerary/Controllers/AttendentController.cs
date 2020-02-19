using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Module.Funerary.App.GroupAttendants;
using Esr.Module.Funerary.Domain.GroupAttendants;
using System;
using System.Linq.Expressions;

namespace Esr.Module.Funerary.Controllers
{
    public class AttendentController
    {
        private AttendantApp _AttendentApp;
        private IFactoryConnection _connection;

        public IList Search(Expression<Func<Attendant, bool>> expression)
        {
            return _AttendentApp.Search(expression).ToList();
        }

        public AttendentController(IFactoryConnection connection)
        {
            _connection = connection;
            _AttendentApp = new AttendantApp(connection);
        }

        public bool Save(Attendant Attendent)
        {
            _AttendentApp.InsertOrUpdate(Attendent);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _AttendentApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _AttendentApp.Remove(_AttendentApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Attendent List.
        /// </summary>
        /// <returns>{ c.Id, c.GroupAttendant.Title, c.User.Login }</returns>
        public IList ListAttendent()
        {
            return _AttendentApp.Search()
                .Select(c => new
                { c.Id, c.GroupAttendant.Title, c.User.Login }).ToList();
        }

        public bool Remove(Expression<Func<Attendant, bool>> expression)
        {
            _AttendentApp.Remove(_AttendentApp.Search(expression).ToList());
            return _connection.Save();
        }

        public Attendant FindId(int id)
        {
            return _AttendentApp.FindId(id);
        }
    }
}