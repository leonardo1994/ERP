using System.Collections.Generic;
using System.ComponentModel;
using Esr.Core.Domain.Attributes;
using Esr.Core.Domain.Authentication;
using Esr.Module.Funerary.Domain.DebitNotes;
using Esr.Module.Funerary.Domain.OrderOfServices;

namespace Esr.Module.Funerary.Domain.Contractors
{
    [DisplayName(@"Contratada")]
    public class Contractor : LegalPerson
    {
        [Unique]
        [DisplayName(@"Código")]
        public override string Code { get; set; }

        [DisplayName(@"Contratada")]
        public override string PersonName { get; set; }

        public virtual ICollection<DebitNote> DebitNotes { get; set; }
        public virtual ICollection<OrderOfService> OrderOfServices { get; set; }
        public virtual ICollection<OsContractorService> OsContractorServices { get; set; }
        public virtual ICollection<OsContractorProduct> OsContractorProducts { get; set; }
    }
}