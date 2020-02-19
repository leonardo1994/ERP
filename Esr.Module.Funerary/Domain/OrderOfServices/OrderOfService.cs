using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using Esr.Module.Funerary.Domain.Contractors;
using Esr.Module.Funerary.Domain.Plans;
using Esr.Module.Funerary.Domain.Integration.Stock;

namespace Esr.Module.Funerary.Domain.OrderOfServices
{
    [DisplayName(@"Ordem de Serviço")]
    public class OrderOfService : IEntityBase
    {
        [DisplayName(@"Lançamento")]
        public int Id { get; set; }
        public Status Status { get; set; }

        [DisplayName(@"OS"), Required, Unique]
        public string NumberOs { get; set; }

        [DisplayName(@"Data de Emissão"), Required, Column(TypeName = "datetime2", Order = 4), DataType(DataType.Date)]
        public DateTime DateOfIssure { get; set; }

        [DisplayName(@"Sinistro"), Unique]
        public string Sinister { get; set; }

        [DisplayName(@"Nota Contratual")]
        public string ContractualNote { get; set; }

        [DisplayName(@"Informações Gerais")]
        public string GeneralInformation { get; set; }

        [DisplayName(@"Nome do Falecido")]
        public string DeadName { get; set; }

        [DisplayName(@"Local do Falecimento")]
        public string PlaceOfDead { get; set; }

        [DisplayName(@"Local do Sepultamento")]
        public string BurialPlace { get; set; }

        [DisplayName(@"Local do Velório")]
        public string WakeLocation { get; set; }

        [DisplayName(@"Data do Falecimento"), Column(TypeName = "datetime2")]
        public DateTime? DateOfDead { get; set; }

        [DisplayName(@"Data do Sepultamento"), Column(TypeName = "datetime2")]
        public DateTime? BurialDate { get; set; }

        [DataType(DataType.Time)]
        [DisplayName(@"Hora do Sepultamento"), Column(TypeName = "datetime2")]
        public DateTime? BurialTime { get; set; }

        [DisplayName(@"Peso do Falecido")]
        public decimal WeigthDeceadesed { get; set; }

        [DisplayName(@"Altura do Falecido")]
        public decimal HeightDeceadesed { get; set; }

        [DisplayName(@"Nome do responsável")]
        public string ResponsibleName { get; set; }

        [DisplayName(@"Telefone 1")]
        public string Phone1 { get; set; }

        [DisplayName(@"Telefone 2")]
        public string Phone2 { get; set; }

        [DisplayName(@"Titular do Plano")]
        public string PlanHolder { get; set; }

        [DisplayName(@"Plano")]
        public int? PlanId { get; set; }
        public virtual Plan Plan { get; set; }

        [DisplayName(@"Atendente"), Required]
        public int  UserId { get; set; }
        public virtual User User { get; set; }

        [DisplayName(@"Contratante")]
        public int? ContractorId { get; set; }
        public virtual Contractor Contractor { get; set; }

        public DateTime? DateUpdate { get; set; }
        public DateTime? DateRegistration { get; set; }
        public int? UserControlId { get; set; }
        public User UserControl { get; set; }
        public int? CompanyControlId { get; set; }
        public Company CompanyControl { get; set; }

        public bool Integration { get; set; }

        public virtual ICollection<OsDocument> OsDocuments { get; set; }
        public virtual ICollection<OsService> OsServices { get; set; }
        public virtual ICollection<OsVehicle> OsVehicles { get; set; }
        public virtual ICollection<OsProduct> OsProducts { get; set; }
        public virtual ICollection<OsContractorService> OsContractorServices { get; set; }
        public virtual ICollection<OsContractorProduct> OsContractorProducts { get; set; }

        public virtual ICollection<OutputStockFunerary> OutputStockFunerary { get; set; }
    }
}