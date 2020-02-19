using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using System.Data.Entity;
using System.Linq;

namespace Esr.Core.Repository.Queries
{
    public class ConsultFormRepo : IFactoryCommand<ConsultForm>
    {
        private readonly IFactoryCommand<ConsultForm> _efcmd;

        public ConsultFormRepo(IFactoryConnection efc)
        {
            IFactoryRepository<ConsultForm> efr = new DbContext<ConsultForm>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(ConsultForm eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(ConsultForm eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<ConsultForm> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public ConsultForm FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<ConsultForm> Search(Expression<Func<ConsultForm, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<ConsultForm> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<ConsultForm> AsNoTracking(Expression<Func<ConsultForm, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<ConsultForm> IFactoryCommand<ConsultForm>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<ConsultForm> IFactoryCommand<ConsultForm>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<ConsultForm>.SearchOfType<T>(Expression<Func<ConsultForm, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
