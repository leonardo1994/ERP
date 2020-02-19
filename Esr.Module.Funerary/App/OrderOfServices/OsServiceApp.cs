using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.Funerary.Repository.OrderOfServices;
using Esr.Core.Domain.Other;

namespace Esr.Module.Funerary.App.OrderOfServices
{
    public class OsServiceApp
    {
        private readonly IFactoryCommand<OsService> _epr;

        public OsServiceApp(IFactoryConnection efc)
        {
            _epr = new OsServiceRepo(efc);
        }

        public OsService FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<OsService> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(OsService OsService)
        {
            return _epr.InsertOrUpdate(OsService);
        }

        public IQueryable<OsService> Search(Expression<Func<OsService, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<OsService> Search()
        {
            return _epr.Search();
        }
    }
}