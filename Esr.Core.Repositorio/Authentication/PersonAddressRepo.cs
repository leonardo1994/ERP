using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Authentication
{
    public class PersonAddressRepo : IFactoryCommand<PersonAddress>
    {
        private readonly IFactoryCommand<PersonAddress> _efcmd;

        public PersonAddressRepo(IFactoryConnection efc)
        {
            IFactoryRepository<PersonAddress> efr = new DbContext<PersonAddress>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(PersonAddress eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(PersonAddress eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<PersonAddress> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public PersonAddress FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<PersonAddress> Search(Expression<Func<PersonAddress, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<PersonAddress> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<PersonAddress> AsNoTracking(Expression<Func<PersonAddress, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<PersonAddress> IFactoryCommand<PersonAddress>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<PersonAddress> IFactoryCommand<PersonAddress>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<PersonAddress>.SearchOfType<T>(Expression<Func<PersonAddress, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
