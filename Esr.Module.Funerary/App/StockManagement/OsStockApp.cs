using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.StockManagement;
using Esr.Module.Funerary.Repository.StockManagement;

namespace Esr.Module.Funerary.App.StockManagement
{
    public class OsStockApp : IFactoryService<OsStock>
    {
        private readonly IFactoryCommand<OsStock> _epr;

        public OsStockApp()
        {
            _epr = new OsStockRepo();
        }

        public int InsertOrUpdate(OsStock obj)
        {
            return obj.Id == 0 ? _epr.Insert(obj) : _epr.Update(obj);
        }

        public IList<OsStock> Search(Expression<Func<OsStock, bool>> condicao)
        {
            return _epr.Search(condicao);
        }

        public IList<OsStock> SearchAll()
        {
            return _epr.Search();
        }

        public OsStock FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool RemoveId(int id)
        {
            return _epr.Remove(id);
        }

        public bool RemoveObject(OsStock obj)
        {
            return _epr.Remove(obj);
        }

        public bool RemoveListId(Expression<Func<OsStock, bool>> condicao)
        {
            return _epr.Remove(Search(condicao));
        }

        public IList<OsStock> AsNoTracking(Expression<Func<OsStock, bool>> expression)
        {
            return _epr.AsNoTracking(expression);
        }

        public IList SearchAllOsStock()
        {
            var list = (from person in SearchAll()
                        select new
                        {
                            person.Id,
                            person.Code,
                            person.DateOutput
                        }).ToList();
            return list;
        }
    }
}