using System.ComponentModel.Composition;
using System.Data.Entity;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Repository;
using Esr.Module.Stock.Domain.Movements;
using Esr.Module.Stock.Domain.Integration;

namespace Esr.Module.Stock.Repository
{
    [Export(typeof(IFactoryConnection))]
    public class DbContext : DbContextConnection
    {
        public override void Setup(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InputStock>()
                .HasMany(c => c.ItemInputStocks)
               .WithRequired(c => c.InputStock)
               .HasForeignKey(c => c.InputStockId)
               .WillCascadeOnDelete(true);

            modelBuilder.Entity<ItemInputStock>()
                .HasRequired(c => c.InputStock)
                .WithMany(c => c.ItemInputStocks)
                .HasForeignKey(c => c.InputStockId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<OutputStock>()
               .HasMany(c => c.ItemOutputStocks)
               .WithRequired(c => c.OutputStock)
               .HasForeignKey(c => c.OutputStockId)
               .WillCascadeOnDelete(true);

            modelBuilder.Entity<ItemOutputStock>()
                .HasRequired(c => c.OutputStock)
                .WithMany(c => c.ItemOutputStocks)
                .HasForeignKey(c => c.OutputStockId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Inventory>();

            modelBuilder.Entity<InventoryItems>();

            modelBuilder.Entity<ResponsibleInventory>();

            modelBuilder.Entity<Inventory>()
                .HasRequired(c => c.ResponsibleInventory)
                .WithMany(c => c.Inventories)
                .HasForeignKey(c => c.ResponsibleInventoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IntegrationCapeStock>().ToTable("IntegrationCapeStock");
            modelBuilder.Entity<IntegrationItemsStock>().ToTable("IntegrationItemsStock");

            modelBuilder.Entity<ItemInputStock>()
                .HasRequired(c => c.UnitMeasure)
                .WithMany()
                .HasForeignKey(c => c.UnitMeasureId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemInputStock>()
                .HasRequired(c => c.StandarUnitMeasure)
                .WithMany()
                .HasForeignKey(c => c.StandarUnitMeasureId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemOutputStock>()
                .HasRequired(c => c.UnitMeasure)
                .WithMany()
                .HasForeignKey(c => c.UnitMeasureId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemOutputStock>()
                .HasRequired(c => c.StandarUnitMeasure)
                .WithMany()
                .HasForeignKey(c => c.StandarUnitMeasureId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OutputStock>()
                .HasOptional(c => c.IntegrationCapeStock)
                .WithMany()
                .HasForeignKey(c => c.IntegrationCapeStockId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InputStock>()
                .HasOptional(c => c.IntegrationCapeStock)
                .WithMany()
                .HasForeignKey(c => c.IntegrationCapeStockId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemOutputStock>()
                .HasOptional(c => c.IntegrationItemsStock)
                .WithMany()
                .HasForeignKey(c => c.IntegrationItemsStockId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemOutputStock>()
                .HasOptional(c => c.IntegrationItemsStock)
                .WithMany()
                .HasForeignKey(c => c.IntegrationItemsStockId)
                .WillCascadeOnDelete(false);

            base.Setup(modelBuilder);
        }
    }
}