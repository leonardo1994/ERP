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
    public class ModelController
    {
        private ModelApp _ModelApp;
        private IFactoryConnection _connection;

        public ModelController(IFactoryConnection connection)
        {
            _connection = connection;
            _ModelApp = new ModelApp(connection);
        }

        public bool Save(Model Model)
        {
            _ModelApp.InsertOrUpdate(Model);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ModelApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ModelApp.Remove(_ModelApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Models List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListModel()
        {
            return _ModelApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.Description }).ToList();
        }

        public bool Remove(Expression<Func<Model, bool>> expression)
        {
            _ModelApp.Remove(_ModelApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Model, bool>> expression)
        {
            return _ModelApp.Search(expression).ToList();
        }

        public Model FindId(int id)
        {
            return _ModelApp.FindId(id);
        }
    }
}