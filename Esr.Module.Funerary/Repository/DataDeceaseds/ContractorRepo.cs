using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.DataDeceaseds;
using System.Data.Entity;
using System.Linq;
using Esr.Core.Repository;

namespace Esr.Module.Funerary.Repository.DataDeceaseds
{
    public class DataDeceasedRepo : IFactoryCommand<DataDeceased>
    {
        private readonly IFactoryCommand<DataDeceased> _efcmd;

        public DataDeceasedRepo(IFactoryConnection efc)
        {
            IFactoryRepository<DataDeceased> efr = new DbContext<DataDeceased>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(DataDeceased eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(DataDeceased eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<DataDeceased> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public DataDeceased FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<DataDeceased> Search(Expression<Func<DataDeceased, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<DataDeceased> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<DataDeceased> AsNoTracking(Expression<Func<DataDeceased, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<DataDeceased> IFactoryCommand<DataDeceased>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<DataDeceased> IFactoryCommand<DataDeceased>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<DataDeceased>.SearchOfType<T>(Expression<Func<DataDeceased, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
