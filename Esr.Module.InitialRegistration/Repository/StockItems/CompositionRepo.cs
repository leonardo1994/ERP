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
    public class CompositionRepo : IFactoryCommand<Composition>
    {
        private readonly IFactoryCommand<Composition> _efcmd;

        public CompositionRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Composition> efr = new DbContext<Composition>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Composition eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Composition eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Composition> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Composition FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Composition> Search(Expression<Func<Composition, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Composition> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Composition> AsNoTracking(Expression<Func<Composition, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<Composition> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IList<Composition> IFactoryCommand<Composition>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<Composition> IFactoryCommand<Composition>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<Composition>.SearchOfType<T>(Expression<Func<Composition, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
