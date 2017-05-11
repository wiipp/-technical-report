using Digigraf.Rat.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Infra.Dados.EntityMap
{
    public class atendenteMap : EntityTypeConfiguration<atendente>
    {
        public atendenteMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_ate);

            // Properties
            this.Property(t => t.nome_ate)
                .HasMaxLength(50);

            this.Property(t => t.status_ate)
                .HasMaxLength(1);

            this.Property(t => t.email_ate)
                .HasMaxLength(40);

            this.Property(t => t.usuario)
                .HasMaxLength(50);

            this.Property(t => t.delete_ate)
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("atendente");
            this.Property(t => t.cod_ate).HasColumnName("cod_ate");
            this.Property(t => t.nome_ate).HasColumnName("nome_ate");
            this.Property(t => t.status_ate).HasColumnName("status_ate");
            this.Property(t => t.email_ate).HasColumnName("email_ate");
            this.Property(t => t.usuario).HasColumnName("usuario");
            this.Property(t => t.delete_ate).HasColumnName("delete_ate");
        }
    }
}
