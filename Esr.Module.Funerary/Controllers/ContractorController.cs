using Esr.Core.Domain.Authentication;
using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.App.Authentication;
using System.Collections;
using Esr.Module.Funerary.App.Contractors;
using Esr.Module.Funerary.Domain.Contractors;
using System;
using System.Linq.Expressions;

namespace Esr.Module.Funerary.Controllers
{
    public class ContractorController
    {
        private ContractorApp _ContractorApp;
        private IFactoryConnection _connection;

        public ContractorController(IFactoryConnection connection)
        {
            _connection = connection;
            _ContractorApp = new ContractorApp(connection);
        }

        public bool Save(Contractor Contractor)
        {
            _ContractorApp.InsertOrUpdate(Contractor);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ContractorApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ContractorApp.Remove(_ContractorApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// Contractor List.
        /// </summary>
        /// <returns>{ c.Id, c.PersonName, c.Cnpj, c.City.CityName, c.State.StateName, c.Country.CountryName }</returns>
        public IList ListContractor()
        {
            return _ContractorApp.Search()
                .Select(c => new
                { c.Id, c.Integration, c.PersonName, c.Cnpj, c.City.CityName, c.State.StateName, c.Country.CountryName }).ToList();
        }

        /// <summary>
        /// Contractor List.
        /// </summary>
        /// <returns>{ c.Id, c.PersonName, c.Cnpj, c.City.CityName, c.State.StateName, c.Country.CountryName }</returns>
        public IList ListContractorOfOrdemDebitNote()
        {
            return _ContractorApp.Search()
                .OrderByDescending(c => c.DebitNotes.Count)
                .Select(c => new
                { c.Id, c.Integration, c.PersonName, c.Cnpj, c.City.CityName, c.State.StateName, c.Country.CountryName }).ToList();
        }



        public IList Search(Expression<Func<Contractor, bool>> expression)
        {
            return _ContractorApp.Search(expression).ToList();
        }

        public bool Remove(Expression<Func<Contractor, bool>> expression)
        {
            _ContractorApp.Remove(_ContractorApp.Search(expression).ToList());
            return _connection.Save();
        }

        public Contractor FindId(int id)
        {
            return _ContractorApp.FindId(id);
        }
    }
}