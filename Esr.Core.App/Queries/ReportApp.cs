using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository.Queries;
using Esr.Core.Domain.Other;

namespace Esr.Core.App.Queries
{
    public class ReportApp
    {
        private readonly IFactoryCommand<Report> _epr;

        public ReportApp(IFactoryConnection efc)
        {
            _epr = new ReportRepo(efc);
        }

        public Report FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<Report> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(Report Report)
        {
            return _epr.InsertOrUpdate(Report);
        }

        public IQueryable<Report> Search(Expression<Func<Report, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<Report> Search()
        {
            return _epr.Search();
        }

        public IList SearchAllReport(string formName)
        {
            var list = (from report in _epr.Search(c => c.ReportForms.Any(d => d.Table.TableName == formName))
                        select new
                        {
                            report.Id,
                            report.Code,
                            report.Display,
                            report.ReportName,
                            report.QueryId
                        });
            return list.ToList();
        }
    }
}