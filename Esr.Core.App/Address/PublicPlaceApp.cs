using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Address;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Address;
using System.Collections.Generic;

namespace Esr.Core.App.Address
{
    public class PublicPlaceApp
    {
        private readonly IFactoryCommand<PublicPlace> _epr;

        public PublicPlaceApp(IFactoryConnection efc)
        {
            _epr = new PublicPlaceRepo(efc);
        }

        public PublicPlace FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<PublicPlace> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(PublicPlace PublicPlace)
        {
            return _epr.InsertOrUpdate(PublicPlace);
        }

        public IQueryable<PublicPlace> Search(Expression<Func<PublicPlace, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<PublicPlace> Search()
        {
            return _epr.Search();
        }
    }
}