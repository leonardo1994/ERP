using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Parking.App;
using Esr.Module.Parking.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.Parking.Controllers
{
    public class ParkingAgreementController
    {
        private ParkingAgreementApp _ParkingAgreementApp; 
        private IFactoryConnection _connection;

        public ParkingAgreementController(IFactoryConnection connection)
        {
            _connection = connection;
            _ParkingAgreementApp = new ParkingAgreementApp(connection);
        }
        
        public bool Save(ParkingAgreement ParkingAgreement)
        {
            _ParkingAgreementApp.InsertOrUpdate(ParkingAgreement);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ParkingAgreementApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ParkingAgreementApp.Remove(_ParkingAgreementApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// ParkingAgreements List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListParkingAgreement()
        {
            return _ParkingAgreementApp.Search()
                .Select(c => new
                {
                    c.Id,
                    c.Integration,
                    c.Code,
                    c.Description,
                    c.LegalPerson.PersonName,
                    c.DiscountValuePorcent,
                    c.DiscountValueReal,
                    c.Monday,
                    c.Tuesday,
                    c.Wednesday,
                    c.Thursday,
                    c.Friday,
                    c.Saturday,
                    c.Sunday,
                    c.Holiday
                }).ToList();
        }

        public bool Remove(Expression<Func<ParkingAgreement, bool>> expression)
        {
            _ParkingAgreementApp.Remove(_ParkingAgreementApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<ParkingAgreement, bool>> expression)
        {
            return _ParkingAgreementApp.Search(expression).ToList();
        }

        public ParkingAgreement FindId(int id)
        {
            return _ParkingAgreementApp.FindId(id);
        }
    }
}