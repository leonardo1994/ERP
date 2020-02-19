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
    public class SpecialTaxApp
    {
        private readonly IFactoryCommand<SpecialTax> _epr;

        public SpecialTaxApp(IFactoryConnection efc)
        {
            _epr = new SpecialTaxRepo(efc);
        }

        public SpecialTax FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<SpecialTax> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(SpecialTax SpecialTax)
        {
            return _epr.InsertOrUpdate(SpecialTax);
        }

        public IQueryable<SpecialTax> Search(Expression<Func<SpecialTax, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<SpecialTax> Search()
        {
            return _epr.Search();
        }
    }
}