using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.App.ConfNumbering;
using Esr.Core.Domain.ConfNumbering;
using Esr.Core.Domain.RepositoryFactory;
using System.Linq;
using System.Collections;

namespace Esr.Module.ControlPainel.Controllers
{
    public class ConfAutNumeringController
    {
        private AutomaticNumberingApp _automaticNumberingApp;
        private IFactoryConnection _connection;

        public ConfAutNumeringController(IFactoryConnection connection)
        {
            _connection = connection;
            _automaticNumberingApp = new AutomaticNumberingApp(connection);
        }

        public bool Save(AutomaticNumbering automaticNumbering)
        {
            _automaticNumberingApp.InsertOrUpdate(automaticNumbering);
            return _connection.Save();
        }

        public bool Remove(Expression<Func<AutomaticNumbering, bool>> expression)
        {
            _automaticNumberingApp.Remove(_automaticNumberingApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<AutomaticNumbering, bool>> expression)
        {
            return _automaticNumberingApp.Search(expression).ToList();
        } 

        public bool RemoveId(int id)
        {
            _automaticNumberingApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _automaticNumberingApp.Remove(_automaticNumberingApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de númeração automática.
        /// </summary>
        /// <returns>{ c.Id, c.Table.TableName, c.FieldName, c.Sequence, c.NextNumber }</returns>
        public IList ListAutomaticNumering()
        {
            return _automaticNumberingApp.Search()
                .Select(c => new
                { c.Id, c.DbTable.TableName, c.FieldName, c.Sequence, c.NextNumber , c.Integration }).ToList();
        }

        public AutomaticNumbering FindId(int id)
        {
            return _automaticNumberingApp.FindId(id);
        }
    }
}
