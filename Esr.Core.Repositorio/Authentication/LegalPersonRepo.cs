using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Authentication
{
    public class LegalPersonRepo : IFactoryCommand<LegalPerson>
    {
        private readonly IFactoryCommand<LegalPerson> _efcmd;

        public LegalPersonRepo(IFactoryConnection efc)
        {
            IFactoryRepository<LegalPerson> efr = new DbContext<LegalPerson>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(LegalPerson eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(LegalPerson eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<LegalPerson> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public LegalPerson FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<LegalPerson> Search(Expression<Func<LegalPerson, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<LegalPerson> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<LegalPerson> AsNoTracking(Expression<Func<LegalPerson, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<LegalPerson> IFactoryCommand<LegalPerson>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<LegalPerson> IFactoryCommand<LegalPerson>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<LegalPerson>.SearchOfType<T>(Expression<Func<LegalPerson, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
