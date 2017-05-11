using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Dominio.Entidades
{
    public  class desrat
    {
        public int cod_des { get; set; }
        public Nullable<int> cod_rat { get; set; }
        public string despesa_des { get; set; }
        public Nullable<double> quant_des { get; set; }
        public Nullable<double> valor_des { get; set; }
        public string ok_des { get; set; }
        public string tipo_des { get; set; }
        public string obj_des { get; set; }
        public string dtprev_des { get; set; }
        public string delet_des { get; set; }
        public string data_des { get; set; }
        public string tp_des { get; set; }
        public Nullable<int> cod_tec { get; set; }
        public virtual rat rat { get; set; }
    }
}
