using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Domain.Translation;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Translation
{
    public class TranslateRepo : IFactoryCommand<Translate>
    {
        private readonly IFactoryCommand<Translate> _efcmd;

        public TranslateRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Translate> efr = new DbContext<Translate>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Translate eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Translate eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Translate> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Translate FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Translate> Search(Expression<Func<Translate, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Translate> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Translate> AsNoTracking(Expression<Func<Translate, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Translate> IFactoryCommand<Translate>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Translate> IFactoryCommand<Translate>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Translate>.SearchOfType<T>(Expression<Func<Translate, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
