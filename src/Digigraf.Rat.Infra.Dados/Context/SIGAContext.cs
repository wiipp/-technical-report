using Digigraf.Rat.Dominio.Entidades.SIGA;
using Digigraf.Rat.Infra.Dados.EntityMap.SIGA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Infra.Dados.Context
{
   public class SIGAContext :DbContext
    {
        public SIGAContext()
            :base("ConexaoSIGA")
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

            Database.SetInitializer<SIGAContext>(null);
        }

        public DbSet<SA1110> SA1110 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SA1110Map());

            base.OnModelCreating(modelBuilder);
        }


    }
}
