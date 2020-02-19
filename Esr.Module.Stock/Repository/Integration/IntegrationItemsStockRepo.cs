using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using System.Linq;
using Esr.Module.Stock.Domain.Integration;

namespace Esr.Module.Stock.Repository.Integration
{
    public class IntegrationItemsStockRepo : IFactoryCommand<IntegrationItemsStock>
    {
        private readonly IFactoryCommand<IntegrationItemsStock> _efcmd;

        public IntegrationItemsStockRepo(IFactoryConnection efc)
        {
            IFactoryRepository<IntegrationItemsStock> efr = new DbContext<IntegrationItemsStock>();
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(IntegrationItemsStock eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(IntegrationItemsStock eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<IntegrationItemsStock> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public IntegrationItemsStock FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<IntegrationItemsStock> Search(Expression<Func<IntegrationItemsStock, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<IntegrationItemsStock> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<IntegrationItemsStock> AsNoTracking(Expression<Func<IntegrationItemsStock, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<IntegrationItemsStock> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<IntegrationItemsStock> IFactoryCommand<IntegrationItemsStock>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<IntegrationItemsStock>.SearchOfType<T>(Expression<Func<IntegrationItemsStock, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}