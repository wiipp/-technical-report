using Digigraf.Rat.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Infra.Dados.EntityMap
{
    public class grupoMap : EntityTypeConfiguration<grupo>
    {
        public grupoMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_gru);

            // Properties
            this.Property(t => t.des_gru)
                .HasMaxLength(50);

            this.Property(t => t.status_gru)
                .HasMaxLength(1);

            this.Property(t => t.delete_gru)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("grupo");
            this.Property(t => t.cod_gru).HasColumnName("cod_gru");
            this.Property(t => t.des_gru).HasColumnName("des_gru");
            this.Property(t => t.status_gru).HasColumnName("status_gru");
            this.Property(t => t.delete_gru).HasColumnName("delete_gru");
        }
    }
}
