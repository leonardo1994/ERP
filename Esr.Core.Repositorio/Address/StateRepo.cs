using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Address;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Address
{
    public class StateRepo : IFactoryCommand<State>
    {
        private readonly IFactoryCommand<State> _efcmd;

        public StateRepo(IFactoryConnection efc)
        {
            IFactoryRepository<State> efr = new DbContext<State>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(State eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(State eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<State> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public State FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<State> Search(Expression<Func<State, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<State> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<State> AsNoTracking(Expression<Func<State, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<State> IFactoryCommand<State>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<State> IFactoryCommand<State>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<State>.SearchOfType<T>(Expression<Func<State, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
