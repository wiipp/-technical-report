using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Dominio.Entidades
{
    public class prodrat
    {
        public int cod_pro { get; set; }
        public Nullable<int> cod_rat { get; set; }
        public string b1_cod { get; set; }
        public Nullable<double> quant_pro { get; set; }
        public Nullable<double> valor_pro { get; set; }
        public string data_pro { get; set; }
        public string estorno_pro { get; set; }
        public string transf_pro { get; set; }
        public string dttransf_pro { get; set; }
        public string descri_pro { get; set; }
        public string status_pro { get; set; }
        public string c5_num_pro { get; set; }
        public string obs { get; set; }
        public string rem_nf_pro { get; set; }
        public string nac_nf_pro { get; set; }
        public string obs_est_pro { get; set; }
        public Nullable<int> status_aprov { get; set; }
        public string est_ori_pro { get; set; }
        public string est_dest_pro { get; set; }
        public string d3_doc { get; set; }
        public string random { get; set; }
        public string delet_pro { get; set; }
        public string situacao_pro { get; set; }
        public virtual rat rat { get; set; }
    }
}
