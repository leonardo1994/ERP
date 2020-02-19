using Esr.Core.Domain.Authentication;
using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.App.Authentication;
using System.Collections;
using Esr.Core.App.Queries;
using Esr.Core.Domain.Queries;
using System.Linq.Expressions;
using System;

namespace Esr.Module.ControlPainel.Controllers
{
    public class ConsultFormController
    {
        private ConsultFormApp _ConsultFormApp;
        private IFactoryConnection _connection;

        public ConsultFormController(IFactoryConnection connection)
        {
            _connection = connection;
            _ConsultFormApp = new ConsultFormApp(connection);
        }

        public bool Save(ConsultForm ConsultForm)
        {
            _ConsultFormApp.InsertOrUpdate(ConsultForm);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ConsultFormApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ConsultFormApp.Remove(_ConsultFormApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        public bool Remove(Expression<Func<ConsultForm, bool>> expression)
        {
            _ConsultFormApp.Remove(_ConsultFormApp.Search(expression).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Lista de empresas.
        /// </summary>
        /// <returns>{ c.Id, c.Consult.Display, c.Table.TableName }</returns>
        public IList ListConsultForm()
        {
            return _ConsultFormApp.Search()
                .Select(c => new
                { c.Id, c.Consult.Display, c.Table.TableName , c.Integration }).ToList();
        }

        /// <summary>
        /// Lista de empresas.
        /// </summary>
        /// <returns>{ c.Id, c.Consult.Display, c.Table.TableName }</returns>
        public IList Search(Expression<Func<ConsultForm, bool>> expression)
        {
            return _ConsultFormApp.Search(expression).ToList();
        }

        /// <summary>
        /// Lista de empresas.
        /// </summary>
        /// <returns>{ c.Id, c.Consult.Display, c.Table.TableName }</returns>
        public IList SearchConsult(Expression<Func<ConsultForm, bool>> expression)
        {
            return _ConsultFormApp.Search(expression)
                .Select(c => new
                { c.Id, c.Consult.Display, c.Table.TableName, c.ConsultId, c.TableId , c.Integration }).ToList();
        }

        public ConsultForm FindId(int id)
        {
            return _ConsultFormApp.FindId(id);
        }
    }
}
