using System.ComponentModel.Composition;
using System.Data.Entity;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.Funerary.Domain.Contractors;
using Esr.Module.Funerary.Domain.DataDeceaseds;
using Esr.Module.Funerary.Domain.DebitNotes;
using Esr.Module.Funerary.Domain.GroupAttendants;
using Esr.Module.Funerary.Domain.OrderOfServices;
using Esr.Module.Funerary.Domain.Plans;
using Esr.Module.Funerary.Domain.Religions;
using Esr.Core.Repository;
using Esr.Module.Funerary.Domain.Integration.Stock;

namespace Esr.Module.Funerary.Repository
{
    [Export(typeof(IFactoryConnection))]
    public class DbContext : DbContextConnection
    {
        public override void Setup(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contractor>().ToTable("Contractor");

            modelBuilder.Entity<DataDeceased>().ToTable("DataDeceased");

            modelBuilder.Entity<DebitNote>().ToTable("DebitNote");

            modelBuilder.Entity<Attendant>().ToTable("Attendant");
            modelBuilder.Entity<GroupAttendant>().ToTable("GroupAttendant");

            modelBuilder.Entity<OrderOfService>().ToTable("OrderOfService");
            modelBuilder.Entity<OsContractorProduct>().ToTable("OsContractorProduct");
            modelBuilder.Entity<OsContractorService>().ToTable("OsContractorService");
            modelBuilder.Entity<OsDocument>().ToTable("OsDocument");
            modelBuilder.Entity<OsProduct>().ToTable("OsProduct");
            modelBuilder.Entity<OsService>().ToTable("OsService");
            modelBuilder.Entity<OsVehicle>().ToTable("OsVehicle");

            modelBuilder.Entity<Plan>().ToTable("Plan");

            modelBuilder.Entity<Religion>().ToTable("Religion");

            modelBuilder.Entity<DebitNote>()
                .HasOptional(c => c.UserControl)
                .WithMany()
                .HasForeignKey(c => c.UserControlId);

            modelBuilder.Entity<DebitNote>()
                .HasOptional(c => c.CompanyControl)
                .WithMany()
                .HasForeignKey(c => c.CompanyControlId);

            modelBuilder.Entity<Contractor>()
                .HasMany(c => c.OsContractorProducts)
                .WithRequired(c => c.Contractor)
                .HasForeignKey(c => c.ContractorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contractor>()
                .HasMany(c => c.OsContractorServices)
                .WithRequired(c => c.Contractor)
                .HasForeignKey(c => c.ContractorId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OsProduct>()
                .HasRequired(c => c.StockItem)
                .WithMany()
                .HasForeignKey(c => c.StockItemId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OsService>()
                .HasRequired(c => c.Service)
                .WithMany()
                .HasForeignKey(c => c.ServiceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OutputStockFunerary>().ToTable("OutputStockFunerary");
            modelBuilder.Entity<ItemOutputStockFunerary>().ToTable("ItemOutputStockFunerary");

            modelBuilder.Entity<OutputStockFunerary>()
                .HasOptional(c => c.OrderOfService)
                .WithMany(c => c.OutputStockFunerary)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemOutputStockFunerary>()
                .HasOptional(c => c.OsProduct)
                .WithMany(c => c.ItemOutputStockFunerary)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderOfService>()
                .HasMany(c => c.OutputStockFunerary)
                .WithOptional(c => c.OrderOfService)
                .HasForeignKey(c => c.OrderOfServiceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OsProduct>()
                .HasMany(c => c.ItemOutputStockFunerary)
                .WithOptional(c => c.OsProduct)
                .HasForeignKey(c => c.OsProductId)
                .WillCascadeOnDelete(false);
        }
    }
}