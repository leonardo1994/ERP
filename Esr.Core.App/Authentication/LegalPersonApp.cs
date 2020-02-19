using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Authentication;
using Esr.Core.Domain.Other;

namespace Esr.Core.App.Authentication
{
    public class LegalPersonApp
    {
        private readonly IFactoryCommand<LegalPerson> _epr;

        public LegalPersonApp(IFactoryConnection efc)
        {
            _epr = new LegalPersonRepo(efc);
        }

        public LegalPerson FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<LegalPerson> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(LegalPerson LegalPerson)
        {
            return _epr.InsertOrUpdate(LegalPerson);
        }

        public IQueryable<LegalPerson> Search(Expression<Func<LegalPerson, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<LegalPerson> Search()
        {
            return _epr.Search();
        }
    }
}