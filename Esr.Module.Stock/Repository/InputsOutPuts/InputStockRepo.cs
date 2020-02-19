using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using System.Data.Entity;
using System.Linq;
using Esr.Module.Stock.Domain.Movements;

namespace Esr.Module.Stock.Repository.InputsOutPuts
{
    public class InputStockRepo : IFactoryCommand<InputStock>
    {
        private readonly IFactoryCommand<InputStock> _efcmd;

        public InputStockRepo(IFactoryConnection efc)
        {
            IFactoryRepository<InputStock> efr = new DbContext<InputStock>();
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(InputStock eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(InputStock eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<InputStock> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public InputStock FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<InputStock> Search(Expression<Func<InputStock, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<InputStock> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<InputStock> AsNoTracking(Expression<Func<InputStock, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<InputStock> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<InputStock> IFactoryCommand<InputStock>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<InputStock>.SearchOfType<T>(Expression<Func<InputStock, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
