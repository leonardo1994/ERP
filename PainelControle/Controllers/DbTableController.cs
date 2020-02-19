using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using System.Linq.Expressions;
using System;
using Esr.Core.App.FiltersCompanies;
using Esr.Core.Domain.FiltersCompanies;

namespace Esr.Module.ControlPainel.Controllers
{
    public class DbTableController
    {
        private DbTableApp _DbTableApp;

        private IFactoryConnection _connection;

        public DbTableController(IFactoryConnection connection)
        {
            _connection = connection;
            _DbTableApp = new DbTableApp(connection);
        }

        public bool Save(DbTable DbTable)
        {
            _DbTableApp.InsertOrUpdate(DbTable);
            return _connection.Save();
        }

        public bool Remove(Expression<Func<DbTable, bool>> expression)
        {
            var companies = _DbTableApp.Search(expression).ToList();
            _DbTableApp.Remove(companies);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _DbTableApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _DbTableApp.Remove(_DbTableApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de empresas.
        /// </summary>
        /// <returns>{ c.Id, c.PersonName, c.Cnpj, c.City.CityName, c.State.StateName, c.Country.CountryName }</returns>
        public IList ListDbTable()
        {
            return _DbTableApp.Search()
                .Select(c => new
                { c.Id, c.Integration, c.TableName, c.TableDescription }).ToList();
        }

        public IList Search(Expression<Func<DbTable, bool>> expression)
        {
            return _DbTableApp.Search(expression).ToList();
        }

        public DbTable FindId(int id)
        {
            return _DbTableApp.FindId(id);
        }
    }
}