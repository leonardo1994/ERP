using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Queries
{
    public class QueryRepo : IFactoryCommand<Query>
    {
        private readonly IFactoryCommand<Query> _efcmd;

        public QueryRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Query> efr = new DbContext<Query>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Query eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Query eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Query> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Query FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Query> Search(Expression<Func<Query, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Query> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Query> AsNoTracking(Expression<Func<Query, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Query> IFactoryCommand<Query>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Query> IFactoryCommand<Query>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Query>.SearchOfType<T>(Expression<Func<Query, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
