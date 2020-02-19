using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Domain.Translation;
using Esr.Core.Repository.Translation;
using System.Linq;

namespace Esr.Core.App.Translation
{
    public class TranslateApp
    {
        private readonly IFactoryCommand<Translate> _epr;

        public TranslateApp(IFactoryConnection efc)
        {
            _epr = new TranslateRepo(efc);
        }

        public Translate FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Translate> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Translate Translate)
        {
            if (_epr.Search(c => c.PropertyName == Translate.PropertyName && c.Id != Translate.Id).Any())
                return _epr.InsertOrUpdate(Translate);
            return false;
        }

        public IQueryable<Translate> Search(Expression<Func<Translate, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Translate> Search()
        {
            return _epr.Search();
        }
    }
}