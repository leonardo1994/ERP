using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using Esr.Core.Domain.FiltersCompanies;
using System.Linq;

namespace Esr.Core.Repository.FiltersCompanies
{
    public class DbTableRepo : IFactoryCommand<DbTable>
    {
        private readonly IFactoryCommand<DbTable> _efcmd;

        public DbTableRepo(IFactoryConnection efc)
        {
            IFactoryRepository<DbTable> efr = new DbContext<DbTable>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(DbTable eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(DbTable eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<DbTable> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public DbTable FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<DbTable> Search(Expression<Func<DbTable, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<DbTable> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<DbTable> AsNoTracking(Expression<Func<DbTable, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<DbTable> IFactoryCommand<DbTable>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<DbTable> IFactoryCommand<DbTable>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<DbTable>.SearchOfType<T>(Expression<Func<DbTable, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
