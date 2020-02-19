using System.ComponentModel.Composition;
using System.Data.Entity;
using Esr.Core.Domain.Address;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Module.InitialRegistration.Domain.Colors;
using Esr.Module.InitialRegistration.Domain.Providers;
using Esr.Module.InitialRegistration.Domain.RH;
using Esr.Module.InitialRegistration.Domain.Services;
using Esr.Module.InitialRegistration.Domain.StockItems;
using Esr.Module.InitialRegistration.Domain.Sales;
using Esr.Core.Repository;

namespace Esr.Module.InitialRegistration.Repository
{
    [Export(typeof(IFactoryConnection))]
    public class DbContext : DbContextConnection
    {
        public override void Setup(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Composition>();

            modelBuilder.Entity<UnitMeasure>();

            modelBuilder.Entity<StockItem>().HasMany(c => c.SpecialTaxs)
                .WithRequired(c => c.StockItem)
                .HasForeignKey(c => c.StockItemId);

            modelBuilder.Entity<StockItem>()
                .HasMany(c => c.Compositions)
                .WithRequired(c => c.StockItem)
                .HasForeignKey(c => c.StockItemId);

            modelBuilder.Entity<Family>().HasMany(c => c.StockItems)
                .WithOptional(c => c.Family)
                .HasForeignKey(c => c.FamilyId);

            modelBuilder.Entity<FeaturedNcm>();

            modelBuilder.Entity<Mark>().HasMany(c => c.StockItems)
                .WithOptional(c => c.Mark)
                .HasForeignKey(c => c.MarkId);

            modelBuilder.Entity<Model>().HasMany(c => c.StockItems)
                .WithOptional(c => c.Model)
                .HasForeignKey(c => c.ModelId);

            modelBuilder.Entity<Ncm>().HasMany(c => c.StockItems)
                .WithOptional(c => c.Ncm)
                .HasForeignKey(c => c.NcmId);

            modelBuilder.Entity<UnitMeasure>()
                .HasMany(c => c.StockItems)
                .WithRequired(c => c.UnitMeasure)
                .HasForeignKey(c => c.UnitMeasureId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SpecialTax>();

            modelBuilder.Entity<Family>()
                .HasMany(c => c.Families)
                .WithOptional(c => c.FamilyMaster)
                .HasForeignKey(c => c.FamilyMasterId);

            modelBuilder.Entity<LocalStock>()
                .HasMany(c => c.LocalStocks)
                .WithOptional(c => c.LocalStockMaster)
                .HasForeignKey(c => c.LocalStockMasterId);

            modelBuilder.Entity<Provider>().ToTable("Provider");

            modelBuilder.Entity<Service>();

            modelBuilder.Entity<TypeService>();

            modelBuilder.Entity<Color>();

            modelBuilder.Entity<Country>();

            modelBuilder.Entity<State>()
                .HasRequired(c => c.Country)
                .WithMany(c => c.States)
                .HasForeignKey(c => c.CountryId);

            modelBuilder.Entity<City>()
                .HasRequired(c => c.State)
                .WithMany(c => c.Cities)
                .HasForeignKey(c => c.StateId);

            modelBuilder.Entity<PublicPlace>()
                .HasRequired(c => c.Country)
                .WithMany(c => c.PublicPlaces)
                .HasForeignKey(c => c.CountryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PublicPlace>()
                .HasRequired(c => c.State)
                .WithMany(c => c.PublicPlaces)
                .HasForeignKey(c => c.StateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PublicPlace>()
                .HasRequired(c => c.City)
                .WithMany(c => c.PublicPlaces)
                .HasForeignKey(c => c.CityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonAddress>()
                .HasRequired(c => c.Country)
                .WithMany(c => c.PersonAddresses)
                .HasForeignKey(c => c.CountryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonAddress>()
                .HasRequired(c => c.State)
                .WithMany(c => c.PersonAddresses)
                .HasForeignKey(c => c.StateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonAddress>()
                .HasRequired(c => c.City)
                .WithMany(c => c.PersonAddresses)
                .HasForeignKey(c => c.CityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasOptional(c => c.Country)
                .WithMany(c => c.Persons)
                .HasForeignKey(c => c.CountryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasOptional(c => c.State)
                .WithMany(c => c.Persons)
                .HasForeignKey(c => c.StateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Person>()
                .HasOptional(c => c.City)
                .WithMany(c => c.Persons)
                .HasForeignKey(c => c.CityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cbo>();
            modelBuilder.Entity<Function>();
            modelBuilder.Entity<Office>();
            modelBuilder.Entity<ChargeLevel>();
            modelBuilder.Entity<TypePositionFunction>();
            modelBuilder.Entity<NaturePositionFunction>();

            modelBuilder.Entity<UnitMeasureConversion>();

            modelBuilder.Entity<UnitMeasureConversion>()
                .HasRequired(c => c.SecondUnitMeasure)
                .WithMany(c => c.UnitMeasureConversions)
                .HasForeignKey(c => c.SecondUnitMeasureId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemSuppliers>()
                .HasRequired(c => c.StockItem)
                .WithMany(c => c.ItemSuppliers)
                .HasForeignKey(c => c.StockItemId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<ItemSuppliers>()
                .HasRequired(c => c.Provider)
                .WithMany(c => c.ItemSuppliers)
                .HasForeignKey(c => c.ProviderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FormOfPayment>();

            base.Setup(modelBuilder);
        }
    }
}