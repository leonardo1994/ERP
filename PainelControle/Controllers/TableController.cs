using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Core.App.Catalog;
using Esr.Core.Domain.Catalog;
using System.Linq.Expressions;
using System;

namespace Esr.Module.ControlPainel.Controllers
{
    public class TableController
    {
        private TableApp _TableApp;
        private IFactoryConnection _connection;

        public TableController(IFactoryConnection connection)
        {
            _connection = connection;
            _TableApp = new TableApp(connection);
        }

        public bool Save(Table Table)
        {
            _TableApp.InsertOrUpdate(Table);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _TableApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _TableApp.Remove(_TableApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de Tables
        /// </summary>
        /// <returns>{ c.Id, c.TableName, c.DescriptionForm }</returns>
        public IList ListTable()
        {
            return _TableApp.Search()
                .Select(c => new
                { c.Id, c.TableName, DescriptionForm = c.TableName + " - " + c.DescriptionForm }).ToList();
        }

        public Table FindId(int id)
        {
            return _TableApp.FindId(id);
        }

        public IList Search(Expression<Func<Table, bool>> expression)
        {
            return _TableApp.Search(expression).ToList();
        }

        public bool Remove(Expression<Func<Table, bool>> expression)
        {
            _TableApp.Remove(_TableApp.Search(expression).ToList());
            return _connection.Save();
        }
    }
}