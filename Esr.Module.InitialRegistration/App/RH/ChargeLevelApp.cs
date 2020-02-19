using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Module.InitialRegistration.Repository.RH;
using System.Collections.Generic;

namespace Esr.Module.InitialRegistration.App.RH
{
    public class ChargeLevelApp
    {
        private readonly IFactoryCommand<ChargeLevel> _epr;

        public ChargeLevelApp(IFactoryConnection efc)
        {
            _epr = new ChargeLevelRepo(efc);
        }

        public ChargeLevel FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<ChargeLevel> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(ChargeLevel ChargeLevel)
        {
            return _epr.InsertOrUpdate(ChargeLevel);
        }

        public IQueryable<ChargeLevel> Search(Expression<Func<ChargeLevel, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<ChargeLevel> Search()
        {
            return _epr.Search();
        }
    }
}