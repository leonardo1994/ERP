using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.Integration.Stock;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.Funerary.Repository.OrderOfServices;
using Esr.Module.Stock.App.Integration;
using Esr.Module.Stock.Domain.Integration;
using Esr.Module.Stock.MapperConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.Funerary.App.OrderOfServices
{
    public class OrderOfServiceApp
    {
        private readonly IFactoryCommand<OrderOfService> _epr;

        public OrderOfServiceApp(IFactoryConnection efc)
        {
            _epr = new OrderOfServiceRepo(efc);
        }

        public OrderOfService FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<OrderOfService> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(OrderOfService OrderOfService)
        {
            return _epr.InsertOrUpdate(OrderOfService);
        }

        public IQueryable<OrderOfService> Search(Expression<Func<OrderOfService, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<OrderOfService> Search()
        {
            return _epr.Search();
        }
    }
}