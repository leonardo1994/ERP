using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Catalog;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Catalog
{
    public class TableRepo : IFactoryCommand<Table>
    {
        private readonly IFactoryCommand<Table> _efcmd;

        public TableRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Table> efr = new DbContext<Table>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Table eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Table eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Table> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Table FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Table> Search(Expression<Func<Table, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Table> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Table> AsNoTracking(Expression<Func<Table, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Table> IFactoryCommand<Table>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Table> IFactoryCommand<Table>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Table>.SearchOfType<T>(Expression<Func<Table, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
