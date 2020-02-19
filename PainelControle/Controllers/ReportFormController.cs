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
    public class ReportFormController
    {
        private ReportFormApp _ReportFormApp;
        private IFactoryConnection _connection;

        public ReportFormController(IFactoryConnection connection)
        {
            _connection = connection;
            _ReportFormApp = new ReportFormApp(connection);
        }

        public bool Save(ReportForm ReportForm)
        {
            _ReportFormApp.InsertOrUpdate(ReportForm);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ReportFormApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ReportFormApp.Remove(_ReportFormApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de ReportForms
        /// </summary>
        /// <returns>{ c.Id, c.Code, Query = c.Query.Code, c.Display, c.ReportFormName  }</returns>
        public IList ListReportForm()
        {
            return _ReportFormApp.Search()
                .Select(c => new
                { c.Id, c.Table.TableName  }).ToList();
        }

        public IList Search(Expression<Func<ReportForm, bool>> expression)
        {
            return _ReportFormApp.Search(expression).ToList();
        }

        public IList ReportSearch(Expression<Func<ReportForm, bool>> expression)
        {
            return _ReportFormApp.Search(expression)
                .Select(c => new
                { c.Id, c.Table.TableName, c.TableId }).ToList();
        }

        public ReportForm FindId(int id)
        {
            return _ReportFormApp.FindId(id);
        }

        public bool Remove(Expression<Func<ReportForm, bool>> expression)
        {
            _ReportFormApp.Remove(_ReportFormApp.Search(expression).ToList());
            return _connection.Save();
        }
    }
}