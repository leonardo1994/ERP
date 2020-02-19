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
    public class FeaturedNcmRepo : IFactoryCommand<FeaturedNcm>
    {
        private readonly IFactoryCommand<FeaturedNcm> _efcmd;

        public FeaturedNcmRepo(IFactoryConnection efc)
        {
            IFactoryRepository<FeaturedNcm> efr = new DbContext<FeaturedNcm>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(FeaturedNcm eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(FeaturedNcm eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<FeaturedNcm> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public FeaturedNcm FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<FeaturedNcm> Search(Expression<Func<FeaturedNcm, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<FeaturedNcm> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<FeaturedNcm> AsNoTracking(Expression<Func<FeaturedNcm, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<FeaturedNcm> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IList<FeaturedNcm> IFactoryCommand<FeaturedNcm>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<FeaturedNcm> IFactoryCommand<FeaturedNcm>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<FeaturedNcm>.SearchOfType<T>(Expression<Func<FeaturedNcm, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
