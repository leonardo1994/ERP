using System.ComponentModel.Composition;
using System.Data.Entity;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.FleetManagement.Domain.Drives;
using Esr.Module.FleetManagement.Domain.Vehicles;

namespace Esr.Module.FleetManagement.Repository
{
    [Export(typeof(IFactoryConnection))]
    public class DbContext : DbContextConnection
    {
        
        public override void Setup(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehiclePlate>();
            modelBuilder.Entity<Vehicle>();
            modelBuilder.Entity<ModelVehicle>();
            modelBuilder.Entity<VehicleModelVehicle>();
            modelBuilder.Entity<ColorModelVehicle>();
            modelBuilder.Entity<Drive>();

            base.Setup(modelBuilder);
        }
    }
}
