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
    public class FunctionRepo : IFactoryCommand<Function>
    {
        private readonly IFactoryCommand<Function> _efcmd;

        public FunctionRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Function> efr = new DbContext<Function>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Function eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Function eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Function> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Function FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Function> Search(Expression<Func<Function, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Function> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Function> AsNoTracking(Expression<Func<Function, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Function> IFactoryCommand<Function>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<Function> IFactoryCommand<Function>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<Function>.SearchOfType<T>(Expression<Func<Function, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
