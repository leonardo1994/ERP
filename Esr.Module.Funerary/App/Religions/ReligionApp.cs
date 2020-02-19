using System;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.Religions;
using Esr.Module.Funerary.Repository.Religions;
using System.Collections.Generic;

namespace Esr.Module.Funerary.App.Religions
{
    public class ReligionApp
    {
        private readonly IFactoryCommand<Religion> _epr;

        public ReligionApp(IFactoryConnection efc)
        {
            _epr = new ReligionRepo(efc);
        }

        public Religion FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Religion> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Religion Religion)
        {
            return _epr.InsertOrUpdate(Religion);
        }

        public IQueryable<Religion> Search(Expression<Func<Religion, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Religion> Search()
        {
            return _epr.Search();
        }
    }
}