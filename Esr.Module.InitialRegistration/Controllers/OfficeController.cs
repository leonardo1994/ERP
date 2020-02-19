using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.RH;
using Esr.Module.InitialRegistration.Domain.RH;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class OfficeController
    {
        private OfficeApp _OfficeApp; 
        private IFactoryConnection _connection;

        public OfficeController(IFactoryConnection connection)
        {
            _connection = connection;
            _OfficeApp = new OfficeApp(connection);
        }
        
        public bool Save(Office Office)
        {
            _OfficeApp.InsertOrUpdate(Office);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _OfficeApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _OfficeApp.Remove(_OfficeApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Offices List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListOffice()
        {
            return _OfficeApp.Search()
                .Select(c => new
                { c.Id, c.OfficeCode, c.OfficeName }).ToList();
        }

        public bool Remove(Expression<Func<Office, bool>> expression)
        {
            _OfficeApp.Remove(_OfficeApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Office, bool>> expression)
        {
            return _OfficeApp.Search(expression).ToList();
        }

        public Office FindId(int id)
        {
            return _OfficeApp.FindId(id);
        }
    }
}