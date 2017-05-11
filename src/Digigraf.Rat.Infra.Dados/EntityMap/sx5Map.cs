using Digigraf.Rat.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Infra.Dados.EntityMap
{
   public class sx5Map : EntityTypeConfiguration<sx5>
    {
        public sx5Map()
        {

            // Primary Key
            this.HasKey(t => new { t.cod, t.bloq });

            // Properties
            this.Property(t => t.sistema)
                .HasMaxLength(20);

            this.Property(t => t.campo)
                .HasMaxLength(30);

            this.Property(t => t.valor)
                .HasMaxLength(50);

            this.Property(t => t.cod)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.bloq)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("sx5");
            this.Property(t => t.sistema).HasColumnName("sistema");
            this.Property(t => t.campo).HasColumnName("campo");
            this.Property(t => t.valor).HasColumnName("valor");
            this.Property(t => t.cod).HasColumnName("cod");
            this.Property(t => t.bloq).HasColumnName("bloq");
        }
    }
}
