using System.Collections.Generic;
using System.Linq;
using Esr.Core.Domain.RepositoryFactory;
using System.Collections;
using Esr.Module.Funerary.App.DebitNotes;
using Esr.Module.Funerary.Domain.DebitNotes;
using System.Linq.Expressions;
using System;
using Esr.Module.Funerary.Reports;
using Esr.Core.Domain.Authentication;
using Esr.Core.App.Authentication;
using System.Data.Entity;

namespace Esr.Module.Funerary.Controllers
{
    public class DebitNotesController
    {
        private DebitNoteApp _DebitNotesApp;
        private IFactoryConnection _connection;

        public DebitNotesController(IFactoryConnection connection)
        {
            _connection = connection;
            _DebitNotesApp = new DebitNoteApp(connection);
        }

        public bool Save(DebitNote DebitNotes)
        {
            _DebitNotesApp.InsertOrUpdate(DebitNotes);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _DebitNotesApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _DebitNotesApp.Remove(_DebitNotesApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// DebitNotes List.
        /// </summary>
        /// <returns>{ c.Id, c.FalecidoNome, c.FalecidoCpf }</returns>
        public IList ListDebitNotes()
        {
            return _DebitNotesApp.Search()
                .Select(c => new
                { c.Id, c.NumberDebitNote, c.ProcessNumber, c.Contractor.PersonName, c.Date, c.DeadName, c.Value }).OrderByDescending(c => c.Id).Take(100).ToList();
        }

        public bool Remove(Expression<Func<DebitNote, bool>> expression)
        {
            _DebitNotesApp.Remove(_DebitNotesApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<DebitNote, bool>> expression)
        {
            return _DebitNotesApp.Search(expression).ToList();
        }

        public DebitNote FindId(int id)
        {
            return _DebitNotesApp.FindId(id);
        }

        #region Métodos específicos
        #region Métodos para realatórios
        public object QueryNotaDebito(object obj)
        {
            var userApp = new UserApp(_connection);

            var lista = new List<object>();
            var notaDebito = obj as IList<DebitNote>;
            if (notaDebito == null) return lista;

            foreach (var item in notaDebito)
            {
                var nd = _DebitNotesApp
                    .Search(c => c.Id == item.Id)
                    .Include(c => c.Contractor.State)
                    .Include(c => c.Contractor.City).First();

                lista.Add(new DebitNoteView
                {
                    DeadName = nd.DeadName,
                    Date = nd.Date.ToShortDateString(),
                    Value = nd.Value.ToString("C"),
                    NumberDebitNote = nd.NumberDebitNote,
                    ProcessNumber = nd.ProcessNumber,
                    PersonName = nd.Contractor.PersonName,
                    City = nd.Contractor.City?.CityName,
                    CorporateName = nd.Contractor.CorporateName,
                    Cnpj = nd.Contractor.Cnpj.Replace(',', '.'),
                    ComercialPhone = nd.Contractor.CommercialPhone,
                    CellPhone = nd.Contractor.CellPhone,
                    LandLine = nd.Contractor.LandLine,
                    DateRegistration = nd.DateRegistration,
                    UserName = userApp.FindId(nd.UserControlId.Value).UserName,
                    ZipCode = nd.Contractor.ZipCode,
                    Street = nd.Contractor.Street,
                    Neighborhhod = nd.Contractor.Neighborhood,
                    NumberStreet = nd.Contractor.NumberStreet.ToString().Replace(",00", "").PadLeft(4, '0'),
                    InitialsState = nd.Contractor.State?.Initials,
                    Complement = nd.Contractor.Complement
                });
            }
            return lista;
        }

        public object QueryNotaDebito(Expression<Func<DebitNote, bool>> obj)
        {
            var userApp = new UserApp(_connection);

            var lista = new List<object>();

            var notaDebito = _DebitNotesApp.Search(obj)
                .Include(c => c.Contractor.State)
                    .Include(c => c.Contractor.City).ToList();

            if (notaDebito == null) return lista;

            var newList = notaDebito.OrderBy(c => c.Date);

            foreach (var item in newList)
            {
                var nd = item;

                lista.Add(new DebitNoteView
                {
                    DeadName = nd.DeadName,
                    Date = nd.Date.ToShortDateString(),
                    Value = nd.Value.ToString("C"),
                    NumberDebitNote = nd.NumberDebitNote,
                    ProcessNumber = nd.ProcessNumber,
                    PersonName = nd.Contractor.PersonName,
                    City = nd.Contractor.City?.CityName,
                    CorporateName = nd.Contractor.CorporateName,
                    Cnpj = nd.Contractor.Cnpj.Replace(',', '.'),
                    ComercialPhone = nd.Contractor.CommercialPhone,
                    CellPhone = nd.Contractor.CellPhone,
                    LandLine = nd.Contractor.LandLine,
                    DateRegistration = nd.DateRegistration,
                    UserName = userApp.FindId(nd.UserControlId.Value).UserName,
                    ZipCode = nd.Contractor.ZipCode,
                    Street = nd.Contractor.Street,
                    Neighborhhod = nd.Contractor.Neighborhood,
                    NumberStreet = nd.Contractor.NumberStreet.ToString().Replace(",00", "").PadLeft(4, '0'),
                    InitialsState = nd.Contractor.State?.Initials,
                    Complement = nd.Contractor.Complement
                });
            }
            return lista;
        }

        #endregion
        #endregion
    }
}