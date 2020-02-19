using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Repository.StockItems;


namespace Esr.Module.InitialRegistration.App.StockItems
{
    public class NcmApp
    {
        private readonly IFactoryCommand<Ncm> _epr;

        public NcmApp(IFactoryConnection efc)
        {
            _epr = new NcmRepo(efc);
        }

        public Ncm FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Ncm> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Ncm Ncm)
        {
            return _epr.InsertOrUpdate(Ncm);
        }

        public IQueryable<Ncm> Search(Expression<Func<Ncm, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Ncm> Search()
        {
            return _epr.Search();
        }
    }
}