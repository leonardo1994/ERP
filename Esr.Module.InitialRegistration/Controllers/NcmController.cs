using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.App.StockItems;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.InitialRegistration.Controllers
{
    public class NcmController
    {
        private NcmApp _NcmApp;
        private IFactoryConnection _connection;

        public NcmController(IFactoryConnection connection)
        {
            _connection = connection;
            _NcmApp = new NcmApp(connection);
        }

        public bool Save(Ncm Ncm)
        {
            _NcmApp.InsertOrUpdate(Ncm);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _NcmApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _NcmApp.Remove(_NcmApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Ncms List.
        /// </summary>
        /// <returns>{ c.Id, c.NcmCode, c.NcmName }</returns>
        public IList ListNcm()
        {
            return _NcmApp.Search()
                .Select(c => new
                { c.Id, c.NcmCode, c.NcmName }).ToList();
        }

        public bool Remove(Expression<Func<Ncm, bool>> expression)
        {
            _NcmApp.Remove(_NcmApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<Ncm, bool>> expression)
        {
            return _NcmApp.Search(expression).ToList();
        }

        public Ncm FindId(int id)
        {
            return _NcmApp.FindId(id);
        }
    }
}