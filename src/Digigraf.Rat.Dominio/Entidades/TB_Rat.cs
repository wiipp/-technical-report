using Digigraf.Rat.Dominio.Validations.Rat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digigraf.Rat.Infra.CrossCutting.Specifications.Validation;

namespace Digigraf.Rat.Dominio.Entidades
{
    public class TB_Rat : DadosPadroes
    {
        public int Cod_Rat { get; set; }
        public string A1_Cod { get; set; }
        public DateTime Dt_Rat { get; set; }
        public DateTime Dt_Vis_Rat { get; set; }
        public string Dt_Fecha_Cham { get; set; }
        public string Dt_Abre_Cham_Hp { get; set; }
        public string Dt_Fecha_Cham_Hp { get; set; }
        public string Hr_Abre_Cham_Hp { get; set; }
        public string Hr_Fecha_Cham_Hp { get; set; }
        public string Solucao { get; set; }
        public string Severidade { get; set; }
        public string Hr_Rat { get; set; }
        public DateTime Hr_Vis_Rat { get; set; }
        public DateTime Hr_Vis_Fim_Rat { get; set; }
        public string N_Serie_Exp { get; set; }
        public string F1_Doc { get; set; }
        public string F2_Doc { get; set; }        
        public string TecnicoId { get; set; }
        public string Tipo_Rat { get; set; }
        public string Descricao { get; set; }
        public string B1_Cod { get; set; }
        public string C5_Nac { get; set; }
        public string Tipo_o_Rat { get; set; }
        public string Chamado { get; set; }
        public string Local_Rat { get; set; }
        public string Defeito_Rat { get; set; }
        public string Def_Diag_Rat { get; set; }
        public decimal Valor_Rat { get; set; }
        public decimal M_Obra_Rat { get; set; }
        public string C5_Num { get; set; }
        public decimal Km_Cli_Rat { get; set; }
        public string Inst_Sw { get; set; }
        public string Obs_Rat { get; set; }
        public string Empresa { get; set; }
        public string Tp_Serv_Rat { get; set; }
        public string Entregue_Rat { get; set; }
        public string Data_Email { get; set; }
        public string Email_Cli_Rat { get; set; }
        public string Pendencia_Rat { get; set; }
        public bool Ativo { get; set; }
        public string Mensagem { get; set; }
        public string GrupoId { get; set; }
        public string AtendenteId { get; set; }
        public string DescGrupo { get; set; }        
        public string DescAtendente { get; set; }        
        public string DescTecnico { get; set; }



        //public DateTime DataCadastro { get; set; }

        //public bool IsValid()
        //{
        //    ResultadoValidacao = new RatEstaConsistenteValidation().Validar(this);
        //    return ResultadoValidacao.IsValid;
        //}
    }

 

}
