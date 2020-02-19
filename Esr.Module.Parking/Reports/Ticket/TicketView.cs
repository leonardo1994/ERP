using System;

namespace Esr.Module.Parking.Reports.Ticket
{
    public class TicketView
    {
        public decimal NumeroTicket { get; set; }

        public DateTime DataInicial { get; set; }

        public DateTime? DataFinal { get; set; }

        public string Placa { get; set; }

        public string Veiculo { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        public string Convenio { get; set; }

        public string FormaPagamento { get; set; }

        public decimal Desconto { get; set; }

        public decimal ValorTotal { get; set; }

        public decimal ValorTotalaPagar { get; set; }

        public decimal ValorPago { get; set; }

        public decimal Troco { get; set; }
    }
}