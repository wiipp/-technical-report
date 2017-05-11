using Digigraf.Rat.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Infra.Dados.EntityMap
{
    public class ratsMap : EntityTypeConfiguration<rat>
    {
        public ratsMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_rat);

            // Properties
            this.Property(t => t.a1_cod)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.dt_rat)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.hr_rat)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.dt_vis_rat)
                .HasMaxLength(10);

            this.Property(t => t.hr_vis_rat)
                .HasMaxLength(5);

            this.Property(t => t.hr_vis_fim_rat)
                .HasMaxLength(5);

            this.Property(t => t.tipo_rat)
                .HasMaxLength(30);

            this.Property(t => t.tipo_o_rat)
                .HasMaxLength(90);

            this.Property(t => t.local_rat)
                .HasMaxLength(30);

            this.Property(t => t.f1_doc)
                .HasMaxLength(9);

            this.Property(t => t.f2_doc)
                .HasMaxLength(9);

            this.Property(t => t.b1_cod)
                .HasMaxLength(30);

            this.Property(t => t.vencto_rat)
                .HasMaxLength(10);

            this.Property(t => t.n_serie_exp)
                .HasMaxLength(50);

            this.Property(t => t.fechado_rat)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.defeito_rat)
                .HasMaxLength(5000);

            this.Property(t => t.c5_num)
                .HasMaxLength(6);

            this.Property(t => t.obs_rat)
                .HasMaxLength(512);

            this.Property(t => t.inst_sw)
                .HasMaxLength(1);

            this.Property(t => t.def_diag_rat)
                .HasMaxLength(200);

            this.Property(t => t.descricao)
                .HasMaxLength(100);

            this.Property(t => t.chamado)
                .HasMaxLength(100);

            this.Property(t => t.c5_nac)
                .HasMaxLength(6);

            this.Property(t => t.dt_abre_cham)
                .HasMaxLength(10);

            this.Property(t => t.dt_fecha_cham)
                .HasMaxLength(10);

            this.Property(t => t.dt_abre_cham_hp)
                .HasMaxLength(10);

            this.Property(t => t.dt_fecha_cham_hp)
                .HasMaxLength(10);

            this.Property(t => t.hr_abre_cham_hp)
                .HasMaxLength(5);

            this.Property(t => t.hr_fecha_cham_hp)
                .HasMaxLength(5);

            this.Property(t => t.solucao)
                .HasMaxLength(5);

            this.Property(t => t.severidade)
                .HasMaxLength(2);

            this.Property(t => t.empresa)
                .HasMaxLength(3);

            this.Property(t => t.tp_serv_rat)
                .HasMaxLength(3);

            this.Property(t => t.obj_serv_rat)
                .HasMaxLength(800);

            this.Property(t => t.tp_cobranca)
                .HasMaxLength(50);

            this.Property(t => t.entregue_rat)
                .HasMaxLength(1);

            this.Property(t => t.email_cli_rat)
                .HasMaxLength(100);

            this.Property(t => t.envia_email_remoto)
                .HasMaxLength(1);

            this.Property(t => t.bloqueio_des)
                .HasMaxLength(1);

            this.Property(t => t.pendencia_rat)
                .HasMaxLength(512);

            this.Property(t => t.data_email)
                .HasMaxLength(50);

            this.Ignore(x => x.ResultadoValidacao);

            this.Ignore(x => x.Mensagem);

            this.Ignore(x => x.Ativo);

            // Table & Column Mappings
            this.ToTable("rat");
            this.Property(t => t.cod_rat).HasColumnName("cod_rat");
            this.Property(t => t.a1_cod).HasColumnName("a1_cod");
            this.Property(t => t.cod_ate).HasColumnName("cod_ate");
            this.Property(t => t.cod_tec).HasColumnName("cod_tec");
            this.Property(t => t.dt_rat).HasColumnName("dt_rat");
            this.Property(t => t.hr_rat).HasColumnName("hr_rat");
            this.Property(t => t.dt_vis_rat).HasColumnName("dt_vis_rat");
            this.Property(t => t.hr_vis_rat).HasColumnName("hr_vis_rat");
            this.Property(t => t.hr_vis_fim_rat).HasColumnName("hr_vis_fim_rat");
            this.Property(t => t.tipo_rat).HasColumnName("tipo_rat");
            this.Property(t => t.tipo_o_rat).HasColumnName("tipo_o_rat");
            this.Property(t => t.local_rat).HasColumnName("local_rat");
            this.Property(t => t.f1_doc).HasColumnName("f1_doc");
            this.Property(t => t.f2_doc).HasColumnName("f2_doc");
            this.Property(t => t.b1_cod).HasColumnName("b1_cod");
            this.Property(t => t.vencto_rat).HasColumnName("vencto_rat");
            this.Property(t => t.n_serie_exp).HasColumnName("n_serie_exp");
            this.Property(t => t.fechado_rat).HasColumnName("fechado_rat");
            this.Property(t => t.valor_rat).HasColumnName("valor_rat");
            this.Property(t => t.m_obra_rat).HasColumnName("m_obra_rat");
            this.Property(t => t.defeito_rat).HasColumnName("defeito_rat");
            this.Property(t => t.c5_num).HasColumnName("c5_num");
            this.Property(t => t.obs_rat).HasColumnName("obs_rat");
            this.Property(t => t.cod_gru).HasColumnName("cod_gru");
            this.Property(t => t.inst_sw).HasColumnName("inst_sw");
            this.Property(t => t.def_diag_rat).HasColumnName("def_diag_rat");
            this.Property(t => t.descricao).HasColumnName("descricao");
            this.Property(t => t.chamado).HasColumnName("chamado");
            this.Property(t => t.c5_nac).HasColumnName("c5_nac");
            this.Property(t => t.dt_abre_cham).HasColumnName("dt_abre_cham");
            this.Property(t => t.dt_fecha_cham).HasColumnName("dt_fecha_cham");
            this.Property(t => t.dt_abre_cham_hp).HasColumnName("dt_abre_cham_hp");
            this.Property(t => t.dt_fecha_cham_hp).HasColumnName("dt_fecha_cham_hp");
            this.Property(t => t.hr_abre_cham_hp).HasColumnName("hr_abre_cham_hp");
            this.Property(t => t.hr_fecha_cham_hp).HasColumnName("hr_fecha_cham_hp");
            this.Property(t => t.solucao).HasColumnName("solucao");
            this.Property(t => t.severidade).HasColumnName("severidade");
            this.Property(t => t.km_cli_rat).HasColumnName("km_cli_rat");
            this.Property(t => t.empresa).HasColumnName("empresa");
            this.Property(t => t.tp_serv_rat).HasColumnName("tp_serv_rat");
            this.Property(t => t.obj_serv_rat).HasColumnName("obj_serv_rat");
            this.Property(t => t.tp_cobranca).HasColumnName("tp_cobranca");
            this.Property(t => t.entregue_rat).HasColumnName("entregue_rat");
            this.Property(t => t.email_cli_rat).HasColumnName("email_cli_rat");
            this.Property(t => t.envia_email_remoto).HasColumnName("envia_email_remoto");
            this.Property(t => t.bloqueio_des).HasColumnName("bloqueio_des");
            this.Property(t => t.pendencia_rat).HasColumnName("pendencia_rat");
            this.Property(t => t.data_email).HasColumnName("data_email");

            // Relationships
            this.HasRequired(t => t.atendente)
                .WithMany(t => t.rats)
                .HasForeignKey(d => d.cod_ate);
            this.HasRequired(t => t.tecnico)
                .WithMany(t => t.rats)
                .HasForeignKey(d => d.cod_tec);

        }
    }
}
