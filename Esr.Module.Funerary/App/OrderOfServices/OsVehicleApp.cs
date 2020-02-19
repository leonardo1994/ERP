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
    public class OsVehicleApp
    {
        private readonly IFactoryCommand<OsVehicle> _epr;

        public OsVehicleApp(IFactoryConnection efc)
        {
            _epr = new OsVehicleRepo(efc);
        }

        public OsVehicle FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<OsVehicle> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(OsVehicle OsVehicle)
        {
            return _epr.InsertOrUpdate(OsVehicle);
        }

        public IQueryable<OsVehicle> Search(Expression<Func<OsVehicle, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<OsVehicle> Search()
        {
            return _epr.Search();
        }
    }
}