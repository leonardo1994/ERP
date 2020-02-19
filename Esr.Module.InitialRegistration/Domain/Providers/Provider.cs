using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Esr.Core.Domain.Authentication;
using Esr.Module.InitialRegistration.Domain.StockItems;
using System.Collections.Generic;

namespace Esr.Module.InitialRegistration.Domain.Providers
{
    [DisplayName(@"Fornecedor")]
    public class Provider : LegalPerson
    {
        [DisplayName(@"Fornecedor"), Required]
        public override string PersonName { get; set; }

        public virtual ICollection<ItemSuppliers> ItemSuppliers { get; set; }
    }
}
