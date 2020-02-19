using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.RH;
using Esr.Module.InitialRegistration.Domain.RH;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class ChargeLevelController
    {
        private ChargeLevelApp _ChargeLevelApp; 
        private IFactoryConnection _connection;

        public ChargeLevelController(IFactoryConnection connection)
        {
            _connection = connection;
            _ChargeLevelApp = new ChargeLevelApp(connection);
        }
        
        public bool Save(ChargeLevel ChargeLevel)
        {
            _ChargeLevelApp.InsertOrUpdate(ChargeLevel);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ChargeLevelApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ChargeLevelApp.Remove(_ChargeLevelApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// ChargeLevels List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListChargeLevel()
        {
            return _ChargeLevelApp.Search()
                .Select(c => new
                { c.Id, c.ChargeLevelCode, c.ChargeLevelDescription }).ToList();
        }

        public bool Remove(Expression<Func<ChargeLevel, bool>> expression)
        {
            _ChargeLevelApp.Remove(_ChargeLevelApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<ChargeLevel, bool>> expression)
        {
            return _ChargeLevelApp.Search(expression).ToList();
        }

        public ChargeLevel FindId(int id)
        {
            return _ChargeLevelApp.FindId(id);
        }
    }
}