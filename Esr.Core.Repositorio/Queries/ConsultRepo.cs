using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Queries
{
    public class ConsultRepo : IFactoryCommand<Consult>
    {
        private readonly IFactoryCommand<Consult> _efcmd;

        public ConsultRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Consult> efr = new DbContext<Consult>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Consult eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Consult eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Consult> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Consult FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Consult> Search(Expression<Func<Consult, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Consult> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Consult> AsNoTracking(Expression<Func<Consult, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Consult> IFactoryCommand<Consult>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Consult> IFactoryCommand<Consult>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Consult>.SearchOfType<T>(Expression<Func<Consult, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
