using Digigraf.Rat.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Infra.Dados.EntityMap
{
    public class prodratMap : EntityTypeConfiguration<prodrat>
    {
        public prodratMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_pro);

            // Properties
            this.Property(t => t.b1_cod)
                .HasMaxLength(15);

            this.Property(t => t.data_pro)
                .HasMaxLength(10);

            this.Property(t => t.estorno_pro)
                .HasMaxLength(10);

            this.Property(t => t.transf_pro)
                .HasMaxLength(1);

            this.Property(t => t.dttransf_pro)
                .HasMaxLength(10);

            this.Property(t => t.descri_pro)
                .HasMaxLength(100);

            this.Property(t => t.status_pro)
                .HasMaxLength(20);

            this.Property(t => t.c5_num_pro)
                .HasMaxLength(15);

            this.Property(t => t.obs)
                .HasMaxLength(1500);

            this.Property(t => t.rem_nf_pro)
                .HasMaxLength(15);

            this.Property(t => t.nac_nf_pro)
                .HasMaxLength(15);

            this.Property(t => t.obs_est_pro)
                .HasMaxLength(1500);

            this.Property(t => t.est_ori_pro)
                .HasMaxLength(5);

            this.Property(t => t.est_dest_pro)
                .HasMaxLength(5);

            this.Property(t => t.d3_doc)
                .HasMaxLength(50);

            this.Property(t => t.random)
                .HasMaxLength(20);

            this.Property(t => t.delet_pro)
                .HasMaxLength(1);

            this.Property(t => t.situacao_pro)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("prodrat");
            this.Property(t => t.cod_pro).HasColumnName("cod_pro");
            this.Property(t => t.cod_rat).HasColumnName("cod_rat");
            this.Property(t => t.b1_cod).HasColumnName("b1_cod");
            this.Property(t => t.quant_pro).HasColumnName("quant_pro");
            this.Property(t => t.valor_pro).HasColumnName("valor_pro");
            this.Property(t => t.data_pro).HasColumnName("data_pro");
            this.Property(t => t.estorno_pro).HasColumnName("estorno_pro");
            this.Property(t => t.transf_pro).HasColumnName("transf_pro");
            this.Property(t => t.dttransf_pro).HasColumnName("dttransf_pro");
            this.Property(t => t.descri_pro).HasColumnName("descri_pro");
            this.Property(t => t.status_pro).HasColumnName("status_pro");
            this.Property(t => t.c5_num_pro).HasColumnName("c5_num_pro");
            this.Property(t => t.obs).HasColumnName("obs");
            this.Property(t => t.rem_nf_pro).HasColumnName("rem_nf_pro");
            this.Property(t => t.nac_nf_pro).HasColumnName("nac_nf_pro");
            this.Property(t => t.obs_est_pro).HasColumnName("obs_est_pro");
            this.Property(t => t.status_aprov).HasColumnName("status_aprov");
            this.Property(t => t.est_ori_pro).HasColumnName("est_ori_pro");
            this.Property(t => t.est_dest_pro).HasColumnName("est_dest_pro");
            this.Property(t => t.d3_doc).HasColumnName("d3_doc");
            this.Property(t => t.random).HasColumnName("random");
            this.Property(t => t.delet_pro).HasColumnName("delet_pro");
            this.Property(t => t.situacao_pro).HasColumnName("situacao_pro");

            // Relationships
            this.HasOptional(t => t.rat)
                .WithMany(t => t.prodrats)
                .HasForeignKey(d => d.cod_rat);

        }
    }
}
