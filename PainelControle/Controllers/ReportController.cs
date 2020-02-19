using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Core.App.Queries;
using Esr.Core.Domain.Queries;
using System.Linq.Expressions;
using System;

namespace Esr.Module.ControlPainel.Controllers
{
    public class ReportController
    {
        private ReportApp _ReportApp;
        private IFactoryConnection _connection;

        public ReportController(IFactoryConnection connection)
        {
            _connection = connection;
            _ReportApp = new ReportApp(connection);
        }

        public bool Save(Report Report)
        {
            _ReportApp.InsertOrUpdate(Report);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ReportApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ReportApp.Remove(_ReportApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de Reports
        /// </summary>
        /// <returns>{ c.Id, c.Code, Query = c.Query.Code, c.Display, c.ReportName  }</returns>
        public IList ListReport()
        {
            return _ReportApp.Search()
                .Select(c => new
                { c.Id, c.Code, Query = c.Query.Code, c.Display, c.ReportName  }).ToList();
        }

        public IList Search(Expression<Func<Report, bool>> expression)
        {
            return _ReportApp.Search(expression).ToList();
        }

        public IList ReportsSearch(Expression<Func<Report, bool>> expression)
        {
            return _ReportApp.Search(expression)
                .Select(c => new
                { c.Id, c.Code, Query = c.Query.Code, c.Display, c.ReportName }).ToList();
        }

        public Report FindId(int id)
        {
            return _ReportApp.FindId(id);
        }

        public bool Remove(Expression<Func<Report, bool>> expression)
        {
            _ReportApp.Remove(_ReportApp.Search(expression).ToList());
            return _connection.Save();
        }
    }
}