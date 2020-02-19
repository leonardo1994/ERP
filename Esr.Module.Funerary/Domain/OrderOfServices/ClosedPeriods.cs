using System;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Esr.Module.Funerary.Domain.OrderOfServices
{
    [DisplayName("Períodos Fechados")]
    public class ClosedPeriods : IEntityBase
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public Company CompanyControl { get; set; }
        public int? CompanyControlId { get; set; }
        public User UserControl { get; set; }
        public int? UserControlId { get; set; }
        public DateTime? DateRegistration { get; set; }
        public DateTime? DateUpdate { get; set; }
        public bool Integration { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data inicial")]
        public DateTime InitialDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data final")]
        public DateTime FinalDate { get; set; }
    }
}