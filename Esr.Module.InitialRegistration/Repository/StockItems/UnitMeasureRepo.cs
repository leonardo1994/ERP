using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System.Data.Entity;
using System.Linq;

namespace Esr.Module.InitialRegistration.Repository.StockItems
{
    public class UnitMeasureRepo : IFactoryCommand<UnitMeasure>
    {
        private readonly IFactoryCommand<UnitMeasure> _efcmd;

        public UnitMeasureRepo(IFactoryConnection efc)
        {
            IFactoryRepository<UnitMeasure> efr = new DbContext<UnitMeasure>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(UnitMeasure eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(UnitMeasure eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<UnitMeasure> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public UnitMeasure FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<UnitMeasure> Search(Expression<Func<UnitMeasure, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<UnitMeasure> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<UnitMeasure> AsNoTracking(Expression<Func<UnitMeasure, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<UnitMeasure> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<UnitMeasure> IFactoryCommand<UnitMeasure>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<UnitMeasure>.SearchOfType<T>(Expression<Func<UnitMeasure, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
