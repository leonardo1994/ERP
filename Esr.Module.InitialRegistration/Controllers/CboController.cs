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
    public class CboController
    {
        private CboApp _CboApp; 
        private IFactoryConnection _connection;

        public CboController(IFactoryConnection connection)
        {
            _connection = connection;
            _CboApp = new CboApp(connection);
        }
        
        public bool Save(Cbo Cbo)
        {
            _CboApp.InsertOrUpdate(Cbo);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _CboApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _CboApp.Remove(_CboApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Cbos List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListCbo()
        {
            return _CboApp.Search()
                .Select(c => new
                { c.Id, c.CboCode, c.CboDescription }).ToList();
        }

        public bool Remove(Expression<Func<Cbo, bool>> expression)
        {
            _CboApp.Remove(_CboApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Cbo, bool>> expression)
        {
            return _CboApp.Search(expression).ToList();
        }

        public Cbo FindId(int id)
        {
            return _CboApp.FindId(id);
        }
    }
}