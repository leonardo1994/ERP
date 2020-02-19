using Esr.Core.App.Address;
using Esr.Core.Domain.Address;
using Esr.Core.Domain.RepositoryFactory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class StateController
    {
        private StateApp _StateApp; 
        private IFactoryConnection _connection;

        public StateController(IFactoryConnection connection)
        {
            _connection = connection;
            _StateApp = new StateApp(connection);
        }
        
        public bool Save(State State)
        {
            _StateApp.InsertOrUpdate(State);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _StateApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _StateApp.Remove(_StateApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// States List.
        /// </summary>
        /// <returns>{ c.Id, c.StateName, c.Initials, c.Country.CountryName, c.CodeIbge }</returns>
        public IList ListState()
        {
            return _StateApp.Search()
                .Select(c => new
                { c.Id, c.StateName, c.Initials, c.Country.CountryName, c.CodeIbge }).ToList();
        }

        /// <summary>
        /// States List.
        /// </summary>
        /// <returns>{ c.Id, c.StateName, c.Initials, c.Country.CountryName, c.CodeIbge }</returns>
        public IList ListState(Expression<Func<State, bool>> expression)
        {
            return _StateApp.Search(expression)
                .Select(c => new
                { c.Id, c.StateName, c.Initials, c.Country.CountryName, c.CodeIbge }).ToList();
        }

        /// <summary>
        /// States List.
        /// </summary>
        /// <returns>{ c.Id, c.StateName, c.Initials, c.Country.CountryName, c.CodeIbge }</returns>
        public IList<State> Search(Expression<Func<State, bool>> expression)
        {
            return _StateApp.Search(expression).ToList();
        }

        public bool Remove(Expression<Func<State, bool>> expression)
        {
            _StateApp.Remove(_StateApp.Search(expression).ToList());
            return _connection.Save();
        }

        public State FindId(int id)
        {
            return _StateApp.FindId(id);
        }
    }
}