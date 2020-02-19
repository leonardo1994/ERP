using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.Colors;
using Esr.Module.InitialRegistration.Repository.Colors;

namespace Esr.Module.InitialRegistration.App.Colors
{
    public class ColorApp
    {
        private readonly IFactoryCommand<Color> _epr;

        public ColorApp(IFactoryConnection efc)
        {
            _epr = new ColorRepo(efc);
        }

        public Color FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Color> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Color Color)
        {
            return _epr.InsertOrUpdate(Color);
        }

        public IQueryable<Color> Search(Expression<Func<Color, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Color> Search()
        {
            return _epr.Search();
        }
    }
}