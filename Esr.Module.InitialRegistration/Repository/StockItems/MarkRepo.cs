using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.InitialRegistration.Repository.StockItems
{
    public class MarkRepo : IFactoryCommand<Mark>
    {
        private readonly IFactoryCommand<Mark> _efcmd;

        public MarkRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Mark> efr = new DbContext<Mark>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Mark eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Mark eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Mark> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Mark FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Mark> Search(Expression<Func<Mark, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Mark> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Mark> AsNoTracking(Expression<Func<Mark, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<Mark> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IList<Mark> IFactoryCommand<Mark>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<Mark> IFactoryCommand<Mark>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<Mark>.SearchOfType<T>(Expression<Func<Mark, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
