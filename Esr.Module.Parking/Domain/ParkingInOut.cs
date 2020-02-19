using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;
using Esr.Module.FleetManagement.Domain.Vehicles;
using Esr.Module.InitialRegistration.Domain.Persons;
using Esr.Module.InitialRegistration.Domain.Sales;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esr.Module.Parking.Domain
{
    /// <summary>
    /// Entrada e Saída de Estacionamento
    /// </summary>
    [Table("ParkingInOut")]
    [DisplayName("Entrada e Saída de Estacionamento")]
    public class ParkingInOut : IEntityBase
    {
        public int Id { get; set; }
        public DateTime? DateRegistration { get; set; }
        public DateTime? DateUpdate { get; set; }
        public Company CompanyControl { get; set; }
        public int? CompanyControlId { get; set; }
        public int? UserControlId { get; set; }
        public bool Integration { get; set; }
        public Status Status { get; set; }
        public User UserControl { get; set; }

        /// <summary>
        /// Número do Ticket
        /// </summary>
        [Required]
        [DisplayName("Número do Bilhete")]
        public decimal TicketNumber { get; set; }

        /// <summary>
        /// Data e Hora de Entrada
        /// </summary>
        [Required]
        [DisplayName("Data e Hora de Entrada")]
        public DateTime ParkingDateTimeInput { get; set; }

        /// <summary>
        /// Data e Hora de Saída
        /// </summary>
        [DisplayName("Data e Hora de Saída")]
        public DateTime? ParkingDateTimeOutput { get; set; }

        /// <summary>
        /// Placa do Veículo
        /// </summary>
        [Required]
        [DisplayName("Placa do Veículo")]
        public int VehiclePlateId { get; set; }
        public VehiclePlate VehiclePlate { get; set; }

        /// <summary>
        /// Cliente
        /// </summary>
        [DisplayName("Cliente")]
        public int? PhysicalPersonId { get; set; }
        public virtual PhysicalPerson PhysicalPerson { get; set; }

        /// <summary>
        /// Tabela de Preço
        /// </summary>
        [Required]
        [DisplayName("Tabela de Preço")]
        public int ParkingTableOfPriceId { get; set; }
        public virtual ParkingTableOfPrice ParkingTableOfPrice { get; set; }

        /// <summary>
        /// Item da Tabela de Preço
        /// </summary>
        [Required, DependencyKey("ParkingTableOfPriceId"), DisplayName("Item da Tabela de Preço")]
        public int ParkingItemTableOfPriceId { get; set; }
        public virtual ParkingItemTableOfPrice ParkingItemTableOfPrice { get; set; }

        /// <summary>
        /// Forma de Pagamento
        /// </summary>
        [DisplayName("Forma de Pagamento")]
        public int? FormOfPaymentId { get; set; }
        public virtual FormOfPayment FormOfPayment { get; set; }

        /// <summary>
        /// Convênio
        /// </summary>
        [DisplayName("Convênio")]
        public int? ParkingAgreementId { get; set; }
        public virtual ParkingAgreement ParkingAgreement { get; set; }

        /// <summary>
        /// Desconto R$
        /// </summary>
        [DisplayName("Desconto R$")]
        [OperationValue("TotalValue", "TotalPayable", Core.Domain.EnumBase.TypeOperation.Subtraction)]
        public decimal DiscountValueReal { get; set; }

        /// <summary>
        /// Desconto %
        /// </summary>
        [DisplayName("Desconto %")]
        [OperationValue("TotalValue", "TotalPayable", Core.Domain.EnumBase.TypeOperation.SubtractionPorcent)]
        public decimal DiscountValuePorcent
        { get; set; }

        /// <summary>
        /// Valor Total
        /// </summary>
        [DisplayName("Valor Total")]
        public decimal TotalValue { get; set; }

        /// <summary>
        /// Total a Pagar
        /// </summary>
        [DisplayName("Total a Pagar")]
        public decimal TotalPayable { get; set; }

        /// <summary>
        /// Valor Pago
        /// </summary>
        [OperationValue("TotalPayable", "ChangeOfMoney", Core.Domain.EnumBase.TypeOperation.SubtractionInversion)]
        [DisplayName("Valor Pago")]
        public decimal AmountPaid { get; set; }

        /// <summary>
        /// Troco
        /// </summary>
        [DisplayName("Troco")]
        public decimal ChangeOfMoney { get; set; }

        public int ClosedId { get { return (int)Closed; } set { Closed = (YesNo)ClosedId; } }
        public YesNo Closed { get; set; }
    }
}