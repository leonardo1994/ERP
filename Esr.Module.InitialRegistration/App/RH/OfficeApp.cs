using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Module.InitialRegistration.Repository.RH;
using Esr.Core.Domain.Other;

namespace Esr.Module.InitialRegistration.App.RH
{
    public class OfficeApp
    {
        private readonly IFactoryCommand<Office> _epr;

        public OfficeApp(IFactoryConnection efc)
        {
            _epr = new OfficeRepo(efc);
        }

        public Office FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Office> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Office Office)
        {
            return _epr.InsertOrUpdate(Office);
        }

        public IQueryable<Office> Search(Expression<Func<Office, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Office> Search()
        {
            return _epr.Search();
        }
    }
}