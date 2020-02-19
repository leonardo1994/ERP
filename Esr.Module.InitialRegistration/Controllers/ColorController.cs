using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.Colors;
using Esr.Module.InitialRegistration.Domain.Colors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class ColorController
    {
        private ColorApp _ColorApp; 
        private IFactoryConnection _connection;

        public ColorController(IFactoryConnection connection)
        {
            _connection = connection;
            _ColorApp = new ColorApp(connection);
        }
        
        public bool Save(Color Color)
        {
            _ColorApp.InsertOrUpdate(Color);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ColorApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ColorApp.Remove(_ColorApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Colors List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListColor()
        {
            return _ColorApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.Description }).ToList();
        }

        public bool Remove(Expression<Func<Color, bool>> expression)
        {
            _ColorApp.Remove(_ColorApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Color, bool>> expression)
        {
            return _ColorApp.Search(expression).ToList();
        }

        public Color FindId(int id)
        {
            return _ColorApp.FindId(id);
        }
    }
}