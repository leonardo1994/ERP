using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Financial.Domain.Financial;
using Esr.Module.Financial.Repository.Financial;

namespace Esr.Module.Financial.App.Financial
{
    public class TypeDocumentFinancialApp
    {
        private readonly IFactoryCommand<TypeDocumentFinancial> _epr;

        public TypeDocumentFinancialApp(IFactoryConnection efc)
        {
            _epr = new TypeDocumentFinancialRepo(efc);
        }

        public TypeDocumentFinancial FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<TypeDocumentFinancial> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(TypeDocumentFinancial TypeDocumentFinancial)
        {
            return _epr.InsertOrUpdate(TypeDocumentFinancial);
        }

        public IQueryable<TypeDocumentFinancial> Search(Expression<Func<TypeDocumentFinancial, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<TypeDocumentFinancial> Search()
        {
            return _epr.Search();
        }
    }
}