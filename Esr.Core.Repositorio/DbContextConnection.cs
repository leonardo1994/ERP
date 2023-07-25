using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data.Entity;
using System.Reflection;
using Esr.Core.Domain.RepositoryFactory;
using System;
using System.Data.Entity.Validation;
using System.Text;
using DbUpdateException = System.Data.Entity.Infrastructure.DbUpdateException;
using System.Configuration;

namespace Esr.Core.Repository
{
    // Autor: LEONARDO TEIXEIRA DOS SANTOS SILVA
    // CNPJ: 23.416.009/0001-83
    // 2015 ©LEONARDO TEIXEIRA DOS SANTOS SILVA 43342439831 | Todos os Direitos  Reservados
    public class DbContextConnection : System.Data.Entity.DbContext, IFactoryConnection
    {
        [ImportMany(typeof(IFactoryConnection))]
        public IEnumerable<IFactoryConnection> FactoryConnection { get; set; }

        public DbContextConnection()
         : base(ConfigurationManager.AppSettings["ConnectionString"])
         //: base(@"Server=localhost,1433;Database=ESR;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;")
         //: base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\custy\OneDrive\Projetos\ESR Softwares\ERP\Esr.Core.Repositorio\BancoESR.mdf';Integrated Security=True")
         //: base(@"Data Source =(local);Initial Catalog = ESR; Integrated Security = True")
         //: base(@"Data Source=SERGIO-PC\SQLEXPRESS;Initial Catalog=ESR; Persist Security Info=True;User ID=sa;Password=Esr@2016")
         //: base(@"Data Source=DOCUMENTO-01\SQLEXPRESS;Initial Catalog=ESR; Persist Security Info=True;User ID=sa;Password=Esr@2016")
         //:base(@"Data Source=URANO\SQLEXPRESS;Initial Catalog=ESR; Persist Security Info=True;User ID=sa;Password=849sistemasMs")
         //:base(@"Data Source=NT1\FUNERARIA;Initial Catalog=ESR; Persist Security Info=True;User ID=sa;Password=849sistemasMs")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbContextConnection, Migrations.Configuration>());
            //Database.SetInitializer<DbContextConnection>(null);
            Configuration.LazyLoadingEnabled = false;
            var ensureDllIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var catalog = new AggregateCatalog(new AssemblyCatalog(Assembly.GetExecutingAssembly()), new DirectoryCatalog("."));
            var container = new CompositionContainer(catalog);
            container.ComposeParts(this);

            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));

            foreach (var plugin in FactoryConnection)
                plugin.Setup(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        public virtual void Setup(DbModelBuilder modelBuilder)
        {
        }

        public bool Save()
        {
            try
            {
                return SaveChanges() > 0;
            }
            catch (DbEntityValidationException e)
            {
                var messageError = new StringBuilder();
                foreach (var eve in e.EntityValidationErrors)
                {
                    messageError.AppendLine(string.Format("Entidade do tipo \"{0}\" no estado \"{1}\" tem os seguintes erros de validação:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        messageError.AppendLine(string.Format("- Property: \"{0}\", Erro: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage));
                    }
                }
                throw new Exception(messageError.ToString(), e);
            }
            catch (DbUpdateException ex)
            {
                var messageError = new StringBuilder();

                Exception oldEx = new Exception();
                messageError.AppendLine(ex.Message);
                oldEx = ex.InnerException;
                while (oldEx != null)
                {
                    messageError.AppendLine(oldEx.Message);
                    oldEx = oldEx.InnerException;
                }
                throw new Exception(messageError.ToString());
            }
        }

        public void BeginTransaction()
        {
            Database.BeginTransaction();
        }

        public void Commit()
        {
            Database.CurrentTransaction?.Commit();
        }

        public void Rollback()
        {
            Database.CurrentTransaction?.Rollback();
        }
    }
}

