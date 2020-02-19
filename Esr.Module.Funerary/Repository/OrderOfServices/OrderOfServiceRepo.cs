using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.OrderOfServices;
using System.Linq;
using System.Data.Entity;
using Esr.Core.Repository;

namespace Esr.Module.Funerary.Repository.OrderOfServices
{
    public class OrderOfServiceRepo : IFactoryCommand<OrderOfService>
    {
        private readonly IFactoryCommand<OrderOfService> _efcmd;

        public OrderOfServiceRepo(IFactoryConnection efc)
        {
            IFactoryRepository<OrderOfService> efr = new DbContext<OrderOfService>();
            
            _efcmd = efr.FactoryCommand(efc);
        }

        public void Dispose()
        {
            _efcmd.Dispose();
        }

        public bool InsertOrUpdate(OrderOfService eobject)
        {
            return _efcmd.InsertOrUpdate(eobject);
        }

        public bool Remove(OrderOfService eobject)
        {
            return _efcmd.Remove(eobject);
        }

        public bool Remove(int id)
        {
            return _efcmd.Remove(id);
        }

        public bool Remove(IEnumerable<OrderOfService> eObjects)
        {
            return _efcmd.Remove(eObjects);
        }

        public OrderOfService FindId(int id)
        {
            return _efcmd.FindId(id);
        }

        public IQueryable<OrderOfService> Search(Expression<Func<OrderOfService, bool>> expression)
        {
            return _efcmd.Search(expression);
        }

        public IQueryable<OrderOfService> Search()
        {
            return _efcmd.Search();
        }

        public IQueryable<OrderOfService> AsNoTracking(Expression<Func<OrderOfService, bool>> expression)
        {
            return _efcmd.AsNoTracking(expression);
        }

        IList<OrderOfService> IFactoryCommand<OrderOfService>.SqlQuery(string sql, params object[] parameters)
        {
            return _efcmd.SqlQuery(sql, parameters);
        }

        IQueryable<OrderOfService> IFactoryCommand<OrderOfService>.SearchInOfType<T>(Expression<Func<T, bool>> expression)
        {
            return _efcmd.SearchInOfType<T>(expression);
        }

        IQueryable<T> IFactoryCommand<OrderOfService>.SearchOfType<T>(Expression<Func<OrderOfService, bool>> expression)
        {
            return _efcmd.SearchOfType<T>(expression);
        }
    }
}
