using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using System.Data.Entity;
using System.Linq;
using Esr.Module.Stock.Domain.Movements;
using Esr.Core.Domain.ClassBase;

namespace Esr.Module.Stock.Repository.InputsOutPuts
{
    public class OutputStockRepo : IFactoryCommand<OutputStock>
    {
        private readonly IFactoryCommand<OutputStock> _efcmd;
        private readonly IFactoryConnection _conn;

        public OutputStockRepo(IFactoryConnection efc)
        {
            IFactoryRepository<OutputStock> efr = new DbContext<OutputStock>();
            _conn = efc;
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(OutputStock eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(OutputStock eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<OutputStock> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public OutputStock FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<OutputStock> Search(Expression<Func<OutputStock, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<OutputStock> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<OutputStock> AsNoTracking(Expression<Func<OutputStock, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<OutputStock> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<OutputStock> IFactoryCommand<OutputStock>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<OutputStock>.SearchOfType<T>(Expression<Func<OutputStock, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
