using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.StockManagement;
using Esr.Module.Funerary.Repository.StockManagement;

namespace Esr.Module.Funerary.App.StockManagement
{
    public class OsProductStockApp : IFactoryService<OsProductStock>
    {
        private readonly IFactoryCommand<OsProductStock> _epr;

        public OsProductStockApp()
        {
            _epr = new OsProductStockRepo();
        }

        public int InsertOrUpdate(OsProductStock obj)
        {
            return obj.Id == 0 ? _epr.Insert(obj) : _epr.Update(obj);
        }

        public IList<OsProductStock> Search(Expression<Func<OsProductStock, bool>> condicao)
        {
            return _epr.Search(condicao);
        }

        public IList<OsProductStock> SearchAll()
        {
            return _epr.Search();
        }

        public OsProductStock FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool RemoveId(int id)
        {
            return _epr.Remove(id);
        }

        public bool RemoveObject(OsProductStock obj)
        {
            return _epr.Remove(obj);
        }

        public bool RemoveListId(Expression<Func<OsProductStock, bool>> condicao)
        {
            return _epr.Remove(Search(condicao));
        }

        public IList<OsProductStock> AsNoTracking(Expression<Func<OsProductStock, bool>> expression)
        {
            return _epr.AsNoTracking(expression);
        }
    }
}