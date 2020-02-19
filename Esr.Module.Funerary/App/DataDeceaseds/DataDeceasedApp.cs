using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.DataDeceaseds;
using Esr.Module.Funerary.Repository.DataDeceaseds;

namespace Esr.Module.Funerary.App.DataDeceaseds
{
    public class DataDeceasedApp
    {
        private readonly IFactoryCommand<DataDeceased> _epr;

        public DataDeceasedApp(IFactoryConnection efc)
        {
            _epr = new DataDeceasedRepo(efc);
        }

        public DataDeceased FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<DataDeceased> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(DataDeceased DataDeceased)
        {
            return _epr.InsertOrUpdate(DataDeceased);
        }

        public IQueryable<DataDeceased> Search(Expression<Func<DataDeceased, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<DataDeceased> Search()
        {
            return _epr.Search();
        }
    }
}