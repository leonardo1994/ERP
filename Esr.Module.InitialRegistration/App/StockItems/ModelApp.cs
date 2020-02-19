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
    public class ModelApp
    {
        private readonly IFactoryCommand<Model> _epr;

        public ModelApp(IFactoryConnection efc)
        {
            _epr = new ModelRepo(efc);
        }

        public Model FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Model> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Model Model)
        {
            return _epr.InsertOrUpdate(Model);
        }

        public IQueryable<Model> Search(Expression<Func<Model, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Model> Search()
        {
            return _epr.Search();
        }
    }
}