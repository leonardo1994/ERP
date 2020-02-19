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
    public class NcmRepo : IFactoryCommand<Ncm>
    {
        private readonly IFactoryCommand<Ncm> _efcmd;

        public NcmRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Ncm> efr = new DbContext<Ncm>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Ncm eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Ncm eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Ncm> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Ncm FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Ncm> Search(Expression<Func<Ncm, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Ncm> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Ncm> AsNoTracking(Expression<Func<Ncm, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<Ncm> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IList<Ncm> IFactoryCommand<Ncm>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Ncm> IFactoryCommand<Ncm>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<Ncm>.SearchOfType<T>(Expression<Func<Ncm, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
