using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Address;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Address
{
    public class CountryRepo : IFactoryCommand<Country>
    {
        private readonly IFactoryCommand<Country> _efcmd;

        public CountryRepo(IFactoryConnection connection)
        {
            IFactoryRepository<Country> efr = new DbContext<Country>();
            _efcmd = efr.FactoryCommand(connection);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Country eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Country eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Country> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Country FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Country> Search(Expression<Func<Country, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Country> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Country> AsNoTracking(Expression<Func<Country, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Country> IFactoryCommand<Country>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Country> IFactoryCommand<Country>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Country>.SearchOfType<T>(Expression<Func<Country, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
