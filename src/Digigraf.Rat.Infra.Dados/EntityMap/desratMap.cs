using Digigraf.Rat.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Infra.Dados.EntityMap
{
    public class desratMap : EntityTypeConfiguration<desrat>
    {
        public desratMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_des);

            // Properties
            this.Property(t => t.despesa_des)
                .HasMaxLength(100);

            this.Property(t => t.ok_des)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.tipo_des)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.obj_des)
                .HasMaxLength(100);

            this.Property(t => t.dtprev_des)
                .HasMaxLength(10);

            this.Property(t => t.delet_des)
                .HasMaxLength(1);

            this.Property(t => t.data_des)
                .HasMaxLength(8);

            this.Property(t => t.tp_des)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("desrat");
            this.Property(t => t.cod_des).HasColumnName("cod_des");
            this.Property(t => t.cod_rat).HasColumnName("cod_rat");
            this.Property(t => t.despesa_des).HasColumnName("despesa_des");
            this.Property(t => t.quant_des).HasColumnName("quant_des");
            this.Property(t => t.valor_des).HasColumnName("valor_des");
            this.Property(t => t.ok_des).HasColumnName("ok_des");
            this.Property(t => t.tipo_des).HasColumnName("tipo_des");
            this.Property(t => t.obj_des).HasColumnName("obj_des");
            this.Property(t => t.dtprev_des).HasColumnName("dtprev_des");
            this.Property(t => t.delet_des).HasColumnName("delet_des");
            this.Property(t => t.data_des).HasColumnName("data_des");
            this.Property(t => t.tp_des).HasColumnName("tp_des");
            this.Property(t => t.cod_tec).HasColumnName("cod_tec");

            // Relationships
            this.HasOptional(t => t.rat)
                .WithMany(t => t.desrats)
                .HasForeignKey(d => d.cod_rat);

        }
    }
}
