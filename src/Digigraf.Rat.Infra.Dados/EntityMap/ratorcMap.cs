using Digigraf.Rat.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Infra.Dados.EntityMap
{
    public class ratorcMap : EntityTypeConfiguration<ratorc>
    {
        public ratorcMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_ratorc);

            // Properties
            this.Property(t => t.valor_orc)
                .HasMaxLength(30);

            this.Property(t => t.pagto_orc)
                .HasMaxLength(30);

            this.Property(t => t.fpagto_orc)
                .HasMaxLength(60);

            this.Property(t => t.banco_orc)
                .HasMaxLength(60);

            this.Property(t => t.prazo_orc)
                .HasMaxLength(60);

            this.Property(t => t.imposto_orc)
                .HasMaxLength(30);

            this.Property(t => t.garantia_orc)
                .HasMaxLength(60);

            this.Property(t => t.frete_orc)
                .HasMaxLength(30);

            this.Property(t => t.validade_orc)
                .HasMaxLength(30);

            this.Property(t => t.servico_orc)
                .HasMaxLength(256);

            this.Property(t => t.teste)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ratorc");
            this.Property(t => t.cod_ratorc).HasColumnName("cod_ratorc");
            this.Property(t => t.cod_rat).HasColumnName("cod_rat");
            this.Property(t => t.valor_orc).HasColumnName("valor_orc");
            this.Property(t => t.pagto_orc).HasColumnName("pagto_orc");
            this.Property(t => t.fpagto_orc).HasColumnName("fpagto_orc");
            this.Property(t => t.banco_orc).HasColumnName("banco_orc");
            this.Property(t => t.prazo_orc).HasColumnName("prazo_orc");
            this.Property(t => t.imposto_orc).HasColumnName("imposto_orc");
            this.Property(t => t.garantia_orc).HasColumnName("garantia_orc");
            this.Property(t => t.frete_orc).HasColumnName("frete_orc");
            this.Property(t => t.validade_orc).HasColumnName("validade_orc");
            this.Property(t => t.servico_orc).HasColumnName("servico_orc");
            this.Property(t => t.teste).HasColumnName("teste");

            // Relationships
            this.HasOptional(t => t.rat)
                .WithMany(t => t.ratorcs)
                .HasForeignKey(d => d.cod_rat);

        }
    }
}
