using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Module.Funerary.App.Religions;
using Esr.Module.Funerary.Domain.Religions;
using System.Linq.Expressions;
using System;

namespace Esr.Module.Funerary.Controllers
{
    public class ReligionController
    {
        private ReligionApp _ReligionApp;
        private IFactoryConnection _connection;

        public ReligionController(IFactoryConnection connection)
        {
            _connection = connection;
            _ReligionApp = new ReligionApp(connection);
        }

        public bool Save(Religion Religion)
        {
            _ReligionApp.InsertOrUpdate(Religion);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ReligionApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ReligionApp.Remove(_ReligionApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Religion List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListReligion()
        {
            return _ReligionApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.Description }).ToList();
        }

        public bool Remove(Expression<Func<Religion, bool>> expression)
        {
            _ReligionApp.Remove(_ReligionApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Religion, bool>> expression)
        {
            return _ReligionApp.Search(expression).ToList();
        }

        public Religion FindId(int id)
        {
            return _ReligionApp.FindId(id);
        }
    }
}