using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Domain.FiltersCompanies;
using Esr.Core.Repository.FiltersCompanies;

namespace Esr.Core.App.FiltersCompanies
{
    public class DbTableApp
    {
        private readonly IFactoryCommand<DbTable> _epr;

        public DbTableApp(IFactoryConnection efc)
        {
            _epr = new DbTableRepo(efc);
        }

        public DbTable FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<DbTable> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(DbTable DbTable)
        {
            return _epr.InsertOrUpdate(DbTable);
        }

        public IQueryable<DbTable> Search(Expression<Func<DbTable, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<DbTable> Search()
        {
            return _epr.Search();
        }
    }
}