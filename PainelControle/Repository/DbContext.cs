using System.ComponentModel.Composition;
using System.Data.Entity;
using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.Queries;
using Esr.Core.Domain.RepositoryFactory;
using Esr.Core.Domain.Translation;
using Esr.Core.Domain.ConfNumbering;
using Esr.Core.Domain.FiltersCompanies;
using Esr.Core.Domain.Parameters;
using Esr.Core.Repository;

namespace Esr.Module.ControlPainel.Repository
{
    [Export(typeof(IFactoryConnection))]
    public class DbContext : DbContextConnection
    {
        public override void Setup(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Translate>().ToTable("Translate");
            modelBuilder.Entity<GroupAccess>().ToTable("GroupAccess");
            modelBuilder.Entity<Permission>().ToTable("Permission");
            modelBuilder.Entity<GroupPermission>().ToTable("GroupPermission");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Company>().ToTable("Company");
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<LegalPerson>().ToTable("LegalPerson");
            modelBuilder.Entity<GroupUser>().ToTable("GroupUser");
            modelBuilder.Entity<Query>().ToTable("Query");
            modelBuilder.Entity<Filter>().ToTable("Filter");
            modelBuilder.Entity<InactiveFilters>().ToTable("InactiveFilters");
            modelBuilder.Entity<Consult>().ToTable("Consult");
            modelBuilder.Entity<ConsultForm>().ToTable("ConsultForm");
            modelBuilder.Entity<Report>().ToTable("Report");
            modelBuilder.Entity<ReportForm>().ToTable("ReportForm");
            modelBuilder.Entity<AutomaticNumbering>().ToTable("AutomaticNumbering");
            modelBuilder.Entity<DbTable>().ToTable("DbTable");
            modelBuilder.Entity<FilterCompany>().ToTable("FilterCompany");
            modelBuilder.Entity<Parameter>().ToTable("Parameters");

            // Configurando tabelas de muitos para muitos.
            modelBuilder.Entity<User>().HasMany(c => c.UsersCompanies)
                .WithRequired(c => c.User)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<Company>().HasMany(c => c.UsersCompanies)
                .WithRequired(c => c.Company)
                .HasForeignKey(c => c.CompanyId);

            // Configurando tabelas de muitos para muitos.
            modelBuilder.Entity<User>().HasMany(c => c.GroupUsers)
                .WithRequired(c => c.User)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<GroupAccess>().HasMany(c => c.GroupUsers)
                .WithRequired(c => c.GroupAccess)
                .HasForeignKey(c => c.GroupAccessId);

            modelBuilder.Entity<Filter>().Property(c => (int)c.TypeComponent);
            modelBuilder.Entity<Filter>().Property(c => (int)c.DefaultTypeFilter);

            modelBuilder.Entity<FilterCompany>()
                .HasOptional(c => c.CompanyControl)
                .WithMany(c => c.FiltersCompanies)
                .HasForeignKey(c => c.CompanyControlId);

            modelBuilder.Entity<FilterCompany>()
                .HasRequired(c => c.CompanyLeft)
                .WithMany()
                .HasForeignKey(c => c.CompanyLeftId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<FilterCompany>()
                .HasRequired(c => c.CompanyRight)
                .WithMany()
                .HasForeignKey(c => c.CompanyRightId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<FilterCompany>()
                .HasRequired(c => c.DbTable)
                .WithMany(c => c.FilterCompanies)
                .HasForeignKey(c => c.DbTableId)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<DbTable>()
                .HasMany(c => c.AutomaticNumberings)
                .WithRequired(c => c.DbTable)
                .HasForeignKey(c => c.DbTableId)
                .WillCascadeOnDelete(true);

            base.Setup(modelBuilder);
        }
    }
}