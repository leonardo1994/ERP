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
    public class FamilyRepo : IFactoryCommand<Family>
    {
        private readonly IFactoryCommand<Family> _efcmd;

        public FamilyRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Family> efr = new DbContext<Family>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Family eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Family eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Family> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Family FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Family> Search(Expression<Func<Family, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Family> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Family> AsNoTracking(Expression<Func<Family, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<Family> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IList<Family> IFactoryCommand<Family>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<Family> IFactoryCommand<Family>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<Family>.SearchOfType<T>(Expression<Func<Family, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
