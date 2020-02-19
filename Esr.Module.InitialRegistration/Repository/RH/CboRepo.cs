using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.InitialRegistration.Domain.RH;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.InitialRegistration.Repository.RH
{
    public class CboRepo : IFactoryCommand<Cbo>
    {
        private readonly IFactoryCommand<Cbo> _efcmd;

        public CboRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Cbo> efr = new DbContext<Cbo>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Cbo eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Cbo eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Cbo> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Cbo FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Cbo> Search(Expression<Func<Cbo, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Cbo> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Cbo> AsNoTracking(Expression<Func<Cbo, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }


        IList<Cbo> IFactoryCommand<Cbo>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<Cbo> IFactoryCommand<Cbo>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<Cbo>.SearchOfType<T>(Expression<Func<Cbo, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
