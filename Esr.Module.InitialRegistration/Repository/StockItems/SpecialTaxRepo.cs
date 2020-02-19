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
    public class SpecialTaxRepo : IFactoryCommand<SpecialTax>
    {
        private readonly IFactoryCommand<SpecialTax> _efcmd;

        public SpecialTaxRepo(IFactoryConnection efc)
        {
            IFactoryRepository<SpecialTax> efr = new DbContext<SpecialTax>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(SpecialTax eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(SpecialTax eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<SpecialTax> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public SpecialTax FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<SpecialTax> Search(Expression<Func<SpecialTax, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<SpecialTax> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<SpecialTax> AsNoTracking(Expression<Func<SpecialTax, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        public IList<SpecialTax> SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IList<SpecialTax> IFactoryCommand<SpecialTax>.SqlQuery(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        IQueryable<SpecialTax> IFactoryCommand<SpecialTax>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<SpecialTax>.SearchOfType<T>(Expression<Func<SpecialTax, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
