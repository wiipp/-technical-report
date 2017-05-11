using Digigraf.Rat.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Infra.Dados.EntityMap
{
    public class pendenciaMap : EntityTypeConfiguration<pendencia>
    {
        public pendenciaMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_pen);

            // Properties
            this.Property(t => t.des_pen)
                .HasMaxLength(150);

            this.Property(t => t.a1_cod)
                .HasMaxLength(6);

            this.Property(t => t.fecha_pen)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.empresa)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("pendencias");
            this.Property(t => t.cod_pen).HasColumnName("cod_pen");
            this.Property(t => t.des_pen).HasColumnName("des_pen");
            this.Property(t => t.a1_cod).HasColumnName("a1_cod");
            this.Property(t => t.cod_tec).HasColumnName("cod_tec");
            this.Property(t => t.fecha_pen).HasColumnName("fecha_pen");
            this.Property(t => t.cod_rat).HasColumnName("cod_rat");
            this.Property(t => t.empresa).HasColumnName("empresa");

            // Relationships
            this.HasOptional(t => t.tecnico)
                .WithMany(t => t.pendencias)
                .HasForeignKey(d => d.cod_tec);

        }
    }
}
