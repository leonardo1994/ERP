using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Domain.ConfNumbering;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.ConfNumbering
{
    public class AutomaticNumberingRepo : IFactoryCommand<AutomaticNumbering>
    {
        private readonly IFactoryCommand<AutomaticNumbering> _efcmd;

        public AutomaticNumberingRepo(IFactoryConnection efc)
        {
            IFactoryRepository<AutomaticNumbering> efr = new DbContext<AutomaticNumbering>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(AutomaticNumbering eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(AutomaticNumbering eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<AutomaticNumbering> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public AutomaticNumbering FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<AutomaticNumbering> Search(Expression<Func<AutomaticNumbering, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<AutomaticNumbering> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<AutomaticNumbering> AsNoTracking(Expression<Func<AutomaticNumbering, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<AutomaticNumbering> IFactoryCommand<AutomaticNumbering>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<AutomaticNumbering> IFactoryCommand<AutomaticNumbering>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<AutomaticNumbering>.SearchOfType<T>(Expression<Func<AutomaticNumbering, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
