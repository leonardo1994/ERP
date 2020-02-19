using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Parking.App;
using Esr.Module.Parking.Domain;
using Esr.Module.Parking.Reports.Ticket;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Esr.Module.Parking.Controllers
{
    public class ParkingInOutController
    {
        private ParkingInOutApp _ParkingInOutApp;
        private ParkingItemTableOfPriceApp _itemTableOfPriceApp;
        private IFactoryConnection _connection;

        public ParkingInOutController(IFactoryConnection connection)
        {
            _connection = connection;
            _ParkingInOutApp = new ParkingInOutApp(connection);
            _itemTableOfPriceApp = new ParkingItemTableOfPriceApp(connection);
        }

        public bool GerarEntrada(ParkingInOut ParkingInOut)
        {
            ParkingInOut.Closed = Core.Domain.EnumBase.YesNo.No;
            _ParkingInOutApp.GerarEntrada(ParkingInOut);
            return _connection.Save();
        }

        public bool GerarSaida(ParkingInOut ParkingInOut)
        {
            ParkingInOut.Closed = Core.Domain.EnumBase.YesNo.Yes;
            _ParkingInOutApp.GerarEntrada(ParkingInOut);
            return _connection.Save();
        }

        public bool Save(ParkingInOut ParkingInOut)
        {
            _ParkingInOutApp.InsertOrUpdate(ParkingInOut);
            return _connection.Save();
        }

        public bool RemoveId(int id)
        {
            _ParkingInOutApp.Remove(id);
            return _connection.Save();
        }

        public bool RemoveListId(IList<int> listId)
        {
            _ParkingInOutApp.Remove(_ParkingInOutApp.Search(c => listId.Contains(c.Id)).ToList());
            return _connection.Save();
        }

        /// <summary>
        /// ParkingInOuts List.
        /// </summary>
        /// <returns>{ c.Id, c.Code, c.Description }</returns>
        public IList ListParkingInOut()
        {
            return _ParkingInOutApp.Search()
                .Select(c => new
                {
                    c.Id,
                    c.VehiclePlate.Plate,
                    c.VehiclePlate.Vehicle.NameVehicle,
                    c.VehiclePlate.ModelVehicle.Description,
                    c.PhysicalPerson.PersonName,
                    c.ParkingDateTimeInput
                }).ToList();
        }

        public bool Remove(Expression<Func<ParkingInOut, bool>> expression)
        {
            _ParkingInOutApp.Remove(_ParkingInOutApp.Search(expression).ToList());
            return _connection.Save();
        }

        public IList Search(Expression<Func<ParkingInOut, bool>> expression)
        {
            return _ParkingInOutApp.Search(expression).ToList();
        }

        public ParkingInOut FindId(int id)
        {
            return _ParkingInOutApp.FindId(id);
        }

        public ParkingInOut FindByTicketNumber(decimal value)
        {
            var ticket = _ParkingInOutApp.Search(c => c.TicketNumber == value && c.Closed == Core.Domain.EnumBase.YesNo.No).FirstOrDefault();
            if (ticket == null) return null;
            ticket.ParkingDateTimeOutput = DateTime.Now;
            ticket.TotalValue = _itemTableOfPriceApp.Calculate(ticket.ParkingDateTimeInput, ticket.ParkingDateTimeOutput.GetValueOrDefault(), ticket.ParkingItemTableOfPriceId);
            ticket.TotalPayable = ticket.TotalValue;
            return ticket;
        }

        public IList<TicketView> ListForReport(int id)
        {
            return _ParkingInOutApp.Search(c => c.Id == id)
                .Select(d => new TicketView
                {
                    NumeroTicket = d.TicketNumber,
                    DataInicial = d.ParkingDateTimeInput,
                    DataFinal = d.ParkingDateTimeOutput,
                    Placa = d.VehiclePlate.Plate,
                    Veiculo = d.VehiclePlate.Vehicle.NameVehicle,
                    Modelo = d.VehiclePlate.ModelVehicle.Description,
                    Cor = d.VehiclePlate.Color.Description,
                    Convenio = d.ParkingAgreement.Description,
                    FormaPagamento = d.FormOfPayment.Description,
                    Desconto = d.DiscountValuePorcent == 0 ? d.DiscountValueReal : d.DiscountValuePorcent,
                    ValorTotal = d.TotalValue,
                    ValorTotalaPagar = d.TotalPayable,
                    ValorPago = d.AmountPaid,
                    Troco = d.ChangeOfMoney
                }).ToList();
        }
    }
}