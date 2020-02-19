using Esr.Core.Domain.Authentication;
using Esr.Core.Domain.FiltersCompanies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Esr.Core.Repository.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DbContextConnection>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        
        protected override void Seed(DbContextConnection context)
        {

            // Crio um dicionário para guardar nome da tabela e o nome da Classe
            IDictionary<string, string> listOfTables = new Dictionary<string, string>();

            var metadata = ((IObjectContextAdapter)context).ObjectContext.MetadataWorkspace;
            var tables = metadata.GetItemCollection(DataSpace.SSpace)
                .GetItems<EntityContainer>()
                .Single()
                .BaseEntitySets
                .OfType<EntitySet>();
            foreach (var table in tables)
            {
                if (!listOfTables.Any(c => c.Key == table.Name))
                    listOfTables.Add(table.Name, table.Table);
            }

            // Pesquiso em todas as Dlls da Esr, as classes existentes.
            List<Assembly> allAssemblies = new List<Assembly>();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            foreach (string dll in Directory.GetFiles(path, "*.dll"))
                if (dll.Contains("Esr"))
                    allAssemblies.Add(Assembly.LoadFile(dll));

            IList<DbTable> dbTables = new List<DbTable>();
            foreach (var item in allAssemblies)
            {
                Type[] Types = item.GetTypes().Where(c => c.GetInterfaces().Any(d => d.Name == "IEntityBase")).ToArray();
                foreach (Type T in Types)
                {
                    var result = listOfTables.FirstOrDefault(c => c.Key == T.Name).Value;
                    if (result == null || dbTables.Any(c => c.TableName == T.Name)) continue;
                    // Atualizo o catalago de tabelas do banco.
                    var itemTable = context.Set<DbTable>().SingleOrDefault(c => c.TableName == T.Name);

                    if (itemTable == null)
                    {
                        dbTables.Add(new DbTable()
                        {
                            TableName = T.Name,
                            TableDescription = T?.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? "Sem Descrição",
                            DateRegistration = DateTime.Now
                        });
                    }
                    else
                    {
                        itemTable.TableDescription = T?.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? "Sem Descrição";
                        context.Entry(itemTable).State = System.Data.Entity.EntityState.Modified;
                        dbTables.Add(itemTable);
                    }
                        
                }
            }

            foreach (var item in dbTables)
            {
                context.Set<DbTable>().AddOrUpdate(c => c.TableName, item);
            }

            context.SaveChanges();

            var arrayDbTables = dbTables.ToArray();

            foreach (var item in dbTables.Distinct())
            {
                var dbTable = context.Set<DbTable>().FirstOrDefault(c => c.TableName == item.TableName);
                var users = context.Set<User>().FirstOrDefault(c => c.IsAdministrator);
                var companies = context.Set<Company>().ToList();
                var companyMatriz = companies.FirstOrDefault(c => c.TypeCompany == Domain.EnumBase.TypeCompany.Matriz);
                foreach (var company in companies)
                {
                    var result = context.Set<FilterCompany>().Any(c => c.DbTableId == item.Id && c.CompanyLeftId == company.Id);

                    if (context.Set<FilterCompany>().Any(c => c.DbTableId == item.Id && c.CompanyLeftId == company.Id))
                        continue;

                    context.Set<FilterCompany>().Add(
                     new FilterCompany()
                     {
                         DateUpdate = DateTime.Now,
                         DateRegistration = DateTime.Now,
                         CompanyControlId = companyMatriz.Id,
                         UserControlId = users.Id,
                         DbTableId = dbTable.Id,
                         CompanyLeftId = company.Id,
                         CompanyRightId = company.Id
                     });
                }
            }

            context.SaveChanges();


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

        }
        
    }
}