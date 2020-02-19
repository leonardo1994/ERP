using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Core.Domain.EnumBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esr.Module.Parking.Domain
{
    [Table("ParkingTableOfPrice")]
    [DisplayName("Tabela de Preço Estacionamento")]
    public class ParkingTableOfPrice : IEntityBase
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

        [Unique]
        [Required]
        [DisplayName("Código")]
        public string Code { get; set; }

        [Required]
        [DisplayName("Descrição")]
        public string Description { get; set; }

        public int SituationId { get { return (int)Situation; } set { Situation = (Situation)value; } }
        [Required]
        public Situation Situation { get; set; }

        public virtual ICollection<ParkingInOut> ListParkingInOut { get; set; }
        public virtual ICollection<ParkingItemTableOfPrice> ParkingItemsTableOfPrice { get; set; }
    }
}