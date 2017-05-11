using Digigraf.Rat.Dominio.Entidades;
using Digigraf.Rat.Infra.Dados.EntityMap;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Infra.Dados.Context
{
   public class RatContext : DbContext
    {
        public RatContext()
            : base("ConexaoSQL")
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
            
            Database.SetInitializer<RatContext>(null);
        }

        //public DbSet<TB_Rat> Rats { get; set; }

        public DbSet<rat> rats { get; set; }
        public DbSet<atendente> atendentes { get; set; }
        public DbSet<desrat> desrats { get; set; }
        public DbSet<grupo> grupos { get; set; }
        public DbSet<pendencia> pendencias { get; set; }
        public DbSet<prodrat> prodrats { get; set; }
        public DbSet<ratorc> ratorcs { get; set; }
        public DbSet<tecnico> tecnicos { get; set; }
        public DbSet <sx5> sx5s { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ratsMap());
            modelBuilder.Configurations.Add(new atendenteMap());
            modelBuilder.Configurations.Add(new desratMap());
            modelBuilder.Configurations.Add(new grupoMap());
            modelBuilder.Configurations.Add(new pendenciaMap());
            modelBuilder.Configurations.Add(new prodratMap());
            modelBuilder.Configurations.Add(new ratorcMap());
            modelBuilder.Configurations.Add(new tecnicoMap());
            modelBuilder.Configurations.Add(new sx5Map());


            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("dt_rat") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("dt_rat").CurrentValue = DateTime.Now.Date.ToShortDateString(); // aqui altera quando for cadastro de cliente novo

                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("dt_rat").IsModified = false; /// aqui nao grava quando for para alterar cadastro
                }
            }
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        Debug.WriteLine(sb.ToString());
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException("Entity Validation Failed - errors follow:\n" + sb.ToString(), new Exception(sb.ToString())
                ); // Add the original exception as the innerException
            }
        }
    }
}
