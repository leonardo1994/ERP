using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.Religions;
using System.Data.Entity;
using System.Linq;
using Esr.Core.Repository;

namespace Esr.Module.Funerary.Repository.Religions
{
    public class ReligionRepo : IFactoryCommand<Religion>
    {
        private readonly IFactoryCommand<Religion> _efcmd;

        public ReligionRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Religion> efr = new DbContext<Religion>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Religion eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Religion eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Religion> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Religion FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Religion> Search(Expression<Func<Religion, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Religion> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Religion> AsNoTracking(Expression<Func<Religion, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Religion> IFactoryCommand<Religion>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Religion> IFactoryCommand<Religion>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType(expression);
        }

        IQueryable<T> IFactoryCommand<Religion>.SearchOfType<T>(Expression<Func<Religion, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
