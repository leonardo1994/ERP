using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.TaxManagement.Domain.Taxations;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.TaxManagement.Repository.Taxations
{
    public class TaxationRepo : IFactoryCommand<Taxation>
    {
        private readonly IFactoryCommand<Taxation> _efcmd;

        public TaxationRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Taxation> efr = new DbContext<Taxation>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Taxation eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Taxation eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Taxation> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Taxation FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Taxation> Search(Expression<Func<Taxation, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Taxation> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Taxation> AsNoTracking(Expression<Func<Taxation, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<Taxation> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Taxation> IFactoryCommand<Taxation>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Taxation>.SearchOfType<T>(Expression<Func<Taxation, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
