using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Queries;

namespace Esr.Core.App.Queries
{
    public class ReportFormApp
    {
        private readonly IFactoryCommand<ReportForm> _epr;

        public ReportFormApp(IFactoryConnection efc)
        {
            _epr = new ReportFormRepo(efc);
        }

        public ReportForm FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<ReportForm> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(ReportForm ReportForm)
        {
            return _epr.InsertOrUpdate(ReportForm);
        }

        public IQueryable<ReportForm> Search(Expression<Func<ReportForm, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<ReportForm> Search()
        {
            return _epr.Search();
        }
    }
}