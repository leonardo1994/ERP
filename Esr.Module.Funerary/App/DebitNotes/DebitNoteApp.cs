using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Esr.Core.App.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.DebitNotes;
using Esr.Module.Funerary.Reports;
using Esr.Module.Funerary.Repository.DebitNotes;
using System.Collections;
using Esr.Core.Domain.ValueObject;
using Esr.Module.Funerary.App.Contractors;
using System.Data.Entity;

namespace Esr.Module.Funerary.App.DebitNotes
{
    public class DebitNoteApp
    {
        private readonly IFactoryCommand<DebitNote> _epr;
        private readonly UserApp _userApp;
        private readonly ContractorApp _contractorApp;

        public DebitNoteApp(IFactoryConnection efc)
        {
            _epr = new DebitNoteRepo(efc);
            _userApp = new UserApp(efc);
            _contractorApp = new ContractorApp(efc);
        }

        public DebitNote FindId(int id)
        {
            return _epr.FindId(id);
        }

        public bool Remove(int id)
        {
            return _epr.Remove(id);
        }

        public bool Remove(IList<DebitNote> cities)
        {
            return _epr.Remove(cities);
        }

        public bool InsertOrUpdate(DebitNote DebitNote)
        {
            var notaDebito = DebitNote;
            var contratada = _contractorApp.Search(c => c.Id == notaDebito.ContractorId).Include(c => c.DebitNotes).FirstOrDefault();

            // Verifico se a nota de débito correponde a empresa selecionada.
            if (contratada.DebitNotes.Any(c => c.NumberDebitNote == notaDebito.NumberDebitNote)) return _epr.InsertOrUpdate(DebitNote);
            var numeroNd = "";

            // Pesquiso a última nota de débito do mês recorrente da empresa selecionada.
            // Cano não exista retorna 000000000, para iniciar a contagem.
            var oldNd =
                contratada.DebitNotes.LastOrDefault(
                    c => c.DateRegistration != null && c.DateRegistration.Value.Month == DateTime.Now.Month)?
                    .NumberDebitNote ?? "000000000";

            // Pego o cnpj da empresa selecionada
            var cnpj = new Cnpj(contratada.Cnpj).Codigo;

            // Faço este loop, pois pode ocorrer situação de o número ser repetido.
            while (true)
            {
                // Pego o último contador e incremento mais 1 (um).
                var nd = (Convert.ToInt32(oldNd.Remove(0, 6)) + 1).ToString();

                // Crio a ND seguindo a regra: CNPJ (apenas dígitos) + ANO + MÊS + Contador.
                numeroNd = cnpj.Substring(12, 2) + DateTime.Now.Year.ToString().Substring(2, 2) + DateTime.Now.Month.ToString().PadLeft(2, '0') + nd.PadLeft(3, '0');

                notaDebito.NumberDebitNote = numeroNd;

                if (!_epr.Search(c => c.NumberDebitNote == notaDebito.NumberDebitNote).Any())
                    break;

                oldNd = numeroNd;
            }

            return _epr.InsertOrUpdate(DebitNote);
        }

        public IQueryable<DebitNote> Search(Expression<Func<DebitNote, bool>> expression)
        {
            return _epr.Search(expression);
        }

        public IQueryable<DebitNote> Search()
        {
            return _epr.Search();
        }

        public IList SearchAllDebitNote()
        {
            var list = (from debitNote in _epr.Search()
                        select new
                        {
                            debitNote.Id,
                            NumberDebitNote = debitNote.NumberDebitNote,
                            debitNote.ProcessNumber,
                            debitNote.DeadName,
                            debitNote.Date,
                            valor = debitNote.Value,
                            Contratada = debitNote.Contractor.PersonName
                        });
            return list.ToList();
        }
    }
}