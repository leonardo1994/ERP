using System.ComponentModel.Composition;
using System.Data.Entity;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.TaxManagement.Domain.Taxations;

namespace Esr.Module.TaxManagement.Repository
{
    [Export(typeof(IFactoryConnection))]
    public class DbContext : DbContextConnection
    {
        public override void Setup(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taxation>();
            base.Setup(modelBuilder);
        }
    }
}
