using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Module.Funerary.App.OrderOfServices;
using Esr.Module.Funerary.Domain.OrderOfServices;
using System.Linq.Expressions;
using System;

namespace Esr.Module.Funerary.Controllers
{
    public class OsContractorServiceController
    {
        private OsContractorServiceApp _OsContractorServiceApp;
        private IFactoryConnection _connection;

        public OsContractorServiceController(IFactoryConnection connection)
        {
            _connection = connection;
            _OsContractorServiceApp = new OsContractorServiceApp(connection);
        }

        public bool Save(OsContractorService OsContractorService)
        {
            _OsContractorServiceApp.InsertOrUpdate(OsContractorService);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _OsContractorServiceApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _OsContractorServiceApp.Remove(_OsContractorServiceApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// OsContractorService List.
        /// </summary>
        /// <returns>{ c.Id, c.Contractor.PersonName, c.Service.Description, c.ValueService, c.HistoricalService }</returns>
        public IList ListOsContractorService()
        {
            return _OsContractorServiceApp.Search()
                .Select(c => new
                { c.Id, c.Contractor.PersonName, c.Service.Description, c.ValueService, c.HistoricalService }).ToList();
        }

        /// <summary>
        /// OsContractorService List.
        /// </summary>
        /// <returns>{ c.Id, c.Contractor.PersonName, c.Service.Description, c.ValueService, c.HistoricalService }</returns>
        public IList ListOsContractorService(Expression<Func<OsContractorService, bool>> expression)
        {
            return _OsContractorServiceApp.Search(expression)
                .Select(c => new
                { c.Id, c.Integration, c.Contractor.PersonName, c.Service.Description, c.ValueService, c.HistoricalService }).ToList();
        }

        public bool Remove(Expression<Func<OsContractorService, bool>> expression)
        {
            _OsContractorServiceApp.Remove(_OsContractorServiceApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<OsContractorService, bool>> expression)
        {
            return _OsContractorServiceApp.Search(expression).ToList();
        }

        public OsContractorService FindId(int id)
        {
            return _OsContractorServiceApp.FindId(id);
        }
    }
}