using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.StockItems;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class FamilyController
    {
        private FamilyApp _FamilyApp; 
        private IFactoryConnection _connection;

        public FamilyController(IFactoryConnection connection)
        {
            _connection = connection;
            _FamilyApp = new FamilyApp(connection);
        }
        
        public bool Save(Family Family)
        {
            _FamilyApp.InsertOrUpdate(Family);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _FamilyApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _FamilyApp.Remove(_FamilyApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Familys List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListFamily()
        {
            return _FamilyApp.Search()
                .Select(c => new
                { c.Id, c.FamilyCode, c.FamilyName }).ToList();
        }

        public bool Remove(Expression<Func<Family, bool>> expression)
        {
            _FamilyApp.Remove(_FamilyApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Family, bool>> expression)
        {
            return _FamilyApp.Search(expression).ToList();
        }

        public IList SearchAll()
        {
            return _FamilyApp.Search().ToList();
        }

        public Family FindId(int id)
        {
            return _FamilyApp.FindId(id);
        }
    }
}