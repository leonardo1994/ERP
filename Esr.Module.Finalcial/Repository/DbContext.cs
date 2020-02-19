using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.Financial.Domain;
using Esr.Module.Financial.Domain.Financial;
using Esr.Module.Financial.Domain.Receive;
using System.ComponentModel.Composition;
using System.Data.Entity;

namespace Esr.Module.Financial.Repository
{
    [Export(typeof(IFactoryConnection))]
    public class DbContext : DbContextConnection
    {
        
        public override void Setup(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillsToReceive>();
            modelBuilder.Entity<InstallmentOfAccountsReceivable>();
            modelBuilder.Entity<TypeDocumentFinancial>();


            base.Setup(modelBuilder);
        }
    }
}
