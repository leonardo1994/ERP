using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Repository.StockItems;
using Esr.Core.Domain.Other;

namespace Esr.Module.InitialRegistration.App.StockItems
{
    public class MarkApp
    {
        private readonly IFactoryCommand<Mark> _epr;

        public MarkApp(IFactoryConnection efc)
        {
            _epr = new MarkRepo(efc);
        }

        public Mark FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Mark> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Mark Mark)
        {
            return _epr.InsertOrUpdate(Mark);
        }

        public IQueryable<Mark> Search(Expression<Func<Mark, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Mark> Search()
        {
            return _epr.Search();
        }
    }
}