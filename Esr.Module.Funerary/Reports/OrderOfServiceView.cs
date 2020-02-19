using System;
using System.Collections.Generic;

namespace Esr.Module.Funerary.Reports
{
    public class OrderOfServiceView
    {
        public int Id { get; set; }
        public string DateOs { get; set; }
        public string TimeOs { get; set; }
        public string NumberOs { get; set; }
        public string DeadName { get; set; }
        public string ResponsibleName { get; set; }
        public string PlaceOfDead { get; set; }
        public string BurialPlace { get; set; }
        public string WakeLocation { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string PlanDescription { get; set; }
        public string Sinister { get; set; }
        public DateTime DateOfDead { get; set; }
        public string BurialDate { get; set; }
        public string BurialTime { get; set; }
        public string GeneralInformation { get; set; }
        public string PersonName { get; set; }
        public string Cnpj { get; set; }
        public string ContractorId { get; set; }
        public string DriveName { get; set; }
        public string Plate { get; set; }
        public string ServiceDescription { get; set; }
        public string ContractorName { get; set; }
        public string ComercialPhone { get; set; }
        public string CellPhone { get; set; }
        public decimal ValueTotalServices { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string CityName { get; set; }
        public string StateInitials { get; set; }
        public string ZipCode { get; set; }
    }

    public class VehicleView
    {
        public string DriveName { get; set; }
        public string Plate { get; set; }
        public string ServiceDescription { get; set; }
    }

    public class ContractorServices
    {
        public int ContractorId { get; set; }
        public string ContractorName { get; set; }
        public string CommercialPhone { get; set; }
        public string CellPhone { get; set; }
        public string Historico { get; set; }
        public decimal ValueService { get; set; }
    }
}
