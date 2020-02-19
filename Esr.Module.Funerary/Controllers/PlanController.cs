using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Module.Funerary.App.Plans;
using Esr.Module.Funerary.Domain.Plans;
using System;
using System.Linq.Expressions;

namespace Esr.Module.Funerary.Controllers
{
    public class PlanController
    {
        private PlanApp _PlanApp;
        private IFactoryConnection _connection;

        public PlanController(IFactoryConnection connection)
        {
            _connection = connection;
            _PlanApp = new PlanApp(connection);
        }

        public bool Save(Plan Plan)
        {
            _PlanApp.InsertOrUpdate(Plan);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _PlanApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _PlanApp.Remove(_PlanApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Plan List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListPlan()
        {
            return _PlanApp.Search()
                .Select(c => new
                { c.Id, c.Code, c.Description }).ToList();
        }

        public bool Remove(Expression<Func<Plan, bool>> expression)
        {
            _PlanApp.Remove(_PlanApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Plan, bool>> expression)
        {
            return _PlanApp.Search(expression).ToList();
        }

        public Plan FindId(int id)
        {
            return _PlanApp.FindId(id);
        }
    }
}