using Esr.Core.Domain.Authentication;
using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.App.Authentication;
using System.Collections;
using Esr.Module.FleetManagement.App.Drives;
using Esr.Module.FleetManagement.Domain.Drives;
using System.Linq.Expressions;
using System;

namespace Esr.Module.FleetManagement.Controllers
{
    public class DriveController
    {
        private DriveApp _DriveApp;
        private IFactoryConnection _connection;

        public DriveController(IFactoryConnection connection)
        {
            _connection = connection;
            _DriveApp = new DriveApp(connection);
        }

        public bool Save(Drive Drive)
        {
            _DriveApp.InsertOrUpdate(Drive);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _DriveApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _DriveApp.Remove(_DriveApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Drives List
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.DriveName, c.Cnh }</returns>
        public IList ListDrive()
        {
            return _DriveApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.DriveName, c.Cnh }).ToList();
        }

        public bool Remove(Expression<Func<Drive, bool>> expression)
        {
            _DriveApp.Remove(_DriveApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Drive, bool>> expression)
        {
            return _DriveApp.Search(expression).ToList();
        }

        public Drive FindId(int id)
        {
            return _DriveApp.FindId(id);
        }
    }
}
