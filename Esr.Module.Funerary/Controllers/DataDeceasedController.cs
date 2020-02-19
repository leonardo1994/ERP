using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Module.Funerary.App.DataDeceaseds;
using Esr.Module.Funerary.Domain.DataDeceaseds;
using System.Linq.Expressions;
using System;

namespace Esr.Module.Funerary.Controllers
{
    public class DataDeceasedController
    {
        private DataDeceasedApp _DataDeceasedApp;
        private IFactoryConnection _connection;

        public DataDeceasedController(IFactoryConnection connection)
        {
            _connection = connection;
            _DataDeceasedApp = new DataDeceasedApp(connection);
        }

        public bool Save(DataDeceased DataDeceased)
        {
            _DataDeceasedApp.InsertOrUpdate(DataDeceased);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _DataDeceasedApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _DataDeceasedApp.Remove(_DataDeceasedApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// DataDeceased List.
        /// </summary>
        /// <returns>{ c.Id, c.FalecidoNome, c.FalecidoCpf }</returns>
        public IList ListDataDeceased()
        {
            return _DataDeceasedApp.Search()
                .Select(c => new
                { c.Id, c.FalecidoNome, c.FalecidoCpf }).ToList();
        }

        public bool Remove(Expression<Func<DataDeceased, bool>> expression)
        {
            _DataDeceasedApp.Remove(_DataDeceasedApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<DataDeceased, bool>> expression)
        {
            return _DataDeceasedApp.Search(expression).ToList();
        }

        public DataDeceased FindId(int id)
        {
            return _DataDeceasedApp.FindId(id);
        }
    }
}