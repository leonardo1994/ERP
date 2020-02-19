using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using System.Linq;
using Esr.Module.Stock.Domain.Integration;

namespace Esr.Module.Stock.Repository.Integration
{
    public class IntegrationCapeStockRepo : IFactoryCommand<IntegrationCapeStock>
    {
        private readonly IFactoryCommand<IntegrationCapeStock> _efcmd;

        public IntegrationCapeStockRepo(IFactoryConnection efc)
        {
            IFactoryRepository<IntegrationCapeStock> efr = new DbContext<IntegrationCapeStock>();
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(IntegrationCapeStock eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(IntegrationCapeStock eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<IntegrationCapeStock> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public IntegrationCapeStock FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<IntegrationCapeStock> Search(Expression<Func<IntegrationCapeStock, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<IntegrationCapeStock> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<IntegrationCapeStock> AsNoTracking(Expression<Func<IntegrationCapeStock, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<IntegrationCapeStock> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<IntegrationCapeStock> IFactoryCommand<IntegrationCapeStock>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<IntegrationCapeStock>.SearchOfType<T>(Expression<Func<IntegrationCapeStock, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}