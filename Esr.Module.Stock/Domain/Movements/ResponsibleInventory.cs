using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.ClassBase;
using System;
using System.Collections.Generic;

namespace Esr.Module.Stock.Domain.Movements
{
    public class ResponsibleInventory : IEntityBase
    {
        public Company CompanyControl { get; set; }
        public int? CompanyControlId { get; set; }
        public DateTime? DateRegistration { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int Id { get; set; }
        public bool Integration { get; set; }
        public Status Status { get; set; }
        public User UserControl { get; set; }
        public int? UserControlId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Inventory> Inventories{ get; set; }
    }
}