using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using System.Data.Entity;
using System.Linq;
using Esr.Module.InitialRegistration.Domain.Persons;

namespace Esr.Module.InitialRegistration.Repository.Persons
{
    public class PhysicalPersonRepo : IFactoryCommand<PhysicalPerson>
    {
        private readonly IFactoryCommand<PhysicalPerson> _efcmd;

        public PhysicalPersonRepo(IFactoryConnection efc)
        {
            IFactoryRepository<PhysicalPerson> efr = new DbContext<PhysicalPerson>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(PhysicalPerson eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(PhysicalPerson eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<PhysicalPerson> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public PhysicalPerson FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<PhysicalPerson> Search(Expression<Func<PhysicalPerson, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<PhysicalPerson> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<PhysicalPerson> AsNoTracking(Expression<Func<PhysicalPerson, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<PhysicalPerson> SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<PhysicalPerson> IFactoryCommand<PhysicalPerson>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        IQueryable<T> IFactoryCommand<PhysicalPerson>.SearchOfType<T>(Expression<Func<PhysicalPerson, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
