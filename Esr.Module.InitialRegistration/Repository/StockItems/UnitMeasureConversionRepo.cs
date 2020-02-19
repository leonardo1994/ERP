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
    public class UnitMeasureConversionRepo : IFactoryCommand<UnitMeasureConversion>
    {
        private readonly IFactoryCommand<UnitMeasureConversion> _efcmd;

        public UnitMeasureConversionRepo(IFactoryConnection efc)
        {
            IFactoryRepository<UnitMeasureConversion> efr = new DbContext<UnitMeasureConversion>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(UnitMeasureConversion eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(UnitMeasureConversion eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<UnitMeasureConversion> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public UnitMeasureConversion FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<UnitMeasureConversion> Search(Expression<Func<UnitMeasureConversion, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<UnitMeasureConversion> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<UnitMeasureConversion> AsNoTracking(Expression<Func<UnitMeasureConversion, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<UnitMeasureConversion> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<UnitMeasureConversion> IFactoryCommand<UnitMeasureConversion>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<UnitMeasureConversion>.SearchOfType<T>(Expression<Func<UnitMeasureConversion, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
