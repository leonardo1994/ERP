using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Authentication
{
    public class PersonRepo : IFactoryCommand<Person>
    {
        private readonly IFactoryCommand<Person> _efcmd;

        public PersonRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Person> efr = new DbContext<Person>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Person eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Person eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Person> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Person FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Person> Search(Expression<Func<Person, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Person> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Person> AsNoTracking(Expression<Func<Person, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Person> IFactoryCommand<Person>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Person> IFactoryCommand<Person>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Person>.SearchOfType<T>(Expression<Func<Person, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
