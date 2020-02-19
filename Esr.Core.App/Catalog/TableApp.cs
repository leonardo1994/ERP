using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Catalog;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Catalog;

namespace Esr.Core.App.Catalog
{
    public class TableApp
    {
        private readonly IFactoryCommand<Table> _epr;

        public TableApp(IFactoryConnection efc)
        {
            _epr = new TableRepo(efc);
        }

        public Table FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Table> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Table Table)
        {
            return _epr.InsertOrUpdate(Table);
        }

        public IQueryable<Table> Search(Expression<Func<Table, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Table> Search()
        {
            return _epr.Search();
        }
    }
}