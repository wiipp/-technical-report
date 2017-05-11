using Digigraf.Rat.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Infra.Dados.EntityMap
{
    public class tecnicoMap : EntityTypeConfiguration<tecnico>
    {
        public tecnicoMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_tec);

            // Properties
            this.Property(t => t.nome_tec)
                .HasMaxLength(50);

            this.Property(t => t.status_tec)
                .HasMaxLength(1);

            this.Property(t => t.a3_cod)
                .HasMaxLength(5);

            this.Property(t => t.usuario)
                .HasMaxLength(50);

            this.Property(t => t.email)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("tecnico");
            this.Property(t => t.cod_tec).HasColumnName("cod_tec");
            this.Property(t => t.nome_tec).HasColumnName("nome_tec");
            this.Property(t => t.status_tec).HasColumnName("status_tec");
            this.Property(t => t.cod_gru).HasColumnName("cod_gru");
            this.Property(t => t.a3_cod).HasColumnName("a3_cod");
            this.Property(t => t.usuario).HasColumnName("usuario");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.salario_tec).HasColumnName("salario_tec");
            this.Property(t => t.fator_tec).HasColumnName("fator_tec");
            this.Property(t => t.horas_tec).HasColumnName("horas_tec");

            // Relationships
            this.HasOptional(t => t.grupo)
                .WithMany(t => t.tecnicoes)
                .HasForeignKey(d => d.cod_gru);

        }
    }
}
