using System.ComponentModel.Composition;
using System.Data.Entity;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Core.ManagementReportConsult.Domain;

namespace Esr.Module.ControlPainel.Repository
{
    [Export(typeof(IFactoryConnection))]
    public class DbContext : DbContextConnection
    { 
        public override void Setup(DbModelBuilder modelBuilder)
        {
            

            base.Setup(modelBuilder);
        }
    }
}
