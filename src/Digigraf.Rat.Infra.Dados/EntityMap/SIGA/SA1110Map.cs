using Digigraf.Rat.Dominio.Entidades.SIGA;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Infra.Dados.EntityMap.SIGA
{
    public class SA1110Map : EntityTypeConfiguration<SA1110>
    {
        public SA1110Map()
        {
            // Primary Key
            this.HasKey(t => t.R_E_C_N_O_);

            // Properties
            this.Property(t => t.A1_FILIAL)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_COD)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_LOJA)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_NOME)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.A1_PESSOA)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_NREDUZ)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.A1_END)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.A1_BAIRRO)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.A1_TIPO)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_EST)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_ESTADO)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.A1_CEP)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_COD_MUN)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.A1_MUN)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.A1_REGIAO)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_DSCREG)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_NATUREZ)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.A1_IBGE)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.A1_ENDCOB)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.A1_DDI)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_DDD)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_ENDREC)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.A1_ENDENT)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.A1_TEL)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_TRIBFAV)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_CONTATO)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_FAX)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_CGC)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.A1_TELEX)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.A1_PFISICA)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.A1_INSCR)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.A1_INSCRM)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.A1_PAIS)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_VEND)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_CONTA)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.A1_BCO1)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_BCO2)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_BCO3)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_BCO4)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_BCO5)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_TRANSP)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_TPFRET)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_COND)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_PRIOR)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_RISCO)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_VENCLC)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_CLASSE)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_PRICOM)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_ULTCOM)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_FORMVIS)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_ULTVIS)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_TMPVIS)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.A1_TMPSTD)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.A1_CLASVEN)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_MENSAGE)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_RECISS)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_TRANSF)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_SUFRAMA)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.A1_DTULTIT)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_DTULCHQ)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_TABELA)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_INCISS)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_CXPOSTA)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.A1_ATIVIDA)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.A1_CARGO1)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_CARGO2)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_CARGO3)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_SUPER)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_RTEC)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_RG)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_OBSERV)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.A1_CALCSUF)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_DTNASC)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_CLIFAT)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_GRPTRIB)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_BAIRROC)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.A1_CEPC)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_MUNC)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_ESTC)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_CEPE)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_BAIRROE)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.A1_MUNE)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_ESTE)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_SATIV1)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_SATIV2)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_CODLOC)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_TPISSRS)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_CODPAIS)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.A1_TPESSOA)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_SATIV3)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_SATIV4)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_SATIV5)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_SATIV6)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_SATIV7)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_SATIV8)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_CODMARC)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_CODAGE)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_TIPCLI)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_EMAIL)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.A1_DEST_1)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_DEST_2)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_CODMUN)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.A1_HPAGE)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.A1_DEST_3)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.A1_CBO)
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.A1_CNAE)
                .IsRequired()
                .HasMaxLength(9);

            this.Property(t => t.A1_CONDPAG)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.A1_OBS)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_AGREG)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.A1_CODHIST)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_RECINSS)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_RECCOFI)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_RECCSLL)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_RECPIS)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_TIPPER)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_CONTAB)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_B2B)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_GRPVEN)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_CLICNV)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_INSCRUR)
                .IsRequired()
                .HasMaxLength(18);

            this.Property(t => t.A1_MSBLQL)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_SITUA)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_NUMRA)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_SUBCOD)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_CDRDES)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_FILDEB)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_CODFOR)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_ABICS)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.A1_BLEMAIL)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_TIPOCLI)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_VINCULO)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_DTINIV)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_DTFIMV)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_LOCCONS)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_CODMUNE)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.A1_HRTRANS)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.A1_UNIDVEN)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_TIPPRFL)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_PRF_VLD)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_PRF_COD)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_REGPB)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_USADDA)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_SIMPLES)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_CTARE)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_FRETISS)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_CODSIAF)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.A1_CEINSS)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.A1_REGESIM)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_IPWEB)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.A1_IRBAX)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_ENDNOT)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_RESERVE)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_NIF)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.A1_IDHIST)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.A1_INDRET)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_ABATIMP)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_CONTRIB)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_INCULT)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_TDA)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_ORIGEM)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_ENTID)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_MINIRF)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_TIMEKEE)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_RECIRRF)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_COMPLEM)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.A1_MATFUN)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_FILTRF)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_FOMEZER)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_CODFID)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.A1_SIMPNAC)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_ALIFIXA)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_RFABOV)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_TPDP)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_RFACS)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_TPJ)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_CRDMA)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_PRSTSER)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_RECFET)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_IENCONT)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_ORIGCT)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_HRCAD)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.A1_ENTORI)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_DTCAD)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_IMGUMOV)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.A1_RESFAT)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_IDESTN)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.A1_CLIPRI)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_LOJPRI)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_TPCAMP)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_CHVCAM)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.A1_INOVAUT)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_TPNFSE)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_OUTRMUN)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.A1_CODSEG)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_TPREG)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_MSEXP)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_ISSRSLC)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_USERLGA)
                .IsRequired()
                .HasMaxLength(17);

            this.Property(t => t.A1_HREXPO)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_USERLGI)
                .IsRequired()
                .HasMaxLength(17);

            this.Property(t => t.A1_TPMEMB)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_CODTER)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_CODMEMB)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_SANGUE)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_CONT)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_R_G)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_SOC_A)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.A1_SOC_B)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.A1_SOC_C)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.A1_SOC_D)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.A1_SOC_E)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.A1_BAIRCOB)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.A1_MUNCOB)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.A1_ESTCOB)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_CEPCOB)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_EBAIRRO)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.A1_EMUN)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.A1_EEST)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_ECEP)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_VEND2)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.A1_EMISSAO)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.A1_LEASING)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_MIDIA)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.A1_PRZMAXD)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.D_E_L_E_T_)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.R_E_C_N_O_)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.A1_INDUSTR)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.A1_XCTSUP)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.A1_XESUP)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.A1_XT1SUP)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.A1_XCELSUP)
                .IsRequired()
                .HasMaxLength(11);

            this.Property(t => t.A1_XT2SUP)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.A1_XCTMAQ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.A1_XEMAQ)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.A1_XT1MAQ)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.A1_XT2MAQ)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.A1_CELMAQ)
                .IsRequired()
                .HasMaxLength(11);

            // Table & Column Mappings
            this.ToTable("SA1110");
            this.Property(t => t.A1_FILIAL).HasColumnName("A1_FILIAL");
            this.Property(t => t.A1_COD).HasColumnName("A1_COD");
            this.Property(t => t.A1_LOJA).HasColumnName("A1_LOJA");
            this.Property(t => t.A1_NOME).HasColumnName("A1_NOME");
            this.Property(t => t.A1_PESSOA).HasColumnName("A1_PESSOA");
            this.Property(t => t.A1_NREDUZ).HasColumnName("A1_NREDUZ");
            this.Property(t => t.A1_END).HasColumnName("A1_END");
            this.Property(t => t.A1_BAIRRO).HasColumnName("A1_BAIRRO");
            this.Property(t => t.A1_TIPO).HasColumnName("A1_TIPO");
            this.Property(t => t.A1_EST).HasColumnName("A1_EST");
            this.Property(t => t.A1_ESTADO).HasColumnName("A1_ESTADO");
            this.Property(t => t.A1_CEP).HasColumnName("A1_CEP");
            this.Property(t => t.A1_COD_MUN).HasColumnName("A1_COD_MUN");
            this.Property(t => t.A1_MUN).HasColumnName("A1_MUN");
            this.Property(t => t.A1_REGIAO).HasColumnName("A1_REGIAO");
            this.Property(t => t.A1_DSCREG).HasColumnName("A1_DSCREG");
            this.Property(t => t.A1_NATUREZ).HasColumnName("A1_NATUREZ");
            this.Property(t => t.A1_IBGE).HasColumnName("A1_IBGE");
            this.Property(t => t.A1_ENDCOB).HasColumnName("A1_ENDCOB");
            this.Property(t => t.A1_DDI).HasColumnName("A1_DDI");
            this.Property(t => t.A1_DDD).HasColumnName("A1_DDD");
            this.Property(t => t.A1_ENDREC).HasColumnName("A1_ENDREC");
            this.Property(t => t.A1_ENDENT).HasColumnName("A1_ENDENT");
            this.Property(t => t.A1_TEL).HasColumnName("A1_TEL");
            this.Property(t => t.A1_TRIBFAV).HasColumnName("A1_TRIBFAV");
            this.Property(t => t.A1_CONTATO).HasColumnName("A1_CONTATO");
            this.Property(t => t.A1_FAX).HasColumnName("A1_FAX");
            this.Property(t => t.A1_CGC).HasColumnName("A1_CGC");
            this.Property(t => t.A1_TELEX).HasColumnName("A1_TELEX");
            this.Property(t => t.A1_PFISICA).HasColumnName("A1_PFISICA");
            this.Property(t => t.A1_INSCR).HasColumnName("A1_INSCR");
            this.Property(t => t.A1_INSCRM).HasColumnName("A1_INSCRM");
            this.Property(t => t.A1_PAIS).HasColumnName("A1_PAIS");
            this.Property(t => t.A1_VEND).HasColumnName("A1_VEND");
            this.Property(t => t.A1_COMIS).HasColumnName("A1_COMIS");
            this.Property(t => t.A1_CONTA).HasColumnName("A1_CONTA");
            this.Property(t => t.A1_BCO1).HasColumnName("A1_BCO1");
            this.Property(t => t.A1_BCO2).HasColumnName("A1_BCO2");
            this.Property(t => t.A1_BCO3).HasColumnName("A1_BCO3");
            this.Property(t => t.A1_BCO4).HasColumnName("A1_BCO4");
            this.Property(t => t.A1_BCO5).HasColumnName("A1_BCO5");
            this.Property(t => t.A1_TRANSP).HasColumnName("A1_TRANSP");
            this.Property(t => t.A1_TPFRET).HasColumnName("A1_TPFRET");
            this.Property(t => t.A1_COND).HasColumnName("A1_COND");
            this.Property(t => t.A1_DESC).HasColumnName("A1_DESC");
            this.Property(t => t.A1_PRIOR).HasColumnName("A1_PRIOR");
            this.Property(t => t.A1_RISCO).HasColumnName("A1_RISCO");
            this.Property(t => t.A1_LC).HasColumnName("A1_LC");
            this.Property(t => t.A1_VENCLC).HasColumnName("A1_VENCLC");
            this.Property(t => t.A1_CLASSE).HasColumnName("A1_CLASSE");
            this.Property(t => t.A1_LCFIN).HasColumnName("A1_LCFIN");
            this.Property(t => t.A1_MOEDALC).HasColumnName("A1_MOEDALC");
            this.Property(t => t.A1_MSALDO).HasColumnName("A1_MSALDO");
            this.Property(t => t.A1_MCOMPRA).HasColumnName("A1_MCOMPRA");
            this.Property(t => t.A1_METR).HasColumnName("A1_METR");
            this.Property(t => t.A1_PRICOM).HasColumnName("A1_PRICOM");
            this.Property(t => t.A1_ULTCOM).HasColumnName("A1_ULTCOM");
            this.Property(t => t.A1_NROCOM).HasColumnName("A1_NROCOM");
            this.Property(t => t.A1_FORMVIS).HasColumnName("A1_FORMVIS");
            this.Property(t => t.A1_TEMVIS).HasColumnName("A1_TEMVIS");
            this.Property(t => t.A1_ULTVIS).HasColumnName("A1_ULTVIS");
            this.Property(t => t.A1_TMPVIS).HasColumnName("A1_TMPVIS");
            this.Property(t => t.A1_TMPSTD).HasColumnName("A1_TMPSTD");
            this.Property(t => t.A1_CLASVEN).HasColumnName("A1_CLASVEN");
            this.Property(t => t.A1_MENSAGE).HasColumnName("A1_MENSAGE");
            this.Property(t => t.A1_SALDUP).HasColumnName("A1_SALDUP");
            this.Property(t => t.A1_RECISS).HasColumnName("A1_RECISS");
            this.Property(t => t.A1_SALPEDL).HasColumnName("A1_SALPEDL");
            this.Property(t => t.A1_NROPAG).HasColumnName("A1_NROPAG");
            this.Property(t => t.A1_TRANSF).HasColumnName("A1_TRANSF");
            this.Property(t => t.A1_SUFRAMA).HasColumnName("A1_SUFRAMA");
            this.Property(t => t.A1_ATR).HasColumnName("A1_ATR");
            this.Property(t => t.A1_VACUM).HasColumnName("A1_VACUM");
            this.Property(t => t.A1_SALPED).HasColumnName("A1_SALPED");
            this.Property(t => t.A1_TITPROT).HasColumnName("A1_TITPROT");
            this.Property(t => t.A1_DTULTIT).HasColumnName("A1_DTULTIT");
            this.Property(t => t.A1_CHQDEVO).HasColumnName("A1_CHQDEVO");
            this.Property(t => t.A1_DTULCHQ).HasColumnName("A1_DTULCHQ");
            this.Property(t => t.A1_MATR).HasColumnName("A1_MATR");
            this.Property(t => t.A1_MAIDUPL).HasColumnName("A1_MAIDUPL");
            this.Property(t => t.A1_TABELA).HasColumnName("A1_TABELA");
            this.Property(t => t.A1_INCISS).HasColumnName("A1_INCISS");
            this.Property(t => t.A1_SALDUPM).HasColumnName("A1_SALDUPM");
            this.Property(t => t.A1_PAGATR).HasColumnName("A1_PAGATR");
            this.Property(t => t.A1_CXPOSTA).HasColumnName("A1_CXPOSTA");
            this.Property(t => t.A1_ATIVIDA).HasColumnName("A1_ATIVIDA");
            this.Property(t => t.A1_CARGO1).HasColumnName("A1_CARGO1");
            this.Property(t => t.A1_CARGO2).HasColumnName("A1_CARGO2");
            this.Property(t => t.A1_CARGO3).HasColumnName("A1_CARGO3");
            this.Property(t => t.A1_SUPER).HasColumnName("A1_SUPER");
            this.Property(t => t.A1_RTEC).HasColumnName("A1_RTEC");
            this.Property(t => t.A1_ALIQIR).HasColumnName("A1_ALIQIR");
            this.Property(t => t.A1_RG).HasColumnName("A1_RG");
            this.Property(t => t.A1_OBSERV).HasColumnName("A1_OBSERV");
            this.Property(t => t.A1_CALCSUF).HasColumnName("A1_CALCSUF");
            this.Property(t => t.A1_DTNASC).HasColumnName("A1_DTNASC");
            this.Property(t => t.A1_SALPEDB).HasColumnName("A1_SALPEDB");
            this.Property(t => t.A1_CLIFAT).HasColumnName("A1_CLIFAT");
            this.Property(t => t.A1_GRPTRIB).HasColumnName("A1_GRPTRIB");
            this.Property(t => t.A1_BAIRROC).HasColumnName("A1_BAIRROC");
            this.Property(t => t.A1_CEPC).HasColumnName("A1_CEPC");
            this.Property(t => t.A1_MUNC).HasColumnName("A1_MUNC");
            this.Property(t => t.A1_ESTC).HasColumnName("A1_ESTC");
            this.Property(t => t.A1_CEPE).HasColumnName("A1_CEPE");
            this.Property(t => t.A1_BAIRROE).HasColumnName("A1_BAIRROE");
            this.Property(t => t.A1_MUNE).HasColumnName("A1_MUNE");
            this.Property(t => t.A1_ESTE).HasColumnName("A1_ESTE");
            this.Property(t => t.A1_SATIV1).HasColumnName("A1_SATIV1");
            this.Property(t => t.A1_SATIV2).HasColumnName("A1_SATIV2");
            this.Property(t => t.A1_CODLOC).HasColumnName("A1_CODLOC");
            this.Property(t => t.A1_TPISSRS).HasColumnName("A1_TPISSRS");
            this.Property(t => t.A1_CODPAIS).HasColumnName("A1_CODPAIS");
            this.Property(t => t.A1_TPESSOA).HasColumnName("A1_TPESSOA");
            this.Property(t => t.A1_SATIV3).HasColumnName("A1_SATIV3");
            this.Property(t => t.A1_SATIV4).HasColumnName("A1_SATIV4");
            this.Property(t => t.A1_SATIV5).HasColumnName("A1_SATIV5");
            this.Property(t => t.A1_SATIV6).HasColumnName("A1_SATIV6");
            this.Property(t => t.A1_SATIV7).HasColumnName("A1_SATIV7");
            this.Property(t => t.A1_SATIV8).HasColumnName("A1_SATIV8");
            this.Property(t => t.A1_CODMARC).HasColumnName("A1_CODMARC");
            this.Property(t => t.A1_CODAGE).HasColumnName("A1_CODAGE");
            this.Property(t => t.A1_COMAGE).HasColumnName("A1_COMAGE");
            this.Property(t => t.A1_TIPCLI).HasColumnName("A1_TIPCLI");
            this.Property(t => t.A1_EMAIL).HasColumnName("A1_EMAIL");
            this.Property(t => t.A1_DEST_1).HasColumnName("A1_DEST_1");
            this.Property(t => t.A1_DEST_2).HasColumnName("A1_DEST_2");
            this.Property(t => t.A1_CODMUN).HasColumnName("A1_CODMUN");
            this.Property(t => t.A1_HPAGE).HasColumnName("A1_HPAGE");
            this.Property(t => t.A1_DEST_3).HasColumnName("A1_DEST_3");
            this.Property(t => t.A1_CBO).HasColumnName("A1_CBO");
            this.Property(t => t.A1_CNAE).HasColumnName("A1_CNAE");
            this.Property(t => t.A1_CONDPAG).HasColumnName("A1_CONDPAG");
            this.Property(t => t.A1_DIASPAG).HasColumnName("A1_DIASPAG");
            this.Property(t => t.A1_OBS).HasColumnName("A1_OBS");
            this.Property(t => t.A1_AGREG).HasColumnName("A1_AGREG");
            this.Property(t => t.A1_CODHIST).HasColumnName("A1_CODHIST");
            this.Property(t => t.A1_RECINSS).HasColumnName("A1_RECINSS");
            this.Property(t => t.A1_RECCOFI).HasColumnName("A1_RECCOFI");
            this.Property(t => t.A1_RECCSLL).HasColumnName("A1_RECCSLL");
            this.Property(t => t.A1_RECPIS).HasColumnName("A1_RECPIS");
            this.Property(t => t.A1_TIPPER).HasColumnName("A1_TIPPER");
            this.Property(t => t.A1_SALFIN).HasColumnName("A1_SALFIN");
            this.Property(t => t.A1_SALFINM).HasColumnName("A1_SALFINM");
            this.Property(t => t.A1_CONTAB).HasColumnName("A1_CONTAB");
            this.Property(t => t.A1_B2B).HasColumnName("A1_B2B");
            this.Property(t => t.A1_GRPVEN).HasColumnName("A1_GRPVEN");
            this.Property(t => t.A1_CLICNV).HasColumnName("A1_CLICNV");
            this.Property(t => t.A1_INSCRUR).HasColumnName("A1_INSCRUR");
            this.Property(t => t.A1_MSBLQL).HasColumnName("A1_MSBLQL");
            this.Property(t => t.A1_SITUA).HasColumnName("A1_SITUA");
            this.Property(t => t.A1_NUMRA).HasColumnName("A1_NUMRA");
            this.Property(t => t.A1_SUBCOD).HasColumnName("A1_SUBCOD");
            this.Property(t => t.A1_CDRDES).HasColumnName("A1_CDRDES");
            this.Property(t => t.A1_FILDEB).HasColumnName("A1_FILDEB");
            this.Property(t => t.A1_CODFOR).HasColumnName("A1_CODFOR");
            this.Property(t => t.A1_ABICS).HasColumnName("A1_ABICS");
            this.Property(t => t.A1_BLEMAIL).HasColumnName("A1_BLEMAIL");
            this.Property(t => t.A1_TIPOCLI).HasColumnName("A1_TIPOCLI");
            this.Property(t => t.A1_VINCULO).HasColumnName("A1_VINCULO");
            this.Property(t => t.A1_DTINIV).HasColumnName("A1_DTINIV");
            this.Property(t => t.A1_DTFIMV).HasColumnName("A1_DTFIMV");
            this.Property(t => t.A1_LOCCONS).HasColumnName("A1_LOCCONS");
            this.Property(t => t.A1_CODMUNE).HasColumnName("A1_CODMUNE");
            this.Property(t => t.A1_PERFIL).HasColumnName("A1_PERFIL");
            this.Property(t => t.A1_HRTRANS).HasColumnName("A1_HRTRANS");
            this.Property(t => t.A1_UNIDVEN).HasColumnName("A1_UNIDVEN");
            this.Property(t => t.A1_TIPPRFL).HasColumnName("A1_TIPPRFL");
            this.Property(t => t.A1_PRF_VLD).HasColumnName("A1_PRF_VLD");
            this.Property(t => t.A1_PRF_COD).HasColumnName("A1_PRF_COD");
            this.Property(t => t.A1_REGPB).HasColumnName("A1_REGPB");
            this.Property(t => t.A1_USADDA).HasColumnName("A1_USADDA");
            this.Property(t => t.A1_SIMPLES).HasColumnName("A1_SIMPLES");
            this.Property(t => t.A1_CTARE).HasColumnName("A1_CTARE");
            this.Property(t => t.A1_FRETISS).HasColumnName("A1_FRETISS");
            this.Property(t => t.A1_CODSIAF).HasColumnName("A1_CODSIAF");
            this.Property(t => t.A1_CEINSS).HasColumnName("A1_CEINSS");
            this.Property(t => t.A1_REGESIM).HasColumnName("A1_REGESIM");
            this.Property(t => t.A1_IPWEB).HasColumnName("A1_IPWEB");
            this.Property(t => t.A1_PERCATM).HasColumnName("A1_PERCATM");
            this.Property(t => t.A1_IRBAX).HasColumnName("A1_IRBAX");
            this.Property(t => t.A1_ENDNOT).HasColumnName("A1_ENDNOT");
            this.Property(t => t.A1_RESERVE).HasColumnName("A1_RESERVE");
            this.Property(t => t.A1_NIF).HasColumnName("A1_NIF");
            this.Property(t => t.A1_IDHIST).HasColumnName("A1_IDHIST");
            this.Property(t => t.A1_INDRET).HasColumnName("A1_INDRET");
            this.Property(t => t.A1_ABATIMP).HasColumnName("A1_ABATIMP");
            this.Property(t => t.A1_CONTRIB).HasColumnName("A1_CONTRIB");
            this.Property(t => t.A1_INCULT).HasColumnName("A1_INCULT");
            this.Property(t => t.A1_TDA).HasColumnName("A1_TDA");
            this.Property(t => t.A1_ORIGEM).HasColumnName("A1_ORIGEM");
            this.Property(t => t.A1_ENTID).HasColumnName("A1_ENTID");
            this.Property(t => t.A1_MINIRF).HasColumnName("A1_MINIRF");
            this.Property(t => t.A1_TIMEKEE).HasColumnName("A1_TIMEKEE");
            this.Property(t => t.A1_RECIRRF).HasColumnName("A1_RECIRRF");
            this.Property(t => t.A1_COMPLEM).HasColumnName("A1_COMPLEM");
            this.Property(t => t.A1_MATFUN).HasColumnName("A1_MATFUN");
            this.Property(t => t.A1_FILTRF).HasColumnName("A1_FILTRF");
            this.Property(t => t.A1_FOMEZER).HasColumnName("A1_FOMEZER");
            this.Property(t => t.A1_CODFID).HasColumnName("A1_CODFID");
            this.Property(t => t.A1_SIMPNAC).HasColumnName("A1_SIMPNAC");
            this.Property(t => t.A1_ALIFIXA).HasColumnName("A1_ALIFIXA");
            this.Property(t => t.A1_RFABOV).HasColumnName("A1_RFABOV");
            this.Property(t => t.A1_TPDP).HasColumnName("A1_TPDP");
            this.Property(t => t.A1_PERFECP).HasColumnName("A1_PERFECP");
            this.Property(t => t.A1_RFACS).HasColumnName("A1_RFACS");
            this.Property(t => t.A1_TPJ).HasColumnName("A1_TPJ");
            this.Property(t => t.A1_CRDMA).HasColumnName("A1_CRDMA");
            this.Property(t => t.A1_PRSTSER).HasColumnName("A1_PRSTSER");
            this.Property(t => t.A1_RECFET).HasColumnName("A1_RECFET");
            this.Property(t => t.A1_IENCONT).HasColumnName("A1_IENCONT");
            this.Property(t => t.A1_ORIGCT).HasColumnName("A1_ORIGCT");
            this.Property(t => t.A1_HRCAD).HasColumnName("A1_HRCAD");
            this.Property(t => t.A1_ENTORI).HasColumnName("A1_ENTORI");
            this.Property(t => t.A1_DTCAD).HasColumnName("A1_DTCAD");
            this.Property(t => t.A1_IMGUMOV).HasColumnName("A1_IMGUMOV");
            this.Property(t => t.A1_RESFAT).HasColumnName("A1_RESFAT");
            this.Property(t => t.A1_IDESTN).HasColumnName("A1_IDESTN");
            this.Property(t => t.A1_NVESTN).HasColumnName("A1_NVESTN");
            this.Property(t => t.A1_CLIPRI).HasColumnName("A1_CLIPRI");
            this.Property(t => t.A1_LOJPRI).HasColumnName("A1_LOJPRI");
            this.Property(t => t.A1_TPCAMP).HasColumnName("A1_TPCAMP");
            this.Property(t => t.A1_CHVCAM).HasColumnName("A1_CHVCAM");
            this.Property(t => t.A1_INOVAUT).HasColumnName("A1_INOVAUT");
            this.Property(t => t.A1_TPNFSE).HasColumnName("A1_TPNFSE");
            this.Property(t => t.A1_OUTRMUN).HasColumnName("A1_OUTRMUN");
            this.Property(t => t.A1_CODSEG).HasColumnName("A1_CODSEG");
            this.Property(t => t.A1_TPREG).HasColumnName("A1_TPREG");
            this.Property(t => t.A1_MSEXP).HasColumnName("A1_MSEXP");
            this.Property(t => t.A1_ISSRSLC).HasColumnName("A1_ISSRSLC");
            this.Property(t => t.A1_USERLGA).HasColumnName("A1_USERLGA");
            this.Property(t => t.A1_HREXPO).HasColumnName("A1_HREXPO");
            this.Property(t => t.A1_USERLGI).HasColumnName("A1_USERLGI");
            this.Property(t => t.A1_TPMEMB).HasColumnName("A1_TPMEMB");
            this.Property(t => t.A1_CODTER).HasColumnName("A1_CODTER");
            this.Property(t => t.A1_CODMEMB).HasColumnName("A1_CODMEMB");
            this.Property(t => t.A1_SANGUE).HasColumnName("A1_SANGUE");
            this.Property(t => t.A1_CONT).HasColumnName("A1_CONT");
            this.Property(t => t.A1_R_G).HasColumnName("A1_R_G");
            this.Property(t => t.A1_SOC_A).HasColumnName("A1_SOC_A");
            this.Property(t => t.A1_SOC_B).HasColumnName("A1_SOC_B");
            this.Property(t => t.A1_SOC_C).HasColumnName("A1_SOC_C");
            this.Property(t => t.A1_SOC_D).HasColumnName("A1_SOC_D");
            this.Property(t => t.A1_SOC_E).HasColumnName("A1_SOC_E");
            this.Property(t => t.A1_BAIRCOB).HasColumnName("A1_BAIRCOB");
            this.Property(t => t.A1_MUNCOB).HasColumnName("A1_MUNCOB");
            this.Property(t => t.A1_ESTCOB).HasColumnName("A1_ESTCOB");
            this.Property(t => t.A1_CEPCOB).HasColumnName("A1_CEPCOB");
            this.Property(t => t.A1_EBAIRRO).HasColumnName("A1_EBAIRRO");
            this.Property(t => t.A1_EMUN).HasColumnName("A1_EMUN");
            this.Property(t => t.A1_EEST).HasColumnName("A1_EEST");
            this.Property(t => t.A1_ECEP).HasColumnName("A1_ECEP");
            this.Property(t => t.A1_VEND2).HasColumnName("A1_VEND2");
            this.Property(t => t.A1_EMISSAO).HasColumnName("A1_EMISSAO");
            this.Property(t => t.A1_LEASING).HasColumnName("A1_LEASING");
            this.Property(t => t.A1_MIDIA).HasColumnName("A1_MIDIA");
            this.Property(t => t.A1_PRZMAXD).HasColumnName("A1_PRZMAXD");
            this.Property(t => t.D_E_L_E_T_).HasColumnName("D_E_L_E_T_");
            this.Property(t => t.R_E_C_N_O_).HasColumnName("R_E_C_N_O_");
            this.Property(t => t.R_E_C_D_E_L_).HasColumnName("R_E_C_D_E_L_");
            this.Property(t => t.A1_INDUSTR).HasColumnName("A1_INDUSTR");
            this.Property(t => t.A1_XCTSUP).HasColumnName("A1_XCTSUP");
            this.Property(t => t.A1_XESUP).HasColumnName("A1_XESUP");
            this.Property(t => t.A1_XT1SUP).HasColumnName("A1_XT1SUP");
            this.Property(t => t.A1_XCELSUP).HasColumnName("A1_XCELSUP");
            this.Property(t => t.A1_XT2SUP).HasColumnName("A1_XT2SUP");
            this.Property(t => t.A1_XCTMAQ).HasColumnName("A1_XCTMAQ");
            this.Property(t => t.A1_XEMAQ).HasColumnName("A1_XEMAQ");
            this.Property(t => t.A1_XT1MAQ).HasColumnName("A1_XT1MAQ");
            this.Property(t => t.A1_XT2MAQ).HasColumnName("A1_XT2MAQ");
            this.Property(t => t.A1_CELMAQ).HasColumnName("A1_CELMAQ");
        }
    }
}
