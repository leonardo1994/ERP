using Esr.Core.Repository;
using Esr.Core.Domain.RepositoryFactory;
using System.ComponentModel.Composition;
using System.Data.Entity;
using Esr.Module.Parking.Domain;

namespace Esr.Module.Parking.Repository
{
    [Export(typeof(IFactoryConnection))]
    public class DbContext : DbContextConnection
    {
        public override void Setup(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParkingInOut>();

            modelBuilder.Entity<ParkingTableOfPrice>()
                .HasMany(c => c.ListParkingInOut)
                .WithRequired(c => c.ParkingTableOfPrice)
                .HasForeignKey(c => c.ParkingTableOfPriceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ParkingTableOfPrice>()
                .HasMany(c => c.ParkingItemsTableOfPrice)
                .WithRequired(c => c.ParkingTableOfPrice)
                .HasForeignKey(c => c.ParkingTableOfPriceId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<ParkingItemTableOfPrice>()
                .HasMany(c => c.ParkingHoursVariations)
                .WithRequired(c => c.ParkingItemTableOfPrice)
                .HasForeignKey(c => c.ParkingItemTableOfPriceId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<ParkingHoursVariation>();

            modelBuilder.Entity<ParkingAgreement>()
                .HasMany(c => c.ListParkingInOut)
                .WithOptional(c => c.ParkingAgreement)
                .HasForeignKey(c => c.ParkingAgreementId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ParkingParameter>()
                .HasOptional(c => c.StandardTableOfPrice);

            base.Setup(modelBuilder);
        }
    }
}