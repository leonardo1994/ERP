using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Address;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Address
{
    public class CityRepo : IFactoryCommand<City>
    {
        private readonly IFactoryCommand<City> _efcmd;

        public CityRepo(IFactoryConnection efc)
        {
            IFactoryRepository<City> efr = new DbContext<City>();
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(City eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(City eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<City> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public City FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<City> Search(Expression<Func<City, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<City> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<City> AsNoTracking(Expression<Func<City, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<City> IFactoryCommand<City>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<City> IFactoryCommand<City>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<City>.SearchOfType<T>(Expression<Func<City, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
