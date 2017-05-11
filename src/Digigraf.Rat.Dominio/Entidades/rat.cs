using Digigraf.Rat.Dominio.Validations.Rat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Dominio.Entidades
{
    public class rat : DadosPadroes
    {
        public rat()
        {
            this.desrats = new List<desrat>();
            this.prodrats = new List<prodrat>();
            this.ratorcs = new List<ratorc>();
        }

        public int cod_rat { get; set; }
        public string a1_cod { get; set; }
        public int cod_ate { get; set; }
        public int cod_tec { get; set; }
        public string dt_rat { get; set; }
        public string hr_rat { get; set; }
        public string dt_vis_rat { get; set; }
        public string hr_vis_rat { get; set; }
        public string hr_vis_fim_rat { get; set; }
        public string tipo_rat { get; set; }
        public string tipo_o_rat { get; set; }
        public string local_rat { get; set; }
        public string f1_doc { get; set; }
        public string f2_doc { get; set; }
        public string b1_cod { get; set; }
        public string vencto_rat { get; set; }
        public string n_serie_exp { get; set; }
        public string fechado_rat { get; set; }
        public Nullable<decimal> valor_rat { get; set; }
        public Nullable<decimal> m_obra_rat { get; set; }
        public string defeito_rat { get; set; }
        public string c5_num { get; set; }
        public string obs_rat { get; set; }
        public Nullable<int> cod_gru { get; set; }
        public string inst_sw { get; set; }
        public string def_diag_rat { get; set; }
        public string descricao { get; set; }
        public string chamado { get; set; }
        public string c5_nac { get; set; }
        public string dt_abre_cham { get; set; }
        public string dt_fecha_cham { get; set; }
        public string dt_abre_cham_hp { get; set; }
        public string dt_fecha_cham_hp { get; set; }
        public string hr_abre_cham_hp { get; set; }
        public string hr_fecha_cham_hp { get; set; }
        public string solucao { get; set; }
        public string severidade { get; set; }
        public Nullable<double> km_cli_rat { get; set; }
        public string empresa { get; set; }
        public string tp_serv_rat { get; set; }
        public string obj_serv_rat { get; set; }
        public string tp_cobranca { get; set; }
        public string entregue_rat { get; set; }
        public string email_cli_rat { get; set; }
        public string envia_email_remoto { get; set; }
        public string bloqueio_des { get; set; }
        public string pendencia_rat { get; set; }
        public string data_email { get; set; }
        public virtual atendente atendente { get; set; }
        public virtual ICollection<desrat> desrats { get; set; }
        public virtual ICollection<prodrat> prodrats { get; set; }
        public virtual tecnico tecnico { get; set; }
        public virtual ICollection<ratorc> ratorcs { get; set; }

        public bool Ativo { get; set; }
        public string Mensagem { get; set; }


        public bool IsValid()
        {
            ResultadoValidacao = new RatEstaConsistenteValidation().Validar(this);
            return ResultadoValidacao.IsValid;
        }
    }

 

}
