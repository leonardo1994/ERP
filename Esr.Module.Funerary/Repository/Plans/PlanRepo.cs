using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.Plans;
using System.Data.Entity;
using System.Linq;
using Esr.Core.Repository;

namespace Esr.Module.Funerary.Repository.Plans
{
    public class PlanRepo : IFactoryCommand<Plan>
    {
        private readonly IFactoryCommand<Plan> _efcmd;

        public PlanRepo(IFactoryConnection efc)
        {
            IFactoryRepository<Plan> efr = new DbContext<Plan>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(Plan eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(Plan eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<Plan> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public Plan FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<Plan> Search(Expression<Func<Plan, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<Plan> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<Plan> AsNoTracking(Expression<Func<Plan, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<Plan> IFactoryCommand<Plan>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<Plan> IFactoryCommand<Plan>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<Plan>.SearchOfType<T>(Expression<Func<Plan, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
