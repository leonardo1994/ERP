using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.Contractors;
using System.Data.Entity;
using System.Linq;
using Esr.Core.Repository;

namespace Esr.Module.Funerary.Repository.Contractors
{
    public class ContractorRepo : IFactoryCommand<Contractor>
    {
        private readonly IFactoryCommand<Contractor> _efcmd;

        public ContractorRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Contractor> efr = new DbContext<Contractor>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Contractor eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Contractor eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Contractor> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Contractor FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Contractor> Search(Expression<Func<Contractor, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Contractor> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Contractor> AsNoTracking(Expression<Func<Contractor, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Contractor> IFactoryCommand<Contractor>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Contractor> IFactoryCommand<Contractor>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Contractor>.SearchOfType<T>(Expression<Func<Contractor, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
