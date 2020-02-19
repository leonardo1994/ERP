using Esr.Core.Domain.Parameters;

namespace Esr.Module.Parking.Domain
{
    public class ParkingParameter : Parameter
    {
        public ParkingParameter()
        {
        }

        /// <summary>
        /// Tabela de Preço Padrão, que será utilizada na entrada de veículos do estacionamento.
        /// </summary>
        public int? StandardTableOfPriceId { get; set; }
        public virtual ParkingTableOfPrice StandardTableOfPrice { get; set; }
    }
}